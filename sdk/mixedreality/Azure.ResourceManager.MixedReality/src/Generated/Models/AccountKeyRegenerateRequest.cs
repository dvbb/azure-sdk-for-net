// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MixedReality.Models
{
    /// <summary> Request for account key regeneration. </summary>
    public partial class AccountKeyRegenerateRequest
    {
        /// <summary> Initializes a new instance of AccountKeyRegenerateRequest. </summary>
        public AccountKeyRegenerateRequest()
        {
        }

        /// <summary> Serial of key to be regenerated. </summary>
        public Serial? Serial { get; set; }
    }
}
