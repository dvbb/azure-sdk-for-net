// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Managed cluster update request. </summary>
    public partial class ManagedClusterUpdateParameters
    {
        /// <summary> Initializes a new instance of ManagedClusterUpdateParameters. </summary>
        public ManagedClusterUpdateParameters()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Managed cluster update parameters. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
