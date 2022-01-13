// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using Azure.ResourceManager.WebPubSub;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub.Tests.Mock
{
    /// <summary> Test for WebPubSub. </summary>
    public partial class WebPubSubMockTests : MockTestBase
    {
        public WebPubSubMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: WebPubSub_Get
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await webPubSub.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: WebPubSub_Delete
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await webPubSub.DeleteAsync();
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: WebPubSub_Update
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);
            WebPubSubData parameters = new WebPubSubData(location: "eastus")
            {
                Sku = new WebPubSubSku(name: "Standard_S1")
                {
                    Tier = new Models.WebPubSubSkuTier("Standard"),
                    Capacity = 1,
                },
                Identity = new Models.ManagedIdentity()
                {
                    Type = new Models.ManagedIdentityType("SystemAssigned"),
                },
                Tls = new Models.WebPubSubTlsSettings()
                {
                    ClientCertEnabled = false,
                },
                LiveTraceConfiguration = new Models.LiveTraceConfiguration()
                {
                    Enabled = "false",
                },
                NetworkAcls = new Models.WebPubSubNetworkAcls()
                {
                    DefaultAction = new Models.AclAction("Deny"),
                    PublicNetwork = new Models.NetworkAcl(),
                },
                PublicNetworkAccess = "Enabled",
                DisableLocalAuth = false,
                DisableAadAuth = false,
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>() { ["key1"] = "value1", });
            await webPubSub.UpdateAsync(parameters);
        }

        [RecordedTest]
        public async Task GetKeys()
        {
            // Example: WebPubSub_ListKeys
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await webPubSub.GetKeysAsync();
        }

        [RecordedTest]
        public async Task RegenerateKey()
        {
            // Example: WebPubSub_RegenerateKey
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);
            Models.RegenerateKeyParameters parameters = new Models.RegenerateKeyParameters()
            {
                KeyType = new Models.KeyType("Primary"),
            };

            await webPubSub.RegenerateKeyAsync(parameters);
        }

        [RecordedTest]
        public async Task Restart()
        {
            // Example: WebPubSub_Restart
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await webPubSub.RestartAsync();
        }

        [RecordedTest]
        public async Task GetSkus()
        {
            // Example: WebPubSub_ListSkus
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);
            
            var list = await (webPubSub.GetSkusAsync());
            foreach (var _ in list.Value)
            {
            }
        }

        [RecordedTest]
        public async Task GetWebPubSubPrivateLinkResources()
        {
            // Example: WebPubSubPrivateLinkResources_List
            var webPubSubId = WebPubSub.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myWebPubSubService");
            var webPubSub = GetArmClient().GetWebPubSub(webPubSubId);

            await foreach (var _ in webPubSub.GetWebPubSubPrivateLinkResourcesAsync())
            {
            }
        }
    }
}
