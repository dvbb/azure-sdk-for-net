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
using Azure.ResourceManager.ServiceFabricMesh;

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    /// <summary> Creates a new value of the specified secret resource. The name of the value is typically the version identifier. Once created the value cannot be changed. </summary>
    public partial class SecretValueResourceDescriptionCreateOrUpdateOperation : Operation<SecretValueResourceDescription>
    {
        private readonly OperationOrResponseInternals<SecretValueResourceDescription> _operation;

        /// <summary> Initializes a new instance of SecretValueResourceDescriptionCreateOrUpdateOperation for mocking. </summary>
        protected SecretValueResourceDescriptionCreateOrUpdateOperation()
        {
        }

        internal SecretValueResourceDescriptionCreateOrUpdateOperation(ArmResource operationsBase, Response<SecretValueResourceDescriptionData> response)
        {
            _operation = new OperationOrResponseInternals<SecretValueResourceDescription>(Response.FromValue(new SecretValueResourceDescription(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SecretValueResourceDescription Value => _operation.Value;

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
        public override ValueTask<Response<SecretValueResourceDescription>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SecretValueResourceDescription>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
