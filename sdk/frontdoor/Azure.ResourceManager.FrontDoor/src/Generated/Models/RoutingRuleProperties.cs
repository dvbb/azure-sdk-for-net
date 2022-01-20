// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The JSON object that contains the properties required to create a routing rule. </summary>
    internal partial class RoutingRuleProperties : RoutingRuleUpdateParameters
    {
        /// <summary> Initializes a new instance of RoutingRuleProperties. </summary>
        internal RoutingRuleProperties()
        {
        }

        /// <summary> Resource status. </summary>
        public FrontDoorResourceState? ResourceState { get; }
    }
}
