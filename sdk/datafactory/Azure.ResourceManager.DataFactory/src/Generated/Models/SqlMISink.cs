// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Azure SQL Managed Instance sink. </summary>
    public partial class SqlMISink : CopySink
    {
        /// <summary> Initializes a new instance of SqlMISink. </summary>
        public SqlMISink()
        {
            StoredProcedureParameters = new ChangeTrackingDictionary<string, StoredProcedureParameter>();
            Type = "SqlMISink";
        }

        /// <summary> Initializes a new instance of SqlMISink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="sqlWriterStoredProcedureName"> SQL writer stored procedure name. Type: string (or Expression with resultType string). </param>
        /// <param name="sqlWriterTableType"> SQL writer table type. Type: string (or Expression with resultType string). </param>
        /// <param name="preCopyScript"> SQL pre-copy script. Type: string (or Expression with resultType string). </param>
        /// <param name="storedProcedureParameters"> SQL stored procedure parameters. </param>
        /// <param name="storedProcedureTableTypeParameterName"> The stored procedure parameter name of the table type. Type: string (or Expression with resultType string). </param>
        /// <param name="tableOption"> The option to handle sink table, such as autoCreate. For now only &apos;autoCreate&apos; value is supported. Type: string (or Expression with resultType string). </param>
        /// <param name="sqlWriterUseTableLock"> Whether to use table lock during bulk copy. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="writeBehavior"> White behavior when copying data into azure SQL MI. Type: SqlWriteBehaviorEnum (or Expression with resultType SqlWriteBehaviorEnum). </param>
        /// <param name="upsertSettings"> SQL upsert settings. </param>
        internal SqlMISink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, object disableMetricsCollection, IDictionary<string, object> additionalProperties, object sqlWriterStoredProcedureName, object sqlWriterTableType, object preCopyScript, IDictionary<string, StoredProcedureParameter> storedProcedureParameters, object storedProcedureTableTypeParameterName, object tableOption, object sqlWriterUseTableLock, object writeBehavior, SqlUpsertSettings upsertSettings) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            SqlWriterStoredProcedureName = sqlWriterStoredProcedureName;
            SqlWriterTableType = sqlWriterTableType;
            PreCopyScript = preCopyScript;
            StoredProcedureParameters = storedProcedureParameters;
            StoredProcedureTableTypeParameterName = storedProcedureTableTypeParameterName;
            TableOption = tableOption;
            SqlWriterUseTableLock = sqlWriterUseTableLock;
            WriteBehavior = writeBehavior;
            UpsertSettings = upsertSettings;
            Type = type ?? "SqlMISink";
        }

        /// <summary> SQL writer stored procedure name. Type: string (or Expression with resultType string). </summary>
        public object SqlWriterStoredProcedureName { get; set; }
        /// <summary> SQL writer table type. Type: string (or Expression with resultType string). </summary>
        public object SqlWriterTableType { get; set; }
        /// <summary> SQL pre-copy script. Type: string (or Expression with resultType string). </summary>
        public object PreCopyScript { get; set; }
        /// <summary> SQL stored procedure parameters. </summary>
        public IDictionary<string, StoredProcedureParameter> StoredProcedureParameters { get; }
        /// <summary> The stored procedure parameter name of the table type. Type: string (or Expression with resultType string). </summary>
        public object StoredProcedureTableTypeParameterName { get; set; }
        /// <summary> The option to handle sink table, such as autoCreate. For now only &apos;autoCreate&apos; value is supported. Type: string (or Expression with resultType string). </summary>
        public object TableOption { get; set; }
        /// <summary> Whether to use table lock during bulk copy. Type: boolean (or Expression with resultType boolean). </summary>
        public object SqlWriterUseTableLock { get; set; }
        /// <summary> White behavior when copying data into azure SQL MI. Type: SqlWriteBehaviorEnum (or Expression with resultType SqlWriteBehaviorEnum). </summary>
        public object WriteBehavior { get; set; }
        /// <summary> SQL upsert settings. </summary>
        public SqlUpsertSettings UpsertSettings { get; set; }
    }
}
