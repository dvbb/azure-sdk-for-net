// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    /// <summary> The details of the error for which the alert was raised. </summary>
    public partial class AlertErrorDetails
    {
        /// <summary> Initializes a new instance of AlertErrorDetails. </summary>
        public AlertErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of AlertErrorDetails. </summary>
        /// <param name="errorCode"> The error code. </param>
        /// <param name="errorMessage"> The error message. </param>
        /// <param name="occurences"> The number of occurrences. </param>
        internal AlertErrorDetails(string errorCode, string errorMessage, int? occurences)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            Occurences = occurences;
        }

        /// <summary> The error code. </summary>
        public string ErrorCode { get; set; }
        /// <summary> The error message. </summary>
        public string ErrorMessage { get; set; }
        /// <summary> The number of occurrences. </summary>
        public int? Occurences { get; set; }
    }
}
