﻿using System;
using System.Collections.Generic;
using System.Text;
using RepositoryCompiler.Communication;
using RepositoryCompilerTests.DataFactories;
using Shouldly;
using Xunit;

namespace RepositoryCompilerTests.Unit
{
    public class RepositoryCompilerAMQPTests
    {
        private readonly MetricsReportFactory _metricsReportFactory = new MetricsReportFactory();

        // TODO: Remove this before completing the PR, since this is not an actual test
        [Fact]
        public void Produce_Metrics_Report_Message()
        {
            MessageProducer  producer = new MessageProducer();
            CaDETClassDTO reportMessage = _metricsReportFactory.CreateMockupMetricsReportMessage();
            producer.CreateNewMetricsReport(reportMessage);
        }
    }
}
