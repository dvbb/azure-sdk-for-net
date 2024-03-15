// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> KPI Resource Health Details. </summary>
    public partial class KpiResourceHealthDetails
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

        /// <summary> Initializes a new instance of <see cref="KpiResourceHealthDetails"/>. </summary>
        public KpiResourceHealthDetails()
        {
            ResourceHealthDetails = new ChangeTrackingList<ResourceHealthDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="KpiResourceHealthDetails"/>. </summary>
        /// <param name="resourceHealthStatus"> Resource Health Status. </param>
        /// <param name="resourceHealthDetails"> Resource Health Status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KpiResourceHealthDetails(ResourceHealthStatus? resourceHealthStatus, IList<ResourceHealthDetails> resourceHealthDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceHealthStatus = resourceHealthStatus;
            ResourceHealthDetails = resourceHealthDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource Health Status. </summary>
        public ResourceHealthStatus? ResourceHealthStatus { get; set; }
        /// <summary> Resource Health Status. </summary>
        public IList<ResourceHealthDetails> ResourceHealthDetails { get; }
    }
}
