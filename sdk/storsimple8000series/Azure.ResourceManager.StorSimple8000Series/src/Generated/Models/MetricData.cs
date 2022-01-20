// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    /// <summary> The metric data. </summary>
    public partial class MetricData
    {
        /// <summary> Initializes a new instance of MetricData. </summary>
        internal MetricData()
        {
        }

        /// <summary> Initializes a new instance of MetricData. </summary>
        /// <param name="timeStamp"> The time stamp of the metric data. </param>
        /// <param name="sum"> The sum of all samples at the time stamp. </param>
        /// <param name="count"> The count of all samples at the time stamp. </param>
        /// <param name="average"> The average of all samples at the time stamp. </param>
        /// <param name="minimum"> The minimum of all samples at the time stamp. </param>
        /// <param name="maximum"> The maximum of all samples at the time stamp. </param>
        internal MetricData(DateTimeOffset? timeStamp, double? sum, int? count, double? average, double? minimum, double? maximum)
        {
            TimeStamp = timeStamp;
            Sum = sum;
            Count = count;
            Average = average;
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary> The time stamp of the metric data. </summary>
        public DateTimeOffset? TimeStamp { get; }
        /// <summary> The sum of all samples at the time stamp. </summary>
        public double? Sum { get; }
        /// <summary> The count of all samples at the time stamp. </summary>
        public int? Count { get; }
        /// <summary> The average of all samples at the time stamp. </summary>
        public double? Average { get; }
        /// <summary> The minimum of all samples at the time stamp. </summary>
        public double? Minimum { get; }
        /// <summary> The maximum of all samples at the time stamp. </summary>
        public double? Maximum { get; }
    }
}
