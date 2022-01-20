// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    public partial class ImageData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(AvailableRegions))
            {
                writer.WritePropertyName("availableRegions");
                writer.WriteStartArray();
                foreach (var item in AvailableRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ImageData DeserializeImageData(JsonElement element)
        {
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<EnableState> enabledState = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<string> iconUrl = default;
            Optional<string> author = default;
            Optional<OsType> osType = default;
            Optional<string> plan = default;
            Optional<EnableState> termsStatus = default;
            Optional<string> offer = default;
            Optional<string> publisher = default;
            Optional<string> sku = default;
            Optional<string> version = default;
            Optional<string> sharedGalleryId = default;
            Optional<IList<string>> availableRegions = default;
            Optional<OsState> osState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("enabledState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabledState = property0.Value.GetString().ToEnableState();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconUrl"))
                        {
                            iconUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("author"))
                        {
                            author = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            osType = property0.Value.GetString().ToOsType();
                            continue;
                        }
                        if (property0.NameEquals("plan"))
                        {
                            plan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("termsStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            termsStatus = property0.Value.GetString().ToEnableState();
                            continue;
                        }
                        if (property0.NameEquals("offer"))
                        {
                            offer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisher"))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedGalleryId"))
                        {
                            sharedGalleryId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("availableRegions"))
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
                            availableRegions = array;
                            continue;
                        }
                        if (property0.NameEquals("osState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            osState = property0.Value.GetString().ToOsState();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ImageData(id, name, type, systemData, Optional.ToNullable(enabledState), Optional.ToNullable(provisioningState), displayName.Value, description.Value, iconUrl.Value, author.Value, Optional.ToNullable(osType), plan.Value, Optional.ToNullable(termsStatus), offer.Value, publisher.Value, sku.Value, version.Value, sharedGalleryId.Value, Optional.ToList(availableRegions), Optional.ToNullable(osState));
        }
    }
}
