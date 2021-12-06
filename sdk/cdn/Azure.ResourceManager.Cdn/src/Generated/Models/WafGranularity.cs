// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The WafGranularity. </summary>
    public readonly partial struct WafGranularity : IEquatable<WafGranularity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WafGranularity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WafGranularity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PT5MValue = "PT5M";
        private const string PT1HValue = "PT1H";
        private const string P1DValue = "P1D";

        /// <summary> PT5M. </summary>
        public static WafGranularity PT5M { get; } = new WafGranularity(PT5MValue);
        /// <summary> PT1H. </summary>
        public static WafGranularity PT1H { get; } = new WafGranularity(PT1HValue);
        /// <summary> P1D. </summary>
        public static WafGranularity P1D { get; } = new WafGranularity(P1DValue);
        /// <summary> Determines if two <see cref="WafGranularity"/> values are the same. </summary>
        public static bool operator ==(WafGranularity left, WafGranularity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WafGranularity"/> values are not the same. </summary>
        public static bool operator !=(WafGranularity left, WafGranularity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WafGranularity"/>. </summary>
        public static implicit operator WafGranularity(string value) => new WafGranularity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WafGranularity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WafGranularity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
