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
using Azure.ResourceManager.ServiceFabricMesh.Models;

namespace Azure.ResourceManager.ServiceFabricMesh
{
    internal partial class CodePackageRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of CodePackageRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public CodePackageRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2018-09-01-preview";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetContainerLogsRequest(string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName, string replicaName, string codePackageName, int? tail)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabricMesh/applications/", false);
            uri.AppendPath(applicationResourceName, false);
            uri.AppendPath("/services/", false);
            uri.AppendPath(serviceResourceName, false);
            uri.AppendPath("/replicas/", false);
            uri.AppendPath(replicaName, false);
            uri.AppendPath("/codePackages/", false);
            uri.AppendPath(codePackageName, true);
            uri.AppendPath("/logs", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (tail != null)
            {
                uri.AppendQuery("tail", tail.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the logs for the container of the specified code package of the service replica. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="applicationResourceName"> The identity of the application. </param>
        /// <param name="serviceResourceName"> The identity of the service. </param>
        /// <param name="replicaName"> Service Fabric replica name. </param>
        /// <param name="codePackageName"> The name of code package of the service. </param>
        /// <param name="tail"> Number of lines to show from the end of the logs. Default is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationResourceName"/>, <paramref name="serviceResourceName"/>, <paramref name="replicaName"/>, or <paramref name="codePackageName"/> is null. </exception>
        public async Task<Response<ContainerLogs>> GetContainerLogsAsync(string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName, string replicaName, string codePackageName, int? tail = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationResourceName == null)
            {
                throw new ArgumentNullException(nameof(applicationResourceName));
            }
            if (serviceResourceName == null)
            {
                throw new ArgumentNullException(nameof(serviceResourceName));
            }
            if (replicaName == null)
            {
                throw new ArgumentNullException(nameof(replicaName));
            }
            if (codePackageName == null)
            {
                throw new ArgumentNullException(nameof(codePackageName));
            }

            using var message = CreateGetContainerLogsRequest(subscriptionId, resourceGroupName, applicationResourceName, serviceResourceName, replicaName, codePackageName, tail);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerLogs value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ContainerLogs.DeserializeContainerLogs(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the logs for the container of the specified code package of the service replica. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="applicationResourceName"> The identity of the application. </param>
        /// <param name="serviceResourceName"> The identity of the service. </param>
        /// <param name="replicaName"> Service Fabric replica name. </param>
        /// <param name="codePackageName"> The name of code package of the service. </param>
        /// <param name="tail"> Number of lines to show from the end of the logs. Default is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationResourceName"/>, <paramref name="serviceResourceName"/>, <paramref name="replicaName"/>, or <paramref name="codePackageName"/> is null. </exception>
        public Response<ContainerLogs> GetContainerLogs(string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName, string replicaName, string codePackageName, int? tail = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationResourceName == null)
            {
                throw new ArgumentNullException(nameof(applicationResourceName));
            }
            if (serviceResourceName == null)
            {
                throw new ArgumentNullException(nameof(serviceResourceName));
            }
            if (replicaName == null)
            {
                throw new ArgumentNullException(nameof(replicaName));
            }
            if (codePackageName == null)
            {
                throw new ArgumentNullException(nameof(codePackageName));
            }

            using var message = CreateGetContainerLogsRequest(subscriptionId, resourceGroupName, applicationResourceName, serviceResourceName, replicaName, codePackageName, tail);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerLogs value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ContainerLogs.DeserializeContainerLogs(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
