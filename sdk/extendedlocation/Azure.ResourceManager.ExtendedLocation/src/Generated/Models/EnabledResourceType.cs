// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ExtendedLocation.Models
{
    /// <summary> EnabledResourceType definition. </summary>
    public partial class EnabledResourceType : Resource
    {
        /// <summary> Initializes a new instance of EnabledResourceType. </summary>
        public EnabledResourceType()
        {
            TypesMetadata = new ChangeTrackingList<EnabledResourceTypePropertiesTypesMetadataItem>();
        }

        /// <summary> Initializes a new instance of EnabledResourceType. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="clusterExtensionId"> Cluster Extension ID. </param>
        /// <param name="extensionType"> Cluster Extension Type. </param>
        /// <param name="typesMetadata"> Metadata of the Resource Type. </param>
        internal EnabledResourceType(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string clusterExtensionId, string extensionType, IList<EnabledResourceTypePropertiesTypesMetadataItem> typesMetadata) : base(id, name, type)
        {
            SystemData = systemData;
            ClusterExtensionId = clusterExtensionId;
            ExtensionType = extensionType;
            TypesMetadata = typesMetadata;
        }

        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> Cluster Extension ID. </summary>
        public string ClusterExtensionId { get; set; }
        /// <summary> Cluster Extension Type. </summary>
        public string ExtensionType { get; set; }
        /// <summary> Metadata of the Resource Type. </summary>
        public IList<EnabledResourceTypePropertiesTypesMetadataItem> TypesMetadata { get; }
    }
}
