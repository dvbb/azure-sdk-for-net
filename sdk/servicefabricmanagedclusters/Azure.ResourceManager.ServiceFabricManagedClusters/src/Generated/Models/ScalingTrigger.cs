// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes the trigger for performing a scaling operation. </summary>
    public partial class ScalingTrigger
    {
        /// <summary> Initializes a new instance of ScalingTrigger. </summary>
        public ScalingTrigger()
        {
        }

        /// <summary> Initializes a new instance of ScalingTrigger. </summary>
        /// <param name="kind"> Specifies the trigger associated with this scaling policy. </param>
        internal ScalingTrigger(ServiceScalingTriggerKind kind)
        {
            Kind = kind;
        }

        /// <summary> Specifies the trigger associated with this scaling policy. </summary>
        internal ServiceScalingTriggerKind Kind { get; set; }
    }
}
