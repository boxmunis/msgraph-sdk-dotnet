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
    /// The type Workbook Named Item.
    /// </summary>
    public partial class WorkbookNamedItem : Entity
    {
    
		///<summary>
		/// The WorkbookNamedItem constructor
		///</summary>
        public WorkbookNamedItem()
        {
            this.ODataType = "microsoft.graph.workbookNamedItem";
        }
	
        /// <summary>
        /// Gets or sets comment.
        /// Represents the comment associated with this name.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of the object. Read-only.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets scope.
        /// Indicates whether the name is scoped to the workbook or to a specific worksheet. Read-only.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Indicates what type of reference is associated with the name. Possible values are: String, Integer, Double, Boolean, Range. Read-only.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// Represents the formula that the name is defined to refer to. E.g. =Sheet14!$B$2:$H$12, =4.75, etc. Read-only.
        /// </summary>
        [JsonPropertyName("value")]
        public System.Text.Json.JsonDocument Value { get; set; }
    
        /// <summary>
        /// Gets or sets visible.
        /// Specifies whether the object is visible or not.
        /// </summary>
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }
    
        /// <summary>
        /// Gets or sets worksheet.
        /// Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.
        /// </summary>
        [JsonPropertyName("worksheet")]
        public WorkbookWorksheet Worksheet { get; set; }
    
    }
}

