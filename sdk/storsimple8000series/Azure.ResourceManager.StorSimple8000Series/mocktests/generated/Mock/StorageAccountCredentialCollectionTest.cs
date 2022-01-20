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
    /// <summary> Test for StorageAccountCredential. </summary>
    public partial class StorageAccountCredentialCollectionMockTests : MockTestBase
    {
        public StorageAccountCredentialCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: StorageAccountCredentialsCreateOrUpdate
            string storageAccountCredentialName = "SACForTest";
            StorSimple8000Series.Tests.Mock.StorageAccountCredentialData parameters = new StorSimple8000Series.Tests.Mock.StorageAccountCredentialData(endPoint: "blob.core.windows.net", sslStatus: StorSimple8000Series.Tests.Mock.Models.SslStatus.Enabled)
            {
                AccessKey = new StorSimple8000Series.Tests.Mock.Models.AsymmetricEncryptedSecret(value: "ATuJSkmrFk4h8r1jrZ4nd3nthLSddcguEO5QLO/NECUtTuB9kL4dNv3/jC4WOvFkeVr3x1UvfhlIeMmJBF1SMr6hR1JzD0xNU/TtQqUeXN7V3jk7I+2l67P9StuHWR6OMd3XOLwvznxOEQtEWpweDiobZU1ZiY03WafcGZFpV5j6tEoHeopoZ1J/GhPtkYmx+TqxzUN6qnir5rP3NSYiZciImP/qu8U9yUV/xpVRv39KvFc2Yr5SpKpMMRUj55XW10UnPer63M6KovF8X9Wi/fNnrZAs1Esl5XddZETGrW/e5B++VMJ6w0Q/uvPR+UBwrOU0804l0SzwdIe3qVVd0Q==", encryptionAlgorithm: StorSimple8000Series.Tests.Mock.Models.EncryptionAlgorithm.RsaesPkcs1V15)
                {
                    EncryptionCertThumbprint = "A872A2DF196AC7682EE24791E7DE2E2A360F5926",
                },
            };

            var managerId = StorSimple8000Series.Tests.Mock.Manager.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroupForSDKTest", "ManagerForSDKTest1");
            var collection = GetArmClient().GetManager(managerId).GetStorageAccountCredentials();
            await collection.CreateOrUpdateAsync(true, storageAccountCredentialName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: StorageAccountCredentialsGet
            string storageAccountCredentialName = "SACForTest";

            var managerId = StorSimple8000Series.Tests.Mock.Manager.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroupForSDKTest", "ManagerForSDKTest1");
            var collection = GetArmClient().GetManager(managerId).GetStorageAccountCredentials();
            await collection.GetAsync(storageAccountCredentialName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: StorageAccountCredentialsListByManager

            var managerId = StorSimple8000Series.Tests.Mock.Manager.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroupForSDKTest", "ManagerForSDKTest1");
            var collection = GetArmClient().GetManager(managerId).GetStorageAccountCredentials();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
