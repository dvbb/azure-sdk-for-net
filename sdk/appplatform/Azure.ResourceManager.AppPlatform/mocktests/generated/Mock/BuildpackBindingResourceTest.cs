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
    /// <summary> Test for BuildpackBindingResource. </summary>
    public partial class BuildpackBindingResourceMockTests : MockTestBase
    {
        public BuildpackBindingResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: BuildpackBinding_Get
            var buildpackBindingResourceId = AppPlatform.Tests.Mock.BuildpackBindingResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default", "default", "myBuildpackBinding");
            var buildpackBindingResource = GetArmClient().GetBuildpackBindingResource(buildpackBindingResourceId);

            await buildpackBindingResource.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: BuildpackBinding_Delete
            var buildpackBindingResourceId = AppPlatform.Tests.Mock.BuildpackBindingResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default", "default", "myBuildpackBinding");
            var buildpackBindingResource = GetArmClient().GetBuildpackBindingResource(buildpackBindingResourceId);

            await buildpackBindingResource.DeleteAsync(true);
        }
    }
}
