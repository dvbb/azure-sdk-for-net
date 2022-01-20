// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity MongoDB Atlas sink. </summary>
    public partial class MongoDbAtlasSink : CopySink
    {
        /// <summary> Initializes a new instance of MongoDbAtlasSink. </summary>
        public MongoDbAtlasSink()
        {
            Type = "MongoDbAtlasSink";
        }

        /// <summary> Initializes a new instance of MongoDbAtlasSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="writeBehavior"> Specifies whether the document with same key to be overwritten (upsert) rather than throw exception (insert). The default value is &quot;insert&quot;. Type: string (or Expression with resultType string). Type: string (or Expression with resultType string). </param>
        internal MongoDbAtlasSink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, object disableMetricsCollection, IDictionary<string, object> additionalProperties, object writeBehavior) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            WriteBehavior = writeBehavior;
            Type = type ?? "MongoDbAtlasSink";
        }

        /// <summary> Specifies whether the document with same key to be overwritten (upsert) rather than throw exception (insert). The default value is &quot;insert&quot;. Type: string (or Expression with resultType string). Type: string (or Expression with resultType string). </summary>
        public object WriteBehavior { get; set; }
    }
}
