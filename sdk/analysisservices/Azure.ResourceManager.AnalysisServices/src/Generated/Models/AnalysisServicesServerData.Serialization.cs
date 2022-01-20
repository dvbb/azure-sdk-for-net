// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AnalysisServices.Models;

namespace Azure.ResourceManager.AnalysisServices
{
    public partial class AnalysisServicesServerData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sku");
            writer.WriteObjectValue(Sku);
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AsAdministrators))
            {
                writer.WritePropertyName("asAdministrators");
                writer.WriteObjectValue(AsAdministrators);
            }
            if (Optional.IsDefined(BackupBlobContainerUri))
            {
                writer.WritePropertyName("backupBlobContainerUri");
                writer.WriteStringValue(BackupBlobContainerUri);
            }
            if (Optional.IsDefined(GatewayDetails))
            {
                writer.WritePropertyName("gatewayDetails");
                writer.WriteObjectValue(GatewayDetails);
            }
            if (Optional.IsDefined(IpV4FirewallSettings))
            {
                writer.WritePropertyName("ipV4FirewallSettings");
                writer.WriteObjectValue(IpV4FirewallSettings);
            }
            if (Optional.IsDefined(QuerypoolConnectionMode))
            {
                writer.WritePropertyName("querypoolConnectionMode");
                writer.WriteStringValue(QuerypoolConnectionMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(ManagedMode))
            {
                writer.WritePropertyName("managedMode");
                writer.WriteStringValue(ManagedMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(ServerMonitorMode))
            {
                writer.WritePropertyName("serverMonitorMode");
                writer.WriteStringValue(ServerMonitorMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(SkuPropertiesSku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(SkuPropertiesSku);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AnalysisServicesServerData DeserializeAnalysisServicesServerData(JsonElement element)
        {
            ResourceSku sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<ServerAdministrators> asAdministrators = default;
            Optional<string> backupBlobContainerUri = default;
            Optional<GatewayDetails> gatewayDetails = default;
            Optional<IPv4FirewallSettings> ipV4FirewallSettings = default;
            Optional<ConnectionMode> querypoolConnectionMode = default;
            Optional<ManagedMode> managedMode = default;
            Optional<ServerMonitorMode> serverMonitorMode = default;
            Optional<State> state = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> serverFullName = default;
            Optional<ResourceSku> sku0 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    sku = ResourceSku.DeserializeResourceSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
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
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("asAdministrators"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            asAdministrators = ServerAdministrators.DeserializeServerAdministrators(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backupBlobContainerUri"))
                        {
                            backupBlobContainerUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("gatewayDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            gatewayDetails = GatewayDetails.DeserializeGatewayDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipV4FirewallSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ipV4FirewallSettings = IPv4FirewallSettings.DeserializeIPv4FirewallSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("querypoolConnectionMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            querypoolConnectionMode = property0.Value.GetString().ToConnectionMode();
                            continue;
                        }
                        if (property0.NameEquals("managedMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            managedMode = property0.Value.GetInt32().ToManagedMode();
                            continue;
                        }
                        if (property0.NameEquals("serverMonitorMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serverMonitorMode = property0.Value.GetInt32().ToServerMonitorMode();
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new State(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serverFullName"))
                        {
                            serverFullName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sku0 = ResourceSku.DeserializeResourceSku(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AnalysisServicesServerData(id, name, type, tags, location, sku, asAdministrators.Value, backupBlobContainerUri.Value, gatewayDetails.Value, ipV4FirewallSettings.Value, Optional.ToNullable(querypoolConnectionMode), Optional.ToNullable(managedMode), Optional.ToNullable(serverMonitorMode), Optional.ToNullable(state), Optional.ToNullable(provisioningState), serverFullName.Value, sku0.Value);
        }
    }
}
