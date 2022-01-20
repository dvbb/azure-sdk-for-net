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
using Azure.ResourceManager.Chaos.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Chaos
{
    /// <summary> A class representing collection of Capability and their operations over its parent. </summary>
    public partial class CapabilityCollection : ArmCollection, IEnumerable<Capability>, IAsyncEnumerable<Capability>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CapabilitiesRestOperations _capabilitiesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CapabilityCollection"/> class for mocking. </summary>
        protected CapabilityCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CapabilityCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CapabilityCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Capability.ResourceType, out string apiVersion);
            _capabilitiesRestClient = new CapabilitiesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Target.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Target.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update a Capability resource that extends a Target resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="capability"> Capability resource to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> or <paramref name="capability"/> is null. </exception>
        public virtual CapabilityCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string capabilityName, CapabilityData capability, CancellationToken cancellationToken = default)
        {
            if (capabilityName == null)
            {
                throw new ArgumentNullException(nameof(capabilityName));
            }
            if (capability == null)
            {
                throw new ArgumentNullException(nameof(capability));
            }

            using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _capabilitiesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, capability, cancellationToken);
                var operation = new CapabilityCreateOrUpdateOperation(this, response);
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

        /// <summary> Create or update a Capability resource that extends a Target resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="capability"> Capability resource to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> or <paramref name="capability"/> is null. </exception>
        public async virtual Task<CapabilityCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string capabilityName, CapabilityData capability, CancellationToken cancellationToken = default)
        {
            if (capabilityName == null)
            {
                throw new ArgumentNullException(nameof(capabilityName));
            }
            if (capability == null)
            {
                throw new ArgumentNullException(nameof(capability));
            }

            using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _capabilitiesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, capability, cancellationToken).ConfigureAwait(false);
                var operation = new CapabilityCreateOrUpdateOperation(this, response);
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

        /// <summary> Get a Capability resource that extends a Target resource. </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public virtual Response<Capability> Get(string capabilityName, CancellationToken cancellationToken = default)
        {
            if (capabilityName == null)
            {
                throw new ArgumentNullException(nameof(capabilityName));
            }

            using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.Get");
            scope.Start();
            try
            {
                var response = _capabilitiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Capability(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a Capability resource that extends a Target resource. </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public async virtual Task<Response<Capability>> GetAsync(string capabilityName, CancellationToken cancellationToken = default)
        {
            if (capabilityName == null)
            {
                throw new ArgumentNullException(nameof(capabilityName));
            }

            using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.Get");
            scope.Start();
            try
            {
                var response = await _capabilitiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Capability(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public virtual Response<Capability> GetIfExists(string capabilityName, CancellationToken cancellationToken = default)
        {
            if (capabilityName == null)
            {
                throw new ArgumentNullException(nameof(capabilityName));
            }

            using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _capabilitiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Capability>(null, response.GetRawResponse());
                return Response.FromValue(new Capability(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public async virtual Task<Response<Capability>> GetIfExistsAsync(string capabilityName, CancellationToken cancellationToken = default)
        {
            if (capabilityName == null)
            {
                throw new ArgumentNullException(nameof(capabilityName));
            }

            using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _capabilitiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Capability>(null, response.GetRawResponse());
                return Response.FromValue(new Capability(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public virtual Response<bool> Exists(string capabilityName, CancellationToken cancellationToken = default)
        {
            if (capabilityName == null)
            {
                throw new ArgumentNullException(nameof(capabilityName));
            }

            using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(capabilityName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string capabilityName, CancellationToken cancellationToken = default)
        {
            if (capabilityName == null)
            {
                throw new ArgumentNullException(nameof(capabilityName));
            }

            using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(capabilityName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a list of Capability resources that extend a Target resource.. </summary>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Capability" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Capability> GetAll(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Page<Capability> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _capabilitiesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, continuationToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Capability(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Capability> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _capabilitiesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, continuationToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Capability(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get a list of Capability resources that extend a Target resource.. </summary>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Capability" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Capability> GetAllAsync(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Capability>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _capabilitiesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, continuationToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Capability(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Capability>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CapabilityCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _capabilitiesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, continuationToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Capability(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<Capability> IEnumerable<Capability>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Capability> IAsyncEnumerable<Capability>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Capability, CapabilityData> Construct() { }
    }
}
