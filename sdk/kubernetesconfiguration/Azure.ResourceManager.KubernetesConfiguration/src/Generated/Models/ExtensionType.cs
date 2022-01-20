// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Represents an Extension Type. </summary>
    public partial class ExtensionType
    {
        /// <summary> Initializes a new instance of ExtensionType. </summary>
        internal ExtensionType()
        {
            ReleaseTrains = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ExtensionType. </summary>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="releaseTrains"> Extension release train: preview or stable. </param>
        /// <param name="clusterTypes"> Cluster types. </param>
        /// <param name="supportedScopes"> Extension scopes. </param>
        internal ExtensionType(SystemData systemData, IReadOnlyList<string> releaseTrains, ClusterTypes? clusterTypes, SupportedScopes supportedScopes)
        {
            SystemData = systemData;
            ReleaseTrains = releaseTrains;
            ClusterTypes = clusterTypes;
            SupportedScopes = supportedScopes;
        }

        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> Extension release train: preview or stable. </summary>
        public IReadOnlyList<string> ReleaseTrains { get; }
        /// <summary> Cluster types. </summary>
        public ClusterTypes? ClusterTypes { get; }
        /// <summary> Extension scopes. </summary>
        public SupportedScopes SupportedScopes { get; }
    }
}
