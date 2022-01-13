// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using Azure.ResourceManager.WebPubSub;

namespace Azure.ResourceManager.WebPubSub.Tests.Mock
{
    /// <summary> Test for SharedPrivateLink. </summary>
    public partial class SharedPrivateLinkMockTests : MockTestBase
    {
        public SharedPrivateLinkMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: WebPubSubSharedPrivateLinkResources_Get
            var sharedPrivateLinkId = SharedPrivateLink.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService", "default");
            var sharedPrivateLink = GetArmClient().GetSharedPrivateLink(sharedPrivateLinkId);

            await sharedPrivateLink.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: WebPubSubSharedPrivateLinkResources_Delete
            var sharedPrivateLinkId = SharedPrivateLink.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService", "default");
            var sharedPrivateLink = GetArmClient().GetSharedPrivateLink(sharedPrivateLinkId);

            await sharedPrivateLink.DeleteAsync();
        }
    }
}
