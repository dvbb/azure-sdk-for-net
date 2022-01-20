// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Healthbot.Models
{
    /// <summary> The properties of a Azure Health Bot. The Health Bot Service is a cloud platform that empowers developers in Healthcare organizations to build and deploy their compliant, AI-powered virtual health assistants and health bots, that help them improve processes and reduce costs. </summary>
    public partial class HealthBotProperties
    {
        /// <summary> Initializes a new instance of HealthBotProperties. </summary>
        public HealthBotProperties()
        {
        }

        /// <summary> Initializes a new instance of HealthBotProperties. </summary>
        /// <param name="provisioningState"> The provisioning state of the Azure Health Bot resource. </param>
        /// <param name="botManagementPortalLink"> The link. </param>
        internal HealthBotProperties(string provisioningState, string botManagementPortalLink)
        {
            ProvisioningState = provisioningState;
            BotManagementPortalLink = botManagementPortalLink;
        }

        /// <summary> The provisioning state of the Azure Health Bot resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The link. </summary>
        public string BotManagementPortalLink { get; }
    }
}
