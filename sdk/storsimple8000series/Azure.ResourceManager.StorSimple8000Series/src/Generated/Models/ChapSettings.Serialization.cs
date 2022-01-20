// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    public partial class ChapSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InitiatorUser))
            {
                writer.WritePropertyName("initiatorUser");
                writer.WriteStringValue(InitiatorUser);
            }
            if (Optional.IsDefined(InitiatorSecret))
            {
                writer.WritePropertyName("initiatorSecret");
                writer.WriteObjectValue(InitiatorSecret);
            }
            if (Optional.IsDefined(TargetUser))
            {
                writer.WritePropertyName("targetUser");
                writer.WriteStringValue(TargetUser);
            }
            if (Optional.IsDefined(TargetSecret))
            {
                writer.WritePropertyName("targetSecret");
                writer.WriteObjectValue(TargetSecret);
            }
            writer.WriteEndObject();
        }

        internal static ChapSettings DeserializeChapSettings(JsonElement element)
        {
            Optional<string> initiatorUser = default;
            Optional<AsymmetricEncryptedSecret> initiatorSecret = default;
            Optional<string> targetUser = default;
            Optional<AsymmetricEncryptedSecret> targetSecret = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initiatorUser"))
                {
                    initiatorUser = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initiatorSecret"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initiatorSecret = AsymmetricEncryptedSecret.DeserializeAsymmetricEncryptedSecret(property.Value);
                    continue;
                }
                if (property.NameEquals("targetUser"))
                {
                    targetUser = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetSecret"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetSecret = AsymmetricEncryptedSecret.DeserializeAsymmetricEncryptedSecret(property.Value);
                    continue;
                }
            }
            return new ChapSettings(initiatorUser.Value, initiatorSecret.Value, targetUser.Value, targetSecret.Value);
        }
    }
}
