// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Properties data connector on tenant level. </summary>
    internal partial class DataConnectorTenantId
    {
        /// <summary> Initializes a new instance of DataConnectorTenantId. </summary>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantId"/> is null. </exception>
        internal DataConnectorTenantId(string tenantId)
        {
            if (tenantId == null)
            {
                throw new ArgumentNullException(nameof(tenantId));
            }

            TenantId = tenantId;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        public string TenantId { get; }
    }
}
