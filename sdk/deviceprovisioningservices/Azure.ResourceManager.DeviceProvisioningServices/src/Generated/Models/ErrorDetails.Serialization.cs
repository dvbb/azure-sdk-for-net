// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    internal partial class ErrorDetails
    {
        internal static ErrorDetails DeserializeErrorDetails(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> httpStatusCode = default;
            Optional<string> message = default;
            Optional<string> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpStatusCode"))
                {
                    httpStatusCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    details = property.Value.GetString();
                    continue;
                }
            }
            return new ErrorDetails(code.Value, httpStatusCode.Value, message.Value, details.Value);
        }
    }
}
