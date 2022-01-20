// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ManagedNetwork.Models;

namespace Azure.ResourceManager.ManagedNetwork
{
    /// <summary> A class representing the ManagedNetworkPeeringPolicy data model. </summary>
    public partial class ManagedNetworkPeeringPolicyData : ProxyResource
    {
        /// <summary> Initializes a new instance of ManagedNetworkPeeringPolicyData. </summary>
        public ManagedNetworkPeeringPolicyData()
        {
        }

        /// <summary> Initializes a new instance of ManagedNetworkPeeringPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="properties"> Gets or sets the properties of a Managed Network Policy. </param>
        internal ManagedNetworkPeeringPolicyData(ResourceIdentifier id, string name, ResourceType type, string location, ManagedNetworkPeeringPolicyProperties properties) : base(id, name, type, location)
        {
            Properties = properties;
        }

        /// <summary> Gets or sets the properties of a Managed Network Policy. </summary>
        public ManagedNetworkPeeringPolicyProperties Properties { get; set; }
    }
}
