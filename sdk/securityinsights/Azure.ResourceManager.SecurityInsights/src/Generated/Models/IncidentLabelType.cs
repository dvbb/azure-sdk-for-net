// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The type of the label. </summary>
    public readonly partial struct IncidentLabelType : IEquatable<IncidentLabelType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IncidentLabelType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IncidentLabelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserValue = "User";
        private const string SystemValue = "System";

        /// <summary> Label manually created by a user. </summary>
        public static IncidentLabelType User { get; } = new IncidentLabelType(UserValue);
        /// <summary> Label automatically created by the system. </summary>
        public static IncidentLabelType System { get; } = new IncidentLabelType(SystemValue);
        /// <summary> Determines if two <see cref="IncidentLabelType"/> values are the same. </summary>
        public static bool operator ==(IncidentLabelType left, IncidentLabelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IncidentLabelType"/> values are not the same. </summary>
        public static bool operator !=(IncidentLabelType left, IncidentLabelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IncidentLabelType"/>. </summary>
        public static implicit operator IncidentLabelType(string value) => new IncidentLabelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IncidentLabelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IncidentLabelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
