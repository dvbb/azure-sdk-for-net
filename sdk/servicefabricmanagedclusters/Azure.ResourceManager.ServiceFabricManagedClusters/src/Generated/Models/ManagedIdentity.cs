// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes the managed identities for an Azure resource. </summary>
    public partial class ManagedIdentity
    {
        /// <summary> Initializes a new instance of ManagedIdentity. </summary>
        public ManagedIdentity()
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of ManagedIdentity. </summary>
        /// <param name="principalId"> The principal id of the managed identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant id of the managed identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="type"> The type of managed identity for the resource. </param>
        /// <param name="userAssignedIdentities">
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form:
        /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
        /// 
        /// </param>
        internal ManagedIdentity(string principalId, string tenantId, ManagedIdentityType? type, IDictionary<string, UserAssignedIdentity> userAssignedIdentities)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> The principal id of the managed identity. This property will only be provided for a system assigned identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The tenant id of the managed identity. This property will only be provided for a system assigned identity. </summary>
        public string TenantId { get; }
        /// <summary> The type of managed identity for the resource. </summary>
        public ManagedIdentityType? Type { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form:
        /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
        /// 
        /// </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
