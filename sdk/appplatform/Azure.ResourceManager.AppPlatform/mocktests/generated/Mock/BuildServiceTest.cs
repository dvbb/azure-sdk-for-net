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
    /// <summary> Test for BuildService. </summary>
    public partial class BuildServiceMockTests : MockTestBase
    {
        public BuildServiceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: BuildService_GetBuildService
            var buildServiceId = AppPlatform.Tests.Mock.BuildService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default");
            var buildService = GetArmClient().GetBuildService(buildServiceId);

            await buildService.GetAsync();
        }

        [RecordedTest]
        public async Task GetResourceUploadUrl()
        {
            // Example: BuildService_GetResourceUploadUrl
            var buildServiceId = AppPlatform.Tests.Mock.BuildService.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default");
            var buildService = GetArmClient().GetBuildService(buildServiceId);

            await buildService.GetResourceUploadUrlAsync();
        }
    }
}
