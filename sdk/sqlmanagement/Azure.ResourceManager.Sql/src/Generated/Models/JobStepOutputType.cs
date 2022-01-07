// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The output destination type. </summary>
    public readonly partial struct JobStepOutputType : IEquatable<JobStepOutputType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobStepOutputType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobStepOutputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SqlDatabaseValue = "SqlDatabase";

        /// <summary> SqlDatabase. </summary>
        public static JobStepOutputType SqlDatabase { get; } = new JobStepOutputType(SqlDatabaseValue);
        /// <summary> Determines if two <see cref="JobStepOutputType"/> values are the same. </summary>
        public static bool operator ==(JobStepOutputType left, JobStepOutputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobStepOutputType"/> values are not the same. </summary>
        public static bool operator !=(JobStepOutputType left, JobStepOutputType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobStepOutputType"/>. </summary>
        public static implicit operator JobStepOutputType(string value) => new JobStepOutputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobStepOutputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobStepOutputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
