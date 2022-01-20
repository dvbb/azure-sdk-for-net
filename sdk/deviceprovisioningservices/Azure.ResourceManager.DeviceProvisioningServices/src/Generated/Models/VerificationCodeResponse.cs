// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Description of the response of the verification code. </summary>
    public partial class VerificationCodeResponse : Resource
    {
        /// <summary> Initializes a new instance of VerificationCodeResponse. </summary>
        internal VerificationCodeResponse()
        {
        }

        /// <summary> Initializes a new instance of VerificationCodeResponse. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="etag"> Request etag. </param>
        /// <param name="properties"></param>
        internal VerificationCodeResponse(ResourceIdentifier id, string name, ResourceType type, string etag, VerificationCodeResponseProperties properties) : base(id, name, type)
        {
            Etag = etag;
            Properties = properties;
        }

        /// <summary> Request etag. </summary>
        public string Etag { get; }
        /// <summary> Gets the properties. </summary>
        public VerificationCodeResponseProperties Properties { get; }
    }
}
