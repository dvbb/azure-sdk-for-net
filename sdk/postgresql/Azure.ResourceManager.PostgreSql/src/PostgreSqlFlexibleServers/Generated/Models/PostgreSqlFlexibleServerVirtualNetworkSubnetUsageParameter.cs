// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Virtual network subnet usage parameter. </summary>
    public partial class PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter
    {
        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter"/>. </summary>
        public PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter"/>. </summary>
        /// <param name="virtualNetworkArmResourceId"> Virtual network resource id. </param>
        internal PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter(ResourceIdentifier virtualNetworkArmResourceId)
        {
            VirtualNetworkArmResourceId = virtualNetworkArmResourceId;
        }

        /// <summary> Virtual network resource id. </summary>
        public ResourceIdentifier VirtualNetworkArmResourceId { get; set; }
    }
}
