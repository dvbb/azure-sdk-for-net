// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class AgentPoolNetworkProfile : IUtf8JsonSerializable, IJsonModel<AgentPoolNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentPoolNetworkProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AgentPoolNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentPoolNetworkProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NodePublicIPTags))
            {
                writer.WritePropertyName("nodePublicIPTags"u8);
                writer.WriteStartArray();
                foreach (var item in NodePublicIPTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowedHostPorts))
            {
                writer.WritePropertyName("allowedHostPorts"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedHostPorts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationSecurityGroups))
            {
                writer.WritePropertyName("applicationSecurityGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationSecurityGroups)
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

        AgentPoolNetworkProfile IJsonModel<AgentPoolNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentPoolNetworkProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentPoolNetworkProfile(document.RootElement, options);
        }

        internal static AgentPoolNetworkProfile DeserializeAgentPoolNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ContainerServiceIPTag> nodePublicIPTags = default;
            IList<AgentPoolNetworkPortRange> allowedHostPorts = default;
            IList<ResourceIdentifier> applicationSecurityGroups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodePublicIPTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceIPTag> array = new List<ContainerServiceIPTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceIPTag.DeserializeContainerServiceIPTag(item, options));
                    }
                    nodePublicIPTags = array;
                    continue;
                }
                if (property.NameEquals("allowedHostPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AgentPoolNetworkPortRange> array = new List<AgentPoolNetworkPortRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AgentPoolNetworkPortRange.DeserializeAgentPoolNetworkPortRange(item, options));
                    }
                    allowedHostPorts = array;
                    continue;
                }
                if (property.NameEquals("applicationSecurityGroups"u8))
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
                    applicationSecurityGroups = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AgentPoolNetworkProfile(nodePublicIPTags ?? new ChangeTrackingList<ContainerServiceIPTag>(), allowedHostPorts ?? new ChangeTrackingList<AgentPoolNetworkPortRange>(), applicationSecurityGroups ?? new ChangeTrackingList<ResourceIdentifier>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AgentPoolNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AgentPoolNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        AgentPoolNetworkProfile IPersistableModel<AgentPoolNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgentPoolNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentPoolNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentPoolNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
