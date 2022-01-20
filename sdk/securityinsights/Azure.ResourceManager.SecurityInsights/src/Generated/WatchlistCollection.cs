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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> A class representing collection of Watchlist and their operations over its parent. </summary>
    public partial class WatchlistCollection : ArmCollection, IEnumerable<Watchlist>, IAsyncEnumerable<Watchlist>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WatchlistsRestOperations _watchlistsRestClient;
        private readonly string _workspaceName;

        /// <summary> Initializes a new instance of the <see cref="WatchlistCollection"/> class for mocking. </summary>
        protected WatchlistCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WatchlistCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        internal WatchlistCollection(ArmResource parent, string workspaceName) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Watchlist.ResourceType, out string apiVersion);
            _watchlistsRestClient = new WatchlistsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _workspaceName = workspaceName;
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a watchlist and its watchlist items (bulk creation, e.g. through text/csv content type). To create a Watchlist and its items, we should call this endpoint with rawContent and contentType properties. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="watchlist"> The watchlist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> or <paramref name="watchlist"/> is null. </exception>
        public virtual WatchlistCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string watchlistAlias, WatchlistData watchlist, CancellationToken cancellationToken = default)
        {
            if (watchlistAlias == null)
            {
                throw new ArgumentNullException(nameof(watchlistAlias));
            }
            if (watchlist == null)
            {
                throw new ArgumentNullException(nameof(watchlist));
            }

            using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _watchlistsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, watchlistAlias, watchlist, cancellationToken);
                var operation = new WatchlistCreateOrUpdateOperation(this, response);
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

        /// <summary> Creates or updates a watchlist and its watchlist items (bulk creation, e.g. through text/csv content type). To create a Watchlist and its items, we should call this endpoint with rawContent and contentType properties. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="watchlist"> The watchlist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> or <paramref name="watchlist"/> is null. </exception>
        public async virtual Task<WatchlistCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string watchlistAlias, WatchlistData watchlist, CancellationToken cancellationToken = default)
        {
            if (watchlistAlias == null)
            {
                throw new ArgumentNullException(nameof(watchlistAlias));
            }
            if (watchlist == null)
            {
                throw new ArgumentNullException(nameof(watchlist));
            }

            using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _watchlistsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, watchlistAlias, watchlist, cancellationToken).ConfigureAwait(false);
                var operation = new WatchlistCreateOrUpdateOperation(this, response);
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

        /// <summary> Gets a watchlist, without its watchlist items. </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public virtual Response<Watchlist> Get(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            if (watchlistAlias == null)
            {
                throw new ArgumentNullException(nameof(watchlistAlias));
            }

            using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.Get");
            scope.Start();
            try
            {
                var response = _watchlistsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, watchlistAlias, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Watchlist(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a watchlist, without its watchlist items. </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public async virtual Task<Response<Watchlist>> GetAsync(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            if (watchlistAlias == null)
            {
                throw new ArgumentNullException(nameof(watchlistAlias));
            }

            using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.Get");
            scope.Start();
            try
            {
                var response = await _watchlistsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, watchlistAlias, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Watchlist(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public virtual Response<Watchlist> GetIfExists(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            if (watchlistAlias == null)
            {
                throw new ArgumentNullException(nameof(watchlistAlias));
            }

            using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _watchlistsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, watchlistAlias, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Watchlist>(null, response.GetRawResponse());
                return Response.FromValue(new Watchlist(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public async virtual Task<Response<Watchlist>> GetIfExistsAsync(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            if (watchlistAlias == null)
            {
                throw new ArgumentNullException(nameof(watchlistAlias));
            }

            using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _watchlistsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, watchlistAlias, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Watchlist>(null, response.GetRawResponse());
                return Response.FromValue(new Watchlist(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public virtual Response<bool> Exists(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            if (watchlistAlias == null)
            {
                throw new ArgumentNullException(nameof(watchlistAlias));
            }

            using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(watchlistAlias, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            if (watchlistAlias == null)
            {
                throw new ArgumentNullException(nameof(watchlistAlias));
            }

            using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(watchlistAlias, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all watchlists, without watchlist items. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Watchlist" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Watchlist> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Watchlist> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _watchlistsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Watchlist(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Watchlist> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _watchlistsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Watchlist(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all watchlists, without watchlist items. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Watchlist" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Watchlist> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Watchlist>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _watchlistsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Watchlist(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Watchlist>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _watchlistsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Watchlist(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Watchlist" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Watchlist.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Watchlist" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WatchlistCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Watchlist.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Watchlist> IEnumerable<Watchlist>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Watchlist> IAsyncEnumerable<Watchlist>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Watchlist, WatchlistData> Construct() { }
    }
}
