// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of an IoT hub. </summary>
    public partial class IotHubProperties
    {
        /// <summary> Initializes a new instance of IotHubProperties. </summary>
        public IotHubProperties()
        {
            AuthorizationPolicies = new ChangeTrackingList<SharedAccessSignatureAuthorizationRule>();
            AllowedFqdnList = new ChangeTrackingList<string>();
            IpFilterRules = new ChangeTrackingList<IpFilterRule>();
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionData>();
            EventHubEndpoints = new ChangeTrackingDictionary<string, EventHubProperties>();
            StorageEndpoints = new ChangeTrackingDictionary<string, StorageEndpointProperties>();
            MessagingEndpoints = new ChangeTrackingDictionary<string, MessagingEndpointProperties>();
            Locations = new ChangeTrackingList<IotHubLocationDescription>();
        }

        /// <summary> Initializes a new instance of IotHubProperties. </summary>
        /// <param name="authorizationPolicies"> The shared access policies you can use to secure a connection to the IoT hub. </param>
        /// <param name="disableLocalAuth"> If true, SAS tokens with Iot hub scoped SAS keys cannot be used for authentication. </param>
        /// <param name="disableDeviceSAS"> If true, all device(including Edge devices but excluding modules) scoped SAS keys cannot be used for authentication. </param>
        /// <param name="disableModuleSAS"> If true, all module scoped SAS keys cannot be used for authentication. </param>
        /// <param name="restrictOutboundNetworkAccess"> If true, egress from IotHub will be restricted to only the allowed FQDNs that are configured via allowedFqdnList. </param>
        /// <param name="allowedFqdnList"> List of allowed FQDNs(Fully Qualified Domain Name) for egress from Iot Hub. </param>
        /// <param name="publicNetworkAccess"> Whether requests from Public Network are allowed. </param>
        /// <param name="ipFilterRules"> The IP filter rules. </param>
        /// <param name="networkRuleSets"> Network Rule Set Properties of IotHub. </param>
        /// <param name="minTlsVersion"> Specifies the minimum TLS version to support for this hub. Can be set to &quot;1.2&quot; to have clients that use a TLS version below 1.2 to be rejected. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections created on this IotHub. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="state"> The hub state. </param>
        /// <param name="hostName"> The name of the host. </param>
        /// <param name="eventHubEndpoints"> The Event Hub-compatible endpoint properties. The only possible keys to this dictionary is events. This key has to be present in the dictionary while making create or update calls for the IoT hub. </param>
        /// <param name="routing"> The routing related properties of the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging. </param>
        /// <param name="storageEndpoints"> The list of Azure Storage endpoints where you can upload files. Currently you can configure only one Azure Storage account and that MUST have its key as $default. Specifying more than one storage account causes an error to be thrown. Not specifying a value for this property when the enableFileUploadNotifications property is set to True, causes an error to be thrown. </param>
        /// <param name="messagingEndpoints"> The messaging endpoint properties for the file upload notification queue. </param>
        /// <param name="enableFileUploadNotifications"> If True, file upload notifications are enabled. </param>
        /// <param name="cloudToDevice"> The IoT hub cloud-to-device messaging properties. </param>
        /// <param name="comments"> IoT hub comments. </param>
        /// <param name="deviceStreams"> The device streams properties of iothub. </param>
        /// <param name="features"> The capabilities and features enabled for the IoT hub. </param>
        /// <param name="encryption"> The encryption properties for the IoT hub. </param>
        /// <param name="locations"> Primary and secondary location for iot hub. </param>
        internal IotHubProperties(IList<SharedAccessSignatureAuthorizationRule> authorizationPolicies, bool? disableLocalAuth, bool? disableDeviceSAS, bool? disableModuleSAS, bool? restrictOutboundNetworkAccess, IList<string> allowedFqdnList, PublicNetworkAccess? publicNetworkAccess, IList<IpFilterRule> ipFilterRules, NetworkRuleSetProperties networkRuleSets, string minTlsVersion, IList<PrivateEndpointConnectionData> privateEndpointConnections, string provisioningState, string state, string hostName, IDictionary<string, EventHubProperties> eventHubEndpoints, RoutingProperties routing, IDictionary<string, StorageEndpointProperties> storageEndpoints, IDictionary<string, MessagingEndpointProperties> messagingEndpoints, bool? enableFileUploadNotifications, CloudToDeviceProperties cloudToDevice, string comments, IotHubPropertiesDeviceStreams deviceStreams, Capabilities? features, EncryptionPropertiesDescription encryption, IReadOnlyList<IotHubLocationDescription> locations)
        {
            AuthorizationPolicies = authorizationPolicies;
            DisableLocalAuth = disableLocalAuth;
            DisableDeviceSAS = disableDeviceSAS;
            DisableModuleSAS = disableModuleSAS;
            RestrictOutboundNetworkAccess = restrictOutboundNetworkAccess;
            AllowedFqdnList = allowedFqdnList;
            PublicNetworkAccess = publicNetworkAccess;
            IpFilterRules = ipFilterRules;
            NetworkRuleSets = networkRuleSets;
            MinTlsVersion = minTlsVersion;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            State = state;
            HostName = hostName;
            EventHubEndpoints = eventHubEndpoints;
            Routing = routing;
            StorageEndpoints = storageEndpoints;
            MessagingEndpoints = messagingEndpoints;
            EnableFileUploadNotifications = enableFileUploadNotifications;
            CloudToDevice = cloudToDevice;
            Comments = comments;
            DeviceStreams = deviceStreams;
            Features = features;
            Encryption = encryption;
            Locations = locations;
        }

        /// <summary> The shared access policies you can use to secure a connection to the IoT hub. </summary>
        public IList<SharedAccessSignatureAuthorizationRule> AuthorizationPolicies { get; }
        /// <summary> If true, SAS tokens with Iot hub scoped SAS keys cannot be used for authentication. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> If true, all device(including Edge devices but excluding modules) scoped SAS keys cannot be used for authentication. </summary>
        public bool? DisableDeviceSAS { get; set; }
        /// <summary> If true, all module scoped SAS keys cannot be used for authentication. </summary>
        public bool? DisableModuleSAS { get; set; }
        /// <summary> If true, egress from IotHub will be restricted to only the allowed FQDNs that are configured via allowedFqdnList. </summary>
        public bool? RestrictOutboundNetworkAccess { get; set; }
        /// <summary> List of allowed FQDNs(Fully Qualified Domain Name) for egress from Iot Hub. </summary>
        public IList<string> AllowedFqdnList { get; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The IP filter rules. </summary>
        public IList<IpFilterRule> IpFilterRules { get; }
        /// <summary> Network Rule Set Properties of IotHub. </summary>
        public NetworkRuleSetProperties NetworkRuleSets { get; set; }
        /// <summary> Specifies the minimum TLS version to support for this hub. Can be set to &quot;1.2&quot; to have clients that use a TLS version below 1.2 to be rejected. </summary>
        public string MinTlsVersion { get; set; }
        /// <summary> Private endpoint connections created on this IotHub. </summary>
        public IList<PrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> The hub state. </summary>
        public string State { get; }
        /// <summary> The name of the host. </summary>
        public string HostName { get; }
        /// <summary> The Event Hub-compatible endpoint properties. The only possible keys to this dictionary is events. This key has to be present in the dictionary while making create or update calls for the IoT hub. </summary>
        public IDictionary<string, EventHubProperties> EventHubEndpoints { get; }
        /// <summary> The routing related properties of the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging. </summary>
        public RoutingProperties Routing { get; set; }
        /// <summary> The list of Azure Storage endpoints where you can upload files. Currently you can configure only one Azure Storage account and that MUST have its key as $default. Specifying more than one storage account causes an error to be thrown. Not specifying a value for this property when the enableFileUploadNotifications property is set to True, causes an error to be thrown. </summary>
        public IDictionary<string, StorageEndpointProperties> StorageEndpoints { get; }
        /// <summary> The messaging endpoint properties for the file upload notification queue. </summary>
        public IDictionary<string, MessagingEndpointProperties> MessagingEndpoints { get; }
        /// <summary> If True, file upload notifications are enabled. </summary>
        public bool? EnableFileUploadNotifications { get; set; }
        /// <summary> The IoT hub cloud-to-device messaging properties. </summary>
        public CloudToDeviceProperties CloudToDevice { get; set; }
        /// <summary> IoT hub comments. </summary>
        public string Comments { get; set; }
        /// <summary> The device streams properties of iothub. </summary>
        public IotHubPropertiesDeviceStreams DeviceStreams { get; set; }
        /// <summary> The capabilities and features enabled for the IoT hub. </summary>
        public Capabilities? Features { get; set; }
        /// <summary> The encryption properties for the IoT hub. </summary>
        public EncryptionPropertiesDescription Encryption { get; set; }
        /// <summary> Primary and secondary location for iot hub. </summary>
        public IReadOnlyList<IotHubLocationDescription> Locations { get; }
    }
}
