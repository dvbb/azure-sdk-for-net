// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The location of Google Cloud Storage dataset. </summary>
    public partial class GoogleCloudStorageLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of GoogleCloudStorageLocation. </summary>
        public GoogleCloudStorageLocation()
        {
            Type = "GoogleCloudStorageLocation";
        }

        /// <summary> Initializes a new instance of GoogleCloudStorageLocation. </summary>
        /// <param name="type"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="bucketName"> Specify the bucketName of Google Cloud Storage. Type: string (or Expression with resultType string). </param>
        /// <param name="version"> Specify the version of Google Cloud Storage. Type: string (or Expression with resultType string). </param>
        internal GoogleCloudStorageLocation(string type, object folderPath, object fileName, IDictionary<string, object> additionalProperties, object bucketName, object version) : base(type, folderPath, fileName, additionalProperties)
        {
            BucketName = bucketName;
            Version = version;
            Type = type ?? "GoogleCloudStorageLocation";
        }

        /// <summary> Specify the bucketName of Google Cloud Storage. Type: string (or Expression with resultType string). </summary>
        public object BucketName { get; set; }
        /// <summary> Specify the version of Google Cloud Storage. Type: string (or Expression with resultType string). </summary>
        public object Version { get; set; }
    }
}
