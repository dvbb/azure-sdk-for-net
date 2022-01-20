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
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary> A class representing collection of DataExport and their operations over its parent. </summary>
    public partial class DataExportCollection : ArmCollection, IEnumerable<DataExport>, IAsyncEnumerable<DataExport>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DataExportsRestOperations _dataExportsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataExportCollection"/> class for mocking. </summary>
        protected DataExportCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataExportCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DataExportCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(DataExport.ResourceType, out string apiVersion);
            _dataExportsRestClient = new DataExportsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Workspace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Workspace.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update a data export. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="parameters"> The parameters required to create or update a data export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DataExportCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string dataExportName, DataExportData parameters, CancellationToken cancellationToken = default)
        {
            if (dataExportName == null)
            {
                throw new ArgumentNullException(nameof(dataExportName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DataExportCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataExportsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, parameters, cancellationToken);
                var operation = new DataExportCreateOrUpdateOperation(this, response);
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

        /// <summary> Create or update a data export. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="parameters"> The parameters required to create or update a data export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DataExportCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string dataExportName, DataExportData parameters, CancellationToken cancellationToken = default)
        {
            if (dataExportName == null)
            {
                throw new ArgumentNullException(nameof(dataExportName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DataExportCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataExportsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DataExportCreateOrUpdateOperation(this, response);
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

        /// <summary> Gets a data export instance. </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public virtual Response<DataExport> Get(string dataExportName, CancellationToken cancellationToken = default)
        {
            if (dataExportName == null)
            {
                throw new ArgumentNullException(nameof(dataExportName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataExportCollection.Get");
            scope.Start();
            try
            {
                var response = _dataExportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataExport(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a data export instance. </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public async virtual Task<Response<DataExport>> GetAsync(string dataExportName, CancellationToken cancellationToken = default)
        {
            if (dataExportName == null)
            {
                throw new ArgumentNullException(nameof(dataExportName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataExportCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataExportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DataExport(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public virtual Response<DataExport> GetIfExists(string dataExportName, CancellationToken cancellationToken = default)
        {
            if (dataExportName == null)
            {
                throw new ArgumentNullException(nameof(dataExportName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataExportCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataExportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DataExport>(null, response.GetRawResponse());
                return Response.FromValue(new DataExport(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public async virtual Task<Response<DataExport>> GetIfExistsAsync(string dataExportName, CancellationToken cancellationToken = default)
        {
            if (dataExportName == null)
            {
                throw new ArgumentNullException(nameof(dataExportName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataExportCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataExportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataExportName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DataExport>(null, response.GetRawResponse());
                return Response.FromValue(new DataExport(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataExportName, CancellationToken cancellationToken = default)
        {
            if (dataExportName == null)
            {
                throw new ArgumentNullException(nameof(dataExportName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataExportCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(dataExportName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataExportName"> The data export rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataExportName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string dataExportName, CancellationToken cancellationToken = default)
        {
            if (dataExportName == null)
            {
                throw new ArgumentNullException(nameof(dataExportName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataExportCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(dataExportName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the data export instances within a workspace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataExport" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataExport> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DataExport> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataExportCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataExportsRestClient.ListByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataExport(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the data export instances within a workspace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataExport" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataExport> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataExport>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataExportCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataExportsRestClient.ListByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataExport(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<DataExport> IEnumerable<DataExport>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataExport> IAsyncEnumerable<DataExport>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DataExport, DataExportData> Construct() { }
    }
}
