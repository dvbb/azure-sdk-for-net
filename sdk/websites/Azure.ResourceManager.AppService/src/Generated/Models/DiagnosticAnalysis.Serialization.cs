// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DiagnosticAnalysis : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(AbnormalTimePeriods))
            {
                writer.WritePropertyName("abnormalTimePeriods");
                writer.WriteStartArray();
                foreach (var item in AbnormalTimePeriods)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Payload))
            {
                writer.WritePropertyName("payload");
                writer.WriteStartArray();
                foreach (var item in Payload)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NonCorrelatedDetectors))
            {
                writer.WritePropertyName("nonCorrelatedDetectors");
                writer.WriteStartArray();
                foreach (var item in NonCorrelatedDetectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DiagnosticAnalysis DeserializeDiagnosticAnalysis(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<IList<AbnormalTimePeriod>> abnormalTimePeriods = default;
            Optional<IList<AnalysisData>> payload = default;
            Optional<IList<DiagnosticDetectorDefinition>> nonCorrelatedDetectors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
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
                    type = new ResourceType(property.Value.GetString());
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("abnormalTimePeriods"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AbnormalTimePeriod> array = new List<AbnormalTimePeriod>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AbnormalTimePeriod.DeserializeAbnormalTimePeriod(item));
                            }
                            abnormalTimePeriods = array;
                            continue;
                        }
                        if (property0.NameEquals("payload"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AnalysisData> array = new List<AnalysisData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AnalysisData.DeserializeAnalysisData(item));
                            }
                            payload = array;
                            continue;
                        }
                        if (property0.NameEquals("nonCorrelatedDetectors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DiagnosticDetectorDefinition> array = new List<DiagnosticDetectorDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DiagnosticDetectorDefinition.DeserializeDiagnosticDetectorDefinition(item));
                            }
                            nonCorrelatedDetectors = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DiagnosticAnalysis(id, name, type, systemData.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToList(abnormalTimePeriods), Optional.ToList(payload), Optional.ToList(nonCorrelatedDetectors), kind.Value);
        }
    }
}
