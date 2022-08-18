// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Batch
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Batch. </summary>
    public static partial class BatchExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets information about the Batch accounts associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Batch/batchAccounts
        /// Operation Id: BatchAccount_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<BatchAccountResource> GetBatchAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetBatchAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets information about the Batch accounts associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Batch/batchAccounts
        /// Operation Id: BatchAccount_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<BatchAccountResource> GetBatchAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetBatchAccounts(cancellationToken);
        }

        /// <summary>
        /// Gets the Batch service quotas for the specified subscription at the given location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/quotas
        /// Operation Id: Location_GetQuotas
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The region for which to retrieve Batch service quotas. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<BatchLocationQuota>> GetBatchQuotasAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(subscriptionResource).GetBatchQuotasAsync(locationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the Batch service quotas for the specified subscription at the given location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/quotas
        /// Operation Id: Location_GetQuotas
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The region for which to retrieve Batch service quotas. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<BatchLocationQuota> GetBatchQuotas(this SubscriptionResource subscriptionResource, AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetBatchQuotas(locationName, cancellationToken);
        }

        /// <summary>
        /// Gets the list of Batch supported Virtual Machine VM sizes available at the given location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/virtualMachineSkus
        /// Operation Id: Location_ListSupportedVirtualMachineSkus
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchSupportedSku" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<BatchSupportedSku> GetBatchSupportedVirtualMachineSkusAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetBatchSupportedVirtualMachineSkusAsync(locationName, maxresults, filter, cancellationToken);
        }

        /// <summary>
        /// Gets the list of Batch supported Virtual Machine VM sizes available at the given location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/virtualMachineSkus
        /// Operation Id: Location_ListSupportedVirtualMachineSkus
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchSupportedSku" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<BatchSupportedSku> GetBatchSupportedVirtualMachineSkus(this SubscriptionResource subscriptionResource, AzureLocation locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetBatchSupportedVirtualMachineSkus(locationName, maxresults, filter, cancellationToken);
        }

        /// <summary>
        /// Gets the list of Batch supported Cloud Service VM sizes available at the given location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/cloudServiceSkus
        /// Operation Id: Location_ListSupportedCloudServiceSkus
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchSupportedSku" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<BatchSupportedSku> GetBatchSupportedCloudServiceSkusAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetBatchSupportedCloudServiceSkusAsync(locationName, maxresults, filter, cancellationToken);
        }

        /// <summary>
        /// Gets the list of Batch supported Cloud Service VM sizes available at the given location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/cloudServiceSkus
        /// Operation Id: Location_ListSupportedCloudServiceSkus
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The region for which to retrieve Batch service supported SKUs. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are &quot;familyName&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchSupportedSku" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<BatchSupportedSku> GetBatchSupportedCloudServiceSkus(this SubscriptionResource subscriptionResource, AzureLocation locationName, int? maxresults = null, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetBatchSupportedCloudServiceSkus(locationName, maxresults, filter, cancellationToken);
        }

        /// <summary>
        /// Checks whether the Batch account name is available in the specified region.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/checkNameAvailability
        /// Operation Id: Location_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="content"> Properties needed to check the availability of a name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<BatchNameAvailabilityResult>> CheckBatchNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, BatchNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckBatchNameAvailabilityAsync(locationName, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether the Batch account name is available in the specified region.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Batch/locations/{locationName}/checkNameAvailability
        /// Operation Id: Location_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="content"> Properties needed to check the availability of a name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<BatchNameAvailabilityResult> CheckBatchNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation locationName, BatchNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckBatchNameAvailability(locationName, content, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of BatchAccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of BatchAccountResources and their operations over a BatchAccountResource. </returns>
        public static BatchAccountCollection GetBatchAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetBatchAccounts();
        }

        /// <summary>
        /// Gets information about the specified Batch account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}
        /// Operation Id: BatchAccount_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<BatchAccountResource>> GetBatchAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetBatchAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified Batch account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}
        /// Operation Id: BatchAccount_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<BatchAccountResource> GetBatchAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetBatchAccounts().Get(accountName, cancellationToken);
        }

        #region BatchAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="BatchAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchAccountResource.CreateResourceIdentifier" /> to create a <see cref="BatchAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchAccountResource" /> object. </returns>
        public static BatchAccountResource GetBatchAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BatchAccountResource.ValidateResourceId(id);
                return new BatchAccountResource(client, id);
            }
            );
        }
        #endregion

        #region BatchAccountDetectorResource
        /// <summary>
        /// Gets an object representing a <see cref="BatchAccountDetectorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchAccountDetectorResource.CreateResourceIdentifier" /> to create a <see cref="BatchAccountDetectorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchAccountDetectorResource" /> object. </returns>
        public static BatchAccountDetectorResource GetBatchAccountDetectorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BatchAccountDetectorResource.ValidateResourceId(id);
                return new BatchAccountDetectorResource(client, id);
            }
            );
        }
        #endregion

        #region BatchApplicationPackageResource
        /// <summary>
        /// Gets an object representing a <see cref="BatchApplicationPackageResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchApplicationPackageResource.CreateResourceIdentifier" /> to create a <see cref="BatchApplicationPackageResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchApplicationPackageResource" /> object. </returns>
        public static BatchApplicationPackageResource GetBatchApplicationPackageResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BatchApplicationPackageResource.ValidateResourceId(id);
                return new BatchApplicationPackageResource(client, id);
            }
            );
        }
        #endregion

        #region BatchApplicationResource
        /// <summary>
        /// Gets an object representing a <see cref="BatchApplicationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchApplicationResource.CreateResourceIdentifier" /> to create a <see cref="BatchApplicationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchApplicationResource" /> object. </returns>
        public static BatchApplicationResource GetBatchApplicationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BatchApplicationResource.ValidateResourceId(id);
                return new BatchApplicationResource(client, id);
            }
            );
        }
        #endregion

        #region BatchAccountCertificateResource
        /// <summary>
        /// Gets an object representing a <see cref="BatchAccountCertificateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchAccountCertificateResource.CreateResourceIdentifier" /> to create a <see cref="BatchAccountCertificateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchAccountCertificateResource" /> object. </returns>
        public static BatchAccountCertificateResource GetBatchAccountCertificateResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BatchAccountCertificateResource.ValidateResourceId(id);
                return new BatchAccountCertificateResource(client, id);
            }
            );
        }
        #endregion

        #region BatchPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="BatchPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="BatchPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchPrivateLinkResource" /> object. </returns>
        public static BatchPrivateLinkResource GetBatchPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BatchPrivateLinkResource.ValidateResourceId(id);
                return new BatchPrivateLinkResource(client, id);
            }
            );
        }
        #endregion

        #region BatchPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="BatchPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="BatchPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchPrivateEndpointConnectionResource" /> object. </returns>
        public static BatchPrivateEndpointConnectionResource GetBatchPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BatchPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new BatchPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region BatchAccountPoolResource
        /// <summary>
        /// Gets an object representing a <see cref="BatchAccountPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BatchAccountPoolResource.CreateResourceIdentifier" /> to create a <see cref="BatchAccountPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BatchAccountPoolResource" /> object. </returns>
        public static BatchAccountPoolResource GetBatchAccountPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BatchAccountPoolResource.ValidateResourceId(id);
                return new BatchAccountPoolResource(client, id);
            }
            );
        }
        #endregion
    }
}
