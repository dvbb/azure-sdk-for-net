// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Information used to connect to a CIFS file system. </summary>
    public partial class BatchCifsMountConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="BatchCifsMountConfiguration"/>. </summary>
        /// <param name="username"> The user to use for authentication against the CIFS file system. </param>
        /// <param name="source"> The URI of the file system to mount. </param>
        /// <param name="relativeMountPath"> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </param>
        /// <param name="password"> The password to use for authentication against the CIFS file system. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/>, <paramref name="source"/>, <paramref name="relativeMountPath"/> or <paramref name="password"/> is null. </exception>
        public BatchCifsMountConfiguration(string username, string source, string relativeMountPath, string password)
        {
            Argument.AssertNotNull(username, nameof(username));
            Argument.AssertNotNull(source, nameof(source));
            Argument.AssertNotNull(relativeMountPath, nameof(relativeMountPath));
            Argument.AssertNotNull(password, nameof(password));

            Username = username;
            Source = source;
            RelativeMountPath = relativeMountPath;
            Password = password;
        }

        /// <summary> Initializes a new instance of <see cref="BatchCifsMountConfiguration"/>. </summary>
        /// <param name="username"> The user to use for authentication against the CIFS file system. </param>
        /// <param name="source"> The URI of the file system to mount. </param>
        /// <param name="relativeMountPath"> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </param>
        /// <param name="mountOptions"> These are 'net use' options in Windows and 'mount' options in Linux. </param>
        /// <param name="password"> The password to use for authentication against the CIFS file system. </param>
        internal BatchCifsMountConfiguration(string username, string source, string relativeMountPath, string mountOptions, string password)
        {
            Username = username;
            Source = source;
            RelativeMountPath = relativeMountPath;
            MountOptions = mountOptions;
            Password = password;
        }

        /// <summary> The user to use for authentication against the CIFS file system. </summary>
        public string Username { get; set; }
        /// <summary> The URI of the file system to mount. </summary>
        public string Source { get; set; }
        /// <summary> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </summary>
        public string RelativeMountPath { get; set; }
        /// <summary> These are 'net use' options in Windows and 'mount' options in Linux. </summary>
        public string MountOptions { get; set; }
        /// <summary> The password to use for authentication against the CIFS file system. </summary>
        public string Password { get; set; }
    }
}
