// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverBulkRemoveContent : IUtf8JsonSerializable, IJsonModel<MoverBulkRemoveContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverBulkRemoveContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoverBulkRemoveContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverBulkRemoveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverBulkRemoveContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ValidateOnly))
            {
                writer.WritePropertyName("validateOnly"u8);
                writer.WriteBooleanValue(ValidateOnly.Value);
            }
            if (Optional.IsCollectionDefined(MoverResources))
            {
                writer.WritePropertyName("moveResources"u8);
                writer.WriteStartArray();
                foreach (var item in MoverResources)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MoverResourceInputType))
            {
                writer.WritePropertyName("moveResourceInputType"u8);
                writer.WriteStringValue(MoverResourceInputType.Value.ToString());
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

        MoverBulkRemoveContent IJsonModel<MoverBulkRemoveContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverBulkRemoveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverBulkRemoveContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverBulkRemoveContent(document.RootElement, options);
        }

        internal static MoverBulkRemoveContent DeserializeMoverBulkRemoveContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? validateOnly = default;
            IList<ResourceIdentifier> moveResources = default;
            MoverResourceInputType? moveResourceInputType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validateOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("moveResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    moveResources = array;
                    continue;
                }
                if (property.NameEquals("moveResourceInputType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveResourceInputType = new MoverResourceInputType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoverBulkRemoveContent(validateOnly, moveResources ?? new ChangeTrackingList<ResourceIdentifier>(), moveResourceInputType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverBulkRemoveContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverBulkRemoveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MoverBulkRemoveContent)} does not support '{options.Format}' format.");
            }
        }

        MoverBulkRemoveContent IPersistableModel<MoverBulkRemoveContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverBulkRemoveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoverBulkRemoveContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoverBulkRemoveContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverBulkRemoveContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
