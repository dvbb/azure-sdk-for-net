// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmWorkloadsModelFactory
    {
        /// <summary> Initializes a new instance of SapSupportedResourceSkusResult. </summary>
        /// <param name="supportedSkus"> Gets the list of SAP supported SKUs. </param>
        /// <returns> A new <see cref="Models.SapSupportedResourceSkusResult"/> instance for mocking. </returns>
        public static SapSupportedResourceSkusResult SapSupportedResourceSkusResult(IEnumerable<SapSupportedSku> supportedSkus = null)
        {
            supportedSkus ??= new List<SapSupportedSku>();

            return new SapSupportedResourceSkusResult(supportedSkus?.ToList());
        }

        /// <summary> Initializes a new instance of SapSupportedSku. </summary>
        /// <param name="vmSku"> The VM Sku. </param>
        /// <param name="isAppServerCertified"> True if the Sku is certified for App server in the SAP system. </param>
        /// <param name="isDatabaseCertified"> True if the Sku is certified for Database server in the SAP system. </param>
        /// <returns> A new <see cref="Models.SapSupportedSku"/> instance for mocking. </returns>
        public static SapSupportedSku SapSupportedSku(string vmSku = null, bool? isAppServerCertified = null, bool? isDatabaseCertified = null)
        {
            return new SapSupportedSku(vmSku, isAppServerCertified, isDatabaseCertified);
        }

        /// <summary> Initializes a new instance of SapDiskConfigurationsResult. </summary>
        /// <param name="volumeConfigurations"> The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os'], Optional volume : ['backup']. </param>
        /// <returns> A new <see cref="Models.SapDiskConfigurationsResult"/> instance for mocking. </returns>
        public static SapDiskConfigurationsResult SapDiskConfigurationsResult(IReadOnlyDictionary<string, SapDiskConfiguration> volumeConfigurations = null)
        {
            volumeConfigurations ??= new Dictionary<string, SapDiskConfiguration>();

            return new SapDiskConfigurationsResult(volumeConfigurations);
        }

        /// <summary> Initializes a new instance of SapDiskConfiguration. </summary>
        /// <param name="recommendedConfiguration"> The recommended disk details for a given VM Sku. </param>
        /// <param name="supportedConfigurations"> The list of supported disks for a given VM Sku. </param>
        /// <returns> A new <see cref="Models.SapDiskConfiguration"/> instance for mocking. </returns>
        public static SapDiskConfiguration SapDiskConfiguration(DiskVolumeConfiguration recommendedConfiguration = null, IEnumerable<SupportedConfigurationsDiskDetails> supportedConfigurations = null)
        {
            supportedConfigurations ??= new List<SupportedConfigurationsDiskDetails>();

            return new SapDiskConfiguration(recommendedConfiguration, supportedConfigurations?.ToList());
        }

        /// <summary> Initializes a new instance of SupportedConfigurationsDiskDetails. </summary>
        /// <param name="skuName"> The type of disk sku. For example, Standard_LRS, Standard_ZRS, Premium_LRS, Premium_ZRS. </param>
        /// <param name="sizeInGB"> The disk size in GB. </param>
        /// <param name="minimumSupportedDiskCount"> The minimum supported disk count. </param>
        /// <param name="maximumSupportedDiskCount"> The maximum supported disk count. </param>
        /// <param name="iopsReadWrite"> The disk Iops. </param>
        /// <param name="mbpsReadWrite"> The disk provisioned throughput in MBps. </param>
        /// <param name="diskTier"> The disk tier, e.g. P10, E10. </param>
        /// <returns> A new <see cref="Models.SupportedConfigurationsDiskDetails"/> instance for mocking. </returns>
        public static SupportedConfigurationsDiskDetails SupportedConfigurationsDiskDetails(DiskDetailsDiskSkuName? skuName = null, long? sizeInGB = null, long? minimumSupportedDiskCount = null, long? maximumSupportedDiskCount = null, long? iopsReadWrite = null, long? mbpsReadWrite = null, string diskTier = null)
        {
            return new SupportedConfigurationsDiskDetails(skuName != null ? new SapDiskSku(skuName) : null, sizeInGB, minimumSupportedDiskCount, maximumSupportedDiskCount, iopsReadWrite, mbpsReadWrite, diskTier);
        }

        /// <summary> Initializes a new instance of SapAvailabilityZoneDetailsResult. </summary>
        /// <param name="availabilityZonePairs"> Gets the list of availability zone pairs. </param>
        /// <returns> A new <see cref="Models.SapAvailabilityZoneDetailsResult"/> instance for mocking. </returns>
        public static SapAvailabilityZoneDetailsResult SapAvailabilityZoneDetailsResult(IEnumerable<SapAvailabilityZonePair> availabilityZonePairs = null)
        {
            availabilityZonePairs ??= new List<SapAvailabilityZonePair>();

            return new SapAvailabilityZoneDetailsResult(availabilityZonePairs?.ToList());
        }

        /// <summary> Initializes a new instance of SapAvailabilityZonePair. </summary>
        /// <param name="zoneA"> The zone A. </param>
        /// <param name="zoneB"> The zone B. </param>
        /// <returns> A new <see cref="Models.SapAvailabilityZonePair"/> instance for mocking. </returns>
        public static SapAvailabilityZonePair SapAvailabilityZonePair(long? zoneA = null, long? zoneB = null)
        {
            return new SapAvailabilityZonePair(zoneA, zoneB);
        }

        /// <summary> Initializes a new instance of SapVirtualInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> A pre-created user assigned identity with appropriate roles assigned. To learn more on identity and roles required, visit the ACSS how-to-guide. </param>
        /// <param name="environment"> Defines the environment type - Production/Non Production. </param>
        /// <param name="sapProduct"> Defines the SAP Product type. </param>
        /// <param name="configuration">
        /// Defines if the SAP system is being created using Azure Center for SAP solutions (ACSS) or if an existing SAP system is being registered with ACSS
        /// Please note <see cref="SapConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeploymentConfiguration"/>, <see cref="DeploymentWithOSConfiguration"/> and <see cref="Models.DiscoveryConfiguration"/>.
        /// </param>
        /// <param name="managedResourceGroupName"> Managed resource group configuration. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <param name="state"> Defines the Virtual Instance for SAP state. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errorsProperties"> Indicates any errors on the Virtual Instance for SAP solutions resource. </param>
        /// <returns> A new <see cref="Workloads.SapVirtualInstanceData"/> instance for mocking. </returns>
        public static SapVirtualInstanceData SapVirtualInstanceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, UserAssignedServiceIdentity identity = null, SapEnvironmentType environment = default, SapProductType sapProduct = default, SapConfiguration configuration = null, string managedResourceGroupName = null, SapVirtualInstanceStatus? status = null, SapHealthState? health = null, SapVirtualInstanceState? state = null, SapVirtualInstanceProvisioningState? provisioningState = null, SapVirtualInstanceErrorDetail errorsProperties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new SapVirtualInstanceData(id, name, resourceType, systemData, tags, location, identity, environment, sapProduct, configuration, managedResourceGroupName != null ? new ManagedRGConfiguration(managedResourceGroupName) : null, status, health, state, provisioningState, errorsProperties != null ? new SapVirtualInstanceError(errorsProperties) : null);
        }

        /// <summary> Initializes a new instance of SapVirtualInstanceErrorDetail. </summary>
        /// <param name="code"> Service specific error code which serves as the substatus for the HTTP error code. </param>
        /// <param name="message"> Description of the error. </param>
        /// <param name="details"> Internal error details. </param>
        /// <returns> A new <see cref="Models.SapVirtualInstanceErrorDetail"/> instance for mocking. </returns>
        public static SapVirtualInstanceErrorDetail SapVirtualInstanceErrorDetail(string code = null, string message = null, IEnumerable<SapVirtualInstanceErrorDetail> details = null)
        {
            details ??= new List<SapVirtualInstanceErrorDetail>();

            return new SapVirtualInstanceErrorDetail(code, message, details?.ToList());
        }

        /// <summary> Initializes a new instance of SapCentralServerInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="instanceNo"> The central services instance number. </param>
        /// <param name="subnetId"> The central services instance subnet. </param>
        /// <param name="messageServerProperties"> Defines the SAP Message Server properties. </param>
        /// <param name="enqueueServerProperties"> Defines the SAP Enqueue Server properties. </param>
        /// <param name="gatewayServerProperties"> Defines the SAP Gateway Server properties. </param>
        /// <param name="enqueueReplicationServerProperties"> Defines the SAP Enqueue Replication Server (ERS) properties. </param>
        /// <param name="kernelVersion"> The central services instance Kernel Version. </param>
        /// <param name="kernelPatch"> The central services instance Kernel Patch level. </param>
        /// <param name="loadBalancerDetailsId"> The Load Balancer details such as LoadBalancer ID attached to ASCS Virtual Machines. </param>
        /// <param name="vmDetails"> The list of virtual machines corresponding to the Central Services instance. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errorsProperties"> Defines the errors related to SAP Central Services Instance resource. </param>
        /// <returns> A new <see cref="Workloads.SapCentralServerInstanceData"/> instance for mocking. </returns>
        public static SapCentralServerInstanceData SapCentralServerInstanceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string instanceNo = null, ResourceIdentifier subnetId = null, MessageServerProperties messageServerProperties = null, EnqueueServerProperties enqueueServerProperties = null, GatewayServerProperties gatewayServerProperties = null, EnqueueReplicationServerProperties enqueueReplicationServerProperties = null, string kernelVersion = null, string kernelPatch = null, ResourceIdentifier loadBalancerDetailsId = null, IEnumerable<CentralServerVmDetails> vmDetails = null, SapVirtualInstanceStatus? status = null, SapHealthState? health = null, SapVirtualInstanceProvisioningState? provisioningState = null, SapVirtualInstanceErrorDetail errorsProperties = null)
        {
            tags ??= new Dictionary<string, string>();
            vmDetails ??= new List<CentralServerVmDetails>();

            return new SapCentralServerInstanceData(id, name, resourceType, systemData, tags, location, instanceNo, subnetId, messageServerProperties, enqueueServerProperties, gatewayServerProperties, enqueueReplicationServerProperties, kernelVersion, kernelPatch, loadBalancerDetailsId != null ? ResourceManagerModelFactory.SubResource(loadBalancerDetailsId) : null, vmDetails?.ToList(), status, health, provisioningState, errorsProperties != null ? new SapVirtualInstanceError(errorsProperties) : null);
        }

        /// <summary> Initializes a new instance of MessageServerProperties. </summary>
        /// <param name="msPort"> Message Server port. </param>
        /// <param name="internalMsPort"> Message Server internal MS port. </param>
        /// <param name="httpPort"> Message Server HTTP Port. </param>
        /// <param name="httpsPort"> Message Server HTTPS Port. </param>
        /// <param name="hostname"> Message Server SAP Hostname. </param>
        /// <param name="ipAddress"> Message server IP Address. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <returns> A new <see cref="Models.MessageServerProperties"/> instance for mocking. </returns>
        public static MessageServerProperties MessageServerProperties(long? msPort = null, long? internalMsPort = null, long? httpPort = null, long? httpsPort = null, string hostname = null, string ipAddress = null, SapHealthState? health = null)
        {
            return new MessageServerProperties(msPort, internalMsPort, httpPort, httpsPort, hostname, ipAddress, health);
        }

        /// <summary> Initializes a new instance of EnqueueServerProperties. </summary>
        /// <param name="hostname"> Enqueue Server SAP Hostname. </param>
        /// <param name="ipAddress"> Enqueue Server SAP IP Address. </param>
        /// <param name="port"> Enqueue Server Port. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <returns> A new <see cref="Models.EnqueueServerProperties"/> instance for mocking. </returns>
        public static EnqueueServerProperties EnqueueServerProperties(string hostname = null, string ipAddress = null, long? port = null, SapHealthState? health = null)
        {
            return new EnqueueServerProperties(hostname, ipAddress, port, health);
        }

        /// <summary> Initializes a new instance of GatewayServerProperties. </summary>
        /// <param name="port"> Gateway Port. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <returns> A new <see cref="Models.GatewayServerProperties"/> instance for mocking. </returns>
        public static GatewayServerProperties GatewayServerProperties(long? port = null, SapHealthState? health = null)
        {
            return new GatewayServerProperties(port, health);
        }

        /// <summary> Initializes a new instance of EnqueueReplicationServerProperties. </summary>
        /// <param name="ersVersion"> Defines the type of Enqueue Replication Server. </param>
        /// <param name="instanceNo"> ERS Instance Number. </param>
        /// <param name="hostname"> ERS SAP Hostname. </param>
        /// <param name="kernelVersion"> ERS SAP Kernel Version. </param>
        /// <param name="kernelPatch"> ERS SAP Kernel Patch level. </param>
        /// <param name="ipAddress"> ERS SAP IP Address. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <returns> A new <see cref="Models.EnqueueReplicationServerProperties"/> instance for mocking. </returns>
        public static EnqueueReplicationServerProperties EnqueueReplicationServerProperties(EnqueueReplicationServerType? ersVersion = null, string instanceNo = null, string hostname = null, string kernelVersion = null, string kernelPatch = null, string ipAddress = null, SapHealthState? health = null)
        {
            return new EnqueueReplicationServerProperties(ersVersion, instanceNo, hostname, kernelVersion, kernelPatch, ipAddress, health);
        }

        /// <summary> Initializes a new instance of CentralServerVmDetails. </summary>
        /// <param name="virtualMachineType"> Defines the type of central server VM. </param>
        /// <param name="virtualMachineId"></param>
        /// <param name="storageDetails"> Storage details of all the Storage Accounts attached to the ASCS Virtual Machine. For e.g. NFS on AFS Shared Storage. </param>
        /// <returns> A new <see cref="Models.CentralServerVmDetails"/> instance for mocking. </returns>
        public static CentralServerVmDetails CentralServerVmDetails(CentralServerVirtualMachineType? virtualMachineType = null, ResourceIdentifier virtualMachineId = null, IEnumerable<SubResource> storageDetails = null)
        {
            storageDetails ??= new List<SubResource>();

            return new CentralServerVmDetails(virtualMachineType, virtualMachineId, storageDetails?.ToList());
        }

        /// <summary> Initializes a new instance of SapDatabaseInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="subnetId"> Database subnet. </param>
        /// <param name="databaseSid"> Database SID name. </param>
        /// <param name="databaseType"> Database type, that is if the DB is HANA, DB2, Oracle, SAP ASE, Max DB or MS SQL Server. </param>
        /// <param name="ipAddress"> Database IP Address. </param>
        /// <param name="loadBalancerDetailsId"> The Load Balancer details such as LoadBalancer ID attached to Database Virtual Machines. </param>
        /// <param name="vmDetails"> The list of virtual machines corresponding to the Database resource. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errorsProperties"> Defines the errors related to Database resource. </param>
        /// <returns> A new <see cref="Workloads.SapDatabaseInstanceData"/> instance for mocking. </returns>
        public static SapDatabaseInstanceData SapDatabaseInstanceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ResourceIdentifier subnetId = null, string databaseSid = null, string databaseType = null, string ipAddress = null, ResourceIdentifier loadBalancerDetailsId = null, IEnumerable<DatabaseVmDetails> vmDetails = null, SapVirtualInstanceStatus? status = null, SapVirtualInstanceProvisioningState? provisioningState = null, SapVirtualInstanceErrorDetail errorsProperties = null)
        {
            tags ??= new Dictionary<string, string>();
            vmDetails ??= new List<DatabaseVmDetails>();

            return new SapDatabaseInstanceData(id, name, resourceType, systemData, tags, location, subnetId, databaseSid, databaseType, ipAddress, loadBalancerDetailsId != null ? ResourceManagerModelFactory.SubResource(loadBalancerDetailsId) : null, vmDetails?.ToList(), status, provisioningState, errorsProperties != null ? new SapVirtualInstanceError(errorsProperties) : null);
        }

        /// <summary> Initializes a new instance of DatabaseVmDetails. </summary>
        /// <param name="virtualMachineId"></param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="storageDetails"> Storage details of all the Storage Accounts attached to the Database Virtual Machine. For e.g. NFS on AFS Shared Storage. </param>
        /// <returns> A new <see cref="Models.DatabaseVmDetails"/> instance for mocking. </returns>
        public static DatabaseVmDetails DatabaseVmDetails(ResourceIdentifier virtualMachineId = null, SapVirtualInstanceStatus? status = null, IEnumerable<SubResource> storageDetails = null)
        {
            storageDetails ??= new List<SubResource>();

            return new DatabaseVmDetails(virtualMachineId, status, storageDetails?.ToList());
        }

        /// <summary> Initializes a new instance of SapApplicationServerInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="instanceNo"> Application server Instance Number. </param>
        /// <param name="subnetId"> Application server Subnet. </param>
        /// <param name="hostname"> Application server instance SAP hostname. </param>
        /// <param name="kernelVersion"> Application server instance SAP Kernel Version. </param>
        /// <param name="kernelPatch"> Application server instance SAP Kernel Patch level. </param>
        /// <param name="ipAddress"> Application server instance SAP IP Address. </param>
        /// <param name="gatewayPort"> Application server instance gateway Port. </param>
        /// <param name="icmHttpPort"> Application server instance ICM HTTP Port. </param>
        /// <param name="icmHttpsPort"> Application server instance ICM HTTPS Port. </param>
        /// <param name="loadBalancerDetailsId"> The Load Balancer details such as LoadBalancer ID attached to Application Server Virtual Machines. </param>
        /// <param name="vmDetails"> The list of virtual machines. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errorsProperties"> Defines the Application Instance errors. </param>
        /// <returns> A new <see cref="Workloads.SapApplicationServerInstanceData"/> instance for mocking. </returns>
        public static SapApplicationServerInstanceData SapApplicationServerInstanceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string instanceNo = null, ResourceIdentifier subnetId = null, string hostname = null, string kernelVersion = null, string kernelPatch = null, string ipAddress = null, long? gatewayPort = null, long? icmHttpPort = null, long? icmHttpsPort = null, ResourceIdentifier loadBalancerDetailsId = null, IEnumerable<ApplicationServerVmDetails> vmDetails = null, SapVirtualInstanceStatus? status = null, SapHealthState? health = null, SapVirtualInstanceProvisioningState? provisioningState = null, SapVirtualInstanceErrorDetail errorsProperties = null)
        {
            tags ??= new Dictionary<string, string>();
            vmDetails ??= new List<ApplicationServerVmDetails>();

            return new SapApplicationServerInstanceData(id, name, resourceType, systemData, tags, location, instanceNo, subnetId, hostname, kernelVersion, kernelPatch, ipAddress, gatewayPort, icmHttpPort, icmHttpsPort, loadBalancerDetailsId != null ? ResourceManagerModelFactory.SubResource(loadBalancerDetailsId) : null, vmDetails?.ToList(), status, health, provisioningState, errorsProperties != null ? new SapVirtualInstanceError(errorsProperties) : null);
        }

        /// <summary> Initializes a new instance of ApplicationServerVmDetails. </summary>
        /// <param name="virtualMachineType"> Defines the type of application server VM. </param>
        /// <param name="virtualMachineId"></param>
        /// <param name="storageDetails"> Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage. </param>
        /// <returns> A new <see cref="Models.ApplicationServerVmDetails"/> instance for mocking. </returns>
        public static ApplicationServerVmDetails ApplicationServerVmDetails(ApplicationServerVirtualMachineType? virtualMachineType = null, ResourceIdentifier virtualMachineId = null, IEnumerable<SubResource> storageDetails = null)
        {
            storageDetails ??= new List<SubResource>();

            return new ApplicationServerVmDetails(virtualMachineType, virtualMachineId, storageDetails?.ToList());
        }

        /// <summary> Initializes a new instance of SapMonitorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> [currently not in use] Managed service identity(user assigned identities). </param>
        /// <param name="provisioningState"> State of provisioning of the SAP monitor. </param>
        /// <param name="errors"> Defines the SAP monitor errors. </param>
        /// <param name="appLocation"> The SAP monitor resources will be deployed in the SAP monitoring region. The subnet region should be same as the SAP monitoring region. </param>
        /// <param name="routingPreference"> Sets the routing preference of the SAP monitor. By default only RFC1918 traffic is routed to the customer VNET. </param>
        /// <param name="zoneRedundancyPreference"> Sets the preference for zone redundancy on resources created for the SAP monitor. By default resources will be created which do not support zone redundancy. </param>
        /// <param name="managedResourceGroupName"> Managed resource group configuration. </param>
        /// <param name="logAnalyticsWorkspaceArmId"> The ARM ID of the Log Analytics Workspace that is used for SAP monitoring. </param>
        /// <param name="monitorSubnetId"> The subnet which the SAP monitor will be deployed in. </param>
        /// <param name="msiArmId"> The ARM ID of the MSI used for SAP monitoring. </param>
        /// <param name="storageAccountArmId"> The ARM ID of the Storage account used for SAP monitoring. </param>
        /// <returns> A new <see cref="Workloads.SapMonitorData"/> instance for mocking. </returns>
        public static SapMonitorData SapMonitorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, UserAssignedServiceIdentity identity = null, WorkloadMonitorProvisioningState? provisioningState = null, ResponseError errors = null, AzureLocation? appLocation = null, SapRoutingPreference? routingPreference = null, string zoneRedundancyPreference = null, string managedResourceGroupName = null, ResourceIdentifier logAnalyticsWorkspaceArmId = null, ResourceIdentifier monitorSubnetId = null, ResourceIdentifier msiArmId = null, ResourceIdentifier storageAccountArmId = null)
        {
            tags ??= new Dictionary<string, string>();

            return new SapMonitorData(id, name, resourceType, systemData, tags, location, identity, provisioningState, errors, appLocation, routingPreference, zoneRedundancyPreference, managedResourceGroupName != null ? new ManagedRGConfiguration(managedResourceGroupName) : null, logAnalyticsWorkspaceArmId, monitorSubnetId, msiArmId, storageAccountArmId);
        }

        /// <summary> Initializes a new instance of SapProviderInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> [currently not in use] Managed service identity(user assigned identities). </param>
        /// <param name="provisioningState"> State of provisioning of the provider instance. </param>
        /// <param name="errors"> Defines the provider instance errors. </param>
        /// <param name="providerSettings">
        /// Defines the provider specific properties.
        /// Please note <see cref="ProviderSpecificProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DB2ProviderInstanceProperties"/>, <see cref="MsSqlServerProviderInstanceProperties"/>, <see cref="PrometheusHAClusterProviderInstanceProperties"/>, <see cref="PrometheusOSProviderInstanceProperties"/>, <see cref="HanaDBProviderInstanceProperties"/> and <see cref="SapNetWeaverProviderInstanceProperties"/>.
        /// </param>
        /// <returns> A new <see cref="Workloads.SapProviderInstanceData"/> instance for mocking. </returns>
        public static SapProviderInstanceData SapProviderInstanceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, UserAssignedServiceIdentity identity = null, WorkloadMonitorProvisioningState? provisioningState = null, ResponseError errors = null, ProviderSpecificProperties providerSettings = null)
        {
            return new SapProviderInstanceData(id, name, resourceType, systemData, identity, provisioningState, errors, providerSettings);
        }

        /// <summary> Initializes a new instance of SapLandscapeMonitorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> State of provisioning of the SAP monitor. </param>
        /// <param name="grouping"> Gets or sets the SID groupings by landscape and Environment. </param>
        /// <param name="topMetricsThresholds"> Gets or sets the list Top Metric Thresholds for SAP Landscape Monitor Dashboard. </param>
        /// <returns> A new <see cref="Workloads.SapLandscapeMonitorData"/> instance for mocking. </returns>
        public static SapLandscapeMonitorData SapLandscapeMonitorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SapLandscapeMonitorProvisioningState? provisioningState = null, SapLandscapeMonitorPropertiesGrouping grouping = null, IEnumerable<SapLandscapeMonitorMetricThresholds> topMetricsThresholds = null)
        {
            topMetricsThresholds ??= new List<SapLandscapeMonitorMetricThresholds>();

            return new SapLandscapeMonitorData(id, name, resourceType, systemData, provisioningState, grouping, topMetricsThresholds?.ToList());
        }

        /// <summary> Initializes a new instance of SingleServerRecommendationResult. </summary>
        /// <param name="vmSku"> The recommended VM SKU for single server. </param>
        /// <returns> A new <see cref="Models.SingleServerRecommendationResult"/> instance for mocking. </returns>
        public static SingleServerRecommendationResult SingleServerRecommendationResult(string vmSku = null)
        {
            return new SingleServerRecommendationResult(SapDeploymentType.SingleServer, vmSku);
        }

        /// <summary> Initializes a new instance of ThreeTierRecommendationResult. </summary>
        /// <param name="dbVmSku"> The database VM SKU. </param>
        /// <param name="databaseInstanceCount"> The database server instance count. </param>
        /// <param name="centralServerVmSku"> The central server VM SKU. </param>
        /// <param name="centralServerInstanceCount"> The central server instance count. </param>
        /// <param name="applicationServerVmSku"> The application server VM SKU. </param>
        /// <param name="applicationServerInstanceCount"> The application server instance count. </param>
        /// <returns> A new <see cref="Models.ThreeTierRecommendationResult"/> instance for mocking. </returns>
        public static ThreeTierRecommendationResult ThreeTierRecommendationResult(string dbVmSku = null, long? databaseInstanceCount = null, string centralServerVmSku = null, long? centralServerInstanceCount = null, string applicationServerVmSku = null, long? applicationServerInstanceCount = null)
        {
            return new ThreeTierRecommendationResult(SapDeploymentType.ThreeTier, dbVmSku, databaseInstanceCount, centralServerVmSku, centralServerInstanceCount, applicationServerVmSku, applicationServerInstanceCount);
        }

        /// <summary> Initializes a new instance of DiscoveryConfiguration. </summary>
        /// <param name="centralServerVmId"> The virtual machine ID of the Central Server. </param>
        /// <param name="managedRgStorageAccountName"> The custom storage account name for the storage account created by the service in the managed resource group created as part of VIS deployment.&lt;br&gt;&lt;br&gt;Refer to the storage account naming rules [here](https://learn.microsoft.com/azure/azure-resource-manager/management/resource-name-rules#microsoftstorage).&lt;br&gt;&lt;br&gt;If not provided, the service will create the storage account with a random name. </param>
        /// <param name="appLocation"> The geo-location where the SAP system exists. </param>
        /// <returns> A new <see cref="Models.DiscoveryConfiguration"/> instance for mocking. </returns>
        public static DiscoveryConfiguration DiscoveryConfiguration(ResourceIdentifier centralServerVmId = null, string managedRgStorageAccountName = null, AzureLocation? appLocation = null)
        {
            return new DiscoveryConfiguration(SapConfigurationType.Discovery, centralServerVmId, managedRgStorageAccountName, appLocation);
        }
    }
}
