// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> An error produced by the compiler. </summary>
    public partial class StreamAnalyticsQueryCompilationError
    {
        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryCompilationError"/>. </summary>
        internal StreamAnalyticsQueryCompilationError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryCompilationError"/>. </summary>
        /// <param name="message"> The content of the error message. </param>
        /// <param name="startLine"> Describes the error location in the original query. Not set if isGlobal is true. </param>
        /// <param name="startColumn"> Describes the error location in the original query. Not set if isGlobal is true. </param>
        /// <param name="endLine"> Describes the error location in the original query. Not set if isGlobal is true. </param>
        /// <param name="endColumn"> Describes the error location in the original query. Not set if isGlobal is true. </param>
        /// <param name="isGlobal"> Whether the error is not for a specific part but for the entire query. </param>
        internal StreamAnalyticsQueryCompilationError(string message, int? startLine, int? startColumn, int? endLine, int? endColumn, bool? isGlobal)
        {
            Message = message;
            StartLine = startLine;
            StartColumn = startColumn;
            EndLine = endLine;
            EndColumn = endColumn;
            IsGlobal = isGlobal;
        }

        /// <summary> The content of the error message. </summary>
        public string Message { get; }
        /// <summary> Describes the error location in the original query. Not set if isGlobal is true. </summary>
        public int? StartLine { get; }
        /// <summary> Describes the error location in the original query. Not set if isGlobal is true. </summary>
        public int? StartColumn { get; }
        /// <summary> Describes the error location in the original query. Not set if isGlobal is true. </summary>
        public int? EndLine { get; }
        /// <summary> Describes the error location in the original query. Not set if isGlobal is true. </summary>
        public int? EndColumn { get; }
        /// <summary> Whether the error is not for a specific part but for the entire query. </summary>
        public bool? IsGlobal { get; }
    }
}
