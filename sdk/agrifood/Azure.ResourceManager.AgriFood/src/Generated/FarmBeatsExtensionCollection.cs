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
using Azure.ResourceManager.AgriFood.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AgriFood
{
    /// <summary> A class representing collection of FarmBeatsExtension and their operations over its parent. </summary>
    public partial class FarmBeatsExtensionCollection : ArmCollection, IEnumerable<FarmBeatsExtension>, IAsyncEnumerable<FarmBeatsExtension>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FarmBeatsExtensionsRestOperations _farmBeatsExtensionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FarmBeatsExtensionCollection"/> class for mocking. </summary>
        protected FarmBeatsExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FarmBeatsExtensionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FarmBeatsExtensionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(FarmBeatsExtension.ResourceType, out string apiVersion);
            _farmBeatsExtensionsRestClient = new FarmBeatsExtensionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Tenant.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Tenant.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Get farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        public virtual Response<FarmBeatsExtension> Get(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            if (farmBeatsExtensionId == null)
            {
                throw new ArgumentNullException(nameof(farmBeatsExtensionId));
            }

            using var scope = _clientDiagnostics.CreateScope("FarmBeatsExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _farmBeatsExtensionsRestClient.Get(farmBeatsExtensionId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FarmBeatsExtension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        public async virtual Task<Response<FarmBeatsExtension>> GetAsync(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            if (farmBeatsExtensionId == null)
            {
                throw new ArgumentNullException(nameof(farmBeatsExtensionId));
            }

            using var scope = _clientDiagnostics.CreateScope("FarmBeatsExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _farmBeatsExtensionsRestClient.GetAsync(farmBeatsExtensionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FarmBeatsExtension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        public virtual Response<FarmBeatsExtension> GetIfExists(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            if (farmBeatsExtensionId == null)
            {
                throw new ArgumentNullException(nameof(farmBeatsExtensionId));
            }

            using var scope = _clientDiagnostics.CreateScope("FarmBeatsExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _farmBeatsExtensionsRestClient.Get(farmBeatsExtensionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FarmBeatsExtension>(null, response.GetRawResponse());
                return Response.FromValue(new FarmBeatsExtension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        public async virtual Task<Response<FarmBeatsExtension>> GetIfExistsAsync(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            if (farmBeatsExtensionId == null)
            {
                throw new ArgumentNullException(nameof(farmBeatsExtensionId));
            }

            using var scope = _clientDiagnostics.CreateScope("FarmBeatsExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _farmBeatsExtensionsRestClient.GetAsync(farmBeatsExtensionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FarmBeatsExtension>(null, response.GetRawResponse());
                return Response.FromValue(new FarmBeatsExtension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        public virtual Response<bool> Exists(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            if (farmBeatsExtensionId == null)
            {
                throw new ArgumentNullException(nameof(farmBeatsExtensionId));
            }

            using var scope = _clientDiagnostics.CreateScope("FarmBeatsExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(farmBeatsExtensionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            if (farmBeatsExtensionId == null)
            {
                throw new ArgumentNullException(nameof(farmBeatsExtensionId));
            }

            using var scope = _clientDiagnostics.CreateScope("FarmBeatsExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(farmBeatsExtensionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get list of farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionIds"> FarmBeatsExtension ids. </param>
        /// <param name="farmBeatsExtensionNames"> FarmBeats extension names. </param>
        /// <param name="extensionCategories"> Extension categories. </param>
        /// <param name="publisherIds"> Publisher ids. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FarmBeatsExtension" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FarmBeatsExtension> GetAll(IEnumerable<string> farmBeatsExtensionIds = null, IEnumerable<string> farmBeatsExtensionNames = null, IEnumerable<string> extensionCategories = null, IEnumerable<string> publisherIds = null, int? maxPageSize = null, CancellationToken cancellationToken = default)
        {
            Page<FarmBeatsExtension> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FarmBeatsExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _farmBeatsExtensionsRestClient.List(farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, pageSizeHint, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FarmBeatsExtension(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FarmBeatsExtension> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FarmBeatsExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _farmBeatsExtensionsRestClient.ListNextPage(nextLink, farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, pageSizeHint, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FarmBeatsExtension(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get list of farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionIds"> FarmBeatsExtension ids. </param>
        /// <param name="farmBeatsExtensionNames"> FarmBeats extension names. </param>
        /// <param name="extensionCategories"> Extension categories. </param>
        /// <param name="publisherIds"> Publisher ids. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FarmBeatsExtension" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FarmBeatsExtension> GetAllAsync(IEnumerable<string> farmBeatsExtensionIds = null, IEnumerable<string> farmBeatsExtensionNames = null, IEnumerable<string> extensionCategories = null, IEnumerable<string> publisherIds = null, int? maxPageSize = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<FarmBeatsExtension>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FarmBeatsExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _farmBeatsExtensionsRestClient.ListAsync(farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, pageSizeHint, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FarmBeatsExtension(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FarmBeatsExtension>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FarmBeatsExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _farmBeatsExtensionsRestClient.ListNextPageAsync(nextLink, farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, pageSizeHint, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FarmBeatsExtension(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<FarmBeatsExtension> IEnumerable<FarmBeatsExtension>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FarmBeatsExtension> IAsyncEnumerable<FarmBeatsExtension>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, FarmBeatsExtension, FarmBeatsExtensionData> Construct() { }
    }
}
