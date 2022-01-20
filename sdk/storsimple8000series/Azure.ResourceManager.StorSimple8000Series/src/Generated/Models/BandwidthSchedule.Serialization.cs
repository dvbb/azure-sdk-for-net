// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    public partial class BandwidthSchedule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("start");
            writer.WriteObjectValue(Start);
            writer.WritePropertyName("stop");
            writer.WriteObjectValue(Stop);
            writer.WritePropertyName("rateInMbps");
            writer.WriteNumberValue(RateInMbps);
            writer.WritePropertyName("days");
            writer.WriteStartArray();
            foreach (var item in Days)
            {
                writer.WriteStringValue(item.ToSerialString());
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static BandwidthSchedule DeserializeBandwidthSchedule(JsonElement element)
        {
            Time start = default;
            Time stop = default;
            int rateInMbps = default;
            IList<DayOfWeek> days = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("start"))
                {
                    start = Time.DeserializeTime(property.Value);
                    continue;
                }
                if (property.NameEquals("stop"))
                {
                    stop = Time.DeserializeTime(property.Value);
                    continue;
                }
                if (property.NameEquals("rateInMbps"))
                {
                    rateInMbps = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("days"))
                {
                    List<DayOfWeek> array = new List<DayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToDayOfWeek());
                    }
                    days = array;
                    continue;
                }
            }
            return new BandwidthSchedule(start, stop, rateInMbps, days);
        }
    }
}
