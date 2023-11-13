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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapseRestorableDroppedSqlPool along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SynapseRestorableDroppedSqlPoolResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSynapseRestorableDroppedSqlPoolResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseWorkspaceResource" /> using the GetSynapseRestorableDroppedSqlPool method.
    /// </summary>
    public partial class SynapseRestorableDroppedSqlPoolResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseRestorableDroppedSqlPoolResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="restorableDroppedSqlPoolId"> The restorableDroppedSqlPoolId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string restorableDroppedSqlPoolId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/restorableDroppedSqlPools/{restorableDroppedSqlPoolId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics;
        private readonly RestorableDroppedSqlPoolsRestOperations _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient;
        private readonly SynapseRestorableDroppedSqlPoolData _data;

        /// <summary> Initializes a new instance of the <see cref="SynapseRestorableDroppedSqlPoolResource"/> class for mocking. </summary>
        protected SynapseRestorableDroppedSqlPoolResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SynapseRestorableDroppedSqlPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseRestorableDroppedSqlPoolResource(ArmClient client, SynapseRestorableDroppedSqlPoolData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseRestorableDroppedSqlPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseRestorableDroppedSqlPoolResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsApiVersion);
            _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient = new RestorableDroppedSqlPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/restorableDroppedSqlPools";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseRestorableDroppedSqlPoolData Data
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
        /// Gets a deleted sql pool that can be restored
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/restorableDroppedSqlPools/{restorableDroppedSqlPoolId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedSqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseRestorableDroppedSqlPoolResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics.CreateScope("SynapseRestorableDroppedSqlPoolResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseRestorableDroppedSqlPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deleted sql pool that can be restored
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/restorableDroppedSqlPools/{restorableDroppedSqlPoolId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedSqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseRestorableDroppedSqlPoolResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics.CreateScope("SynapseRestorableDroppedSqlPoolResource.Get");
            scope.Start();
            try
            {
                var response = _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseRestorableDroppedSqlPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
