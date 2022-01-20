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
using Azure.ResourceManager.Chaos.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Chaos
{
    /// <summary> A class representing collection of Experiment and their operations over its parent. </summary>
    public partial class ExperimentCollection : ArmCollection, IEnumerable<Experiment>, IAsyncEnumerable<Experiment>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ExperimentsRestOperations _experimentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExperimentCollection"/> class for mocking. </summary>
        protected ExperimentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExperimentCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExperimentCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Experiment.ResourceType, out string apiVersion);
            _experimentsRestClient = new ExperimentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Create or update a Experiment resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="experiment"> Experiment resource to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> or <paramref name="experiment"/> is null. </exception>
        public virtual ExperimentCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string experimentName, ExperimentData experiment, CancellationToken cancellationToken = default)
        {
            if (experimentName == null)
            {
                throw new ArgumentNullException(nameof(experimentName));
            }
            if (experiment == null)
            {
                throw new ArgumentNullException(nameof(experiment));
            }

            using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _experimentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, experimentName, experiment, cancellationToken);
                var operation = new ExperimentCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _experimentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, experimentName, experiment).Request, response);
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

        /// <summary> Create or update a Experiment resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="experiment"> Experiment resource to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> or <paramref name="experiment"/> is null. </exception>
        public async virtual Task<ExperimentCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string experimentName, ExperimentData experiment, CancellationToken cancellationToken = default)
        {
            if (experimentName == null)
            {
                throw new ArgumentNullException(nameof(experimentName));
            }
            if (experiment == null)
            {
                throw new ArgumentNullException(nameof(experiment));
            }

            using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _experimentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, experimentName, experiment, cancellationToken).ConfigureAwait(false);
                var operation = new ExperimentCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _experimentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, experimentName, experiment).Request, response);
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

        /// <summary> Get a Experiment resource. </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual Response<Experiment> Get(string experimentName, CancellationToken cancellationToken = default)
        {
            if (experimentName == null)
            {
                throw new ArgumentNullException(nameof(experimentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.Get");
            scope.Start();
            try
            {
                var response = _experimentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, experimentName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Experiment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a Experiment resource. </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public async virtual Task<Response<Experiment>> GetAsync(string experimentName, CancellationToken cancellationToken = default)
        {
            if (experimentName == null)
            {
                throw new ArgumentNullException(nameof(experimentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.Get");
            scope.Start();
            try
            {
                var response = await _experimentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, experimentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Experiment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual Response<Experiment> GetIfExists(string experimentName, CancellationToken cancellationToken = default)
        {
            if (experimentName == null)
            {
                throw new ArgumentNullException(nameof(experimentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _experimentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, experimentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Experiment>(null, response.GetRawResponse());
                return Response.FromValue(new Experiment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public async virtual Task<Response<Experiment>> GetIfExistsAsync(string experimentName, CancellationToken cancellationToken = default)
        {
            if (experimentName == null)
            {
                throw new ArgumentNullException(nameof(experimentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _experimentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, experimentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Experiment>(null, response.GetRawResponse());
                return Response.FromValue(new Experiment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual Response<bool> Exists(string experimentName, CancellationToken cancellationToken = default)
        {
            if (experimentName == null)
            {
                throw new ArgumentNullException(nameof(experimentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(experimentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string experimentName, CancellationToken cancellationToken = default)
        {
            if (experimentName == null)
            {
                throw new ArgumentNullException(nameof(experimentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(experimentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a list of Experiment resources in a resource group. </summary>
        /// <param name="running"> Optional value that indicates whether to filter results based on if the Experiment is currently running. If null, then the results will not be filtered. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Experiment" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Experiment> GetAll(bool? running = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Page<Experiment> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _experimentsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, running, continuationToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Experiment(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Experiment> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _experimentsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, running, continuationToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Experiment(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get a list of Experiment resources in a resource group. </summary>
        /// <param name="running"> Optional value that indicates whether to filter results based on if the Experiment is currently running. If null, then the results will not be filtered. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Experiment" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Experiment> GetAllAsync(bool? running = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Experiment>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _experimentsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, running, continuationToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Experiment(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Experiment>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _experimentsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, running, continuationToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Experiment(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Experiment" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Experiment.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Experiment" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExperimentCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Experiment.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Experiment> IEnumerable<Experiment>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Experiment> IAsyncEnumerable<Experiment>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Experiment, ExperimentData> Construct() { }
    }
}
