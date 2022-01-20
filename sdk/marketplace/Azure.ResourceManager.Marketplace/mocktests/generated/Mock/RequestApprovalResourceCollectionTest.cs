// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Marketplace.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Marketplace.Tests.Mock.Tests.Mock
{
    /// <summary> Test for RequestApprovalResource. </summary>
    public partial class RequestApprovalResourceCollectionMockTests : MockTestBase
    {
        public RequestApprovalResourceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: CreateApprovalRequest
            string requestApprovalId = "marketplacetestthirdparty.md-test-third-party-2";
            Marketplace.Tests.Mock.RequestApprovalResourceData payload = null;

            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var collection = GetArmClient().GetPrivateStore(privateStoreId).GetRequestApprovalResources();
            await collection.CreateOrUpdateAsync(true, requestApprovalId, payload);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: GetApprovalRequest
            string requestApprovalId = "marketplacetestthirdparty.md-test-third-party-2";

            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var collection = GetArmClient().GetPrivateStore(privateStoreId).GetRequestApprovalResources();
            await collection.GetAsync(requestApprovalId);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: GetApprovalRequestsList

            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var collection = GetArmClient().GetPrivateStore(privateStoreId).GetRequestApprovalResources();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
