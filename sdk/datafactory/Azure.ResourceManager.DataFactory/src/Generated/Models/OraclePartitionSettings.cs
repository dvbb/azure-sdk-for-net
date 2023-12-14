// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The settings that will be leveraged for Oracle source partitioning. </summary>
    public partial class OraclePartitionSettings
    {
        /// <summary> Initializes a new instance of <see cref="OraclePartitionSettings"/>. </summary>
        public OraclePartitionSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OraclePartitionSettings"/>. </summary>
        /// <param name="partitionNames"> Names of the physical partitions of Oracle table. </param>
        /// <param name="partitionColumnName"> The name of the column in integer type that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionUpperBound"> The maximum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionLowerBound"> The minimum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        internal OraclePartitionSettings(BinaryData partitionNames, DataFactoryElement<string> partitionColumnName, DataFactoryElement<string> partitionUpperBound, DataFactoryElement<string> partitionLowerBound)
        {
            PartitionNames = partitionNames;
            PartitionColumnName = partitionColumnName;
            PartitionUpperBound = partitionUpperBound;
            PartitionLowerBound = partitionLowerBound;
        }

        /// <summary>
        /// Names of the physical partitions of Oracle table.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData PartitionNames { get; set; }
        /// <summary> The name of the column in integer type that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PartitionColumnName { get; set; }
        /// <summary> The maximum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PartitionUpperBound { get; set; }
        /// <summary> The minimum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PartitionLowerBound { get; set; }
    }
}
