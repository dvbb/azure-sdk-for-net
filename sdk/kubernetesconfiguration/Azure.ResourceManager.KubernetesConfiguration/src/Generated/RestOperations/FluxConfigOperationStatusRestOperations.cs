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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.KubernetesConfiguration.Models;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    internal partial class FluxConfigOperationStatusRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of FluxConfigOperationStatusRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public FluxConfigOperationStatusRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2022-01-01-preview";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, Enum0 clusterRp, Enum1 clusterResourceName, string clusterName, string fluxConfigurationName, string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/", false);
            uri.AppendPath(clusterRp.ToString(), true);
            uri.AppendPath("/", false);
            uri.AppendPath(clusterResourceName.ToString(), true);
            uri.AppendPath("/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/", false);
            uri.AppendPath(fluxConfigurationName, true);
            uri.AppendPath("/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get Async Operation status. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters). </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="operationId"> operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="fluxConfigurationName"/>, or <paramref name="operationId"/> is null. </exception>
        public async Task<Response<OperationStatusResult>> GetAsync(string subscriptionId, string resourceGroupName, Enum0 clusterRp, Enum1 clusterResourceName, string clusterName, string fluxConfigurationName, string operationId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (fluxConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(fluxConfigurationName));
            }
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, clusterRp, clusterResourceName, clusterName, fluxConfigurationName, operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperationStatusResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OperationStatusResult.DeserializeOperationStatusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get Async Operation status. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters). </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="operationId"> operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="fluxConfigurationName"/>, or <paramref name="operationId"/> is null. </exception>
        public Response<OperationStatusResult> Get(string subscriptionId, string resourceGroupName, Enum0 clusterRp, Enum1 clusterResourceName, string clusterName, string fluxConfigurationName, string operationId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (fluxConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(fluxConfigurationName));
            }
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, clusterRp, clusterResourceName, clusterName, fluxConfigurationName, operationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperationStatusResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OperationStatusResult.DeserializeOperationStatusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
