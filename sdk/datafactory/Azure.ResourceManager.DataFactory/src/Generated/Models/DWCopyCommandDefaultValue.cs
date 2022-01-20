// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Default value. </summary>
    public partial class DWCopyCommandDefaultValue
    {
        /// <summary> Initializes a new instance of DWCopyCommandDefaultValue. </summary>
        public DWCopyCommandDefaultValue()
        {
        }

        /// <summary> Initializes a new instance of DWCopyCommandDefaultValue. </summary>
        /// <param name="columnName"> Column name. Type: object (or Expression with resultType string). </param>
        /// <param name="defaultValue"> The default value of the column. Type: object (or Expression with resultType string). </param>
        internal DWCopyCommandDefaultValue(object columnName, object defaultValue)
        {
            ColumnName = columnName;
            DefaultValue = defaultValue;
        }

        /// <summary> Column name. Type: object (or Expression with resultType string). </summary>
        public object ColumnName { get; set; }
        /// <summary> The default value of the column. Type: object (or Expression with resultType string). </summary>
        public object DefaultValue { get; set; }
    }
}
