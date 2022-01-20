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
using Azure.ResourceManager.HybridDataManager.Models;

namespace Azure.ResourceManager.HybridDataManager
{
    /// <summary> A Class representing a DataManager along with the instance operations that can be performed on it. </summary>
    public partial class DataManager : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataManager"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string dataManagerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers/{dataManagerName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DataManagersRestOperations _dataManagersRestClient;
        private readonly JobDefinitionsRestOperations _jobDefinitionsRestClient;
        private readonly JobsRestOperations _jobsRestClient;
        private readonly DataManagerData _data;

        /// <summary> Initializes a new instance of the <see cref="DataManager"/> class for mocking. </summary>
        protected DataManager()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataManager"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataManager(ArmResource options, DataManagerData data) : base(options, data.Id)
        {
            HasData = true;
            _data = data;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _dataManagersRestClient = new DataManagersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _jobDefinitionsRestClient = new JobDefinitionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _jobsRestClient = new JobsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="DataManager"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataManager(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _dataManagersRestClient = new DataManagersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _jobDefinitionsRestClient = new JobDefinitionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _jobsRestClient = new JobsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="DataManager"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataManager(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _dataManagersRestClient = new DataManagersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _jobDefinitionsRestClient = new JobDefinitionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _jobsRestClient = new JobsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HybridData/dataManagers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataManagerData Data
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

        /// <summary> Gets information about the specified data manager resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DataManager>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataManager.Get");
            scope.Start();
            try
            {
                var response = await _dataManagersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DataManager(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified data manager resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataManager> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataManager.Get");
            scope.Start();
            try
            {
                var response = _dataManagersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataManager(this, response.Value), response.GetRawResponse());
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
            using var scope = _clientDiagnostics.CreateScope("DataManager.GetAvailableLocations");
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
            using var scope = _clientDiagnostics.CreateScope("DataManager.GetAvailableLocations");
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

        /// <summary> Deletes a data manager resource in Microsoft Azure. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DataManagerDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataManager.Delete");
            scope.Start();
            try
            {
                var response = await _dataManagersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataManagerDeleteOperation(_clientDiagnostics, Pipeline, _dataManagersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Deletes a data manager resource in Microsoft Azure. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DataManagerDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataManager.Delete");
            scope.Start();
            try
            {
                var response = _dataManagersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new DataManagerDeleteOperation(_clientDiagnostics, Pipeline, _dataManagersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the properties of an existing data manager resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="dataManagerUpdateParameter"> Data manager resource details from request body. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The patch will be performed only if the ETag of the data manager resource on the server matches this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataManagerUpdateParameter"/> is null. </exception>
        public async virtual Task<DataManagerUpdateOperation> UpdateAsync(bool waitForCompletion, DataManagerUpdateParameter dataManagerUpdateParameter, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (dataManagerUpdateParameter == null)
            {
                throw new ArgumentNullException(nameof(dataManagerUpdateParameter));
            }

            using var scope = _clientDiagnostics.CreateScope("DataManager.Update");
            scope.Start();
            try
            {
                var response = await _dataManagersRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataManagerUpdateParameter, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataManagerUpdateOperation(this, _clientDiagnostics, Pipeline, _dataManagersRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataManagerUpdateParameter, ifMatch).Request, response);
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

        /// <summary> Updates the properties of an existing data manager resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="dataManagerUpdateParameter"> Data manager resource details from request body. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The patch will be performed only if the ETag of the data manager resource on the server matches this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataManagerUpdateParameter"/> is null. </exception>
        public virtual DataManagerUpdateOperation Update(bool waitForCompletion, DataManagerUpdateParameter dataManagerUpdateParameter, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (dataManagerUpdateParameter == null)
            {
                throw new ArgumentNullException(nameof(dataManagerUpdateParameter));
            }

            using var scope = _clientDiagnostics.CreateScope("DataManager.Update");
            scope.Start();
            try
            {
                var response = _dataManagersRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataManagerUpdateParameter, ifMatch, cancellationToken);
                var operation = new DataManagerUpdateOperation(this, _clientDiagnostics, Pipeline, _dataManagersRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataManagerUpdateParameter, ifMatch).Request, response);
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

        /// <summary> This method gets all the job definitions of the given data manager resource. </summary>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobDefinitionData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobDefinitionData> GetJobDefinitionsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<JobDefinitionData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataManager.GetJobDefinitions");
                scope.Start();
                try
                {
                    var response = await _jobDefinitionsRestClient.ListByDataManagerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobDefinitionData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataManager.GetJobDefinitions");
                scope.Start();
                try
                {
                    var response = await _jobDefinitionsRestClient.ListByDataManagerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// <summary> This method gets all the job definitions of the given data manager resource. </summary>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobDefinitionData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobDefinitionData> GetJobDefinitions(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<JobDefinitionData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataManager.GetJobDefinitions");
                scope.Start();
                try
                {
                    var response = _jobDefinitionsRestClient.ListByDataManager(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobDefinitionData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataManager.GetJobDefinitions");
                scope.Start();
                try
                {
                    var response = _jobDefinitionsRestClient.ListByDataManagerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
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

        /// <summary> This method gets all the jobs at the data manager resource level. </summary>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobData> GetJobsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<JobData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataManager.GetJobs");
                scope.Start();
                try
                {
                    var response = await _jobsRestClient.ListByDataManagerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataManager.GetJobs");
                scope.Start();
                try
                {
                    var response = await _jobsRestClient.ListByDataManagerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// <summary> This method gets all the jobs at the data manager resource level. </summary>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobData> GetJobs(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<JobData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataManager.GetJobs");
                scope.Start();
                try
                {
                    var response = _jobsRestClient.ListByDataManager(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataManager.GetJobs");
                scope.Start();
                try
                {
                    var response = _jobsRestClient.ListByDataManagerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
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

        #region DataService

        /// <summary> Gets a collection of DataServices in the DataManager. </summary>
        /// <returns> An object representing collection of DataServices and their operations over a DataManager. </returns>
        public virtual DataServiceCollection GetDataServices()
        {
            return new DataServiceCollection(this);
        }
        #endregion

        #region DataStore

        /// <summary> Gets a collection of DataStores in the DataManager. </summary>
        /// <returns> An object representing collection of DataStores and their operations over a DataManager. </returns>
        public virtual DataStoreCollection GetDataStores()
        {
            return new DataStoreCollection(this);
        }
        #endregion

        #region DataStoreType

        /// <summary> Gets a collection of DataStoreTypes in the DataManager. </summary>
        /// <returns> An object representing collection of DataStoreTypes and their operations over a DataManager. </returns>
        public virtual DataStoreTypeCollection GetDataStoreTypes()
        {
            return new DataStoreTypeCollection(this);
        }
        #endregion

        #region PublicKey

        /// <summary> Gets a collection of PublicKeys in the DataManager. </summary>
        /// <returns> An object representing collection of PublicKeys and their operations over a DataManager. </returns>
        public virtual PublicKeyCollection GetPublicKeys()
        {
            return new PublicKeyCollection(this);
        }
        #endregion
    }
}
