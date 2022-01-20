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
using Azure.ResourceManager.AzureStackHCI;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AzureStackHCI.Models
{
    /// <summary> Update Extension for HCI cluster. </summary>
    public partial class ExtensionUpdateOperation : Operation<Extension>, IOperationSource<Extension>
    {
        private readonly OperationInternals<Extension> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of ExtensionUpdateOperation for mocking. </summary>
        protected ExtensionUpdateOperation()
        {
        }

        internal ExtensionUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<Extension>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.OriginalUri, "ExtensionUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override Extension Value => _operation.Value;

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
        public override ValueTask<Response<Extension>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Extension>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        Extension IOperationSource<Extension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ExtensionData.DeserializeExtensionData(document.RootElement);
            return new Extension(_operationBase, data);
        }

        async ValueTask<Extension> IOperationSource<Extension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ExtensionData.DeserializeExtensionData(document.RootElement);
            return new Extension(_operationBase, data);
        }
    }
}
