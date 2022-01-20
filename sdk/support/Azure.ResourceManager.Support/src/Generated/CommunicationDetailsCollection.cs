// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary> A class representing collection of CommunicationDetails and their operations over its parent. </summary>
    public partial class CommunicationDetailsCollection : ArmCollection, IEnumerable<CommunicationDetails>, IAsyncEnumerable<CommunicationDetails>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CommunicationsRestOperations _communicationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CommunicationDetailsCollection"/> class for mocking. </summary>
        protected CommunicationDetailsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CommunicationDetailsCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CommunicationDetailsCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(CommunicationDetails.ResourceType, out string apiVersion);
            _communicationsRestClient = new CommunicationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SupportTicketDetails.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SupportTicketDetails.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Adds a new customer communication to an Azure support ticket. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="createCommunicationParameters"> Communication object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> or <paramref name="createCommunicationParameters"/> is null. </exception>
        public virtual CommunicationDetailsCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string communicationName, CommunicationDetailsData createCommunicationParameters, CancellationToken cancellationToken = default)
        {
            if (communicationName == null)
            {
                throw new ArgumentNullException(nameof(communicationName));
            }
            if (createCommunicationParameters == null)
            {
                throw new ArgumentNullException(nameof(createCommunicationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _communicationsRestClient.Create(Id.SubscriptionId, Id.Name, communicationName, createCommunicationParameters, cancellationToken);
                var operation = new CommunicationDetailsCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _communicationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.Name, communicationName, createCommunicationParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Adds a new customer communication to an Azure support ticket. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="createCommunicationParameters"> Communication object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> or <paramref name="createCommunicationParameters"/> is null. </exception>
        public async virtual Task<CommunicationDetailsCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string communicationName, CommunicationDetailsData createCommunicationParameters, CancellationToken cancellationToken = default)
        {
            if (communicationName == null)
            {
                throw new ArgumentNullException(nameof(communicationName));
            }
            if (createCommunicationParameters == null)
            {
                throw new ArgumentNullException(nameof(createCommunicationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _communicationsRestClient.CreateAsync(Id.SubscriptionId, Id.Name, communicationName, createCommunicationParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CommunicationDetailsCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _communicationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.Name, communicationName, createCommunicationParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns communication details for a support ticket. </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        public virtual Response<CommunicationDetails> Get(string communicationName, CancellationToken cancellationToken = default)
        {
            if (communicationName == null)
            {
                throw new ArgumentNullException(nameof(communicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.Get");
            scope.Start();
            try
            {
                var response = _communicationsRestClient.Get(Id.SubscriptionId, Id.Name, communicationName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CommunicationDetails(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns communication details for a support ticket. </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        public async virtual Task<Response<CommunicationDetails>> GetAsync(string communicationName, CancellationToken cancellationToken = default)
        {
            if (communicationName == null)
            {
                throw new ArgumentNullException(nameof(communicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.Get");
            scope.Start();
            try
            {
                var response = await _communicationsRestClient.GetAsync(Id.SubscriptionId, Id.Name, communicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CommunicationDetails(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        public virtual Response<CommunicationDetails> GetIfExists(string communicationName, CancellationToken cancellationToken = default)
        {
            if (communicationName == null)
            {
                throw new ArgumentNullException(nameof(communicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _communicationsRestClient.Get(Id.SubscriptionId, Id.Name, communicationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CommunicationDetails>(null, response.GetRawResponse());
                return Response.FromValue(new CommunicationDetails(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        public async virtual Task<Response<CommunicationDetails>> GetIfExistsAsync(string communicationName, CancellationToken cancellationToken = default)
        {
            if (communicationName == null)
            {
                throw new ArgumentNullException(nameof(communicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _communicationsRestClient.GetAsync(Id.SubscriptionId, Id.Name, communicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CommunicationDetails>(null, response.GetRawResponse());
                return Response.FromValue(new CommunicationDetails(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        public virtual Response<bool> Exists(string communicationName, CancellationToken cancellationToken = default)
        {
            if (communicationName == null)
            {
                throw new ArgumentNullException(nameof(communicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(communicationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string communicationName, CancellationToken cancellationToken = default)
        {
            if (communicationName == null)
            {
                throw new ArgumentNullException(nameof(communicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(communicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all communications (attachments not included) for a support ticket. &lt;br/&gt;&lt;/br&gt; You can also filter support ticket communications by _CreatedDate_ or _CommunicationType_ using the $filter parameter. The only type of communication supported today is _Web_. Output will be a paged result with _nextLink_, using which you can retrieve the next set of Communication results. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error. </summary>
        /// <param name="top"> The number of values to return in the collection. Default is 10 and max is 10. </param>
        /// <param name="filter"> The filter to apply on the operation. You can filter by communicationType and createdDate properties. CommunicationType supports Equals (&apos;eq&apos;) operator and createdDate supports Greater Than (&apos;gt&apos;) and Greater Than or Equals (&apos;ge&apos;) operators. You may combine the CommunicationType and CreatedDate filters by Logical And (&apos;and&apos;) operator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CommunicationDetails" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CommunicationDetails> GetAll(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Page<CommunicationDetails> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _communicationsRestClient.List(Id.SubscriptionId, Id.Name, top, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationDetails(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CommunicationDetails> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _communicationsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.Name, top, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationDetails(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all communications (attachments not included) for a support ticket. &lt;br/&gt;&lt;/br&gt; You can also filter support ticket communications by _CreatedDate_ or _CommunicationType_ using the $filter parameter. The only type of communication supported today is _Web_. Output will be a paged result with _nextLink_, using which you can retrieve the next set of Communication results. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error. </summary>
        /// <param name="top"> The number of values to return in the collection. Default is 10 and max is 10. </param>
        /// <param name="filter"> The filter to apply on the operation. You can filter by communicationType and createdDate properties. CommunicationType supports Equals (&apos;eq&apos;) operator and createdDate supports Greater Than (&apos;gt&apos;) and Greater Than or Equals (&apos;ge&apos;) operators. You may combine the CommunicationType and CreatedDate filters by Logical And (&apos;and&apos;) operator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CommunicationDetails" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CommunicationDetails> GetAllAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<CommunicationDetails>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _communicationsRestClient.ListAsync(Id.SubscriptionId, Id.Name, top, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationDetails(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CommunicationDetails>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationDetailsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _communicationsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.Name, top, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CommunicationDetails(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<CommunicationDetails> IEnumerable<CommunicationDetails>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CommunicationDetails> IAsyncEnumerable<CommunicationDetails>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CommunicationDetails, CommunicationDetailsData> Construct() { }
    }
}
