// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Chaos;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Create or update a Capability resource that extends a Target resource. </summary>
    public partial class CapabilityCreateOrUpdateOperation : Operation<Capability>
    {
        private readonly OperationOrResponseInternals<Capability> _operation;

        /// <summary> Initializes a new instance of CapabilityCreateOrUpdateOperation for mocking. </summary>
        protected CapabilityCreateOrUpdateOperation()
        {
        }

        internal CapabilityCreateOrUpdateOperation(ArmResource operationsBase, Response<CapabilityData> response)
        {
            _operation = new OperationOrResponseInternals<Capability>(Response.FromValue(new Capability(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override Capability Value => _operation.Value;

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
        public override ValueTask<Response<Capability>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Capability>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
