// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Marketplace.Tests.Mock;
using Azure.ResourceManager.Marketplace.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Marketplace.Tests.Mock.Tests.Mock
{
    /// <summary> Test for PrivateStore. </summary>
    public partial class PrivateStoreMockTests : MockTestBase
    {
        public PrivateStoreMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: GetPrivateStore
            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var privateStore = GetArmClient().GetPrivateStore(privateStoreId);

            await privateStore.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: DeletePrivateStores
            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var privateStore = GetArmClient().GetPrivateStore(privateStoreId);

            await privateStore.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task QueryOffers()
        {
            // Example: QueryOffers
            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var privateStore = GetArmClient().GetPrivateStore(privateStoreId);

            await foreach (var _ in privateStore.QueryOffersAsync())
            {
            }
        }

        [RecordedTest]
        public async Task BillingAccounts()
        {
            // Example: BillingAccounts
            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var privateStore = GetArmClient().GetPrivateStore(privateStoreId);

            await privateStore.BillingAccountsAsync();
        }

        [RecordedTest]
        public async Task CollectionsToSubscriptionsMapping()
        {
            // Example: CollectionsToSubscriptionsMapping
            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var privateStore = GetArmClient().GetPrivateStore(privateStoreId);
            Marketplace.Tests.Mock.Models.CollectionsToSubscriptionsMappingPayload payload = new Marketplace.Tests.Mock.Models.CollectionsToSubscriptionsMappingPayload()
            {
                Properties = new Marketplace.Tests.Mock.Models.CollectionsToSubscriptionsMappingProperties(),
            };

            await privateStore.CollectionsToSubscriptionsMappingAsync(payload);
        }

        [RecordedTest]
        public async Task QueryApprovedPlans()
        {
            // Example: QueryApprovedPlans
            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var privateStore = GetArmClient().GetPrivateStore(privateStoreId);
            Marketplace.Tests.Mock.Models.QueryApprovedPlansPayload payload = new Marketplace.Tests.Mock.Models.QueryApprovedPlansPayload()
            {
                OfferId = "marketplacetestthirdparty.md-test-third-party-2",
            };

            await privateStore.QueryApprovedPlansAsync(payload);
        }

        [RecordedTest]
        public async Task BulkCollectionsAction()
        {
            // Example: BulkCollectionsAction
            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var privateStore = GetArmClient().GetPrivateStore(privateStoreId);
            Marketplace.Tests.Mock.Models.BulkCollectionsPayload payload = new Marketplace.Tests.Mock.Models.BulkCollectionsPayload()
            {
                Action = "EnableCollections",
            };

            await privateStore.BulkCollectionsActionAsync(payload);
        }

        [RecordedTest]
        public async Task QueryNotificationsState()
        {
            // Example: NotificationsState
            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var privateStore = GetArmClient().GetPrivateStore(privateStoreId);

            await privateStore.QueryNotificationsStateAsync();
        }

        [RecordedTest]
        public async Task AcknowledgeOfferNotification()
        {
            // Example: AcknowledgeNotification
            var privateStoreId = Marketplace.Tests.Mock.PrivateStore.CreateResourceIdentifier("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            var privateStore = GetArmClient().GetPrivateStore(privateStoreId);
            string offerId = "marketplacetestthirdparty.md-test-third-party-2";
            Marketplace.Tests.Mock.Models.AcknowledgeOfferNotificationProperties payload = new Marketplace.Tests.Mock.Models.AcknowledgeOfferNotificationProperties()
            {
                Acknowledge = false,
                Dismiss = false,
                RemoveOffer = false,
            };

            await privateStore.AcknowledgeOfferNotificationAsync(offerId, payload);
        }
    }
}
