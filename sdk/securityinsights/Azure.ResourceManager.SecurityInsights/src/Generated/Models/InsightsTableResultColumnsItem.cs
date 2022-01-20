// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The InsightsTableResultColumnsItem. </summary>
    public partial class InsightsTableResultColumnsItem
    {
        /// <summary> Initializes a new instance of InsightsTableResultColumnsItem. </summary>
        internal InsightsTableResultColumnsItem()
        {
        }

        /// <summary> Initializes a new instance of InsightsTableResultColumnsItem. </summary>
        /// <param name="type"> the type of the colum. </param>
        /// <param name="name"> the name of the colum. </param>
        internal InsightsTableResultColumnsItem(string type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <summary> the type of the colum. </summary>
        public string Type { get; }
        /// <summary> the name of the colum. </summary>
        public string Name { get; }
    }
}
