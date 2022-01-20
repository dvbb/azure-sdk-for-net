// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The partition mechanism that will be used for SAP HANA read in parallel. </summary>
    internal readonly partial struct SapHanaPartitionOption : IEquatable<SapHanaPartitionOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapHanaPartitionOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapHanaPartitionOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string PhysicalPartitionsOfTableValue = "PhysicalPartitionsOfTable";
        private const string SapHanaDynamicRangeValue = "SapHanaDynamicRange";

        /// <summary> None. </summary>
        public static SapHanaPartitionOption None { get; } = new SapHanaPartitionOption(NoneValue);
        /// <summary> PhysicalPartitionsOfTable. </summary>
        public static SapHanaPartitionOption PhysicalPartitionsOfTable { get; } = new SapHanaPartitionOption(PhysicalPartitionsOfTableValue);
        /// <summary> SapHanaDynamicRange. </summary>
        public static SapHanaPartitionOption SapHanaDynamicRange { get; } = new SapHanaPartitionOption(SapHanaDynamicRangeValue);
        /// <summary> Determines if two <see cref="SapHanaPartitionOption"/> values are the same. </summary>
        public static bool operator ==(SapHanaPartitionOption left, SapHanaPartitionOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapHanaPartitionOption"/> values are not the same. </summary>
        public static bool operator !=(SapHanaPartitionOption left, SapHanaPartitionOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SapHanaPartitionOption"/>. </summary>
        public static implicit operator SapHanaPartitionOption(string value) => new SapHanaPartitionOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapHanaPartitionOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapHanaPartitionOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
