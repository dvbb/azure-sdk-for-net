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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Quota.Models;

namespace Azure.ResourceManager.Quota
{
    /// <summary> A class representing collection of CurrentUsagesBase and their operations over its parent. </summary>
    public partial class CurrentUsagesBaseCollection : ArmCollection, IEnumerable<CurrentUsagesBase>, IAsyncEnumerable<CurrentUsagesBase>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly UsagesRestOperations _usagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CurrentUsagesBaseCollection"/> class for mocking. </summary>
        protected CurrentUsagesBaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CurrentUsagesBaseCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CurrentUsagesBaseCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(CurrentUsagesBase.ResourceType, out string apiVersion);
            _usagesRestClient = new UsagesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
        }

        // Collection level operations.

        /// <summary> Get the current usage of a resource. </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<CurrentUsagesBase> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CurrentUsagesBaseCollection.Get");
            scope.Start();
            try
            {
                var response = _usagesRestClient.Get(Id, resourceName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentUsagesBase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the current usage of a resource. </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public async virtual Task<Response<CurrentUsagesBase>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CurrentUsagesBaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _usagesRestClient.GetAsync(Id, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CurrentUsagesBase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<CurrentUsagesBase> GetIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CurrentUsagesBaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _usagesRestClient.Get(Id, resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CurrentUsagesBase>(null, response.GetRawResponse());
                return Response.FromValue(new CurrentUsagesBase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public async virtual Task<Response<CurrentUsagesBase>> GetIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CurrentUsagesBaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _usagesRestClient.GetAsync(Id, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CurrentUsagesBase>(null, response.GetRawResponse());
                return Response.FromValue(new CurrentUsagesBase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CurrentUsagesBaseCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CurrentUsagesBaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a list of current usage for all resources for the scope specified. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CurrentUsagesBase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CurrentUsagesBase> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CurrentUsagesBase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CurrentUsagesBaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _usagesRestClient.List(Id, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CurrentUsagesBase(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CurrentUsagesBase> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CurrentUsagesBaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _usagesRestClient.ListNextPage(nextLink, Id, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CurrentUsagesBase(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get a list of current usage for all resources for the scope specified. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CurrentUsagesBase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CurrentUsagesBase> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CurrentUsagesBase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CurrentUsagesBaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _usagesRestClient.ListAsync(Id, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CurrentUsagesBase(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CurrentUsagesBase>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CurrentUsagesBaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _usagesRestClient.ListNextPageAsync(nextLink, Id, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CurrentUsagesBase(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<CurrentUsagesBase> IEnumerable<CurrentUsagesBase>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CurrentUsagesBase> IAsyncEnumerable<CurrentUsagesBase>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CurrentUsagesBase, CurrentUsagesBaseData> Construct() { }
    }
}
