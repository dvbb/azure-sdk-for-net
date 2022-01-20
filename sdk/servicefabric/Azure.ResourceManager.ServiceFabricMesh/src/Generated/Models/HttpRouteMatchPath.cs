// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    /// <summary> Path to match for routing. </summary>
    public partial class HttpRouteMatchPath
    {
        /// <summary> Initializes a new instance of HttpRouteMatchPath. </summary>
        /// <param name="value"> Uri path to match for request. </param>
        /// <param name="type"> how to match value in the Uri. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HttpRouteMatchPath(string value, PathMatchType type)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
            Type = type;
        }

        /// <summary> Initializes a new instance of HttpRouteMatchPath. </summary>
        /// <param name="value"> Uri path to match for request. </param>
        /// <param name="rewrite"> replacement string for matched part of the Uri. </param>
        /// <param name="type"> how to match value in the Uri. </param>
        internal HttpRouteMatchPath(string value, string rewrite, PathMatchType type)
        {
            Value = value;
            Rewrite = rewrite;
            Type = type;
        }

        /// <summary> Uri path to match for request. </summary>
        public string Value { get; set; }
        /// <summary> replacement string for matched part of the Uri. </summary>
        public string Rewrite { get; set; }
        /// <summary> how to match value in the Uri. </summary>
        public PathMatchType Type { get; set; }
    }
}
