// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class P2sVpnGatewayData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub");
                JsonSerializer.Serialize(writer, VirtualHub);
            }
            if (Optional.IsCollectionDefined(P2sConnectionConfigurations))
            {
                writer.WritePropertyName("p2SConnectionConfigurations");
                writer.WriteStartArray();
                foreach (var item in P2sConnectionConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VpnGatewayScaleUnit))
            {
                writer.WritePropertyName("vpnGatewayScaleUnit");
                writer.WriteNumberValue(VpnGatewayScaleUnit.Value);
            }
            if (Optional.IsDefined(VpnServerConfiguration))
            {
                writer.WritePropertyName("vpnServerConfiguration");
                JsonSerializer.Serialize(writer, VpnServerConfiguration);
            }
            if (Optional.IsCollectionDefined(CustomDnsServers))
            {
                writer.WritePropertyName("customDnsServers");
                writer.WriteStartArray();
                foreach (var item in CustomDnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsRoutingPreferenceInternet))
            {
                writer.WritePropertyName("isRoutingPreferenceInternet");
                writer.WriteBooleanValue(IsRoutingPreferenceInternet.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static P2sVpnGatewayData DeserializeP2sVpnGatewayData(JsonElement element)
        {
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<WritableSubResource> virtualHub = default;
            Optional<IList<P2sConnectionConfiguration>> p2SConnectionConfigurations = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<int> vpnGatewayScaleUnit = default;
            Optional<WritableSubResource> vpnServerConfiguration = default;
            Optional<VpnClientConnectionHealth> vpnClientConnectionHealth = default;
            Optional<IList<string>> customDnsServers = default;
            Optional<bool> isRoutingPreferenceInternet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualHub"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualHub = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("p2SConnectionConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<P2sConnectionConfiguration> array = new List<P2sConnectionConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(P2sConnectionConfiguration.DeserializeP2sConnectionConfiguration(item));
                            }
                            p2SConnectionConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayScaleUnit"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vpnGatewayScaleUnit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("vpnServerConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vpnServerConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("vpnClientConnectionHealth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vpnClientConnectionHealth = VpnClientConnectionHealth.DeserializeVpnClientConnectionHealth(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customDnsServers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
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
                        if (property0.NameEquals("isRoutingPreferenceInternet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isRoutingPreferenceInternet = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new P2sVpnGatewayData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), Optional.ToNullable(etag), virtualHub, Optional.ToList(p2SConnectionConfigurations), Optional.ToNullable(provisioningState), Optional.ToNullable(vpnGatewayScaleUnit), vpnServerConfiguration, vpnClientConnectionHealth.Value, Optional.ToList(customDnsServers), Optional.ToNullable(isRoutingPreferenceInternet));
        }
    }
}
