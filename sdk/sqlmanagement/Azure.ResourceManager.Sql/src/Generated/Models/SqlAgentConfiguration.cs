// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A recoverable managed database resource. </summary>
    public partial class SqlAgentConfiguration : ProxyResource
    {
        /// <summary> Initializes a new instance of SqlAgentConfiguration. </summary>
        public SqlAgentConfiguration()
        {
        }

        /// <summary> Initializes a new instance of SqlAgentConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="state"> The state of Sql Agent. </param>
        internal SqlAgentConfiguration(string id, string name, string type, SqlAgentConfigurationPropertiesState? state) : base(id, name, type)
        {
            State = state;
        }

        /// <summary> The state of Sql Agent. </summary>
        public SqlAgentConfigurationPropertiesState? State { get; set; }
    }
}
