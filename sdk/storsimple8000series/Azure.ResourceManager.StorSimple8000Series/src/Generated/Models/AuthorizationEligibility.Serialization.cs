// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    internal static partial class AuthorizationEligibilityExtensions
    {
        public static string ToSerialString(this AuthorizationEligibility value) => value switch
        {
            AuthorizationEligibility.InEligible => "InEligible",
            AuthorizationEligibility.Eligible => "Eligible",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AuthorizationEligibility value.")
        };

        public static AuthorizationEligibility ToAuthorizationEligibility(this string value)
        {
            if (string.Equals(value, "InEligible", StringComparison.InvariantCultureIgnoreCase)) return AuthorizationEligibility.InEligible;
            if (string.Equals(value, "Eligible", StringComparison.InvariantCultureIgnoreCase)) return AuthorizationEligibility.Eligible;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AuthorizationEligibility value.");
        }
    }
}
