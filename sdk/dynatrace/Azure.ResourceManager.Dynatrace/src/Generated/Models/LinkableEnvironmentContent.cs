// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Request for getting all the linkable environments for a user. </summary>
    public partial class LinkableEnvironmentContent
    {
        /// <summary> Initializes a new instance of <see cref="LinkableEnvironmentContent"/>. </summary>
        public LinkableEnvironmentContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkableEnvironmentContent"/>. </summary>
        /// <param name="tenantId"> Tenant Id of the user in which they want to link the environment. </param>
        /// <param name="userPrincipal"> user principal id of the user. </param>
        /// <param name="region"> Azure region in which we want to link the environment. </param>
        internal LinkableEnvironmentContent(Guid? tenantId, string userPrincipal, AzureLocation? region)
        {
            TenantId = tenantId;
            UserPrincipal = userPrincipal;
            Region = region;
        }

        /// <summary> Tenant Id of the user in which they want to link the environment. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> user principal id of the user. </summary>
        public string UserPrincipal { get; set; }
        /// <summary> Azure region in which we want to link the environment. </summary>
        public AzureLocation? Region { get; set; }
    }
}
