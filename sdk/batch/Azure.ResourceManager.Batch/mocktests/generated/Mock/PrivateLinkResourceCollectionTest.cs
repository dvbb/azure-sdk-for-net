// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Batch.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Batch.Tests.Mock.Tests.Mock
{
    /// <summary> Test for PrivateLinkResource. </summary>
    public partial class PrivateLinkResourceCollectionMockTests : MockTestBase
    {
        public PrivateLinkResourceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: GetPrivateLinkResource
            string privateLinkResourceName = "sampleacct";

            var batchAccountId = Batch.Tests.Mock.BatchAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "default-azurebatch-japaneast", "sampleacct");
            var collection = GetArmClient().GetBatchAccount(batchAccountId).GetPrivateLinkResources();
            await collection.GetAsync(privateLinkResourceName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: ListPrivateLinkResource
            int? maxresults = null;

            var batchAccountId = Batch.Tests.Mock.BatchAccount.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "default-azurebatch-japaneast", "sampleacct");
            var collection = GetArmClient().GetBatchAccount(batchAccountId).GetPrivateLinkResources();
            await foreach (var _ in collection.GetAllAsync(maxresults))
            {
            }
        }
    }
}
