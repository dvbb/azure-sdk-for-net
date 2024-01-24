// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the Allowed Audiences validation flow. </summary>
    internal partial class AllowedAudiencesValidation
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

        /// <summary> Initializes a new instance of <see cref="AllowedAudiencesValidation"/>. </summary>
        public AllowedAudiencesValidation()
        {
            AllowedAudiences = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AllowedAudiencesValidation"/>. </summary>
        /// <param name="allowedAudiences"> The configuration settings of the allowed list of audiences from which to validate the JWT token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AllowedAudiencesValidation(IList<string> allowedAudiences, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowedAudiences = allowedAudiences;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration settings of the allowed list of audiences from which to validate the JWT token. </summary>
        public IList<string> AllowedAudiences { get; }
    }
}
