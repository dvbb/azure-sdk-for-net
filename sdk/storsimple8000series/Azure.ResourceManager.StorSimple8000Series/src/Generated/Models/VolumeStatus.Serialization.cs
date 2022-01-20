// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    internal static partial class VolumeStatusExtensions
    {
        public static string ToSerialString(this VolumeStatus value) => value switch
        {
            VolumeStatus.Online => "Online",
            VolumeStatus.Offline => "Offline",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VolumeStatus value.")
        };

        public static VolumeStatus ToVolumeStatus(this string value)
        {
            if (string.Equals(value, "Online", StringComparison.InvariantCultureIgnoreCase)) return VolumeStatus.Online;
            if (string.Equals(value, "Offline", StringComparison.InvariantCultureIgnoreCase)) return VolumeStatus.Offline;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VolumeStatus value.");
        }
    }
}
