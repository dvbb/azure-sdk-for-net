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
    internal partial class SecretRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of SecretRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public SecretRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2018-09-01-preview";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string secretResourceName, SecretResourceDescriptionData secretResourceDescription)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabricMesh/secrets/", false);
            uri.AppendPath(secretResourceName, false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(secretResourceDescription);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates a secret resource with the specified name, description and properties. If a secret resource with the same name exists, then it is updated with the specified description and properties. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="secretResourceName"> The name of the secret resource. </param>
        /// <param name="secretResourceDescription"> Description for creating a secret resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="secretResourceName"/>, or <paramref name="secretResourceDescription"/> is null. </exception>
        public async Task<Response<SecretResourceDescriptionData>> CreateAsync(string subscriptionId, string resourceGroupName, string secretResourceName, SecretResourceDescriptionData secretResourceDescription, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (secretResourceName == null)
            {
                throw new ArgumentNullException(nameof(secretResourceName));
            }
            if (secretResourceDescription == null)
            {
                throw new ArgumentNullException(nameof(secretResourceDescription));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, secretResourceName, secretResourceDescription);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SecretResourceDescriptionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecretResourceDescriptionData.DeserializeSecretResourceDescriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                    return Response.FromValue((SecretResourceDescriptionData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a secret resource with the specified name, description and properties. If a secret resource with the same name exists, then it is updated with the specified description and properties. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="secretResourceName"> The name of the secret resource. </param>
        /// <param name="secretResourceDescription"> Description for creating a secret resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="secretResourceName"/>, or <paramref name="secretResourceDescription"/> is null. </exception>
        public Response<SecretResourceDescriptionData> Create(string subscriptionId, string resourceGroupName, string secretResourceName, SecretResourceDescriptionData secretResourceDescription, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (secretResourceName == null)
            {
                throw new ArgumentNullException(nameof(secretResourceName));
            }
            if (secretResourceDescription == null)
            {
                throw new ArgumentNullException(nameof(secretResourceDescription));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, secretResourceName, secretResourceDescription);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SecretResourceDescriptionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecretResourceDescriptionData.DeserializeSecretResourceDescriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                    return Response.FromValue((SecretResourceDescriptionData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string secretResourceName)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabricMesh/secrets/", false);
            uri.AppendPath(secretResourceName, false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the information about the secret resource with the given name. The information include the description and other properties of the secret. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="secretResourceName"> The name of the secret resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="secretResourceName"/> is null. </exception>
        public async Task<Response<SecretResourceDescriptionData>> GetAsync(string subscriptionId, string resourceGroupName, string secretResourceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (secretResourceName == null)
            {
                throw new ArgumentNullException(nameof(secretResourceName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, secretResourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretResourceDescriptionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecretResourceDescriptionData.DeserializeSecretResourceDescriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecretResourceDescriptionData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the information about the secret resource with the given name. The information include the description and other properties of the secret. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="secretResourceName"> The name of the secret resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="secretResourceName"/> is null. </exception>
        public Response<SecretResourceDescriptionData> Get(string subscriptionId, string resourceGroupName, string secretResourceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (secretResourceName == null)
            {
                throw new ArgumentNullException(nameof(secretResourceName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, secretResourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretResourceDescriptionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecretResourceDescriptionData.DeserializeSecretResourceDescriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecretResourceDescriptionData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string secretResourceName)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabricMesh/secrets/", false);
            uri.AppendPath(secretResourceName, false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes the secret resource identified by the name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="secretResourceName"> The name of the secret resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="secretResourceName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string secretResourceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (secretResourceName == null)
            {
                throw new ArgumentNullException(nameof(secretResourceName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, secretResourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the secret resource identified by the name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="secretResourceName"> The name of the secret resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="secretResourceName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string secretResourceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (secretResourceName == null)
            {
                throw new ArgumentNullException(nameof(secretResourceName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, secretResourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupRequest(string subscriptionId, string resourceGroupName)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabricMesh/secrets", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the information about all secret resources in a given resource group. The information include the description and other properties of the Secret. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<SecretResourceDescriptionList>> ListByResourceGroupAsync(string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(subscriptionId, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretResourceDescriptionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecretResourceDescriptionList.DeserializeSecretResourceDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the information about all secret resources in a given resource group. The information include the description and other properties of the Secret. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public Response<SecretResourceDescriptionList> ListByResourceGroup(string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(subscriptionId, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretResourceDescriptionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecretResourceDescriptionList.DeserializeSecretResourceDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySubscriptionRequest(string subscriptionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ServiceFabricMesh/secrets", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the information about all secret resources in a given resource group. The information include the description and other properties of the secret. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public async Task<Response<SecretResourceDescriptionList>> ListBySubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreateListBySubscriptionRequest(subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretResourceDescriptionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecretResourceDescriptionList.DeserializeSecretResourceDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the information about all secret resources in a given resource group. The information include the description and other properties of the secret. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public Response<SecretResourceDescriptionList> ListBySubscription(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreateListBySubscriptionRequest(subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretResourceDescriptionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecretResourceDescriptionList.DeserializeSecretResourceDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName)
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

        /// <summary> Gets the information about all secret resources in a given resource group. The information include the description and other properties of the Secret. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, or <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<SecretResourceDescriptionList>> ListByResourceGroupNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
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

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretResourceDescriptionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecretResourceDescriptionList.DeserializeSecretResourceDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the information about all secret resources in a given resource group. The information include the description and other properties of the Secret. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> Azure resource group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, or <paramref name="resourceGroupName"/> is null. </exception>
        public Response<SecretResourceDescriptionList> ListByResourceGroupNextPage(string nextLink, string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
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

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretResourceDescriptionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecretResourceDescriptionList.DeserializeSecretResourceDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySubscriptionNextPageRequest(string nextLink, string subscriptionId)
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

        /// <summary> Gets the information about all secret resources in a given resource group. The information include the description and other properties of the secret. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="subscriptionId"/> is null. </exception>
        public async Task<Response<SecretResourceDescriptionList>> ListBySubscriptionNextPageAsync(string nextLink, string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreateListBySubscriptionNextPageRequest(nextLink, subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretResourceDescriptionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecretResourceDescriptionList.DeserializeSecretResourceDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the information about all secret resources in a given resource group. The information include the description and other properties of the secret. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="subscriptionId"/> is null. </exception>
        public Response<SecretResourceDescriptionList> ListBySubscriptionNextPage(string nextLink, string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreateListBySubscriptionNextPageRequest(nextLink, subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretResourceDescriptionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecretResourceDescriptionList.DeserializeSecretResourceDescriptionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
