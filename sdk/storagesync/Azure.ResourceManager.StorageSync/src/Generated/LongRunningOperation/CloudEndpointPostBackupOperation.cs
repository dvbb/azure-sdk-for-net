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

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Post Backup a given CloudEndpoint. </summary>
    public partial class CloudEndpointPostBackupOperation : Operation<PostBackupResponse>, IOperationSource<PostBackupResponse>
    {
        private readonly OperationInternals<PostBackupResponse> _operation;

        /// <summary> Initializes a new instance of CloudEndpointPostBackupOperation for mocking. </summary>
        protected CloudEndpointPostBackupOperation()
        {
        }

        internal CloudEndpointPostBackupOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<PostBackupResponse>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "CloudEndpointPostBackupOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override PostBackupResponse Value => _operation.Value;

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
        public override ValueTask<Response<PostBackupResponse>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PostBackupResponse>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PostBackupResponse IOperationSource<PostBackupResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return PostBackupResponse.DeserializePostBackupResponse(document.RootElement);
        }

        async ValueTask<PostBackupResponse> IOperationSource<PostBackupResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return PostBackupResponse.DeserializePostBackupResponse(document.RootElement);
        }
    }
}
