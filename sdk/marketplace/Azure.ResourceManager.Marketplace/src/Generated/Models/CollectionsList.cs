// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> The CollectionsList. </summary>
    internal partial class CollectionsList
    {
        /// <summary> Initializes a new instance of <see cref="CollectionsList"/>. </summary>
        internal CollectionsList()
        {
            Value = new ChangeTrackingList<PrivateStoreCollectionInfoData>();
        }

        /// <summary> Initializes a new instance of <see cref="CollectionsList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of offer list results if there are any. </param>
        internal CollectionsList(IReadOnlyList<PrivateStoreCollectionInfoData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<PrivateStoreCollectionInfoData> Value { get; }
        /// <summary> URL to get the next set of offer list results if there are any. </summary>
        public string NextLink { get; }
    }
}
