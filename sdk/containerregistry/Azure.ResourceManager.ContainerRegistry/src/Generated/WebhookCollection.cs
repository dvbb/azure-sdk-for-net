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
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary> A class representing collection of Webhook and their operations over its parent. </summary>
    public partial class WebhookCollection : ArmCollection, IEnumerable<Webhook>, IAsyncEnumerable<Webhook>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebhooksRestOperations _webhooksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebhookCollection"/> class for mocking. </summary>
        protected WebhookCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebhookCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WebhookCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Webhook.ResourceType, out string apiVersion);
            _webhooksRestClient = new WebhooksRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Registry.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Registry.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a webhook for a container registry with the specified parameters. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="webhookCreateParameters"> The parameters for creating a webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> or <paramref name="webhookCreateParameters"/> is null. </exception>
        public virtual WebhookCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string webhookName, WebhookCreateParameters webhookCreateParameters, CancellationToken cancellationToken = default)
        {
            if (webhookName == null)
            {
                throw new ArgumentNullException(nameof(webhookName));
            }
            if (webhookCreateParameters == null)
            {
                throw new ArgumentNullException(nameof(webhookCreateParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WebhookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webhooksRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, webhookCreateParameters, cancellationToken);
                var operation = new WebhookCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _webhooksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, webhookCreateParameters).Request, response);
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

        /// <summary> Creates a webhook for a container registry with the specified parameters. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="webhookCreateParameters"> The parameters for creating a webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> or <paramref name="webhookCreateParameters"/> is null. </exception>
        public async virtual Task<WebhookCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string webhookName, WebhookCreateParameters webhookCreateParameters, CancellationToken cancellationToken = default)
        {
            if (webhookName == null)
            {
                throw new ArgumentNullException(nameof(webhookName));
            }
            if (webhookCreateParameters == null)
            {
                throw new ArgumentNullException(nameof(webhookCreateParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WebhookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webhooksRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, webhookCreateParameters, cancellationToken).ConfigureAwait(false);
                var operation = new WebhookCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _webhooksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, webhookCreateParameters).Request, response);
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

        /// <summary> Gets the properties of the specified webhook. </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual Response<Webhook> Get(string webhookName, CancellationToken cancellationToken = default)
        {
            if (webhookName == null)
            {
                throw new ArgumentNullException(nameof(webhookName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebhookCollection.Get");
            scope.Start();
            try
            {
                var response = _webhooksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Webhook(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the properties of the specified webhook. </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public async virtual Task<Response<Webhook>> GetAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            if (webhookName == null)
            {
                throw new ArgumentNullException(nameof(webhookName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebhookCollection.Get");
            scope.Start();
            try
            {
                var response = await _webhooksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Webhook(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual Response<Webhook> GetIfExists(string webhookName, CancellationToken cancellationToken = default)
        {
            if (webhookName == null)
            {
                throw new ArgumentNullException(nameof(webhookName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebhookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webhooksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Webhook>(null, response.GetRawResponse());
                return Response.FromValue(new Webhook(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public async virtual Task<Response<Webhook>> GetIfExistsAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            if (webhookName == null)
            {
                throw new ArgumentNullException(nameof(webhookName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebhookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webhooksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Webhook>(null, response.GetRawResponse());
                return Response.FromValue(new Webhook(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual Response<bool> Exists(string webhookName, CancellationToken cancellationToken = default)
        {
            if (webhookName == null)
            {
                throw new ArgumentNullException(nameof(webhookName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebhookCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(webhookName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            if (webhookName == null)
            {
                throw new ArgumentNullException(nameof(webhookName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebhookCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(webhookName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the webhooks for the specified container registry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Webhook" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Webhook> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Webhook> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebhookCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webhooksRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Webhook(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Webhook> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebhookCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webhooksRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Webhook(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the webhooks for the specified container registry. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Webhook" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Webhook> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Webhook>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebhookCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webhooksRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Webhook(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Webhook>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebhookCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webhooksRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Webhook(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<Webhook> IEnumerable<Webhook>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Webhook> IAsyncEnumerable<Webhook>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Webhook, WebhookData> Construct() { }
    }
}
