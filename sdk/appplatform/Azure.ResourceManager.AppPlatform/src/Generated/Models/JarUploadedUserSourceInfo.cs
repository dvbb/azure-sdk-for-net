// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Uploaded Jar binary for a deployment. </summary>
    public partial class JarUploadedUserSourceInfo : AppPlatformUploadedUserSourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="JarUploadedUserSourceInfo"/>. </summary>
        public JarUploadedUserSourceInfo()
        {
            UserSourceInfoType = "Jar";
        }

        /// <summary> Initializes a new instance of <see cref="JarUploadedUserSourceInfo"/>. </summary>
        /// <param name="userSourceInfoType"> Type of the source uploaded. </param>
        /// <param name="version"> Version of the source. </param>
        /// <param name="relativePath"> Relative path of the storage which stores the source. </param>
        /// <param name="runtimeVersion"> Runtime version of the Jar file. </param>
        /// <param name="jvmOptions"> JVM parameter. </param>
        internal JarUploadedUserSourceInfo(string userSourceInfoType, string version, string relativePath, string runtimeVersion, string jvmOptions) : base(userSourceInfoType, version, relativePath)
        {
            RuntimeVersion = runtimeVersion;
            JvmOptions = jvmOptions;
            UserSourceInfoType = userSourceInfoType ?? "Jar";
        }

        /// <summary> Runtime version of the Jar file. </summary>
        public string RuntimeVersion { get; set; }
        /// <summary> JVM parameter. </summary>
        public string JvmOptions { get; set; }
    }
}
