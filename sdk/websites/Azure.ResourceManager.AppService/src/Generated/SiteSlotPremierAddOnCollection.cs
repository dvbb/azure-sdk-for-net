// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of PremierAddOn and their operations over its parent. </summary>
    public partial class SiteSlotPremierAddOnCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotPremierAddOnCollection"/> class for mocking. </summary>
        protected SiteSlotPremierAddOnCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteSlotPremierAddOnCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotPremierAddOnCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_AddPremierAddOnSlot
        /// <summary> Description for Updates a named add-on of an app. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="premierAddOn"> A JSON representation of the edited premier add-on. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> or <paramref name="premierAddOn"/> is null. </exception>
        public virtual WebAppAddPremierAddOnSlotOperation CreateOrUpdate(string premierAddOnName, PremierAddOnData premierAddOn, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (premierAddOnName == null)
            {
                throw new ArgumentNullException(nameof(premierAddOnName));
            }
            if (premierAddOn == null)
            {
                throw new ArgumentNullException(nameof(premierAddOn));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.AddPremierAddOnSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, premierAddOn, cancellationToken);
                var operation = new WebAppAddPremierAddOnSlotOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_AddPremierAddOnSlot
        /// <summary> Description for Updates a named add-on of an app. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="premierAddOn"> A JSON representation of the edited premier add-on. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> or <paramref name="premierAddOn"/> is null. </exception>
        public async virtual Task<WebAppAddPremierAddOnSlotOperation> CreateOrUpdateAsync(string premierAddOnName, PremierAddOnData premierAddOn, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (premierAddOnName == null)
            {
                throw new ArgumentNullException(nameof(premierAddOnName));
            }
            if (premierAddOn == null)
            {
                throw new ArgumentNullException(nameof(premierAddOn));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.AddPremierAddOnSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, premierAddOn, cancellationToken).ConfigureAwait(false);
                var operation = new WebAppAddPremierAddOnSlotOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetPremierAddOnSlot
        /// <summary> Description for Gets a named add-on of an app. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<SiteSlotPremierAddOn> Get(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            if (premierAddOnName == null)
            {
                throw new ArgumentNullException(nameof(premierAddOnName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetPremierAddOnSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotPremierAddOn(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetPremierAddOnSlot
        /// <summary> Description for Gets a named add-on of an app. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotPremierAddOn>> GetAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            if (premierAddOnName == null)
            {
                throw new ArgumentNullException(nameof(premierAddOnName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetPremierAddOnSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotPremierAddOn(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<SiteSlotPremierAddOn> GetIfExists(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            if (premierAddOnName == null)
            {
                throw new ArgumentNullException(nameof(premierAddOnName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetPremierAddOnSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteSlotPremierAddOn>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotPremierAddOn(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotPremierAddOn>> GetIfExistsAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            if (premierAddOnName == null)
            {
                throw new ArgumentNullException(nameof(premierAddOnName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetPremierAddOnSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, premierAddOnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteSlotPremierAddOn>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotPremierAddOn(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<bool> Exists(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            if (premierAddOnName == null)
            {
                throw new ArgumentNullException(nameof(premierAddOnName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(premierAddOnName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            if (premierAddOnName == null)
            {
                throw new ArgumentNullException(nameof(premierAddOnName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotPremierAddOnCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(premierAddOnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteSlotPremierAddOn, PremierAddOnData> Construct() { }
    }
}
