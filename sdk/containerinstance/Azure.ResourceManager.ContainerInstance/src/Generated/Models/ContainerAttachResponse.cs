// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The information for the output stream from container attach. </summary>
    public partial class ContainerAttachResponse
    {
        /// <summary> Initializes a new instance of ContainerAttachResponse. </summary>
        internal ContainerAttachResponse()
        {
        }

        /// <summary> Initializes a new instance of ContainerAttachResponse. </summary>
        /// <param name="webSocketUri"> The uri for the output stream from the attach. </param>
        /// <param name="password"> The password to the output stream from the attach. Send as an Authorization header value when connecting to the websocketUri. </param>
        internal ContainerAttachResponse(string webSocketUri, string password)
        {
            WebSocketUri = webSocketUri;
            Password = password;
        }

        /// <summary> The uri for the output stream from the attach. </summary>
        public string WebSocketUri { get; }
        /// <summary> The password to the output stream from the attach. Send as an Authorization header value when connecting to the websocketUri. </summary>
        public string Password { get; }
    }
}
