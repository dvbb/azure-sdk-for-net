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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class P2SVpnGatewayData : IUtf8JsonSerializable, IJsonModel<P2SVpnGatewayData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<P2SVpnGatewayData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<P2SVpnGatewayData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SVpnGatewayData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(P2SVpnGatewayData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub"u8);
                JsonSerializer.Serialize(writer, VirtualHub);
            }
            if (Optional.IsCollectionDefined(P2SConnectionConfigurations))
            {
                writer.WritePropertyName("p2SConnectionConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in P2SConnectionConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(VpnGatewayScaleUnit))
            {
                writer.WritePropertyName("vpnGatewayScaleUnit"u8);
                writer.WriteNumberValue(VpnGatewayScaleUnit.Value);
            }
            if (Optional.IsDefined(VpnServerConfiguration))
            {
                writer.WritePropertyName("vpnServerConfiguration"u8);
                JsonSerializer.Serialize(writer, VpnServerConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(VpnClientConnectionHealth))
            {
                writer.WritePropertyName("vpnClientConnectionHealth"u8);
                writer.WriteObjectValue(VpnClientConnectionHealth);
            }
            if (Optional.IsCollectionDefined(CustomDnsServers))
            {
                writer.WritePropertyName("customDnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in CustomDnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsRoutingPreferenceInternet))
            {
                writer.WritePropertyName("isRoutingPreferenceInternet"u8);
                writer.WriteBooleanValue(IsRoutingPreferenceInternet.Value);
            }
            writer.WriteEndObject();
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

        P2SVpnGatewayData IJsonModel<P2SVpnGatewayData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SVpnGatewayData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(P2SVpnGatewayData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeP2SVpnGatewayData(document.RootElement, options);
        }

        internal static P2SVpnGatewayData DeserializeP2SVpnGatewayData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<WritableSubResource> virtualHub = default;
            Optional<IList<P2SConnectionConfiguration>> p2sConnectionConfigurations = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<int> vpnGatewayScaleUnit = default;
            Optional<WritableSubResource> vpnServerConfiguration = default;
            Optional<VpnClientConnectionHealth> vpnClientConnectionHealth = default;
            Optional<IList<string>> customDnsServers = default;
            Optional<bool> isRoutingPreferenceInternet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualHub"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualHub = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("p2SConnectionConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<P2SConnectionConfiguration> array = new List<P2SConnectionConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(P2SConnectionConfiguration.DeserializeP2SConnectionConfiguration(item));
                            }
                            p2sConnectionConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayScaleUnit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnGatewayScaleUnit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("vpnServerConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnServerConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("vpnClientConnectionHealth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnClientConnectionHealth = VpnClientConnectionHealth.DeserializeVpnClientConnectionHealth(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customDnsServers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            customDnsServers = array;
                            continue;
                        }
                        if (property0.NameEquals("isRoutingPreferenceInternet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isRoutingPreferenceInternet = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new P2SVpnGatewayData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), serializedAdditionalRawData, Optional.ToNullable(etag), virtualHub, Optional.ToList(p2sConnectionConfigurations), Optional.ToNullable(provisioningState), Optional.ToNullable(vpnGatewayScaleUnit), vpnServerConfiguration, vpnClientConnectionHealth.Value, Optional.ToList(customDnsServers), Optional.ToNullable(isRoutingPreferenceInternet));
        }

        BinaryData IPersistableModel<P2SVpnGatewayData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SVpnGatewayData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(P2SVpnGatewayData)} does not support '{options.Format}' format.");
            }
        }

        P2SVpnGatewayData IPersistableModel<P2SVpnGatewayData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SVpnGatewayData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeP2SVpnGatewayData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(P2SVpnGatewayData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<P2SVpnGatewayData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
