// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class VirtualApplication : IUtf8JsonSerializable, IJsonModel<VirtualApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualApplication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualApplication)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualPath))
            {
                writer.WritePropertyName("virtualPath"u8);
                writer.WriteStringValue(VirtualPath);
            }
            if (Optional.IsDefined(PhysicalPath))
            {
                writer.WritePropertyName("physicalPath"u8);
                writer.WriteStringValue(PhysicalPath);
            }
            if (Optional.IsDefined(IsPreloadEnabled))
            {
                writer.WritePropertyName("preloadEnabled"u8);
                writer.WriteBooleanValue(IsPreloadEnabled.Value);
            }
            if (Optional.IsCollectionDefined(VirtualDirectories))
            {
                writer.WritePropertyName("virtualDirectories"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualDirectories)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        VirtualApplication IJsonModel<VirtualApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualApplication)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualApplication(document.RootElement, options);
        }

        internal static VirtualApplication DeserializeVirtualApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> virtualPath = default;
            Optional<string> physicalPath = default;
            Optional<bool> preloadEnabled = default;
            Optional<IList<VirtualDirectory>> virtualDirectories = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualPath"u8))
                {
                    virtualPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalPath"u8))
                {
                    physicalPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preloadEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preloadEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("virtualDirectories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualDirectory> array = new List<VirtualDirectory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualDirectory.DeserializeVirtualDirectory(item, options));
                    }
                    virtualDirectories = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualApplication(virtualPath.Value, physicalPath.Value, Optional.ToNullable(preloadEnabled), Optional.ToList(virtualDirectories), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualApplication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualApplication)} does not support '{options.Format}' format.");
            }
        }

        VirtualApplication IPersistableModel<VirtualApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualApplication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualApplication)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualApplication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
