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
using Azure.ResourceManager.StorSimple8000Series.Models;

namespace Azure.ResourceManager.StorSimple8000Series
{
    internal partial class JobsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of JobsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public JobsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2017-06-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListByDeviceRequest(string subscriptionId, string resourceGroupName, string managerName, string deviceName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, false);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, false);
            uri.AppendPath("/providers/Microsoft.StorSimple/managers/", false);
            uri.AppendPath(managerName, false);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(deviceName, false);
            uri.AppendPath("/jobs", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets all the jobs for specified device. With optional OData query parameters, a filtered set of jobs is returned. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managerName"/>, or <paramref name="deviceName"/> is null. </exception>
        public async Task<Response<JobList>> ListByDeviceAsync(string subscriptionId, string resourceGroupName, string managerName, string deviceName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }
            if (deviceName == null)
            {
                throw new ArgumentNullException(nameof(deviceName));
            }

            using var message = CreateListByDeviceRequest(subscriptionId, resourceGroupName, managerName, deviceName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobList.DeserializeJobList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the jobs for specified device. With optional OData query parameters, a filtered set of jobs is returned. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managerName"/>, or <paramref name="deviceName"/> is null. </exception>
        public Response<JobList> ListByDevice(string subscriptionId, string resourceGroupName, string managerName, string deviceName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }
            if (deviceName == null)
            {
                throw new ArgumentNullException(nameof(deviceName));
            }

            using var message = CreateListByDeviceRequest(subscriptionId, resourceGroupName, managerName, deviceName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobList.DeserializeJobList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string managerName, string deviceName, string jobName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, false);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, false);
            uri.AppendPath("/providers/Microsoft.StorSimple/managers/", false);
            uri.AppendPath(managerName, false);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(deviceName, false);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobName, false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the details of the specified job name. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="jobName"> The job Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managerName"/>, <paramref name="deviceName"/>, or <paramref name="jobName"/> is null. </exception>
        public async Task<Response<JobData>> GetAsync(string subscriptionId, string resourceGroupName, string managerName, string deviceName, string jobName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }
            if (deviceName == null)
            {
                throw new ArgumentNullException(nameof(deviceName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, managerName, deviceName, jobName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobData.DeserializeJobData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((JobData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the details of the specified job name. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="jobName"> The job Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managerName"/>, <paramref name="deviceName"/>, or <paramref name="jobName"/> is null. </exception>
        public Response<JobData> Get(string subscriptionId, string resourceGroupName, string managerName, string deviceName, string jobName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }
            if (deviceName == null)
            {
                throw new ArgumentNullException(nameof(deviceName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, managerName, deviceName, jobName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobData.DeserializeJobData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((JobData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelRequest(string subscriptionId, string resourceGroupName, string managerName, string deviceName, string jobName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, false);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, false);
            uri.AppendPath("/providers/Microsoft.StorSimple/managers/", false);
            uri.AppendPath(managerName, false);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(deviceName, false);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobName, false);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Cancels a job on the device. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="jobName"> The jobName. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managerName"/>, <paramref name="deviceName"/>, or <paramref name="jobName"/> is null. </exception>
        public async Task<Response> CancelAsync(string subscriptionId, string resourceGroupName, string managerName, string deviceName, string jobName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }
            if (deviceName == null)
            {
                throw new ArgumentNullException(nameof(deviceName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var message = CreateCancelRequest(subscriptionId, resourceGroupName, managerName, deviceName, jobName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Cancels a job on the device. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="jobName"> The jobName. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managerName"/>, <paramref name="deviceName"/>, or <paramref name="jobName"/> is null. </exception>
        public Response Cancel(string subscriptionId, string resourceGroupName, string managerName, string deviceName, string jobName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }
            if (deviceName == null)
            {
                throw new ArgumentNullException(nameof(deviceName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var message = CreateCancelRequest(subscriptionId, resourceGroupName, managerName, deviceName, jobName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByManagerRequest(string subscriptionId, string resourceGroupName, string managerName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, false);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, false);
            uri.AppendPath("/providers/Microsoft.StorSimple/managers/", false);
            uri.AppendPath(managerName, false);
            uri.AppendPath("/jobs", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets all the jobs for the specified manager. With optional OData query parameters, a filtered set of jobs is returned. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="managerName"/> is null. </exception>
        public async Task<Response<JobList>> ListByManagerAsync(string subscriptionId, string resourceGroupName, string managerName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }

            using var message = CreateListByManagerRequest(subscriptionId, resourceGroupName, managerName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobList.DeserializeJobList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the jobs for the specified manager. With optional OData query parameters, a filtered set of jobs is returned. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="managerName"/> is null. </exception>
        public Response<JobList> ListByManager(string subscriptionId, string resourceGroupName, string managerName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }

            using var message = CreateListByManagerRequest(subscriptionId, resourceGroupName, managerName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobList.DeserializeJobList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByDeviceNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string managerName, string deviceName, string filter)
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

        /// <summary> Gets all the jobs for specified device. With optional OData query parameters, a filtered set of jobs is returned. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managerName"/>, or <paramref name="deviceName"/> is null. </exception>
        public async Task<Response<JobList>> ListByDeviceNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string managerName, string deviceName, string filter = null, CancellationToken cancellationToken = default)
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
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }
            if (deviceName == null)
            {
                throw new ArgumentNullException(nameof(deviceName));
            }

            using var message = CreateListByDeviceNextPageRequest(nextLink, subscriptionId, resourceGroupName, managerName, deviceName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobList.DeserializeJobList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the jobs for specified device. With optional OData query parameters, a filtered set of jobs is returned. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managerName"/>, or <paramref name="deviceName"/> is null. </exception>
        public Response<JobList> ListByDeviceNextPage(string nextLink, string subscriptionId, string resourceGroupName, string managerName, string deviceName, string filter = null, CancellationToken cancellationToken = default)
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
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }
            if (deviceName == null)
            {
                throw new ArgumentNullException(nameof(deviceName));
            }

            using var message = CreateListByDeviceNextPageRequest(nextLink, subscriptionId, resourceGroupName, managerName, deviceName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobList.DeserializeJobList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByManagerNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string managerName, string filter)
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

        /// <summary> Gets all the jobs for the specified manager. With optional OData query parameters, a filtered set of jobs is returned. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="managerName"/> is null. </exception>
        public async Task<Response<JobList>> ListByManagerNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string managerName, string filter = null, CancellationToken cancellationToken = default)
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
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }

            using var message = CreateListByManagerNextPageRequest(nextLink, subscriptionId, resourceGroupName, managerName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobList.DeserializeJobList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the jobs for the specified manager. With optional OData query parameters, a filtered set of jobs is returned. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="managerName"> The manager name. </param>
        /// <param name="filter"> OData Filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="managerName"/> is null. </exception>
        public Response<JobList> ListByManagerNextPage(string nextLink, string subscriptionId, string resourceGroupName, string managerName, string filter = null, CancellationToken cancellationToken = default)
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
            if (managerName == null)
            {
                throw new ArgumentNullException(nameof(managerName));
            }

            using var message = CreateListByManagerNextPageRequest(nextLink, subscriptionId, resourceGroupName, managerName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobList.DeserializeJobList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
