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
using Azure.ResourceManager.ServiceFabricMesh.Models;

namespace Azure.ResourceManager.ServiceFabricMesh
{
    /// <summary> A class representing collection of GatewayResourceDescription and their operations over its parent. </summary>
    public partial class GatewayResourceDescriptionCollection : ArmCollection, IEnumerable<GatewayResourceDescription>, IAsyncEnumerable<GatewayResourceDescription>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly GatewayRestOperations _gatewayRestClient;

        /// <summary> Initializes a new instance of the <see cref="GatewayResourceDescriptionCollection"/> class for mocking. </summary>
        protected GatewayResourceDescriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GatewayResourceDescriptionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GatewayResourceDescriptionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(GatewayResourceDescription.ResourceType, out string apiVersion);
            _gatewayRestClient = new GatewayRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Creates a gateway resource with the specified name, description and properties. If a gateway resource with the same name exists, then it is updated with the specified description and properties. Use gateway resources to create a gateway for public connectivity for services within your application. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="gatewayResourceName"> The identity of the gateway. </param>
        /// <param name="gatewayResourceDescription"> Description for creating a Gateway resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayResourceName"/> or <paramref name="gatewayResourceDescription"/> is null. </exception>
        public virtual GatewayResourceDescriptionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string gatewayResourceName, GatewayResourceDescriptionData gatewayResourceDescription, CancellationToken cancellationToken = default)
        {
            if (gatewayResourceName == null)
            {
                throw new ArgumentNullException(nameof(gatewayResourceName));
            }
            if (gatewayResourceDescription == null)
            {
                throw new ArgumentNullException(nameof(gatewayResourceDescription));
            }

            using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _gatewayRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, gatewayResourceName, gatewayResourceDescription, cancellationToken);
                var operation = new GatewayResourceDescriptionCreateOrUpdateOperation(this, response);
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

        /// <summary> Creates a gateway resource with the specified name, description and properties. If a gateway resource with the same name exists, then it is updated with the specified description and properties. Use gateway resources to create a gateway for public connectivity for services within your application. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="gatewayResourceName"> The identity of the gateway. </param>
        /// <param name="gatewayResourceDescription"> Description for creating a Gateway resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayResourceName"/> or <paramref name="gatewayResourceDescription"/> is null. </exception>
        public async virtual Task<GatewayResourceDescriptionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string gatewayResourceName, GatewayResourceDescriptionData gatewayResourceDescription, CancellationToken cancellationToken = default)
        {
            if (gatewayResourceName == null)
            {
                throw new ArgumentNullException(nameof(gatewayResourceName));
            }
            if (gatewayResourceDescription == null)
            {
                throw new ArgumentNullException(nameof(gatewayResourceDescription));
            }

            using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _gatewayRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayResourceName, gatewayResourceDescription, cancellationToken).ConfigureAwait(false);
                var operation = new GatewayResourceDescriptionCreateOrUpdateOperation(this, response);
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

        /// <summary> Gets the information about the gateway resource with the given name. The information include the description and other properties of the gateway. </summary>
        /// <param name="gatewayResourceName"> The identity of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayResourceName"/> is null. </exception>
        public virtual Response<GatewayResourceDescription> Get(string gatewayResourceName, CancellationToken cancellationToken = default)
        {
            if (gatewayResourceName == null)
            {
                throw new ArgumentNullException(nameof(gatewayResourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _gatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, gatewayResourceName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GatewayResourceDescription(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the information about the gateway resource with the given name. The information include the description and other properties of the gateway. </summary>
        /// <param name="gatewayResourceName"> The identity of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayResourceName"/> is null. </exception>
        public async virtual Task<Response<GatewayResourceDescription>> GetAsync(string gatewayResourceName, CancellationToken cancellationToken = default)
        {
            if (gatewayResourceName == null)
            {
                throw new ArgumentNullException(nameof(gatewayResourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _gatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new GatewayResourceDescription(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayResourceName"> The identity of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayResourceName"/> is null. </exception>
        public virtual Response<GatewayResourceDescription> GetIfExists(string gatewayResourceName, CancellationToken cancellationToken = default)
        {
            if (gatewayResourceName == null)
            {
                throw new ArgumentNullException(nameof(gatewayResourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _gatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, gatewayResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<GatewayResourceDescription>(null, response.GetRawResponse());
                return Response.FromValue(new GatewayResourceDescription(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayResourceName"> The identity of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayResourceName"/> is null. </exception>
        public async virtual Task<Response<GatewayResourceDescription>> GetIfExistsAsync(string gatewayResourceName, CancellationToken cancellationToken = default)
        {
            if (gatewayResourceName == null)
            {
                throw new ArgumentNullException(nameof(gatewayResourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _gatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<GatewayResourceDescription>(null, response.GetRawResponse());
                return Response.FromValue(new GatewayResourceDescription(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayResourceName"> The identity of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string gatewayResourceName, CancellationToken cancellationToken = default)
        {
            if (gatewayResourceName == null)
            {
                throw new ArgumentNullException(nameof(gatewayResourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(gatewayResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayResourceName"> The identity of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayResourceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string gatewayResourceName, CancellationToken cancellationToken = default)
        {
            if (gatewayResourceName == null)
            {
                throw new ArgumentNullException(nameof(gatewayResourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(gatewayResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the information about all gateway resources in a given resource group. The information include the description and other properties of the Gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GatewayResourceDescription" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GatewayResourceDescription> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GatewayResourceDescription> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _gatewayRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GatewayResourceDescription(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GatewayResourceDescription> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _gatewayRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GatewayResourceDescription(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the information about all gateway resources in a given resource group. The information include the description and other properties of the Gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GatewayResourceDescription" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GatewayResourceDescription> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GatewayResourceDescription>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _gatewayRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GatewayResourceDescription(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GatewayResourceDescription>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _gatewayRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GatewayResourceDescription(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="GatewayResourceDescription" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(GatewayResourceDescription.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="GatewayResourceDescription" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GatewayResourceDescriptionCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(GatewayResourceDescription.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GatewayResourceDescription> IEnumerable<GatewayResourceDescription>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GatewayResourceDescription> IAsyncEnumerable<GatewayResourceDescription>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, GatewayResourceDescription, GatewayResourceDescriptionData> Construct() { }
    }
}
