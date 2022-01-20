// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary> A class representing the CertificateResource data model. </summary>
    public partial class CertificateResourceData : ProxyResource
    {
        /// <summary> Initializes a new instance of CertificateResourceData. </summary>
        public CertificateResourceData()
        {
        }

        /// <summary> Initializes a new instance of CertificateResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="properties"> Properties of the certificate resource payload. </param>
        internal CertificateResourceData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, CertificateProperties properties) : base(id, name, type, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the certificate resource payload. </summary>
        public CertificateProperties Properties { get; set; }
    }
}
