// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The CosmosDB (MongoDB API) database dataset. </summary>
    public partial class CosmosDbMongoDbApiCollectionDataset : Dataset
    {
        /// <summary> Initializes a new instance of CosmosDbMongoDbApiCollectionDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="collection"> The collection name of the CosmosDB (MongoDB API) database. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="collection"/> is null. </exception>
        public CosmosDbMongoDbApiCollectionDataset(LinkedServiceReference linkedServiceName, object collection) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            Collection = collection;
            Type = "CosmosDbMongoDbApiCollection";
        }

        /// <summary> Initializes a new instance of CosmosDbMongoDbApiCollectionDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="collection"> The collection name of the CosmosDB (MongoDB API) database. Type: string (or Expression with resultType string). </param>
        internal CosmosDbMongoDbApiCollectionDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object collection) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Collection = collection;
            Type = type ?? "CosmosDbMongoDbApiCollection";
        }

        /// <summary> The collection name of the CosmosDB (MongoDB API) database. Type: string (or Expression with resultType string). </summary>
        public object Collection { get; set; }
    }
}
