// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Search;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Response containing a list of Private Endpoint connections. </summary>
    internal partial class PrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionListResult. </summary>
        internal PrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<PrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> The list of Private Endpoint connections. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of private endpoint connections. Returned when the total number of requested private endpoint connections exceed maximum page size. </param>
        internal PrivateEndpointConnectionListResult(IReadOnlyList<PrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of Private Endpoint connections. </summary>
        public IReadOnlyList<PrivateEndpointConnectionData> Value { get; }
        /// <summary> Request URL that can be used to query next page of private endpoint connections. Returned when the total number of requested private endpoint connections exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
