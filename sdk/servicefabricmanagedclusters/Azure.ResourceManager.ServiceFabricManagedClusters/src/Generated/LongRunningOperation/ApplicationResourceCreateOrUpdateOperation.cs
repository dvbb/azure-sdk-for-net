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
using Azure.ResourceManager.ServiceFabricManagedClusters;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Create or update a Service Fabric managed application resource with the specified name. </summary>
    public partial class ApplicationResourceCreateOrUpdateOperation : Operation<ApplicationResource>, IOperationSource<ApplicationResource>
    {
        private readonly OperationInternals<ApplicationResource> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of ApplicationResourceCreateOrUpdateOperation for mocking. </summary>
        protected ApplicationResourceCreateOrUpdateOperation()
        {
        }

        internal ApplicationResourceCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ApplicationResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ApplicationResourceCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ApplicationResource Value => _operation.Value;

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
        public override ValueTask<Response<ApplicationResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ApplicationResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ApplicationResource IOperationSource<ApplicationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApplicationResourceData.DeserializeApplicationResourceData(document.RootElement);
            return new ApplicationResource(_operationBase, data);
        }

        async ValueTask<ApplicationResource> IOperationSource<ApplicationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApplicationResourceData.DeserializeApplicationResourceData(document.RootElement);
            return new ApplicationResource(_operationBase, data);
        }
    }
}
