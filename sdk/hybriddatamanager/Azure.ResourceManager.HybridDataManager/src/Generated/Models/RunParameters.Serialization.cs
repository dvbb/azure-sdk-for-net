// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridDataManager.Models
{
    public partial class RunParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
        }
    }
}
