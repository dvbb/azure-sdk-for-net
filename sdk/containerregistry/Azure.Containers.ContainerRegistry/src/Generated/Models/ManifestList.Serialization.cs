// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class ManifestList
    {
        internal static ManifestList DeserializeManifestList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mediaType = default;
            IReadOnlyList<ManifestListAttributes> manifests = default;
            int? schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"u8))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManifestListAttributes> array = new List<ManifestListAttributes>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManifestListAttributes.DeserializeManifestListAttributes(item));
                    }
                    manifests = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new ManifestList(schemaVersion, mediaType, manifests ?? new ChangeTrackingList<ManifestListAttributes>());
        }
    }
}
