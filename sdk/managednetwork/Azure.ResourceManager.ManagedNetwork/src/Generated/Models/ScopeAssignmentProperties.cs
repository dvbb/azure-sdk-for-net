// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    /// <summary> Properties of Managed Network. </summary>
    public partial class ScopeAssignmentProperties : ResourceProperties
    {
        /// <summary> Initializes a new instance of ScopeAssignmentProperties. </summary>
        public ScopeAssignmentProperties()
        {
        }

        /// <summary> Initializes a new instance of ScopeAssignmentProperties. </summary>
        /// <param name="provisioningState"> Provisioning state of the ManagedNetwork resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="assignedManagedNetwork"> The managed network ID with scope will be assigned to. </param>
        internal ScopeAssignmentProperties(ProvisioningState? provisioningState, string etag, string assignedManagedNetwork) : base(provisioningState, etag)
        {
            AssignedManagedNetwork = assignedManagedNetwork;
        }

        /// <summary> The managed network ID with scope will be assigned to. </summary>
        public string AssignedManagedNetwork { get; set; }
    }
}
