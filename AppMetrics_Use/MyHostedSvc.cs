using App.Metrics;
using App.Metrics.Counter;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppMetrics_Use
{
    internal class MyHostedSvc : BackgroundService
    {
        private const int delayBetweenCallsInSec = 3;
        private readonly CounterOptions metrCounter;
        private readonly IMetricsRoot metrics;
        private readonly MetricsDataValueSource snapshot;
        private Timer _timer;

        public MyHostedSvc()
        {
            metrics = new MetricsBuilder().Build();
            metrCounter = new CounterOptions { Name = "AppMetrics_Use" };
            metrics.Measure.Counter.Increment(metrCounter);
            snapshot = metrics.Snapshot.Get(); // filters avilable
        }

        public override void Dispose()
        {
            base.Dispose();
            _timer?.Dispose();
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            System.Console.WriteLine("MyHostedSvc ExecuteAsync() start.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(delayBetweenCallsInSec));

            System.Console.WriteLine("MyHostedSvc ExecuteAsync() end.");

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            // stop timer before execution :
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
            try
            {
                metrics.Measure.Counter.Increment(metrCounter);
                Console.WriteLine("###");
                // TODO :
                // IF - throw new NotImplementedException();
                Task<string> rez = ShowMetrics();
                Console.WriteLine(rez.Result);
            }
            catch (Exception)
            {
                throw;
            }
            // run timer again :
            _timer.Change(TimeSpan.FromSeconds(delayBetweenCallsInSec), TimeSpan.FromSeconds(delayBetweenCallsInSec));
        }

        private async Task<string> ShowMetrics()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                await metrics.DefaultOutputMetricsFormatter.WriteAsync(stream, snapshot);

                return Encoding.UTF8.GetString(stream.ToArray());
                // # TIMESTAMP: 636910200018631835
                // # MEASUREMENT: [Application] AppMetrics_Use
                // # TAGS:
                //                   mtype = counter
                //                    unit = none
                // # FIELDS:
                //                   value = 3
            }
        }
    }
}