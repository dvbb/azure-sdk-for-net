// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters used to regenerate the login credential. </summary>
    public partial class RegenerateCredentialParameters
    {
        /// <summary> Initializes a new instance of RegenerateCredentialParameters. </summary>
        /// <param name="name"> Specifies name of the password which should be regenerated -- password or password2. </param>
        public RegenerateCredentialParameters(PasswordName name)
        {
            Name = name;
        }

        /// <summary> Specifies name of the password which should be regenerated -- password or password2. </summary>
        public PasswordName Name { get; }
    }
}
