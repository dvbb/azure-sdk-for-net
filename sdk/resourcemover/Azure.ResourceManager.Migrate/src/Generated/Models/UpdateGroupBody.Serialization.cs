// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class UpdateGroupBody : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag");
                writer.WriteStringValue(ETag);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            writer.WriteEndObject();
        }
    }
}
