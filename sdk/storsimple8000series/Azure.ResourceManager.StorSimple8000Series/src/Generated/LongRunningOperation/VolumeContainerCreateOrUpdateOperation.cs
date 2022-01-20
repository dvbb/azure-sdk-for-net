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
using Azure.ResourceManager.StorSimple8000Series;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    /// <summary> Creates or updates the volume container. </summary>
    public partial class VolumeContainerCreateOrUpdateOperation : Operation<VolumeContainer>, IOperationSource<VolumeContainer>
    {
        private readonly OperationInternals<VolumeContainer> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of VolumeContainerCreateOrUpdateOperation for mocking. </summary>
        protected VolumeContainerCreateOrUpdateOperation()
        {
        }

        internal VolumeContainerCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VolumeContainer>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VolumeContainerCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VolumeContainer Value => _operation.Value;

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
        public override ValueTask<Response<VolumeContainer>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VolumeContainer>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VolumeContainer IOperationSource<VolumeContainer>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VolumeContainerData.DeserializeVolumeContainerData(document.RootElement);
            return new VolumeContainer(_operationBase, data);
        }

        async ValueTask<VolumeContainer> IOperationSource<VolumeContainer>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VolumeContainerData.DeserializeVolumeContainerData(document.RootElement);
            return new VolumeContainer(_operationBase, data);
        }
    }
}
