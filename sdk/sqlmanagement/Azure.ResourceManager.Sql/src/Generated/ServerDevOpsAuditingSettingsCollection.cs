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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerDevOpsAuditingSettings and their operations over its parent. </summary>
    public partial class ServerDevOpsAuditingSettingsCollection : ArmCollection, IEnumerable<ServerDevOpsAuditingSettings>, IAsyncEnumerable<ServerDevOpsAuditingSettings>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServerDevOpsAuditSettingsRestOperations _serverDevOpsAuditSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerDevOpsAuditingSettingsCollection"/> class for mocking. </summary>
        protected ServerDevOpsAuditingSettingsCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerDevOpsAuditingSettingsCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerDevOpsAuditingSettingsCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _serverDevOpsAuditSettingsRestClient = new ServerDevOpsAuditSettingsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SqlServer.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_CreateOrUpdate
        /// <summary> Creates or updates a server&apos;s DevOps audit settings. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="parameters"> Properties of DevOps audit settings. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ServerDevOpsAuditSettingCreateOrUpdateOperation CreateOrUpdate(string devOpsAuditingSettingsName, ServerDevOpsAuditingSettingsData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (devOpsAuditingSettingsName == null)
            {
                throw new ArgumentNullException(nameof(devOpsAuditingSettingsName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters, cancellationToken);
                var operation = new ServerDevOpsAuditSettingCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serverDevOpsAuditSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_CreateOrUpdate
        /// <summary> Creates or updates a server&apos;s DevOps audit settings. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="parameters"> Properties of DevOps audit settings. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ServerDevOpsAuditSettingCreateOrUpdateOperation> CreateOrUpdateAsync(string devOpsAuditingSettingsName, ServerDevOpsAuditingSettingsData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (devOpsAuditingSettingsName == null)
            {
                throw new ArgumentNullException(nameof(devOpsAuditingSettingsName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServerDevOpsAuditSettingCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serverDevOpsAuditSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_Get
        /// <summary> Gets a server&apos;s DevOps audit settings. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<ServerDevOpsAuditingSettings> Get(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            if (devOpsAuditingSettingsName == null)
            {
                throw new ArgumentNullException(nameof(devOpsAuditingSettingsName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDevOpsAuditingSettings(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_Get
        /// <summary> Gets a server&apos;s DevOps audit settings. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public async virtual Task<Response<ServerDevOpsAuditingSettings>> GetAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            if (devOpsAuditingSettingsName == null)
            {
                throw new ArgumentNullException(nameof(devOpsAuditingSettingsName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerDevOpsAuditingSettings(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<ServerDevOpsAuditingSettings> GetIfExists(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            if (devOpsAuditingSettingsName == null)
            {
                throw new ArgumentNullException(nameof(devOpsAuditingSettingsName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerDevOpsAuditingSettings>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerDevOpsAuditingSettings(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public async virtual Task<Response<ServerDevOpsAuditingSettings>> GetIfExistsAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            if (devOpsAuditingSettingsName == null)
            {
                throw new ArgumentNullException(nameof(devOpsAuditingSettingsName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerDevOpsAuditingSettings>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerDevOpsAuditingSettings(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<bool> Exists(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            if (devOpsAuditingSettingsName == null)
            {
                throw new ArgumentNullException(nameof(devOpsAuditingSettingsName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(devOpsAuditingSettingsName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            if (devOpsAuditingSettingsName == null)
            {
                throw new ArgumentNullException(nameof(devOpsAuditingSettingsName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(devOpsAuditingSettingsName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_ListByServer
        /// <summary> Lists DevOps audit settings of a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerDevOpsAuditingSettings" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerDevOpsAuditingSettings> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerDevOpsAuditingSettings> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDevOpsAuditSettingsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerDevOpsAuditingSettings> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDevOpsAuditSettingsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_ListByServer
        /// <summary> Lists DevOps audit settings of a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerDevOpsAuditingSettings" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerDevOpsAuditingSettings> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerDevOpsAuditingSettings>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDevOpsAuditSettingsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerDevOpsAuditingSettings>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDevOpsAuditSettingsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ServerDevOpsAuditingSettings> IEnumerable<ServerDevOpsAuditingSettings>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerDevOpsAuditingSettings> IAsyncEnumerable<ServerDevOpsAuditingSettings>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ServerDevOpsAuditingSettings, ServerDevOpsAuditingSettingsData> Construct() { }
    }
}
