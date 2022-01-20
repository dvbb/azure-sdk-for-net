// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class AutomationRuleModifyPropertiesActionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Classification))
            {
                writer.WritePropertyName("classification");
                writer.WriteStringValue(Classification.Value.ToString());
            }
            if (Optional.IsDefined(ClassificationComment))
            {
                writer.WritePropertyName("classificationComment");
                writer.WriteStringValue(ClassificationComment);
            }
            if (Optional.IsDefined(ClassificationReason))
            {
                writer.WritePropertyName("classificationReason");
                writer.WriteStringValue(ClassificationReason.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels");
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner");
                writer.WriteObjectValue(Owner);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity");
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AutomationRuleModifyPropertiesActionConfiguration DeserializeAutomationRuleModifyPropertiesActionConfiguration(JsonElement element)
        {
            Optional<IncidentClassification> classification = default;
            Optional<string> classificationComment = default;
            Optional<IncidentClassificationReason> classificationReason = default;
            Optional<IList<IncidentLabel>> labels = default;
            Optional<IncidentOwnerInfo> owner = default;
            Optional<IncidentSeverity> severity = default;
            Optional<IncidentStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("classification"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    classification = new IncidentClassification(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("classificationComment"))
                {
                    classificationComment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classificationReason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    classificationReason = new IncidentClassificationReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("labels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IncidentLabel> array = new List<IncidentLabel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IncidentLabel.DeserializeIncidentLabel(item));
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("owner"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    owner = IncidentOwnerInfo.DeserializeIncidentOwnerInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("severity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    severity = new IncidentSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new IncidentStatus(property.Value.GetString());
                    continue;
                }
            }
            return new AutomationRuleModifyPropertiesActionConfiguration(Optional.ToNullable(classification), classificationComment.Value, Optional.ToNullable(classificationReason), Optional.ToList(labels), owner.Value, Optional.ToNullable(severity), Optional.ToNullable(status));
        }
    }
}
