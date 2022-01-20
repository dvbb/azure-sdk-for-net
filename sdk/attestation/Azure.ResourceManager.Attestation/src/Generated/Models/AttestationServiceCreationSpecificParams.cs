// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> Client supplied parameters used to create a new attestation provider. </summary>
    public partial class AttestationServiceCreationSpecificParams
    {
        /// <summary> Initializes a new instance of AttestationServiceCreationSpecificParams. </summary>
        public AttestationServiceCreationSpecificParams()
        {
        }

        /// <summary> JSON Web Key Set defining a set of X.509 Certificates that will represent the parent certificate for the signing certificate used for policy operations. </summary>
        public JsonWebKeySet PolicySigningCertificates { get; set; }
    }
}
