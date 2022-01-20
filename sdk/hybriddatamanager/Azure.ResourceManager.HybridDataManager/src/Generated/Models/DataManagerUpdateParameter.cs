// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridDataManager.Models
{
    /// <summary> The DataManagerUpdateParameter. </summary>
    public partial class DataManagerUpdateParameter
    {
        /// <summary> Initializes a new instance of DataManagerUpdateParameter. </summary>
        public DataManagerUpdateParameter()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The sku type. </summary>
        public Sku Sku { get; set; }
        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource
        /// (across resource groups).
        /// </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
