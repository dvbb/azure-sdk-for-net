// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class PlatformProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("os");
            writer.WriteStringValue(Os.ToString());
            if (Optional.IsDefined(Architecture))
            {
                writer.WritePropertyName("architecture");
                writer.WriteStringValue(Architecture.Value.ToString());
            }
            if (Optional.IsDefined(Variant))
            {
                writer.WritePropertyName("variant");
                writer.WriteStringValue(Variant.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static PlatformProperties DeserializePlatformProperties(JsonElement element)
        {
            OS os = default;
            Optional<Architecture> architecture = default;
            Optional<Variant> variant = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("os"))
                {
                    os = new OS(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("architecture"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    architecture = new Architecture(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("variant"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    variant = new Variant(property.Value.GetString());
                    continue;
                }
            }
            return new PlatformProperties(os, Optional.ToNullable(architecture), Optional.ToNullable(variant));
        }
    }
}
