// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.DeviceProvisioningServices.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.DeviceProvisioningServices.Tests.Mock.Tests.Mock
{
    /// <summary> Test for PrivateEndpointConnection. </summary>
    public partial class PrivateEndpointConnectionMockTests : MockTestBase
    {
        public PrivateEndpointConnectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: PrivateEndpointConnection_Get
            var privateEndpointConnectionId = DeviceProvisioningServices.Tests.Mock.PrivateEndpointConnection.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myFirstProvisioningService", "myPrivateEndpointConnection");
            var privateEndpointConnection = GetArmClient().GetPrivateEndpointConnection(privateEndpointConnectionId);

            await privateEndpointConnection.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: PrivateEndpointConnection_Delete
            var privateEndpointConnectionId = DeviceProvisioningServices.Tests.Mock.PrivateEndpointConnection.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myFirstProvisioningService", "myPrivateEndpointConnection");
            var privateEndpointConnection = GetArmClient().GetPrivateEndpointConnection(privateEndpointConnectionId);

            await privateEndpointConnection.DeleteAsync(true);
        }
    }
}
