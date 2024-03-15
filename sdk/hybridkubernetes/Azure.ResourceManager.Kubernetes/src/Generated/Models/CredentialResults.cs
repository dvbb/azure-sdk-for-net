// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Kubernetes;

namespace Azure.ResourceManager.Kubernetes.Models
{
    /// <summary> The list of credential result response. </summary>
    public partial class CredentialResults
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

        /// <summary> Initializes a new instance of <see cref="CredentialResults"/>. </summary>
        internal CredentialResults()
        {
            Kubeconfigs = new ChangeTrackingList<CredentialResult>();
        }

        /// <summary> Initializes a new instance of <see cref="CredentialResults"/>. </summary>
        /// <param name="hybridConnectionConfig"> Contains the REP (rendezvous endpoint) and “Sender” access token. </param>
        /// <param name="kubeconfigs"> Base64-encoded Kubernetes configuration file. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CredentialResults(HybridConnectionConfig hybridConnectionConfig, IReadOnlyList<CredentialResult> kubeconfigs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HybridConnectionConfig = hybridConnectionConfig;
            Kubeconfigs = kubeconfigs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Contains the REP (rendezvous endpoint) and “Sender” access token. </summary>
        public HybridConnectionConfig HybridConnectionConfig { get; }
        /// <summary> Base64-encoded Kubernetes configuration file. </summary>
        public IReadOnlyList<CredentialResult> Kubeconfigs { get; }
    }
}
