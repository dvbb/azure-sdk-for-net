// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RoutingTwinProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Desired))
            {
                writer.WritePropertyName("desired");
                writer.WriteObjectValue(Desired);
            }
            if (Optional.IsDefined(Reported))
            {
                writer.WritePropertyName("reported");
                writer.WriteObjectValue(Reported);
            }
            writer.WriteEndObject();
        }
    }
}
