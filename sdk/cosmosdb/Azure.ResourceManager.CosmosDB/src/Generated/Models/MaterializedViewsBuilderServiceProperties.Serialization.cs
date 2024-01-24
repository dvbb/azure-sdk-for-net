// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MaterializedViewsBuilderServiceProperties : IUtf8JsonSerializable, IJsonModel<MaterializedViewsBuilderServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaterializedViewsBuilderServiceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MaterializedViewsBuilderServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewsBuilderServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaterializedViewsBuilderServiceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(InstanceSize))
            {
                writer.WritePropertyName("instanceSize"u8);
                writer.WriteStringValue(InstanceSize.Value.ToString());
            }
            if (Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount"u8);
                writer.WriteNumberValue(InstanceCount.Value);
            }
            writer.WritePropertyName("serviceType"u8);
            writer.WriteStringValue(ServiceType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        MaterializedViewsBuilderServiceProperties IJsonModel<MaterializedViewsBuilderServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewsBuilderServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaterializedViewsBuilderServiceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaterializedViewsBuilderServiceProperties(document.RootElement, options);
        }

        internal static MaterializedViewsBuilderServiceProperties DeserializeMaterializedViewsBuilderServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MaterializedViewsBuilderRegionalService>> locations = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<CosmosDBServiceSize> instanceSize = default;
            Optional<int> instanceCount = default;
            CosmosDBServiceType serviceType = default;
            Optional<CosmosDBServiceStatus> status = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaterializedViewsBuilderRegionalService> array = new List<MaterializedViewsBuilderRegionalService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaterializedViewsBuilderRegionalService.DeserializeMaterializedViewsBuilderRegionalService(item));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("instanceSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceSize = new CosmosDBServiceSize(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceType"u8))
                {
                    serviceType = new CosmosDBServiceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new CosmosDBServiceStatus(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new MaterializedViewsBuilderServiceProperties(Optional.ToNullable(creationTime), Optional.ToNullable(instanceSize), Optional.ToNullable(instanceCount), serviceType, Optional.ToNullable(status), additionalProperties, Optional.ToList(locations));
        }

        BinaryData IPersistableModel<MaterializedViewsBuilderServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewsBuilderServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MaterializedViewsBuilderServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        MaterializedViewsBuilderServiceProperties IPersistableModel<MaterializedViewsBuilderServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewsBuilderServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMaterializedViewsBuilderServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaterializedViewsBuilderServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaterializedViewsBuilderServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
