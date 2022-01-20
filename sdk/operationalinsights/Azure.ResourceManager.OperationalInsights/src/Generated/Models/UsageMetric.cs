// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> A metric describing the usage of a resource. </summary>
    public partial class UsageMetric
    {
        /// <summary> Initializes a new instance of UsageMetric. </summary>
        internal UsageMetric()
        {
        }

        /// <summary> Initializes a new instance of UsageMetric. </summary>
        /// <param name="name"> The name of the metric. </param>
        /// <param name="unit"> The units used for the metric. </param>
        /// <param name="currentValue"> The current value of the metric. </param>
        /// <param name="limit"> The quota limit for the metric. </param>
        /// <param name="nextResetTime"> The time that the metric&apos;s value will reset. </param>
        /// <param name="quotaPeriod"> The quota period that determines the length of time between value resets. </param>
        internal UsageMetric(MetricName name, string unit, double? currentValue, double? limit, DateTimeOffset? nextResetTime, string quotaPeriod)
        {
            Name = name;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            NextResetTime = nextResetTime;
            QuotaPeriod = quotaPeriod;
        }

        /// <summary> The name of the metric. </summary>
        public MetricName Name { get; }
        /// <summary> The units used for the metric. </summary>
        public string Unit { get; }
        /// <summary> The current value of the metric. </summary>
        public double? CurrentValue { get; }
        /// <summary> The quota limit for the metric. </summary>
        public double? Limit { get; }
        /// <summary> The time that the metric&apos;s value will reset. </summary>
        public DateTimeOffset? NextResetTime { get; }
        /// <summary> The quota period that determines the length of time between value resets. </summary>
        public string QuotaPeriod { get; }
    }
}
