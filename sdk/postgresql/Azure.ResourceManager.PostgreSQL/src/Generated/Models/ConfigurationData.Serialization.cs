// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSQL.Models;

namespace Azure.ResourceManager.PostgreSQL
{
    public partial class ConfigurationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ConfigurationData DeserializeConfigurationData(JsonElement element)
        {
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> value = default;
            Optional<string> description = default;
            Optional<string> defaultValue = default;
            Optional<ConfigurationDataType> dataType = default;
            Optional<string> allowedValues = default;
            Optional<string> source = default;
            Optional<bool> isDynamicConfig = default;
            Optional<bool> isReadOnly = default;
            Optional<bool> isConfigPendingRestart = default;
            Optional<string> unit = default;
            Optional<string> documentationLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("value"))
                        {
                            value = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultValue"))
                        {
                            defaultValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataType = new ConfigurationDataType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowedValues"))
                        {
                            allowedValues = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDynamicConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDynamicConfig = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isReadOnly"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isReadOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isConfigPendingRestart"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isConfigPendingRestart = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("unit"))
                        {
                            unit = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentationLink"))
                        {
                            documentationLink = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConfigurationData(id, name, type, systemData, value.Value, description.Value, defaultValue.Value, Optional.ToNullable(dataType), allowedValues.Value, source.Value, Optional.ToNullable(isDynamicConfig), Optional.ToNullable(isReadOnly), Optional.ToNullable(isConfigPendingRestart), unit.Value, documentationLink.Value);
        }
    }
}
