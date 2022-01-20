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
using Azure.ResourceManager.ServiceFabricMesh.Tests.Mock;
using Azure.ResourceManager.ServiceFabricMesh.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceFabricMesh.Tests.Mock.Tests.Mock
{
    /// <summary> Test for NetworkResourceDescription. </summary>
    public partial class NetworkResourceDescriptionCollectionMockTests : MockTestBase
    {
        public NetworkResourceDescriptionCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: CreateOrUpdateNetwork
            string networkResourceName = "sampleNetwork";
            ServiceFabricMesh.Tests.Mock.NetworkResourceDescriptionData networkResourceDescription = new ServiceFabricMesh.Tests.Mock.NetworkResourceDescriptionData(location: "EastUS", properties: new ServiceFabricMesh.Tests.Mock.Models.LocalNetworkResourceProperties()
            {
                NetworkAddressPrefix = "2.0.0.0/16",
                Description = "Service Fabric Mesh sample network.",
                Kind = new ServiceFabricMesh.Tests.Mock.Models.NetworkKind("Local"),
            })
            {
            };
            networkResourceDescription.Tags.ReplaceWith(new Dictionary<string, string>()
            {
            });

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo")).GetNetworkResourceDescriptions();
            await collection.CreateOrUpdateAsync(true, networkResourceName, networkResourceDescription);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: GetNetwork
            string networkResourceName = "sampleNetwork";

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo")).GetNetworkResourceDescriptions();
            await collection.GetAsync(networkResourceName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: ListNetworksByResourceGroup

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo")).GetNetworkResourceDescriptions();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
