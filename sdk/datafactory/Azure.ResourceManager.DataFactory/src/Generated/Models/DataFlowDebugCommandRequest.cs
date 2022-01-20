// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Request body structure for data flow debug command. </summary>
    public partial class DataFlowDebugCommandRequest
    {
        /// <summary> Initializes a new instance of DataFlowDebugCommandRequest. </summary>
        public DataFlowDebugCommandRequest()
        {
        }

        /// <summary> The ID of data flow debug session. </summary>
        public string SessionId { get; set; }
        /// <summary> The command type. </summary>
        public DataFlowDebugCommandType? Command { get; set; }
        /// <summary> The command payload object. </summary>
        public DataFlowDebugCommandPayload CommandPayload { get; set; }
    }
}
