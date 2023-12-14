// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Subscription update details. </summary>
    public partial class ApiManagementSubscriptionPatch
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementSubscriptionPatch"/>. </summary>
        public ApiManagementSubscriptionPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementSubscriptionPatch"/>. </summary>
        /// <param name="ownerId"> User identifier path: /users/{userId}. </param>
        /// <param name="scope"> Scope like /products/{productId} or /apis or /apis/{apiId}. </param>
        /// <param name="expireOn"> Subscription expiration date. The setting is for audit purposes only and the subscription is not automatically expired. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard. </param>
        /// <param name="displayName"> Subscription name. </param>
        /// <param name="primaryKey"> Primary subscription key. </param>
        /// <param name="secondaryKey"> Secondary subscription key. </param>
        /// <param name="state"> Subscription state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated. </param>
        /// <param name="stateComment"> Comments describing subscription state change by the administrator when the state is changed to the 'rejected'. </param>
        /// <param name="allowTracing"> Determines whether tracing can be enabled. </param>
        internal ApiManagementSubscriptionPatch(string ownerId, string scope, DateTimeOffset? expireOn, string displayName, string primaryKey, string secondaryKey, SubscriptionState? state, string stateComment, bool? allowTracing)
        {
            OwnerId = ownerId;
            Scope = scope;
            ExpireOn = expireOn;
            DisplayName = displayName;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            State = state;
            StateComment = stateComment;
            AllowTracing = allowTracing;
        }

        /// <summary> User identifier path: /users/{userId}. </summary>
        public string OwnerId { get; set; }
        /// <summary> Scope like /products/{productId} or /apis or /apis/{apiId}. </summary>
        public string Scope { get; set; }
        /// <summary> Subscription expiration date. The setting is for audit purposes only and the subscription is not automatically expired. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Subscription name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Primary subscription key. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> Secondary subscription key. </summary>
        public string SecondaryKey { get; set; }
        /// <summary> Subscription state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated. </summary>
        public SubscriptionState? State { get; set; }
        /// <summary> Comments describing subscription state change by the administrator when the state is changed to the 'rejected'. </summary>
        public string StateComment { get; set; }
        /// <summary> Determines whether tracing can be enabled. </summary>
        public bool? AllowTracing { get; set; }
    }
}
