// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowTriggerCallbackUri : IUtf8JsonSerializable, IJsonModel<LogicWorkflowTriggerCallbackUri>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkflowTriggerCallbackUri>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicWorkflowTriggerCallbackUri>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowTriggerCallbackUri>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowTriggerCallbackUri)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(BasePath))
            {
                writer.WritePropertyName("basePath"u8);
                writer.WriteStringValue(BasePath);
            }
            if (options.Format != "W" && Optional.IsDefined(RelativePath))
            {
                writer.WritePropertyName("relativePath"u8);
                writer.WriteStringValue(RelativePath);
            }
            if (Optional.IsCollectionDefined(RelativePathParameters))
            {
                writer.WritePropertyName("relativePathParameters"u8);
                writer.WriteStartArray();
                foreach (var item in RelativePathParameters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Queries))
            {
                writer.WritePropertyName("queries"u8);
                writer.WriteObjectValue(Queries);
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

        LogicWorkflowTriggerCallbackUri IJsonModel<LogicWorkflowTriggerCallbackUri>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowTriggerCallbackUri>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowTriggerCallbackUri)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowTriggerCallbackUri(document.RootElement, options);
        }

        internal static LogicWorkflowTriggerCallbackUri DeserializeLogicWorkflowTriggerCallbackUri(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> value = default;
            Optional<RequestMethod> method = default;
            Optional<string> basePath = default;
            Optional<string> relativePath = default;
            Optional<IReadOnlyList<string>> relativePathParameters = default;
            Optional<LogicWorkflowTriggerCallbackQueryParameterInfo> queries = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("method"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    method = new RequestMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("basePath"u8))
                {
                    basePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativePathParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    relativePathParameters = array;
                    continue;
                }
                if (property.NameEquals("queries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queries = LogicWorkflowTriggerCallbackQueryParameterInfo.DeserializeLogicWorkflowTriggerCallbackQueryParameterInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicWorkflowTriggerCallbackUri(value.Value, Optional.ToNullable(method), basePath.Value, relativePath.Value, Optional.ToList(relativePathParameters), queries.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicWorkflowTriggerCallbackUri>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowTriggerCallbackUri>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowTriggerCallbackUri)} does not support '{options.Format}' format.");
            }
        }

        LogicWorkflowTriggerCallbackUri IPersistableModel<LogicWorkflowTriggerCallbackUri>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowTriggerCallbackUri>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicWorkflowTriggerCallbackUri(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowTriggerCallbackUri)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicWorkflowTriggerCallbackUri>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
