// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    /// <summary> Describes a setting for the container. The setting file path can be fetched from environment variable &quot;Fabric_SettingPath&quot;. The path for Windows container is &quot;C:\\secrets&quot;. The path for Linux container is &quot;/var/secrets&quot;. </summary>
    public partial class Setting
    {
        /// <summary> Initializes a new instance of Setting. </summary>
        public Setting()
        {
        }

        /// <summary> Initializes a new instance of Setting. </summary>
        /// <param name="name"> The name of the setting. </param>
        /// <param name="value"> The value of the setting. </param>
        internal Setting(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of the setting. </summary>
        public string Name { get; set; }
        /// <summary> The value of the setting. </summary>
        public string Value { get; set; }
    }
}
