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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.StorSimple8000Series.Models;

namespace Azure.ResourceManager.StorSimple8000Series
{
    /// <summary> A class representing collection of BandwidthSetting and their operations over its parent. </summary>
    public partial class BandwidthSettingCollection : ArmCollection, IEnumerable<BandwidthSetting>, IAsyncEnumerable<BandwidthSetting>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BandwidthSettingsRestOperations _bandwidthSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BandwidthSettingCollection"/> class for mocking. </summary>
        protected BandwidthSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BandwidthSettingCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BandwidthSettingCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(BandwidthSetting.ResourceType, out string apiVersion);
            _bandwidthSettingsRestClient = new BandwidthSettingsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Manager.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Manager.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates the bandwidth setting. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="bandwidthSettingName"> The bandwidth setting name. </param>
        /// <param name="parameters"> The bandwidth setting to be added or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bandwidthSettingName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual BandwidthSettingCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string bandwidthSettingName, BandwidthSettingData parameters, CancellationToken cancellationToken = default)
        {
            if (bandwidthSettingName == null)
            {
                throw new ArgumentNullException(nameof(bandwidthSettingName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BandwidthSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _bandwidthSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bandwidthSettingName, parameters, cancellationToken);
                var operation = new BandwidthSettingCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _bandwidthSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bandwidthSettingName, parameters).Request, response);
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

        /// <summary> Creates or updates the bandwidth setting. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="bandwidthSettingName"> The bandwidth setting name. </param>
        /// <param name="parameters"> The bandwidth setting to be added or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bandwidthSettingName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<BandwidthSettingCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string bandwidthSettingName, BandwidthSettingData parameters, CancellationToken cancellationToken = default)
        {
            if (bandwidthSettingName == null)
            {
                throw new ArgumentNullException(nameof(bandwidthSettingName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BandwidthSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _bandwidthSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bandwidthSettingName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new BandwidthSettingCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _bandwidthSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bandwidthSettingName, parameters).Request, response);
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

        /// <summary> Returns the properties of the specified bandwidth setting name. </summary>
        /// <param name="bandwidthSettingName"> The name of bandwidth setting to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bandwidthSettingName"/> is null. </exception>
        public virtual Response<BandwidthSetting> Get(string bandwidthSettingName, CancellationToken cancellationToken = default)
        {
            if (bandwidthSettingName == null)
            {
                throw new ArgumentNullException(nameof(bandwidthSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("BandwidthSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _bandwidthSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bandwidthSettingName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BandwidthSetting(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns the properties of the specified bandwidth setting name. </summary>
        /// <param name="bandwidthSettingName"> The name of bandwidth setting to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bandwidthSettingName"/> is null. </exception>
        public async virtual Task<Response<BandwidthSetting>> GetAsync(string bandwidthSettingName, CancellationToken cancellationToken = default)
        {
            if (bandwidthSettingName == null)
            {
                throw new ArgumentNullException(nameof(bandwidthSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("BandwidthSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _bandwidthSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bandwidthSettingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BandwidthSetting(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="bandwidthSettingName"> The name of bandwidth setting to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bandwidthSettingName"/> is null. </exception>
        public virtual Response<BandwidthSetting> GetIfExists(string bandwidthSettingName, CancellationToken cancellationToken = default)
        {
            if (bandwidthSettingName == null)
            {
                throw new ArgumentNullException(nameof(bandwidthSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("BandwidthSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _bandwidthSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bandwidthSettingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<BandwidthSetting>(null, response.GetRawResponse());
                return Response.FromValue(new BandwidthSetting(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="bandwidthSettingName"> The name of bandwidth setting to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bandwidthSettingName"/> is null. </exception>
        public async virtual Task<Response<BandwidthSetting>> GetIfExistsAsync(string bandwidthSettingName, CancellationToken cancellationToken = default)
        {
            if (bandwidthSettingName == null)
            {
                throw new ArgumentNullException(nameof(bandwidthSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("BandwidthSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _bandwidthSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bandwidthSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<BandwidthSetting>(null, response.GetRawResponse());
                return Response.FromValue(new BandwidthSetting(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="bandwidthSettingName"> The name of bandwidth setting to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bandwidthSettingName"/> is null. </exception>
        public virtual Response<bool> Exists(string bandwidthSettingName, CancellationToken cancellationToken = default)
        {
            if (bandwidthSettingName == null)
            {
                throw new ArgumentNullException(nameof(bandwidthSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("BandwidthSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(bandwidthSettingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="bandwidthSettingName"> The name of bandwidth setting to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bandwidthSettingName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string bandwidthSettingName, CancellationToken cancellationToken = default)
        {
            if (bandwidthSettingName == null)
            {
                throw new ArgumentNullException(nameof(bandwidthSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("BandwidthSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(bandwidthSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all the bandwidth setting in a manager. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BandwidthSetting" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BandwidthSetting> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BandwidthSetting> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BandwidthSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bandwidthSettingsRestClient.ListByManager(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BandwidthSetting(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Retrieves all the bandwidth setting in a manager. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BandwidthSetting" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BandwidthSetting> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BandwidthSetting>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BandwidthSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bandwidthSettingsRestClient.ListByManagerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BandwidthSetting(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<BandwidthSetting> IEnumerable<BandwidthSetting>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BandwidthSetting> IAsyncEnumerable<BandwidthSetting>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, BandwidthSetting, BandwidthSettingData> Construct() { }
    }
}
