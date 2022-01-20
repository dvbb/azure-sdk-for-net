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
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Adds a new customer communication to an Azure support ticket. </summary>
    public partial class CommunicationDetailsCreateOrUpdateOperation : Operation<CommunicationDetails>, IOperationSource<CommunicationDetails>
    {
        private readonly OperationInternals<CommunicationDetails> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of CommunicationDetailsCreateOrUpdateOperation for mocking. </summary>
        protected CommunicationDetailsCreateOrUpdateOperation()
        {
        }

        internal CommunicationDetailsCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<CommunicationDetails>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "CommunicationDetailsCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override CommunicationDetails Value => _operation.Value;

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
        public override ValueTask<Response<CommunicationDetails>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CommunicationDetails>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        CommunicationDetails IOperationSource<CommunicationDetails>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CommunicationDetailsData.DeserializeCommunicationDetailsData(document.RootElement);
            return new CommunicationDetails(_operationBase, data);
        }

        async ValueTask<CommunicationDetails> IOperationSource<CommunicationDetails>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CommunicationDetailsData.DeserializeCommunicationDetailsData(document.RootElement);
            return new CommunicationDetails(_operationBase, data);
        }
    }
}
