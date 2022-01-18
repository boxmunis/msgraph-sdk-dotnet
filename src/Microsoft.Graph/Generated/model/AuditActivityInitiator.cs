// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AuditActivityInitiator.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AuditActivityInitiator>))]
    public partial class AuditActivityInitiator
    {

        /// <summary>
        /// Gets or sets app.
        /// If the actor initiating the activity is an app, this property indicates all its identification information including appId, displayName, servicePrincipalId, and servicePrincipalName.
        /// </summary>
        [JsonPropertyName("app")]
        public AppIdentity App { get; set; }
    
        /// <summary>
        /// Gets or sets user.
        /// If the actor initiating the activity is a user, this property indicates their identification information including their id, displayName, and userPrincipalName.
        /// </summary>
        [JsonPropertyName("user")]
        public UserIdentity User { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
