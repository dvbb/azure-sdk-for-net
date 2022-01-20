// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    /// <summary> The resource model definition for a ARM proxy resource. It will have everything other than required location and tags. </summary>
    public partial class ProxyResource : Resource
    {
        /// <summary> Initializes a new instance of ProxyResource. </summary>
        public ProxyResource()
        {
        }

        /// <summary> Initializes a new instance of ProxyResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal ProxyResource(ResourceIdentifier id, string name, ResourceType type, string location) : base(id, name, type, location)
        {
        }
    }
}
