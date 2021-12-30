// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Management
{
    /// <summary> A class representing the HierarchySettings data model. </summary>
    public partial class HierarchySettingsData : Resource
    {
        /// <summary> Initializes a new instance of HierarchySettingsData. </summary>
        internal HierarchySettingsData()
        {
        }

        /// <summary> Initializes a new instance of HierarchySettingsData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tenantId"> The AAD Tenant ID associated with the hierarchy settings. For example, 00000000-0000-0000-0000-000000000000. </param>
        /// <param name="requireAuthorizationForGroupCreation"> Indicates whether RBAC access is required upon group creation under the root Management Group. If set to true, user will require Microsoft.Management/managementGroups/write action on the root Management Group scope in order to create new Groups directly under the root. This will prevent new users from creating new Management Groups, unless they are given access. </param>
        /// <param name="defaultManagementGroup"> Settings that sets the default Management Group under which new subscriptions get added in this tenant. For example, /providers/Microsoft.Management/managementGroups/defaultGroup. </param>
        internal HierarchySettingsData(ResourceIdentifier id, string name, ResourceType type, string tenantId, bool? requireAuthorizationForGroupCreation, string defaultManagementGroup) : base(id, name, type)
        {
            TenantId = tenantId;
            RequireAuthorizationForGroupCreation = requireAuthorizationForGroupCreation;
            DefaultManagementGroup = defaultManagementGroup;
        }

        /// <summary> The AAD Tenant ID associated with the hierarchy settings. For example, 00000000-0000-0000-0000-000000000000. </summary>
        public string TenantId { get; }
        /// <summary> Indicates whether RBAC access is required upon group creation under the root Management Group. If set to true, user will require Microsoft.Management/managementGroups/write action on the root Management Group scope in order to create new Groups directly under the root. This will prevent new users from creating new Management Groups, unless they are given access. </summary>
        public bool? RequireAuthorizationForGroupCreation { get; }
        /// <summary> Settings that sets the default Management Group under which new subscriptions get added in this tenant. For example, /providers/Microsoft.Management/managementGroups/defaultGroup. </summary>
        public string DefaultManagementGroup { get; }
    }
}
