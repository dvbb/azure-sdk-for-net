// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> IP Rule to be applied as part of Network Rule Set. </summary>
    public partial class IotHubNetworkRuleSetIPRule
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

        /// <summary> Initializes a new instance of <see cref="IotHubNetworkRuleSetIPRule"/>. </summary>
        /// <param name="filterName"> Name of the IP filter rule. </param>
        /// <param name="ipMask"> A string that contains the IP address range in CIDR notation for the rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> or <paramref name="ipMask"/> is null. </exception>
        public IotHubNetworkRuleSetIPRule(string filterName, string ipMask)
        {
            Argument.AssertNotNull(filterName, nameof(filterName));
            Argument.AssertNotNull(ipMask, nameof(ipMask));

            FilterName = filterName;
            IPMask = ipMask;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubNetworkRuleSetIPRule"/>. </summary>
        /// <param name="filterName"> Name of the IP filter rule. </param>
        /// <param name="action"> IP Filter Action. </param>
        /// <param name="ipMask"> A string that contains the IP address range in CIDR notation for the rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubNetworkRuleSetIPRule(string filterName, IotHubNetworkRuleIPAction? action, string ipMask, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FilterName = filterName;
            Action = action;
            IPMask = ipMask;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubNetworkRuleSetIPRule"/> for deserialization. </summary>
        internal IotHubNetworkRuleSetIPRule()
        {
        }

        /// <summary> Name of the IP filter rule. </summary>
        public string FilterName { get; set; }
        /// <summary> IP Filter Action. </summary>
        public IotHubNetworkRuleIPAction? Action { get; set; }
        /// <summary> A string that contains the IP address range in CIDR notation for the rule. </summary>
        public string IPMask { get; set; }
    }
}
