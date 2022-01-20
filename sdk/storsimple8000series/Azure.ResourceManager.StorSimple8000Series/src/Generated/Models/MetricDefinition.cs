// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    /// <summary> The monitoring metric definition. </summary>
    public partial class MetricDefinition
    {
        /// <summary> Initializes a new instance of MetricDefinition. </summary>
        internal MetricDefinition()
        {
            MetricAvailabilities = new ChangeTrackingList<MetricAvailablity>();
            Dimensions = new ChangeTrackingList<MetricDimension>();
        }

        /// <summary> Initializes a new instance of MetricDefinition. </summary>
        /// <param name="name"> The metric name. </param>
        /// <param name="unit"> The metric unit. </param>
        /// <param name="primaryAggregationType"> The metric aggregation type. </param>
        /// <param name="resourceId"> The metric source ID. </param>
        /// <param name="metricAvailabilities"> The available metric granularities. </param>
        /// <param name="dimensions"> The available metric dimensions. </param>
        /// <param name="category"> The category of the metric. </param>
        /// <param name="type"> The metric definition type. </param>
        internal MetricDefinition(MetricName name, MetricUnit? unit, MetricAggregationType? primaryAggregationType, string resourceId, IReadOnlyList<MetricAvailablity> metricAvailabilities, IReadOnlyList<MetricDimension> dimensions, string category, string type)
        {
            Name = name;
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            ResourceId = resourceId;
            MetricAvailabilities = metricAvailabilities;
            Dimensions = dimensions;
            Category = category;
            Type = type;
        }

        /// <summary> The metric name. </summary>
        public MetricName Name { get; }
        /// <summary> The metric unit. </summary>
        public MetricUnit? Unit { get; }
        /// <summary> The metric aggregation type. </summary>
        public MetricAggregationType? PrimaryAggregationType { get; }
        /// <summary> The metric source ID. </summary>
        public string ResourceId { get; }
        /// <summary> The available metric granularities. </summary>
        public IReadOnlyList<MetricAvailablity> MetricAvailabilities { get; }
        /// <summary> The available metric dimensions. </summary>
        public IReadOnlyList<MetricDimension> Dimensions { get; }
        /// <summary> The category of the metric. </summary>
        public string Category { get; }
        /// <summary> The metric definition type. </summary>
        public string Type { get; }
    }
}
