// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The type of endpoint. </summary>
    public readonly partial struct EndpointType : IEquatable<EndpointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EndpointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EndpointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AFDValue = "AFD";
        private const string AzureRegionValue = "AzureRegion";
        private const string CDNValue = "CDN";
        private const string ATMValue = "ATM";

        /// <summary> AFD. </summary>
        public static EndpointType AFD { get; } = new EndpointType(AFDValue);
        /// <summary> AzureRegion. </summary>
        public static EndpointType AzureRegion { get; } = new EndpointType(AzureRegionValue);
        /// <summary> CDN. </summary>
        public static EndpointType CDN { get; } = new EndpointType(CDNValue);
        /// <summary> ATM. </summary>
        public static EndpointType ATM { get; } = new EndpointType(ATMValue);
        /// <summary> Determines if two <see cref="EndpointType"/> values are the same. </summary>
        public static bool operator ==(EndpointType left, EndpointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EndpointType"/> values are not the same. </summary>
        public static bool operator !=(EndpointType left, EndpointType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EndpointType"/>. </summary>
        public static implicit operator EndpointType(string value) => new EndpointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EndpointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EndpointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
