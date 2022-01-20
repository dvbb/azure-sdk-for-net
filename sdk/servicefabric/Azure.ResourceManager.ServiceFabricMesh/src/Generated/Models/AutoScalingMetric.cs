// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    /// <summary> Describes the metric that is used for triggering auto scaling operation. Derived classes will describe resources or metrics. </summary>
    public partial class AutoScalingMetric
    {
        /// <summary> Initializes a new instance of AutoScalingMetric. </summary>
        public AutoScalingMetric()
        {
        }

        /// <summary> Initializes a new instance of AutoScalingMetric. </summary>
        /// <param name="kind"> The type of auto scaling metric. </param>
        internal AutoScalingMetric(AutoScalingMetricKind kind)
        {
            Kind = kind;
        }

        /// <summary> The type of auto scaling metric. </summary>
        internal AutoScalingMetricKind Kind { get; set; }
    }
}
