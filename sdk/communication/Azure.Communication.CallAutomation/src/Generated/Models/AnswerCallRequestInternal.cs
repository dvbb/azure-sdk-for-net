// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for answering the call. </summary>
    internal partial class AnswerCallRequestInternal
    {
        /// <summary> Initializes a new instance of AnswerCallRequestInternal. </summary>
        /// <param name="incomingCallContext"> The context associated with the call. </param>
        /// <param name="callbackUri"> The callback uri. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="incomingCallContext"/> or <paramref name="callbackUri"/> is null. </exception>
        public AnswerCallRequestInternal(string incomingCallContext, string callbackUri)
        {
            if (incomingCallContext == null)
            {
                throw new ArgumentNullException(nameof(incomingCallContext));
            }
            if (callbackUri == null)
            {
                throw new ArgumentNullException(nameof(callbackUri));
            }

            IncomingCallContext = incomingCallContext;
            CallbackUri = callbackUri;
        }

        /// <summary> The context associated with the call. </summary>
        public string IncomingCallContext { get; }
        /// <summary> The callback uri. </summary>
        public string CallbackUri { get; }
        /// <summary> Media Streaming Configuration. </summary>
        public MediaStreamingOptionsInternal MediaStreamingConfiguration { get; set; }
    }
}
