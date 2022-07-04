// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes how data from an input is serialized or how data is serialized when written to an output in CSV format. </summary>
    public partial class CsvSerialization : Serialization
    {
        /// <summary> Initializes a new instance of CsvSerialization. </summary>
        public CsvSerialization()
        {
            EventSerializationType = EventSerializationType.Csv;
        }

        /// <summary> Initializes a new instance of CsvSerialization. </summary>
        /// <param name="eventSerializationType"> Indicates the type of serialization that the input or output uses. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="fieldDelimiter"> Specifies the delimiter that will be used to separate comma-separated value (CSV) records. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a list of supported values. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="encoding"> Specifies the encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. Required on PUT (CreateOrReplace) requests. </param>
        internal CsvSerialization(EventSerializationType eventSerializationType, string fieldDelimiter, StreamEncoding? encoding) : base(eventSerializationType)
        {
            FieldDelimiter = fieldDelimiter;
            Encoding = encoding;
            EventSerializationType = eventSerializationType;
        }

        /// <summary> Specifies the delimiter that will be used to separate comma-separated value (CSV) records. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a list of supported values. Required on PUT (CreateOrReplace) requests. </summary>
        public string FieldDelimiter { get; set; }
        /// <summary> Specifies the encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. Required on PUT (CreateOrReplace) requests. </summary>
        public StreamEncoding? Encoding { get; set; }
    }
}
