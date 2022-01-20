// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The JSON-serialized leaf certificate. </summary>
    public partial class VerificationCodeRequest
    {
        /// <summary> Initializes a new instance of VerificationCodeRequest. </summary>
        public VerificationCodeRequest()
        {
        }

        /// <summary> base-64 representation of X509 certificate .cer file or just .pem file content. </summary>
        public string Certificate { get; set; }
    }
}
