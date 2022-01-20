// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Service update request. </summary>
    public partial class ServiceUpdateParameters
    {
        /// <summary> Initializes a new instance of ServiceUpdateParameters. </summary>
        public ServiceUpdateParameters()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Service update parameters. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
