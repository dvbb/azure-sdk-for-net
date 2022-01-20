// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.LabServices.Tests.Mock;
using Azure.ResourceManager.LabServices.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.LabServices.Tests.Mock.Tests.Mock
{
    /// <summary> Test for LabPlan. </summary>
    public partial class LabPlanMockTests : MockTestBase
    {
        public LabPlanMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: getLabPlan
            var labPlanId = LabServices.Tests.Mock.LabPlan.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlabplan");
            var labPlan = GetArmClient().GetLabPlan(labPlanId);

            await labPlan.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: deleteLabPlan
            var labPlanId = LabServices.Tests.Mock.LabPlan.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlabplan");
            var labPlan = GetArmClient().GetLabPlan(labPlanId);

            await labPlan.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: patchLabPlan
            var labPlanId = LabServices.Tests.Mock.LabPlan.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlabplan");
            var labPlan = GetArmClient().GetLabPlan(labPlanId);
            LabServices.Tests.Mock.Models.LabPlanUpdate body = new LabServices.Tests.Mock.Models.LabPlanUpdate()
            {
                DefaultConnectionProfile = new LabServices.Tests.Mock.Models.ConnectionProfile()
                {
                    WebSshAccess = LabServices.Tests.Mock.Models.ConnectionType.None,
                    WebRdpAccess = LabServices.Tests.Mock.Models.ConnectionType.None,
                    ClientSshAccess = LabServices.Tests.Mock.Models.ConnectionType.Public,
                    ClientRdpAccess = LabServices.Tests.Mock.Models.ConnectionType.Public,
                },
            };

            await labPlan.UpdateAsync(true, body);
        }

        [RecordedTest]
        public async Task SaveImage()
        {
            // Example: saveImageVirtualMachine
            var labPlanId = LabServices.Tests.Mock.LabPlan.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlabplan");
            var labPlan = GetArmClient().GetLabPlan(labPlanId);
            LabServices.Tests.Mock.Models.SaveImageBody body = new LabServices.Tests.Mock.Models.SaveImageBody()
            {
                Name = "Test Image",
                LabVirtualMachineId = "/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/testrg123/providers/Microsoft.LabServices/labs/testlab/virtualMachines/template",
            };

            await labPlan.SaveImageAsync(true, body);
        }
    }
}
