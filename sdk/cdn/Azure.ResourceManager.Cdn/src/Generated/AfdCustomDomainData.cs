// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the AfdCustomDomain data model. </summary>
    public partial class AfdCustomDomainData : ProxyResource
    {
        /// <summary> Initializes a new instance of AfdCustomDomainData. </summary>
        public AfdCustomDomainData()
        {
        }

        /// <summary> Initializes a new instance of AfdCustomDomainData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Read only system data. </param>
        /// <param name="tlsSettings"> The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user&apos;s own certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default. </param>
        /// <param name="azureDnsZone"> Resource reference to the Azure DNS zone. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        /// <param name="domainValidationState"> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation. </param>
        /// <param name="hostName"> The host name of the domain. Must be a domain name. </param>
        /// <param name="validationProperties"> Values the customer needs to validate domain ownership. </param>
        internal AfdCustomDomainData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, AfdCustomDomainHttpsParameters tlsSettings, WritableSubResource azureDnsZone, AfdProvisioningState? provisioningState, DeploymentStatus? deploymentStatus, DomainValidationState? domainValidationState, string hostName, DomainValidationProperties validationProperties) : base(id, name, type, systemData)
        {
            TlsSettings = tlsSettings;
            AzureDnsZone = azureDnsZone;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            DomainValidationState = domainValidationState;
            HostName = hostName;
            ValidationProperties = validationProperties;
        }

        /// <summary> The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user&apos;s own certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default. </summary>
        public AfdCustomDomainHttpsParameters TlsSettings { get; set; }
        /// <summary> Resource reference to the Azure DNS zone. </summary>
        public WritableSubResource AzureDnsZone { get; set; }
        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public DeploymentStatus? DeploymentStatus { get; }
        /// <summary> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation. </summary>
        public DomainValidationState? DomainValidationState { get; }
        /// <summary> The host name of the domain. Must be a domain name. </summary>
        public string HostName { get; set; }
        /// <summary> Values the customer needs to validate domain ownership. </summary>
        public DomainValidationProperties ValidationProperties { get; }
    }
}
