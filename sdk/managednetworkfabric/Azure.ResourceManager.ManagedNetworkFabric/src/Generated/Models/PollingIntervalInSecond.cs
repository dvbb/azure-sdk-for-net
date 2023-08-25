// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Polling interval in seconds. </summary>
    public readonly partial struct PollingIntervalInSecond : IEquatable<PollingIntervalInSecond>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="PollingIntervalInSecond"/>. </summary>
        public PollingIntervalInSecond(int value)
        {
            _value = value;
        }

        private const int ThirtyValue = 30;
        private const int SixtyValue = 60;
        private const int NinetyValue = 90;
        private const int OneHundredTwentyValue = 120;

        /// <summary> 30. </summary>
        public static PollingIntervalInSecond Thirty { get; } = new PollingIntervalInSecond(ThirtyValue);
        /// <summary> 60. </summary>
        public static PollingIntervalInSecond Sixty { get; } = new PollingIntervalInSecond(SixtyValue);
        /// <summary> 90. </summary>
        public static PollingIntervalInSecond Ninety { get; } = new PollingIntervalInSecond(NinetyValue);
        /// <summary> 120. </summary>
        public static PollingIntervalInSecond OneHundredTwenty { get; } = new PollingIntervalInSecond(OneHundredTwentyValue);

        internal int ToSerialInt32() => _value;

        /// <summary> Determines if two <see cref="PollingIntervalInSecond"/> values are the same. </summary>
        public static bool operator ==(PollingIntervalInSecond left, PollingIntervalInSecond right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PollingIntervalInSecond"/> values are not the same. </summary>
        public static bool operator !=(PollingIntervalInSecond left, PollingIntervalInSecond right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PollingIntervalInSecond"/>. </summary>
        public static implicit operator PollingIntervalInSecond(int value) => new PollingIntervalInSecond(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PollingIntervalInSecond other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PollingIntervalInSecond other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
