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
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> Schedules a new run based on the request parameters and add it to the run queue. </summary>
    public partial class RegistryScheduleRunOperation : Operation<RunData>, IOperationSource<RunData>
    {
        private readonly OperationInternals<RunData> _operation;

        /// <summary> Initializes a new instance of RegistryScheduleRunOperation for mocking. </summary>
        protected RegistryScheduleRunOperation()
        {
        }

        internal RegistryScheduleRunOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Azure.Core.Request request, Response response)
        {
            _operation = new OperationInternals<RunData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "RegistryScheduleRunOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override RunData Value => _operation.Value;

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
        public override ValueTask<Response<RunData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<RunData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        RunData IOperationSource<RunData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return RunData.DeserializeRunData(document.RootElement);
        }

        async ValueTask<RunData> IOperationSource<RunData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return RunData.DeserializeRunData(document.RootElement);
        }
    }
}
