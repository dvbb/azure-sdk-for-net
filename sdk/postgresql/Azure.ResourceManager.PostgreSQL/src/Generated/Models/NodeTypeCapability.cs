// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PostgreSQL.Models
{
    /// <summary> node type capability. </summary>
    public partial class NodeTypeCapability
    {
        /// <summary> Initializes a new instance of NodeTypeCapability. </summary>
        internal NodeTypeCapability()
        {
        }

        /// <summary> Initializes a new instance of NodeTypeCapability. </summary>
        /// <param name="name"> note type name. </param>
        /// <param name="nodeType"> note type. </param>
        /// <param name="status"> The status. </param>
        internal NodeTypeCapability(string name, string nodeType, string status)
        {
            Name = name;
            NodeType = nodeType;
            Status = status;
        }

        /// <summary> note type name. </summary>
        public string Name { get; }
        /// <summary> note type. </summary>
        public string NodeType { get; }
        /// <summary> The status. </summary>
        public string Status { get; }
    }
}
