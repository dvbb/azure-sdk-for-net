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
using Azure.ResourceManager.Relay;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> Creates or updates an authorization rule for a hybrid connection. </summary>
    public partial class NamespaceHybridConnectionAuthorizationRuleCreateOrUpdateOperation : Operation<NamespaceHybridConnectionAuthorizationRule>
    {
        private readonly OperationOrResponseInternals<NamespaceHybridConnectionAuthorizationRule> _operation;

        /// <summary> Initializes a new instance of NamespaceHybridConnectionAuthorizationRuleCreateOrUpdateOperation for mocking. </summary>
        protected NamespaceHybridConnectionAuthorizationRuleCreateOrUpdateOperation()
        {
        }

        internal NamespaceHybridConnectionAuthorizationRuleCreateOrUpdateOperation(ArmResource operationsBase, Response<AuthorizationRuleData> response)
        {
            _operation = new OperationOrResponseInternals<NamespaceHybridConnectionAuthorizationRule>(Response.FromValue(new NamespaceHybridConnectionAuthorizationRule(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override NamespaceHybridConnectionAuthorizationRule Value => _operation.Value;

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
        public override ValueTask<Response<NamespaceHybridConnectionAuthorizationRule>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NamespaceHybridConnectionAuthorizationRule>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
