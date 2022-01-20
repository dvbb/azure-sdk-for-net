// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Error details. </summary>
    public partial class ErrorDetails
    {
        /// <summary> Initializes a new instance of ErrorDetails. </summary>
        internal ErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of ErrorDetails. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="httpStatusCode"> The HTTP status code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="details"> The error details. </param>
        internal ErrorDetails(string code, string httpStatusCode, string message, string details)
        {
            Code = code;
            HttpStatusCode = httpStatusCode;
            Message = message;
            Details = details;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The HTTP status code. </summary>
        public string HttpStatusCode { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The error details. </summary>
        public string Details { get; }
    }
}
