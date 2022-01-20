// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Migrate.Tests.Mock;
using Azure.ResourceManager.Migrate.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Migrate.Tests.Mock.Tests.Mock
{
    /// <summary> Test for Group. </summary>
    public partial class GroupMockTests : MockTestBase
    {
        public GroupMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Groups_Get
            var groupId = Migrate.Tests.Mock.Group.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abgoyalWEselfhostb72bproject", "Test1");
            var group = GetArmClient().GetGroup(groupId);

            await group.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Groups_Delete
            var groupId = Migrate.Tests.Mock.Group.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abgoyalWEselfhostb72bproject", "Test1");
            var group = GetArmClient().GetGroup(groupId);

            await group.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task UpdateMachines()
        {
            // Example: Groups_UpdateMachines
            var groupId = Migrate.Tests.Mock.Group.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abgoyalWEselfhostb72bproject", "Group2");
            var group = GetArmClient().GetGroup(groupId);
            Migrate.Tests.Mock.Models.UpdateGroupBody groupUpdateProperties = null;

            await group.UpdateMachinesAsync(groupUpdateProperties);
        }
    }
}
