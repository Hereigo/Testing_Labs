namespace ZD_ADO_Connector
{
    using System;
    using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
    using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
    using Microsoft.VisualStudio.Services.Common;
    using Microsoft.VisualStudio.Services.WebApi;
    using Microsoft.VisualStudio.Services.WebApi.Patch;
    using Microsoft.VisualStudio.Services.WebApi.Patch.Json;

    public class AdoProcessor
    {
        private readonly string _personalAccessToken;

        private readonly string _project;

        private readonly Uri _uri;

        private readonly VssBasicCredential _credentials;

        private readonly VssConnection _connection;

        public AdoProcessor()
        {
            _uri = new Uri(GIT_IGNORE.Variables.ZdAdoUri);
            _personalAccessToken = GIT_IGNORE.Variables.ZdAdoPat;
            _project = GIT_IGNORE.Variables.ZdAdoProject;
            _credentials = new VssBasicCredential(string.Empty, _personalAccessToken);
            _connection = new VssConnection(_uri, _credentials);
        }

        public WorkItem CreateIssueUsingClientLib()
        {
            const string newItemType = "Issue";

            JsonPatchDocument patchDocument = JsonPatchDocumentToCreateOrUpdate();

            WorkItemTrackingHttpClient workItemTrackingHttpClient = _connection.GetClient<WorkItemTrackingHttpClient>();

            try
            {
                WorkItem result = workItemTrackingHttpClient.CreateWorkItemAsync(patchDocument, _project, newItemType).Result;

                Console.WriteLine($"{newItemType} Successfully Created : {newItemType} #{result.Id}");

                return result;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Error creating {newItemType} : {ex.InnerException.Message}");
                return null;
            }
        }

        private JsonPatchDocument JsonPatchDocumentToCreateOrUpdate()
        {
            return new JsonPatchDocument
            {
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = Strings.operationTitle,
                    Value = "Bla-bla-bla New Task."
                },
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = Strings.operationReproSteps,
                    Value = "Our authorization logic needs to allow for users with Microsoft accounts (formerly Live Ids) - http:// msdn.microsoft.com/library/live/hh826547.aspx"
                },
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = Strings.operationPriority,
                    Value = "1"
                },
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = Strings.operationSeverity,
                    Value = "2 - High"
                }
            };
        }

        public WorkItem UpdateWorkItemAsyncUsingClientLib(int itemIdToUpdate)
        {
            JsonPatchDocument patchDocument = JsonPatchDocumentToCreateOrUpdate();

            WorkItemTrackingHttpClient workItemTrackingHttpClient = _connection.GetClient<WorkItemTrackingHttpClient>();

            try
            {
                WorkItem result = workItemTrackingHttpClient.UpdateWorkItemAsync(patchDocument, itemIdToUpdate).Result;

                Console.WriteLine($"Item #{itemIdToUpdate} Successfully Updated : Item #{result.Id}");

                return result;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Error updating Item #{itemIdToUpdate} : {ex.InnerException.Message}");
                return null;
            }
        }
    }
}