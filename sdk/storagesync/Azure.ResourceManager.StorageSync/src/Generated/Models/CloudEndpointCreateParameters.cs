// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> The parameters used when creating a cloud endpoint. </summary>
    public partial class CloudEndpointCreateParameters : Resource
    {
        /// <summary> Initializes a new instance of CloudEndpointCreateParameters. </summary>
        public CloudEndpointCreateParameters()
        {
        }

        /// <summary> Initializes a new instance of CloudEndpointCreateParameters. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="storageAccountResourceId"> Storage Account Resource Id. </param>
        /// <param name="azureFileShareName"> Azure file share name. </param>
        /// <param name="storageAccountTenantId"> Storage Account Tenant Id. </param>
        /// <param name="friendlyName"> Friendly Name. </param>
        internal CloudEndpointCreateParameters(ResourceIdentifier id, string name, ResourceType type, string storageAccountResourceId, string azureFileShareName, string storageAccountTenantId, string friendlyName) : base(id, name, type)
        {
            StorageAccountResourceId = storageAccountResourceId;
            AzureFileShareName = azureFileShareName;
            StorageAccountTenantId = storageAccountTenantId;
            FriendlyName = friendlyName;
        }

        /// <summary> Storage Account Resource Id. </summary>
        public string StorageAccountResourceId { get; set; }
        /// <summary> Azure file share name. </summary>
        public string AzureFileShareName { get; set; }
        /// <summary> Storage Account Tenant Id. </summary>
        public string StorageAccountTenantId { get; set; }
        /// <summary> Friendly Name. </summary>
        public string FriendlyName { get; set; }
    }
}
