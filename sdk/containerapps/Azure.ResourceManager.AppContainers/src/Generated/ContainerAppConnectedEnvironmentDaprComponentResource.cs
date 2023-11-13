// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A Class representing a ContainerAppConnectedEnvironmentDaprComponent along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ContainerAppConnectedEnvironmentDaprComponentResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetContainerAppConnectedEnvironmentDaprComponentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerAppConnectedEnvironmentResource" /> using the GetContainerAppConnectedEnvironmentDaprComponent method.
    /// </summary>
    public partial class ContainerAppConnectedEnvironmentDaprComponentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="connectedEnvironmentName"> The connectedEnvironmentName. </param>
        /// <param name="componentName"> The componentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string connectedEnvironmentName, string componentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics;
        private readonly ConnectedEnvironmentsDaprComponentsRestOperations _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient;
        private readonly ContainerAppDaprComponentData _data;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/> class for mocking. </summary>
        protected ContainerAppConnectedEnvironmentDaprComponentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ContainerAppConnectedEnvironmentDaprComponentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerAppConnectedEnvironmentDaprComponentResource(ArmClient client, ContainerAppDaprComponentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerAppConnectedEnvironmentDaprComponentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsApiVersion);
            _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient = new ConnectedEnvironmentsDaprComponentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.App/connectedEnvironments/daprComponents";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerAppDaprComponentData Data
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
        /// Get a dapr component.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerAppConnectedEnvironmentDaprComponentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentResource.Get");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentDaprComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a dapr component.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerAppConnectedEnvironmentDaprComponentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentResource.Get");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentDaprComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Dapr Component from a connected environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentResource.Delete");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation(response);
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
        /// Delete a Dapr Component from a connected environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentResource.Delete");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppContainersArmOperation(response);
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
        /// Creates or updates a Dapr Component in a connected environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Configuration details of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppConnectedEnvironmentDaprComponentResource>> UpdateAsync(WaitUntil waitUntil, ContainerAppDaprComponentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentResource.Update");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppConnectedEnvironmentDaprComponentResource>(Response.FromValue(new ContainerAppConnectedEnvironmentDaprComponentResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a Dapr Component in a connected environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Configuration details of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppConnectedEnvironmentDaprComponentResource> Update(WaitUntil waitUntil, ContainerAppDaprComponentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentResource.Update");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppConnectedEnvironmentDaprComponentResource>(Response.FromValue(new ContainerAppConnectedEnvironmentDaprComponentResource(Client, response), response.GetRawResponse()));
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
        /// List secrets for a dapr component
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}/listSecrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_ListSecrets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppDaprSecret" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppDaprSecret> GetSecretsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.CreateListSecretsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ContainerAppDaprSecret.DeserializeContainerAppDaprSecret, _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics, Pipeline, "ContainerAppConnectedEnvironmentDaprComponentResource.GetSecrets", "value", null, cancellationToken);
        }

        /// <summary>
        /// List secrets for a dapr component
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}/listSecrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_ListSecrets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppDaprSecret" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppDaprSecret> GetSecrets(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.CreateListSecretsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, ContainerAppDaprSecret.DeserializeContainerAppDaprSecret, _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics, Pipeline, "ContainerAppConnectedEnvironmentDaprComponentResource.GetSecrets", "value", null, cancellationToken);
        }
    }
}
