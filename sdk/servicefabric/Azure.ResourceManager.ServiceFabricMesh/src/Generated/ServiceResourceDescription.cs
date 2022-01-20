// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ServiceFabricMesh.Models;

namespace Azure.ResourceManager.ServiceFabricMesh
{
    /// <summary> A Class representing a ServiceResourceDescription along with the instance operations that can be performed on it. </summary>
    public partial class ServiceResourceDescription : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceResourceDescription"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabricMesh/applications/{applicationResourceName}/services/{serviceResourceName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServiceRestOperations _serviceRestClient;
        private readonly ServiceReplicaRestOperations _serviceReplicaRestClient;
        private readonly CodePackageRestOperations _codePackageRestClient;
        private readonly ServiceResourceDescriptionData _data;

        /// <summary> Initializes a new instance of the <see cref="ServiceResourceDescription"/> class for mocking. </summary>
        protected ServiceResourceDescription()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServiceResourceDescription"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceResourceDescription(ArmResource options, ServiceResourceDescriptionData data) : base(options, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _serviceRestClient = new ServiceRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _serviceReplicaRestClient = new ServiceReplicaRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _codePackageRestClient = new CodePackageRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceResourceDescription"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceResourceDescription(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _serviceRestClient = new ServiceRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _serviceReplicaRestClient = new ServiceReplicaRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _codePackageRestClient = new CodePackageRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceResourceDescription"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceResourceDescription(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _serviceRestClient = new ServiceRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _serviceReplicaRestClient = new ServiceReplicaRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _codePackageRestClient = new CodePackageRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceFabricMesh/applications/services";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceResourceDescriptionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets the information about the service resource with the given name. The information include the description and other properties of the service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServiceResourceDescription>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.Get");
            scope.Start();
            try
            {
                var response = await _serviceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServiceResourceDescription(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the information about the service resource with the given name. The information include the description and other properties of the service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceResourceDescription> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.Get");
            scope.Start();
            try
            {
                var response = _serviceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceResourceDescription(this, response.Value), response.GetRawResponse());
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
            using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
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
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the information about the service replica with the given name. The information include the description and other properties of the service replica. </summary>
        /// <param name="replicaName"> Service Fabric replica name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public async virtual Task<Response<ServiceReplicaDescription>> GetServiceReplicaAsync(string replicaName, CancellationToken cancellationToken = default)
        {
            if (replicaName == null)
            {
                throw new ArgumentNullException(nameof(replicaName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.GetServiceReplica");
            scope.Start();
            try
            {
                var response = await _serviceReplicaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, replicaName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the information about the service replica with the given name. The information include the description and other properties of the service replica. </summary>
        /// <param name="replicaName"> Service Fabric replica name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual Response<ServiceReplicaDescription> GetServiceReplica(string replicaName, CancellationToken cancellationToken = default)
        {
            if (replicaName == null)
            {
                throw new ArgumentNullException(nameof(replicaName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.GetServiceReplica");
            scope.Start();
            try
            {
                var response = _serviceReplicaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, replicaName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the information about all replicas of a given service of an application. The information includes the runtime properties of the replica instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceReplicaDescription" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceReplicaDescription> GetServiceReplicasAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceReplicaDescription>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.GetServiceReplicas");
                scope.Start();
                try
                {
                    var response = await _serviceReplicaRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceReplicaDescription>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.GetServiceReplicas");
                scope.Start();
                try
                {
                    var response = await _serviceReplicaRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets the information about all replicas of a given service of an application. The information includes the runtime properties of the replica instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceReplicaDescription" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceReplicaDescription> GetServiceReplicas(CancellationToken cancellationToken = default)
        {
            Page<ServiceReplicaDescription> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.GetServiceReplicas");
                scope.Start();
                try
                {
                    var response = _serviceReplicaRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceReplicaDescription> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.GetServiceReplicas");
                scope.Start();
                try
                {
                    var response = _serviceReplicaRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
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

        /// <summary> Gets the logs for the container of the specified code package of the service replica. </summary>
        /// <param name="replicaName"> Service Fabric replica name. </param>
        /// <param name="codePackageName"> The name of code package of the service. </param>
        /// <param name="tail"> Number of lines to show from the end of the logs. Default is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> or <paramref name="codePackageName"/> is null. </exception>
        public async virtual Task<Response<ContainerLogs>> GetContainerLogsCodePackageAsync(string replicaName, string codePackageName, int? tail = null, CancellationToken cancellationToken = default)
        {
            if (replicaName == null)
            {
                throw new ArgumentNullException(nameof(replicaName));
            }
            if (codePackageName == null)
            {
                throw new ArgumentNullException(nameof(codePackageName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.GetContainerLogsCodePackage");
            scope.Start();
            try
            {
                var response = await _codePackageRestClient.GetContainerLogsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, replicaName, codePackageName, tail, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the logs for the container of the specified code package of the service replica. </summary>
        /// <param name="replicaName"> Service Fabric replica name. </param>
        /// <param name="codePackageName"> The name of code package of the service. </param>
        /// <param name="tail"> Number of lines to show from the end of the logs. Default is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> or <paramref name="codePackageName"/> is null. </exception>
        public virtual Response<ContainerLogs> GetContainerLogsCodePackage(string replicaName, string codePackageName, int? tail = null, CancellationToken cancellationToken = default)
        {
            if (replicaName == null)
            {
                throw new ArgumentNullException(nameof(replicaName));
            }
            if (codePackageName == null)
            {
                throw new ArgumentNullException(nameof(codePackageName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceResourceDescription.GetContainerLogsCodePackage");
            scope.Start();
            try
            {
                var response = _codePackageRestClient.GetContainerLogs(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, replicaName, codePackageName, tail, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
