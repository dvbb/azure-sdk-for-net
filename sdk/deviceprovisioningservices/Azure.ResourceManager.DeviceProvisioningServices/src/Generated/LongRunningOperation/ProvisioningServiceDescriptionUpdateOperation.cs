// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Update an existing provisioning service&apos;s tags. to update other fields use the CreateOrUpdate method. </summary>
    public partial class ProvisioningServiceDescriptionUpdateOperation : Operation<ProvisioningServiceDescription>, IOperationSource<ProvisioningServiceDescription>
    {
        private readonly OperationInternals<ProvisioningServiceDescription> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of ProvisioningServiceDescriptionUpdateOperation for mocking. </summary>
        protected ProvisioningServiceDescriptionUpdateOperation()
        {
        }

        internal ProvisioningServiceDescriptionUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ProvisioningServiceDescription>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ProvisioningServiceDescriptionUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ProvisioningServiceDescription Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ProvisioningServiceDescription>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ProvisioningServiceDescription>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ProvisioningServiceDescription IOperationSource<ProvisioningServiceDescription>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ProvisioningServiceDescriptionData.DeserializeProvisioningServiceDescriptionData(document.RootElement);
            return new ProvisioningServiceDescription(_operationBase, data);
        }

        async ValueTask<ProvisioningServiceDescription> IOperationSource<ProvisioningServiceDescription>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ProvisioningServiceDescriptionData.DeserializeProvisioningServiceDescriptionData(document.RootElement);
            return new ProvisioningServiceDescription(_operationBase, data);
        }
    }
}
