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
    /// <summary> Test for FirewallRule. </summary>
    public partial class FirewallRuleCollectionMockTests : MockTestBase
    {
        public FirewallRuleCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: FirewallRuleCreate
            string firewallRuleName = "rule1";
            PostgreSQL.Tests.Mock.FirewallRuleData parameters = new PostgreSQL.Tests.Mock.FirewallRuleData(startIpAddress: "0.0.0.0", endIpAddress: "255.255.255.255");

            var serverId = PostgreSQL.Tests.Mock.Server.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testserver");
            var collection = GetArmClient().GetServer(serverId).GetFirewallRules();
            await collection.CreateOrUpdateAsync(true, firewallRuleName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: FirewallRuleList
            string firewallRuleName = "rule1";

            var serverId = PostgreSQL.Tests.Mock.Server.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testserver");
            var collection = GetArmClient().GetServer(serverId).GetFirewallRules();
            await collection.GetAsync(firewallRuleName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: FirewallRuleList

            var serverId = PostgreSQL.Tests.Mock.Server.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testserver");
            var collection = GetArmClient().GetServer(serverId).GetFirewallRules();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
