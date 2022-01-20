// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class PrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of PrivateLinkResourceListResult. </summary>
        internal PrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<PrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of PrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal PrivateLinkResourceListResult(IReadOnlyList<PrivateLinkResource> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<PrivateLinkResource> Value { get; }
    }
}
