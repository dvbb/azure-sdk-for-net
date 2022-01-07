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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Updates a database geo backup policy. </summary>
    public partial class GeoBackupPolicyCreateOrUpdateOperation : Operation<GeoBackupPolicy>
    {
        private readonly OperationOrResponseInternals<GeoBackupPolicy> _operation;

        /// <summary> Initializes a new instance of GeoBackupPolicyCreateOrUpdateOperation for mocking. </summary>
        protected GeoBackupPolicyCreateOrUpdateOperation()
        {
        }

        internal GeoBackupPolicyCreateOrUpdateOperation(ArmResource operationsBase, Response<GeoBackupPolicyData> response)
        {
            _operation = new OperationOrResponseInternals<GeoBackupPolicy>(Response.FromValue(new GeoBackupPolicy(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override GeoBackupPolicy Value => _operation.Value;

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
        public override ValueTask<Response<GeoBackupPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<GeoBackupPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
