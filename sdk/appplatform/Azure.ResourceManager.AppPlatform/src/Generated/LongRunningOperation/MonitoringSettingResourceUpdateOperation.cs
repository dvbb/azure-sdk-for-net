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
    /// <summary> Update the Monitoring Setting. </summary>
    public partial class MonitoringSettingResourceUpdateOperation : Operation<MonitoringSettingResource>, IOperationSource<MonitoringSettingResource>
    {
        private readonly OperationInternals<MonitoringSettingResource> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of MonitoringSettingResourceUpdateOperation for mocking. </summary>
        protected MonitoringSettingResourceUpdateOperation()
        {
        }

        internal MonitoringSettingResourceUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<MonitoringSettingResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "MonitoringSettingResourceUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override MonitoringSettingResource Value => _operation.Value;

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
        public override ValueTask<Response<MonitoringSettingResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<MonitoringSettingResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        MonitoringSettingResource IOperationSource<MonitoringSettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MonitoringSettingResourceData.DeserializeMonitoringSettingResourceData(document.RootElement);
            return new MonitoringSettingResource(_operationBase, data);
        }

        async ValueTask<MonitoringSettingResource> IOperationSource<MonitoringSettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MonitoringSettingResourceData.DeserializeMonitoringSettingResourceData(document.RootElement);
            return new MonitoringSettingResource(_operationBase, data);
        }
    }
}
