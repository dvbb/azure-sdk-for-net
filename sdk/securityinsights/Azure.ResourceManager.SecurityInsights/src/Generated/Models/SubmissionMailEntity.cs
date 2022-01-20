// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a submission mail entity. </summary>
    public partial class SubmissionMailEntity : EntityData
    {
        /// <summary> Initializes a new instance of SubmissionMailEntity. </summary>
        public SubmissionMailEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, object>();
            Kind = EntityKind.SubmissionMail;
        }

        /// <summary> Initializes a new instance of SubmissionMailEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="networkMessageId"> The network message id of email to which submission belongs. </param>
        /// <param name="submissionId"> The submission id. </param>
        /// <param name="submitter"> The submitter. </param>
        /// <param name="submissionDate"> The submission date. </param>
        /// <param name="timestamp"> The Time stamp when the message is received (Mail). </param>
        /// <param name="recipient"> The recipient of the mail. </param>
        /// <param name="sender"> The sender of the mail. </param>
        /// <param name="senderIp"> The sender&apos;s IP. </param>
        /// <param name="subject"> The subject of submission mail. </param>
        /// <param name="reportType"> The submission type for the given instance. This maps to Junk, Phish, Malware or NotJunk. </param>
        internal SubmissionMailEntity(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, object> additionalData, string friendlyName, Guid? networkMessageId, Guid? submissionId, string submitter, DateTimeOffset? submissionDate, DateTimeOffset? timestamp, string recipient, string sender, string senderIp, string subject, string reportType) : base(id, name, type, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            NetworkMessageId = networkMessageId;
            SubmissionId = submissionId;
            Submitter = submitter;
            SubmissionDate = submissionDate;
            Timestamp = timestamp;
            Recipient = recipient;
            Sender = sender;
            SenderIp = senderIp;
            Subject = subject;
            ReportType = reportType;
            Kind = kind;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, object> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The network message id of email to which submission belongs. </summary>
        public Guid? NetworkMessageId { get; }
        /// <summary> The submission id. </summary>
        public Guid? SubmissionId { get; }
        /// <summary> The submitter. </summary>
        public string Submitter { get; }
        /// <summary> The submission date. </summary>
        public DateTimeOffset? SubmissionDate { get; }
        /// <summary> The Time stamp when the message is received (Mail). </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The recipient of the mail. </summary>
        public string Recipient { get; }
        /// <summary> The sender of the mail. </summary>
        public string Sender { get; }
        /// <summary> The sender&apos;s IP. </summary>
        public string SenderIp { get; }
        /// <summary> The subject of submission mail. </summary>
        public string Subject { get; }
        /// <summary> The submission type for the given instance. This maps to Junk, Phish, Malware or NotJunk. </summary>
        public string ReportType { get; }
    }
}
