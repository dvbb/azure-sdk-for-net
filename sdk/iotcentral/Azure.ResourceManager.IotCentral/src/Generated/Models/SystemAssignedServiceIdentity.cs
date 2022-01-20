// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> Managed service identity (either system assigned, or none). </summary>
    public partial class SystemAssignedServiceIdentity
    {
        /// <summary> Initializes a new instance of SystemAssignedServiceIdentity. </summary>
        /// <param name="type"> Type of managed service identity (either system assigned, or none). </param>
        public SystemAssignedServiceIdentity(SystemAssignedServiceIdentityType type)
        {
            Type = type;
        }

        /// <summary> Initializes a new instance of SystemAssignedServiceIdentity. </summary>
        /// <param name="principalId"> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="type"> Type of managed service identity (either system assigned, or none). </param>
        internal SystemAssignedServiceIdentity(Guid? principalId, Guid? tenantId, SystemAssignedServiceIdentityType type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }

        /// <summary> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public Guid? TenantId { get; }
        /// <summary> Type of managed service identity (either system assigned, or none). </summary>
        public SystemAssignedServiceIdentityType Type { get; set; }
    }
}
