// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> The error details. </summary>
    internal partial class ServiceErrorDetail
    {
        /// <summary> Initializes a new instance of ServiceErrorDetail. </summary>
        internal ServiceErrorDetail()
        {
        }

        /// <summary> Initializes a new instance of ServiceErrorDetail. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="target"> The target of the error. </param>
        internal ServiceErrorDetail(string code, string message, string target)
        {
            Code = code;
            Message = message;
            Target = target;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The target of the error. </summary>
        public string Target { get; }
    }
}
