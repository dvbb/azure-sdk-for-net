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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing collection of DeletedAccount and their operations over its parent. </summary>
    public partial class DeletedAccountCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DeletedAccountsRestOperations _deletedAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeletedAccountCollection"/> class for mocking. </summary>
        protected DeletedAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of DeletedAccountCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DeletedAccountCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _deletedAccountsRestClient = new DeletedAccountsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Get properties of specified deleted account resource. </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is null. </exception>
        public virtual Response<DeletedAccount> Get(string location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (deletedAccountName == null)
            {
                throw new ArgumentNullException(nameof(deletedAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeletedAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedAccountsRestClient.Get(Id.SubscriptionId, location, deletedAccountName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedAccount(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get properties of specified deleted account resource. </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is null. </exception>
        public async virtual Task<Response<DeletedAccount>> GetAsync(string location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (deletedAccountName == null)
            {
                throw new ArgumentNullException(nameof(deletedAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeletedAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedAccountsRestClient.GetAsync(Id.SubscriptionId, location, deletedAccountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeletedAccount(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is null. </exception>
        public virtual Response<DeletedAccount> GetIfExists(string location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (deletedAccountName == null)
            {
                throw new ArgumentNullException(nameof(deletedAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeletedAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deletedAccountsRestClient.Get(Id.SubscriptionId, location, deletedAccountName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DeletedAccount>(null, response.GetRawResponse())
                    : Response.FromValue(new DeletedAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is null. </exception>
        public async virtual Task<Response<DeletedAccount>> GetIfExistsAsync(string location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (deletedAccountName == null)
            {
                throw new ArgumentNullException(nameof(deletedAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeletedAccountCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _deletedAccountsRestClient.GetAsync(Id.SubscriptionId, location, deletedAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DeletedAccount>(null, response.GetRawResponse())
                    : Response.FromValue(new DeletedAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is null. </exception>
        public virtual Response<bool> Exists(string location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (deletedAccountName == null)
            {
                throw new ArgumentNullException(nameof(deletedAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeletedAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, deletedAccountName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="deletedAccountName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (deletedAccountName == null)
            {
                throw new ArgumentNullException(nameof(deletedAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeletedAccountCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, deletedAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DeletedAccount" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedAccountCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DeletedAccount.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DeletedAccount" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedAccountCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DeletedAccount.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DeletedAccount, DeletedAccountData> Construct() { }
    }
}
