// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary>
    /// An object representing a form field with distinct field label (key) and field
    /// value (may be empty).
    /// </summary>
    public partial class DocumentKeyValuePair
    {
        /// <summary> Initializes a new instance of <see cref="DocumentKeyValuePair"/>. </summary>
        /// <param name="key"> Field label of the key-value pair. </param>
        /// <param name="confidence"> Confidence of correctly extracting the key-value pair. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        internal DocumentKeyValuePair(DocumentKeyValueElement key, float confidence)
        {
            Argument.AssertNotNull(key, nameof(key));

            Key = key;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentKeyValuePair"/>. </summary>
        /// <param name="key"> Field label of the key-value pair. </param>
        /// <param name="value"> Field value of the key-value pair. </param>
        /// <param name="confidence"> Confidence of correctly extracting the key-value pair. </param>
        internal DocumentKeyValuePair(DocumentKeyValueElement key, DocumentKeyValueElement value, float confidence)
        {
            Key = key;
            Value = value;
            Confidence = confidence;
        }

        /// <summary> Field label of the key-value pair. </summary>
        public DocumentKeyValueElement Key { get; }
        /// <summary> Field value of the key-value pair. </summary>
        public DocumentKeyValueElement Value { get; }
        /// <summary> Confidence of correctly extracting the key-value pair. </summary>
        public float Confidence { get; }
    }
}
