// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Migrate.Tests.Mock;
using Azure.ResourceManager.Migrate.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Migrate.Tests.Mock.Tests.Mock
{
    /// <summary> Test for ServerCollector. </summary>
    public partial class ServerCollectorCollectionMockTests : MockTestBase
    {
        public ServerCollectorCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: ServerCollectors_Create
            string serverCollectorName = "app23df4collector";
            Migrate.Tests.Mock.ServerCollectorData collectorBody = new Migrate.Tests.Mock.ServerCollectorData()
            {
                ETag = "\"00000606-0000-0d00-0000-605999bf0000\"",
                Properties = new Migrate.Tests.Mock.Models.CollectorProperties()
                {
                    DiscoverySiteId = "/subscriptions/4bd2aa0f-2bd2-4d67-91a8-5a4533d58600/resourceGroups/pajindTest/providers/Microsoft.OffAzure/ServerSites/app21141site",
                    AgentProperties = new Migrate.Tests.Mock.Models.CollectorAgentProperties()
                    {
                        SpnDetails = new Migrate.Tests.Mock.Models.CollectorBodyAgentSpnProperties()
                        {
                            Authority = "https://login.windows.net/72f988bf-86f1-41af-91ab-2d7cd011db47",
                            ApplicationId = "ad9f701a-cc08-4421-b51f-b5762d58e9ba",
                            Audience = "https://72f988bf-86f1-41af-91ab-2d7cd011db47/app23df4authandaccessaadapp",
                            ObjectId = "b4975e42-9248-4a36-b99f-37eca377ea00",
                            TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47",
                        },
                    },
                },
            };

            var projectId = Migrate.Tests.Mock.Project.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "pajindtest", "app11141project");
            var collection = GetArmClient().GetProject(projectId).GetServerCollectors();
            await collection.CreateOrUpdateAsync(true, serverCollectorName, collectorBody);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: ServerCollectors_Get
            string serverCollectorName = "app23df4collector";

            var projectId = Migrate.Tests.Mock.Project.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "pajindtest", "app11141project");
            var collection = GetArmClient().GetProject(projectId).GetServerCollectors();
            await collection.GetAsync(serverCollectorName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: ServerCollectors_ListByProject

            var projectId = Migrate.Tests.Mock.Project.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "pajindtest", "app11141project");
            var collection = GetArmClient().GetProject(projectId).GetServerCollectors();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
