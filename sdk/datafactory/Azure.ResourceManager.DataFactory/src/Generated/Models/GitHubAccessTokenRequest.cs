// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Get GitHub access token request definition. </summary>
    public partial class GitHubAccessTokenRequest
    {
        /// <summary> Initializes a new instance of GitHubAccessTokenRequest. </summary>
        /// <param name="gitHubAccessCode"> GitHub access code. </param>
        /// <param name="gitHubAccessTokenBaseUrl"> GitHub access token base URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubAccessCode"/> or <paramref name="gitHubAccessTokenBaseUrl"/> is null. </exception>
        public GitHubAccessTokenRequest(string gitHubAccessCode, string gitHubAccessTokenBaseUrl)
        {
            if (gitHubAccessCode == null)
            {
                throw new ArgumentNullException(nameof(gitHubAccessCode));
            }
            if (gitHubAccessTokenBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(gitHubAccessTokenBaseUrl));
            }

            GitHubAccessCode = gitHubAccessCode;
            GitHubAccessTokenBaseUrl = gitHubAccessTokenBaseUrl;
        }

        /// <summary> GitHub access code. </summary>
        public string GitHubAccessCode { get; }
        /// <summary> GitHub application client ID. </summary>
        public string GitHubClientId { get; set; }
        /// <summary> GitHub bring your own app client secret information. </summary>
        public GitHubClientSecret GitHubClientSecret { get; set; }
        /// <summary> GitHub access token base URL. </summary>
        public string GitHubAccessTokenBaseUrl { get; }
    }
}
