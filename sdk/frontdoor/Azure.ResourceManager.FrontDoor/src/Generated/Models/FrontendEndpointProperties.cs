// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The JSON object that contains the properties required to create a frontend endpoint. </summary>
    internal partial class FrontendEndpointProperties : FrontendEndpointUpdateParameters
    {
        /// <summary> Initializes a new instance of FrontendEndpointProperties. </summary>
        internal FrontendEndpointProperties()
        {
        }

        /// <summary> Resource status. </summary>
        public FrontDoorResourceState? ResourceState { get; }
        /// <summary> Provisioning status of Custom Https of the frontendEndpoint. </summary>
        public CustomHttpsProvisioningState? CustomHttpsProvisioningState { get; }
        /// <summary> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. </summary>
        public CustomHttpsProvisioningSubstate? CustomHttpsProvisioningSubstate { get; }
        /// <summary> The configuration specifying how to enable HTTPS. </summary>
        public CustomHttpsConfiguration CustomHttpsConfiguration { get; }
    }
}
