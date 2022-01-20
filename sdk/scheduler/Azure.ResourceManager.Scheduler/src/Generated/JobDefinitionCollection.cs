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
using Azure.ResourceManager.Scheduler.Models;

namespace Azure.ResourceManager.Scheduler
{
    /// <summary> A class representing collection of JobDefinition and their operations over its parent. </summary>
    public partial class JobDefinitionCollection : ArmCollection, IEnumerable<JobDefinition>, IAsyncEnumerable<JobDefinition>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly JobsRestOperations _jobsRestClient;

        /// <summary> Initializes a new instance of the <see cref="JobDefinitionCollection"/> class for mocking. </summary>
        protected JobDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JobDefinitionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal JobDefinitionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(JobDefinition.ResourceType, out string apiVersion);
            _jobsRestClient = new JobsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != JobCollectionDefinition.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, JobCollectionDefinition.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Provisions a new job or updates an existing job. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="jobName"> The job name. </param>
        /// <param name="job"> The job definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="job"/> is null. </exception>
        public virtual JobDefinitionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string jobName, JobDefinitionData job, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }
            if (job == null)
            {
                throw new ArgumentNullException(nameof(job));
            }

            using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jobsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, job, cancellationToken);
                var operation = new JobDefinitionCreateOrUpdateOperation(this, response);
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

        /// <summary> Provisions a new job or updates an existing job. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="jobName"> The job name. </param>
        /// <param name="job"> The job definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="job"/> is null. </exception>
        public async virtual Task<JobDefinitionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string jobName, JobDefinitionData job, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }
            if (job == null)
            {
                throw new ArgumentNullException(nameof(job));
            }

            using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jobsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, job, cancellationToken).ConfigureAwait(false);
                var operation = new JobDefinitionCreateOrUpdateOperation(this, response);
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

        /// <summary> Gets a job. </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<JobDefinition> Get(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _jobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a job. </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public async virtual Task<Response<JobDefinition>> GetAsync(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new JobDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<JobDefinition> GetIfExists(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<JobDefinition>(null, response.GetRawResponse());
                return Response.FromValue(new JobDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public async virtual Task<Response<JobDefinition>> GetIfExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _jobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<JobDefinition>(null, response.GetRawResponse());
                return Response.FromValue(new JobDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(jobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all jobs under the specified job collection. </summary>
        /// <param name="top"> The number of jobs to request, in the of range of [1..100]. </param>
        /// <param name="skip"> The (0-based) index of the job history list from which to begin requesting entries. </param>
        /// <param name="filter"> The filter to apply on the job state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobDefinition> GetAll(int? top = null, int? skip = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Page<JobDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobDefinition(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobDefinition(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all jobs under the specified job collection. </summary>
        /// <param name="top"> The number of jobs to request, in the of range of [1..100]. </param>
        /// <param name="skip"> The (0-based) index of the job history list from which to begin requesting entries. </param>
        /// <param name="filter"> The filter to apply on the job state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobDefinition> GetAllAsync(int? top = null, int? skip = null, string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<JobDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobDefinition(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobDefinition(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<JobDefinition> IEnumerable<JobDefinition>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JobDefinition> IAsyncEnumerable<JobDefinition>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, JobDefinition, JobDefinitionData> Construct() { }
    }
}
