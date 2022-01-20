// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Import command settings. </summary>
    public partial class ImportSettings
    {
        /// <summary> Initializes a new instance of ImportSettings. </summary>
        public ImportSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
            Type = "ImportSettings";
        }

        /// <summary> Initializes a new instance of ImportSettings. </summary>
        /// <param name="type"> The import setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ImportSettings(string type, IDictionary<string, object> additionalProperties)
        {
            Type = type ?? "ImportSettings";
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The import setting type. </summary>
        internal string Type { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
