// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> Parameters for creating or updating Management Group settings. </summary>
    public partial class CreateOrUpdateSettingsRequest
    {
        /// <summary> Initializes a new instance of CreateOrUpdateSettingsRequest. </summary>
        public CreateOrUpdateSettingsRequest()
        {
        }

        /// <summary> Indicates whether RBAC access is required upon group creation under the root Management Group. If set to true, user will require Microsoft.Management/managementGroups/write action on the root Management Group scope in order to create new Groups directly under the root. This will prevent new users from creating new Management Groups, unless they are given access. </summary>
        public bool? RequireAuthorizationForGroupCreation { get; set; }
        /// <summary> Settings that sets the default Management Group under which new subscriptions get added in this tenant. For example, /providers/Microsoft.Management/managementGroups/defaultGroup. </summary>
        public string DefaultManagementGroup { get; set; }
    }
}
