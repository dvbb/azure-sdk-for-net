// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    internal static partial class ScheduleStatusExtensions
    {
        public static string ToSerialString(this ScheduleStatus value) => value switch
        {
            ScheduleStatus.Enabled => "Enabled",
            ScheduleStatus.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ScheduleStatus value.")
        };

        public static ScheduleStatus ToScheduleStatus(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return ScheduleStatus.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return ScheduleStatus.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ScheduleStatus value.");
        }
    }
}
