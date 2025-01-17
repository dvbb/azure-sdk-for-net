// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlServerDatabaseRestorePoint data model.
    /// Database restore points.
    /// </summary>
    public partial class SqlServerDatabaseRestorePointData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlServerDatabaseRestorePointData"/>. </summary>
        public SqlServerDatabaseRestorePointData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerDatabaseRestorePointData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="restorePointType"> The type of restore point. </param>
        /// <param name="earliestRestoreOn"> The earliest time to which this database can be restored. </param>
        /// <param name="restorePointCreatedOn"> The time the backup was taken. </param>
        /// <param name="restorePointLabel"> The label of restore point for backup request by user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlServerDatabaseRestorePointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, RestorePointType? restorePointType, DateTimeOffset? earliestRestoreOn, DateTimeOffset? restorePointCreatedOn, string restorePointLabel, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            RestorePointType = restorePointType;
            EarliestRestoreOn = earliestRestoreOn;
            RestorePointCreatedOn = restorePointCreatedOn;
            RestorePointLabel = restorePointLabel;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The type of restore point. </summary>
        public RestorePointType? RestorePointType { get; }
        /// <summary> The earliest time to which this database can be restored. </summary>
        public DateTimeOffset? EarliestRestoreOn { get; }
        /// <summary> The time the backup was taken. </summary>
        public DateTimeOffset? RestorePointCreatedOn { get; }
        /// <summary> The label of restore point for backup request by user. </summary>
        public string RestorePointLabel { get; }
    }
}
