// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Identity Protection Root.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IdentityProtectionRoot>))]
    public partial class IdentityProtectionRoot
    {
    
        /// <summary>
        /// Gets or sets risk detections.
        /// </summary>
        [JsonPropertyName("riskDetections")]
        public IIdentityProtectionRootRiskDetectionsCollectionPage RiskDetections { get; set; }

        /// <summary>
        /// Gets or sets riskDetectionsNextLink.
        /// </summary>
        [JsonPropertyName("riskDetections@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RiskDetectionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets risky users.
        /// </summary>
        [JsonPropertyName("riskyUsers")]
        public IIdentityProtectionRootRiskyUsersCollectionPage RiskyUsers { get; set; }

        /// <summary>
        /// Gets or sets riskyUsersNextLink.
        /// </summary>
        [JsonPropertyName("riskyUsers@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RiskyUsersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

