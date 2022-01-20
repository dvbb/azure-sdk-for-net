// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Scheduler.Models
{
    /// <summary> The StorageQueueMessage. </summary>
    public partial class StorageQueueMessage
    {
        /// <summary> Initializes a new instance of StorageQueueMessage. </summary>
        public StorageQueueMessage()
        {
        }

        /// <summary> Initializes a new instance of StorageQueueMessage. </summary>
        /// <param name="storageAccount"> Gets or sets the storage account name. </param>
        /// <param name="queueName"> Gets or sets the queue name. </param>
        /// <param name="sasToken"> Gets or sets the SAS key. </param>
        /// <param name="message"> Gets or sets the message. </param>
        internal StorageQueueMessage(string storageAccount, string queueName, string sasToken, string message)
        {
            StorageAccount = storageAccount;
            QueueName = queueName;
            SasToken = sasToken;
            Message = message;
        }

        /// <summary> Gets or sets the storage account name. </summary>
        public string StorageAccount { get; set; }
        /// <summary> Gets or sets the queue name. </summary>
        public string QueueName { get; set; }
        /// <summary> Gets or sets the SAS key. </summary>
        public string SasToken { get; set; }
        /// <summary> Gets or sets the message. </summary>
        public string Message { get; set; }
    }
}
