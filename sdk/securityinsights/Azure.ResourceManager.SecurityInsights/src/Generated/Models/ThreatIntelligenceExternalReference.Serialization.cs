// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceExternalReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ExternalId))
            {
                writer.WritePropertyName("externalId");
                writer.WriteStringValue(ExternalId);
            }
            if (Optional.IsDefined(SourceName))
            {
                writer.WritePropertyName("sourceName");
                writer.WriteStringValue(SourceName);
            }
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url");
                writer.WriteStringValue(Url);
            }
            if (Optional.IsCollectionDefined(Hashes))
            {
                writer.WritePropertyName("hashes");
                writer.WriteStartObject();
                foreach (var item in Hashes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ThreatIntelligenceExternalReference DeserializeThreatIntelligenceExternalReference(JsonElement element)
        {
            Optional<string> description = default;
            Optional<string> externalId = default;
            Optional<string> sourceName = default;
            Optional<string> url = default;
            Optional<IDictionary<string, string>> hashes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("externalId"))
                {
                    externalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceName"))
                {
                    sourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hashes"))
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
                    hashes = dictionary;
                    continue;
                }
            }
            return new ThreatIntelligenceExternalReference(description.Value, externalId.Value, sourceName.Value, url.Value, Optional.ToDictionary(hashes));
        }
    }
}
