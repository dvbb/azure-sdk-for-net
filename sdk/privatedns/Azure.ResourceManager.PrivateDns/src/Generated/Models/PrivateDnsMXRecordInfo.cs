// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> An MX record. </summary>
    public partial class PrivateDnsMXRecordInfo
    {
        /// <summary> Initializes a new instance of <see cref="PrivateDnsMXRecordInfo"/>. </summary>
        public PrivateDnsMXRecordInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsMXRecordInfo"/>. </summary>
        /// <param name="preference"> The preference value for this MX record. </param>
        /// <param name="exchange"> The domain name of the mail host for this MX record. </param>
        internal PrivateDnsMXRecordInfo(int? preference, string exchange)
        {
            Preference = preference;
            Exchange = exchange;
        }

        /// <summary> The preference value for this MX record. </summary>
        public int? Preference { get; set; }
        /// <summary> The domain name of the mail host for this MX record. </summary>
        public string Exchange { get; set; }
    }
}
