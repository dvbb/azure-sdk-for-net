// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSQL.Models
{
    public partial class MaintenanceWindow : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomWindow))
            {
                writer.WritePropertyName("customWindow");
                writer.WriteStringValue(CustomWindow);
            }
            if (Optional.IsDefined(StartHour))
            {
                writer.WritePropertyName("startHour");
                writer.WriteNumberValue(StartHour.Value);
            }
            if (Optional.IsDefined(StartMinute))
            {
                writer.WritePropertyName("startMinute");
                writer.WriteNumberValue(StartMinute.Value);
            }
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek");
                writer.WriteNumberValue(DayOfWeek.Value);
            }
            writer.WriteEndObject();
        }

        internal static MaintenanceWindow DeserializeMaintenanceWindow(JsonElement element)
        {
            Optional<string> customWindow = default;
            Optional<int> startHour = default;
            Optional<int> startMinute = default;
            Optional<int> dayOfWeek = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customWindow"))
                {
                    customWindow = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startHour"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startHour = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startMinute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startMinute = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dayOfWeek"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dayOfWeek = property.Value.GetInt32();
                    continue;
                }
            }
            return new MaintenanceWindow(customWindow.Value, Optional.ToNullable(startHour), Optional.ToNullable(startMinute), Optional.ToNullable(dayOfWeek));
        }
    }
}
