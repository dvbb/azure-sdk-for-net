// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EdgeOrder;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Address Resource Collection. </summary>
    internal partial class AddressResourceList
    {
        /// <summary> Initializes a new instance of <see cref="AddressResourceList"/>. </summary>
        internal AddressResourceList()
        {
            Value = new ChangeTrackingList<EdgeOrderAddressData>();
        }

        /// <summary> Initializes a new instance of <see cref="AddressResourceList"/>. </summary>
        /// <param name="value"> List of address resources. </param>
        /// <param name="nextLink"> Link for the next set of job resources. </param>
        internal AddressResourceList(IReadOnlyList<EdgeOrderAddressData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of address resources. </summary>
        public IReadOnlyList<EdgeOrderAddressData> Value { get; }
        /// <summary> Link for the next set of job resources. </summary>
        public string NextLink { get; }
    }
}
