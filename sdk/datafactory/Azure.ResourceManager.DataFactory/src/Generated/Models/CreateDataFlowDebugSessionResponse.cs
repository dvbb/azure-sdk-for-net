// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Response body structure for creating data flow debug session. </summary>
    public partial class CreateDataFlowDebugSessionResponse
    {
        /// <summary> Initializes a new instance of CreateDataFlowDebugSessionResponse. </summary>
        internal CreateDataFlowDebugSessionResponse()
        {
        }

        /// <summary> Initializes a new instance of CreateDataFlowDebugSessionResponse. </summary>
        /// <param name="status"> The state of the debug session. </param>
        /// <param name="sessionId"> The ID of data flow debug session. </param>
        internal CreateDataFlowDebugSessionResponse(string status, string sessionId)
        {
            Status = status;
            SessionId = sessionId;
        }

        /// <summary> The state of the debug session. </summary>
        public string Status { get; }
        /// <summary> The ID of data flow debug session. </summary>
        public string SessionId { get; }
    }
}
