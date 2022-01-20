// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The Amazon S3 settings needed for the interim Amazon S3 when copying from Amazon Redshift with unload. With this, data from Amazon Redshift source will be unloaded into S3 first and then copied into the targeted sink from the interim S3. </summary>
    public partial class RedshiftUnloadSettings
    {
        /// <summary> Initializes a new instance of RedshiftUnloadSettings. </summary>
        /// <param name="s3LinkedServiceName"> The name of the Amazon S3 linked service which will be used for the unload operation when copying from the Amazon Redshift source. </param>
        /// <param name="bucketName"> The bucket of the interim Amazon S3 which will be used to store the unloaded data from Amazon Redshift source. The bucket must be in the same region as the Amazon Redshift source. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="s3LinkedServiceName"/> or <paramref name="bucketName"/> is null. </exception>
        public RedshiftUnloadSettings(LinkedServiceReference s3LinkedServiceName, object bucketName)
        {
            if (s3LinkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(s3LinkedServiceName));
            }
            if (bucketName == null)
            {
                throw new ArgumentNullException(nameof(bucketName));
            }

            S3LinkedServiceName = s3LinkedServiceName;
            BucketName = bucketName;
        }

        /// <summary> The name of the Amazon S3 linked service which will be used for the unload operation when copying from the Amazon Redshift source. </summary>
        public LinkedServiceReference S3LinkedServiceName { get; set; }
        /// <summary> The bucket of the interim Amazon S3 which will be used to store the unloaded data from Amazon Redshift source. The bucket must be in the same region as the Amazon Redshift source. Type: string (or Expression with resultType string). </summary>
        public object BucketName { get; set; }
    }
}
