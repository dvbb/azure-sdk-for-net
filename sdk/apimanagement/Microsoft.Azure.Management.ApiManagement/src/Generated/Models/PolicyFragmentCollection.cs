// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response of the get policy fragments operation.
    /// </summary>
    public partial class PolicyFragmentCollection
    {
        /// <summary>
        /// Initializes a new instance of the PolicyFragmentCollection class.
        /// </summary>
        public PolicyFragmentCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyFragmentCollection class.
        /// </summary>
        /// <param name="value">Policy fragment contract value.</param>
        /// <param name="count">Total record count number.</param>
        /// <param name="nextLink">Next page link if any.</param>
        public PolicyFragmentCollection(IList<PolicyFragmentContract> value = default(IList<PolicyFragmentContract>), long? count = default(long?), string nextLink = default(string))
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets policy fragment contract value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PolicyFragmentContract> Value { get; set; }

        /// <summary>
        /// Gets or sets total record count number.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or sets next page link if any.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
