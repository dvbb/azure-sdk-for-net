// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ActionStatus
    {
        internal static ActionStatus DeserializeActionStatus(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> status = default;
            Optional<IReadOnlyList<ExperimentExecutionActionTargetDetailsProperties>> targets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ExperimentExecutionActionTargetDetailsProperties> array = new List<ExperimentExecutionActionTargetDetailsProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExperimentExecutionActionTargetDetailsProperties.DeserializeExperimentExecutionActionTargetDetailsProperties(item));
                    }
                    targets = array;
                    continue;
                }
            }
            return new ActionStatus(name.Value, id.Value, status.Value, Optional.ToList(targets));
        }
    }
}
