// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.CustomProviders.Tests.Mock;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.CustomProviders.Tests.Mock.Tests.Mock
{
    /// <summary> Test for Association. </summary>
    public partial class AssociationMockTests : MockTestBase
    {
        public AssociationMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get an association
            var associationId = CustomProviders.Tests.Mock.Association.CreateResourceIdentifier("scope", "associationName");
            var association = GetArmClient().GetAssociation(associationId);

            await association.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete an association
            var associationId = CustomProviders.Tests.Mock.Association.CreateResourceIdentifier("scope", "associationName");
            var association = GetArmClient().GetAssociation(associationId);

            await association.DeleteAsync(true);
        }
    }
}
