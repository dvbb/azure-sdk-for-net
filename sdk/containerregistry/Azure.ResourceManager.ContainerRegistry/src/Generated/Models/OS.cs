// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The OS of agent machine. </summary>
    public readonly partial struct OS : IEquatable<OS>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OS"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OS(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";

        /// <summary> Windows. </summary>
        public static OS Windows { get; } = new OS(WindowsValue);
        /// <summary> Linux. </summary>
        public static OS Linux { get; } = new OS(LinuxValue);
        /// <summary> Determines if two <see cref="OS"/> values are the same. </summary>
        public static bool operator ==(OS left, OS right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OS"/> values are not the same. </summary>
        public static bool operator !=(OS left, OS right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OS"/>. </summary>
        public static implicit operator OS(string value) => new OS(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OS other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OS other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
