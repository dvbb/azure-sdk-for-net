// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Defines the SKU of an Azure Cognitive Search Service, which determines price tier and capacity limits. </summary>
    public partial class Sku
    {
        /// <summary> Initializes a new instance of Sku. </summary>
        public Sku()
        {
        }

        /// <summary> Initializes a new instance of Sku. </summary>
        /// <param name="name"> The SKU of the search service. Valid values include: &apos;free&apos;: Shared service. &apos;basic&apos;: Dedicated service with up to 3 replicas. &apos;standard&apos;: Dedicated service with up to 12 partitions and 12 replicas. &apos;standard2&apos;: Similar to standard, but with more capacity per search unit. &apos;standard3&apos;: The largest Standard offering with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to &apos;highDensity&apos;). &apos;storage_optimized_l1&apos;: Supports 1TB per partition, up to 12 partitions. &apos;storage_optimized_l2&apos;: Supports 2TB per partition, up to 12 partitions.&apos;. </param>
        internal Sku(SkuName? name)
        {
            Name = name;
        }

        /// <summary> The SKU of the search service. Valid values include: &apos;free&apos;: Shared service. &apos;basic&apos;: Dedicated service with up to 3 replicas. &apos;standard&apos;: Dedicated service with up to 12 partitions and 12 replicas. &apos;standard2&apos;: Similar to standard, but with more capacity per search unit. &apos;standard3&apos;: The largest Standard offering with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to &apos;highDensity&apos;). &apos;storage_optimized_l1&apos;: Supports 1TB per partition, up to 12 partitions. &apos;storage_optimized_l2&apos;: Supports 2TB per partition, up to 12 partitions.&apos;. </summary>
        public SkuName? Name { get; set; }
    }
}
