// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.NotificationHubs.Tests.Mock;
using Azure.ResourceManager.NotificationHubs.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.NotificationHubs.Tests.Mock.Tests.Mock
{
    /// <summary> Test for SharedAccessAuthorizationRuleResource. </summary>
    public partial class NamespaceAuthorizationRuleCollectionMockTests : MockTestBase
    {
        public NamespaceAuthorizationRuleCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: NameSpaceAuthorizationRuleCreate
            string authorizationRuleName = "sdk-AuthRules-1788";
            NotificationHubs.Tests.Mock.Models.SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters = new NotificationHubs.Tests.Mock.Models.SharedAccessAuthorizationRuleCreateOrUpdateParameters(properties: new NotificationHubs.Tests.Mock.Models.SharedAccessAuthorizationRuleProperties());

            var namespaceResourceId = NotificationHubs.Tests.Mock.NamespaceResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "5ktrial", "nh-sdk-ns");
            var collection = GetArmClient().GetNamespaceResource(namespaceResourceId).GetNamespaceAuthorizationRules();
            await collection.CreateOrUpdateAsync(true, authorizationRuleName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: NameSpaceAuthorizationRuleGet
            string authorizationRuleName = "RootManageSharedAccessKey";

            var namespaceResourceId = NotificationHubs.Tests.Mock.NamespaceResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "5ktrial", "nh-sdk-ns");
            var collection = GetArmClient().GetNamespaceResource(namespaceResourceId).GetNamespaceAuthorizationRules();
            await collection.GetAsync(authorizationRuleName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: NameSpaceAuthorizationRuleListAll

            var namespaceResourceId = NotificationHubs.Tests.Mock.NamespaceResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "5ktrial", "nh-sdk-ns");
            var collection = GetArmClient().GetNamespaceResource(namespaceResourceId).GetNamespaceAuthorizationRules();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
