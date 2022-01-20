// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Support.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Support.Tests.Mock.Tests.Mock
{
    /// <summary> Test for CommunicationDetails. </summary>
    public partial class CommunicationDetailsCollectionMockTests : MockTestBase
    {
        public CommunicationDetailsCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: AddCommunicationToSubscriptionTicket
            string communicationName = "testcommunication";
            Support.Tests.Mock.CommunicationDetailsData createCommunicationParameters = new Support.Tests.Mock.CommunicationDetailsData()
            {
                Sender = "user@contoso.com",
                Subject = "This is a test message from a customer!",
                Body = "This is a test message from a customer!",
            };

            var supportTicketDetailsId = Support.Tests.Mock.SupportTicketDetails.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testticket");
            var collection = GetArmClient().GetSupportTicketDetails(supportTicketDetailsId).GetCommunicationDetails();
            await collection.CreateOrUpdateAsync(true, communicationName, createCommunicationParameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get communication details for a subscription support ticket
            string communicationName = "testmessage";

            var supportTicketDetailsId = Support.Tests.Mock.SupportTicketDetails.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testticket");
            var collection = GetArmClient().GetSupportTicketDetails(supportTicketDetailsId).GetCommunicationDetails();
            await collection.GetAsync(communicationName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List communications for a subscription support ticket
            int? top = null;
            string filter = null;

            var supportTicketDetailsId = Support.Tests.Mock.SupportTicketDetails.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testticket");
            var collection = GetArmClient().GetSupportTicketDetails(supportTicketDetailsId).GetCommunicationDetails();
            await foreach (var _ in collection.GetAllAsync(top, filter))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll2()
        {
            // Example: List web communication created on or after a specific date for a subscription support ticket
            int? top = null;
            string filter = "communicationType eq 'web' and createdDate ge 2020-03-10T22:08:51Z";

            var supportTicketDetailsId = Support.Tests.Mock.SupportTicketDetails.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testticket");
            var collection = GetArmClient().GetSupportTicketDetails(supportTicketDetailsId).GetCommunicationDetails();
            await foreach (var _ in collection.GetAllAsync(top, filter))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll3()
        {
            // Example: List web communications for a subscription support ticket
            int? top = null;
            string filter = "communicationType eq 'web'";

            var supportTicketDetailsId = Support.Tests.Mock.SupportTicketDetails.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testticket");
            var collection = GetArmClient().GetSupportTicketDetails(supportTicketDetailsId).GetCommunicationDetails();
            await foreach (var _ in collection.GetAllAsync(top, filter))
            {
            }
        }
    }
}
