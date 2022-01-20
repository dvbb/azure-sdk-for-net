// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridDataManager.Models;

namespace Azure.ResourceManager.HybridDataManager
{
    public partial class JobDefinitionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceId");
            writer.WriteStringValue(DataSourceId);
            writer.WritePropertyName("dataSinkId");
            writer.WriteStringValue(DataSinkId);
            if (Optional.IsCollectionDefined(Schedules))
            {
                writer.WritePropertyName("schedules");
                writer.WriteStartArray();
                foreach (var item in Schedules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("state");
            writer.WriteStringValue(State.ToSerialString());
            if (Optional.IsDefined(LastModifiedTime))
            {
                writer.WritePropertyName("lastModifiedTime");
                writer.WriteStringValue(LastModifiedTime.Value, "O");
            }
            if (Optional.IsDefined(RunLocation))
            {
                writer.WritePropertyName("runLocation");
                writer.WriteStringValue(RunLocation.Value.ToSerialString());
            }
            if (Optional.IsDefined(UserConfirmation))
            {
                writer.WritePropertyName("userConfirmation");
                writer.WriteStringValue(UserConfirmation.Value.ToSerialString());
            }
            if (Optional.IsDefined(DataServiceInput))
            {
                writer.WritePropertyName("dataServiceInput");
                writer.WriteObjectValue(DataServiceInput);
            }
            if (Optional.IsCollectionDefined(CustomerSecrets))
            {
                writer.WritePropertyName("customerSecrets");
                writer.WriteStartArray();
                foreach (var item in CustomerSecrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static JobDefinitionData DeserializeJobDefinitionData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            string dataSourceId = default;
            string dataSinkId = default;
            Optional<IList<Schedule>> schedules = default;
            State state = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<RunLocation> runLocation = default;
            Optional<UserConfirmation> userConfirmation = default;
            Optional<object> dataServiceInput = default;
            Optional<IList<CustomerSecret>> customerSecrets = default;
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
                        if (property0.NameEquals("dataSourceId"))
                        {
                            dataSourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataSinkId"))
                        {
                            dataSinkId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("schedules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Schedule> array = new List<Schedule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Schedule.DeserializeSchedule(item));
                            }
                            schedules = array;
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            state = property0.Value.GetString().ToState();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("runLocation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            runLocation = property0.Value.GetString().ToRunLocation();
                            continue;
                        }
                        if (property0.NameEquals("userConfirmation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            userConfirmation = property0.Value.GetString().ToUserConfirmation();
                            continue;
                        }
                        if (property0.NameEquals("dataServiceInput"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataServiceInput = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("customerSecrets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<CustomerSecret> array = new List<CustomerSecret>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CustomerSecret.DeserializeCustomerSecret(item));
                            }
                            customerSecrets = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new JobDefinitionData(id, name, type, dataSourceId, dataSinkId, Optional.ToList(schedules), state, Optional.ToNullable(lastModifiedTime), Optional.ToNullable(runLocation), Optional.ToNullable(userConfirmation), dataServiceInput.Value, Optional.ToList(customerSecrets));
        }
    }
}
