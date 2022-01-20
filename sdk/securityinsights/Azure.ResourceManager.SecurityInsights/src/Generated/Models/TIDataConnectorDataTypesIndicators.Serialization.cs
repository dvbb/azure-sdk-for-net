// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class TIDataConnectorDataTypesIndicators : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("state");
            writer.WriteStringValue(State.ToString());
            writer.WriteEndObject();
        }

        internal static TIDataConnectorDataTypesIndicators DeserializeTIDataConnectorDataTypesIndicators(JsonElement element)
        {
            DataTypeState state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"))
                {
                    state = new DataTypeState(property.Value.GetString());
                    continue;
                }
            }
            return new TIDataConnectorDataTypesIndicators(state);
        }
    }
}
