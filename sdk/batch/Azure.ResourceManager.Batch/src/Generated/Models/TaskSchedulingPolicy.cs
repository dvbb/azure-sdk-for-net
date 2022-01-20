// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Specifies how tasks should be distributed across compute nodes. </summary>
    public partial class TaskSchedulingPolicy
    {
        /// <summary> Initializes a new instance of TaskSchedulingPolicy. </summary>
        /// <param name="nodeFillType"> How tasks should be distributed across compute nodes. </param>
        public TaskSchedulingPolicy(ComputeNodeFillType nodeFillType)
        {
            NodeFillType = nodeFillType;
        }

        /// <summary> How tasks should be distributed across compute nodes. </summary>
        public ComputeNodeFillType NodeFillType { get; set; }
    }
}
