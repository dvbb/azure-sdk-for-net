// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IotCentral.Models;

namespace Azure.ResourceManager.IotCentral
{
    public partial class AppData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sku");
            writer.WriteObjectValue(Sku);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
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
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Subdomain))
            {
                writer.WritePropertyName("subdomain");
                writer.WriteStringValue(Subdomain);
            }
            if (Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template");
                writer.WriteStringValue(Template);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppData DeserializeAppData(JsonElement element)
        {
            AppSkuInfo sku = default;
            Optional<SystemAssignedServiceIdentity> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> applicationId = default;
            Optional<string> displayName = default;
            Optional<string> subdomain = default;
            Optional<string> template = default;
            Optional<AppState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    sku = AppSkuInfo.DeserializeAppSkuInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = SystemAssignedServiceIdentity.DeserializeSystemAssignedServiceIdentity(property.Value);
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
                        if (property0.NameEquals("applicationId"))
                        {
                            applicationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subdomain"))
                        {
                            subdomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("template"))
                        {
                            template = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new AppState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppData(id, name, type, tags, location, sku, identity.Value, applicationId.Value, displayName.Value, subdomain.Value, template.Value, Optional.ToNullable(state));
        }
    }
}
