// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List of all the entity queries. </summary>
    internal partial class EntityQueryList
    {
        /// <summary> Initializes a new instance of EntityQueryList. </summary>
        /// <param name="value"> Array of entity queries. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal EntityQueryList(IEnumerable<EntityQueryData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of EntityQueryList. </summary>
        /// <param name="nextLink"> URL to fetch the next set of entity queries. </param>
        /// <param name="value"> Array of entity queries. </param>
        internal EntityQueryList(string nextLink, IReadOnlyList<EntityQueryData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> URL to fetch the next set of entity queries. </summary>
        public string NextLink { get; }
        /// <summary> Array of entity queries. </summary>
        public IReadOnlyList<EntityQueryData> Value { get; }
    }
}
