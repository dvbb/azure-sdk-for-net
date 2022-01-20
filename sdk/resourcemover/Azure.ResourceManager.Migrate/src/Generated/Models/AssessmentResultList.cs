// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Migrate;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> List of assessments. </summary>
    internal partial class AssessmentResultList
    {
        /// <summary> Initializes a new instance of AssessmentResultList. </summary>
        internal AssessmentResultList()
        {
            Value = new ChangeTrackingList<AssessmentData>();
        }

        /// <summary> Initializes a new instance of AssessmentResultList. </summary>
        /// <param name="value"> List of assessments. </param>
        internal AssessmentResultList(IReadOnlyList<AssessmentData> value)
        {
            Value = value;
        }

        /// <summary> List of assessments. </summary>
        public IReadOnlyList<AssessmentData> Value { get; }
    }
}
