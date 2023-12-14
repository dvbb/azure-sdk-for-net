// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc. </summary>
    public partial class StorageSkuCapability
    {
        /// <summary> Initializes a new instance of <see cref="StorageSkuCapability"/>. </summary>
        internal StorageSkuCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageSkuCapability"/>. </summary>
        /// <param name="name"> The name of capability, The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc. </param>
        /// <param name="value"> A string value to indicate states of given capability. Possibly 'true' or 'false'. </param>
        internal StorageSkuCapability(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of capability, The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc. </summary>
        public string Name { get; }
        /// <summary> A string value to indicate states of given capability. Possibly 'true' or 'false'. </summary>
        public string Value { get; }
    }
}
