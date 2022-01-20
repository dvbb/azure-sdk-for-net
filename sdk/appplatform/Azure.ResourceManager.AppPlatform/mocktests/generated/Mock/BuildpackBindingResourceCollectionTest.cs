// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppPlatform.Tests.Mock;
using Azure.ResourceManager.AppPlatform.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.AppPlatform.Tests.Mock.Tests.Mock
{
    /// <summary> Test for BuildpackBindingResource. </summary>
    public partial class BuildpackBindingResourceCollectionMockTests : MockTestBase
    {
        public BuildpackBindingResourceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: BuildpackBinding_CreateOrUpdate
            string buildpackBindingName = "myBuildpackBinding";
            AppPlatform.Tests.Mock.BuildpackBindingResourceData buildpackBinding = new AppPlatform.Tests.Mock.BuildpackBindingResourceData()
            {
                Properties = new AppPlatform.Tests.Mock.Models.BuildpackBindingProperties()
                {
                    BindingType = new AppPlatform.Tests.Mock.Models.BindingType("ApplicationInsights"),
                    LaunchProperties = new AppPlatform.Tests.Mock.Models.BuildpackBindingLaunchProperties(),
                },
            };

            var builderResourceId = AppPlatform.Tests.Mock.BuilderResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default", "default");
            var collection = GetArmClient().GetBuilderResource(builderResourceId).GetBuildpackBindingResources();
            await collection.CreateOrUpdateAsync(true, buildpackBindingName, buildpackBinding);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: BuildpackBinding_Get
            string buildpackBindingName = "myBuildpackBinding";

            var builderResourceId = AppPlatform.Tests.Mock.BuilderResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default", "default");
            var collection = GetArmClient().GetBuilderResource(builderResourceId).GetBuildpackBindingResources();
            await collection.GetAsync(buildpackBindingName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: BuildpackBinding_Get

            var builderResourceId = AppPlatform.Tests.Mock.BuilderResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myservice", "default", "default");
            var collection = GetArmClient().GetBuilderResource(builderResourceId).GetBuildpackBindingResources();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
