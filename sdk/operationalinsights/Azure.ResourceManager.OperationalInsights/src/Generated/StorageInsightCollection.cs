// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary> A class representing collection of StorageInsight and their operations over its parent. </summary>
    public partial class StorageInsightCollection : ArmCollection, IEnumerable<StorageInsight>, IAsyncEnumerable<StorageInsight>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly StorageInsightConfigsRestOperations _storageInsightConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageInsightCollection"/> class for mocking. </summary>
        protected StorageInsightCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageInsightCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal StorageInsightCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(StorageInsight.ResourceType, out string apiVersion);
            _storageInsightConfigsRestClient = new StorageInsightConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Workspace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Workspace.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update a storage insight. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="parameters"> The parameters required to create or update a storage insight. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual StorageInsightCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string storageInsightName, StorageInsightData parameters, CancellationToken cancellationToken = default)
        {
            if (storageInsightName == null)
            {
                throw new ArgumentNullException(nameof(storageInsightName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageInsightConfigsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, parameters, cancellationToken);
                var operation = new StorageInsightCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a storage insight. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="parameters"> The parameters required to create or update a storage insight. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<StorageInsightCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string storageInsightName, StorageInsightData parameters, CancellationToken cancellationToken = default)
        {
            if (storageInsightName == null)
            {
                throw new ArgumentNullException(nameof(storageInsightName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageInsightConfigsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new StorageInsightCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a storage insight instance. </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public virtual Response<StorageInsight> Get(string storageInsightName, CancellationToken cancellationToken = default)
        {
            if (storageInsightName == null)
            {
                throw new ArgumentNullException(nameof(storageInsightName));
            }

            using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.Get");
            scope.Start();
            try
            {
                var response = _storageInsightConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageInsight(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a storage insight instance. </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public async virtual Task<Response<StorageInsight>> GetAsync(string storageInsightName, CancellationToken cancellationToken = default)
        {
            if (storageInsightName == null)
            {
                throw new ArgumentNullException(nameof(storageInsightName));
            }

            using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageInsightConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new StorageInsight(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public virtual Response<StorageInsight> GetIfExists(string storageInsightName, CancellationToken cancellationToken = default)
        {
            if (storageInsightName == null)
            {
                throw new ArgumentNullException(nameof(storageInsightName));
            }

            using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageInsightConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<StorageInsight>(null, response.GetRawResponse());
                return Response.FromValue(new StorageInsight(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public async virtual Task<Response<StorageInsight>> GetIfExistsAsync(string storageInsightName, CancellationToken cancellationToken = default)
        {
            if (storageInsightName == null)
            {
                throw new ArgumentNullException(nameof(storageInsightName));
            }

            using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageInsightConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageInsightName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<StorageInsight>(null, response.GetRawResponse());
                return Response.FromValue(new StorageInsight(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageInsightName, CancellationToken cancellationToken = default)
        {
            if (storageInsightName == null)
            {
                throw new ArgumentNullException(nameof(storageInsightName));
            }

            using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(storageInsightName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="storageInsightName"> Name of the storageInsightsConfigs resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageInsightName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string storageInsightName, CancellationToken cancellationToken = default)
        {
            if (storageInsightName == null)
            {
                throw new ArgumentNullException(nameof(storageInsightName));
            }

            using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(storageInsightName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the storage insight instances within a workspace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageInsight" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageInsight> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StorageInsight> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _storageInsightConfigsRestClient.ListByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageInsight(this, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StorageInsight> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _storageInsightConfigsRestClient.ListByWorkspaceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageInsight(this, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the storage insight instances within a workspace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageInsight" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageInsight> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StorageInsight>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _storageInsightConfigsRestClient.ListByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageInsight(this, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StorageInsight>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StorageInsightCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _storageInsightConfigsRestClient.ListByWorkspaceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageInsight(this, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<StorageInsight> IEnumerable<StorageInsight>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageInsight> IAsyncEnumerable<StorageInsight>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, StorageInsight, StorageInsightData> Construct() { }
    }
}
