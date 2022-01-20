// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSQL.Models
{
    public partial class NodeTypeCapability
    {
        internal static NodeTypeCapability DeserializeNodeTypeCapability(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> nodeType = default;
            Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeType"))
                {
                    nodeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new NodeTypeCapability(name.Value, nodeType.Value, status.Value);
        }
    }
}
