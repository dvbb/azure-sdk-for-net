// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Properties used to create a user account on a Windows node. </summary>
    public partial class WindowsUserConfiguration
    {
        /// <summary> Initializes a new instance of WindowsUserConfiguration. </summary>
        public WindowsUserConfiguration()
        {
        }

        /// <summary> Initializes a new instance of WindowsUserConfiguration. </summary>
        /// <param name="loginMode"> Specifies login mode for the user. The default value for VirtualMachineConfiguration pools is interactive mode and for CloudServiceConfiguration pools is batch mode. </param>
        internal WindowsUserConfiguration(LoginMode? loginMode)
        {
            LoginMode = loginMode;
        }

        /// <summary> Specifies login mode for the user. The default value for VirtualMachineConfiguration pools is interactive mode and for CloudServiceConfiguration pools is batch mode. </summary>
        public LoginMode? LoginMode { get; set; }
    }
}
