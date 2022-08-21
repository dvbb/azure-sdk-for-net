// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Basic network, or Standard features available to the volume. </summary>
    public readonly partial struct NetworkFeature : IEquatable<NetworkFeature>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkFeature"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkFeature(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";

        /// <summary> Basic network feature. </summary>
        public static NetworkFeature Basic { get; } = new NetworkFeature(BasicValue);
        /// <summary> Standard network feature. </summary>
        public static NetworkFeature Standard { get; } = new NetworkFeature(StandardValue);
        /// <summary> Determines if two <see cref="NetworkFeature"/> values are the same. </summary>
        public static bool operator ==(NetworkFeature left, NetworkFeature right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkFeature"/> values are not the same. </summary>
        public static bool operator !=(NetworkFeature left, NetworkFeature right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkFeature"/>. </summary>
        public static implicit operator NetworkFeature(string value) => new NetworkFeature(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkFeature other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkFeature other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
