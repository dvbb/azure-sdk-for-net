// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The routes table associated with the ExpressRouteCircuit. </summary>
    public partial class ExpressRouteCircuitRoutesTableSummary
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

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitRoutesTableSummary"/>. </summary>
        internal ExpressRouteCircuitRoutesTableSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitRoutesTableSummary"/>. </summary>
        /// <param name="neighbor"> IP address of the neighbor. </param>
        /// <param name="v"> BGP version number spoken to the neighbor. </param>
        /// <param name="as"> Autonomous system number. </param>
        /// <param name="upDown"> The length of time that the BGP session has been in the Established state, or the current status if not in the Established state. </param>
        /// <param name="statePfxRcd"> Current state of the BGP session, and the number of prefixes that have been received from a neighbor or peer group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteCircuitRoutesTableSummary(string neighbor, int? v, int? @as, string upDown, string statePfxRcd, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Neighbor = neighbor;
            V = v;
            As = @as;
            UpDown = upDown;
            StatePfxRcd = statePfxRcd;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> IP address of the neighbor. </summary>
        public string Neighbor { get; }
        /// <summary> BGP version number spoken to the neighbor. </summary>
        public int? V { get; }
        /// <summary> Autonomous system number. </summary>
        public int? As { get; }
        /// <summary> The length of time that the BGP session has been in the Established state, or the current status if not in the Established state. </summary>
        public string UpDown { get; }
        /// <summary> Current state of the BGP session, and the number of prefixes that have been received from a neighbor or peer group. </summary>
        public string StatePfxRcd { get; }
    }
}
