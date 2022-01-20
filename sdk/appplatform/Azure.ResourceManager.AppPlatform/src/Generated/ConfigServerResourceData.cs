// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary> A class representing the ConfigServerResource data model. </summary>
    public partial class ConfigServerResourceData : ProxyResource
    {
        /// <summary> Initializes a new instance of ConfigServerResourceData. </summary>
        public ConfigServerResourceData()
        {
        }

        /// <summary> Initializes a new instance of ConfigServerResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="properties"> Properties of the Config Server resource. </param>
        internal ConfigServerResourceData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, ConfigServerProperties properties) : base(id, name, type, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the Config Server resource. </summary>
        public ConfigServerProperties Properties { get; set; }
    }
}
