// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class LogFileUrlResponse
    {
        internal static LogFileUrlResponse DeserializeLogFileUrlResponse(JsonElement element)
        {
            string url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new LogFileUrlResponse(url);
        }
    }
}
