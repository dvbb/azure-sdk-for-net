// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Location of the ARM Resource. </summary>
    public partial class Location
    {
        /// <summary> Initializes a new instance of Location. </summary>
        public Location()
        {
        }

        /// <summary> Initializes a new instance of Location. </summary>
        /// <param name="locationValue"> The Azure location where the Confidential Ledger is running. </param>
        internal Location(string locationValue)
        {
            LocationValue = locationValue;
        }

        /// <summary> The Azure location where the Confidential Ledger is running. </summary>
        public string LocationValue { get; set; }
    }
}
