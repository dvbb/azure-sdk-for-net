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
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Create a new StorageSyncService. </summary>
    public partial class StorageSyncServiceCreateOrUpdateOperation : Operation<StorageSyncService>, IOperationSource<StorageSyncService>
    {
        private readonly OperationInternals<StorageSyncService> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of StorageSyncServiceCreateOrUpdateOperation for mocking. </summary>
        protected StorageSyncServiceCreateOrUpdateOperation()
        {
        }

        internal StorageSyncServiceCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<StorageSyncService>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "StorageSyncServiceCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override StorageSyncService Value => _operation.Value;

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
        public override ValueTask<Response<StorageSyncService>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<StorageSyncService>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        StorageSyncService IOperationSource<StorageSyncService>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StorageSyncServiceData.DeserializeStorageSyncServiceData(document.RootElement);
            return new StorageSyncService(_operationBase, data);
        }

        async ValueTask<StorageSyncService> IOperationSource<StorageSyncService>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StorageSyncServiceData.DeserializeStorageSyncServiceData(document.RootElement);
            return new StorageSyncService(_operationBase, data);
        }
    }
}
