// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.StorSimple8000Series;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    /// <summary> The collection of volumes. </summary>
    internal partial class VolumeList
    {
        /// <summary> Initializes a new instance of VolumeList. </summary>
        /// <param name="value"> The value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VolumeList(IEnumerable<VolumeData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of VolumeList. </summary>
        /// <param name="value"> The value. </param>
        internal VolumeList(IReadOnlyList<VolumeData> value)
        {
            Value = value;
        }

        /// <summary> The value. </summary>
        public IReadOnlyList<VolumeData> Value { get; }
    }
}
