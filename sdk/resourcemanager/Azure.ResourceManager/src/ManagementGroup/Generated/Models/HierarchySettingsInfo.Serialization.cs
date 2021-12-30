// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Management.Models
{
    public partial class HierarchySettingsInfo
    {
        internal static HierarchySettingsInfo DeserializeHierarchySettingsInfo(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> tenantId = default;
            Optional<bool> requireAuthorizationForGroupCreation = default;
            Optional<string> defaultManagementGroup = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("tenantId"))
                        {
                            tenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requireAuthorizationForGroupCreation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requireAuthorizationForGroupCreation = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultManagementGroup"))
                        {
                            defaultManagementGroup = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HierarchySettingsInfo(id, name, type, tenantId.Value, Optional.ToNullable(requireAuthorizationForGroupCreation), defaultManagementGroup.Value);
        }
    }
}
