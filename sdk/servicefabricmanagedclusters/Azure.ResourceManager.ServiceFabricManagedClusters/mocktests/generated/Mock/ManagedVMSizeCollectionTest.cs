// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Tests.Mock.Tests.Mock
{
    /// <summary> Test for ManagedVMSize. </summary>
    public partial class ManagedVMSizeCollectionMockTests : MockTestBase
    {
        public ManagedVMSizeCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get unsupported vm sizes
            string location = "eastus";
            string vmSize = "Standard_B1ls1";

            var collection = GetArmClient().GetSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000")).GetManagedVMSizes(location);
            await collection.GetAsync(vmSize);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List unsupported vm sizes
            string location = "eastus";

            var collection = GetArmClient().GetSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000")).GetManagedVMSizes(location);
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
