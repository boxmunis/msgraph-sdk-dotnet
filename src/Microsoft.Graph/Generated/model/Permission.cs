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
    /// The type Permission.
    /// </summary>
    public partial class Permission : Entity
    {
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// A format of yyyy-MM-ddTHH:mm:ssZ of DateTimeOffset indicates the expiration time of the permission. DateTime.MinValue indicates there is no expiration set for this permission. Optional.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets granted to.
        /// </summary>
        [Obsolete("The grantedTo property is deprecated. Please refer to grantedToV2")]
        [JsonPropertyName("grantedTo")]
        public IdentitySet GrantedTo { get; set; }
    
        /// <summary>
        /// Gets or sets granted to identities.
        /// </summary>
        [Obsolete("The grantedToIdentities property is deprecated. Please refer to grantedToIdentitiesV2")]
        [JsonPropertyName("grantedToIdentities")]
        public IEnumerable<IdentitySet> GrantedToIdentities { get; set; }
    
        /// <summary>
        /// Gets or sets granted to identities v2.
        /// For link type permissions, the details of the users to whom permission was granted. Read-only.
        /// </summary>
        [JsonPropertyName("grantedToIdentitiesV2")]
        public IEnumerable<SharePointIdentitySet> GrantedToIdentitiesV2 { get; set; }
    
        /// <summary>
        /// Gets or sets granted to v2.
        /// For user type permissions, the details of the users and applications for this permission. Read-only.
        /// </summary>
        [JsonPropertyName("grantedToV2")]
        public SharePointIdentitySet GrantedToV2 { get; set; }
    
        /// <summary>
        /// Gets or sets has password.
        /// Indicates whether the password is set for this permission. This property only appears in the response. Optional. Read-only. For OneDrive Personal only.
        /// </summary>
        [JsonPropertyName("hasPassword")]
        public bool? HasPassword { get; set; }
    
        /// <summary>
        /// Gets or sets inherited from.
        /// Provides a reference to the ancestor of the current permission, if it is inherited from an ancestor. Read-only.
        /// </summary>
        [JsonPropertyName("inheritedFrom")]
        public ItemReference InheritedFrom { get; set; }
    
        /// <summary>
        /// Gets or sets invitation.
        /// Details of any associated sharing invitation for this permission. Read-only.
        /// </summary>
        [JsonPropertyName("invitation")]
        public SharingInvitation Invitation { get; set; }
    
        /// <summary>
        /// Gets or sets link.
        /// Provides the link details of the current permission, if it is a link type permissions. Read-only.
        /// </summary>
        [JsonPropertyName("link")]
        public SharingLink Link { get; set; }
    
        /// <summary>
        /// Gets or sets roles.
        /// The type of permission, for example, read. See below for the full list of roles. Read-only.
        /// </summary>
        [JsonPropertyName("roles")]
        public IEnumerable<string> Roles { get; set; }
    
        /// <summary>
        /// Gets or sets share id.
        /// A unique token that can be used to access this shared item via the [shares API][]. Read-only.
        /// </summary>
        [JsonPropertyName("shareId")]
        public string ShareId { get; set; }
    
    }
}

