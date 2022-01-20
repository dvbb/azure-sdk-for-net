// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.StorageSync.Tests.Mock;
using Azure.ResourceManager.StorageSync.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.StorageSync.Tests.Mock.Tests.Mock
{
    /// <summary> Test for RegisteredServer. </summary>
    public partial class RegisteredServerMockTests : MockTestBase
    {
        public RegisteredServerMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: RegisteredServers_Get
            var registeredServerId = StorageSync.Tests.Mock.RegisteredServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "SampleResourceGroup_1", "SampleStorageSyncService_1", "080d4133-bdb5-40a0-96a0-71a6057bfe9a");
            var registeredServer = GetArmClient().GetRegisteredServer(registeredServerId);

            await registeredServer.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: RegisteredServers_Delete
            var registeredServerId = StorageSync.Tests.Mock.RegisteredServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "SampleResourceGroup_1", "SampleStorageSyncService_1", "41166691-ab03-43e9-ab3e-0330eda162ac");
            var registeredServer = GetArmClient().GetRegisteredServer(registeredServerId);

            await registeredServer.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task TriggerRollover()
        {
            // Example: RegisteredServers_triggerRollover
            var registeredServerId = StorageSync.Tests.Mock.RegisteredServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "SampleResourceGroup_1", "SampleStorageSyncService_1", "d166ca76-dad2-49df-b409-12345642d730");
            var registeredServer = GetArmClient().GetRegisteredServer(registeredServerId);
            StorageSync.Tests.Mock.Models.TriggerRolloverRequest parameters = new StorageSync.Tests.Mock.Models.TriggerRolloverRequest()
            {
                ServerCertificate = "\"MIIDFjCCAf6gAwIBAgIQQS+DS8uhc4VNzUkTw7wbRjANBgkqhkiG9w0BAQ0FADAzMTEwLwYDVQQDEyhhbmt1c2hiLXByb2QzLnJlZG1vbmQuY29ycC5taWNyb3NvZnQuY29tMB4XDTE3MDgwMzE3MDQyNFoXDTE4MDgwNDE3MDQyNFowMzExMC8GA1UEAxMoYW5rdXNoYi1wcm9kMy5yZWRtb25kLmNvcnAubWljcm9zb2Z0LmNvbTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBALDRvV4gmsIy6jGDPiHsXmvgVP749NNP7DopdlbHaNhjFmYINHl0uWylyaZmgJrROt2mnxN/zEyJtGnqYHlzUr4xvGq/qV5pqgdB9tag/sw9i22gfe9PRZ0FmSOZnXMbLYgLiDFqLtut5gHcOuWMj03YnkfoBEKlFBxWbagvW2yxz/Sxi9OVSJOKCaXra0RpcIHrO/KFl6ho2eE1/7Ykmfa8hZvSdoPd5gHdLiQcMB/pxq+mWp1fI6c8vFZoDu7Atn+NXTzYPKUxKzaisF12TsaKpohUsJpbB3Wocb0F5frn614D2pg14ERB5otjAMWw1m65csQWPI6dP8KIYe0+QPkCAwEAAaMmMCQwIgYDVR0lAQH/BBgwFgYIKwYBBQUHAwIGCisGAQQBgjcKAwwwDQYJKoZIhvcNAQENBQADggEBAA4RhVIBkw34M1RwakJgHvtjsOFxF1tVQA941NtLokx1l2Z8+GFQkcG4xpZSt+UN6wLerdCbnNhtkCErWUDeaT0jxk4g71Ofex7iM04crT4iHJr8mi96/XnhnkTUs+GDk12VgdeeNEczMZz+8Mxw9dJ5NCnYgTwO0SzGlclRsDvjzkLo8rh2ZG6n/jKrEyNXXo+hOqhupij0QbRP2Tvexdfw201kgN1jdZify8XzJ8Oi0bTS0KpJf2pNPOlooK2bjMUei9ANtEdXwwfVZGWvVh6tJjdv6k14wWWJ1L7zhA1IIVb1J+sQUzJji5iX0DrezjTz1Fg+gAzITaA/WsuujlM=\"",
            };

            await registeredServer.TriggerRolloverAsync(true, parameters);
        }
    }
}
