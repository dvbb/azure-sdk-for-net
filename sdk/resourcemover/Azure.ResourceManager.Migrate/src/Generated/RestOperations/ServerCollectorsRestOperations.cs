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
using Azure.ResourceManager.Migrate.Models;

namespace Azure.ResourceManager.Migrate
{
    internal partial class ServerCollectorsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of ServerCollectorsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public ServerCollectorsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2019-10-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListByProjectRequest(string subscriptionId, string resourceGroupName, string projectName)
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
            uri.AppendPath("/providers/Microsoft.Migrate/assessmentProjects/", false);
            uri.AppendPath(projectName, true);
            uri.AppendPath("/servercollectors", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get a list of Server collector. </summary>
        /// <param name="subscriptionId"> Azure Subscription Id in which project was created. </param>
        /// <param name="resourceGroupName"> Name of the Azure Resource Group that project is part of. </param>
        /// <param name="projectName"> Name of the Azure Migrate project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="projectName"/> is null. </exception>
        public async Task<Response<ServerCollectorList>> ListByProjectAsync(string subscriptionId, string resourceGroupName, string projectName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }

            using var message = CreateListByProjectRequest(subscriptionId, resourceGroupName, projectName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServerCollectorList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServerCollectorList.DeserializeServerCollectorList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a list of Server collector. </summary>
        /// <param name="subscriptionId"> Azure Subscription Id in which project was created. </param>
        /// <param name="resourceGroupName"> Name of the Azure Resource Group that project is part of. </param>
        /// <param name="projectName"> Name of the Azure Migrate project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="projectName"/> is null. </exception>
        public Response<ServerCollectorList> ListByProject(string subscriptionId, string resourceGroupName, string projectName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }

            using var message = CreateListByProjectRequest(subscriptionId, resourceGroupName, projectName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServerCollectorList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServerCollectorList.DeserializeServerCollectorList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string projectName, string serverCollectorName)
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
            uri.AppendPath("/providers/Microsoft.Migrate/assessmentProjects/", false);
            uri.AppendPath(projectName, true);
            uri.AppendPath("/servercollectors/", false);
            uri.AppendPath(serverCollectorName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get a Server collector. </summary>
        /// <param name="subscriptionId"> Azure Subscription Id in which project was created. </param>
        /// <param name="resourceGroupName"> Name of the Azure Resource Group that project is part of. </param>
        /// <param name="projectName"> Name of the Azure Migrate project. </param>
        /// <param name="serverCollectorName"> Unique name of a Server collector within a project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, or <paramref name="serverCollectorName"/> is null. </exception>
        public async Task<Response<ServerCollectorData>> GetAsync(string subscriptionId, string resourceGroupName, string projectName, string serverCollectorName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (serverCollectorName == null)
            {
                throw new ArgumentNullException(nameof(serverCollectorName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, projectName, serverCollectorName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServerCollectorData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServerCollectorData.DeserializeServerCollectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ServerCollectorData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a Server collector. </summary>
        /// <param name="subscriptionId"> Azure Subscription Id in which project was created. </param>
        /// <param name="resourceGroupName"> Name of the Azure Resource Group that project is part of. </param>
        /// <param name="projectName"> Name of the Azure Migrate project. </param>
        /// <param name="serverCollectorName"> Unique name of a Server collector within a project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, or <paramref name="serverCollectorName"/> is null. </exception>
        public Response<ServerCollectorData> Get(string subscriptionId, string resourceGroupName, string projectName, string serverCollectorName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (serverCollectorName == null)
            {
                throw new ArgumentNullException(nameof(serverCollectorName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, projectName, serverCollectorName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServerCollectorData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServerCollectorData.DeserializeServerCollectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ServerCollectorData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string projectName, string serverCollectorName, ServerCollectorData collectorBody)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Migrate/assessmentProjects/", false);
            uri.AppendPath(projectName, true);
            uri.AppendPath("/servercollectors/", false);
            uri.AppendPath(serverCollectorName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (collectorBody != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(collectorBody);
                request.Content = content;
            }
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Create or Update Server collector. </summary>
        /// <param name="subscriptionId"> Azure Subscription Id in which project was created. </param>
        /// <param name="resourceGroupName"> Name of the Azure Resource Group that project is part of. </param>
        /// <param name="projectName"> Name of the Azure Migrate project. </param>
        /// <param name="serverCollectorName"> Unique name of a Server collector within a project. </param>
        /// <param name="collectorBody"> New or Updated Server collector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, or <paramref name="serverCollectorName"/> is null. </exception>
        public async Task<Response<ServerCollectorData>> CreateAsync(string subscriptionId, string resourceGroupName, string projectName, string serverCollectorName, ServerCollectorData collectorBody = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (serverCollectorName == null)
            {
                throw new ArgumentNullException(nameof(serverCollectorName));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, projectName, serverCollectorName, collectorBody);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ServerCollectorData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServerCollectorData.DeserializeServerCollectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or Update Server collector. </summary>
        /// <param name="subscriptionId"> Azure Subscription Id in which project was created. </param>
        /// <param name="resourceGroupName"> Name of the Azure Resource Group that project is part of. </param>
        /// <param name="projectName"> Name of the Azure Migrate project. </param>
        /// <param name="serverCollectorName"> Unique name of a Server collector within a project. </param>
        /// <param name="collectorBody"> New or Updated Server collector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, or <paramref name="serverCollectorName"/> is null. </exception>
        public Response<ServerCollectorData> Create(string subscriptionId, string resourceGroupName, string projectName, string serverCollectorName, ServerCollectorData collectorBody = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (serverCollectorName == null)
            {
                throw new ArgumentNullException(nameof(serverCollectorName));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, projectName, serverCollectorName, collectorBody);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ServerCollectorData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServerCollectorData.DeserializeServerCollectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string projectName, string serverCollectorName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Migrate/assessmentProjects/", false);
            uri.AppendPath(projectName, true);
            uri.AppendPath("/servercollectors/", false);
            uri.AppendPath(serverCollectorName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Delete a Server collector from the project. </summary>
        /// <param name="subscriptionId"> Azure Subscription Id in which project was created. </param>
        /// <param name="resourceGroupName"> Name of the Azure Resource Group that project is part of. </param>
        /// <param name="projectName"> Name of the Azure Migrate project. </param>
        /// <param name="serverCollectorName"> Unique name of a Server collector within a project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, or <paramref name="serverCollectorName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string projectName, string serverCollectorName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (serverCollectorName == null)
            {
                throw new ArgumentNullException(nameof(serverCollectorName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, projectName, serverCollectorName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete a Server collector from the project. </summary>
        /// <param name="subscriptionId"> Azure Subscription Id in which project was created. </param>
        /// <param name="resourceGroupName"> Name of the Azure Resource Group that project is part of. </param>
        /// <param name="projectName"> Name of the Azure Migrate project. </param>
        /// <param name="serverCollectorName"> Unique name of a Server collector within a project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, or <paramref name="serverCollectorName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string projectName, string serverCollectorName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (serverCollectorName == null)
            {
                throw new ArgumentNullException(nameof(serverCollectorName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, projectName, serverCollectorName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
