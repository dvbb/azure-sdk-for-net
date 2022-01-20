// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Workspace features. </summary>
    public partial class WorkspaceFeatures
    {
        /// <summary> Initializes a new instance of WorkspaceFeatures. </summary>
        public WorkspaceFeatures()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of WorkspaceFeatures. </summary>
        /// <param name="enableDataExport"> Flag that indicate if data should be exported. </param>
        /// <param name="immediatePurgeDataOn30Days"> Flag that describes if we want to remove the data after 30 days. </param>
        /// <param name="enableLogAccessUsingOnlyResourcePermissions"> Flag that indicate which permission to use - resource or workspace or both. </param>
        /// <param name="clusterResourceId"> Dedicated LA cluster resourceId that is linked to the workspaces. </param>
        /// <param name="disableLocalAuth"> Disable Non-AAD based Auth. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal WorkspaceFeatures(bool? enableDataExport, bool? immediatePurgeDataOn30Days, bool? enableLogAccessUsingOnlyResourcePermissions, string clusterResourceId, bool? disableLocalAuth, IDictionary<string, object> additionalProperties)
        {
            EnableDataExport = enableDataExport;
            ImmediatePurgeDataOn30Days = immediatePurgeDataOn30Days;
            EnableLogAccessUsingOnlyResourcePermissions = enableLogAccessUsingOnlyResourcePermissions;
            ClusterResourceId = clusterResourceId;
            DisableLocalAuth = disableLocalAuth;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Flag that indicate if data should be exported. </summary>
        public bool? EnableDataExport { get; set; }
        /// <summary> Flag that describes if we want to remove the data after 30 days. </summary>
        public bool? ImmediatePurgeDataOn30Days { get; set; }
        /// <summary> Flag that indicate which permission to use - resource or workspace or both. </summary>
        public bool? EnableLogAccessUsingOnlyResourcePermissions { get; set; }
        /// <summary> Dedicated LA cluster resourceId that is linked to the workspaces. </summary>
        public string ClusterResourceId { get; set; }
        /// <summary> Disable Non-AAD based Auth. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
