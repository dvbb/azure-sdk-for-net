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
using Azure.ResourceManager.OperationalInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary> A class representing collection of Workspace and their operations over its parent. </summary>
    public partial class WorkspaceCollection : ArmCollection, IEnumerable<Workspace>, IAsyncEnumerable<Workspace>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WorkspacesRestOperations _workspacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkspaceCollection"/> class for mocking. </summary>
        protected WorkspaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkspaceCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WorkspaceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Workspace.ResourceType, out string apiVersion);
            _workspacesRestClient = new WorkspacesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Create or update a workspace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="parameters"> The parameters required to create or update a workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual WorkspaceCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string workspaceName, WorkspaceData parameters, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workspacesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, parameters, cancellationToken);
                var operation = new WorkspaceCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _workspacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, parameters).Request, response);
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

        /// <summary> Create or update a workspace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="parameters"> The parameters required to create or update a workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WorkspaceCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string workspaceName, WorkspaceData parameters, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workspacesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WorkspaceCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _workspacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, parameters).Request, response);
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

        /// <summary> Gets a workspace instance. </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<Workspace> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = _workspacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Workspace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a workspace instance. </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public async virtual Task<Response<Workspace>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _workspacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Workspace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<Workspace> GetIfExists(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workspacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Workspace>(null, response.GetRawResponse());
                return Response.FromValue(new Workspace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public async virtual Task<Response<Workspace>> GetIfExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workspacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Workspace>(null, response.GetRawResponse());
                return Response.FromValue(new Workspace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets workspaces in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Workspace" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Workspace> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Workspace> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workspacesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Workspace(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets workspaces in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Workspace" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Workspace> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Workspace>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workspacesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Workspace(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="Workspace" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Workspace.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Workspace" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Workspace.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Workspace> IEnumerable<Workspace>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Workspace> IAsyncEnumerable<Workspace>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Workspace, WorkspaceData> Construct() { }
    }
}
