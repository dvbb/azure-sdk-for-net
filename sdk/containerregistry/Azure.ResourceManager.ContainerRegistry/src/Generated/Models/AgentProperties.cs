// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties that determine the run agent configuration. </summary>
    public partial class AgentProperties
    {
        /// <summary> Initializes a new instance of AgentProperties. </summary>
        public AgentProperties()
        {
        }

        /// <summary> Initializes a new instance of AgentProperties. </summary>
        /// <param name="cpu"> The CPU configuration in terms of number of cores required for the run. </param>
        internal AgentProperties(int? cpu)
        {
            Cpu = cpu;
        }

        /// <summary> The CPU configuration in terms of number of cores required for the run. </summary>
        public int? Cpu { get; set; }
    }
}
