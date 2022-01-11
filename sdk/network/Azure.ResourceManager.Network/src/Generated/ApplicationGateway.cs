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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a ApplicationGateway along with the instance operations that can be performed on it. </summary>
    public partial class ApplicationGateway : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApplicationGateway"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string applicationGatewayName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ApplicationGatewaysRestOperations _applicationGatewaysRestClient;
        private readonly ApplicationGatewayPrivateLinkResourcesRestOperations _applicationGatewayPrivateLinkResourcesRestClient;
        private readonly ApplicationGatewayData _data;

        /// <summary> Initializes a new instance of the <see cref="ApplicationGateway"/> class for mocking. </summary>
        protected ApplicationGateway()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApplicationGateway"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ApplicationGateway(ArmResource options, ApplicationGatewayData resource) : base(options, new ResourceIdentifier(resource.Id))
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _applicationGatewaysRestClient = new ApplicationGatewaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _applicationGatewayPrivateLinkResourcesRestClient = new ApplicationGatewayPrivateLinkResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGateway"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApplicationGateway(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _applicationGatewaysRestClient = new ApplicationGatewaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _applicationGatewayPrivateLinkResourcesRestClient = new ApplicationGatewayPrivateLinkResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGateway"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApplicationGateway(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _applicationGatewaysRestClient = new ApplicationGatewaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _applicationGatewayPrivateLinkResourcesRestClient = new ApplicationGatewayPrivateLinkResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/applicationGateways";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApplicationGatewayData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ApplicationGateway>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.Get");
            scope.Start();
            try
            {
                var response = await _applicationGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ApplicationGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationGateway> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.Get");
            scope.Start();
            try
            {
                var response = _applicationGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGateway(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes the specified application gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ApplicationGatewayDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.Delete");
            scope.Start();
            try
            {
                var response = await _applicationGatewaysRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ApplicationGatewayDeleteOperation(_clientDiagnostics, Pipeline, _applicationGatewaysRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Deletes the specified application gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationGatewayDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.Delete");
            scope.Start();
            try
            {
                var response = _applicationGatewaysRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new ApplicationGatewayDeleteOperation(_clientDiagnostics, Pipeline, _applicationGatewaysRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Updates the specified application gateway tags. </summary>
        /// <param name="parameters"> Parameters supplied to update application gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<ApplicationGateway>> UpdateAsync(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.Update");
            scope.Start();
            try
            {
                var response = await _applicationGatewaysRestClient.UpdateTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ApplicationGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the specified application gateway tags. </summary>
        /// <param name="parameters"> Parameters supplied to update application gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<ApplicationGateway> Update(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.Update");
            scope.Start();
            try
            {
                var response = _applicationGatewaysRestClient.UpdateTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new ApplicationGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the specified application gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ApplicationGatewayStartOperation> StartAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.Start");
            scope.Start();
            try
            {
                var response = await _applicationGatewaysRestClient.StartAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ApplicationGatewayStartOperation(_clientDiagnostics, Pipeline, _applicationGatewaysRestClient.CreateStartRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Starts the specified application gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationGatewayStartOperation Start(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.Start");
            scope.Start();
            try
            {
                var response = _applicationGatewaysRestClient.Start(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new ApplicationGatewayStartOperation(_clientDiagnostics, Pipeline, _applicationGatewaysRestClient.CreateStartRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Stops the specified application gateway in a resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ApplicationGatewayStopOperation> StopAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.Stop");
            scope.Start();
            try
            {
                var response = await _applicationGatewaysRestClient.StopAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ApplicationGatewayStopOperation(_clientDiagnostics, Pipeline, _applicationGatewaysRestClient.CreateStopRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Stops the specified application gateway in a resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationGatewayStopOperation Stop(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.Stop");
            scope.Start();
            try
            {
                var response = _applicationGatewaysRestClient.Stop(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new ApplicationGatewayStopOperation(_clientDiagnostics, Pipeline, _applicationGatewaysRestClient.CreateStopRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Gets the backend health of the specified application gateway in a resource group. </summary>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ApplicationGatewayBackendHealthOperation> BackendHealthAsync(string expand = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.BackendHealth");
            scope.Start();
            try
            {
                var response = await _applicationGatewaysRestClient.BackendHealthAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                var operation = new ApplicationGatewayBackendHealthOperation(_clientDiagnostics, Pipeline, _applicationGatewaysRestClient.CreateBackendHealthRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand).Request, response);
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

        /// <summary> Gets the backend health of the specified application gateway in a resource group. </summary>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationGatewayBackendHealthOperation BackendHealth(string expand = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.BackendHealth");
            scope.Start();
            try
            {
                var response = _applicationGatewaysRestClient.BackendHealth(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                var operation = new ApplicationGatewayBackendHealthOperation(_clientDiagnostics, Pipeline, _applicationGatewaysRestClient.CreateBackendHealthRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand).Request, response);
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

        /// <summary> Gets the backend health for given combination of backend pool and http setting of the specified application gateway in a resource group. </summary>
        /// <param name="probeRequest"> Request body for on-demand test probe operation. </param>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="probeRequest"/> is null. </exception>
        public async virtual Task<ApplicationGatewayBackendHealthOnDemandOperation> BackendHealthOnDemandAsync(ApplicationGatewayOnDemandProbe probeRequest, string expand = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (probeRequest == null)
            {
                throw new ArgumentNullException(nameof(probeRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.BackendHealthOnDemand");
            scope.Start();
            try
            {
                var response = await _applicationGatewaysRestClient.BackendHealthOnDemandAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeRequest, expand, cancellationToken).ConfigureAwait(false);
                var operation = new ApplicationGatewayBackendHealthOnDemandOperation(_clientDiagnostics, Pipeline, _applicationGatewaysRestClient.CreateBackendHealthOnDemandRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeRequest, expand).Request, response);
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

        /// <summary> Gets the backend health for given combination of backend pool and http setting of the specified application gateway in a resource group. </summary>
        /// <param name="probeRequest"> Request body for on-demand test probe operation. </param>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="probeRequest"/> is null. </exception>
        public virtual ApplicationGatewayBackendHealthOnDemandOperation BackendHealthOnDemand(ApplicationGatewayOnDemandProbe probeRequest, string expand = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (probeRequest == null)
            {
                throw new ArgumentNullException(nameof(probeRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.BackendHealthOnDemand");
            scope.Start();
            try
            {
                var response = _applicationGatewaysRestClient.BackendHealthOnDemand(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeRequest, expand, cancellationToken);
                var operation = new ApplicationGatewayBackendHealthOnDemandOperation(_clientDiagnostics, Pipeline, _applicationGatewaysRestClient.CreateBackendHealthOnDemandRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeRequest, expand).Request, response);
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

        /// <summary> Lists all private link resources on an application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationGatewayPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationGatewayPrivateLinkResource> GetApplicationGatewayPrivateLinkResourcesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationGatewayPrivateLinkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.GetApplicationGatewayPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = await _applicationGatewayPrivateLinkResourcesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationGatewayPrivateLinkResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.GetApplicationGatewayPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = await _applicationGatewayPrivateLinkResourcesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all private link resources on an application gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationGatewayPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationGatewayPrivateLinkResource> GetApplicationGatewayPrivateLinkResources(CancellationToken cancellationToken = default)
        {
            Page<ApplicationGatewayPrivateLinkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.GetApplicationGatewayPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = _applicationGatewayPrivateLinkResourcesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationGatewayPrivateLinkResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGateway.GetApplicationGatewayPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = _applicationGatewayPrivateLinkResourcesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        #region ApplicationGatewayPrivateEndpointConnection

        /// <summary> Gets a collection of ApplicationGatewayPrivateEndpointConnections in the ApplicationGateway. </summary>
        /// <returns> An object representing collection of ApplicationGatewayPrivateEndpointConnections and their operations over a ApplicationGateway. </returns>
        public virtual ApplicationGatewayPrivateEndpointConnectionCollection GetApplicationGatewayPrivateEndpointConnections()
        {
            return new ApplicationGatewayPrivateEndpointConnectionCollection(this);
        }
        #endregion
    }
}
