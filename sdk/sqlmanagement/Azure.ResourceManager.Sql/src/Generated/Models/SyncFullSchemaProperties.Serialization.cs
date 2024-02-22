// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncFullSchemaProperties : IUtf8JsonSerializable, IJsonModel<SyncFullSchemaProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncFullSchemaProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SyncFullSchemaProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncFullSchemaProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Tables))
            {
                writer.WritePropertyName("tables"u8);
                writer.WriteStartArray();
                foreach (var item in Tables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LastUpdateOn))
            {
                writer.WritePropertyName("lastUpdateTime"u8);
                writer.WriteStringValue(LastUpdateOn.Value, "O");
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

        SyncFullSchemaProperties IJsonModel<SyncFullSchemaProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncFullSchemaProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncFullSchemaProperties(document.RootElement, options);
        }

        internal static SyncFullSchemaProperties DeserializeSyncFullSchemaProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SyncFullSchemaTable>> tables = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyncFullSchemaTable> array = new List<SyncFullSchemaTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncFullSchemaTable.DeserializeSyncFullSchemaTable(item, options));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SyncFullSchemaProperties(Optional.ToList(tables), Optional.ToNullable(lastUpdateTime), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SyncFullSchemaProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SyncFullSchemaProperties)} does not support '{options.Format}' format.");
            }
        }

        SyncFullSchemaProperties IPersistableModel<SyncFullSchemaProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncFullSchemaProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyncFullSchemaProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncFullSchemaProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
