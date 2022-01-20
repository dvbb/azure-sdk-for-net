// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Creates or updates a managed Virtual Network. </summary>
    public partial class ManagedVirtualNetworkResourceCreateOrUpdateOperation : Operation<ManagedVirtualNetworkResource>
    {
        private readonly OperationOrResponseInternals<ManagedVirtualNetworkResource> _operation;

        /// <summary> Initializes a new instance of ManagedVirtualNetworkResourceCreateOrUpdateOperation for mocking. </summary>
        protected ManagedVirtualNetworkResourceCreateOrUpdateOperation()
        {
        }

        internal ManagedVirtualNetworkResourceCreateOrUpdateOperation(ArmResource operationsBase, Response<ManagedVirtualNetworkResourceData> response)
        {
            _operation = new OperationOrResponseInternals<ManagedVirtualNetworkResource>(Response.FromValue(new ManagedVirtualNetworkResource(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagedVirtualNetworkResource Value => _operation.Value;

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
        public override ValueTask<Response<ManagedVirtualNetworkResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagedVirtualNetworkResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
