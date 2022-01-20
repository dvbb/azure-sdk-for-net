// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ServiceFabricManagedClusters.Tests.Mock;
using Azure.ResourceManager.ServiceFabricManagedClusters.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Tests.Mock.Tests.Mock
{
    /// <summary> Test for ManagedCluster. </summary>
    public partial class ManagedClusterMockTests : MockTestBase
    {
        public ManagedClusterMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a cluster
            var managedClusterId = ServiceFabricManagedClusters.Tests.Mock.ManagedCluster.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster");
            var managedCluster = GetArmClient().GetManagedCluster(managedClusterId);

            await managedCluster.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete a cluster
            var managedClusterId = ServiceFabricManagedClusters.Tests.Mock.ManagedCluster.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster");
            var managedCluster = GetArmClient().GetManagedCluster(managedClusterId);

            await managedCluster.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Patch a managed cluster
            var managedClusterId = ServiceFabricManagedClusters.Tests.Mock.ManagedCluster.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster");
            var managedCluster = GetArmClient().GetManagedCluster(managedClusterId);
            ServiceFabricManagedClusters.Tests.Mock.Models.ManagedClusterUpdateParameters parameters = new ServiceFabricManagedClusters.Tests.Mock.Models.ManagedClusterUpdateParameters();

            await managedCluster.UpdateAsync(parameters);
        }
    }
}
