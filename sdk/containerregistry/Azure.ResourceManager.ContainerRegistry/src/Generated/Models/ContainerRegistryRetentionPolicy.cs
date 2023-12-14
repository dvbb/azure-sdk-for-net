// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The retention policy for a container registry. </summary>
    public partial class ContainerRegistryRetentionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryRetentionPolicy"/>. </summary>
        public ContainerRegistryRetentionPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryRetentionPolicy"/>. </summary>
        /// <param name="days"> The number of days to retain an untagged manifest after which it gets purged. </param>
        /// <param name="lastUpdatedOn"> The timestamp when the policy was last updated. </param>
        /// <param name="status"> The value that indicates whether the policy is enabled or not. </param>
        internal ContainerRegistryRetentionPolicy(int? days, DateTimeOffset? lastUpdatedOn, ContainerRegistryPolicyStatus? status)
        {
            Days = days;
            LastUpdatedOn = lastUpdatedOn;
            Status = status;
        }

        /// <summary> The number of days to retain an untagged manifest after which it gets purged. </summary>
        public int? Days { get; set; }
        /// <summary> The timestamp when the policy was last updated. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> The value that indicates whether the policy is enabled or not. </summary>
        public ContainerRegistryPolicyStatus? Status { get; set; }
    }
}
