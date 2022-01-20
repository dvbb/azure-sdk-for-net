// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Threat intelligence indicator entity. </summary>
    public partial class ThreatIntelligenceIndicatorModel : ThreatIntelligenceInformationData
    {
        /// <summary> Initializes a new instance of ThreatIntelligenceIndicatorModel. </summary>
        /// <param name="kind"> The kind of the entity. </param>
        public ThreatIntelligenceIndicatorModel(ThreatIntelligenceResourceKindEnum kind) : base(kind)
        {
            AdditionalData = new ChangeTrackingDictionary<string, object>();
            ThreatIntelligenceTags = new ChangeTrackingList<string>();
            IndicatorTypes = new ChangeTrackingList<string>();
            KillChainPhases = new ChangeTrackingList<ThreatIntelligenceKillChainPhase>();
            ParsedPattern = new ChangeTrackingList<ThreatIntelligenceParsedPattern>();
            ExternalReferences = new ChangeTrackingList<ThreatIntelligenceExternalReference>();
            GranularMarkings = new ChangeTrackingList<ThreatIntelligenceGranularMarkingModel>();
            Labels = new ChangeTrackingList<string>();
            ObjectMarkingRefs = new ChangeTrackingList<string>();
            ThreatTypes = new ChangeTrackingList<string>();
            Extensions = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ThreatIntelligenceIndicatorModel. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="threatIntelligenceTags"> List of tags. </param>
        /// <param name="lastUpdatedTimeUtc"> Last updated time in UTC. </param>
        /// <param name="source"> Source of a threat intelligence entity. </param>
        /// <param name="displayName"> Display name of a threat intelligence entity. </param>
        /// <param name="description"> Description of a threat intelligence entity. </param>
        /// <param name="indicatorTypes"> Indicator types of threat intelligence entities. </param>
        /// <param name="pattern"> Pattern of a threat intelligence entity. </param>
        /// <param name="patternType"> Pattern type of a threat intelligence entity. </param>
        /// <param name="patternVersion"> Pattern version of a threat intelligence entity. </param>
        /// <param name="killChainPhases"> Kill chain phases. </param>
        /// <param name="parsedPattern"> Parsed patterns. </param>
        /// <param name="externalId"> External ID of threat intelligence entity. </param>
        /// <param name="createdByRef"> Created by reference of threat intelligence entity. </param>
        /// <param name="defanged"> Is threat intelligence entity defanged. </param>
        /// <param name="externalLastUpdatedTimeUtc"> External last updated time in UTC. </param>
        /// <param name="externalReferences"> External References. </param>
        /// <param name="granularMarkings"> Granular Markings. </param>
        /// <param name="labels"> Labels  of threat intelligence entity. </param>
        /// <param name="revoked"> Is threat intelligence entity revoked. </param>
        /// <param name="confidence"> Confidence of threat intelligence entity. </param>
        /// <param name="objectMarkingRefs"> Threat intelligence entity object marking references. </param>
        /// <param name="language"> Language of threat intelligence entity. </param>
        /// <param name="threatTypes"> Threat types. </param>
        /// <param name="validFrom"> Valid from. </param>
        /// <param name="validUntil"> Valid until. </param>
        /// <param name="created"> Created by. </param>
        /// <param name="modified"> Modified by. </param>
        /// <param name="extensions"> Extensions map. </param>
        internal ThreatIntelligenceIndicatorModel(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string etag, ThreatIntelligenceResourceKindEnum kind, IReadOnlyDictionary<string, object> additionalData, string friendlyName, IList<string> threatIntelligenceTags, string lastUpdatedTimeUtc, string source, string displayName, string description, IList<string> indicatorTypes, string pattern, string patternType, string patternVersion, IList<ThreatIntelligenceKillChainPhase> killChainPhases, IList<ThreatIntelligenceParsedPattern> parsedPattern, string externalId, string createdByRef, bool? defanged, string externalLastUpdatedTimeUtc, IList<ThreatIntelligenceExternalReference> externalReferences, IList<ThreatIntelligenceGranularMarkingModel> granularMarkings, IList<string> labels, bool? revoked, int? confidence, IList<string> objectMarkingRefs, string language, IList<string> threatTypes, string validFrom, string validUntil, string created, string modified, IDictionary<string, object> extensions) : base(id, name, type, systemData, etag, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            ThreatIntelligenceTags = threatIntelligenceTags;
            LastUpdatedTimeUtc = lastUpdatedTimeUtc;
            Source = source;
            DisplayName = displayName;
            Description = description;
            IndicatorTypes = indicatorTypes;
            Pattern = pattern;
            PatternType = patternType;
            PatternVersion = patternVersion;
            KillChainPhases = killChainPhases;
            ParsedPattern = parsedPattern;
            ExternalId = externalId;
            CreatedByRef = createdByRef;
            Defanged = defanged;
            ExternalLastUpdatedTimeUtc = externalLastUpdatedTimeUtc;
            ExternalReferences = externalReferences;
            GranularMarkings = granularMarkings;
            Labels = labels;
            Revoked = revoked;
            Confidence = confidence;
            ObjectMarkingRefs = objectMarkingRefs;
            Language = language;
            ThreatTypes = threatTypes;
            ValidFrom = validFrom;
            ValidUntil = validUntil;
            Created = created;
            Modified = modified;
            Extensions = extensions;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, object> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> List of tags. </summary>
        public IList<string> ThreatIntelligenceTags { get; }
        /// <summary> Last updated time in UTC. </summary>
        public string LastUpdatedTimeUtc { get; set; }
        /// <summary> Source of a threat intelligence entity. </summary>
        public string Source { get; set; }
        /// <summary> Display name of a threat intelligence entity. </summary>
        public string DisplayName { get; set; }
        /// <summary> Description of a threat intelligence entity. </summary>
        public string Description { get; set; }
        /// <summary> Indicator types of threat intelligence entities. </summary>
        public IList<string> IndicatorTypes { get; }
        /// <summary> Pattern of a threat intelligence entity. </summary>
        public string Pattern { get; set; }
        /// <summary> Pattern type of a threat intelligence entity. </summary>
        public string PatternType { get; set; }
        /// <summary> Pattern version of a threat intelligence entity. </summary>
        public string PatternVersion { get; set; }
        /// <summary> Kill chain phases. </summary>
        public IList<ThreatIntelligenceKillChainPhase> KillChainPhases { get; }
        /// <summary> Parsed patterns. </summary>
        public IList<ThreatIntelligenceParsedPattern> ParsedPattern { get; }
        /// <summary> External ID of threat intelligence entity. </summary>
        public string ExternalId { get; set; }
        /// <summary> Created by reference of threat intelligence entity. </summary>
        public string CreatedByRef { get; set; }
        /// <summary> Is threat intelligence entity defanged. </summary>
        public bool? Defanged { get; set; }
        /// <summary> External last updated time in UTC. </summary>
        public string ExternalLastUpdatedTimeUtc { get; set; }
        /// <summary> External References. </summary>
        public IList<ThreatIntelligenceExternalReference> ExternalReferences { get; }
        /// <summary> Granular Markings. </summary>
        public IList<ThreatIntelligenceGranularMarkingModel> GranularMarkings { get; }
        /// <summary> Labels  of threat intelligence entity. </summary>
        public IList<string> Labels { get; }
        /// <summary> Is threat intelligence entity revoked. </summary>
        public bool? Revoked { get; set; }
        /// <summary> Confidence of threat intelligence entity. </summary>
        public int? Confidence { get; set; }
        /// <summary> Threat intelligence entity object marking references. </summary>
        public IList<string> ObjectMarkingRefs { get; }
        /// <summary> Language of threat intelligence entity. </summary>
        public string Language { get; set; }
        /// <summary> Threat types. </summary>
        public IList<string> ThreatTypes { get; }
        /// <summary> Valid from. </summary>
        public string ValidFrom { get; set; }
        /// <summary> Valid until. </summary>
        public string ValidUntil { get; set; }
        /// <summary> Created by. </summary>
        public string Created { get; set; }
        /// <summary> Modified by. </summary>
        public string Modified { get; set; }
        /// <summary> Extensions map. </summary>
        public IDictionary<string, object> Extensions { get; }
    }
}
