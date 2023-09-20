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
using Azure.ResourceManager.DefenderEasm.Models;

namespace Azure.ResourceManager.DefenderEasm
{
    /// <summary>
    /// A Class representing an EasmLabel along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="EasmLabelResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetEasmLabelResource method.
    /// Otherwise you can get one from its parent resource <see cref="EasmWorkspaceResource" /> using the GetEasmLabel method.
    /// </summary>
    public partial class EasmLabelResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EasmLabelResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string labelName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _easmLabelLabelsClientDiagnostics;
        private readonly LabelsRestOperations _easmLabelLabelsRestClient;
        private readonly EasmLabelData _data;

        /// <summary> Initializes a new instance of the <see cref="EasmLabelResource"/> class for mocking. </summary>
        protected EasmLabelResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EasmLabelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EasmLabelResource(ArmClient client, EasmLabelData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EasmLabelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EasmLabelResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _easmLabelLabelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DefenderEasm", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string easmLabelLabelsApiVersion);
            _easmLabelLabelsRestClient = new LabelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, easmLabelLabelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Easm/workspaces/labels";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EasmLabelData Data
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
        /// Returns a label in the given workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_GetByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EasmLabelResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelResource.Get");
            scope.Start();
            try
            {
                var response = await _easmLabelLabelsRestClient.GetByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EasmLabelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a label in the given workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_GetByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EasmLabelResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelResource.Get");
            scope.Start();
            try
            {
                var response = _easmLabelLabelsRestClient.GetByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EasmLabelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Label.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelResource.Delete");
            scope.Start();
            try
            {
                var response = await _easmLabelLabelsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DefenderEasmArmOperation(_easmLabelLabelsClientDiagnostics, Pipeline, _easmLabelLabelsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Delete a Label.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelResource.Delete");
            scope.Start();
            try
            {
                var response = _easmLabelLabelsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DefenderEasmArmOperation(_easmLabelLabelsClientDiagnostics, Pipeline, _easmLabelLabelsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Update a Label.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Label patch details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<EasmLabelResource>> UpdateAsync(EasmLabelPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelResource.Update");
            scope.Start();
            try
            {
                var response = await _easmLabelLabelsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new EasmLabelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a Label.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}/labels/{labelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labels_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Label patch details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<EasmLabelResource> Update(EasmLabelPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _easmLabelLabelsClientDiagnostics.CreateScope("EasmLabelResource.Update");
            scope.Start();
            try
            {
                var response = _easmLabelLabelsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new EasmLabelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
