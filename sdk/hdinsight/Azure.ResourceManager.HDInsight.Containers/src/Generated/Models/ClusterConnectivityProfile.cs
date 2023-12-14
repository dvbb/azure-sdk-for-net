// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster connectivity profile. </summary>
    public partial class ClusterConnectivityProfile
    {
        /// <summary> Initializes a new instance of <see cref="ClusterConnectivityProfile"/>. </summary>
        /// <param name="web"> Web connectivity endpoint details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="web"/> is null. </exception>
        internal ClusterConnectivityProfile(WebConnectivityEndpoint web)
        {
            Argument.AssertNotNull(web, nameof(web));

            Web = web;
            Ssh = new ChangeTrackingList<SshConnectivityEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterConnectivityProfile"/>. </summary>
        /// <param name="web"> Web connectivity endpoint details. </param>
        /// <param name="ssh"> List of SSH connectivity endpoints. </param>
        internal ClusterConnectivityProfile(WebConnectivityEndpoint web, IReadOnlyList<SshConnectivityEndpoint> ssh)
        {
            Web = web;
            Ssh = ssh;
        }

        /// <summary> Web connectivity endpoint details. </summary>
        internal WebConnectivityEndpoint Web { get; }
        /// <summary> Web connectivity endpoint. </summary>
        public string WebFqdn
        {
            get => Web?.Fqdn;
        }

        /// <summary> List of SSH connectivity endpoints. </summary>
        public IReadOnlyList<SshConnectivityEndpoint> Ssh { get; }
    }
}
