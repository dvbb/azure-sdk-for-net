// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Name of the notification hub sku. </summary>
    public readonly partial struct SkuName : IEquatable<SkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FreeValue = "Free";
        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";

        /// <summary> Free. </summary>
        public static SkuName Free { get; } = new SkuName(FreeValue);
        /// <summary> Basic. </summary>
        public static SkuName Basic { get; } = new SkuName(BasicValue);
        /// <summary> Standard. </summary>
        public static SkuName Standard { get; } = new SkuName(StandardValue);
        /// <summary> Determines if two <see cref="SkuName"/> values are the same. </summary>
        public static bool operator ==(SkuName left, SkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SkuName"/> values are not the same. </summary>
        public static bool operator !=(SkuName left, SkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SkuName"/>. </summary>
        public static implicit operator SkuName(string value) => new SkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
