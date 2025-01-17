// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Access profile for managed cluster API server. </summary>
    public partial class ManagedClusterApiServerAccessProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterApiServerAccessProfile"/>. </summary>
        public ManagedClusterApiServerAccessProfile()
        {
            AuthorizedIPRanges = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterApiServerAccessProfile"/>. </summary>
        /// <param name="authorizedIPRanges"> IP ranges are specified in CIDR format, e.g. 137.117.106.88/29. This feature is not compatible with clusters that use Public IP Per Node, or clusters that are using a Basic Load Balancer. For more information see [API server authorized IP ranges](https://docs.microsoft.com/azure/aks/api-server-authorized-ip-ranges). </param>
        /// <param name="enablePrivateCluster"> For more details, see [Creating a private AKS cluster](https://docs.microsoft.com/azure/aks/private-clusters). </param>
        /// <param name="privateDnsZone"> The default is System. For more details see [configure private DNS zone](https://docs.microsoft.com/azure/aks/private-clusters#configure-private-dns-zone). Allowed values are 'system' and 'none'. </param>
        /// <param name="enablePrivateClusterPublicFqdn"> Whether to create additional public FQDN for private cluster or not. </param>
        /// <param name="disableRunCommand"> Whether to disable run command for the cluster or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterApiServerAccessProfile(IList<string> authorizedIPRanges, bool? enablePrivateCluster, string privateDnsZone, bool? enablePrivateClusterPublicFqdn, bool? disableRunCommand, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AuthorizedIPRanges = authorizedIPRanges;
            EnablePrivateCluster = enablePrivateCluster;
            PrivateDnsZone = privateDnsZone;
            EnablePrivateClusterPublicFqdn = enablePrivateClusterPublicFqdn;
            DisableRunCommand = disableRunCommand;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> IP ranges are specified in CIDR format, e.g. 137.117.106.88/29. This feature is not compatible with clusters that use Public IP Per Node, or clusters that are using a Basic Load Balancer. For more information see [API server authorized IP ranges](https://docs.microsoft.com/azure/aks/api-server-authorized-ip-ranges). </summary>
        public IList<string> AuthorizedIPRanges { get; }
        /// <summary> For more details, see [Creating a private AKS cluster](https://docs.microsoft.com/azure/aks/private-clusters). </summary>
        public bool? EnablePrivateCluster { get; set; }
        /// <summary> The default is System. For more details see [configure private DNS zone](https://docs.microsoft.com/azure/aks/private-clusters#configure-private-dns-zone). Allowed values are 'system' and 'none'. </summary>
        public string PrivateDnsZone { get; set; }
        /// <summary> Whether to create additional public FQDN for private cluster or not. </summary>
        public bool? EnablePrivateClusterPublicFqdn { get; set; }
        /// <summary> Whether to disable run command for the cluster or not. </summary>
        public bool? DisableRunCommand { get; set; }
    }
}
