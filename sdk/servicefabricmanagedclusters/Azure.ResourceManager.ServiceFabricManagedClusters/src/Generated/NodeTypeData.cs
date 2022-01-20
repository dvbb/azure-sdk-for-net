// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    /// <summary> A class representing the NodeType data model. </summary>
    public partial class NodeTypeData : ManagedProxyResource
    {
        /// <summary> Initializes a new instance of NodeTypeData. </summary>
        public NodeTypeData()
        {
            PlacementProperties = new ChangeTrackingDictionary<string, string>();
            Capacities = new ChangeTrackingDictionary<string, string>();
            VmSecrets = new ChangeTrackingList<VaultSecretGroup>();
            VmExtensions = new ChangeTrackingList<VmssExtension>();
            FrontendConfigurations = new ChangeTrackingList<FrontendConfiguration>();
            NetworkSecurityRules = new ChangeTrackingList<NetworkSecurityRule>();
            AdditionalDataDisks = new ChangeTrackingList<VmssDataDisk>();
        }

        /// <summary> Initializes a new instance of NodeTypeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> Azure resource tags. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="sku"> The node type sku. </param>
        /// <param name="isPrimary"> Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed once the node type is created. </param>
        /// <param name="vmInstanceCount"> The number of nodes in the node type. &lt;br /&gt;&lt;br /&gt;**Values:** &lt;br /&gt;-1 - Use when auto scale rules are configured or sku.capacity is defined &lt;br /&gt; 0 - Not supported &lt;br /&gt; &gt;0 - Use for manual scale. </param>
        /// <param name="dataDiskSizeGB"> Disk size for the managed disk attached to the vms on the node type in GBs. </param>
        /// <param name="dataDiskType"> Managed data disk type. Specifies the storage account type for the managed disk. </param>
        /// <param name="dataDiskLetter"> Managed data disk letter. It can not use the reserved letter C or D and it can not change after created. </param>
        /// <param name="placementProperties"> The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run. </param>
        /// <param name="capacities"> The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has. </param>
        /// <param name="applicationPorts"> The range of ports from which cluster assigned port to Service Fabric applications. </param>
        /// <param name="ephemeralPorts"> The range of ephemeral ports that nodes in this node type should be configured with. </param>
        /// <param name="vmSize"> The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3. </param>
        /// <param name="vmImagePublisher"> The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer. </param>
        /// <param name="vmImageOffer"> The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer. </param>
        /// <param name="vmImageSku"> The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter. </param>
        /// <param name="vmImageVersion"> The version of the Azure Virtual Machines Marketplace image. A value of &apos;latest&apos; can be specified to select the latest version of an image. If omitted, the default is &apos;latest&apos;. </param>
        /// <param name="vmSecrets"> The secrets to install in the virtual machines. </param>
        /// <param name="vmExtensions"> Set of extensions that should be installed onto the virtual machines. </param>
        /// <param name="vmManagedIdentity"> Identities to assign to the virtual machine scale set under the node type. </param>
        /// <param name="isStateless"> Indicates if the node type can only host Stateless workloads. </param>
        /// <param name="multiplePlacementGroups"> Indicates if scale set associated with the node type can be composed of multiple placement groups. </param>
        /// <param name="frontendConfigurations"> Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting can only be specified for non-primary node types and can not be added or removed after the node type is created. </param>
        /// <param name="networkSecurityRules"> The Network Security Rules for this node type. This setting can only be specified for node types that are configured with frontend configurations. </param>
        /// <param name="additionalDataDisks"> Additional managed data disks. </param>
        /// <param name="enableEncryptionAtHost"> Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property is set to true for the resource. </param>
        /// <param name="provisioningState"> The provisioning state of the node type resource. </param>
        /// <param name="enableAcceleratedNetworking"> Specifies whether the network interface is accelerated networking-enabled. </param>
        /// <param name="useDefaultPublicLoadBalancer"> Specifies whether the use public load balancer. If not specified and the node type doesn&apos;t have its own frontend configuration, it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity. </param>
        /// <param name="useTempDataDisk"> Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will be attached and the temporary disk will be used. It is only allowed for stateless node types. </param>
        internal NodeTypeData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, SystemData systemData, NodeTypeSku sku, bool? isPrimary, int? vmInstanceCount, int? dataDiskSizeGB, DiskType? dataDiskType, string dataDiskLetter, IDictionary<string, string> placementProperties, IDictionary<string, string> capacities, EndpointRangeDescription applicationPorts, EndpointRangeDescription ephemeralPorts, string vmSize, string vmImagePublisher, string vmImageOffer, string vmImageSku, string vmImageVersion, IList<VaultSecretGroup> vmSecrets, IList<VmssExtension> vmExtensions, VmManagedIdentity vmManagedIdentity, bool? isStateless, bool? multiplePlacementGroups, IList<FrontendConfiguration> frontendConfigurations, IList<NetworkSecurityRule> networkSecurityRules, IList<VmssDataDisk> additionalDataDisks, bool? enableEncryptionAtHost, ManagedResourceProvisioningState? provisioningState, bool? enableAcceleratedNetworking, bool? useDefaultPublicLoadBalancer, bool? useTempDataDisk) : base(id, name, type, tags, systemData)
        {
            Sku = sku;
            IsPrimary = isPrimary;
            VmInstanceCount = vmInstanceCount;
            DataDiskSizeGB = dataDiskSizeGB;
            DataDiskType = dataDiskType;
            DataDiskLetter = dataDiskLetter;
            PlacementProperties = placementProperties;
            Capacities = capacities;
            ApplicationPorts = applicationPorts;
            EphemeralPorts = ephemeralPorts;
            VmSize = vmSize;
            VmImagePublisher = vmImagePublisher;
            VmImageOffer = vmImageOffer;
            VmImageSku = vmImageSku;
            VmImageVersion = vmImageVersion;
            VmSecrets = vmSecrets;
            VmExtensions = vmExtensions;
            VmManagedIdentity = vmManagedIdentity;
            IsStateless = isStateless;
            MultiplePlacementGroups = multiplePlacementGroups;
            FrontendConfigurations = frontendConfigurations;
            NetworkSecurityRules = networkSecurityRules;
            AdditionalDataDisks = additionalDataDisks;
            EnableEncryptionAtHost = enableEncryptionAtHost;
            ProvisioningState = provisioningState;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            UseDefaultPublicLoadBalancer = useDefaultPublicLoadBalancer;
            UseTempDataDisk = useTempDataDisk;
        }

        /// <summary> The node type sku. </summary>
        public NodeTypeSku Sku { get; set; }
        /// <summary> Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed once the node type is created. </summary>
        public bool? IsPrimary { get; set; }
        /// <summary> The number of nodes in the node type. &lt;br /&gt;&lt;br /&gt;**Values:** &lt;br /&gt;-1 - Use when auto scale rules are configured or sku.capacity is defined &lt;br /&gt; 0 - Not supported &lt;br /&gt; &gt;0 - Use for manual scale. </summary>
        public int? VmInstanceCount { get; set; }
        /// <summary> Disk size for the managed disk attached to the vms on the node type in GBs. </summary>
        public int? DataDiskSizeGB { get; set; }
        /// <summary> Managed data disk type. Specifies the storage account type for the managed disk. </summary>
        public DiskType? DataDiskType { get; set; }
        /// <summary> Managed data disk letter. It can not use the reserved letter C or D and it can not change after created. </summary>
        public string DataDiskLetter { get; set; }
        /// <summary> The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run. </summary>
        public IDictionary<string, string> PlacementProperties { get; }
        /// <summary> The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has. </summary>
        public IDictionary<string, string> Capacities { get; }
        /// <summary> The range of ports from which cluster assigned port to Service Fabric applications. </summary>
        public EndpointRangeDescription ApplicationPorts { get; set; }
        /// <summary> The range of ephemeral ports that nodes in this node type should be configured with. </summary>
        public EndpointRangeDescription EphemeralPorts { get; set; }
        /// <summary> The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3. </summary>
        public string VmSize { get; set; }
        /// <summary> The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer. </summary>
        public string VmImagePublisher { get; set; }
        /// <summary> The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer. </summary>
        public string VmImageOffer { get; set; }
        /// <summary> The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter. </summary>
        public string VmImageSku { get; set; }
        /// <summary> The version of the Azure Virtual Machines Marketplace image. A value of &apos;latest&apos; can be specified to select the latest version of an image. If omitted, the default is &apos;latest&apos;. </summary>
        public string VmImageVersion { get; set; }
        /// <summary> The secrets to install in the virtual machines. </summary>
        public IList<VaultSecretGroup> VmSecrets { get; }
        /// <summary> Set of extensions that should be installed onto the virtual machines. </summary>
        public IList<VmssExtension> VmExtensions { get; }
        /// <summary> Identities to assign to the virtual machine scale set under the node type. </summary>
        public VmManagedIdentity VmManagedIdentity { get; set; }
        /// <summary> Indicates if the node type can only host Stateless workloads. </summary>
        public bool? IsStateless { get; set; }
        /// <summary> Indicates if scale set associated with the node type can be composed of multiple placement groups. </summary>
        public bool? MultiplePlacementGroups { get; set; }
        /// <summary> Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting can only be specified for non-primary node types and can not be added or removed after the node type is created. </summary>
        public IList<FrontendConfiguration> FrontendConfigurations { get; }
        /// <summary> The Network Security Rules for this node type. This setting can only be specified for node types that are configured with frontend configurations. </summary>
        public IList<NetworkSecurityRule> NetworkSecurityRules { get; }
        /// <summary> Additional managed data disks. </summary>
        public IList<VmssDataDisk> AdditionalDataDisks { get; }
        /// <summary> Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property is set to true for the resource. </summary>
        public bool? EnableEncryptionAtHost { get; set; }
        /// <summary> The provisioning state of the node type resource. </summary>
        public ManagedResourceProvisioningState? ProvisioningState { get; }
        /// <summary> Specifies whether the network interface is accelerated networking-enabled. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
        /// <summary> Specifies whether the use public load balancer. If not specified and the node type doesn&apos;t have its own frontend configuration, it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity. </summary>
        public bool? UseDefaultPublicLoadBalancer { get; set; }
        /// <summary> Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will be attached and the temporary disk will be used. It is only allowed for stateless node types. </summary>
        public bool? UseTempDataDisk { get; set; }
    }
}
