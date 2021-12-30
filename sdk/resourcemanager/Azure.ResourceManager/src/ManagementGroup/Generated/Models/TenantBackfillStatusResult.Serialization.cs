// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Management.Models
{
    public partial class TenantBackfillStatusResult
    {
        internal static TenantBackfillStatusResult DeserializeTenantBackfillStatusResult(JsonElement element)
        {
            Optional<string> tenantId = default;
            Optional<Status> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetString().ToStatus();
                    continue;
                }
            }
            return new TenantBackfillStatusResult(tenantId.Value, Optional.ToNullable(status));
        }
    }
}
