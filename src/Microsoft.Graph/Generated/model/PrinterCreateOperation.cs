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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Printer Create Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrinterCreateOperation : PrintOperation
    {
    
		///<summary>
		/// The PrinterCreateOperation constructor
		///</summary>
        public PrinterCreateOperation()
        {
            this.ODataType = "microsoft.graph.printerCreateOperation";
        }
	
        /// <summary>
        /// Gets or sets certificate.
        /// The signed certificate created during the registration process. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificate", Required = Newtonsoft.Json.Required.Default)]
        public string Certificate { get; set; }
    
        /// <summary>
        /// Gets or sets printer.
        /// The created printer entity. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "printer", Required = Newtonsoft.Json.Required.Default)]
        public Printer Printer { get; set; }
    
    }
}

