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

namespace Azure.ResourceManager.KeyVault.Tests.Mock
{
    /// <summary> Test for DeletedManagedHsm. </summary>
    public partial class DeletedManagedHsmCollectionMockTests : MockTestBase
    {
        public DeletedManagedHsmCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Retrieve a deleted managed HSM
            string location = "westus";
            string name = "hsm1";

            var collection = GetArmClient().GetSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000")).GetDeletedManagedHsms();
            await collection.GetAsync(location, name);
        }
    }
}
