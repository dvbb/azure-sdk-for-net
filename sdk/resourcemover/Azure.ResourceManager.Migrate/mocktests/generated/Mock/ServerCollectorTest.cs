// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Migrate.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Migrate.Tests.Mock.Tests.Mock
{
    /// <summary> Test for ServerCollector. </summary>
    public partial class ServerCollectorMockTests : MockTestBase
    {
        public ServerCollectorMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: ServerCollectors_Get
            var serverCollectorId = Migrate.Tests.Mock.ServerCollector.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "pajindtest", "app11141project", "app23df4collector");
            var serverCollector = GetArmClient().GetServerCollector(serverCollectorId);

            await serverCollector.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: ServerCollectors_Delete
            var serverCollectorId = Migrate.Tests.Mock.ServerCollector.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "pajindtest", "app11141project", "app23df4collector");
            var serverCollector = GetArmClient().GetServerCollector(serverCollectorId);

            await serverCollector.DeleteAsync(true);
        }
    }
}
