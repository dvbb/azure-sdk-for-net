// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Microsoft Access sink. </summary>
    public partial class MicrosoftAccessSink : CopySink
    {
        /// <summary> Initializes a new instance of MicrosoftAccessSink. </summary>
        public MicrosoftAccessSink()
        {
            CopySinkType = "MicrosoftAccessSink";
        }

        /// <summary> Initializes a new instance of MicrosoftAccessSink. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="preCopyScript"> A query to execute before starting the copy. Type: string (or Expression with resultType string). </param>
        internal MicrosoftAccessSink(string copySinkType, BinaryData writeBatchSize, BinaryData writeBatchTimeout, BinaryData sinkRetryCount, BinaryData sinkRetryWait, BinaryData maxConcurrentConnections, BinaryData disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, BinaryData preCopyScript) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            PreCopyScript = preCopyScript;
            CopySinkType = copySinkType ?? "MicrosoftAccessSink";
        }

        /// <summary> A query to execute before starting the copy. Type: string (or Expression with resultType string). </summary>
        public BinaryData PreCopyScript { get; set; }
    }
}
