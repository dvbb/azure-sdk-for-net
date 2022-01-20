// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The registrar associated with this domain. </summary>
    public partial class EnrichmentDomainWhoisRegistrarDetails
    {
        /// <summary> Initializes a new instance of EnrichmentDomainWhoisRegistrarDetails. </summary>
        internal EnrichmentDomainWhoisRegistrarDetails()
        {
        }

        /// <summary> Initializes a new instance of EnrichmentDomainWhoisRegistrarDetails. </summary>
        /// <param name="name"> The name of this registrar. </param>
        /// <param name="abuseContactEmail"> This registrar&apos;s abuse contact email. </param>
        /// <param name="abuseContactPhone"> This registrar&apos;s abuse contact phone number. </param>
        /// <param name="ianaId"> This registrar&apos;s Internet Assigned Numbers Authority id. </param>
        /// <param name="url"> This registrar&apos;s URL. </param>
        /// <param name="whoisServer"> The hostname of this registrar&apos;s whois server. </param>
        internal EnrichmentDomainWhoisRegistrarDetails(string name, string abuseContactEmail, string abuseContactPhone, string ianaId, string url, string whoisServer)
        {
            Name = name;
            AbuseContactEmail = abuseContactEmail;
            AbuseContactPhone = abuseContactPhone;
            IanaId = ianaId;
            Url = url;
            WhoisServer = whoisServer;
        }

        /// <summary> The name of this registrar. </summary>
        public string Name { get; }
        /// <summary> This registrar&apos;s abuse contact email. </summary>
        public string AbuseContactEmail { get; }
        /// <summary> This registrar&apos;s abuse contact phone number. </summary>
        public string AbuseContactPhone { get; }
        /// <summary> This registrar&apos;s Internet Assigned Numbers Authority id. </summary>
        public string IanaId { get; }
        /// <summary> This registrar&apos;s URL. </summary>
        public string Url { get; }
        /// <summary> The hostname of this registrar&apos;s whois server. </summary>
        public string WhoisServer { get; }
    }
}
