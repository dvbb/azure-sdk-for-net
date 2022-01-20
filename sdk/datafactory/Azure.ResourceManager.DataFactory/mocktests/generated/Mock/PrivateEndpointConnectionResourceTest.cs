// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.DataFactory.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.DataFactory.Tests.Mock.Tests.Mock
{
    /// <summary> Test for PrivateEndpointConnectionResource. </summary>
    public partial class PrivateEndpointConnectionResourceMockTests : MockTestBase
    {
        public PrivateEndpointConnectionResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a private endpoint connection for a datafactory.
            var privateEndpointConnectionResourceId = DataFactory.Tests.Mock.PrivateEndpointConnectionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "exampleResourceGroup", "exampleFactoryName", "connection");
            var privateEndpointConnectionResource = GetArmClient().GetPrivateEndpointConnectionResource(privateEndpointConnectionResourceId);
            string ifNoneMatch = null;

            await privateEndpointConnectionResource.GetAsync(ifNoneMatch);
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete a private endpoint connection for a datafactory.
            var privateEndpointConnectionResourceId = DataFactory.Tests.Mock.PrivateEndpointConnectionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "exampleResourceGroup", "exampleFactoryName", "connection");
            var privateEndpointConnectionResource = GetArmClient().GetPrivateEndpointConnectionResource(privateEndpointConnectionResourceId);

            await privateEndpointConnectionResource.DeleteAsync(true);
        }
    }
}
