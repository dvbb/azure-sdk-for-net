// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> ServicePlacementNonPartiallyPlaceServicePolicy. </summary>
    public partial class ServicePlacementNonPartiallyPlaceServicePolicy : ServicePlacementPolicy
    {
        /// <summary> Initializes a new instance of ServicePlacementNonPartiallyPlaceServicePolicy. </summary>
        public ServicePlacementNonPartiallyPlaceServicePolicy()
        {
            Type = ServicePlacementPolicyType.NonPartiallyPlaceService;
        }

        /// <summary> Initializes a new instance of ServicePlacementNonPartiallyPlaceServicePolicy. </summary>
        /// <param name="type"> The type of placement policy for a service fabric service. Following are the possible values. </param>
        internal ServicePlacementNonPartiallyPlaceServicePolicy(ServicePlacementPolicyType type) : base(type)
        {
            Type = type;
        }
    }
}
