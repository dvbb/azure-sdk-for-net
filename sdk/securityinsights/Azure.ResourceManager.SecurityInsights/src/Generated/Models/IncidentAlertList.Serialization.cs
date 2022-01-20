// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class IncidentAlertList
    {
        internal static IncidentAlertList DeserializeIncidentAlertList(JsonElement element)
        {
            IReadOnlyList<SecurityAlert> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SecurityAlert> array = new List<SecurityAlert>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityAlert.DeserializeSecurityAlert(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new IncidentAlertList(value);
        }
    }
}
