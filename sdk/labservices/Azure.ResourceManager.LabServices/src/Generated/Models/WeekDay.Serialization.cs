// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.LabServices.Models
{
    internal static partial class WeekDayExtensions
    {
        public static string ToSerialString(this WeekDay value) => value switch
        {
            WeekDay.Sunday => "Sunday",
            WeekDay.Monday => "Monday",
            WeekDay.Tuesday => "Tuesday",
            WeekDay.Wednesday => "Wednesday",
            WeekDay.Thursday => "Thursday",
            WeekDay.Friday => "Friday",
            WeekDay.Saturday => "Saturday",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WeekDay value.")
        };

        public static WeekDay ToWeekDay(this string value)
        {
            if (string.Equals(value, "Sunday", StringComparison.InvariantCultureIgnoreCase)) return WeekDay.Sunday;
            if (string.Equals(value, "Monday", StringComparison.InvariantCultureIgnoreCase)) return WeekDay.Monday;
            if (string.Equals(value, "Tuesday", StringComparison.InvariantCultureIgnoreCase)) return WeekDay.Tuesday;
            if (string.Equals(value, "Wednesday", StringComparison.InvariantCultureIgnoreCase)) return WeekDay.Wednesday;
            if (string.Equals(value, "Thursday", StringComparison.InvariantCultureIgnoreCase)) return WeekDay.Thursday;
            if (string.Equals(value, "Friday", StringComparison.InvariantCultureIgnoreCase)) return WeekDay.Friday;
            if (string.Equals(value, "Saturday", StringComparison.InvariantCultureIgnoreCase)) return WeekDay.Saturday;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WeekDay value.");
        }
    }
}
