// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlConfigurationListResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static MySqlConfigurationListResult DeserializeMySqlConfigurationListResult(JsonElement element)
        {
            Optional<IList<MySqlConfigurationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MySqlConfigurationData> array = new List<MySqlConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlConfigurationData.DeserializeMySqlConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MySqlConfigurationListResult(Optional.ToList(value));
        }
    }
}
