// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.PostgreSQL.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.PostgreSQL.Tests.Mock.Tests.Mock
{
    /// <summary> Test for Configuration. </summary>
    public partial class ConfigurationCollectionMockTests : MockTestBase
    {
        public ConfigurationCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Update a user configuration
            string configurationName = "event_scheduler";
            PostgreSQL.Tests.Mock.ConfigurationData parameters = new PostgreSQL.Tests.Mock.ConfigurationData()
            {
                Value = "on",
                Source = "user-override",
            };

            var serverId = PostgreSQL.Tests.Mock.Server.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testserver");
            var collection = GetArmClient().GetServer(serverId).GetConfigurations();
            await collection.CreateOrUpdateAsync(true, configurationName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: ConfigurationGet
            string configurationName = "array_nulls";

            var serverId = PostgreSQL.Tests.Mock.Server.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testserver");
            var collection = GetArmClient().GetServer(serverId).GetConfigurations();
            await collection.GetAsync(configurationName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: ConfigurationList

            var serverId = PostgreSQL.Tests.Mock.Server.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testserver");
            var collection = GetArmClient().GetServer(serverId).GetConfigurations();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
