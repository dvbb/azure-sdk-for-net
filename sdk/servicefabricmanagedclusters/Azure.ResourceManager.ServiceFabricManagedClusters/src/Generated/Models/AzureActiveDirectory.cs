// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The settings to enable AAD authentication on the cluster. </summary>
    public partial class AzureActiveDirectory
    {
        /// <summary> Initializes a new instance of AzureActiveDirectory. </summary>
        public AzureActiveDirectory()
        {
        }

        /// <summary> Initializes a new instance of AzureActiveDirectory. </summary>
        /// <param name="tenantId"> Azure active directory tenant id. </param>
        /// <param name="clusterApplication"> Azure active directory cluster application id. </param>
        /// <param name="clientApplication"> Azure active directory client application id. </param>
        internal AzureActiveDirectory(string tenantId, string clusterApplication, string clientApplication)
        {
            TenantId = tenantId;
            ClusterApplication = clusterApplication;
            ClientApplication = clientApplication;
        }

        /// <summary> Azure active directory tenant id. </summary>
        public string TenantId { get; set; }
        /// <summary> Azure active directory cluster application id. </summary>
        public string ClusterApplication { get; set; }
        /// <summary> Azure active directory client application id. </summary>
        public string ClientApplication { get; set; }
    }
}
