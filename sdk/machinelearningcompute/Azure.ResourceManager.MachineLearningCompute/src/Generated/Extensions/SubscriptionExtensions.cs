// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningCompute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MachineLearningCompute
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static OperationalizationClustersRestOperations GetOperationalizationClustersRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions clientOptions, Uri endpoint = null, string apiVersion = default)
        {
            return new OperationalizationClustersRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint, apiVersion);
        }

        /// <summary> Lists the OperationalizationClusters for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OperationalizationCluster> GetOperationalizationClustersAsync(this Subscription subscription, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                options.TryGetApiVersion(OperationalizationCluster.ResourceType, out string apiVersion);
                OperationalizationClustersRestOperations restOperations = GetOperationalizationClustersRestOperations(clientDiagnostics, pipeline, options, baseUri, apiVersion);
                async Task<Page<OperationalizationCluster>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetOperationalizationClusters");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListBySubscriptionIdAsync(subscription.Id.SubscriptionId, skiptoken, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new OperationalizationCluster(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<OperationalizationCluster>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetOperationalizationClusters");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListBySubscriptionIdNextPageAsync(nextLink, subscription.Id.SubscriptionId, skiptoken, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new OperationalizationCluster(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the OperationalizationClusters for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<OperationalizationCluster> GetOperationalizationClusters(this Subscription subscription, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                options.TryGetApiVersion(OperationalizationCluster.ResourceType, out string apiVersion);
                OperationalizationClustersRestOperations restOperations = GetOperationalizationClustersRestOperations(clientDiagnostics, pipeline, options, baseUri, apiVersion);
                Page<OperationalizationCluster> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetOperationalizationClusters");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListBySubscriptionId(subscription.Id.SubscriptionId, skiptoken, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new OperationalizationCluster(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<OperationalizationCluster> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetOperationalizationClusters");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListBySubscriptionIdNextPage(nextLink, subscription.Id.SubscriptionId, skiptoken, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new OperationalizationCluster(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of OperationalizationClusters for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetOperationalizationClustersAsGenericResourcesAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(OperationalizationCluster.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of OperationalizationClusters for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetOperationalizationClustersAsGenericResources(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(OperationalizationCluster.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }
    }
}
