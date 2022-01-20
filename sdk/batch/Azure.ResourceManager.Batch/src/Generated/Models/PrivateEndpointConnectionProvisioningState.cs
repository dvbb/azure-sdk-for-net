// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The provisioning state of the private endpoint connection. </summary>
    public enum PrivateEndpointConnectionProvisioningState
    {
        /// <summary> The connection status is final and is ready for use if Status is Approved. </summary>
        Succeeded,
        /// <summary> The user has requested that the connection status be updated, but the update operation has not yet completed. You may not reference the connection when connecting the Batch account. </summary>
        Updating,
        /// <summary> The user requested that the connection be updated and it failed. You may retry the update operation. </summary>
        Failed
    }
}
