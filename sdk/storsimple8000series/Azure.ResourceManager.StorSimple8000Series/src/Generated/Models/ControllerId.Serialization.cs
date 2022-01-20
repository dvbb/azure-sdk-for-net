// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    internal static partial class ControllerIdExtensions
    {
        public static string ToSerialString(this ControllerId value) => value switch
        {
            ControllerId.Unknown => "Unknown",
            ControllerId.None => "None",
            ControllerId.Controller0 => "Controller0",
            ControllerId.Controller1 => "Controller1",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ControllerId value.")
        };

        public static ControllerId ToControllerId(this string value)
        {
            if (string.Equals(value, "Unknown", StringComparison.InvariantCultureIgnoreCase)) return ControllerId.Unknown;
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return ControllerId.None;
            if (string.Equals(value, "Controller0", StringComparison.InvariantCultureIgnoreCase)) return ControllerId.Controller0;
            if (string.Equals(value, "Controller1", StringComparison.InvariantCultureIgnoreCase)) return ControllerId.Controller1;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ControllerId value.");
        }
    }
}
