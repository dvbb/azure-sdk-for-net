// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> DW Copy Command settings. </summary>
    public partial class DWCopyCommandSettings
    {
        /// <summary> Initializes a new instance of <see cref="DWCopyCommandSettings"/>. </summary>
        public DWCopyCommandSettings()
        {
            DefaultValues = new ChangeTrackingList<DWCopyCommandDefaultValue>();
            AdditionalOptions = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DWCopyCommandSettings"/>. </summary>
        /// <param name="defaultValues"> Specifies the default values for each target column in SQL DW. The default values in the property overwrite the DEFAULT constraint set in the DB, and identity column cannot have a default value. Type: array of objects (or Expression with resultType array of objects). </param>
        /// <param name="additionalOptions"> Additional options directly passed to SQL DW in Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalOptions": { "MAXERRORS": "1000", "DATEFORMAT": "'ymd'" }. </param>
        internal DWCopyCommandSettings(IList<DWCopyCommandDefaultValue> defaultValues, IDictionary<string, string> additionalOptions)
        {
            DefaultValues = defaultValues;
            AdditionalOptions = additionalOptions;
        }

        /// <summary> Specifies the default values for each target column in SQL DW. The default values in the property overwrite the DEFAULT constraint set in the DB, and identity column cannot have a default value. Type: array of objects (or Expression with resultType array of objects). </summary>
        public IList<DWCopyCommandDefaultValue> DefaultValues { get; }
        /// <summary> Additional options directly passed to SQL DW in Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalOptions": { "MAXERRORS": "1000", "DATEFORMAT": "'ymd'" }. </summary>
        public IDictionary<string, string> AdditionalOptions { get; }
    }
}
