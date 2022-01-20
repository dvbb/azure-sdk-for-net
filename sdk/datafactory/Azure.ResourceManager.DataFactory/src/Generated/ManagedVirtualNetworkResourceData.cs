// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary> A class representing the ManagedVirtualNetworkResource data model. </summary>
    public partial class ManagedVirtualNetworkResourceData : SubResource
    {
        /// <summary> Initializes a new instance of ManagedVirtualNetworkResourceData. </summary>
        /// <param name="properties"> Managed Virtual Network properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public ManagedVirtualNetworkResourceData(ManagedVirtualNetwork properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of ManagedVirtualNetworkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="etag"> Etag identifies change in the resource. </param>
        /// <param name="properties"> Managed Virtual Network properties. </param>
        internal ManagedVirtualNetworkResourceData(ResourceIdentifier id, string name, ResourceType type, string etag, ManagedVirtualNetwork properties) : base(id, name, type, etag)
        {
            Properties = properties;
        }

        /// <summary> Managed Virtual Network properties. </summary>
        public ManagedVirtualNetwork Properties { get; set; }
    }
}
