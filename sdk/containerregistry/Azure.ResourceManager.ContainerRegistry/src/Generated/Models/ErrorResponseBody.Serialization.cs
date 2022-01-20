// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    internal partial class ErrorResponseBody
    {
        internal static ErrorResponseBody DeserializeErrorResponseBody(JsonElement element)
        {
            string code = default;
            string message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<InnerErrorDescription>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<InnerErrorDescription> array = new List<InnerErrorDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InnerErrorDescription.DeserializeInnerErrorDescription(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new ErrorResponseBody(code, message, target.Value, Optional.ToList(details));
        }
    }
}
