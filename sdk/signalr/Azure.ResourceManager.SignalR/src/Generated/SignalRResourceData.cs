// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR
{
    /// <summary> A class representing the SignalRResource data model. </summary>
    public partial class SignalRResourceData : TrackedResource
    {
        /// <summary> Initializes a new instance of SignalRResourceData. </summary>
        /// <param name="location"> The location. </param>
        public SignalRResourceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionData>();
            SharedPrivateLinkResources = new ChangeTrackingList<SharedPrivateLinkResourceData>();
            Features = new ChangeTrackingList<SignalRFeature>();
        }

        /// <summary> Initializes a new instance of SignalRResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The billing information of the resource. </param>
        /// <param name="kind"> The kind of the service, it can be SignalR or RawWebSockets. </param>
        /// <param name="identity"> A class represent managed identities used for request and response. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="externalIP"> The publicly accessible IP of the resource. </param>
        /// <param name="hostName"> FQDN of the service instance. </param>
        /// <param name="publicPort"> The publicly accessible port of the resource which is designed for browser/client side usage. </param>
        /// <param name="serverPort"> The publicly accessible port of the resource which is designed for customer server side usage. </param>
        /// <param name="version"> Version of the resource. Probably you need the same or higher version of client SDKs. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections to the resource. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources. </param>
        /// <param name="tls"> TLS settings for the resource. </param>
        /// <param name="hostNamePrefix"> Deprecated. </param>
        /// <param name="features">
        /// List of the featureFlags.
        /// 
        /// FeatureFlags that are not included in the parameters for the update operation will not be modified.
        /// And the response will only include featureFlags that are explicitly set. 
        /// When a featureFlag is not explicitly set, its globally default value will be used
        /// But keep in mind, the default value doesn&apos;t mean &quot;false&quot;. It varies in terms of different FeatureFlags.
        /// </param>
        /// <param name="resourceLogConfiguration"> Resource log configuration of a Microsoft.SignalRService resource. </param>
        /// <param name="cors"> Cross-Origin Resource Sharing (CORS) settings. </param>
        /// <param name="upstream"> The settings for the Upstream when the service is in server-less mode. </param>
        /// <param name="networkACLs"> Network ACLs for the resource. </param>
        /// <param name="publicNetworkAccess">
        /// Enable or disable public network access. Default to &quot;Enabled&quot;.
        /// When it&apos;s Enabled, network ACLs still apply.
        /// When it&apos;s Disabled, public network access is always disabled no matter what you set in network ACLs.
        /// </param>
        /// <param name="disableLocalAuth">
        /// DisableLocalAuth
        /// Enable or disable local auth with AccessKey
        /// When set as true, connection with AccessKey=xxx won&apos;t work.
        /// </param>
        /// <param name="disableAadAuth">
        /// DisableLocalAuth
        /// Enable or disable aad auth
        /// When set as true, connection with AuthType=aad won&apos;t work.
        /// </param>
        internal SignalRResourceData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, ResourceSku sku, ServiceKind? kind, ManagedIdentity identity, SystemData systemData, ProvisioningState? provisioningState, string externalIP, string hostName, int? publicPort, int? serverPort, string version, IReadOnlyList<PrivateEndpointConnectionData> privateEndpointConnections, IReadOnlyList<SharedPrivateLinkResourceData> sharedPrivateLinkResources, SignalRTlsSettings tls, string hostNamePrefix, IList<SignalRFeature> features, ResourceLogConfiguration resourceLogConfiguration, SignalRCorsSettings cors, ServerlessUpstreamSettings upstream, SignalRNetworkACLs networkACLs, string publicNetworkAccess, bool? disableLocalAuth, bool? disableAadAuth) : base(id, name, type, tags, location)
        {
            Sku = sku;
            Kind = kind;
            Identity = identity;
            SystemData = systemData;
            ProvisioningState = provisioningState;
            ExternalIP = externalIP;
            HostName = hostName;
            PublicPort = publicPort;
            ServerPort = serverPort;
            Version = version;
            PrivateEndpointConnections = privateEndpointConnections;
            SharedPrivateLinkResources = sharedPrivateLinkResources;
            Tls = tls;
            HostNamePrefix = hostNamePrefix;
            Features = features;
            ResourceLogConfiguration = resourceLogConfiguration;
            Cors = cors;
            Upstream = upstream;
            NetworkACLs = networkACLs;
            PublicNetworkAccess = publicNetworkAccess;
            DisableLocalAuth = disableLocalAuth;
            DisableAadAuth = disableAadAuth;
        }

        /// <summary> The billing information of the resource. </summary>
        public ResourceSku Sku { get; set; }
        /// <summary> The kind of the service, it can be SignalR or RawWebSockets. </summary>
        public ServiceKind? Kind { get; set; }
        /// <summary> A class represent managed identities used for request and response. </summary>
        public ManagedIdentity Identity { get; set; }
        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The publicly accessible IP of the resource. </summary>
        public string ExternalIP { get; }
        /// <summary> FQDN of the service instance. </summary>
        public string HostName { get; }
        /// <summary> The publicly accessible port of the resource which is designed for browser/client side usage. </summary>
        public int? PublicPort { get; }
        /// <summary> The publicly accessible port of the resource which is designed for customer server side usage. </summary>
        public int? ServerPort { get; }
        /// <summary> Version of the resource. Probably you need the same or higher version of client SDKs. </summary>
        public string Version { get; }
        /// <summary> Private endpoint connections to the resource. </summary>
        public IReadOnlyList<PrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The list of shared private link resources. </summary>
        public IReadOnlyList<SharedPrivateLinkResourceData> SharedPrivateLinkResources { get; }
        /// <summary> TLS settings for the resource. </summary>
        public SignalRTlsSettings Tls { get; set; }
        /// <summary> Deprecated. </summary>
        public string HostNamePrefix { get; }
        /// <summary>
        /// List of the featureFlags.
        /// 
        /// FeatureFlags that are not included in the parameters for the update operation will not be modified.
        /// And the response will only include featureFlags that are explicitly set. 
        /// When a featureFlag is not explicitly set, its globally default value will be used
        /// But keep in mind, the default value doesn&apos;t mean &quot;false&quot;. It varies in terms of different FeatureFlags.
        /// </summary>
        public IList<SignalRFeature> Features { get; }
        /// <summary> Resource log configuration of a Microsoft.SignalRService resource. </summary>
        public ResourceLogConfiguration ResourceLogConfiguration { get; set; }
        /// <summary> Cross-Origin Resource Sharing (CORS) settings. </summary>
        public SignalRCorsSettings Cors { get; set; }
        /// <summary> The settings for the Upstream when the service is in server-less mode. </summary>
        public ServerlessUpstreamSettings Upstream { get; set; }
        /// <summary> Network ACLs for the resource. </summary>
        public SignalRNetworkACLs NetworkACLs { get; set; }
        /// <summary>
        /// Enable or disable public network access. Default to &quot;Enabled&quot;.
        /// When it&apos;s Enabled, network ACLs still apply.
        /// When it&apos;s Disabled, public network access is always disabled no matter what you set in network ACLs.
        /// </summary>
        public string PublicNetworkAccess { get; set; }
        /// <summary>
        /// DisableLocalAuth
        /// Enable or disable local auth with AccessKey
        /// When set as true, connection with AccessKey=xxx won&apos;t work.
        /// </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary>
        /// DisableLocalAuth
        /// Enable or disable aad auth
        /// When set as true, connection with AuthType=aad won&apos;t work.
        /// </summary>
        public bool? DisableAadAuth { get; set; }
    }
}
