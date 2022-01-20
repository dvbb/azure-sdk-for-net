// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Document Database Collection source. </summary>
    public partial class DocumentDbCollectionSource : CopySource
    {
        /// <summary> Initializes a new instance of DocumentDbCollectionSource. </summary>
        public DocumentDbCollectionSource()
        {
            Type = "DocumentDbCollectionSource";
        }

        /// <summary> Initializes a new instance of DocumentDbCollectionSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="query"> Documents query. Type: string (or Expression with resultType string). </param>
        /// <param name="nestingSeparator"> Nested properties separator. Type: string (or Expression with resultType string). </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal DocumentDbCollectionSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, object disableMetricsCollection, IDictionary<string, object> additionalProperties, object query, object nestingSeparator, object queryTimeout, object additionalColumns) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            Query = query;
            NestingSeparator = nestingSeparator;
            QueryTimeout = queryTimeout;
            AdditionalColumns = additionalColumns;
            Type = type ?? "DocumentDbCollectionSource";
        }

        /// <summary> Documents query. Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
        /// <summary> Nested properties separator. Type: string (or Expression with resultType string). </summary>
        public object NestingSeparator { get; set; }
        /// <summary> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public object QueryTimeout { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public object AdditionalColumns { get; set; }
    }
}
