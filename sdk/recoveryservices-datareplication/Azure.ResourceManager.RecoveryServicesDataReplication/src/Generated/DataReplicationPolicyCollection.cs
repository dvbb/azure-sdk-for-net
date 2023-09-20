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

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing a collection of <see cref="DataReplicationPolicyResource" /> and their operations.
    /// Each <see cref="DataReplicationPolicyResource" /> in the collection will belong to the same instance of <see cref="DataReplicationVaultResource" />.
    /// To get a <see cref="DataReplicationPolicyCollection" /> instance call the GetDataReplicationPolicies method from an instance of <see cref="DataReplicationVaultResource" />.
    /// </summary>
    public partial class DataReplicationPolicyCollection : ArmCollection, IEnumerable<DataReplicationPolicyResource>, IAsyncEnumerable<DataReplicationPolicyResource>
    {
        private readonly ClientDiagnostics _dataReplicationPolicyPolicyClientDiagnostics;
        private readonly PolicyRestOperations _dataReplicationPolicyPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataReplicationPolicyCollection"/> class for mocking. </summary>
        protected DataReplicationPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataReplicationPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataReplicationPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataReplicationPolicyPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", DataReplicationPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataReplicationPolicyResource.ResourceType, out string dataReplicationPolicyPolicyApiVersion);
            _dataReplicationPolicyPolicyRestClient = new PolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataReplicationPolicyPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataReplicationVaultResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataReplicationVaultResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="data"> Policy model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataReplicationPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyName, DataReplicationPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataReplicationPolicyPolicyClientDiagnostics.CreateScope("DataReplicationPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataReplicationPolicyPolicyRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesDataReplicationArmOperation<DataReplicationPolicyResource>(new DataReplicationPolicyOperationSource(Client), _dataReplicationPolicyPolicyClientDiagnostics, Pipeline, _dataReplicationPolicyPolicyRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="data"> Policy model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataReplicationPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string policyName, DataReplicationPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataReplicationPolicyPolicyClientDiagnostics.CreateScope("DataReplicationPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataReplicationPolicyPolicyRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyName, data, cancellationToken);
                var operation = new RecoveryServicesDataReplicationArmOperation<DataReplicationPolicyResource>(new DataReplicationPolicyOperationSource(Client), _dataReplicationPolicyPolicyClientDiagnostics, Pipeline, _dataReplicationPolicyPolicyRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<DataReplicationPolicyResource>> GetAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _dataReplicationPolicyPolicyClientDiagnostics.CreateScope("DataReplicationPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataReplicationPolicyPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<DataReplicationPolicyResource> Get(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _dataReplicationPolicyPolicyClientDiagnostics.CreateScope("DataReplicationPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _dataReplicationPolicyPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of policies in the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataReplicationPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataReplicationPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationPolicyPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationPolicyPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataReplicationPolicyResource(Client, DataReplicationPolicyData.DeserializeDataReplicationPolicyData(e)), _dataReplicationPolicyPolicyClientDiagnostics, Pipeline, "DataReplicationPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of policies in the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataReplicationPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataReplicationPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationPolicyPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationPolicyPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataReplicationPolicyResource(Client, DataReplicationPolicyData.DeserializeDataReplicationPolicyData(e)), _dataReplicationPolicyPolicyClientDiagnostics, Pipeline, "DataReplicationPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _dataReplicationPolicyPolicyClientDiagnostics.CreateScope("DataReplicationPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataReplicationPolicyPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _dataReplicationPolicyPolicyClientDiagnostics.CreateScope("DataReplicationPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataReplicationPolicyPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, policyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataReplicationPolicyResource> IEnumerable<DataReplicationPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataReplicationPolicyResource> IAsyncEnumerable<DataReplicationPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
