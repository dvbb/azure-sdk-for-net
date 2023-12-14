// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    /// <summary>
    /// A class representing the ServiceFabricManagedCluster data model.
    /// The managed cluster resource
    ///
    /// </summary>
    public partial class ServiceFabricManagedClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedClusterData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The sku of the managed cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public ServiceFabricManagedClusterData(AzureLocation location, ServiceFabricManagedClustersSku sku) : base(location)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Sku = sku;
            ClusterCertificateThumbprints = new ChangeTrackingList<BinaryData>();
            LoadBalancingRules = new ChangeTrackingList<ManagedClusterLoadBalancingRule>();
            NetworkSecurityRules = new ChangeTrackingList<ServiceFabricManagedNetworkSecurityRule>();
            Clients = new ChangeTrackingList<ManagedClusterClientCertificate>();
            FabricSettings = new ChangeTrackingList<ClusterFabricSettingsSection>();
            AddOnFeatures = new ChangeTrackingList<ManagedClusterAddOnFeature>();
            IPTags = new ChangeTrackingList<ManagedClusterIPTag>();
            AuxiliarySubnets = new ChangeTrackingList<ManagedClusterSubnet>();
            ServiceEndpoints = new ChangeTrackingList<ManagedClusterServiceEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The sku of the managed cluster. </param>
        /// <param name="dnsName"> The cluster dns name. </param>
        /// <param name="fqdn"> The fully qualified domain name associated with the public load balancer of the cluster. </param>
        /// <param name="ipv4Address"> The IPv4 address associated with the public load balancer of the cluster. </param>
        /// <param name="clusterId"> A service generated unique identifier for the cluster resource. </param>
        /// <param name="clusterState"> The current state of the cluster. </param>
        /// <param name="clusterCertificateThumbprints"> List of thumbprints of the cluster certificates. </param>
        /// <param name="clientConnectionPort"> The port used for client connections to the cluster. </param>
        /// <param name="httpGatewayConnectionPort"> The port used for HTTP connections to the cluster. </param>
        /// <param name="adminUserName"> VM admin user name. </param>
        /// <param name="adminPassword"> VM admin user password. </param>
        /// <param name="loadBalancingRules"> Load balancing rules that are applied to the public load balancer of the cluster. </param>
        /// <param name="isRdpAccessAllowed"> Setting this to true enables RDP access to the VM. The default NSG rule opens RDP port to Internet which can be overridden with custom Network Security Rules. The default value for this setting is false. </param>
        /// <param name="networkSecurityRules"> Custom Network Security Rules that are applied to the Virtual Network of the cluster. </param>
        /// <param name="clients"> Client certificates that are allowed to manage the cluster. </param>
        /// <param name="azureActiveDirectory"> The AAD authentication settings of the cluster. </param>
        /// <param name="fabricSettings"> The list of custom fabric settings to configure the cluster. </param>
        /// <param name="provisioningState"> The provisioning state of the managed cluster resource. </param>
        /// <param name="clusterCodeVersion"> The Service Fabric runtime version of the cluster. This property is required when **clusterUpgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get the list of available version for existing clusters use **availableClusterVersions**. </param>
        /// <param name="clusterUpgradeMode">
        /// The upgrade mode of the cluster when new Service Fabric runtime version is available.
        ///
        /// </param>
        /// <param name="clusterUpgradeCadence"> Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only applies when **clusterUpgradeMode** is set to 'Automatic'. </param>
        /// <param name="addOnFeatures"> List of add-on features to enable on the cluster. </param>
        /// <param name="isAutoOSUpgradeEnabled"> Setting this to true enables automatic OS upgrade for the node types that are created using any platform OS image with version 'latest'. The default value for this setting is false. </param>
        /// <param name="hasZoneResiliency"> Indicates if the cluster has zone resiliency. </param>
        /// <param name="applicationTypeVersionsCleanupPolicy"> The policy used to clean up unused versions. </param>
        /// <param name="isIPv6Enabled"> Setting this to true creates IPv6 address space for the default VNet used by the cluster. This setting cannot be changed once the cluster is created. The default value for this setting is false. </param>
        /// <param name="subnetId"> If specified, the node types for the cluster are created in this subnet instead of the default VNet. The **networkSecurityRules** specified for the cluster are also applied to this subnet. This setting cannot be changed once the cluster is created. </param>
        /// <param name="ipTags"> The list of IP tags associated with the default public IP address of the cluster. </param>
        /// <param name="ipv6Address"> IPv6 address for the cluster if IPv6 is enabled. </param>
        /// <param name="isServicePublicIPEnabled"> Setting this to true will link the IPv4 address as the ServicePublicIP of the IPv6 address. It can only be set to True if IPv6 is enabled on the cluster. </param>
        /// <param name="auxiliarySubnets"> Auxiliary subnets for the cluster. </param>
        /// <param name="serviceEndpoints"> Service endpoints for subnets in the cluster. </param>
        /// <param name="zonalUpdateMode"> Indicates the update mode for Cross Az clusters. </param>
        /// <param name="useCustomVnet"> For new clusters, this parameter indicates that it uses Bring your own VNet, but the subnet is specified at node type level; and for such clusters, the subnetId property is required for node types. </param>
        /// <param name="publicIPPrefixId"> Specify the resource id of a public IP prefix that the load balancer will allocate a public IP address from. Only supports IPv4. </param>
        /// <param name="etag"> Azure resource etag. </param>
        internal ServiceFabricManagedClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ServiceFabricManagedClustersSku sku, string dnsName, string fqdn, IPAddress ipv4Address, Guid? clusterId, ServiceFabricManagedClusterState? clusterState, IReadOnlyList<BinaryData> clusterCertificateThumbprints, int? clientConnectionPort, int? httpGatewayConnectionPort, string adminUserName, string adminPassword, IList<ManagedClusterLoadBalancingRule> loadBalancingRules, bool? isRdpAccessAllowed, IList<ServiceFabricManagedNetworkSecurityRule> networkSecurityRules, IList<ManagedClusterClientCertificate> clients, ManagedClusterAzureActiveDirectory azureActiveDirectory, IList<ClusterFabricSettingsSection> fabricSettings, ServiceFabricManagedResourceProvisioningState? provisioningState, string clusterCodeVersion, ManagedClusterUpgradeMode? clusterUpgradeMode, ManagedClusterUpgradeCadence? clusterUpgradeCadence, IList<ManagedClusterAddOnFeature> addOnFeatures, bool? isAutoOSUpgradeEnabled, bool? hasZoneResiliency, ApplicationTypeVersionsCleanupPolicy applicationTypeVersionsCleanupPolicy, bool? isIPv6Enabled, string subnetId, IList<ManagedClusterIPTag> ipTags, IPAddress ipv6Address, bool? isServicePublicIPEnabled, IList<ManagedClusterSubnet> auxiliarySubnets, IList<ManagedClusterServiceEndpoint> serviceEndpoints, ZonalUpdateMode? zonalUpdateMode, bool? useCustomVnet, ResourceIdentifier publicIPPrefixId, ETag? etag) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            DnsName = dnsName;
            Fqdn = fqdn;
            IPv4Address = ipv4Address;
            ClusterId = clusterId;
            ClusterState = clusterState;
            ClusterCertificateThumbprints = clusterCertificateThumbprints;
            ClientConnectionPort = clientConnectionPort;
            HttpGatewayConnectionPort = httpGatewayConnectionPort;
            AdminUserName = adminUserName;
            AdminPassword = adminPassword;
            LoadBalancingRules = loadBalancingRules;
            IsRdpAccessAllowed = isRdpAccessAllowed;
            NetworkSecurityRules = networkSecurityRules;
            Clients = clients;
            AzureActiveDirectory = azureActiveDirectory;
            FabricSettings = fabricSettings;
            ProvisioningState = provisioningState;
            ClusterCodeVersion = clusterCodeVersion;
            ClusterUpgradeMode = clusterUpgradeMode;
            ClusterUpgradeCadence = clusterUpgradeCadence;
            AddOnFeatures = addOnFeatures;
            IsAutoOSUpgradeEnabled = isAutoOSUpgradeEnabled;
            HasZoneResiliency = hasZoneResiliency;
            ApplicationTypeVersionsCleanupPolicy = applicationTypeVersionsCleanupPolicy;
            IsIPv6Enabled = isIPv6Enabled;
            SubnetId = subnetId;
            IPTags = ipTags;
            IPv6Address = ipv6Address;
            IsServicePublicIPEnabled = isServicePublicIPEnabled;
            AuxiliarySubnets = auxiliarySubnets;
            ServiceEndpoints = serviceEndpoints;
            ZonalUpdateMode = zonalUpdateMode;
            UseCustomVnet = useCustomVnet;
            PublicIPPrefixId = publicIPPrefixId;
            ETag = etag;
        }

        /// <summary> The sku of the managed cluster. </summary>
        internal ServiceFabricManagedClustersSku Sku { get; set; }
        /// <summary> Sku Name. </summary>
        public ServiceFabricManagedClustersSkuName? SkuName
        {
            get => Sku is null ? default(ServiceFabricManagedClustersSkuName?) : Sku.Name;
            set
            {
                Sku = value.HasValue ? new ServiceFabricManagedClustersSku(value.Value) : null;
            }
        }

        /// <summary> The cluster dns name. </summary>
        public string DnsName { get; set; }
        /// <summary> The fully qualified domain name associated with the public load balancer of the cluster. </summary>
        public string Fqdn { get; }
        /// <summary> The IPv4 address associated with the public load balancer of the cluster. </summary>
        public IPAddress IPv4Address { get; }
        /// <summary> A service generated unique identifier for the cluster resource. </summary>
        public Guid? ClusterId { get; }
        /// <summary> The current state of the cluster. </summary>
        public ServiceFabricManagedClusterState? ClusterState { get; }
        /// <summary>
        /// List of thumbprints of the cluster certificates.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IReadOnlyList<BinaryData> ClusterCertificateThumbprints { get; }
        /// <summary> The port used for client connections to the cluster. </summary>
        public int? ClientConnectionPort { get; set; }
        /// <summary> The port used for HTTP connections to the cluster. </summary>
        public int? HttpGatewayConnectionPort { get; set; }
        /// <summary> VM admin user name. </summary>
        public string AdminUserName { get; set; }
        /// <summary> VM admin user password. </summary>
        public string AdminPassword { get; set; }
        /// <summary> Load balancing rules that are applied to the public load balancer of the cluster. </summary>
        public IList<ManagedClusterLoadBalancingRule> LoadBalancingRules { get; }
        /// <summary> Setting this to true enables RDP access to the VM. The default NSG rule opens RDP port to Internet which can be overridden with custom Network Security Rules. The default value for this setting is false. </summary>
        public bool? IsRdpAccessAllowed { get; set; }
        /// <summary> Custom Network Security Rules that are applied to the Virtual Network of the cluster. </summary>
        public IList<ServiceFabricManagedNetworkSecurityRule> NetworkSecurityRules { get; }
        /// <summary> Client certificates that are allowed to manage the cluster. </summary>
        public IList<ManagedClusterClientCertificate> Clients { get; }
        /// <summary> The AAD authentication settings of the cluster. </summary>
        public ManagedClusterAzureActiveDirectory AzureActiveDirectory { get; set; }
        /// <summary> The list of custom fabric settings to configure the cluster. </summary>
        public IList<ClusterFabricSettingsSection> FabricSettings { get; }
        /// <summary> The provisioning state of the managed cluster resource. </summary>
        public ServiceFabricManagedResourceProvisioningState? ProvisioningState { get; }
        /// <summary> The Service Fabric runtime version of the cluster. This property is required when **clusterUpgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get the list of available version for existing clusters use **availableClusterVersions**. </summary>
        public string ClusterCodeVersion { get; set; }
        /// <summary>
        /// The upgrade mode of the cluster when new Service Fabric runtime version is available.
        ///
        /// </summary>
        public ManagedClusterUpgradeMode? ClusterUpgradeMode { get; set; }
        /// <summary> Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only applies when **clusterUpgradeMode** is set to 'Automatic'. </summary>
        public ManagedClusterUpgradeCadence? ClusterUpgradeCadence { get; set; }
        /// <summary> List of add-on features to enable on the cluster. </summary>
        public IList<ManagedClusterAddOnFeature> AddOnFeatures { get; }
        /// <summary> Setting this to true enables automatic OS upgrade for the node types that are created using any platform OS image with version 'latest'. The default value for this setting is false. </summary>
        public bool? IsAutoOSUpgradeEnabled { get; set; }
        /// <summary> Indicates if the cluster has zone resiliency. </summary>
        public bool? HasZoneResiliency { get; set; }
        /// <summary> The policy used to clean up unused versions. </summary>
        internal ApplicationTypeVersionsCleanupPolicy ApplicationTypeVersionsCleanupPolicy { get; set; }
        /// <summary> Number of unused versions per application type to keep. </summary>
        public int? MaxUnusedVersionsToKeep
        {
            get => ApplicationTypeVersionsCleanupPolicy is null ? default(int?) : ApplicationTypeVersionsCleanupPolicy.MaxUnusedVersionsToKeep;
            set
            {
                ApplicationTypeVersionsCleanupPolicy = value.HasValue ? new ApplicationTypeVersionsCleanupPolicy(value.Value) : null;
            }
        }

        /// <summary> Setting this to true creates IPv6 address space for the default VNet used by the cluster. This setting cannot be changed once the cluster is created. The default value for this setting is false. </summary>
        public bool? IsIPv6Enabled { get; set; }
        /// <summary> If specified, the node types for the cluster are created in this subnet instead of the default VNet. The **networkSecurityRules** specified for the cluster are also applied to this subnet. This setting cannot be changed once the cluster is created. </summary>
        public string SubnetId { get; set; }
        /// <summary> The list of IP tags associated with the default public IP address of the cluster. </summary>
        public IList<ManagedClusterIPTag> IPTags { get; }
        /// <summary> IPv6 address for the cluster if IPv6 is enabled. </summary>
        public IPAddress IPv6Address { get; }
        /// <summary> Setting this to true will link the IPv4 address as the ServicePublicIP of the IPv6 address. It can only be set to True if IPv6 is enabled on the cluster. </summary>
        public bool? IsServicePublicIPEnabled { get; set; }
        /// <summary> Auxiliary subnets for the cluster. </summary>
        public IList<ManagedClusterSubnet> AuxiliarySubnets { get; }
        /// <summary> Service endpoints for subnets in the cluster. </summary>
        public IList<ManagedClusterServiceEndpoint> ServiceEndpoints { get; }
        /// <summary> Indicates the update mode for Cross Az clusters. </summary>
        public ZonalUpdateMode? ZonalUpdateMode { get; set; }
        /// <summary> For new clusters, this parameter indicates that it uses Bring your own VNet, but the subnet is specified at node type level; and for such clusters, the subnetId property is required for node types. </summary>
        public bool? UseCustomVnet { get; set; }
        /// <summary> Specify the resource id of a public IP prefix that the load balancer will allocate a public IP address from. Only supports IPv4. </summary>
        public ResourceIdentifier PublicIPPrefixId { get; set; }
        /// <summary> Azure resource etag. </summary>
        public ETag? ETag { get; }
    }
}
