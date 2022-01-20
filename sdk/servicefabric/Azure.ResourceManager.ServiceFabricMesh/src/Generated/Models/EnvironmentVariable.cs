// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    /// <summary> Describes an environment variable for the container. </summary>
    public partial class EnvironmentVariable
    {
        /// <summary> Initializes a new instance of EnvironmentVariable. </summary>
        public EnvironmentVariable()
        {
        }

        /// <summary> Initializes a new instance of EnvironmentVariable. </summary>
        /// <param name="name"> The name of the environment variable. </param>
        /// <param name="value"> The value of the environment variable. </param>
        internal EnvironmentVariable(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of the environment variable. </summary>
        public string Name { get; set; }
        /// <summary> The value of the environment variable. </summary>
        public string Value { get; set; }
    }
}
