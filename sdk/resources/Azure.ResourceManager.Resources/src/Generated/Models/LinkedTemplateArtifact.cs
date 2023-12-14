// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Represents a Template Spec artifact containing an embedded Azure Resource Manager template for use as a linked template. </summary>
    public partial class LinkedTemplateArtifact
    {
        /// <summary> Initializes a new instance of <see cref="LinkedTemplateArtifact"/>. </summary>
        /// <param name="path"> A filesystem safe relative path of the artifact. </param>
        /// <param name="template"> The Azure Resource Manager template. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> or <paramref name="template"/> is null. </exception>
        public LinkedTemplateArtifact(string path, BinaryData template)
        {
            Argument.AssertNotNull(path, nameof(path));
            Argument.AssertNotNull(template, nameof(template));

            Path = path;
            Template = template;
        }

        /// <summary> A filesystem safe relative path of the artifact. </summary>
        public string Path { get; set; }
        /// <summary>
        /// The Azure Resource Manager template.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Template { get; set; }
    }
}
