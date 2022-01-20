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
    /// <summary> Test for User. </summary>
    public partial class UserMockTests : MockTestBase
    {
        public UserMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: getUser
            var userId = LabServices.Tests.Mock.User.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlab", "testuser");
            var user = GetArmClient().GetUser(userId);

            await user.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: deleteUser
            var userId = LabServices.Tests.Mock.User.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlab", "testuser");
            var user = GetArmClient().GetUser(userId);

            await user.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: patchUser
            var userId = LabServices.Tests.Mock.User.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlab", "testuser");
            var user = GetArmClient().GetUser(userId);
            LabServices.Tests.Mock.Models.UserUpdate body = new LabServices.Tests.Mock.Models.UserUpdate()
            {
                AdditionalUsageQuota = TimeSpan.Parse("20:00"),
            };

            await user.UpdateAsync(true, body);
        }

        [RecordedTest]
        public async Task Invite()
        {
            // Example: inviteUser
            var userId = LabServices.Tests.Mock.User.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg123", "testlab", "testuser");
            var user = GetArmClient().GetUser(userId);
            LabServices.Tests.Mock.Models.InviteBody body = new LabServices.Tests.Mock.Models.InviteBody()
            {
                Text = "Invitation to lab testlab",
            };

            await user.InviteAsync(true, body);
        }
    }
}
