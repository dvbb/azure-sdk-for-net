// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HybridDataManager.Models
{
    internal static partial class RunLocationExtensions
    {
        public static string ToSerialString(this RunLocation value) => value switch
        {
            RunLocation.None => "none",
            RunLocation.Australiaeast => "australiaeast",
            RunLocation.Australiasoutheast => "australiasoutheast",
            RunLocation.Brazilsouth => "brazilsouth",
            RunLocation.Canadacentral => "canadacentral",
            RunLocation.Canadaeast => "canadaeast",
            RunLocation.Centralindia => "centralindia",
            RunLocation.Centralus => "centralus",
            RunLocation.Eastasia => "eastasia",
            RunLocation.Eastus => "eastus",
            RunLocation.Eastus2 => "eastus2",
            RunLocation.Japaneast => "japaneast",
            RunLocation.Japanwest => "japanwest",
            RunLocation.Koreacentral => "koreacentral",
            RunLocation.Koreasouth => "koreasouth",
            RunLocation.Southeastasia => "southeastasia",
            RunLocation.Southcentralus => "southcentralus",
            RunLocation.Southindia => "southindia",
            RunLocation.Northcentralus => "northcentralus",
            RunLocation.Northeurope => "northeurope",
            RunLocation.Uksouth => "uksouth",
            RunLocation.Ukwest => "ukwest",
            RunLocation.Westcentralus => "westcentralus",
            RunLocation.Westeurope => "westeurope",
            RunLocation.Westindia => "westindia",
            RunLocation.Westus => "westus",
            RunLocation.Westus2 => "westus2",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RunLocation value.")
        };

        public static RunLocation ToRunLocation(this string value)
        {
            if (string.Equals(value, "none", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.None;
            if (string.Equals(value, "australiaeast", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Australiaeast;
            if (string.Equals(value, "australiasoutheast", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Australiasoutheast;
            if (string.Equals(value, "brazilsouth", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Brazilsouth;
            if (string.Equals(value, "canadacentral", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Canadacentral;
            if (string.Equals(value, "canadaeast", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Canadaeast;
            if (string.Equals(value, "centralindia", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Centralindia;
            if (string.Equals(value, "centralus", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Centralus;
            if (string.Equals(value, "eastasia", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Eastasia;
            if (string.Equals(value, "eastus", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Eastus;
            if (string.Equals(value, "eastus2", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Eastus2;
            if (string.Equals(value, "japaneast", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Japaneast;
            if (string.Equals(value, "japanwest", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Japanwest;
            if (string.Equals(value, "koreacentral", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Koreacentral;
            if (string.Equals(value, "koreasouth", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Koreasouth;
            if (string.Equals(value, "southeastasia", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Southeastasia;
            if (string.Equals(value, "southcentralus", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Southcentralus;
            if (string.Equals(value, "southindia", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Southindia;
            if (string.Equals(value, "northcentralus", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Northcentralus;
            if (string.Equals(value, "northeurope", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Northeurope;
            if (string.Equals(value, "uksouth", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Uksouth;
            if (string.Equals(value, "ukwest", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Ukwest;
            if (string.Equals(value, "westcentralus", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Westcentralus;
            if (string.Equals(value, "westeurope", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Westeurope;
            if (string.Equals(value, "westindia", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Westindia;
            if (string.Equals(value, "westus", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Westus;
            if (string.Equals(value, "westus2", StringComparison.InvariantCultureIgnoreCase)) return RunLocation.Westus2;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RunLocation value.");
        }
    }
}
