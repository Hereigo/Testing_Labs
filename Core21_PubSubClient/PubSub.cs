using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Cloud.PubSub.V1;

namespace Core21_PubSubClient
{
	internal class PubSub
	{
		private static string GetEnvVar(string name)
		{
			string value = Environment.GetEnvironmentVariable(name);

			return !string.IsNullOrWhiteSpace(value) ? value
				   : throw new InvalidOperationException($"Environment variable {name} has no valid value [is empty]");
		}

		private static string PubSubTaskerCreds => GetEnvVar("GOOGLE_APPLICATION_CREDENTIALS");
		private static string ProjectId => GetEnvVar("GOOGLE_APPLICATION_PROJECT");
		private static string TopicId => GetEnvVar("GOOGLE_APPLICATION_TOPIC");
		private static string SubscriptionId => GetEnvVar("GOOGLE_APPLICATION_SUBSCRIPTION");

		internal async Task ClientAsync()
		{
			// First create a topic :
			PublisherServiceApiClient publisherService = await PublisherServiceApiClient.CreateAsync().ConfigureAwait(false);
			TopicName topicName = new TopicName(ProjectId, TopicId);
			// publisherService.CreateTopic(topicName);

			// Subscribe to the topic :
			SubscriberServiceApiClient subscriberService = await SubscriberServiceApiClient.CreateAsync().ConfigureAwait(false);
			SubscriptionName subscriptionName = new SubscriptionName(ProjectId, SubscriptionId);
			// subscriberService.CreateSubscription(subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: 60);

			// Publish a message to the topic :
			PublisherClient publisher = await PublisherClient.CreateAsync(topicName).ConfigureAwait(false);
			// PublishAsync() has various overloads. Here we're using the string overload.
			string messageId = await publisher.PublishAsync("Hello, Pubsub").ConfigureAwait(false);

			// PublisherClient instance should be shutdown after use :
			// The TimeSpan specifies for how long to attempt to publish locally queued messages.
			await publisher.ShutdownAsync(TimeSpan.FromSeconds(15)).ConfigureAwait(false);

			// Pull messages from the subscription :
			SubscriberClient subscriber = await SubscriberClient.CreateAsync(subscriptionName).ConfigureAwait(false);
			List<PubsubMessage> receivedMessages = new List<PubsubMessage>();

			// Start the subscriber listening for messages.
			await subscriber.StartAsync((msg, cancellationToken) =>
			{
				receivedMessages.Add(msg);
				Console.WriteLine($"Received message {msg.MessageId} published at {msg.PublishTime.ToDateTime()}");
				Console.WriteLine($"Text: '{msg.Data.ToStringUtf8()}'");
				// Stop this subscriber after one message is received :
				// This is non-blocking, and the returned Task may be awaited.
				subscriber.StopAsync(TimeSpan.FromSeconds(15));
				// Return Reply.Ack to indicate this message has been handled.
				return Task.FromResult(SubscriberClient.Reply.Ack);
			})
			.ConfigureAwait(false);

			// Tidy up by deleting the subscription and the topic :
			// subscriberService.DeleteSubscription(subscriptionName);
			// publisherService.DeleteTopic(topicName);
		}
	}
}