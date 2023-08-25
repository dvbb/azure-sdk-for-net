// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The IntegrationRuntimeDataFlowCustomItem. </summary>
    public partial class IntegrationRuntimeDataFlowCustomItem
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeDataFlowCustomItem. </summary>
        public IntegrationRuntimeDataFlowCustomItem()
        {
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeDataFlowCustomItem. </summary>
        /// <param name="name"> Name of custom property. </param>
        /// <param name="value"> Value of custom property. </param>
        internal IntegrationRuntimeDataFlowCustomItem(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> Name of custom property. </summary>
        public string Name { get; set; }
        /// <summary> Value of custom property. </summary>
        public string Value { get; set; }
    }
}
