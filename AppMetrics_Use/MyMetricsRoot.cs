using System.Collections.Generic;
using App.Metrics;
using App.Metrics.Filters;
using App.Metrics.Formatters;
using App.Metrics.Infrastructure;
using App.Metrics.Reporting;

namespace AppMetrics_Use
{
    internal class MyMetricsRoot : IMetricsRoot
    {
        public IReadOnlyCollection<IMetricsOutputFormatter> OutputMetricsFormatters => throw new System.NotImplementedException();

        public IMetricsOutputFormatter DefaultOutputMetricsFormatter => throw new System.NotImplementedException();

        public IEnvOutputFormatter DefaultOutputEnvFormatter => throw new System.NotImplementedException();

        public IReadOnlyCollection<IEnvOutputFormatter> OutputEnvFormatters => throw new System.NotImplementedException();

        public IReadOnlyCollection<IReportMetrics> Reporters => throw new System.NotImplementedException();

        public IRunMetricsReports ReportRunner => throw new System.NotImplementedException();

        public MetricsOptions Options => throw new System.NotImplementedException();

        public EnvironmentInfo EnvironmentInfo => throw new System.NotImplementedException();

        public IBuildMetrics Build => throw new System.NotImplementedException();

        public IClock Clock => throw new System.NotImplementedException();

        public IFilterMetrics Filter => throw new System.NotImplementedException();

        public IManageMetrics Manage => throw new System.NotImplementedException();

        public IMeasureMetrics Measure => throw new System.NotImplementedException();

        public IProvideMetrics Provider => throw new System.NotImplementedException();

        public IProvideMetricValues Snapshot => throw new System.NotImplementedException();
    }
}