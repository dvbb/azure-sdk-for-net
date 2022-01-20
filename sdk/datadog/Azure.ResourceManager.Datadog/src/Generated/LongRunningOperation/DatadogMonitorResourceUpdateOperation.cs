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
using Azure.ResourceManager.Datadog;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> Update a monitor resource. </summary>
    public partial class DatadogMonitorResourceUpdateOperation : Operation<DatadogMonitorResource>, IOperationSource<DatadogMonitorResource>
    {
        private readonly OperationInternals<DatadogMonitorResource> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of DatadogMonitorResourceUpdateOperation for mocking. </summary>
        protected DatadogMonitorResourceUpdateOperation()
        {
        }

        internal DatadogMonitorResourceUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DatadogMonitorResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DatadogMonitorResourceUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DatadogMonitorResource Value => _operation.Value;

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
        public override ValueTask<Response<DatadogMonitorResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DatadogMonitorResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DatadogMonitorResource IOperationSource<DatadogMonitorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DatadogMonitorResourceData.DeserializeDatadogMonitorResourceData(document.RootElement);
            return new DatadogMonitorResource(_operationBase, data);
        }

        async ValueTask<DatadogMonitorResource> IOperationSource<DatadogMonitorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DatadogMonitorResourceData.DeserializeDatadogMonitorResourceData(document.RootElement);
            return new DatadogMonitorResource(_operationBase, data);
        }
    }
}
