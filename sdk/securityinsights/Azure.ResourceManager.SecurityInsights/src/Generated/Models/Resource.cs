// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Common fields that are returned in the response for all Azure Resource Manager resources. </summary>
    public partial class Resource : ResourceManager.Models.Resource
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        public Resource()
        {
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        internal Resource(ResourceIdentifier id, string name, ResourceType type, SystemData systemData) : base(id, name, type)
        {
            SystemData = systemData;
        }

        /// <summary> Azure Resource Manager metadata containing createdBy and modifiedBy information. </summary>
        public SystemData SystemData { get; }
    }
}
