// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The password that will be used for authenticating the token of a container registry. </summary>
    public partial class ContainerRegistryTokenPassword
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTokenPassword"/>. </summary>
        public ContainerRegistryTokenPassword()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTokenPassword"/>. </summary>
        /// <param name="createdOn"> The creation datetime of the password. </param>
        /// <param name="expireOn"> The expiry datetime of the password. </param>
        /// <param name="name"> The password name "password1" or "password2". </param>
        /// <param name="value"> The password value. </param>
        internal ContainerRegistryTokenPassword(DateTimeOffset? createdOn, DateTimeOffset? expireOn, ContainerRegistryTokenPasswordName? name, string value)
        {
            CreatedOn = createdOn;
            ExpireOn = expireOn;
            Name = name;
            Value = value;
        }

        /// <summary> The creation datetime of the password. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The expiry datetime of the password. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The password name "password1" or "password2". </summary>
        public ContainerRegistryTokenPasswordName? Name { get; set; }
        /// <summary> The password value. </summary>
        public string Value { get; }
    }
}
