// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Support.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Support.Tests.Mock.Tests.Mock
{
    /// <summary> Test for CommunicationDetails. </summary>
    public partial class CommunicationDetailsMockTests : MockTestBase
    {
        public CommunicationDetailsMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get communication details for a subscription support ticket
            var communicationDetailsId = Support.Tests.Mock.CommunicationDetails.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testticket", "testmessage");
            var communicationDetails = GetArmClient().GetCommunicationDetails(communicationDetailsId);

            await communicationDetails.GetAsync();
        }
    }
}
