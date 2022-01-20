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

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Check if the Application Configuration Service settings are valid. </summary>
    public partial class ConfigurationServiceResourceValidateOperation : Operation<ConfigurationServiceSettingsValidateResult>, IOperationSource<ConfigurationServiceSettingsValidateResult>
    {
        private readonly OperationInternals<ConfigurationServiceSettingsValidateResult> _operation;

        /// <summary> Initializes a new instance of ConfigurationServiceResourceValidateOperation for mocking. </summary>
        protected ConfigurationServiceResourceValidateOperation()
        {
        }

        internal ConfigurationServiceResourceValidateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ConfigurationServiceSettingsValidateResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ConfigurationServiceResourceValidateOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ConfigurationServiceSettingsValidateResult Value => _operation.Value;

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
        public override ValueTask<Response<ConfigurationServiceSettingsValidateResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ConfigurationServiceSettingsValidateResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ConfigurationServiceSettingsValidateResult IOperationSource<ConfigurationServiceSettingsValidateResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ConfigurationServiceSettingsValidateResult.DeserializeConfigurationServiceSettingsValidateResult(document.RootElement);
        }

        async ValueTask<ConfigurationServiceSettingsValidateResult> IOperationSource<ConfigurationServiceSettingsValidateResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ConfigurationServiceSettingsValidateResult.DeserializeConfigurationServiceSettingsValidateResult(document.RootElement);
        }
    }
}
