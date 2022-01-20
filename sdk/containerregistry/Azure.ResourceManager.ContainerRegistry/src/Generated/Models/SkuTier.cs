// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The SKU tier based on the SKU name. </summary>
    public readonly partial struct SkuTier : IEquatable<SkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClassicValue = "Classic";
        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";

        /// <summary> Classic. </summary>
        public static SkuTier Classic { get; } = new SkuTier(ClassicValue);
        /// <summary> Basic. </summary>
        public static SkuTier Basic { get; } = new SkuTier(BasicValue);
        /// <summary> Standard. </summary>
        public static SkuTier Standard { get; } = new SkuTier(StandardValue);
        /// <summary> Premium. </summary>
        public static SkuTier Premium { get; } = new SkuTier(PremiumValue);
        /// <summary> Determines if two <see cref="SkuTier"/> values are the same. </summary>
        public static bool operator ==(SkuTier left, SkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SkuTier"/> values are not the same. </summary>
        public static bool operator !=(SkuTier left, SkuTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SkuTier"/>. </summary>
        public static implicit operator SkuTier(string value) => new SkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
