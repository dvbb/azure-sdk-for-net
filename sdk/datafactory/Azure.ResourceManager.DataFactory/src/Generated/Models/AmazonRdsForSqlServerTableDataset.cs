// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The Amazon RDS for SQL Server dataset. </summary>
    public partial class AmazonRdsForSqlServerTableDataset : Dataset
    {
        /// <summary> Initializes a new instance of AmazonRdsForSqlServerTableDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public AmazonRdsForSqlServerTableDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            Type = "AmazonRdsForSqlServerTable";
        }

        /// <summary> Initializes a new instance of AmazonRdsForSqlServerTableDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="schemaTypePropertiesSchema"> The schema name of the SQL Server dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="table"> The table name of the SQL Server dataset. Type: string (or Expression with resultType string). </param>
        internal AmazonRdsForSqlServerTableDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object schemaTypePropertiesSchema, object table) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            SchemaTypePropertiesSchema = schemaTypePropertiesSchema;
            Table = table;
            Type = type ?? "AmazonRdsForSqlServerTable";
        }

        /// <summary> The schema name of the SQL Server dataset. Type: string (or Expression with resultType string). </summary>
        public object SchemaTypePropertiesSchema { get; set; }
        /// <summary> The table name of the SQL Server dataset. Type: string (or Expression with resultType string). </summary>
        public object Table { get; set; }
    }
}
