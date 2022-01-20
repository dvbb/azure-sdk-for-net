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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> Creates a task run for a container registry with the specified parameters. </summary>
    public partial class TaskRunCreateOrUpdateOperation : Operation<TaskRun>, IOperationSource<TaskRun>
    {
        private readonly OperationInternals<TaskRun> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of TaskRunCreateOrUpdateOperation for mocking. </summary>
        protected TaskRunCreateOrUpdateOperation()
        {
        }

        internal TaskRunCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Azure.Core.Request request, Response response)
        {
            _operation = new OperationInternals<TaskRun>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "TaskRunCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override TaskRun Value => _operation.Value;

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
        public override ValueTask<Response<TaskRun>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<TaskRun>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        TaskRun IOperationSource<TaskRun>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = TaskRunData.DeserializeTaskRunData(document.RootElement);
            return new TaskRun(_operationBase, data);
        }

        async ValueTask<TaskRun> IOperationSource<TaskRun>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = TaskRunData.DeserializeTaskRunData(document.RootElement);
            return new TaskRun(_operationBase, data);
        }
    }
}
