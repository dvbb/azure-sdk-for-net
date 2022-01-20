// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Values returned by the List operation. </summary>
    internal partial class ListPrivateEndpointConnectionsResult
    {
        /// <summary> Initializes a new instance of ListPrivateEndpointConnectionsResult. </summary>
        internal ListPrivateEndpointConnectionsResult()
        {
            Value = new ChangeTrackingList<PrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of ListPrivateEndpointConnectionsResult. </summary>
        /// <param name="value"> The collection of returned private endpoint connection. </param>
        /// <param name="nextLink"> The continuation token. </param>
        internal ListPrivateEndpointConnectionsResult(IReadOnlyList<PrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of returned private endpoint connection. </summary>
        public IReadOnlyList<PrivateEndpointConnectionData> Value { get; }
        /// <summary> The continuation token. </summary>
        public string NextLink { get; }
    }
}
