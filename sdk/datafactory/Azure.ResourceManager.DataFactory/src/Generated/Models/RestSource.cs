// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Rest service source. </summary>
    public partial class RestSource : CopySource
    {
        /// <summary> Initializes a new instance of RestSource. </summary>
        public RestSource()
        {
            Type = "RestSource";
        }

        /// <summary> Initializes a new instance of RestSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="requestMethod"> The HTTP method used to call the RESTful API. The default is GET. Type: string (or Expression with resultType string). </param>
        /// <param name="requestBody"> The HTTP request body to the RESTful API if requestMethod is POST. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalHeaders"> The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string). </param>
        /// <param name="paginationRules"> The pagination rules to compose next page requests. Type: string (or Expression with resultType string). </param>
        /// <param name="httpRequestTimeout"> The timeout (TimeSpan) to get an HTTP response. It is the timeout to get a response, not the timeout to read response data. Default value: 00:01:40. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="requestInterval"> The time to await before sending next page request. </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal RestSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, object disableMetricsCollection, IDictionary<string, object> additionalProperties, object requestMethod, object requestBody, object additionalHeaders, object paginationRules, object httpRequestTimeout, object requestInterval, object additionalColumns) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            RequestMethod = requestMethod;
            RequestBody = requestBody;
            AdditionalHeaders = additionalHeaders;
            PaginationRules = paginationRules;
            HttpRequestTimeout = httpRequestTimeout;
            RequestInterval = requestInterval;
            AdditionalColumns = additionalColumns;
            Type = type ?? "RestSource";
        }

        /// <summary> The HTTP method used to call the RESTful API. The default is GET. Type: string (or Expression with resultType string). </summary>
        public object RequestMethod { get; set; }
        /// <summary> The HTTP request body to the RESTful API if requestMethod is POST. Type: string (or Expression with resultType string). </summary>
        public object RequestBody { get; set; }
        /// <summary> The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string). </summary>
        public object AdditionalHeaders { get; set; }
        /// <summary> The pagination rules to compose next page requests. Type: string (or Expression with resultType string). </summary>
        public object PaginationRules { get; set; }
        /// <summary> The timeout (TimeSpan) to get an HTTP response. It is the timeout to get a response, not the timeout to read response data. Default value: 00:01:40. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public object HttpRequestTimeout { get; set; }
        /// <summary> The time to await before sending next page request. </summary>
        public object RequestInterval { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public object AdditionalColumns { get; set; }
    }
}
