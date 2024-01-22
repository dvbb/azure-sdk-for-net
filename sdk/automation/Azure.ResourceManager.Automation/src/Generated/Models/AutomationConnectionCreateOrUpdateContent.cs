// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update connection operation. </summary>
    public partial class AutomationConnectionCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the connection. </param>
        /// <param name="connectionType"> Gets or sets the connectionType of the connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="connectionType"/> is null. </exception>
        public AutomationConnectionCreateOrUpdateContent(string name, ConnectionTypeAssociationProperty connectionType)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(connectionType, nameof(connectionType));

            Name = name;
            ConnectionType = connectionType;
            FieldDefinitionValues = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the connection. </param>
        /// <param name="description"> Gets or sets the description of the connection. </param>
        /// <param name="connectionType"> Gets or sets the connectionType of the connection. </param>
        /// <param name="fieldDefinitionValues"> Gets or sets the field definition properties of the connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationConnectionCreateOrUpdateContent(string name, string description, ConnectionTypeAssociationProperty connectionType, IDictionary<string, string> fieldDefinitionValues, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Description = description;
            ConnectionType = connectionType;
            FieldDefinitionValues = fieldDefinitionValues;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionCreateOrUpdateContent"/> for deserialization. </summary>
        internal AutomationConnectionCreateOrUpdateContent()
        {
        }

        /// <summary> Gets or sets the name of the connection. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the description of the connection. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the connectionType of the connection. </summary>
        internal ConnectionTypeAssociationProperty ConnectionType { get; }
        /// <summary> Gets or sets the name of the connection type. </summary>
        public string ConnectionTypeName
        {
            get => ConnectionType?.Name;
        }

        /// <summary> Gets or sets the field definition properties of the connection. </summary>
        public IDictionary<string, string> FieldDefinitionValues { get; }
    }
}
