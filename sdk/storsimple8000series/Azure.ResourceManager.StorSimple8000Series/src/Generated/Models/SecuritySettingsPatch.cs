// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    /// <summary> Represents the patch request for the security settings of a device. </summary>
    public partial class SecuritySettingsPatch
    {
        /// <summary> Initializes a new instance of SecuritySettingsPatch. </summary>
        public SecuritySettingsPatch()
        {
        }

        /// <summary> The remote management settings. </summary>
        public RemoteManagementSettingsPatch RemoteManagementSettings { get; set; }
        /// <summary> The device administrator password. </summary>
        public AsymmetricEncryptedSecret DeviceAdminPassword { get; set; }
        /// <summary> The snapshot manager password. </summary>
        public AsymmetricEncryptedSecret SnapshotPassword { get; set; }
        /// <summary> The device CHAP and reverse-CHAP settings. </summary>
        public ChapSettings ChapSettings { get; set; }
        /// <summary> The cloud appliance settings. </summary>
        public CloudApplianceSettings CloudApplianceSettings { get; set; }
    }
}
