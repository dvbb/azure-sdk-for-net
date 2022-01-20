// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ConfidentialLedger.Tests.Mock;
using Azure.ResourceManager.ConfidentialLedger.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ConfidentialLedger.Tests.Mock.Tests.Mock
{
    /// <summary> Test for ConfidentialLedger. </summary>
    public partial class ConfidentialLedgerCollectionMockTests : MockTestBase
    {
        public ConfidentialLedgerCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: ConfidentialLedgerCreate
            string ledgerName = "DummyLedgerName";
            ConfidentialLedger.Tests.Mock.ConfidentialLedgerData confidentialLedger = new ConfidentialLedger.Tests.Mock.ConfidentialLedgerData()
            {
                Properties = new ConfidentialLedger.Tests.Mock.Models.LedgerProperties()
                {
                    LedgerType = new ConfidentialLedger.Tests.Mock.Models.LedgerType("Public"),
                },
                Location = "EastUS",
            };

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/DummyResourceGroupName")).GetConfidentialLedgers();
            await collection.CreateOrUpdateAsync(true, ledgerName, confidentialLedger);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: ConfidentialLedgerGet
            string ledgerName = "DummyLedgerName";

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/DummyResourceGroupName")).GetConfidentialLedgers();
            await collection.GetAsync(ledgerName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: ConfidentialLedgerList
            string filter = null;

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/DummyResourceGroupName")).GetConfidentialLedgers();
            await foreach (var _ in collection.GetAllAsync(filter))
            {
            }
        }
    }
}
