// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.Messages;

namespace Azure.Communication.Messages.Models.Channels
{
    /// <summary> The template bindings component for WhatsApp. </summary>
    public partial class WhatsAppMessageTemplateBindingsComponent
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

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateBindingsComponent"/>. </summary>
        /// <param name="refValue"> The name of the referenced item in the template values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="refValue"/> is null. </exception>
        public WhatsAppMessageTemplateBindingsComponent(string refValue)
        {
            Argument.AssertNotNull(refValue, nameof(refValue));

            RefValue = refValue;
        }

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateBindingsComponent"/>. </summary>
        /// <param name="refValue"> The name of the referenced item in the template values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WhatsAppMessageTemplateBindingsComponent(string refValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RefValue = refValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateBindingsComponent"/> for deserialization. </summary>
        internal WhatsAppMessageTemplateBindingsComponent()
        {
        }

        /// <summary> The name of the referenced item in the template values. </summary>
        public string RefValue { get; }
    }
}
