// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    public partial class JobStage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            writer.WritePropertyName("stageStatus");
            writer.WriteStringValue(StageStatus.ToSerialString());
            if (Optional.IsDefined(Detail))
            {
                writer.WritePropertyName("detail");
                writer.WriteStringValue(Detail);
            }
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode");
                writer.WriteStringValue(ErrorCode);
            }
            writer.WriteEndObject();
        }

        internal static JobStage DeserializeJobStage(JsonElement element)
        {
            Optional<string> message = default;
            JobStatus stageStatus = default;
            Optional<string> detail = default;
            Optional<string> errorCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stageStatus"))
                {
                    stageStatus = property.Value.GetString().ToJobStatus();
                    continue;
                }
                if (property.NameEquals("detail"))
                {
                    detail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
            }
            return new JobStage(message.Value, stageStatus, detail.Value, errorCode.Value);
        }
    }
}
