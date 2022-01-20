// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The JSON object that contains the properties required to create a health probe settings. </summary>
    internal partial class HealthProbeSettingsProperties : HealthProbeSettingsUpdateParameters
    {
        /// <summary> Initializes a new instance of HealthProbeSettingsProperties. </summary>
        internal HealthProbeSettingsProperties()
        {
        }

        /// <summary> Resource status. </summary>
        public FrontDoorResourceState? ResourceState { get; }
    }
}
