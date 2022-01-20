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

namespace Azure.ResourceManager.WorkloadMonitor.Tests.Mock.Tests.Mock
{
    /// <summary> Test for HealthMonitor. </summary>
    public partial class HealthMonitorCollectionMockTests : MockTestBase
    {
        public HealthMonitorCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get monitor with default values
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A|free-space";
            string expand = null;

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/tugamidiAlerts")).GetHealthMonitors(providerName, resourceCollectionName, resourceName);
            await collection.GetAsync(monitorId, expand);
        }

        [RecordedTest]
        public async Task Get2()
        {
            // Example: Get monitor with expanded values
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A|free-space";
            string expand = "evidence";

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/tugamidiAlerts")).GetHealthMonitors(providerName, resourceCollectionName, resourceName);
            await collection.GetAsync(monitorId, expand);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Get monitor list with default values
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string filter = null;
            string expand = null;

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/tugamidiAlerts")).GetHealthMonitors(providerName, resourceCollectionName, resourceName);
            await foreach (var _ in collection.GetAllAsync(filter, expand))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll2()
        {
            // Example: Get monitor list with expanded values
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string filter = null;
            string expand = "evidence,configuration";

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/tugamidiAlerts")).GetHealthMonitors(providerName, resourceCollectionName, resourceName);
            await foreach (var _ in collection.GetAllAsync(filter, expand))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll3()
        {
            // Example: Get monitor list with filtered values
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string filter = "monitorName eq 'root'";
            string expand = null;

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/tugamidiAlerts")).GetHealthMonitors(providerName, resourceCollectionName, resourceName);
            await foreach (var _ in collection.GetAllAsync(filter, expand))
            {
            }
        }
    }
}
