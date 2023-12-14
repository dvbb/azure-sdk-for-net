// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class KustoPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of <see cref="KustoPrivateLinkResourceListResult"/>. </summary>
        internal KustoPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<KustoPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="KustoPrivateLinkResourceListResult"/>. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal KustoPrivateLinkResourceListResult(IReadOnlyList<KustoPrivateLinkResourceData> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<KustoPrivateLinkResourceData> Value { get; }
    }
}
