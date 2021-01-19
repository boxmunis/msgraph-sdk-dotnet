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
    /// The enum SecurityNetworkProtocol.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SecurityNetworkProtocol
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = -1,
	
        /// <summary>
        /// Ip
        /// </summary>
        Ip = 0,
	
        /// <summary>
        /// Icmp
        /// </summary>
        Icmp = 1,
	
        /// <summary>
        /// Igmp
        /// </summary>
        Igmp = 2,
	
        /// <summary>
        /// Ggp
        /// </summary>
        Ggp = 3,
	
        /// <summary>
        /// Ipv4
        /// </summary>
        Ipv4 = 4,
	
        /// <summary>
        /// Tcp
        /// </summary>
        Tcp = 6,
	
        /// <summary>
        /// Pup
        /// </summary>
        Pup = 12,
	
        /// <summary>
        /// Udp
        /// </summary>
        Udp = 17,
	
        /// <summary>
        /// Idp
        /// </summary>
        Idp = 22,
	
        /// <summary>
        /// Ipv6
        /// </summary>
        Ipv6 = 41,
	
        /// <summary>
        /// Ipv6Routing Header
        /// </summary>
        Ipv6RoutingHeader = 43,
	
        /// <summary>
        /// Ipv6Fragment Header
        /// </summary>
        Ipv6FragmentHeader = 44,
	
        /// <summary>
        /// Ip Sec Encapsulating Security Payload
        /// </summary>
        IpSecEncapsulatingSecurityPayload = 50,
	
        /// <summary>
        /// Ip Sec Authentication Header
        /// </summary>
        IpSecAuthenticationHeader = 51,
	
        /// <summary>
        /// Icmp V6
        /// </summary>
        IcmpV6 = 58,
	
        /// <summary>
        /// Ipv6No Next Header
        /// </summary>
        Ipv6NoNextHeader = 59,
	
        /// <summary>
        /// Ipv6Destination Options
        /// </summary>
        Ipv6DestinationOptions = 60,
	
        /// <summary>
        /// Nd
        /// </summary>
        Nd = 77,
	
        /// <summary>
        /// Raw
        /// </summary>
        Raw = 255,
	
        /// <summary>
        /// Ipx
        /// </summary>
        Ipx = 1000,
	
        /// <summary>
        /// Spx
        /// </summary>
        Spx = 1256,
	
        /// <summary>
        /// Spx II
        /// </summary>
        SpxII = 1257,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 32767,
	
    }
}
