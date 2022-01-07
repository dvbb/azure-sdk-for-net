// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The DataWarehouseUserActivityName. </summary>
    public readonly partial struct DataWarehouseUserActivityName : IEquatable<DataWarehouseUserActivityName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataWarehouseUserActivityName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataWarehouseUserActivityName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentValue = "current";

        /// <summary> current. </summary>
        public static DataWarehouseUserActivityName Current { get; } = new DataWarehouseUserActivityName(CurrentValue);
        /// <summary> Determines if two <see cref="DataWarehouseUserActivityName"/> values are the same. </summary>
        public static bool operator ==(DataWarehouseUserActivityName left, DataWarehouseUserActivityName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataWarehouseUserActivityName"/> values are not the same. </summary>
        public static bool operator !=(DataWarehouseUserActivityName left, DataWarehouseUserActivityName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataWarehouseUserActivityName"/>. </summary>
        public static implicit operator DataWarehouseUserActivityName(string value) => new DataWarehouseUserActivityName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataWarehouseUserActivityName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataWarehouseUserActivityName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
