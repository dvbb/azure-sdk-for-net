// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties related to a storage container endpoint. </summary>
    public partial class RoutingStorageContainerProperties
    {
        /// <summary> Initializes a new instance of RoutingStorageContainerProperties. </summary>
        /// <param name="name"> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types. </param>
        /// <param name="containerName"> The name of storage container in the storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="containerName"/> is null. </exception>
        public RoutingStorageContainerProperties(string name, string containerName)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            Name = name;
            ContainerName = containerName;
        }

        /// <summary> Initializes a new instance of RoutingStorageContainerProperties. </summary>
        /// <param name="id"> Id of the storage container endpoint. </param>
        /// <param name="connectionString"> The connection string of the storage account. </param>
        /// <param name="endpointUri"> The url of the storage endpoint. It must include the protocol https://. </param>
        /// <param name="authenticationType"> Method used to authenticate against the storage endpoint. </param>
        /// <param name="identity"> Managed identity properties of routing storage endpoint. </param>
        /// <param name="name"> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types. </param>
        /// <param name="subscriptionId"> The subscription identifier of the storage account. </param>
        /// <param name="resourceGroup"> The name of the resource group of the storage account. </param>
        /// <param name="containerName"> The name of storage container in the storage account. </param>
        /// <param name="fileNameFormat"> File name format for the blob. Default format is {iothub}/{partition}/{YYYY}/{MM}/{DD}/{HH}/{mm}. All parameters are mandatory but can be reordered. </param>
        /// <param name="batchFrequencyInSeconds"> Time interval at which blobs are written to storage. Value should be between 60 and 720 seconds. Default value is 300 seconds. </param>
        /// <param name="maxChunkSizeInBytes"> Maximum number of bytes for each blob written to storage. Value should be between 10485760(10MB) and 524288000(500MB). Default value is 314572800(300MB). </param>
        /// <param name="encoding"> Encoding that is used to serialize messages to blobs. Supported values are &apos;avro&apos;, &apos;avrodeflate&apos;, and &apos;JSON&apos;. Default value is &apos;avro&apos;. </param>
        internal RoutingStorageContainerProperties(string id, string connectionString, string endpointUri, AuthenticationType? authenticationType, ManagedIdentity identity, string name, string subscriptionId, string resourceGroup, string containerName, string fileNameFormat, int? batchFrequencyInSeconds, int? maxChunkSizeInBytes, RoutingStorageContainerPropertiesEncoding? encoding)
        {
            Id = id;
            ConnectionString = connectionString;
            EndpointUri = endpointUri;
            AuthenticationType = authenticationType;
            Identity = identity;
            Name = name;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            ContainerName = containerName;
            FileNameFormat = fileNameFormat;
            BatchFrequencyInSeconds = batchFrequencyInSeconds;
            MaxChunkSizeInBytes = maxChunkSizeInBytes;
            Encoding = encoding;
        }

        /// <summary> Id of the storage container endpoint. </summary>
        public string Id { get; set; }
        /// <summary> The connection string of the storage account. </summary>
        public string ConnectionString { get; set; }
        /// <summary> The url of the storage endpoint. It must include the protocol https://. </summary>
        public string EndpointUri { get; set; }
        /// <summary> Method used to authenticate against the storage endpoint. </summary>
        public AuthenticationType? AuthenticationType { get; set; }
        /// <summary> Managed identity properties of routing storage endpoint. </summary>
        public ManagedIdentity Identity { get; set; }
        /// <summary> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types. </summary>
        public string Name { get; set; }
        /// <summary> The subscription identifier of the storage account. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> The name of the resource group of the storage account. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> The name of storage container in the storage account. </summary>
        public string ContainerName { get; set; }
        /// <summary> File name format for the blob. Default format is {iothub}/{partition}/{YYYY}/{MM}/{DD}/{HH}/{mm}. All parameters are mandatory but can be reordered. </summary>
        public string FileNameFormat { get; set; }
        /// <summary> Time interval at which blobs are written to storage. Value should be between 60 and 720 seconds. Default value is 300 seconds. </summary>
        public int? BatchFrequencyInSeconds { get; set; }
        /// <summary> Maximum number of bytes for each blob written to storage. Value should be between 10485760(10MB) and 524288000(500MB). Default value is 314572800(300MB). </summary>
        public int? MaxChunkSizeInBytes { get; set; }
        /// <summary> Encoding that is used to serialize messages to blobs. Supported values are &apos;avro&apos;, &apos;avrodeflate&apos;, and &apos;JSON&apos;. Default value is &apos;avro&apos;. </summary>
        public RoutingStorageContainerPropertiesEncoding? Encoding { get; set; }
    }
}
