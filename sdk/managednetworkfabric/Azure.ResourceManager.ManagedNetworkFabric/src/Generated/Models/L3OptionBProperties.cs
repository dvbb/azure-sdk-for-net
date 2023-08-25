// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Option B configuration. </summary>
    public partial class L3OptionBProperties
    {
        /// <summary> Initializes a new instance of L3OptionBProperties. </summary>
        public L3OptionBProperties()
        {
            ImportRouteTargets = new ChangeTrackingList<string>();
            ExportRouteTargets = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of L3OptionBProperties. </summary>
        /// <param name="importRouteTargets"> RouteTargets to be applied. This is used for the backward compatibility. </param>
        /// <param name="exportRouteTargets"> RouteTargets to be applied. This is used for the backward compatibility. </param>
        /// <param name="routeTargets"> RouteTargets to be applied. </param>
        internal L3OptionBProperties(IList<string> importRouteTargets, IList<string> exportRouteTargets, RouteTargetInformation routeTargets)
        {
            ImportRouteTargets = importRouteTargets;
            ExportRouteTargets = exportRouteTargets;
            RouteTargets = routeTargets;
        }

        /// <summary> RouteTargets to be applied. This is used for the backward compatibility. </summary>
        public IList<string> ImportRouteTargets { get; }
        /// <summary> RouteTargets to be applied. This is used for the backward compatibility. </summary>
        public IList<string> ExportRouteTargets { get; }
        /// <summary> RouteTargets to be applied. </summary>
        public RouteTargetInformation RouteTargets { get; set; }
    }
}
