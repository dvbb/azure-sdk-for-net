// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> The UnknownPlannedFailoverModelCustomProperties. </summary>
    internal partial class UnknownPlannedFailoverModelCustomProperties : PlannedFailoverModelCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownPlannedFailoverModelCustomProperties"/>. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        internal UnknownPlannedFailoverModelCustomProperties(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}
