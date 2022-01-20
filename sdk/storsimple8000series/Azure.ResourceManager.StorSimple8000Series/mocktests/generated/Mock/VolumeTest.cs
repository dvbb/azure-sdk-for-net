// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.StorSimple8000Series.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.StorSimple8000Series.Tests.Mock.Tests.Mock
{
    /// <summary> Test for Volume. </summary>
    public partial class VolumeMockTests : MockTestBase
    {
        public VolumeMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: VolumesGet
            var volumeId = StorSimple8000Series.Tests.Mock.Volume.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroupForSDKTest", "ManagerForSDKTest1", "Device05ForSDKTest", "VolumeContainerForSDKTest", "Volume1ForSDKTest");
            var volume = GetArmClient().GetVolume(volumeId);

            await volume.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: VolumesDelete
            var volumeId = StorSimple8000Series.Tests.Mock.Volume.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroupForSDKTest", "ManagerForSDKTest1", "Device05ForSDKTest", "VolumeContainerForSDKTest", "Volume1ForSDKTest");
            var volume = GetArmClient().GetVolume(volumeId);

            await volume.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task GetMetrics()
        {
            // Example: VolumesListMetrics
            var volumeId = StorSimple8000Series.Tests.Mock.Volume.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroupForSDKTest", "ManagerForSDKTest1", "Device05ForSDKTest", "vcForOdataFilterTest", "CloneVolForSDKTest890836587");
            var volume = GetArmClient().GetVolume(volumeId);
            string filter = "name/value eq 'PrimaryStorageTieredUsed' and timeGrain eq 'PT1H' and startTime ge '2017-06-17T18:30:00Z' and endTime le '2017-06-21T18:30:00Z' and category eq 'CapacityUtilization'";

            await foreach (var _ in volume.GetMetricsAsync(filter))
            {
            }
        }

        [RecordedTest]
        public async Task GetMetricDefinition()
        {
            // Example: VolumesListMetricDefinition
            var volumeId = StorSimple8000Series.Tests.Mock.Volume.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroupForSDKTest", "ManagerForSDKTest1", "Device05ForSDKTest", "vcForOdataFilterTest", "CloneVolForSDKTest890836587");
            var volume = GetArmClient().GetVolume(volumeId);

            await foreach (var _ in volume.GetMetricDefinitionAsync())
            {
            }
        }
    }
}
