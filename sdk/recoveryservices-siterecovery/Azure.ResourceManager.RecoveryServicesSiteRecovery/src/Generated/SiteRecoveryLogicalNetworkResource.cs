// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A Class representing a SiteRecoveryLogicalNetwork along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SiteRecoveryLogicalNetworkResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSiteRecoveryLogicalNetworkResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteRecoveryFabricResource"/> using the GetSiteRecoveryLogicalNetwork method.
    /// </summary>
    public partial class SiteRecoveryLogicalNetworkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteRecoveryLogicalNetworkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="fabricName"> The fabricName. </param>
        /// <param name="logicalNetworkName"> The logicalNetworkName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string logicalNetworkName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationLogicalNetworks/{logicalNetworkName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteRecoveryLogicalNetworkReplicationLogicalNetworksClientDiagnostics;
        private readonly ReplicationLogicalNetworksRestOperations _siteRecoveryLogicalNetworkReplicationLogicalNetworksRestClient;
        private readonly SiteRecoveryLogicalNetworkData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/replicationFabrics/replicationLogicalNetworks";

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryLogicalNetworkResource"/> class for mocking. </summary>
        protected SiteRecoveryLogicalNetworkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryLogicalNetworkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteRecoveryLogicalNetworkResource(ArmClient client, SiteRecoveryLogicalNetworkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryLogicalNetworkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteRecoveryLogicalNetworkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecoveryLogicalNetworkReplicationLogicalNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteRecoveryLogicalNetworkReplicationLogicalNetworksApiVersion);
            _siteRecoveryLogicalNetworkReplicationLogicalNetworksRestClient = new ReplicationLogicalNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryLogicalNetworkReplicationLogicalNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteRecoveryLogicalNetworkData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details of a logical network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationLogicalNetworks/{logicalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLogicalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteRecoveryLogicalNetworkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryLogicalNetworkReplicationLogicalNetworksClientDiagnostics.CreateScope("SiteRecoveryLogicalNetworkResource.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryLogicalNetworkReplicationLogicalNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryLogicalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a logical network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationLogicalNetworks/{logicalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLogicalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteRecoveryLogicalNetworkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryLogicalNetworkReplicationLogicalNetworksClientDiagnostics.CreateScope("SiteRecoveryLogicalNetworkResource.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryLogicalNetworkReplicationLogicalNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryLogicalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
