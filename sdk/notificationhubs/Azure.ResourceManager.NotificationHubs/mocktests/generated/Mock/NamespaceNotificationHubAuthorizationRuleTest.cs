// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.NotificationHubs.Tests.Mock;
using Azure.ResourceManager.NotificationHubs.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.NotificationHubs.Tests.Mock.Tests.Mock
{
    /// <summary> Test for SharedAccessAuthorizationRuleResource. </summary>
    public partial class NamespaceNotificationHubAuthorizationRuleMockTests : MockTestBase
    {
        public NamespaceNotificationHubAuthorizationRuleMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: NotificationHubAuthorizationRuleGet
            var namespaceNotificationHubAuthorizationRuleId = NotificationHubs.Tests.Mock.NamespaceNotificationHubAuthorizationRule.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "5ktrial", "nh-sdk-ns", "nh-sdk-hub", "DefaultListenSharedAccessSignature");
            var namespaceNotificationHubAuthorizationRule = GetArmClient().GetNamespaceNotificationHubAuthorizationRule(namespaceNotificationHubAuthorizationRuleId);

            await namespaceNotificationHubAuthorizationRule.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: NotificationHubAuthorizationRuleDelete
            var namespaceNotificationHubAuthorizationRuleId = NotificationHubs.Tests.Mock.NamespaceNotificationHubAuthorizationRule.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "5ktrial", "nh-sdk-ns", "nh-sdk-hub", "DefaultListenSharedAccessSignature");
            var namespaceNotificationHubAuthorizationRule = GetArmClient().GetNamespaceNotificationHubAuthorizationRule(namespaceNotificationHubAuthorizationRuleId);

            await namespaceNotificationHubAuthorizationRule.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task GetKeys()
        {
            // Example: NotificationHubAuthorizationRuleListKey
            var namespaceNotificationHubAuthorizationRuleId = NotificationHubs.Tests.Mock.NamespaceNotificationHubAuthorizationRule.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "5ktrial", "nh-sdk-ns", "nh-sdk-hub", "sdk-AuthRules-5800");
            var namespaceNotificationHubAuthorizationRule = GetArmClient().GetNamespaceNotificationHubAuthorizationRule(namespaceNotificationHubAuthorizationRuleId);

            await namespaceNotificationHubAuthorizationRule.GetKeysAsync();
        }

        [RecordedTest]
        public async Task RegenerateKeys()
        {
            // Example: NotificationHubAuthorizationRuleRegenrateKey
            var namespaceNotificationHubAuthorizationRuleId = NotificationHubs.Tests.Mock.NamespaceNotificationHubAuthorizationRule.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "5ktrial", "nh-sdk-ns", "nh-sdk-hub", "DefaultListenSharedAccessSignature");
            var namespaceNotificationHubAuthorizationRule = GetArmClient().GetNamespaceNotificationHubAuthorizationRule(namespaceNotificationHubAuthorizationRuleId);
            NotificationHubs.Tests.Mock.Models.PolicykeyResource parameters = new NotificationHubs.Tests.Mock.Models.PolicykeyResource()
            {
                PolicyKey = "PrimaryKey",
            };

            await namespaceNotificationHubAuthorizationRule.RegenerateKeysAsync(parameters);
        }
    }
}
