// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedCassandraTableResourceInfo : IUtf8JsonSerializable, IJsonModel<ExtendedCassandraTableResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedCassandraTableResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExtendedCassandraTableResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCassandraTableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedCassandraTableResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Rid))
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("_ts"u8);
                writer.WriteNumberValue(Timestamp.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("_etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(TableName);
            if (Optional.IsDefined(DefaultTtl))
            {
                writer.WritePropertyName("defaultTtl"u8);
                writer.WriteNumberValue(DefaultTtl.Value);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteObjectValue(Schema);
            }
            if (Optional.IsDefined(AnalyticalStorageTtl))
            {
                writer.WritePropertyName("analyticalStorageTtl"u8);
                writer.WriteNumberValue(AnalyticalStorageTtl.Value);
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

        ExtendedCassandraTableResourceInfo IJsonModel<ExtendedCassandraTableResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCassandraTableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedCassandraTableResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedCassandraTableResourceInfo(document.RootElement, options);
        }

        internal static ExtendedCassandraTableResourceInfo DeserializeExtendedCassandraTableResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<ETag> etag = default;
            string id = default;
            Optional<int> defaultTtl = default;
            Optional<CassandraSchema> schema = default;
            Optional<int> analyticalStorageTtl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultTtl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = CassandraSchema.DeserializeCassandraSchema(property.Value, options);
                    continue;
                }
                if (property.NameEquals("analyticalStorageTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticalStorageTtl = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExtendedCassandraTableResourceInfo(id, Optional.ToNullable(defaultTtl), schema.Value, Optional.ToNullable(analyticalStorageTtl), serializedAdditionalRawData, rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag));
        }

        BinaryData IPersistableModel<ExtendedCassandraTableResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCassandraTableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedCassandraTableResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        ExtendedCassandraTableResourceInfo IPersistableModel<ExtendedCassandraTableResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCassandraTableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedCassandraTableResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtendedCassandraTableResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedCassandraTableResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
