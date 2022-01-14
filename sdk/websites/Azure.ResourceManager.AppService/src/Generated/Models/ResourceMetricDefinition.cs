// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Metadata for the metrics. </summary>
    public partial class ResourceMetricDefinition : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of ResourceMetricDefinition. </summary>
        public ResourceMetricDefinition()
        {
            MetricAvailabilities = new ChangeTrackingList<ResourceMetricAvailability>();
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ResourceMetricDefinition. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="unit"> Unit of the metric. </param>
        /// <param name="primaryAggregationType"> Primary aggregation type. </param>
        /// <param name="metricAvailabilities"> List of time grains supported for the metric together with retention period. </param>
        /// <param name="resourceUri"> Resource URI. </param>
        /// <param name="properties"> Resource metric definition properties. </param>
        internal ResourceMetricDefinition(ResourceIdentifier id, string name, ResourceType type, string kind, string unit, string primaryAggregationType, IReadOnlyList<ResourceMetricAvailability> metricAvailabilities, string resourceUri, IReadOnlyDictionary<string, string> properties) : base(id, name, type, kind)
        {
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            MetricAvailabilities = metricAvailabilities;
            ResourceUri = resourceUri;
            Properties = properties;
        }

        /// <summary> Unit of the metric. </summary>
        public string Unit { get; }
        /// <summary> Primary aggregation type. </summary>
        public string PrimaryAggregationType { get; }
        /// <summary> List of time grains supported for the metric together with retention period. </summary>
        public IReadOnlyList<ResourceMetricAvailability> MetricAvailabilities { get; }
        /// <summary> Resource URI. </summary>
        public string ResourceUri { get; }
        /// <summary> Resource metric definition properties. </summary>
        public IReadOnlyDictionary<string, string> Properties { get; }
    }
}
