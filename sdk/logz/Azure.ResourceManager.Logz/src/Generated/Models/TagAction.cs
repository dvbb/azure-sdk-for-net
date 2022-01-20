// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logz.Models
{
    /// <summary> Valid actions for a filtering tag. Exclusion takes priority over inclusion. </summary>
    public readonly partial struct TagAction : IEquatable<TagAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TagAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TagAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IncludeValue = "Include";
        private const string ExcludeValue = "Exclude";

        /// <summary> Include. </summary>
        public static TagAction Include { get; } = new TagAction(IncludeValue);
        /// <summary> Exclude. </summary>
        public static TagAction Exclude { get; } = new TagAction(ExcludeValue);
        /// <summary> Determines if two <see cref="TagAction"/> values are the same. </summary>
        public static bool operator ==(TagAction left, TagAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TagAction"/> values are not the same. </summary>
        public static bool operator !=(TagAction left, TagAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TagAction"/>. </summary>
        public static implicit operator TagAction(string value) => new TagAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TagAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TagAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
