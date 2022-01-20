// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AgriFood.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AgriFood
{
    internal partial class FarmBeatsExtensionsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of FarmBeatsExtensionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public FarmBeatsExtensionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2020-05-12-preview";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListRequest(IEnumerable<string> farmBeatsExtensionIds, IEnumerable<string> farmBeatsExtensionNames, IEnumerable<string> extensionCategories, IEnumerable<string> publisherIds, int? maxPageSize)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions", false);
            if (farmBeatsExtensionIds != null)
            {
                foreach (var param in farmBeatsExtensionIds)
                {
                    uri.AppendQuery("farmBeatsExtensionIds", param, true);
                }
            }
            if (farmBeatsExtensionNames != null)
            {
                foreach (var param in farmBeatsExtensionNames)
                {
                    uri.AppendQuery("farmBeatsExtensionNames", param, true);
                }
            }
            if (extensionCategories != null)
            {
                foreach (var param in extensionCategories)
                {
                    uri.AppendQuery("extensionCategories", param, true);
                }
            }
            if (publisherIds != null)
            {
                foreach (var param in publisherIds)
                {
                    uri.AppendQuery("publisherIds", param, true);
                }
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get list of farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionIds"> FarmBeatsExtension ids. </param>
        /// <param name="farmBeatsExtensionNames"> FarmBeats extension names. </param>
        /// <param name="extensionCategories"> Extension categories. </param>
        /// <param name="publisherIds"> Publisher ids. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<FarmBeatsExtensionListResponse>> ListAsync(IEnumerable<string> farmBeatsExtensionIds = null, IEnumerable<string> farmBeatsExtensionNames = null, IEnumerable<string> extensionCategories = null, IEnumerable<string> publisherIds = null, int? maxPageSize = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, maxPageSize);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FarmBeatsExtensionListResponse.DeserializeFarmBeatsExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get list of farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionIds"> FarmBeatsExtension ids. </param>
        /// <param name="farmBeatsExtensionNames"> FarmBeats extension names. </param>
        /// <param name="extensionCategories"> Extension categories. </param>
        /// <param name="publisherIds"> Publisher ids. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<FarmBeatsExtensionListResponse> List(IEnumerable<string> farmBeatsExtensionIds = null, IEnumerable<string> farmBeatsExtensionNames = null, IEnumerable<string> extensionCategories = null, IEnumerable<string> publisherIds = null, int? maxPageSize = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, maxPageSize);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FarmBeatsExtensionListResponse.DeserializeFarmBeatsExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string farmBeatsExtensionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions/", false);
            uri.AppendPath(farmBeatsExtensionId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        public async Task<Response<FarmBeatsExtensionData>> GetAsync(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            if (farmBeatsExtensionId == null)
            {
                throw new ArgumentNullException(nameof(farmBeatsExtensionId));
            }

            using var message = CreateGetRequest(farmBeatsExtensionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FarmBeatsExtensionData.DeserializeFarmBeatsExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FarmBeatsExtensionData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        public Response<FarmBeatsExtensionData> Get(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            if (farmBeatsExtensionId == null)
            {
                throw new ArgumentNullException(nameof(farmBeatsExtensionId));
            }

            using var message = CreateGetRequest(farmBeatsExtensionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FarmBeatsExtensionData.DeserializeFarmBeatsExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FarmBeatsExtensionData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, IEnumerable<string> farmBeatsExtensionIds, IEnumerable<string> farmBeatsExtensionNames, IEnumerable<string> extensionCategories, IEnumerable<string> publisherIds, int? maxPageSize)
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

        /// <summary> Get list of farmBeats extension. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="farmBeatsExtensionIds"> FarmBeatsExtension ids. </param>
        /// <param name="farmBeatsExtensionNames"> FarmBeats extension names. </param>
        /// <param name="extensionCategories"> Extension categories. </param>
        /// <param name="publisherIds"> Publisher ids. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<FarmBeatsExtensionListResponse>> ListNextPageAsync(string nextLink, IEnumerable<string> farmBeatsExtensionIds = null, IEnumerable<string> farmBeatsExtensionNames = null, IEnumerable<string> extensionCategories = null, IEnumerable<string> publisherIds = null, int? maxPageSize = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, maxPageSize);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FarmBeatsExtensionListResponse.DeserializeFarmBeatsExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get list of farmBeats extension. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="farmBeatsExtensionIds"> FarmBeatsExtension ids. </param>
        /// <param name="farmBeatsExtensionNames"> FarmBeats extension names. </param>
        /// <param name="extensionCategories"> Extension categories. </param>
        /// <param name="publisherIds"> Publisher ids. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<FarmBeatsExtensionListResponse> ListNextPage(string nextLink, IEnumerable<string> farmBeatsExtensionIds = null, IEnumerable<string> farmBeatsExtensionNames = null, IEnumerable<string> extensionCategories = null, IEnumerable<string> publisherIds = null, int? maxPageSize = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, maxPageSize);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FarmBeatsExtensionListResponse.DeserializeFarmBeatsExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
