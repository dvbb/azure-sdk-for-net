// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> OfficeIRM (Microsoft Insider Risk Management) data connector properties. </summary>
    internal partial class OfficeIRMDataConnectorProperties : DataConnectorTenantId
    {
        /// <summary> Initializes a new instance of OfficeIRMDataConnectorProperties. </summary>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantId"/> is null. </exception>
        internal OfficeIRMDataConnectorProperties(string tenantId) : base(tenantId)
        {
            if (tenantId == null)
            {
                throw new ArgumentNullException(nameof(tenantId));
            }
        }

        /// <summary> The available data types for the connector. </summary>
        public AlertsDataTypeOfDataConnector DataTypes { get; }
    }
}
