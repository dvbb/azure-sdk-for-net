// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> The Enum2. </summary>
    public readonly partial struct Enum2 : IEquatable<Enum2>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum2"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum2(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowedParentsValue = "AllowedParents";
        private const string AllowedChildrenValue = "AllowedChildren";
        private const string ParentAndFirstLevelChildrenValue = "ParentAndFirstLevelChildren";
        private const string ParentOnlyValue = "ParentOnly";
        private const string ChildrenOnlyValue = "ChildrenOnly";

        /// <summary> AllowedParents. </summary>
        public static Enum2 AllowedParents { get; } = new Enum2(AllowedParentsValue);
        /// <summary> AllowedChildren. </summary>
        public static Enum2 AllowedChildren { get; } = new Enum2(AllowedChildrenValue);
        /// <summary> ParentAndFirstLevelChildren. </summary>
        public static Enum2 ParentAndFirstLevelChildren { get; } = new Enum2(ParentAndFirstLevelChildrenValue);
        /// <summary> ParentOnly. </summary>
        public static Enum2 ParentOnly { get; } = new Enum2(ParentOnlyValue);
        /// <summary> ChildrenOnly. </summary>
        public static Enum2 ChildrenOnly { get; } = new Enum2(ChildrenOnlyValue);
        /// <summary> Determines if two <see cref="Enum2"/> values are the same. </summary>
        public static bool operator ==(Enum2 left, Enum2 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum2"/> values are not the same. </summary>
        public static bool operator !=(Enum2 left, Enum2 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum2"/>. </summary>
        public static implicit operator Enum2(string value) => new Enum2(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum2 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum2 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
