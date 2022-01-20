// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The private link service connection state of the private endpoint connection. </summary>
    public partial class PrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of PrivateLinkServiceConnectionState. </summary>
        /// <param name="status"> The status of the Batch private endpoint connection. </param>
        public PrivateLinkServiceConnectionState(PrivateLinkServiceConnectionStatus status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of PrivateLinkServiceConnectionState. </summary>
        /// <param name="status"> The status of the Batch private endpoint connection. </param>
        /// <param name="description"> Description of the private Connection state. </param>
        /// <param name="actionRequired"> Action required on the private connection state. </param>
        internal PrivateLinkServiceConnectionState(PrivateLinkServiceConnectionStatus status, string description, string actionRequired)
        {
            Status = status;
            Description = description;
            ActionRequired = actionRequired;
        }

        /// <summary> The status of the Batch private endpoint connection. </summary>
        public PrivateLinkServiceConnectionStatus Status { get; set; }
        /// <summary> Description of the private Connection state. </summary>
        public string Description { get; set; }
        /// <summary> Action required on the private connection state. </summary>
        public string ActionRequired { get; }
    }
}
