// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> MCAS (Microsoft Cloud App Security) requirements check properties. </summary>
    internal partial class McasCheckRequirementsProperties : DataConnectorTenantId
    {
        /// <summary> Initializes a new instance of McasCheckRequirementsProperties. </summary>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantId"/> is null. </exception>
        internal McasCheckRequirementsProperties(string tenantId) : base(tenantId)
        {
            if (tenantId == null)
            {
                throw new ArgumentNullException(nameof(tenantId));
            }
        }
    }
}
