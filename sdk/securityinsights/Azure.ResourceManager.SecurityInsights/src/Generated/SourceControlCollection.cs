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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> A class representing collection of SourceControl and their operations over its parent. </summary>
    public partial class SourceControlCollection : ArmCollection, IEnumerable<SourceControl>, IAsyncEnumerable<SourceControl>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SourceControlsRestOperations _sourceControlsRestClient;
        private readonly string _workspaceName;

        /// <summary> Initializes a new instance of the <see cref="SourceControlCollection"/> class for mocking. </summary>
        protected SourceControlCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SourceControlCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        internal SourceControlCollection(ArmResource parent, string workspaceName) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SourceControl.ResourceType, out string apiVersion);
            _sourceControlsRestClient = new SourceControlsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _workspaceName = workspaceName;
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a source control. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="sourceControlId"> Source control Id. </param>
        /// <param name="sourceControl"> The SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlId"/> or <paramref name="sourceControl"/> is null. </exception>
        public virtual SourceControlCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string sourceControlId, SourceControlData sourceControl, CancellationToken cancellationToken = default)
        {
            if (sourceControlId == null)
            {
                throw new ArgumentNullException(nameof(sourceControlId));
            }
            if (sourceControl == null)
            {
                throw new ArgumentNullException(nameof(sourceControl));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sourceControlsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, sourceControlId, sourceControl, cancellationToken);
                var operation = new SourceControlCreateOrUpdateOperation(this, response);
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

        /// <summary> Creates a source control. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="sourceControlId"> Source control Id. </param>
        /// <param name="sourceControl"> The SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlId"/> or <paramref name="sourceControl"/> is null. </exception>
        public async virtual Task<SourceControlCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string sourceControlId, SourceControlData sourceControl, CancellationToken cancellationToken = default)
        {
            if (sourceControlId == null)
            {
                throw new ArgumentNullException(nameof(sourceControlId));
            }
            if (sourceControl == null)
            {
                throw new ArgumentNullException(nameof(sourceControl));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sourceControlsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, sourceControlId, sourceControl, cancellationToken).ConfigureAwait(false);
                var operation = new SourceControlCreateOrUpdateOperation(this, response);
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

        /// <summary> Gets a source control byt its identifier. </summary>
        /// <param name="sourceControlId"> Source control Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlId"/> is null. </exception>
        public virtual Response<SourceControl> Get(string sourceControlId, CancellationToken cancellationToken = default)
        {
            if (sourceControlId == null)
            {
                throw new ArgumentNullException(nameof(sourceControlId));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = _sourceControlsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, sourceControlId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SourceControl(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a source control byt its identifier. </summary>
        /// <param name="sourceControlId"> Source control Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlId"/> is null. </exception>
        public async virtual Task<Response<SourceControl>> GetAsync(string sourceControlId, CancellationToken cancellationToken = default)
        {
            if (sourceControlId == null)
            {
                throw new ArgumentNullException(nameof(sourceControlId));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = await _sourceControlsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, sourceControlId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SourceControl(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sourceControlId"> Source control Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlId"/> is null. </exception>
        public virtual Response<SourceControl> GetIfExists(string sourceControlId, CancellationToken cancellationToken = default)
        {
            if (sourceControlId == null)
            {
                throw new ArgumentNullException(nameof(sourceControlId));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sourceControlsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, sourceControlId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SourceControl>(null, response.GetRawResponse());
                return Response.FromValue(new SourceControl(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sourceControlId"> Source control Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlId"/> is null. </exception>
        public async virtual Task<Response<SourceControl>> GetIfExistsAsync(string sourceControlId, CancellationToken cancellationToken = default)
        {
            if (sourceControlId == null)
            {
                throw new ArgumentNullException(nameof(sourceControlId));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sourceControlsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, sourceControlId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SourceControl>(null, response.GetRawResponse());
                return Response.FromValue(new SourceControl(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sourceControlId"> Source control Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlId"/> is null. </exception>
        public virtual Response<bool> Exists(string sourceControlId, CancellationToken cancellationToken = default)
        {
            if (sourceControlId == null)
            {
                throw new ArgumentNullException(nameof(sourceControlId));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(sourceControlId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sourceControlId"> Source control Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string sourceControlId, CancellationToken cancellationToken = default)
        {
            if (sourceControlId == null)
            {
                throw new ArgumentNullException(nameof(sourceControlId));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(sourceControlId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all source controls, without source control items. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SourceControl" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SourceControl> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SourceControl> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sourceControlsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SourceControl> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sourceControlsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all source controls, without source control items. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SourceControl" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SourceControl> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SourceControl>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sourceControlsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SourceControl>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sourceControlsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SourceControl" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SourceControl.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SourceControl" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SourceControl.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SourceControl> IEnumerable<SourceControl>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SourceControl> IAsyncEnumerable<SourceControl>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SourceControl, SourceControlData> Construct() { }
    }
}
