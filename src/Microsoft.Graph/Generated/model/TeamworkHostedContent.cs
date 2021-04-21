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
    /// The type Teamwork Hosted Content.
    /// </summary>
    public partial class TeamworkHostedContent : Entity
    {
    
		///<summary>
		/// The TeamworkHostedContent constructor
		///</summary>
        public TeamworkHostedContent()
        {
            this.ODataType = "microsoft.graph.teamworkHostedContent";
        }
	
        /// <summary>
        /// Gets or sets content bytes.
        /// Write only. Bytes for the hosted content (such as images).
        /// </summary>
        [JsonPropertyName("contentBytes")]
        public byte[] ContentBytes { get; set; }
    
        /// <summary>
        /// Gets or sets content type.
        /// Write only. Content type, such as image/png, image/jpg.
        /// </summary>
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    
    }
}

