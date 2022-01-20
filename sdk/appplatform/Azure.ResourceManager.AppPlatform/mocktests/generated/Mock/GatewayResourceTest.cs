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
    /// <summary> Test for GatewayResource. </summary>
    public partial class GatewayResourceMockTests : MockTestBase
    {
        public GatewayResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Gateways_Get
            var gatewayResourceId = AppPlatform.Tests.Mock.GatewayResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default");
            var gatewayResource = GetArmClient().GetGatewayResource(gatewayResourceId);

            await gatewayResource.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Gateways_Delete
            var gatewayResourceId = AppPlatform.Tests.Mock.GatewayResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default");
            var gatewayResource = GetArmClient().GetGatewayResource(gatewayResourceId);

            await gatewayResource.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task ValidateDomain()
        {
            // Example: Gateways_ValidateDomain
            var gatewayResourceId = AppPlatform.Tests.Mock.GatewayResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default");
            var gatewayResource = GetArmClient().GetGatewayResource(gatewayResourceId);
            AppPlatform.Tests.Mock.Models.CustomDomainValidatePayload validatePayload = new AppPlatform.Tests.Mock.Models.CustomDomainValidatePayload(name: "mydomain.io");

            await gatewayResource.ValidateDomainAsync(validatePayload);
        }
    }
}
