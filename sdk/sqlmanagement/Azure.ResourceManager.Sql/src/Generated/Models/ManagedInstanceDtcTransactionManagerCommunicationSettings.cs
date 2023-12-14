// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The Transaction Manager Communication Settings of managed instance DTC. </summary>
    public partial class ManagedInstanceDtcTransactionManagerCommunicationSettings
    {
        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDtcTransactionManagerCommunicationSettings"/>. </summary>
        public ManagedInstanceDtcTransactionManagerCommunicationSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDtcTransactionManagerCommunicationSettings"/>. </summary>
        /// <param name="allowInboundEnabled"> Allow Inbound traffic to managed instance DTC. </param>
        /// <param name="allowOutboundEnabled"> Allow Outbound traffic of managed instance DTC. </param>
        /// <param name="authentication"> Authentication type of managed instance DTC. </param>
        internal ManagedInstanceDtcTransactionManagerCommunicationSettings(bool? allowInboundEnabled, bool? allowOutboundEnabled, string authentication)
        {
            AllowInboundEnabled = allowInboundEnabled;
            AllowOutboundEnabled = allowOutboundEnabled;
            Authentication = authentication;
        }

        /// <summary> Allow Inbound traffic to managed instance DTC. </summary>
        public bool? AllowInboundEnabled { get; set; }
        /// <summary> Allow Outbound traffic of managed instance DTC. </summary>
        public bool? AllowOutboundEnabled { get; set; }
        /// <summary> Authentication type of managed instance DTC. </summary>
        public string Authentication { get; set; }
    }
}
