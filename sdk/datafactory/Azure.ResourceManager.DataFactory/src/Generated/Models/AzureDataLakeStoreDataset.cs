// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Data Lake Store dataset. </summary>
    public partial class AzureDataLakeStoreDataset : Dataset
    {
        /// <summary> Initializes a new instance of AzureDataLakeStoreDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public AzureDataLakeStoreDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            Type = "AzureDataLakeStoreFile";
        }

        /// <summary> Initializes a new instance of AzureDataLakeStoreDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="folderPath"> Path to the folder in the Azure Data Lake Store. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> The name of the file in the Azure Data Lake Store. Type: string (or Expression with resultType string). </param>
        /// <param name="format"> The format of the Data Lake Store. </param>
        /// <param name="compression"> The data compression method used for the item(s) in the Azure Data Lake Store. </param>
        internal AzureDataLakeStoreDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object folderPath, object fileName, DatasetStorageFormat format, DatasetCompression compression) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            FolderPath = folderPath;
            FileName = fileName;
            Format = format;
            Compression = compression;
            Type = type ?? "AzureDataLakeStoreFile";
        }

        /// <summary> Path to the folder in the Azure Data Lake Store. Type: string (or Expression with resultType string). </summary>
        public object FolderPath { get; set; }
        /// <summary> The name of the file in the Azure Data Lake Store. Type: string (or Expression with resultType string). </summary>
        public object FileName { get; set; }
        /// <summary> The format of the Data Lake Store. </summary>
        public DatasetStorageFormat Format { get; set; }
        /// <summary> The data compression method used for the item(s) in the Azure Data Lake Store. </summary>
        public DatasetCompression Compression { get; set; }
    }
}
