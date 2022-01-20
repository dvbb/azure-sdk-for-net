// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Logz.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Logz.Tests.Mock.Tests.Mock
{
    /// <summary> Test for MonitoringTagRules. </summary>
    public partial class MonitorAccountTagRuleCollectionMockTests : MockTestBase
    {
        public MonitorAccountTagRuleCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: SubAccountTagRules_CreateOrUpdate
            string ruleSetName = "default";
            Logz.Tests.Mock.MonitoringTagRulesData body = null;

            var monitorAccountId = Logz.Tests.Mock.MonitorAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myMonitor", "SubAccount1");
            var collection = GetArmClient().GetMonitorAccount(monitorAccountId).GetMonitorAccountTagRules();
            await collection.CreateOrUpdateAsync(true, ruleSetName, body);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: SubAccountTagRules_Get
            string ruleSetName = "default";

            var monitorAccountId = Logz.Tests.Mock.MonitorAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myMonitor", "SubAccount1");
            var collection = GetArmClient().GetMonitorAccount(monitorAccountId).GetMonitorAccountTagRules();
            await collection.GetAsync(ruleSetName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: SubAccountTagRules_List

            var monitorAccountId = Logz.Tests.Mock.MonitorAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myMonitor", "SubAccount1");
            var collection = GetArmClient().GetMonitorAccount(monitorAccountId).GetMonitorAccountTagRules();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
