// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.StorSimple8000Series.Tests.Mock;
using Azure.ResourceManager.StorSimple8000Series.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.StorSimple8000Series.Tests.Mock.Tests.Mock
{
    /// <summary> Test for VolumeContainer. </summary>
    public partial class VolumeContainerCollectionMockTests : MockTestBase
    {
        public VolumeContainerCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: VolumeContainersCreateOrUpdate
            string volumeContainerName = "VolumeContainerForSDKTest";
            StorSimple8000Series.Tests.Mock.VolumeContainerData parameters = new StorSimple8000Series.Tests.Mock.VolumeContainerData(storageAccountCredentialId: "/subscriptions/4385cf00-2d3a-425a-832f-f4285b1c9dce/resourceGroups/ResourceGroupForSDKTest/providers/Microsoft.StorSimple/managers/ManagerForSDKTest1/storageAccountCredentials/safortestrecording")
            {
                EncryptionKey = new StorSimple8000Series.Tests.Mock.Models.AsymmetricEncryptedSecret(value: "R//pyVLx/fn58ia098JiLgZB5RY7fVT+6o8a4fmsvjy+ls2UgJphMf25XVqEQCZnsp/5uxteN1M/9ArPIICdhM7M1+b/Ur7kJ0FH0ktxfk7CrPWWJLI4q20LZoduJGI56lREav1VpuLdqw5F9fRcq7zbfgPQ3B/SD0mfumNRiV+AnwbC6msfavIuWrhVDl9iSzEPE+zU06/kpsexnrS81yYT2QlVVUbvpY4F3zfH8TQPpAROTbv2pld6JO4eGOrZ5O1iOr6XCg2TY2W/jf+Ev4z5tqC9VWXE5kh65gjBfpWN0bDWXKekqEhor2crHAxZi4dybdY8Ok1MDWd1CSU8kw==", encryptionAlgorithm: StorSimple8000Series.Tests.Mock.Models.EncryptionAlgorithm.RsaesPkcs1V15)
                {
                    EncryptionCertThumbprint = "A872A2DF196AC7682EE24791E7DE2E2A360F5926",
                },
                BandwidthSettingId = "/subscriptions/4385cf00-2d3a-425a-832f-f4285b1c9dce/resourceGroups/ResourceGroupForSDKTest/providers/Microsoft.StorSimple/managers/ManagerForSDKTest1/bandwidthSettings/bandwidthSetting1",
            };

            var deviceId = StorSimple8000Series.Tests.Mock.Device.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroupForSDKTest", "ManagerForSDKTest1", "Device05ForSDKTest");
            var collection = GetArmClient().GetDevice(deviceId).GetVolumeContainers();
            await collection.CreateOrUpdateAsync(true, volumeContainerName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: VolumeContainersGet
            string volumeContainerName = "VolumeContainerForSDKTest";

            var deviceId = StorSimple8000Series.Tests.Mock.Device.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroupForSDKTest", "ManagerForSDKTest1", "Device05ForSDKTest");
            var collection = GetArmClient().GetDevice(deviceId).GetVolumeContainers();
            await collection.GetAsync(volumeContainerName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: VolumeContainersListByDevice

            var deviceId = StorSimple8000Series.Tests.Mock.Device.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroupForSDKTest", "ManagerForSDKTest1", "Device05ForSDKTest");
            var collection = GetArmClient().GetDevice(deviceId).GetVolumeContainers();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
