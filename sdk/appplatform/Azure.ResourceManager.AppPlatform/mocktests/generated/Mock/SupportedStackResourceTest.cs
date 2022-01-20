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
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.AppPlatform.Tests.Mock.Tests.Mock
{
    /// <summary> Test for SupportedStackResource. </summary>
    public partial class SupportedStackResourceMockTests : MockTestBase
    {
        public SupportedStackResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: BuildService_GetSupportedStack
            var supportedStackResourceId = AppPlatform.Tests.Mock.SupportedStackResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default", "io.buildpacks.stacks.bionic-base");
            var supportedStackResource = GetArmClient().GetSupportedStackResource(supportedStackResourceId);

            await supportedStackResource.GetAsync();
        }
    }
}
