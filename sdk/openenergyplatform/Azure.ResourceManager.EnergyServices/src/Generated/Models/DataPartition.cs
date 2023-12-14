// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EnergyServices.Models
{
    /// <summary> Defines the properties of an individual data partition. </summary>
    public partial class DataPartition
    {
        /// <summary> Initializes a new instance of <see cref="DataPartition"/>. </summary>
        internal DataPartition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataPartition"/>. </summary>
        /// <param name="name"> Name of the data partition. </param>
        /// <param name="provisioningState"> Name of the data partition. </param>
        internal DataPartition(string name, string provisioningState)
        {
            Name = name;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the data partition. </summary>
        public string Name { get; }
        /// <summary> Name of the data partition. </summary>
        public string ProvisioningState { get; }
    }
}
