// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Attestation;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> List of private endpoint connection associated with the specified storage account. </summary>
    internal partial class PrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionListResult. </summary>
        internal PrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<PrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        internal PrivateEndpointConnectionListResult(IReadOnlyList<PrivateEndpointConnectionData> value)
        {
            Value = value;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<PrivateEndpointConnectionData> Value { get; }
    }
}
