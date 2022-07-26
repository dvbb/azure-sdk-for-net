// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    public partial class NSRecord : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NsdName))
            {
                writer.WritePropertyName("nsdname");
                writer.WriteStringValue(NsdName);
            }
            writer.WriteEndObject();
        }

        internal static NSRecord DeserializeNSRecord(JsonElement element)
        {
            Optional<string> nsdname = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nsdname"))
                {
                    nsdname = property.Value.GetString();
                    continue;
                }
            }
            return new NSRecord(nsdname.Value);
        }
    }
}
