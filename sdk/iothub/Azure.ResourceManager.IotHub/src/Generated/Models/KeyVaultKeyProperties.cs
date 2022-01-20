// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of the KeyVault key. </summary>
    public partial class KeyVaultKeyProperties
    {
        /// <summary> Initializes a new instance of KeyVaultKeyProperties. </summary>
        public KeyVaultKeyProperties()
        {
        }

        /// <summary> Initializes a new instance of KeyVaultKeyProperties. </summary>
        /// <param name="keyIdentifier"> The identifier of the key. </param>
        /// <param name="identity"> Managed identity properties of KeyVault Key. </param>
        internal KeyVaultKeyProperties(string keyIdentifier, ManagedIdentity identity)
        {
            KeyIdentifier = keyIdentifier;
            Identity = identity;
        }

        /// <summary> The identifier of the key. </summary>
        public string KeyIdentifier { get; set; }
        /// <summary> Managed identity properties of KeyVault Key. </summary>
        public ManagedIdentity Identity { get; set; }
    }
}
