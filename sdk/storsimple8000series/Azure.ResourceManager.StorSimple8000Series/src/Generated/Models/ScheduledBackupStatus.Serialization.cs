// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    internal static partial class ScheduledBackupStatusExtensions
    {
        public static string ToSerialString(this ScheduledBackupStatus value) => value switch
        {
            ScheduledBackupStatus.Disabled => "Disabled",
            ScheduledBackupStatus.Enabled => "Enabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ScheduledBackupStatus value.")
        };

        public static ScheduledBackupStatus ToScheduledBackupStatus(this string value)
        {
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return ScheduledBackupStatus.Disabled;
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return ScheduledBackupStatus.Enabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ScheduledBackupStatus value.");
        }
    }
}
