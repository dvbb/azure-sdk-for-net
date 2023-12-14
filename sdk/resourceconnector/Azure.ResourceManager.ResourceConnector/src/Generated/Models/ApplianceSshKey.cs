// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> Appliance SSHKey definition. </summary>
    public partial class ApplianceSshKey
    {
        /// <summary> Initializes a new instance of <see cref="ApplianceSshKey"/>. </summary>
        internal ApplianceSshKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplianceSshKey"/>. </summary>
        /// <param name="certificate"> Certificate associated with the public key if the key is signed. </param>
        /// <param name="creationTimeStamp"> Certificate creation timestamp (Unix). </param>
        /// <param name="expirationTimeStamp"> Certificate expiration timestamp (Unix). </param>
        /// <param name="privateKey"> Private Key. </param>
        /// <param name="publicKey"> Public Key. </param>
        internal ApplianceSshKey(string certificate, long? creationTimeStamp, long? expirationTimeStamp, string privateKey, string publicKey)
        {
            Certificate = certificate;
            CreationTimeStamp = creationTimeStamp;
            ExpirationTimeStamp = expirationTimeStamp;
            PrivateKey = privateKey;
            PublicKey = publicKey;
        }

        /// <summary> Certificate associated with the public key if the key is signed. </summary>
        public string Certificate { get; }
        /// <summary> Certificate creation timestamp (Unix). </summary>
        public long? CreationTimeStamp { get; }
        /// <summary> Certificate expiration timestamp (Unix). </summary>
        public long? ExpirationTimeStamp { get; }
        /// <summary> Private Key. </summary>
        public string PrivateKey { get; }
        /// <summary> Public Key. </summary>
        public string PublicKey { get; }
    }
}
