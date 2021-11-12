﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Tests.Scenario
{
    public class ManagedServerSecurityAlertPolicyTests : SqlManagementClientBase
    {
        private ResourceGroup _resourceGroup;
        private ResourceIdentifier _resourceGroupIdentifier;
        public ManagedServerSecurityAlertPolicyTests(bool isAsync)
            : base(isAsync)
        {
        }

        [OneTimeSetUp]
        public async Task GlobalSetUp()
        {
            var rgLro = await GlobalClient.GetDefaultSubscriptionAsync().Result.GetResourceGroups().CreateOrUpdateAsync(SessionRecording.GenerateAssetName("Sql-RG-"), new ResourceGroupData(Location.WestUS2));
            ResourceGroup rg = rgLro.Value;
            _resourceGroupIdentifier = rg.Id;
            StopSessionRecording();
        }

        [SetUp]
        public async Task TestSetUp()
        {
            var client = GetArmClient();
            _resourceGroup = await client.GetResourceGroup(_resourceGroupIdentifier).GetAsync();
        }

        [Test]
        [RecordedTest]
        public async Task ManagedInstanceKeyApiTests()
        {
            // Create Managed Instance
            string managedInstanceName = Recording.GenerateAssetName("managed-instance-");
            var managedInstance = await CreateDefaultManagedInstance(managedInstanceName, Location.WestUS2, _resourceGroup);
            Assert.IsNotNull(managedInstance.Data);
            var collection = managedInstance.GetManagedServerSecurityAlertPolicies();
            string securityAlertPoliciesName = "Default";

            // 1.CreateOrUpdate
            ManagedServerSecurityAlertPolicyData data = new ManagedServerSecurityAlertPolicyData()
            {
                State = SecurityAlertsPolicyState.Enabled,
                DisabledAlerts = { },
                EmailAddresses = { },
                EmailAccountAdmins = false,
                RetentionDays = 0,
            };
            var key = await collection.CreateOrUpdateAsync(securityAlertPoliciesName, data);
            Assert.IsNotNull(key.Value.Data);
            Assert.AreEqual(securityAlertPoliciesName, key.Value.Data.Name);
            Assert.AreEqual("Enabled", key.Value.Data.State.ToString());

            // 2.CheckIfExist
            Assert.IsTrue(collection.CheckIfExists(securityAlertPoliciesName));

            // 3.Get
            var getKey = await collection.GetAsync(securityAlertPoliciesName);
            Assert.IsNotNull(getKey.Value.Data);
            Assert.AreEqual(securityAlertPoliciesName, getKey.Value.Data.Name);

            // 4.GetAll
            var list = await collection.GetAllAsync().ToEnumerableAsync();
            Assert.IsNotEmpty(list);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(securityAlertPoliciesName, list.FirstOrDefault().Data.Name);
        }
    }
}
