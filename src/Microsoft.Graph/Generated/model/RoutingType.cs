// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum RoutingType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RoutingType
    {
    
        /// <summary>
        /// Forwarded
        /// </summary>
        Forwarded = 0,
	
        /// <summary>
        /// Lookup
        /// </summary>
        Lookup = 1,
	
        /// <summary>
        /// Self Fork
        /// </summary>
        SelfFork = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}
