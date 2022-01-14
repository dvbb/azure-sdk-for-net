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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a HostingEnvironmentWorkerPool along with the instance operations that can be performed on it. </summary>
    public partial class HostingEnvironmentWorkerPool : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HostingEnvironmentWorkerPool"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string workerPoolName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _appServiceEnvironmentsRestClient;
        private readonly WorkerPoolResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentWorkerPool"/> class for mocking. </summary>
        protected HostingEnvironmentWorkerPool()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HostingEnvironmentWorkerPool"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal HostingEnvironmentWorkerPool(ArmResource options, WorkerPoolResourceData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentWorkerPool"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HostingEnvironmentWorkerPool(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentWorkerPool"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HostingEnvironmentWorkerPool(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/hostingEnvironments/workerPools";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WorkerPoolResourceData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_GetWorkerPool
        /// <summary> Description for Get properties of a worker pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<HostingEnvironmentWorkerPool>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.Get");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.GetWorkerPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentWorkerPool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_GetWorkerPool
        /// <summary> Description for Get properties of a worker pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HostingEnvironmentWorkerPool> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.Get");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.GetWorkerPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentWorkerPool(this, response.Value), response.GetRawResponse());
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_UpdateWorkerPool
        /// <summary> Description for Create or update a worker pool. </summary>
        /// <param name="workerPoolEnvelope"> Properties of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolEnvelope"/> is null. </exception>
        public async virtual Task<Response<HostingEnvironmentWorkerPool>> UpdateAsync(WorkerPoolResourceData workerPoolEnvelope, CancellationToken cancellationToken = default)
        {
            if (workerPoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(workerPoolEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.Update");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.UpdateWorkerPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workerPoolEnvelope, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentWorkerPool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_UpdateWorkerPool
        /// <summary> Description for Create or update a worker pool. </summary>
        /// <param name="workerPoolEnvelope"> Properties of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolEnvelope"/> is null. </exception>
        public virtual Response<HostingEnvironmentWorkerPool> Update(WorkerPoolResourceData workerPoolEnvelope, CancellationToken cancellationToken = default)
        {
            if (workerPoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(workerPoolEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.Update");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.UpdateWorkerPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workerPoolEnvelope, cancellationToken);
                return Response.FromValue(new HostingEnvironmentWorkerPool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/instances/{instance}/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_ListWorkerPoolInstanceMetricDefinitions
        /// <summary> Description for Get metric definitions for a specific instance of a worker pool of an App Service Environment. </summary>
        /// <param name="instance"> Name of the instance in the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceMetricDefinition> GetWorkerPoolInstanceMetricDefinitionsAsync(string instance, CancellationToken cancellationToken = default)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            async Task<Page<ResourceMetricDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWorkerPoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListWorkerPoolInstanceMetricDefinitionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, instance, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceMetricDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWorkerPoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListWorkerPoolInstanceMetricDefinitionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, instance, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/instances/{instance}/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_ListWorkerPoolInstanceMetricDefinitions
        /// <summary> Description for Get metric definitions for a specific instance of a worker pool of an App Service Environment. </summary>
        /// <param name="instance"> Name of the instance in the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceMetricDefinition> GetWorkerPoolInstanceMetricDefinitions(string instance, CancellationToken cancellationToken = default)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            Page<ResourceMetricDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWorkerPoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListWorkerPoolInstanceMetricDefinitions(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, instance, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceMetricDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWorkerPoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListWorkerPoolInstanceMetricDefinitionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, instance, cancellationToken: cancellationToken);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_ListWebWorkerMetricDefinitions
        /// <summary> Description for Get metric definitions for a worker pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceMetricDefinition> GetWebWorkerMetricDefinitionsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceMetricDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWebWorkerMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListWebWorkerMetricDefinitionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceMetricDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWebWorkerMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListWebWorkerMetricDefinitionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_ListWebWorkerMetricDefinitions
        /// <summary> Description for Get metric definitions for a worker pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceMetricDefinition> GetWebWorkerMetricDefinitions(CancellationToken cancellationToken = default)
        {
            Page<ResourceMetricDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWebWorkerMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListWebWorkerMetricDefinitions(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceMetricDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWebWorkerMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListWebWorkerMetricDefinitionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/skus
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_ListWorkerPoolSkus
        /// <summary> Description for Get available SKUs for scaling a worker pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SkuInfo> GetWorkerPoolSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SkuInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWorkerPoolSkus");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListWorkerPoolSkusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SkuInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWorkerPoolSkus");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListWorkerPoolSkusNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/skus
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_ListWorkerPoolSkus
        /// <summary> Description for Get available SKUs for scaling a worker pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SkuInfo> GetWorkerPoolSkus(CancellationToken cancellationToken = default)
        {
            Page<SkuInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWorkerPoolSkus");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListWorkerPoolSkus(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SkuInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWorkerPoolSkus");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListWorkerPoolSkusNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/usages
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_ListWebWorkerUsages
        /// <summary> Description for Get usage metrics for a worker pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Usage> GetWebWorkerUsagesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Usage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWebWorkerUsages");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListWebWorkerUsagesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Usage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWebWorkerUsages");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListWebWorkerUsagesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}/usages
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}
        /// OperationId: AppServiceEnvironments_ListWebWorkerUsages
        /// <summary> Description for Get usage metrics for a worker pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Usage> GetWebWorkerUsages(CancellationToken cancellationToken = default)
        {
            Page<Usage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWebWorkerUsages");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListWebWorkerUsages(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Usage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentWorkerPool.GetWebWorkerUsages");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListWebWorkerUsagesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
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
    }
}
