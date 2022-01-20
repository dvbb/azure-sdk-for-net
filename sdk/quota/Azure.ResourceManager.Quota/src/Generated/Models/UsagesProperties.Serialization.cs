// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    public partial class UsagesProperties
    {
        internal static UsagesProperties DeserializeUsagesProperties(JsonElement element)
        {
            Optional<UsagesObject> usages = default;
            Optional<string> unit = default;
            Optional<ResourceName> name = default;
            Optional<string> resourceType = default;
            Optional<string> quotaPeriod = default;
            Optional<bool> isQuotaApplicable = default;
            Optional<object> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usages"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    usages = UsagesObject.DeserializeUsagesObject(property.Value);
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = ResourceName.DeserializeResourceName(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaPeriod"))
                {
                    quotaPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isQuotaApplicable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isQuotaApplicable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = property.Value.GetObject();
                    continue;
                }
            }
            return new UsagesProperties(usages.Value, unit.Value, name.Value, resourceType.Value, quotaPeriod.Value, Optional.ToNullable(isQuotaApplicable), properties.Value);
        }
    }
}
