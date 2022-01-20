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
using Azure.ResourceManager.AppPlatform;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Create a new Binding or update an exiting Binding. </summary>
    public partial class BindingResourceCreateOrUpdateOperation : Operation<BindingResource>, IOperationSource<BindingResource>
    {
        private readonly OperationInternals<BindingResource> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of BindingResourceCreateOrUpdateOperation for mocking. </summary>
        protected BindingResourceCreateOrUpdateOperation()
        {
        }

        internal BindingResourceCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<BindingResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "BindingResourceCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override BindingResource Value => _operation.Value;

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
        public override ValueTask<Response<BindingResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BindingResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        BindingResource IOperationSource<BindingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BindingResourceData.DeserializeBindingResourceData(document.RootElement);
            return new BindingResource(_operationBase, data);
        }

        async ValueTask<BindingResource> IOperationSource<BindingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BindingResourceData.DeserializeBindingResourceData(document.RootElement);
            return new BindingResource(_operationBase, data);
        }
    }
}
