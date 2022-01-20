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
using Azure.ResourceManager.ContainerInstance.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ContainerInstance
{
    internal partial class ContainersRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of ContainersRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public ContainersRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2021-09-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListLogsRequest(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, int? tail, bool? timestamps)
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
            uri.AppendPath("/providers/Microsoft.ContainerInstance/containerGroups/", false);
            uri.AppendPath(containerGroupName, true);
            uri.AppendPath("/containers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/logs", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (tail != null)
            {
                uri.AppendQuery("tail", tail.Value, true);
            }
            if (timestamps != null)
            {
                uri.AppendQuery("timestamps", timestamps.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get the logs for a specified container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="tail"> The number of lines to show from the tail of the container instance log. If not provided, all available logs are shown up to 4mb. </param>
        /// <param name="timestamps"> If true, adds a timestamp at the beginning of every line of log output. If not provided, defaults to false. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/>, or <paramref name="containerName"/> is null. </exception>
        public async Task<Response<Logs>> ListLogsAsync(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, int? tail = null, bool? timestamps = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (containerGroupName == null)
            {
                throw new ArgumentNullException(nameof(containerGroupName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var message = CreateListLogsRequest(subscriptionId, resourceGroupName, containerGroupName, containerName, tail, timestamps);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Logs value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Logs.DeserializeLogs(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the logs for a specified container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="tail"> The number of lines to show from the tail of the container instance log. If not provided, all available logs are shown up to 4mb. </param>
        /// <param name="timestamps"> If true, adds a timestamp at the beginning of every line of log output. If not provided, defaults to false. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/>, or <paramref name="containerName"/> is null. </exception>
        public Response<Logs> ListLogs(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, int? tail = null, bool? timestamps = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (containerGroupName == null)
            {
                throw new ArgumentNullException(nameof(containerGroupName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var message = CreateListLogsRequest(subscriptionId, resourceGroupName, containerGroupName, containerName, tail, timestamps);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Logs value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Logs.DeserializeLogs(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateExecuteCommandRequest(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, ContainerExecRequest containerExecRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerInstance/containerGroups/", false);
            uri.AppendPath(containerGroupName, true);
            uri.AppendPath("/containers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/exec", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(containerExecRequest);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Executes a command for a specific container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="containerExecRequest"> The request for the exec command. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/>, <paramref name="containerName"/>, or <paramref name="containerExecRequest"/> is null. </exception>
        public async Task<Response<ContainerExecResponse>> ExecuteCommandAsync(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, ContainerExecRequest containerExecRequest, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (containerGroupName == null)
            {
                throw new ArgumentNullException(nameof(containerGroupName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (containerExecRequest == null)
            {
                throw new ArgumentNullException(nameof(containerExecRequest));
            }

            using var message = CreateExecuteCommandRequest(subscriptionId, resourceGroupName, containerGroupName, containerName, containerExecRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerExecResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ContainerExecResponse.DeserializeContainerExecResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Executes a command for a specific container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="containerExecRequest"> The request for the exec command. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/>, <paramref name="containerName"/>, or <paramref name="containerExecRequest"/> is null. </exception>
        public Response<ContainerExecResponse> ExecuteCommand(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, ContainerExecRequest containerExecRequest, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (containerGroupName == null)
            {
                throw new ArgumentNullException(nameof(containerGroupName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (containerExecRequest == null)
            {
                throw new ArgumentNullException(nameof(containerExecRequest));
            }

            using var message = CreateExecuteCommandRequest(subscriptionId, resourceGroupName, containerGroupName, containerName, containerExecRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerExecResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ContainerExecResponse.DeserializeContainerExecResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAttachRequest(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerInstance/containerGroups/", false);
            uri.AppendPath(containerGroupName, true);
            uri.AppendPath("/containers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/attach", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Attach to the output stream of a specific container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/>, or <paramref name="containerName"/> is null. </exception>
        public async Task<Response<ContainerAttachResponse>> AttachAsync(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (containerGroupName == null)
            {
                throw new ArgumentNullException(nameof(containerGroupName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var message = CreateAttachRequest(subscriptionId, resourceGroupName, containerGroupName, containerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerAttachResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ContainerAttachResponse.DeserializeContainerAttachResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Attach to the output stream of a specific container instance in a specified resource group and container group. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="containerName"> The name of the container instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="containerGroupName"/>, or <paramref name="containerName"/> is null. </exception>
        public Response<ContainerAttachResponse> Attach(string subscriptionId, string resourceGroupName, string containerGroupName, string containerName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (containerGroupName == null)
            {
                throw new ArgumentNullException(nameof(containerGroupName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var message = CreateAttachRequest(subscriptionId, resourceGroupName, containerGroupName, containerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerAttachResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ContainerAttachResponse.DeserializeContainerAttachResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
