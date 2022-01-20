// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The X509 Certificate. </summary>
    public partial class CertificateWithNonceDescription : Resource
    {
        /// <summary> Initializes a new instance of CertificateWithNonceDescription. </summary>
        internal CertificateWithNonceDescription()
        {
        }

        /// <summary> Initializes a new instance of CertificateWithNonceDescription. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> The description of an X509 CA Certificate including the challenge nonce issued for the Proof-Of-Possession flow. </param>
        /// <param name="etag"> The entity tag. </param>
        internal CertificateWithNonceDescription(ResourceIdentifier id, string name, ResourceType type, CertificatePropertiesWithNonce properties, string etag) : base(id, name, type)
        {
            Properties = properties;
            Etag = etag;
        }

        /// <summary> The description of an X509 CA Certificate including the challenge nonce issued for the Proof-Of-Possession flow. </summary>
        public CertificatePropertiesWithNonce Properties { get; }
        /// <summary> The entity tag. </summary>
        public string Etag { get; }
    }
}
