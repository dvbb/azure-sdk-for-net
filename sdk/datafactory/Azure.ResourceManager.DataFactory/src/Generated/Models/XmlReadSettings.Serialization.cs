// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class XmlReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CompressionProperties))
            {
                writer.WritePropertyName("compressionProperties");
                writer.WriteObjectValue(CompressionProperties);
            }
            if (Optional.IsDefined(ValidationMode))
            {
                writer.WritePropertyName("validationMode");
                writer.WriteObjectValue(ValidationMode);
            }
            if (Optional.IsDefined(DetectDataType))
            {
                writer.WritePropertyName("detectDataType");
                writer.WriteObjectValue(DetectDataType);
            }
            if (Optional.IsDefined(Namespaces))
            {
                writer.WritePropertyName("namespaces");
                writer.WriteObjectValue(Namespaces);
            }
            if (Optional.IsDefined(NamespacePrefixes))
            {
                writer.WritePropertyName("namespacePrefixes");
                writer.WriteObjectValue(NamespacePrefixes);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static XmlReadSettings DeserializeXmlReadSettings(JsonElement element)
        {
            Optional<CompressionReadSettings> compressionProperties = default;
            Optional<object> validationMode = default;
            Optional<object> detectDataType = default;
            Optional<object> namespaces = default;
            Optional<object> namespacePrefixes = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compressionProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    compressionProperties = CompressionReadSettings.DeserializeCompressionReadSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("validationMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validationMode = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("detectDataType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    detectDataType = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("namespaces"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    namespaces = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("namespacePrefixes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    namespacePrefixes = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new XmlReadSettings(type, additionalProperties, compressionProperties.Value, validationMode.Value, detectDataType.Value, namespaces.Value, namespacePrefixes.Value);
        }
    }
}
