// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Parameters for updating a factory resource. </summary>
    public partial class FactoryUpdateParameters
    {
        /// <summary> Initializes a new instance of FactoryUpdateParameters. </summary>
        public FactoryUpdateParameters()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Managed service identity of the factory. </summary>
        public FactoryIdentity Identity { get; set; }
        /// <summary> Whether or not public network access is allowed for the data factory. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
