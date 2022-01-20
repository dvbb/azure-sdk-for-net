// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Scheduler.Models
{
    internal static partial class RetryTypeExtensions
    {
        public static string ToSerialString(this RetryType value) => value switch
        {
            RetryType.None => "None",
            RetryType.Fixed => "Fixed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RetryType value.")
        };

        public static RetryType ToRetryType(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return RetryType.None;
            if (string.Equals(value, "Fixed", StringComparison.InvariantCultureIgnoreCase)) return RetryType.Fixed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RetryType value.");
        }
    }
}
