// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class AlertRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            writer.WriteEndObject();
        }

        internal static AlertRuleData DeserializeAlertRuleData(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Fusion": return FusionAlertRule.DeserializeFusionAlertRule(element);
                    case "MLBehaviorAnalytics": return MLBehaviorAnalyticsAlertRule.DeserializeMLBehaviorAnalyticsAlertRule(element);
                    case "MicrosoftSecurityIncidentCreation": return MicrosoftSecurityIncidentCreationAlertRule.DeserializeMicrosoftSecurityIncidentCreationAlertRule(element);
                    case "NRT": return NrtAlertRule.DeserializeNrtAlertRule(element);
                    case "Scheduled": return ScheduledAlertRule.DeserializeScheduledAlertRule(element);
                    case "ThreatIntelligence": return ThreatIntelligenceAlertRule.DeserializeThreatIntelligenceAlertRule(element);
                }
            }
            AlertRuleKind kind = default;
            Optional<string> etag = default;
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
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
            }
            return new AlertRuleData(id, name, type, systemData, etag.Value, kind);
        }
    }
}
