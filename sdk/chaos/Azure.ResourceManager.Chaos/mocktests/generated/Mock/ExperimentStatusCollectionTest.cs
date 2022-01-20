// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Chaos.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Chaos.Tests.Mock.Tests.Mock
{
    /// <summary> Test for ExperimentStatus. </summary>
    public partial class ExperimentStatusCollectionMockTests : MockTestBase
    {
        public ExperimentStatusCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get the status of a Experiment.
            string statusId = "50734542-2e64-4e08-814c-cc0e7475f7e4";

            var experimentId = Chaos.Tests.Mock.Experiment.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "exampleRG", "exampleExperiment");
            var collection = GetArmClient().GetExperiment(experimentId).GetExperimentStatuses();
            await collection.GetAsync(statusId);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List all statuses of a Experiment.

            var experimentId = Chaos.Tests.Mock.Experiment.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "exampleRG", "exampleExperiment");
            var collection = GetArmClient().GetExperiment(experimentId).GetExperimentStatuses();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
