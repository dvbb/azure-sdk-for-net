// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class DownloadUrl
    {
        internal static DownloadUrl DeserializeDownloadUrl(JsonElement element)
        {
            Optional<string> assessmentReportUrl = default;
            Optional<DateTimeOffset> expirationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assessmentReportUrl"))
                {
                    assessmentReportUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new DownloadUrl(assessmentReportUrl.Value, Optional.ToNullable(expirationTime));
        }
    }
}
