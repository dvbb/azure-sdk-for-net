// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    internal static partial class BackupStatusExtensions
    {
        public static string ToSerialString(this BackupStatus value) => value switch
        {
            BackupStatus.Enabled => "Enabled",
            BackupStatus.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BackupStatus value.")
        };

        public static BackupStatus ToBackupStatus(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return BackupStatus.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return BackupStatus.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BackupStatus value.");
        }
    }
}
