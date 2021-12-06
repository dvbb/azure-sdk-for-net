// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> SKU of the namespace. </summary>
    public partial class ServiceBusSku
    {
        /// <summary> Initializes a new instance of ServiceBusSku. </summary>
        /// <param name="name"> Name of this SKU. </param>
        public ServiceBusSku(SkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of ServiceBusSku. </summary>
        /// <param name="name"> Name of this SKU. </param>
        /// <param name="tier"> The billing tier of this particular SKU. </param>
        /// <param name="capacity"> The specified messaging units for the tier. For Premium tier, capacity are 1,2 and 4. </param>
        internal ServiceBusSku(SkuName name, SkuTier? tier, int? capacity)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
        }

        /// <summary> Name of this SKU. </summary>
        public SkuName Name { get; set; }
        /// <summary> The billing tier of this particular SKU. </summary>
        public SkuTier? Tier { get; set; }
        /// <summary> The specified messaging units for the tier. For Premium tier, capacity are 1,2 and 4. </summary>
        public int? Capacity { get; set; }
    }
}
