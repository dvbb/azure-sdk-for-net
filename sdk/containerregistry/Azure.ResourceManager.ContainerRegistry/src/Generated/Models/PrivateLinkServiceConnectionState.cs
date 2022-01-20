// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The state of a private link service connection. </summary>
    public partial class PrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of PrivateLinkServiceConnectionState. </summary>
        public PrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkServiceConnectionState. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The description for connection status. For example if connection is rejected it can indicate reason for rejection. </param>
        /// <param name="actionsRequired"> A message indicating if changes on the service provider require any updates on the consumer. </param>
        internal PrivateLinkServiceConnectionState(ConnectionStatus? status, string description, ActionsRequired? actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The private link service connection status. </summary>
        public ConnectionStatus? Status { get; set; }
        /// <summary> The description for connection status. For example if connection is rejected it can indicate reason for rejection. </summary>
        public string Description { get; set; }
        /// <summary> A message indicating if changes on the service provider require any updates on the consumer. </summary>
        public ActionsRequired? ActionsRequired { get; set; }
    }
}
