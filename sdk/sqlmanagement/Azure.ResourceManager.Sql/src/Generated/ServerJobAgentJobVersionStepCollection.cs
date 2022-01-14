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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of JobStep and their operations over its parent. </summary>
    public partial class ServerJobAgentJobVersionStepCollection : ArmCollection, IEnumerable<ServerJobAgentJobVersionStep>, IAsyncEnumerable<ServerJobAgentJobVersionStep>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly JobStepsRestOperations _jobStepsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerJobAgentJobVersionStepCollection"/> class for mocking. </summary>
        protected ServerJobAgentJobVersionStepCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerJobAgentJobVersionStepCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerJobAgentJobVersionStepCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _jobStepsRestClient = new JobStepsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != JobVersion.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, JobVersion.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}
        /// OperationId: JobSteps_GetByVersion
        /// <summary> Gets the specified version of a job step. </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<ServerJobAgentJobVersionStep> Get(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobVersionStepCollection.Get");
            scope.Start();
            try
            {
                var response = _jobStepsRestClient.GetByVersion(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), stepName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobVersionStep(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}
        /// OperationId: JobSteps_GetByVersion
        /// <summary> Gets the specified version of a job step. </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public async virtual Task<Response<ServerJobAgentJobVersionStep>> GetAsync(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobVersionStepCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobStepsRestClient.GetByVersionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), stepName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerJobAgentJobVersionStep(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<ServerJobAgentJobVersionStep> GetIfExists(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobVersionStepCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobStepsRestClient.GetByVersion(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), stepName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerJobAgentJobVersionStep>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerJobAgentJobVersionStep(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public async virtual Task<Response<ServerJobAgentJobVersionStep>> GetIfExistsAsync(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobVersionStepCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _jobStepsRestClient.GetByVersionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), stepName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerJobAgentJobVersionStep>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerJobAgentJobVersionStep(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<bool> Exists(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobVersionStepCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(stepName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobVersionStepCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(stepName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}
        /// OperationId: JobSteps_ListByVersion
        /// <summary> Gets all job steps in the specified job version. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerJobAgentJobVersionStep" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerJobAgentJobVersionStep> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerJobAgentJobVersionStep> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobVersionStepCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobStepsRestClient.ListByVersion(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobVersionStep(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerJobAgentJobVersionStep> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobVersionStepCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobStepsRestClient.ListByVersionNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobVersionStep(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}
        /// OperationId: JobSteps_ListByVersion
        /// <summary> Gets all job steps in the specified job version. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerJobAgentJobVersionStep" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerJobAgentJobVersionStep> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerJobAgentJobVersionStep>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobVersionStepCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobStepsRestClient.ListByVersionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobVersionStep(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerJobAgentJobVersionStep>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobVersionStepCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobStepsRestClient.ListByVersionNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobVersionStep(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ServerJobAgentJobVersionStep> IEnumerable<ServerJobAgentJobVersionStep>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerJobAgentJobVersionStep> IAsyncEnumerable<ServerJobAgentJobVersionStep>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ServerJobAgentJobVersionStep, JobStepData> Construct() { }
    }
}
