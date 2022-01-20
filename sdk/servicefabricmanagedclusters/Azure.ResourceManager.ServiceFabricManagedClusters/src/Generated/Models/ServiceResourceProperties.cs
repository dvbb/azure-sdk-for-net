// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The service resource properties. </summary>
    public partial class ServiceResourceProperties : ServiceResourcePropertiesBase
    {
        /// <summary> Initializes a new instance of ServiceResourceProperties. </summary>
        /// <param name="serviceTypeName"> The name of the service type. </param>
        /// <param name="partitionDescription"> Describes how the service is partitioned. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceTypeName"/> or <paramref name="partitionDescription"/> is null. </exception>
        public ServiceResourceProperties(string serviceTypeName, Partition partitionDescription)
        {
            if (serviceTypeName == null)
            {
                throw new ArgumentNullException(nameof(serviceTypeName));
            }
            if (partitionDescription == null)
            {
                throw new ArgumentNullException(nameof(partitionDescription));
            }

            ServiceTypeName = serviceTypeName;
            PartitionDescription = partitionDescription;
            ServiceKind = new ServiceKind("ServiceResourceProperties");
        }

        /// <summary> Initializes a new instance of ServiceResourceProperties. </summary>
        /// <param name="placementConstraints"> The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes where NodeType is blue specify the following: &quot;NodeColor == blue)&quot;. </param>
        /// <param name="correlationScheme"> A list that describes the correlation of the service with other services. </param>
        /// <param name="serviceLoadMetrics"> The service load metrics is given as an array of ServiceLoadMetric objects. </param>
        /// <param name="servicePlacementPolicies"> A list that describes the correlation of the service with other services. </param>
        /// <param name="defaultMoveCost"> Specifies the move cost for the service. </param>
        /// <param name="scalingPolicies"> Scaling policies for this service. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state, which only appears in the response. </param>
        /// <param name="serviceKind"> The kind of service (Stateless or Stateful). </param>
        /// <param name="serviceTypeName"> The name of the service type. </param>
        /// <param name="partitionDescription"> Describes how the service is partitioned. </param>
        /// <param name="servicePackageActivationMode"> The activation Mode of the service package. </param>
        internal ServiceResourceProperties(string placementConstraints, IList<ServiceCorrelation> correlationScheme, IList<ServiceLoadMetric> serviceLoadMetrics, IList<ServicePlacementPolicy> servicePlacementPolicies, MoveCost? defaultMoveCost, IList<ScalingPolicy> scalingPolicies, string provisioningState, ServiceKind serviceKind, string serviceTypeName, Partition partitionDescription, ServicePackageActivationMode? servicePackageActivationMode) : base(placementConstraints, correlationScheme, serviceLoadMetrics, servicePlacementPolicies, defaultMoveCost, scalingPolicies)
        {
            ProvisioningState = provisioningState;
            ServiceKind = serviceKind;
            ServiceTypeName = serviceTypeName;
            PartitionDescription = partitionDescription;
            ServicePackageActivationMode = servicePackageActivationMode;
        }

        /// <summary> The current deployment or provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The kind of service (Stateless or Stateful). </summary>
        internal ServiceKind ServiceKind { get; set; }
        /// <summary> The name of the service type. </summary>
        public string ServiceTypeName { get; set; }
        /// <summary> Describes how the service is partitioned. </summary>
        public Partition PartitionDescription { get; set; }
        /// <summary> The activation Mode of the service package. </summary>
        public ServicePackageActivationMode? ServicePackageActivationMode { get; set; }
    }
}
