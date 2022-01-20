// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logz.Models
{
    /// <summary> VM Resource Ids. </summary>
    public partial class VMResources
    {
        /// <summary> Initializes a new instance of VMResources. </summary>
        public VMResources()
        {
        }

        /// <summary> Initializes a new instance of VMResources. </summary>
        /// <param name="id"> Request of a list vm host update operation. </param>
        /// <param name="agentVersion"> Version of the Logz agent installed on the VM. </param>
        internal VMResources(string id, string agentVersion)
        {
            Id = id;
            AgentVersion = agentVersion;
        }

        /// <summary> Request of a list vm host update operation. </summary>
        public string Id { get; set; }
        /// <summary> Version of the Logz agent installed on the VM. </summary>
        public string AgentVersion { get; set; }
    }
}
