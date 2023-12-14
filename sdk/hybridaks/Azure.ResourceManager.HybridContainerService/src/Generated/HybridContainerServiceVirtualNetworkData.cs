// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A class representing the HybridContainerServiceVirtualNetwork data model.
    /// The virtualNetworks resource definition.
    /// </summary>
    public partial class HybridContainerServiceVirtualNetworkData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceVirtualNetworkData"/>. </summary>
        /// <param name="location"> The location. </param>
        public HybridContainerServiceVirtualNetworkData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceVirtualNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> HybridAKSNetworkSpec defines the desired state of HybridAKSNetwork. </param>
        /// <param name="extendedLocation"></param>
        internal HybridContainerServiceVirtualNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, VirtualNetworksProperties properties, VirtualNetworksExtendedLocation extendedLocation) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ExtendedLocation = extendedLocation;
        }

        /// <summary> HybridAKSNetworkSpec defines the desired state of HybridAKSNetwork. </summary>
        public VirtualNetworksProperties Properties { get; set; }
        /// <summary> Gets or sets the extended location. </summary>
        public VirtualNetworksExtendedLocation ExtendedLocation { get; set; }
    }
}
