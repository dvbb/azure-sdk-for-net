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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LabServices
{
    /// <summary>
    /// A class representing a collection of <see cref="LabPlanResource" /> and their operations.
    /// Each <see cref="LabPlanResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="LabPlanCollection" /> instance call the GetLabPlans method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class LabPlanCollection : ArmCollection, IEnumerable<LabPlanResource>, IAsyncEnumerable<LabPlanResource>
    {
        private readonly ClientDiagnostics _labPlanClientDiagnostics;
        private readonly LabPlansRestOperations _labPlanRestClient;

        /// <summary> Initializes a new instance of the <see cref="LabPlanCollection"/> class for mocking. </summary>
        protected LabPlanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LabPlanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LabPlanCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _labPlanClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LabServices", LabPlanResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LabPlanResource.ResourceType, out string labPlanApiVersion);
            _labPlanRestClient = new LabPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, labPlanApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Operation to create or update a Lab Plan resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}
        /// Operation Id: LabPlans_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="labPlanName"> The name of the lab plan that uniquely identifies it within containing resource group. Used in resource URIs and in UI. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labPlanName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LabPlanResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string labPlanName, LabPlanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labPlanName, nameof(labPlanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labPlanClientDiagnostics.CreateScope("LabPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _labPlanRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, labPlanName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LabServicesArmOperation<LabPlanResource>(new LabPlanOperationSource(Client), _labPlanClientDiagnostics, Pipeline, _labPlanRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, labPlanName, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to create or update a Lab Plan resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}
        /// Operation Id: LabPlans_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="labPlanName"> The name of the lab plan that uniquely identifies it within containing resource group. Used in resource URIs and in UI. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labPlanName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LabPlanResource> CreateOrUpdate(WaitUntil waitUntil, string labPlanName, LabPlanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labPlanName, nameof(labPlanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labPlanClientDiagnostics.CreateScope("LabPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _labPlanRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, labPlanName, data, cancellationToken);
                var operation = new LabServicesArmOperation<LabPlanResource>(new LabPlanOperationSource(Client), _labPlanClientDiagnostics, Pipeline, _labPlanRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, labPlanName, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of a Lab Plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}
        /// Operation Id: LabPlans_Get
        /// </summary>
        /// <param name="labPlanName"> The name of the lab plan that uniquely identifies it within containing resource group. Used in resource URIs and in UI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labPlanName"/> is null. </exception>
        public virtual async Task<Response<LabPlanResource>> GetAsync(string labPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labPlanName, nameof(labPlanName));

            using var scope = _labPlanClientDiagnostics.CreateScope("LabPlanCollection.Get");
            scope.Start();
            try
            {
                var response = await _labPlanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, labPlanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of a Lab Plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}
        /// Operation Id: LabPlans_Get
        /// </summary>
        /// <param name="labPlanName"> The name of the lab plan that uniquely identifies it within containing resource group. Used in resource URIs and in UI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labPlanName"/> is null. </exception>
        public virtual Response<LabPlanResource> Get(string labPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labPlanName, nameof(labPlanName));

            using var scope = _labPlanClientDiagnostics.CreateScope("LabPlanCollection.Get");
            scope.Start();
            try
            {
                var response = _labPlanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, labPlanName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of all lab plans for a subscription and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans
        /// Operation Id: LabPlans_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LabPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LabPlanResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LabPlanResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _labPlanClientDiagnostics.CreateScope("LabPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _labPlanRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LabPlanResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LabPlanResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _labPlanClientDiagnostics.CreateScope("LabPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _labPlanRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LabPlanResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Returns a list of all lab plans for a subscription and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans
        /// Operation Id: LabPlans_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LabPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LabPlanResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LabPlanResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _labPlanClientDiagnostics.CreateScope("LabPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _labPlanRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LabPlanResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LabPlanResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _labPlanClientDiagnostics.CreateScope("LabPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _labPlanRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LabPlanResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}
        /// Operation Id: LabPlans_Get
        /// </summary>
        /// <param name="labPlanName"> The name of the lab plan that uniquely identifies it within containing resource group. Used in resource URIs and in UI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labPlanName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string labPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labPlanName, nameof(labPlanName));

            using var scope = _labPlanClientDiagnostics.CreateScope("LabPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = await _labPlanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, labPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}
        /// Operation Id: LabPlans_Get
        /// </summary>
        /// <param name="labPlanName"> The name of the lab plan that uniquely identifies it within containing resource group. Used in resource URIs and in UI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labPlanName"/> is null. </exception>
        public virtual Response<bool> Exists(string labPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labPlanName, nameof(labPlanName));

            using var scope = _labPlanClientDiagnostics.CreateScope("LabPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = _labPlanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, labPlanName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LabPlanResource> IEnumerable<LabPlanResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LabPlanResource> IAsyncEnumerable<LabPlanResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
