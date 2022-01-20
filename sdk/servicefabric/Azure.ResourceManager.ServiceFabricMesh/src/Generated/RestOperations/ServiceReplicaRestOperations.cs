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
    internal partial class ServiceReplicaRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of ServiceReplicaRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public ServiceReplicaRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2018-09-01-preview";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName, string replicaName)
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
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the information about the service replica with the given name. The information include the description and other properties of the service replica. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="applicationResourceName"> The identity of the application. </param>
        /// <param name="serviceResourceName"> The identity of the service. </param>
        /// <param name="replicaName"> Service Fabric replica name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationResourceName"/>, <paramref name="serviceResourceName"/>, or <paramref name="replicaName"/> is null. </exception>
        public async Task<Response<ServiceReplicaDescription>> GetAsync(string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName, string replicaName, CancellationToken cancellationToken = default)
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

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, applicationResourceName, serviceResourceName, replicaName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceReplicaDescription value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceReplicaDescription.DeserializeServiceReplicaDescription(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the information about the service replica with the given name. The information include the description and other properties of the service replica. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="applicationResourceName"> The identity of the application. </param>
        /// <param name="serviceResourceName"> The identity of the service. </param>
        /// <param name="replicaName"> Service Fabric replica name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationResourceName"/>, <paramref name="serviceResourceName"/>, or <paramref name="replicaName"/> is null. </exception>
        public Response<ServiceReplicaDescription> Get(string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName, string replicaName, CancellationToken cancellationToken = default)
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

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, applicationResourceName, serviceResourceName, replicaName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceReplicaDescription value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceReplicaDescription.DeserializeServiceReplicaDescription(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName)
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
            uri.AppendPath("/replicas", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the information about all replicas of a given service of an application. The information includes the runtime properties of the replica instance. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="applicationResourceName"> The identity of the application. </param>
        /// <param name="serviceResourceName"> The identity of the service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationResourceName"/>, or <paramref name="serviceResourceName"/> is null. </exception>
        public async Task<Response<ServiceReplicaDescriptionList>> ListAsync(string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName, CancellationToken cancellationToken = default)
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

            using var message = CreateListRequest(subscriptionId, resourceGroupName, applicationResourceName, serviceResourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceReplicaDescriptionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceReplicaDescriptionList.DeserializeServiceReplicaDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the information about all replicas of a given service of an application. The information includes the runtime properties of the replica instance. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="applicationResourceName"> The identity of the application. </param>
        /// <param name="serviceResourceName"> The identity of the service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationResourceName"/>, or <paramref name="serviceResourceName"/> is null. </exception>
        public Response<ServiceReplicaDescriptionList> List(string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName, CancellationToken cancellationToken = default)
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

            using var message = CreateListRequest(subscriptionId, resourceGroupName, applicationResourceName, serviceResourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceReplicaDescriptionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceReplicaDescriptionList.DeserializeServiceReplicaDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the information about all replicas of a given service of an application. The information includes the runtime properties of the replica instance. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="applicationResourceName"> The identity of the application. </param>
        /// <param name="serviceResourceName"> The identity of the service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationResourceName"/>, or <paramref name="serviceResourceName"/> is null. </exception>
        public async Task<Response<ServiceReplicaDescriptionList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
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

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, applicationResourceName, serviceResourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceReplicaDescriptionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceReplicaDescriptionList.DeserializeServiceReplicaDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the information about all replicas of a given service of an application. The information includes the runtime properties of the replica instance. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="applicationResourceName"> The identity of the application. </param>
        /// <param name="serviceResourceName"> The identity of the service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationResourceName"/>, or <paramref name="serviceResourceName"/> is null. </exception>
        public Response<ServiceReplicaDescriptionList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string applicationResourceName, string serviceResourceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
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

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, applicationResourceName, serviceResourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceReplicaDescriptionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceReplicaDescriptionList.DeserializeServiceReplicaDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
