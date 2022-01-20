// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.NotificationHubs.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.NotificationHubs.Tests.Mock.Tests.Mock
{
    /// <summary> Test for NamespaceResource. </summary>
    public partial class NamespaceResourceCollectionMockTests : MockTestBase
    {
        public NamespaceResourceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: NameSpaceCreate
            string namespaceName = "nh-sdk-ns";
            NotificationHubs.Tests.Mock.Models.NamespaceCreateOrUpdateParameters parameters = new NotificationHubs.Tests.Mock.Models.NamespaceCreateOrUpdateParameters(location: "South Central US")
            {
                Sku = new NotificationHubs.Tests.Mock.Models.Sku(name: new NotificationHubs.Tests.Mock.Models.SkuName("Standard"))
                {
                    Tier = "Standard",
                },
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
                ["tag1"] = "value1",
                ["tag2"] = "value2",
            });

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/5ktrial")).GetNamespaceResources();
            await collection.CreateOrUpdateAsync(true, namespaceName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: NameSpaceGet
            string namespaceName = "nh-sdk-ns";

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/5ktrial")).GetNamespaceResources();
            await collection.GetAsync(namespaceName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: NameSpaceListByResourceGroup

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/5ktrial")).GetNamespaceResources();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
