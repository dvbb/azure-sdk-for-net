// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.PrivateDns.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.PrivateDns.Tests.Mock.Tests.Mock
{
    /// <summary> Test for PrivateZone. </summary>
    public partial class PrivateZoneMockTests : MockTestBase
    {
        public PrivateZoneMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: GET Private DNS Zone
            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var privateZone = GetArmClient().GetPrivateZone(privateZoneId);

            await privateZone.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: DELETE Private DNS Zone
            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var privateZone = GetArmClient().GetPrivateZone(privateZoneId);
            string ifMatch = null;

            await privateZone.DeleteAsync(true, ifMatch);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: PATCH Private DNS Zone
            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var privateZone = GetArmClient().GetPrivateZone(privateZoneId);
            PrivateDns.Tests.Mock.PrivateZoneData parameters = new PrivateDns.Tests.Mock.PrivateZoneData(location: AzureLocation.WestUS)
            {
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
                ["key2"] = "value2",
            });
            string ifMatch = null;

            await privateZone.UpdateAsync(true, parameters, ifMatch);
        }

        [RecordedTest]
        public async Task GetRecordSets()
        {
            // Example: GET Private DNS Zone ALL Record Sets
            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var privateZone = GetArmClient().GetPrivateZone(privateZoneId);
            int? top = null;
            string recordsetnamesuffix = null;

            await foreach (var _ in privateZone.GetRecordSetsAsync(top, recordsetnamesuffix))
            {
            }
        }
    }
}
