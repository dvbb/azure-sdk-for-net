// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Search.Models
{
    internal static partial class SkuNameExtensions
    {
        public static string ToSerialString(this SkuName value) => value switch
        {
            SkuName.Free => "free",
            SkuName.Basic => "basic",
            SkuName.Standard => "standard",
            SkuName.Standard2 => "standard2",
            SkuName.Standard3 => "standard3",
            SkuName.StorageOptimizedL1 => "storage_optimized_l1",
            SkuName.StorageOptimizedL2 => "storage_optimized_l2",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuName value.")
        };

        public static SkuName ToSkuName(this string value)
        {
            if (string.Equals(value, "free", StringComparison.InvariantCultureIgnoreCase)) return SkuName.Free;
            if (string.Equals(value, "basic", StringComparison.InvariantCultureIgnoreCase)) return SkuName.Basic;
            if (string.Equals(value, "standard", StringComparison.InvariantCultureIgnoreCase)) return SkuName.Standard;
            if (string.Equals(value, "standard2", StringComparison.InvariantCultureIgnoreCase)) return SkuName.Standard2;
            if (string.Equals(value, "standard3", StringComparison.InvariantCultureIgnoreCase)) return SkuName.Standard3;
            if (string.Equals(value, "storage_optimized_l1", StringComparison.InvariantCultureIgnoreCase)) return SkuName.StorageOptimizedL1;
            if (string.Equals(value, "storage_optimized_l2", StringComparison.InvariantCultureIgnoreCase)) return SkuName.StorageOptimizedL2;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuName value.");
        }
    }
}
