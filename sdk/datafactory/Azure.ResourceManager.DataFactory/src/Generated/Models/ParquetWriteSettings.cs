// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Parquet write settings. </summary>
    public partial class ParquetWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of ParquetWriteSettings. </summary>
        public ParquetWriteSettings()
        {
            Type = "ParquetWriteSettings";
        }

        /// <summary> Initializes a new instance of ParquetWriteSettings. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="maxRowsPerFile"> Limit the written file&apos;s row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="fileNamePrefix"> Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string). </param>
        internal ParquetWriteSettings(string type, IDictionary<string, object> additionalProperties, object maxRowsPerFile, object fileNamePrefix) : base(type, additionalProperties)
        {
            MaxRowsPerFile = maxRowsPerFile;
            FileNamePrefix = fileNamePrefix;
            Type = type ?? "ParquetWriteSettings";
        }

        /// <summary> Limit the written file&apos;s row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer). </summary>
        public object MaxRowsPerFile { get; set; }
        /// <summary> Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string). </summary>
        public object FileNamePrefix { get; set; }
    }
}
