// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> The limit object type. </summary>
    public readonly partial struct LimitType : IEquatable<LimitType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LimitType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LimitType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LimitValueValue = "LimitValue";

        /// <summary> LimitValue. </summary>
        public static LimitType LimitValue { get; } = new LimitType(LimitValueValue);
        /// <summary> Determines if two <see cref="LimitType"/> values are the same. </summary>
        public static bool operator ==(LimitType left, LimitType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LimitType"/> values are not the same. </summary>
        public static bool operator !=(LimitType left, LimitType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LimitType"/>. </summary>
        public static implicit operator LimitType(string value) => new LimitType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LimitType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LimitType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
