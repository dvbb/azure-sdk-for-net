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
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary> A class representing collection of DatasetResource and their operations over its parent. </summary>
    public partial class DatasetResourceCollection : ArmCollection, IEnumerable<DatasetResource>, IAsyncEnumerable<DatasetResource>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DatasetsRestOperations _datasetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DatasetResourceCollection"/> class for mocking. </summary>
        protected DatasetResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DatasetResourceCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DatasetResourceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(DatasetResource.ResourceType, out string apiVersion);
            _datasetsRestClient = new DatasetsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Factory.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Factory.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a dataset. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="dataset"> Dataset resource definition. </param>
        /// <param name="ifMatch"> ETag of the dataset entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="dataset"/> is null. </exception>
        public virtual DatasetResourceCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string datasetName, DatasetResourceData dataset, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _datasetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, dataset, ifMatch, cancellationToken);
                var operation = new DatasetResourceCreateOrUpdateOperation(this, response);
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

        /// <summary> Creates or updates a dataset. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="dataset"> Dataset resource definition. </param>
        /// <param name="ifMatch"> ETag of the dataset entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="dataset"/> is null. </exception>
        public async virtual Task<DatasetResourceCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string datasetName, DatasetResourceData dataset, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _datasetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, dataset, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DatasetResourceCreateOrUpdateOperation(this, response);
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

        /// <summary> Gets a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual Response<DatasetResource> Get(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _datasetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatasetResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public async virtual Task<Response<DatasetResource>> GetAsync(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _datasetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DatasetResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual Response<DatasetResource> GetIfExists(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _datasetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, ifNoneMatch, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DatasetResource>(null, response.GetRawResponse());
                return Response.FromValue(new DatasetResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public async virtual Task<Response<DatasetResource>> GetIfExistsAsync(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _datasetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DatasetResource>(null, response.GetRawResponse());
                return Response.FromValue(new DatasetResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual Response<bool> Exists(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(datasetName, ifNoneMatch, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(datasetName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists datasets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatasetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatasetResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DatasetResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _datasetsRestClient.ListByFactory(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DatasetResource(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DatasetResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _datasetsRestClient.ListByFactoryNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DatasetResource(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists datasets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatasetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatasetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DatasetResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _datasetsRestClient.ListByFactoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DatasetResource(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DatasetResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DatasetResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _datasetsRestClient.ListByFactoryNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DatasetResource(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<DatasetResource> IEnumerable<DatasetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DatasetResource> IAsyncEnumerable<DatasetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DatasetResource, DatasetResourceData> Construct() { }
    }
}
