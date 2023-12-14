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
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeAnalytics.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary>
    /// A Class representing a DataLakeAnalyticsComputePolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DataLakeAnalyticsComputePolicyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDataLakeAnalyticsComputePolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataLakeAnalyticsAccountResource"/> using the GetDataLakeAnalyticsComputePolicy method.
    /// </summary>
    public partial class DataLakeAnalyticsComputePolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataLakeAnalyticsComputePolicyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="computePolicyName"> The computePolicyName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string computePolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics;
        private readonly ComputePoliciesRestOperations _dataLakeAnalyticsComputePolicyComputePoliciesRestClient;
        private readonly DataLakeAnalyticsComputePolicyData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataLakeAnalytics/accounts/computePolicies";

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsComputePolicyResource"/> class for mocking. </summary>
        protected DataLakeAnalyticsComputePolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsComputePolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataLakeAnalyticsComputePolicyResource(ArmClient client, DataLakeAnalyticsComputePolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsComputePolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataLakeAnalyticsComputePolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataLakeAnalyticsComputePolicyComputePoliciesApiVersion);
            _dataLakeAnalyticsComputePolicyComputePoliciesRestClient = new ComputePoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeAnalyticsComputePolicyComputePoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataLakeAnalyticsComputePolicyData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified Data Lake Analytics compute policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataLakeAnalyticsComputePolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsComputePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Analytics compute policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataLakeAnalyticsComputePolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyResource.Get");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsComputePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified compute policy from the specified Data Lake Analytics account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeAnalyticsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified compute policy from the specified Data Lake Analytics account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyResource.Delete");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DataLakeAnalyticsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the specified compute policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Parameters supplied to update the compute policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<DataLakeAnalyticsComputePolicyResource>> UpdateAsync(DataLakeAnalyticsComputePolicyPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DataLakeAnalyticsComputePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the specified compute policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Parameters supplied to update the compute policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<DataLakeAnalyticsComputePolicyResource> Update(DataLakeAnalyticsComputePolicyPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyResource.Update");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new DataLakeAnalyticsComputePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
