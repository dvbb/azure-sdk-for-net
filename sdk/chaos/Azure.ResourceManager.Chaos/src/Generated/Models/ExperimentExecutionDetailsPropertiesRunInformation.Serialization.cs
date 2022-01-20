// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ExperimentExecutionDetailsPropertiesRunInformation
    {
        internal static ExperimentExecutionDetailsPropertiesRunInformation DeserializeExperimentExecutionDetailsPropertiesRunInformation(JsonElement element)
        {
            Optional<IReadOnlyList<StepStatus>> steps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("steps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StepStatus> array = new List<StepStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StepStatus.DeserializeStepStatus(item));
                    }
                    steps = array;
                    continue;
                }
            }
            return new ExperimentExecutionDetailsPropertiesRunInformation(Optional.ToList(steps));
        }
    }
}
