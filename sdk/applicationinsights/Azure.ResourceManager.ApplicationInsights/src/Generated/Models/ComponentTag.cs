// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> A container holding only the Tags for a resource, allowing the user to update the tags on a WebTest instance. </summary>
    public partial class ComponentTag
    {
        /// <summary> Initializes a new instance of <see cref="ComponentTag"/>. </summary>
        public ComponentTag()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ComponentTag"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        internal ComponentTag(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
