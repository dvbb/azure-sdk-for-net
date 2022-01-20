// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    /// <summary> The metric name filter, specifying the name of the metric to be filtered on. </summary>
    internal partial class MetricNameFilter
    {
        /// <summary> Initializes a new instance of MetricNameFilter. </summary>
        internal MetricNameFilter()
        {
        }

        /// <summary> Specifies the metric name to be filtered on. E.g., CloudStorageUsed. Valid values are the ones returned in the field &quot;name&quot; in the ListMetricDefinitions call. Only &apos;Equality&apos; operator is supported for this property. </summary>
        public string Value { get; }
    }
}
