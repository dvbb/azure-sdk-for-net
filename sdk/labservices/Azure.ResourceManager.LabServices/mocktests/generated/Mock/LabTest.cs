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
    /// <summary> Test for Lab. </summary>
    public partial class LabMockTests : MockTestBase
    {
        public LabMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: getLab
            var labId = LabServices.Tests.Mock.Lab.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlab");
            var lab = GetArmClient().GetLab(labId);

            await lab.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: deleteLab
            var labId = LabServices.Tests.Mock.Lab.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlab");
            var lab = GetArmClient().GetLab(labId);

            await lab.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: patchLab
            var labId = LabServices.Tests.Mock.Lab.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlab");
            var lab = GetArmClient().GetLab(labId);
            LabServices.Tests.Mock.Models.LabUpdate body = new LabServices.Tests.Mock.Models.LabUpdate()
            {
                SecurityProfile = new LabServices.Tests.Mock.Models.SecurityProfile()
                {
                    OpenAccess = LabServices.Tests.Mock.Models.EnableState.Enabled,
                },
            };

            await lab.UpdateAsync(true, body);
        }

        [RecordedTest]
        public async Task Publish()
        {
            // Example: publishLab
            var labId = LabServices.Tests.Mock.Lab.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlab");
            var lab = GetArmClient().GetLab(labId);

            await lab.PublishAsync(true);
        }

        [RecordedTest]
        public async Task SyncGroup()
        {
            // Example: syncLab
            var labId = LabServices.Tests.Mock.Lab.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlab");
            var lab = GetArmClient().GetLab(labId);

            await lab.SyncGroupAsync(true);
        }
    }
}
