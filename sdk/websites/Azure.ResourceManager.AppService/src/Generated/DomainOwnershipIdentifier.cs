// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a DomainOwnershipIdentifier along with the instance operations that can be performed on it. </summary>
    public partial class DomainOwnershipIdentifier : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DomainOwnershipIdentifier"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string domainName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DomainsRestOperations _domainsRestClient;
        private readonly DomainOwnershipIdentifierData _data;

        /// <summary> Initializes a new instance of the <see cref="DomainOwnershipIdentifier"/> class for mocking. </summary>
        protected DomainOwnershipIdentifier()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DomainOwnershipIdentifier"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DomainOwnershipIdentifier(ArmResource options, DomainOwnershipIdentifierData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _domainsRestClient = new DomainsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="DomainOwnershipIdentifier"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DomainOwnershipIdentifier(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _domainsRestClient = new DomainsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="DomainOwnershipIdentifier"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DomainOwnershipIdentifier(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _domainsRestClient = new DomainsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DomainOwnershipIdentifierData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_GetOwnershipIdentifier
        /// <summary> Description for Get ownership identifier for domain. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DomainOwnershipIdentifier>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DomainOwnershipIdentifier.Get");
            scope.Start();
            try
            {
                var response = await _domainsRestClient.GetOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DomainOwnershipIdentifier(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_GetOwnershipIdentifier
        /// <summary> Description for Get ownership identifier for domain. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DomainOwnershipIdentifier> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DomainOwnershipIdentifier.Get");
            scope.Start();
            try
            {
                var response = _domainsRestClient.GetOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainOwnershipIdentifier(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_DeleteOwnershipIdentifier
        /// <summary> Description for Delete ownership identifier for domain. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DomainDeleteOwnershipIdentifierOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DomainOwnershipIdentifier.Delete");
            scope.Start();
            try
            {
                var response = await _domainsRestClient.DeleteOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DomainDeleteOwnershipIdentifierOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_DeleteOwnershipIdentifier
        /// <summary> Description for Delete ownership identifier for domain. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DomainDeleteOwnershipIdentifierOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DomainOwnershipIdentifier.Delete");
            scope.Start();
            try
            {
                var response = _domainsRestClient.DeleteOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DomainDeleteOwnershipIdentifierOperation(response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_UpdateOwnershipIdentifier
        /// <summary> Description for Creates an ownership identifier for a domain or updates identifier details for an existing identifier. </summary>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public async virtual Task<Response<DomainOwnershipIdentifier>> UpdateAsync(DomainOwnershipIdentifierData domainOwnershipIdentifier, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifier == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifier));
            }

            using var scope = _clientDiagnostics.CreateScope("DomainOwnershipIdentifier.Update");
            scope.Start();
            try
            {
                var response = await _domainsRestClient.UpdateOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifier, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DomainOwnershipIdentifier(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_UpdateOwnershipIdentifier
        /// <summary> Description for Creates an ownership identifier for a domain or updates identifier details for an existing identifier. </summary>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public virtual Response<DomainOwnershipIdentifier> Update(DomainOwnershipIdentifierData domainOwnershipIdentifier, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifier == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifier));
            }

            using var scope = _clientDiagnostics.CreateScope("DomainOwnershipIdentifier.Update");
            scope.Start();
            try
            {
                var response = _domainsRestClient.UpdateOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifier, cancellationToken);
                return Response.FromValue(new DomainOwnershipIdentifier(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
