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
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Batch
{
    internal partial class LocationRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of LocationRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public LocationRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2021-06-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetQuotasRequest(string subscriptionId, string locationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Batch/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/quotas", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the Batch service quotas for the specified subscription at the given location. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The region for which to retrieve Batch service quotas. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is null. </exception>
        public async Task<Response<BatchLocationQuota>> GetQuotasAsync(string subscriptionId, string locationName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateGetQuotasRequest(subscriptionId, locationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BatchLocationQuota value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BatchLocationQuota.DeserializeBatchLocationQuota(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the Batch service quotas for the specified subscription at the given location. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The region for which to retrieve Batch service quotas. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is null. </exception>
        public Response<BatchLocationQuota> GetQuotas(string subscriptionId, string locationName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateGetQuotasRequest(subscriptionId, locationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BatchLocationQuota value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BatchLocationQuota.DeserializeBatchLocationQuota(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListSupportedVirtualMachineSkusRequest(string subscriptionId, string locationName, int? maxresults, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Batch/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/virtualMachineSkus", false);
            if (maxresults != null)
            {
                uri.AppendQuery("maxresults", maxresults.Value, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the list of Batch supported Virtual Machine VM sizes available at the given location. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is null. </exception>
        public async Task<Response<SupportedSkusResult>> ListSupportedVirtualMachineSkusAsync(string subscriptionId, string locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListSupportedVirtualMachineSkusRequest(subscriptionId, locationName, maxresults, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportedSkusResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SupportedSkusResult.DeserializeSupportedSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of Batch supported Virtual Machine VM sizes available at the given location. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is null. </exception>
        public Response<SupportedSkusResult> ListSupportedVirtualMachineSkus(string subscriptionId, string locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListSupportedVirtualMachineSkusRequest(subscriptionId, locationName, maxresults, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportedSkusResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SupportedSkusResult.DeserializeSupportedSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListSupportedCloudServiceSkusRequest(string subscriptionId, string locationName, int? maxresults, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Batch/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/cloudServiceSkus", false);
            if (maxresults != null)
            {
                uri.AppendQuery("maxresults", maxresults.Value, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the list of Batch supported Cloud Service VM sizes available at the given location. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is null. </exception>
        public async Task<Response<SupportedSkusResult>> ListSupportedCloudServiceSkusAsync(string subscriptionId, string locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListSupportedCloudServiceSkusRequest(subscriptionId, locationName, maxresults, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportedSkusResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SupportedSkusResult.DeserializeSupportedSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of Batch supported Cloud Service VM sizes available at the given location. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is null. </exception>
        public Response<SupportedSkusResult> ListSupportedCloudServiceSkus(string subscriptionId, string locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListSupportedCloudServiceSkusRequest(subscriptionId, locationName, maxresults, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportedSkusResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SupportedSkusResult.DeserializeSupportedSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCheckNameAvailabilityRequest(string subscriptionId, string locationName, CheckNameAvailabilityParameters parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Batch/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/checkNameAvailability", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Checks whether the Batch account name is available in the specified region. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="parameters"> Properties needed to check the availability of a name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="locationName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityAsync(string subscriptionId, string locationName, CheckNameAvailabilityParameters parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCheckNameAvailabilityRequest(subscriptionId, locationName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CheckNameAvailabilityResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CheckNameAvailabilityResult.DeserializeCheckNameAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Checks whether the Batch account name is available in the specified region. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="parameters"> Properties needed to check the availability of a name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="locationName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response<CheckNameAvailabilityResult> CheckNameAvailability(string subscriptionId, string locationName, CheckNameAvailabilityParameters parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCheckNameAvailabilityRequest(subscriptionId, locationName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CheckNameAvailabilityResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CheckNameAvailabilityResult.DeserializeCheckNameAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListSupportedVirtualMachineSkusNextPageRequest(string nextLink, string subscriptionId, string locationName, int? maxresults, string filter)
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

        /// <summary> Gets the list of Batch supported Virtual Machine VM sizes available at the given location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, or <paramref name="locationName"/> is null. </exception>
        public async Task<Response<SupportedSkusResult>> ListSupportedVirtualMachineSkusNextPageAsync(string nextLink, string subscriptionId, string locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListSupportedVirtualMachineSkusNextPageRequest(nextLink, subscriptionId, locationName, maxresults, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportedSkusResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SupportedSkusResult.DeserializeSupportedSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of Batch supported Virtual Machine VM sizes available at the given location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, or <paramref name="locationName"/> is null. </exception>
        public Response<SupportedSkusResult> ListSupportedVirtualMachineSkusNextPage(string nextLink, string subscriptionId, string locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListSupportedVirtualMachineSkusNextPageRequest(nextLink, subscriptionId, locationName, maxresults, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportedSkusResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SupportedSkusResult.DeserializeSupportedSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListSupportedCloudServiceSkusNextPageRequest(string nextLink, string subscriptionId, string locationName, int? maxresults, string filter)
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

        /// <summary> Gets the list of Batch supported Cloud Service VM sizes available at the given location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, or <paramref name="locationName"/> is null. </exception>
        public async Task<Response<SupportedSkusResult>> ListSupportedCloudServiceSkusNextPageAsync(string nextLink, string subscriptionId, string locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListSupportedCloudServiceSkusNextPageRequest(nextLink, subscriptionId, locationName, maxresults, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportedSkusResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SupportedSkusResult.DeserializeSupportedSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of Batch supported Cloud Service VM sizes available at the given location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, or <paramref name="locationName"/> is null. </exception>
        public Response<SupportedSkusResult> ListSupportedCloudServiceSkusNextPage(string nextLink, string subscriptionId, string locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var message = CreateListSupportedCloudServiceSkusNextPageRequest(nextLink, subscriptionId, locationName, maxresults, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SupportedSkusResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SupportedSkusResult.DeserializeSupportedSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
