// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> List of API operations. </summary>
    internal partial class AssessmentOptionsResultList
    {
        /// <summary> Initializes a new instance of AssessmentOptionsResultList. </summary>
        internal AssessmentOptionsResultList()
        {
            Value = new ChangeTrackingList<AssessmentOptions>();
        }

        /// <summary> Initializes a new instance of AssessmentOptionsResultList. </summary>
        /// <param name="value"> List of operations. </param>
        internal AssessmentOptionsResultList(IReadOnlyList<AssessmentOptions> value)
        {
            Value = value;
        }

        /// <summary> List of operations. </summary>
        public IReadOnlyList<AssessmentOptions> Value { get; }
    }
}
