// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CustomProviders.Models
{
    /// <summary> The routing types that are supported for resource requests. </summary>
    public readonly partial struct ResourceTypeRouting : IEquatable<ResourceTypeRouting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceTypeRouting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceTypeRouting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ProxyValue = "Proxy";
        private const string ProxyCacheValue = "Proxy,Cache";

        /// <summary> Proxy. </summary>
        public static ResourceTypeRouting Proxy { get; } = new ResourceTypeRouting(ProxyValue);
        /// <summary> Proxy,Cache. </summary>
        public static ResourceTypeRouting ProxyCache { get; } = new ResourceTypeRouting(ProxyCacheValue);
        /// <summary> Determines if two <see cref="ResourceTypeRouting"/> values are the same. </summary>
        public static bool operator ==(ResourceTypeRouting left, ResourceTypeRouting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceTypeRouting"/> values are not the same. </summary>
        public static bool operator !=(ResourceTypeRouting left, ResourceTypeRouting right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceTypeRouting"/>. </summary>
        public static implicit operator ResourceTypeRouting(string value) => new ResourceTypeRouting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceTypeRouting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceTypeRouting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
