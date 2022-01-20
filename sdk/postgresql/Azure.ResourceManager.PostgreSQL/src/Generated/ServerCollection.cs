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
using Azure.ResourceManager.PostgreSQL.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PostgreSQL
{
    /// <summary> A class representing collection of Server and their operations over its parent. </summary>
    public partial class ServerCollection : ArmCollection, IEnumerable<Server>, IAsyncEnumerable<Server>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServersRestOperations _serversRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerCollection"/> class for mocking. </summary>
        protected ServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Server.ResourceType, out string apiVersion);
            _serversRestClient = new ServersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Creates a new server. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="parameters"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ServerCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string serverName, ServerData parameters, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serversRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, serverName, parameters, cancellationToken);
                var operation = new ServerCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _serversRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, parameters).Request, response);
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

        /// <summary> Creates a new server. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="parameters"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ServerCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string serverName, ServerData parameters, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serversRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServerCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _serversRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, parameters).Request, response);
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

        /// <summary> Gets information about a server. </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<Server> Get(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCollection.Get");
            scope.Start();
            try
            {
                var response = _serversRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Server(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about a server. </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public async virtual Task<Response<Server>> GetAsync(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _serversRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Server(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<Server> GetIfExists(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serversRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Server>(null, response.GetRawResponse());
                return Response.FromValue(new Server(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public async virtual Task<Response<Server>> GetIfExistsAsync(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serversRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Server>(null, response.GetRawResponse());
                return Response.FromValue(new Server(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(serverName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serverName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all the servers in a given resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Server" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Server> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Server> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serversRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Server(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Server> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serversRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Server(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List all the servers in a given resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Server" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Server> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Server>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serversRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Server(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Server>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serversRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Server(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Server" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Server.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Server" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Server.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Server> IEnumerable<Server>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Server> IAsyncEnumerable<Server>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Server, ServerData> Construct() { }
    }
}
