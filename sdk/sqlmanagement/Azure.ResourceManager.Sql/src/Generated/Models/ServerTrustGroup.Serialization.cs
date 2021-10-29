// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ServerTrustGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(GroupMembers))
            {
                writer.WritePropertyName("groupMembers");
                writer.WriteStartArray();
                foreach (var item in GroupMembers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TrustScopes))
            {
                writer.WritePropertyName("trustScopes");
                writer.WriteStartArray();
                foreach (var item in TrustScopes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServerTrustGroup DeserializeServerTrustGroup(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<IList<ServerInfo>> groupMembers = default;
            Optional<IList<ServerTrustGroupPropertiesTrustScopesItem>> trustScopes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("groupMembers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ServerInfo> array = new List<ServerInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServerInfo.DeserializeServerInfo(item));
                            }
                            groupMembers = array;
                            continue;
                        }
                        if (property0.NameEquals("trustScopes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ServerTrustGroupPropertiesTrustScopesItem> array = new List<ServerTrustGroupPropertiesTrustScopesItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ServerTrustGroupPropertiesTrustScopesItem(item.GetString()));
                            }
                            trustScopes = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServerTrustGroup(id.Value, name.Value, type.Value, Optional.ToList(groupMembers), Optional.ToList(trustScopes));
        }
    }
}
