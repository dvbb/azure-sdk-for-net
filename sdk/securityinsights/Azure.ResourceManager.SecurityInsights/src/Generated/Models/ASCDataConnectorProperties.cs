// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> ASC (Azure Security Center) data connector properties. </summary>
    internal partial class ASCDataConnectorProperties : DataConnectorWithAlertsProperties
    {
        /// <summary> Initializes a new instance of ASCDataConnectorProperties. </summary>
        internal ASCDataConnectorProperties()
        {
        }

        /// <summary> The subscription id to connect to, and get the data from. </summary>
        public string SubscriptionId { get; }
    }
}
