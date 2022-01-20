// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Microsoft Azure Document Database Collection dataset. </summary>
    public partial class DocumentDbCollectionDataset : Dataset
    {
        /// <summary> Initializes a new instance of DocumentDbCollectionDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="collectionName"> Document Database collection name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="collectionName"/> is null. </exception>
        public DocumentDbCollectionDataset(LinkedServiceReference linkedServiceName, object collectionName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (collectionName == null)
            {
                throw new ArgumentNullException(nameof(collectionName));
            }

            CollectionName = collectionName;
            Type = "DocumentDbCollection";
        }

        /// <summary> Initializes a new instance of DocumentDbCollectionDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="collectionName"> Document Database collection name. Type: string (or Expression with resultType string). </param>
        internal DocumentDbCollectionDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object collectionName) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            CollectionName = collectionName;
            Type = type ?? "DocumentDbCollection";
        }

        /// <summary> Document Database collection name. Type: string (or Expression with resultType string). </summary>
        public object CollectionName { get; set; }
    }
}
