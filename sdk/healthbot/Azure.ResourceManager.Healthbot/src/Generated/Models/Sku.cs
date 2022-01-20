// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Healthbot.Models
{
    /// <summary> The resource model definition representing SKU. </summary>
    public partial class Sku
    {
        /// <summary> Initializes a new instance of Sku. </summary>
        /// <param name="name"> The name of the Azure Health Bot SKU. </param>
        public Sku(SkuName name)
        {
            Name = name;
        }

        /// <summary> The name of the Azure Health Bot SKU. </summary>
        public SkuName Name { get; set; }
    }
}
