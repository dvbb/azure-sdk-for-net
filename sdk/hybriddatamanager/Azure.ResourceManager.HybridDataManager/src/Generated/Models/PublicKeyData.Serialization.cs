// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridDataManager.Models;

namespace Azure.ResourceManager.HybridDataManager
{
    public partial class PublicKeyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("dataServiceLevel1Key");
            writer.WriteObjectValue(DataServiceLevel1Key);
            writer.WritePropertyName("dataServiceLevel2Key");
            writer.WriteObjectValue(DataServiceLevel2Key);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PublicKeyData DeserializePublicKeyData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Key dataServiceLevel1Key = default;
            Key dataServiceLevel2Key = default;
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
                        if (property0.NameEquals("dataServiceLevel1Key"))
                        {
                            dataServiceLevel1Key = Key.DeserializeKey(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataServiceLevel2Key"))
                        {
                            dataServiceLevel2Key = Key.DeserializeKey(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PublicKeyData(id, name, type, dataServiceLevel1Key, dataServiceLevel2Key);
        }
    }
}
