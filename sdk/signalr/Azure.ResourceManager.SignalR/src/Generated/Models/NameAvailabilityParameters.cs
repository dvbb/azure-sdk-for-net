// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Data POST-ed to the nameAvailability action. </summary>
    public partial class NameAvailabilityParameters
    {
        /// <summary> Initializes a new instance of NameAvailabilityParameters. </summary>
        /// <param name="type"> The resource type. Can be &quot;Microsoft.SignalRService/SignalR&quot; or &quot;Microsoft.SignalRService/webPubSub&quot;. </param>
        /// <param name="name"> The resource name to validate. e.g.&quot;my-resource-name&quot;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="name"/> is null. </exception>
        public NameAvailabilityParameters(string type, string name)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Type = type;
            Name = name;
        }

        /// <summary> The resource type. Can be &quot;Microsoft.SignalRService/SignalR&quot; or &quot;Microsoft.SignalRService/webPubSub&quot;. </summary>
        public string Type { get; }
        /// <summary> The resource name to validate. e.g.&quot;my-resource-name&quot;. </summary>
        public string Name { get; }
    }
}
