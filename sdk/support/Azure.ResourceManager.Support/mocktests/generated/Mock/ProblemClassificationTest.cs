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
    /// <summary> Test for ProblemClassification. </summary>
    public partial class ProblemClassificationMockTests : MockTestBase
    {
        public ProblemClassificationMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Gets details of problemClassification for Azure service
            var problemClassificationId = Support.Tests.Mock.ProblemClassification.CreateResourceIdentifier("service_guid", "problemClassification_guid");
            var problemClassification = GetArmClient().GetProblemClassification(problemClassificationId);

            await problemClassification.GetAsync();
        }
    }
}
