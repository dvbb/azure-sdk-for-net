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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of SqlTimeZone and their operations over its parent. </summary>
    public partial class SqlTimeZoneCollection : ArmCollection, IEnumerable<SqlTimeZone>, IAsyncEnumerable<SqlTimeZone>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly TimeZonesRestOperations _timeZonesRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="SqlTimeZoneCollection"/> class for mocking. </summary>
        protected SqlTimeZoneCollection()
        {
        }

        /// <summary> Initializes a new instance of SqlTimeZoneCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="locationName"> The String to use. </param>
        internal SqlTimeZoneCollection(ArmResource parent, string locationName) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _timeZonesRestClient = new TimeZonesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _locationName = locationName;
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Subscription.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_Get
        /// <summary> Gets a managed instance time zone. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public virtual Response<SqlTimeZone> Get(string timeZoneId, CancellationToken cancellationToken = default)
        {
            if (timeZoneId == null)
            {
                throw new ArgumentNullException(nameof(timeZoneId));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.Get");
            scope.Start();
            try
            {
                var response = _timeZonesRestClient.Get(Id.SubscriptionId, _locationName, timeZoneId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlTimeZone(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_Get
        /// <summary> Gets a managed instance time zone. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public async virtual Task<Response<SqlTimeZone>> GetAsync(string timeZoneId, CancellationToken cancellationToken = default)
        {
            if (timeZoneId == null)
            {
                throw new ArgumentNullException(nameof(timeZoneId));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.Get");
            scope.Start();
            try
            {
                var response = await _timeZonesRestClient.GetAsync(Id.SubscriptionId, _locationName, timeZoneId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlTimeZone(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public virtual Response<SqlTimeZone> GetIfExists(string timeZoneId, CancellationToken cancellationToken = default)
        {
            if (timeZoneId == null)
            {
                throw new ArgumentNullException(nameof(timeZoneId));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _timeZonesRestClient.Get(Id.SubscriptionId, _locationName, timeZoneId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SqlTimeZone>(null, response.GetRawResponse())
                    : Response.FromValue(new SqlTimeZone(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public async virtual Task<Response<SqlTimeZone>> GetIfExistsAsync(string timeZoneId, CancellationToken cancellationToken = default)
        {
            if (timeZoneId == null)
            {
                throw new ArgumentNullException(nameof(timeZoneId));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _timeZonesRestClient.GetAsync(Id.SubscriptionId, _locationName, timeZoneId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SqlTimeZone>(null, response.GetRawResponse())
                    : Response.FromValue(new SqlTimeZone(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public virtual Response<bool> Exists(string timeZoneId, CancellationToken cancellationToken = default)
        {
            if (timeZoneId == null)
            {
                throw new ArgumentNullException(nameof(timeZoneId));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(timeZoneId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string timeZoneId, CancellationToken cancellationToken = default)
        {
            if (timeZoneId == null)
            {
                throw new ArgumentNullException(nameof(timeZoneId));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(timeZoneId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_ListByLocation
        /// <summary> Gets a list of managed instance time zones by location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlTimeZone" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlTimeZone> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlTimeZone> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _timeZonesRestClient.ListByLocation(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlTimeZone(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlTimeZone> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _timeZonesRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlTimeZone(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_ListByLocation
        /// <summary> Gets a list of managed instance time zones by location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlTimeZone" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlTimeZone> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlTimeZone>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _timeZonesRestClient.ListByLocationAsync(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlTimeZone(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlTimeZone>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _timeZonesRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlTimeZone(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SqlTimeZone" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SqlTimeZone.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SqlTimeZone" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlTimeZoneCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SqlTimeZone.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlTimeZone> IEnumerable<SqlTimeZone>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlTimeZone> IAsyncEnumerable<SqlTimeZone>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SqlTimeZone, SqlTimeZoneData> Construct() { }
    }
}
