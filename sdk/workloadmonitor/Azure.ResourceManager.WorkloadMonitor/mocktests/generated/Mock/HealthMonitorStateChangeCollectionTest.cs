// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using Azure.ResourceManager.WorkloadMonitor.Tests.Mock;

namespace Azure.ResourceManager.WorkloadMonitor.Tests.Mock.Tests.Mock
{
    /// <summary> Test for HealthMonitorStateChange. </summary>
    public partial class HealthMonitorStateChangeCollectionMockTests : MockTestBase
    {
        public HealthMonitorStateChangeCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get monitor state change with default values
            string timestampUnix = "1584316800";
            string expand = null;

            var healthMonitorId = WorkloadMonitor.Tests.Mock.HealthMonitor.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "tugamidiAlerts", "Microsoft.Compute", "virtualMachines", "linuxEUS", "logical-disks|C@3A");
            var collection = GetArmClient().GetHealthMonitor(healthMonitorId).GetHealthMonitorStateChanges();
            await collection.GetAsync(timestampUnix, expand);
        }

        [RecordedTest]
        public async Task Get2()
        {
            // Example: Get monitor state change with expanded values
            string timestampUnix = "1584316800";
            string expand = "evidence";

            var healthMonitorId = WorkloadMonitor.Tests.Mock.HealthMonitor.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "tugamidiAlerts", "Microsoft.Compute", "virtualMachines", "linuxEUS", "logical-disks|C@3A");
            var collection = GetArmClient().GetHealthMonitor(healthMonitorId).GetHealthMonitorStateChanges();
            await collection.GetAsync(timestampUnix, expand);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Get monitor state changes with default values
            string filter = null;
            string expand = null;
            DateTimeOffset? startTimestampUtc = DateTimeOffset.Parse("2020-10-19T19:24:14Z");
            DateTimeOffset? endTimestampUtc = DateTimeOffset.Parse("2020-10-20T01:24:14Z");

            var healthMonitorId = WorkloadMonitor.Tests.Mock.HealthMonitor.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "tugamidiAlerts", "Microsoft.Compute", "virtualMachines", "linuxEUS", "logical-disks|C@3A");
            var collection = GetArmClient().GetHealthMonitor(healthMonitorId).GetHealthMonitorStateChanges();
            await foreach (var _ in collection.GetAllAsync(filter, expand, startTimestampUtc, endTimestampUtc))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll2()
        {
            // Example: Get monitor state changes with expanded values
            string filter = null;
            string expand = "evidence,configuration";
            DateTimeOffset? startTimestampUtc = DateTimeOffset.Parse("2020-10-19T07:22:25.824Z");
            DateTimeOffset? endTimestampUtc = DateTimeOffset.Parse("2020-10-21T13:22:25.822Z");

            var healthMonitorId = WorkloadMonitor.Tests.Mock.HealthMonitor.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "tugamidiAlerts", "Microsoft.Compute", "virtualMachines", "linuxEUS", "logical-disks|C@3A");
            var collection = GetArmClient().GetHealthMonitor(healthMonitorId).GetHealthMonitorStateChanges();
            await foreach (var _ in collection.GetAllAsync(filter, expand, startTimestampUtc, endTimestampUtc))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll3()
        {
            // Example: Get monitor state changes with filtered values
            string filter = "isHeartbeat eq false";
            string expand = null;
            DateTimeOffset? startTimestampUtc = DateTimeOffset.Parse("2020-01-04T20:20:18.5765757Z");
            DateTimeOffset? endTimestampUtc = DateTimeOffset.Parse("2020-01-09T20:20:18.5765757Z");

            var healthMonitorId = WorkloadMonitor.Tests.Mock.HealthMonitor.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "tugamidiAlerts", "Microsoft.Compute", "virtualMachines", "linuxEUS", "logical-disks|C@3A|free-space");
            var collection = GetArmClient().GetHealthMonitor(healthMonitorId).GetHealthMonitorStateChanges();
            await foreach (var _ in collection.GetAllAsync(filter, expand, startTimestampUtc, endTimestampUtc))
            {
            }
        }
    }
}
