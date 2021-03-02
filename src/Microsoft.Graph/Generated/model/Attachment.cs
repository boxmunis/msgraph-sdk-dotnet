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
    /// The type Attachment.
    /// </summary>
    public partial class Attachment : Entity
    {
    
		///<summary>
		/// The internal Attachment constructor
		///</summary>
        protected internal Attachment()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets content type.
        /// The MIME type.
        /// </summary>
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets is inline.
        /// true if the attachment is an inline attachment; otherwise, false.
        /// </summary>
        [JsonPropertyName("isInline")]
        public bool? IsInline { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The display name of the attachment. This does not need to be the actual file name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// The length of the attachment in bytes.
        /// </summary>
        [JsonPropertyName("size")]
        public Int32? Size { get; set; }
    
    }
}

