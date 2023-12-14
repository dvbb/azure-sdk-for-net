// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The export policy for a container registry. </summary>
    internal partial class ContainerRegistryExportPolicy
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryExportPolicy"/>. </summary>
        public ContainerRegistryExportPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryExportPolicy"/>. </summary>
        /// <param name="status"> The value that indicates whether the policy is enabled or not. </param>
        internal ContainerRegistryExportPolicy(ContainerRegistryExportPolicyStatus? status)
        {
            Status = status;
        }

        /// <summary> The value that indicates whether the policy is enabled or not. </summary>
        public ContainerRegistryExportPolicyStatus? Status { get; set; }
    }
}
