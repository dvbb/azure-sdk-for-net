// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal static partial class OSFamilyExtensions
    {
        public static string ToSerialString(this OSFamily value) => value switch
        {
            OSFamily.Linux => "Linux",
            OSFamily.Windows => "Windows",
            OSFamily.Android => "Android",
            OSFamily.IOS => "IOS",
            OSFamily.Unknown => "Unknown",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OSFamily value.")
        };

        public static OSFamily ToOSFamily(this string value)
        {
            if (string.Equals(value, "Linux", StringComparison.InvariantCultureIgnoreCase)) return OSFamily.Linux;
            if (string.Equals(value, "Windows", StringComparison.InvariantCultureIgnoreCase)) return OSFamily.Windows;
            if (string.Equals(value, "Android", StringComparison.InvariantCultureIgnoreCase)) return OSFamily.Android;
            if (string.Equals(value, "IOS", StringComparison.InvariantCultureIgnoreCase)) return OSFamily.IOS;
            if (string.Equals(value, "Unknown", StringComparison.InvariantCultureIgnoreCase)) return OSFamily.Unknown;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OSFamily value.");
        }
    }
}
