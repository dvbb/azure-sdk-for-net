// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The credential type. </summary>
    internal readonly partial struct CredentialType : IEquatable<CredentialType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CredentialType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CredentialType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string AzureContainerRegistryScopedTokenValue = "AzureContainerRegistryScopedToken";
        private const string AzureStorageAccountTokenValue = "AzureStorageAccountToken";

        /// <summary> Unknown. </summary>
        public static CredentialType Unknown { get; } = new CredentialType(UnknownValue);
        /// <summary> AzureContainerRegistryScopedToken. </summary>
        public static CredentialType AzureContainerRegistryScopedToken { get; } = new CredentialType(AzureContainerRegistryScopedTokenValue);
        /// <summary> AzureStorageAccountToken. </summary>
        public static CredentialType AzureStorageAccountToken { get; } = new CredentialType(AzureStorageAccountTokenValue);
        /// <summary> Determines if two <see cref="CredentialType"/> values are the same. </summary>
        public static bool operator ==(CredentialType left, CredentialType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CredentialType"/> values are not the same. </summary>
        public static bool operator !=(CredentialType left, CredentialType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CredentialType"/>. </summary>
        public static implicit operator CredentialType(string value) => new CredentialType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CredentialType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CredentialType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
