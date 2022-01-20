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
using Azure.ResourceManager.PrivateDns;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> Creates or updates a record set within a Private DNS zone. </summary>
    public partial class PrivateDnsZoneCNAMECreateOrUpdateOperation : Operation<PrivateDnsZoneCNAME>
    {
        private readonly OperationOrResponseInternals<PrivateDnsZoneCNAME> _operation;

        /// <summary> Initializes a new instance of PrivateDnsZoneCNAMECreateOrUpdateOperation for mocking. </summary>
        protected PrivateDnsZoneCNAMECreateOrUpdateOperation()
        {
        }

        internal PrivateDnsZoneCNAMECreateOrUpdateOperation(ArmResource operationsBase, Response<RecordSetData> response)
        {
            _operation = new OperationOrResponseInternals<PrivateDnsZoneCNAME>(Response.FromValue(new PrivateDnsZoneCNAME(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override PrivateDnsZoneCNAME Value => _operation.Value;

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
        public override ValueTask<Response<PrivateDnsZoneCNAME>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PrivateDnsZoneCNAME>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
