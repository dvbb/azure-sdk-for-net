// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Format read settings. </summary>
    public partial class FormatReadSettings
    {
        /// <summary> Initializes a new instance of FormatReadSettings. </summary>
        public FormatReadSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
            Type = "FormatReadSettings";
        }

        /// <summary> Initializes a new instance of FormatReadSettings. </summary>
        /// <param name="type"> The read setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal FormatReadSettings(string type, IDictionary<string, object> additionalProperties)
        {
            Type = type ?? "FormatReadSettings";
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The read setting type. </summary>
        internal string Type { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
