// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> SSH configuration for Linux based VMs running on Azure. </summary>
    internal partial class SshConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SshConfiguration"/>. </summary>
        public SshConfiguration()
        {
            PublicKeys = new ChangeTrackingList<SshPublicKey>();
        }

        /// <summary> Initializes a new instance of <see cref="SshConfiguration"/>. </summary>
        /// <param name="publicKeys"> The list of SSH public keys used to authenticate with linux based VMs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SshConfiguration(IList<SshPublicKey> publicKeys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PublicKeys = publicKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of SSH public keys used to authenticate with linux based VMs. </summary>
        public IList<SshPublicKey> PublicKeys { get; }
    }
}
