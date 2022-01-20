// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The connection state of a managed private endpoint. </summary>
    public partial class ConnectionStateProperties
    {
        /// <summary> Initializes a new instance of ConnectionStateProperties. </summary>
        public ConnectionStateProperties()
        {
        }

        /// <summary> Initializes a new instance of ConnectionStateProperties. </summary>
        /// <param name="actionsRequired"> The actions required on the managed private endpoint. </param>
        /// <param name="description"> The managed private endpoint description. </param>
        /// <param name="status"> The approval status. </param>
        internal ConnectionStateProperties(string actionsRequired, string description, string status)
        {
            ActionsRequired = actionsRequired;
            Description = description;
            Status = status;
        }

        /// <summary> The actions required on the managed private endpoint. </summary>
        public string ActionsRequired { get; }
        /// <summary> The managed private endpoint description. </summary>
        public string Description { get; }
        /// <summary> The approval status. </summary>
        public string Status { get; }
    }
}
