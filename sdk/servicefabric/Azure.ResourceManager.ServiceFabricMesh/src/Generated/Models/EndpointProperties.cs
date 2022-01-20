// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    /// <summary> Describes a container endpoint. </summary>
    public partial class EndpointProperties
    {
        /// <summary> Initializes a new instance of EndpointProperties. </summary>
        /// <param name="name"> The name of the endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public EndpointProperties(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of EndpointProperties. </summary>
        /// <param name="name"> The name of the endpoint. </param>
        /// <param name="port"> Port used by the container. </param>
        internal EndpointProperties(string name, int? port)
        {
            Name = name;
            Port = port;
        }

        /// <summary> The name of the endpoint. </summary>
        public string Name { get; set; }
        /// <summary> Port used by the container. </summary>
        public int? Port { get; set; }
    }
}
