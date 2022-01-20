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
using Azure.ResourceManager.PrivateDns.Models;

namespace Azure.ResourceManager.PrivateDns
{
    /// <summary> A class representing collection of VirtualNetworkLink and their operations over its parent. </summary>
    public partial class VirtualNetworkLinkCollection : ArmCollection, IEnumerable<VirtualNetworkLink>, IAsyncEnumerable<VirtualNetworkLink>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualNetworkLinksRestOperations _virtualNetworkLinksRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkLinkCollection"/> class for mocking. </summary>
        protected VirtualNetworkLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkLinkCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkLinkCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VirtualNetworkLink.ResourceType, out string apiVersion);
            _virtualNetworkLinksRestClient = new VirtualNetworkLinksRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateZone.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateZone.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a virtual network link to the specified Private DNS zone. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="parameters"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The ETag of the virtual network link to the Private DNS zone. Omit this value to always overwrite the current virtual network link. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new virtual network link to the Private DNS zone to be created, but to prevent updating an existing link. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualNetworkLinkCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string virtualNetworkLinkName, VirtualNetworkLinkData parameters, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkLinkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkLinkName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkLinksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, parameters, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new VirtualNetworkLinkCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualNetworkLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, parameters, ifMatch, ifNoneMatch).Request, response);
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

        /// <summary> Creates or updates a virtual network link to the specified Private DNS zone. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="parameters"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The ETag of the virtual network link to the Private DNS zone. Omit this value to always overwrite the current virtual network link. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new virtual network link to the Private DNS zone to be created, but to prevent updating an existing link. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkLinkCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string virtualNetworkLinkName, VirtualNetworkLinkData parameters, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkLinkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkLinkName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkLinksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, parameters, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkLinkCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualNetworkLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, parameters, ifMatch, ifNoneMatch).Request, response);
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

        /// <summary> Gets a virtual network link to the specified Private DNS zone. </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual Response<VirtualNetworkLink> Get(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkLinkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a virtual network link to the specified Private DNS zone. </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkLink>> GetAsync(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkLinkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual Response<VirtualNetworkLink> GetIfExists(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkLinkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkLink>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkLink>> GetIfExistsAsync(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkLinkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkLink>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkLinkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualNetworkLinkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkLinkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualNetworkLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the virtual network links to the specified Private DNS zone. </summary>
        /// <param name="top"> The maximum number of virtual network links to return. If not specified, returns up to 100 virtual network links. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkLink> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkLinksRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkLink(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkLinksRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkLink(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the virtual network links to the specified Private DNS zone. </summary>
        /// <param name="top"> The maximum number of virtual network links to return. If not specified, returns up to 100 virtual network links. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkLink> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkLinksRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkLink(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkLinksRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkLink(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VirtualNetworkLink> IEnumerable<VirtualNetworkLink>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkLink> IAsyncEnumerable<VirtualNetworkLink>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualNetworkLink, VirtualNetworkLinkData> Construct() { }
    }
}
