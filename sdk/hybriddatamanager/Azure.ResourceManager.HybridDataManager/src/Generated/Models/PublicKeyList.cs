// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridDataManager;

namespace Azure.ResourceManager.HybridDataManager.Models
{
    /// <summary> PublicKey Collection. </summary>
    internal partial class PublicKeyList
    {
        /// <summary> Initializes a new instance of PublicKeyList. </summary>
        internal PublicKeyList()
        {
            Value = new ChangeTrackingList<PublicKeyData>();
        }

        /// <summary> Initializes a new instance of PublicKeyList. </summary>
        /// <param name="value"> List of public keys. </param>
        /// <param name="nextLink"> Link for the next set of public keys. </param>
        internal PublicKeyList(IReadOnlyList<PublicKeyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of public keys. </summary>
        public IReadOnlyList<PublicKeyData> Value { get; }
        /// <summary> Link for the next set of public keys. </summary>
        public string NextLink { get; }
    }
}
