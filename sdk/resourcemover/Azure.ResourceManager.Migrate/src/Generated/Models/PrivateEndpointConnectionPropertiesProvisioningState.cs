// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Indicates whether there is an ongoing operation on the private endpoint. </summary>
    public readonly partial struct PrivateEndpointConnectionPropertiesProvisioningState : IEquatable<PrivateEndpointConnectionPropertiesProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnectionPropertiesProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrivateEndpointConnectionPropertiesProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Accepted. </summary>
        public static PrivateEndpointConnectionPropertiesProvisioningState Accepted { get; } = new PrivateEndpointConnectionPropertiesProvisioningState(AcceptedValue);
        /// <summary> InProgress. </summary>
        public static PrivateEndpointConnectionPropertiesProvisioningState InProgress { get; } = new PrivateEndpointConnectionPropertiesProvisioningState(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static PrivateEndpointConnectionPropertiesProvisioningState Succeeded { get; } = new PrivateEndpointConnectionPropertiesProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static PrivateEndpointConnectionPropertiesProvisioningState Failed { get; } = new PrivateEndpointConnectionPropertiesProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="PrivateEndpointConnectionPropertiesProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PrivateEndpointConnectionPropertiesProvisioningState left, PrivateEndpointConnectionPropertiesProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrivateEndpointConnectionPropertiesProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PrivateEndpointConnectionPropertiesProvisioningState left, PrivateEndpointConnectionPropertiesProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrivateEndpointConnectionPropertiesProvisioningState"/>. </summary>
        public static implicit operator PrivateEndpointConnectionPropertiesProvisioningState(string value) => new PrivateEndpointConnectionPropertiesProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrivateEndpointConnectionPropertiesProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrivateEndpointConnectionPropertiesProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
