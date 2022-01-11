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
    /// <summary> A Class representing a HostingEnvironmentMultiRolePool along with the instance operations that can be performed on it. </summary>
    public partial class HostingEnvironmentMultiRolePool : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HostingEnvironmentMultiRolePool"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _appServiceEnvironmentsRestClient;
        private readonly WorkerPoolResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentMultiRolePool"/> class for mocking. </summary>
        protected HostingEnvironmentMultiRolePool()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HostingEnvironmentMultiRolePool"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal HostingEnvironmentMultiRolePool(ArmResource options, WorkerPoolResourceData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentMultiRolePool"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HostingEnvironmentMultiRolePool(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentMultiRolePool"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HostingEnvironmentMultiRolePool(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/hostingEnvironments/multiRolePools";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

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

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_GetMultiRolePool
        /// <summary> Description for Get properties of a multi-role pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<HostingEnvironmentMultiRolePool>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.Get");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.GetMultiRolePoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentMultiRolePool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_GetMultiRolePool
        /// <summary> Description for Get properties of a multi-role pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HostingEnvironmentMultiRolePool> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.Get");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.GetMultiRolePool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentMultiRolePool(this, response.Value), response.GetRawResponse());
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_CreateOrUpdateMultiRolePool
        /// <summary> Description for Create or update a multi-role pool. </summary>
        /// <param name="multiRolePoolEnvelope"> Properties of the multi-role pool. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multiRolePoolEnvelope"/> is null. </exception>
        public async virtual Task<AppServiceEnvironmentCreateOrUpdateMultiRolePoolOperation> CreateOrUpdateAsync(WorkerPoolResourceData multiRolePoolEnvelope, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (multiRolePoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(multiRolePoolEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.CreateOrUpdateMultiRolePoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceEnvironmentCreateOrUpdateMultiRolePoolOperation(this, _clientDiagnostics, Pipeline, _appServiceEnvironmentsRestClient.CreateCreateOrUpdateMultiRolePoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_CreateOrUpdateMultiRolePool
        /// <summary> Description for Create or update a multi-role pool. </summary>
        /// <param name="multiRolePoolEnvelope"> Properties of the multi-role pool. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multiRolePoolEnvelope"/> is null. </exception>
        public virtual AppServiceEnvironmentCreateOrUpdateMultiRolePoolOperation CreateOrUpdate(WorkerPoolResourceData multiRolePoolEnvelope, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (multiRolePoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(multiRolePoolEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.CreateOrUpdateMultiRolePool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope, cancellationToken);
                var operation = new AppServiceEnvironmentCreateOrUpdateMultiRolePoolOperation(this, _clientDiagnostics, Pipeline, _appServiceEnvironmentsRestClient.CreateCreateOrUpdateMultiRolePoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_UpdateMultiRolePool
        /// <summary> Description for Create or update a multi-role pool. </summary>
        /// <param name="multiRolePoolEnvelope"> Properties of the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multiRolePoolEnvelope"/> is null. </exception>
        public async virtual Task<Response<HostingEnvironmentMultiRolePool>> UpdateAsync(WorkerPoolResourceData multiRolePoolEnvelope, CancellationToken cancellationToken = default)
        {
            if (multiRolePoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(multiRolePoolEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.Update");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.UpdateMultiRolePoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentMultiRolePool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_UpdateMultiRolePool
        /// <summary> Description for Create or update a multi-role pool. </summary>
        /// <param name="multiRolePoolEnvelope"> Properties of the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multiRolePoolEnvelope"/> is null. </exception>
        public virtual Response<HostingEnvironmentMultiRolePool> Update(WorkerPoolResourceData multiRolePoolEnvelope, CancellationToken cancellationToken = default)
        {
            if (multiRolePoolEnvelope == null)
            {
                throw new ArgumentNullException(nameof(multiRolePoolEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.Update");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.UpdateMultiRolePool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, multiRolePoolEnvelope, cancellationToken);
                return Response.FromValue(new HostingEnvironmentMultiRolePool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/instances/{instance}/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRolePoolInstanceMetricDefinitions
        /// <summary> Description for Get metric definitions for a specific instance of a multi-role pool of an App Service Environment. </summary>
        /// <param name="instance"> Name of the instance in the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceMetricDefinition> GetMultiRolePoolInstanceMetricDefinitionsAsync(string instance, CancellationToken cancellationToken = default)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            async Task<Page<ResourceMetricDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListMultiRolePoolInstanceMetricDefinitionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance, cancellationToken: cancellationToken).ConfigureAwait(false);
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
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListMultiRolePoolInstanceMetricDefinitionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/instances/{instance}/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRolePoolInstanceMetricDefinitions
        /// <summary> Description for Get metric definitions for a specific instance of a multi-role pool of an App Service Environment. </summary>
        /// <param name="instance"> Name of the instance in the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceMetricDefinition> GetMultiRolePoolInstanceMetricDefinitions(string instance, CancellationToken cancellationToken = default)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            Page<ResourceMetricDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListMultiRolePoolInstanceMetricDefinitions(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance, cancellationToken: cancellationToken);
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
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolInstanceMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListMultiRolePoolInstanceMetricDefinitionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance, cancellationToken: cancellationToken);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRoleMetricDefinitions
        /// <summary> Description for Get metric definitions for a multi-role pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceMetricDefinition> GetMultiRoleMetricDefinitionsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceMetricDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListMultiRoleMetricDefinitionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleMetricDefinitions");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListMultiRoleMetricDefinitionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/metricdefinitions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRoleMetricDefinitions
        /// <summary> Description for Get metric definitions for a multi-role pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceMetricDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceMetricDefinition> GetMultiRoleMetricDefinitions(CancellationToken cancellationToken = default)
        {
            Page<ResourceMetricDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListMultiRoleMetricDefinitions(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
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
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleMetricDefinitions");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListMultiRoleMetricDefinitionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/skus
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRolePoolSkus
        /// <summary> Description for Get available SKUs for scaling a multi-role pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SkuInfo> GetMultiRolePoolSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SkuInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolSkus");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListMultiRolePoolSkusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolSkus");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListMultiRolePoolSkusNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/skus
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRolePoolSkus
        /// <summary> Description for Get available SKUs for scaling a multi-role pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SkuInfo> GetMultiRolePoolSkus(CancellationToken cancellationToken = default)
        {
            Page<SkuInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolSkus");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListMultiRolePoolSkus(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
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
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRolePoolSkus");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListMultiRolePoolSkusNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/usages
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRoleUsages
        /// <summary> Description for Get usage metrics for a multi-role pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Usage> GetMultiRoleUsagesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Usage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleUsages");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListMultiRoleUsagesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleUsages");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListMultiRoleUsagesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/usages
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default
        /// OperationId: AppServiceEnvironments_ListMultiRoleUsages
        /// <summary> Description for Get usage metrics for a multi-role pool of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Usage> GetMultiRoleUsages(CancellationToken cancellationToken = default)
        {
            Page<Usage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleUsages");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListMultiRoleUsages(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
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
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentMultiRolePool.GetMultiRoleUsages");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListMultiRoleUsagesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
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
