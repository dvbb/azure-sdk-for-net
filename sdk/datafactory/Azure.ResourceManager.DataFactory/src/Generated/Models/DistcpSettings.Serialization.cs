// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DistcpSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceManagerEndpoint");
            writer.WriteObjectValue(ResourceManagerEndpoint);
            writer.WritePropertyName("tempScriptPath");
            writer.WriteObjectValue(TempScriptPath);
            if (Optional.IsDefined(DistcpOptions))
            {
                writer.WritePropertyName("distcpOptions");
                writer.WriteObjectValue(DistcpOptions);
            }
            writer.WriteEndObject();
        }

        internal static DistcpSettings DeserializeDistcpSettings(JsonElement element)
        {
            object resourceManagerEndpoint = default;
            object tempScriptPath = default;
            Optional<object> distcpOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceManagerEndpoint"))
                {
                    resourceManagerEndpoint = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("tempScriptPath"))
                {
                    tempScriptPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("distcpOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    distcpOptions = property.Value.GetObject();
                    continue;
                }
            }
            return new DistcpSettings(resourceManagerEndpoint, tempScriptPath, distcpOptions.Value);
        }
    }
}
