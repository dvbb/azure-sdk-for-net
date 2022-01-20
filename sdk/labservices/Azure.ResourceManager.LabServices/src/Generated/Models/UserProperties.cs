// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> User resource properties. </summary>
    internal partial class UserProperties : UserUpdateProperties
    {
        /// <summary> Initializes a new instance of UserProperties. </summary>
        /// <param name="email"> Email address of the user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="email"/> is null. </exception>
        internal UserProperties(string email)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            Email = email;
        }

        /// <summary> Current provisioning state of the user resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Display name of the user, for example user&apos;s full name. </summary>
        public string DisplayName { get; }
        /// <summary> Email address of the user. </summary>
        public string Email { get; }
        /// <summary> State of the user&apos;s registration within the lab. </summary>
        public RegistrationState? RegistrationState { get; }
        /// <summary> State of the invitation message for the user. </summary>
        public InvitationState? InvitationState { get; }
        /// <summary> Date and time when the invitation message was sent to the user. </summary>
        public DateTimeOffset? InvitationSent { get; }
        /// <summary> How long the user has used their virtual machines in this lab. </summary>
        public TimeSpan? TotalUsage { get; }
    }
}
