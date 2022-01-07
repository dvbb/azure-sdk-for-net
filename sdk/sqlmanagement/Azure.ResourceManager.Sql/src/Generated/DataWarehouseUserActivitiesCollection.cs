// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of DataWarehouseUserActivities and their operations over its parent. </summary>
    public partial class DataWarehouseUserActivitiesCollection : ArmCollection, IEnumerable<DataWarehouseUserActivities>, IAsyncEnumerable<DataWarehouseUserActivities>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DataWarehouseUserActivitiesRestOperations _dataWarehouseUserActivitiesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataWarehouseUserActivitiesCollection"/> class for mocking. </summary>
        protected DataWarehouseUserActivitiesCollection()
        {
        }

        /// <summary> Initializes a new instance of DataWarehouseUserActivitiesCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DataWarehouseUserActivitiesCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _dataWarehouseUserActivitiesRestClient = new DataWarehouseUserActivitiesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SqlDatabase.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DataWarehouseUserActivities_Get
        /// <summary> Gets the user activities of a data warehouse which includes running and suspended queries. </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataWarehouseUserActivities> Get(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataWarehouseUserActivitiesCollection.Get");
            scope.Start();
            try
            {
                var response = _dataWarehouseUserActivitiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataWarehouseUserActivityName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataWarehouseUserActivities(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DataWarehouseUserActivities_Get
        /// <summary> Gets the user activities of a data warehouse which includes running and suspended queries. </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DataWarehouseUserActivities>> GetAsync(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataWarehouseUserActivitiesCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataWarehouseUserActivitiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataWarehouseUserActivityName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DataWarehouseUserActivities(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataWarehouseUserActivities> GetIfExists(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataWarehouseUserActivitiesCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataWarehouseUserActivitiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataWarehouseUserActivityName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DataWarehouseUserActivities>(null, response.GetRawResponse())
                    : Response.FromValue(new DataWarehouseUserActivities(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DataWarehouseUserActivities>> GetIfExistsAsync(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataWarehouseUserActivitiesCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _dataWarehouseUserActivitiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataWarehouseUserActivityName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DataWarehouseUserActivities>(null, response.GetRawResponse())
                    : Response.FromValue(new DataWarehouseUserActivities(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataWarehouseUserActivitiesCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(dataWarehouseUserActivityName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataWarehouseUserActivitiesCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(dataWarehouseUserActivityName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DataWarehouseUserActivities_ListByDatabase
        /// <summary> List the user activities of a data warehouse which includes running and suspended queries. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataWarehouseUserActivities" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataWarehouseUserActivities> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DataWarehouseUserActivities> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataWarehouseUserActivitiesCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataWarehouseUserActivitiesRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataWarehouseUserActivities(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataWarehouseUserActivities> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataWarehouseUserActivitiesCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataWarehouseUserActivitiesRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataWarehouseUserActivities(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DataWarehouseUserActivities_ListByDatabase
        /// <summary> List the user activities of a data warehouse which includes running and suspended queries. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataWarehouseUserActivities" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataWarehouseUserActivities> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataWarehouseUserActivities>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataWarehouseUserActivitiesCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataWarehouseUserActivitiesRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataWarehouseUserActivities(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataWarehouseUserActivities>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataWarehouseUserActivitiesCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataWarehouseUserActivitiesRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataWarehouseUserActivities(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<DataWarehouseUserActivities> IEnumerable<DataWarehouseUserActivities>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataWarehouseUserActivities> IAsyncEnumerable<DataWarehouseUserActivities>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, DataWarehouseUserActivities, DataWarehouseUserActivitiesData> Construct() { }
    }
}
