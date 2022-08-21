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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A Class representing a WorkloadNetworkVmGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WorkloadNetworkVmGroupResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWorkloadNetworkVmGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="PrivateCloudResource" /> using the GetWorkloadNetworkVmGroup method.
    /// </summary>
    public partial class WorkloadNetworkVmGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WorkloadNetworkVmGroupResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string privateCloudName, string vmGroupId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkVmGroupWorkloadNetworksRestClient;
        private readonly WorkloadNetworkVmGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkVmGroupResource"/> class for mocking. </summary>
        protected WorkloadNetworkVmGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WorkloadNetworkVmGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WorkloadNetworkVmGroupResource(ArmClient client, WorkloadNetworkVmGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkVmGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WorkloadNetworkVmGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string workloadNetworkVmGroupWorkloadNetworksApiVersion);
            _workloadNetworkVmGroupWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkVmGroupWorkloadNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AVS/privateClouds/workloadNetworks/vmGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WorkloadNetworkVmGroupData Data
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
        /// Get a vm group by id in a private cloud workload network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}
        /// Operation Id: WorkloadNetworks_GetVMGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WorkloadNetworkVmGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkVmGroupWorkloadNetworksRestClient.GetVmGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVmGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a vm group by id in a private cloud workload network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}
        /// Operation Id: WorkloadNetworks_GetVMGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WorkloadNetworkVmGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupResource.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkVmGroupWorkloadNetworksRestClient.GetVmGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVmGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a vm group by id in a private cloud workload network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}
        /// Operation Id: WorkloadNetworks_DeleteVMGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _workloadNetworkVmGroupWorkloadNetworksRestClient.DeleteVmGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation(_workloadNetworkVmGroupWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateDeleteVmGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete a vm group by id in a private cloud workload network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}
        /// Operation Id: WorkloadNetworks_DeleteVMGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _workloadNetworkVmGroupWorkloadNetworksRestClient.DeleteVmGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                var operation = new AvsArmOperation(_workloadNetworkVmGroupWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateDeleteVmGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a vm group by id in a private cloud workload network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}
        /// Operation Id: WorkloadNetworks_UpdateVMGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> NSX VM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadNetworkVmGroupResource>> UpdateAsync(WaitUntil waitUntil, WorkloadNetworkVmGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _workloadNetworkVmGroupWorkloadNetworksRestClient.UpdateVmGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<WorkloadNetworkVmGroupResource>(new WorkloadNetworkVmGroupOperationSource(Client), _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateUpdateVmGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a vm group by id in a private cloud workload network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}
        /// Operation Id: WorkloadNetworks_UpdateVMGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> NSX VM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadNetworkVmGroupResource> Update(WaitUntil waitUntil, WorkloadNetworkVmGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupResource.Update");
            scope.Start();
            try
            {
                var response = _workloadNetworkVmGroupWorkloadNetworksRestClient.UpdateVmGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AvsArmOperation<WorkloadNetworkVmGroupResource>(new WorkloadNetworkVmGroupOperationSource(Client), _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateUpdateVmGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
