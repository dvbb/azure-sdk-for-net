// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing a collection of <see cref="DataReplicationVaultResource" /> and their operations.
    /// Each <see cref="DataReplicationVaultResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DataReplicationVaultCollection" /> instance call the GetDataReplicationVaults method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DataReplicationVaultCollection : ArmCollection, IEnumerable<DataReplicationVaultResource>, IAsyncEnumerable<DataReplicationVaultResource>
    {
        private readonly ClientDiagnostics _dataReplicationVaultVaultClientDiagnostics;
        private readonly VaultRestOperations _dataReplicationVaultVaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataReplicationVaultCollection"/> class for mocking. </summary>
        protected DataReplicationVaultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataReplicationVaultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataReplicationVaultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataReplicationVaultVaultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", DataReplicationVaultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataReplicationVaultResource.ResourceType, out string dataReplicationVaultVaultApiVersion);
            _dataReplicationVaultVaultRestClient = new VaultRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataReplicationVaultVaultApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="data"> Vault properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataReplicationVaultResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vaultName, DataReplicationVaultData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataReplicationVaultVaultClientDiagnostics.CreateScope("DataReplicationVaultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataReplicationVaultVaultRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesDataReplicationArmOperation<DataReplicationVaultResource>(new DataReplicationVaultOperationSource(Client), _dataReplicationVaultVaultClientDiagnostics, Pipeline, _dataReplicationVaultVaultRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="data"> Vault properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataReplicationVaultResource> CreateOrUpdate(WaitUntil waitUntil, string vaultName, DataReplicationVaultData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataReplicationVaultVaultClientDiagnostics.CreateScope("DataReplicationVaultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataReplicationVaultVaultRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data, cancellationToken);
                var operation = new RecoveryServicesDataReplicationArmOperation<DataReplicationVaultResource>(new DataReplicationVaultOperationSource(Client), _dataReplicationVaultVaultClientDiagnostics, Pipeline, _dataReplicationVaultVaultRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<DataReplicationVaultResource>> GetAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _dataReplicationVaultVaultClientDiagnostics.CreateScope("DataReplicationVaultCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataReplicationVaultVaultRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<DataReplicationVaultResource> Get(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _dataReplicationVaultVaultClientDiagnostics.CreateScope("DataReplicationVaultCollection.Get");
            scope.Start();
            try
            {
                var response = _dataReplicationVaultVaultRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of vaults in the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> Continuation token from the previous call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataReplicationVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataReplicationVaultResource> GetAllAsync(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationVaultVaultRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationVaultVaultRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataReplicationVaultResource(Client, DataReplicationVaultData.DeserializeDataReplicationVaultData(e)), _dataReplicationVaultVaultClientDiagnostics, Pipeline, "DataReplicationVaultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of vaults in the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> Continuation token from the previous call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataReplicationVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataReplicationVaultResource> GetAll(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationVaultVaultRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationVaultVaultRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataReplicationVaultResource(Client, DataReplicationVaultData.DeserializeDataReplicationVaultData(e)), _dataReplicationVaultVaultClientDiagnostics, Pipeline, "DataReplicationVaultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _dataReplicationVaultVaultClientDiagnostics.CreateScope("DataReplicationVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataReplicationVaultVaultRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<bool> Exists(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _dataReplicationVaultVaultClientDiagnostics.CreateScope("DataReplicationVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataReplicationVaultVaultRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataReplicationVaultResource> IEnumerable<DataReplicationVaultResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataReplicationVaultResource> IAsyncEnumerable<DataReplicationVaultResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
