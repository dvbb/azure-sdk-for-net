// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A voice receiver. </summary>
    public partial class MonitorVoiceReceiver
    {
        /// <summary> Initializes a new instance of <see cref="MonitorVoiceReceiver"/>. </summary>
        /// <param name="name"> The name of the voice receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="countryCode"> The country code of the voice receiver. </param>
        /// <param name="phoneNumber"> The phone number of the voice receiver. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="countryCode"/> or <paramref name="phoneNumber"/> is null. </exception>
        public MonitorVoiceReceiver(string name, string countryCode, string phoneNumber)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(countryCode, nameof(countryCode));
            Argument.AssertNotNull(phoneNumber, nameof(phoneNumber));

            Name = name;
            CountryCode = countryCode;
            PhoneNumber = phoneNumber;
        }

        /// <summary> The name of the voice receiver. Names must be unique across all receivers within an action group. </summary>
        public string Name { get; set; }
        /// <summary> The country code of the voice receiver. </summary>
        public string CountryCode { get; set; }
        /// <summary> The phone number of the voice receiver. </summary>
        public string PhoneNumber { get; set; }
    }
}
