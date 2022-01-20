// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Relay.Tests.Mock;
using Azure.ResourceManager.Relay.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Relay.Tests.Mock.Tests.Mock
{
    /// <summary> Test for AuthorizationRule. </summary>
    public partial class NamespaceHybridConnectionAuthorizationRuleCollectionMockTests : MockTestBase
    {
        public NamespaceHybridConnectionAuthorizationRuleCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: RelayHybridConnectionAuthorizationRuleCreate
            string authorizationRuleName = "example-RelayAuthRules-01";
            Relay.Tests.Mock.AuthorizationRuleData parameters = new Relay.Tests.Mock.AuthorizationRuleData(rights: new List<Relay.Tests.Mock.Models.AccessRights>()
{
Relay.Tests.Mock.Models.AccessRights.Listen,Relay.Tests.Mock.Models.AccessRights.Send,});

            var hybridConnectionId = Relay.Tests.Mock.HybridConnection.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourcegroup", "example-RelayNamespace-01", "example-Relay-Hybrid-01");
            var collection = GetArmClient().GetHybridConnection(hybridConnectionId).GetNamespaceHybridConnectionAuthorizationRules();
            await collection.CreateOrUpdateAsync(true, authorizationRuleName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: RelayHybridConnectionAutorizationRuleGet
            string authorizationRuleName = "example-RelayAuthRules-01";

            var hybridConnectionId = Relay.Tests.Mock.HybridConnection.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourcegroup", "example-RelayNamespace-01", "example-Relay-Hybrid-01");
            var collection = GetArmClient().GetHybridConnection(hybridConnectionId).GetNamespaceHybridConnectionAuthorizationRules();
            await collection.GetAsync(authorizationRuleName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: RelayHybridConnectionAutorizationRuleListAll

            var hybridConnectionId = Relay.Tests.Mock.HybridConnection.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourcegroup", "example-RelayNamespace-01", "example-Relay-Hybrid-01");
            var collection = GetArmClient().GetHybridConnection(hybridConnectionId).GetNamespaceHybridConnectionAuthorizationRules();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
