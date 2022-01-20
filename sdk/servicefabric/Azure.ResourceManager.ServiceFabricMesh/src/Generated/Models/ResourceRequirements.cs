// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    /// <summary> This type describes the resource requirements for a container or a service. </summary>
    public partial class ResourceRequirements
    {
        /// <summary> Initializes a new instance of ResourceRequirements. </summary>
        /// <param name="requests"> Describes the requested resources for a given container. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requests"/> is null. </exception>
        public ResourceRequirements(ResourceRequests requests)
        {
            if (requests == null)
            {
                throw new ArgumentNullException(nameof(requests));
            }

            Requests = requests;
        }

        /// <summary> Initializes a new instance of ResourceRequirements. </summary>
        /// <param name="requests"> Describes the requested resources for a given container. </param>
        /// <param name="limits"> Describes the maximum limits on the resources for a given container. </param>
        internal ResourceRequirements(ResourceRequests requests, ResourceLimits limits)
        {
            Requests = requests;
            Limits = limits;
        }

        /// <summary> Describes the requested resources for a given container. </summary>
        public ResourceRequests Requests { get; set; }
        /// <summary> Describes the maximum limits on the resources for a given container. </summary>
        public ResourceLimits Limits { get; set; }
    }
}
