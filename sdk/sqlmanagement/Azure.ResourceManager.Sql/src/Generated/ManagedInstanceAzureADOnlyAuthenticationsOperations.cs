// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The ManagedInstanceAzureADOnlyAuthentications service client. </summary>
    public partial class ManagedInstanceAzureADOnlyAuthenticationsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ManagedInstanceAzureADOnlyAuthenticationsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of ManagedInstanceAzureADOnlyAuthenticationsOperations for mocking. </summary>
        protected ManagedInstanceAzureADOnlyAuthenticationsOperations()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceAzureADOnlyAuthenticationsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ManagedInstanceAzureADOnlyAuthenticationsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ManagedInstanceAzureADOnlyAuthenticationsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a specific Azure Active Directory only authentication property. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceAzureADOnlyAuthentication>> GetAsync(string resourceGroupName, string managedInstanceName, AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, managedInstanceName, authenticationName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a specific Azure Active Directory only authentication property. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceAzureADOnlyAuthentication> Get(string resourceGroupName, string managedInstanceName, AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, managedInstanceName, authenticationName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of server Azure Active Directory only authentications. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual AsyncPageable<ManagedInstanceAzureADOnlyAuthentication> ListByInstanceAsync(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            async Task<Page<ManagedInstanceAzureADOnlyAuthentication>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByInstanceAsync(resourceGroupName, managedInstanceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceAzureADOnlyAuthentication>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByInstanceNextPageAsync(nextLink, resourceGroupName, managedInstanceName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets a list of server Azure Active Directory only authentications. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual Pageable<ManagedInstanceAzureADOnlyAuthentication> ListByInstance(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            Page<ManagedInstanceAzureADOnlyAuthentication> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = RestClient.ListByInstance(resourceGroupName, managedInstanceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceAzureADOnlyAuthentication> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = RestClient.ListByInstanceNextPage(nextLink, resourceGroupName, managedInstanceName, cancellationToken);
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

        /// <summary> Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="parameters"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ManagedInstanceAzureADOnlyAuthenticationsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string managedInstanceName, AuthenticationName authenticationName, ManagedInstanceAzureADOnlyAuthentication parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, authenticationName, parameters, cancellationToken).ConfigureAwait(false);
                return new ManagedInstanceAzureADOnlyAuthenticationsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, managedInstanceName, authenticationName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="parameters"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual ManagedInstanceAzureADOnlyAuthenticationsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string managedInstanceName, AuthenticationName authenticationName, ManagedInstanceAzureADOnlyAuthentication parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, managedInstanceName, authenticationName, parameters, cancellationToken);
                return new ManagedInstanceAzureADOnlyAuthenticationsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, managedInstanceName, authenticationName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an existing server Active Directory only authentication property. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual async Task<ManagedInstanceAzureADOnlyAuthenticationsDeleteOperation> StartDeleteAsync(string resourceGroupName, string managedInstanceName, AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, managedInstanceName, authenticationName, cancellationToken).ConfigureAwait(false);
                return new ManagedInstanceAzureADOnlyAuthenticationsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, managedInstanceName, authenticationName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an existing server Active Directory only authentication property. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual ManagedInstanceAzureADOnlyAuthenticationsDeleteOperation StartDelete(string resourceGroupName, string managedInstanceName, AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, managedInstanceName, authenticationName, cancellationToken);
                return new ManagedInstanceAzureADOnlyAuthenticationsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, managedInstanceName, authenticationName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
