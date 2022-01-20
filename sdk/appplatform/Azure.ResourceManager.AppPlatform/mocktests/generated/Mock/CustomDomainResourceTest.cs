// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppPlatform.Tests.Mock;
using Azure.ResourceManager.AppPlatform.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.AppPlatform.Tests.Mock.Tests.Mock
{
    /// <summary> Test for CustomDomainResource. </summary>
    public partial class CustomDomainResourceMockTests : MockTestBase
    {
        public CustomDomainResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: CustomDomains_Get
            var customDomainResourceId = AppPlatform.Tests.Mock.CustomDomainResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "myapp", "mydomain.com");
            var customDomainResource = GetArmClient().GetCustomDomainResource(customDomainResourceId);

            await customDomainResource.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: CustomDomains_Delete
            var customDomainResourceId = AppPlatform.Tests.Mock.CustomDomainResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "myapp", "mydomain.com");
            var customDomainResource = GetArmClient().GetCustomDomainResource(customDomainResourceId);

            await customDomainResource.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: CustomDomains_Update
            var customDomainResourceId = AppPlatform.Tests.Mock.CustomDomainResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "myapp", "mydomain.com");
            var customDomainResource = GetArmClient().GetCustomDomainResource(customDomainResourceId);
            AppPlatform.Tests.Mock.CustomDomainResourceData domainResource = new AppPlatform.Tests.Mock.CustomDomainResourceData()
            {
                Properties = new AppPlatform.Tests.Mock.Models.CustomDomainProperties()
                {
                    Thumbprint = "934367bf1c97033f877db0f15cb1b586957d3133",
                    CertName = "mycert",
                },
            };

            await customDomainResource.UpdateAsync(true, domainResource);
        }
    }
}
