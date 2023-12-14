// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Collection of all the shares on the Data Box Edge/Gateway device. </summary>
    internal partial class ShareList
    {
        /// <summary> Initializes a new instance of <see cref="ShareList"/>. </summary>
        internal ShareList()
        {
            Value = new ChangeTrackingList<DataBoxEdgeShareData>();
        }

        /// <summary> Initializes a new instance of <see cref="ShareList"/>. </summary>
        /// <param name="value"> The list of shares. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal ShareList(IReadOnlyList<DataBoxEdgeShareData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of shares. </summary>
        public IReadOnlyList<DataBoxEdgeShareData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
