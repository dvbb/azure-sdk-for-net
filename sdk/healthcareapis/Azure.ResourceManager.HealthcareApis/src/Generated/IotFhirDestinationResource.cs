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

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A Class representing an IotFhirDestination along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="IotFhirDestinationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetIotFhirDestinationResource method.
    /// Otherwise you can get one from its parent resource <see cref="IotConnectorResource" /> using the GetIotFhirDestination method.
    /// </summary>
    public partial class IotFhirDestinationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="IotFhirDestinationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics;
        private readonly IotConnectorFhirDestinationRestOperations _iotFhirDestinationIotConnectorFhirDestinationRestClient;
        private readonly IotFhirDestinationData _data;

        /// <summary> Initializes a new instance of the <see cref="IotFhirDestinationResource"/> class for mocking. </summary>
        protected IotFhirDestinationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "IotFhirDestinationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal IotFhirDestinationResource(ArmClient client, IotFhirDestinationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="IotFhirDestinationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IotFhirDestinationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string iotFhirDestinationIotConnectorFhirDestinationApiVersion);
            _iotFhirDestinationIotConnectorFhirDestinationRestClient = new IotConnectorFhirDestinationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotFhirDestinationIotConnectorFhirDestinationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HealthcareApis/workspaces/iotconnectors/fhirdestinations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IotFhirDestinationData Data
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
        /// Gets the properties of the specified Iot Connector FHIR destination.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IotFhirDestinationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationResource.Get");
            scope.Start();
            try
            {
                var response = await _iotFhirDestinationIotConnectorFhirDestinationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotFhirDestinationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified Iot Connector FHIR destination.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IotFhirDestinationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationResource.Get");
            scope.Start();
            try
            {
                var response = _iotFhirDestinationIotConnectorFhirDestinationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotFhirDestinationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an IoT Connector FHIR destination.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationResource.Delete");
            scope.Start();
            try
            {
                var response = await _iotFhirDestinationIotConnectorFhirDestinationRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation(_iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics, Pipeline, _iotFhirDestinationIotConnectorFhirDestinationRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes an IoT Connector FHIR destination.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationResource.Delete");
            scope.Start();
            try
            {
                var response = _iotFhirDestinationIotConnectorFhirDestinationRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new HealthcareApisArmOperation(_iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics, Pipeline, _iotFhirDestinationIotConnectorFhirDestinationRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an IoT Connector FHIR destination resource with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating or updating an IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IotFhirDestinationResource>> UpdateAsync(WaitUntil waitUntil, IotFhirDestinationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationResource.Update");
            scope.Start();
            try
            {
                var response = await _iotFhirDestinationIotConnectorFhirDestinationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation<IotFhirDestinationResource>(new IotFhirDestinationOperationSource(Client), _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics, Pipeline, _iotFhirDestinationIotConnectorFhirDestinationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an IoT Connector FHIR destination resource with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating or updating an IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IotFhirDestinationResource> Update(WaitUntil waitUntil, IotFhirDestinationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationResource.Update");
            scope.Start();
            try
            {
                var response = _iotFhirDestinationIotConnectorFhirDestinationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new HealthcareApisArmOperation<IotFhirDestinationResource>(new IotFhirDestinationOperationSource(Client), _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics, Pipeline, _iotFhirDestinationIotConnectorFhirDestinationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
