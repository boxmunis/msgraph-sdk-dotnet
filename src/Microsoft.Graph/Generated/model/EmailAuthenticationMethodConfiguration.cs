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
    /// The type Email Authentication Method Configuration.
    /// </summary>
    public partial class EmailAuthenticationMethodConfiguration : AuthenticationMethodConfiguration
    {
    
		///<summary>
		/// The EmailAuthenticationMethodConfiguration constructor
		///</summary>
        public EmailAuthenticationMethodConfiguration()
        {
            this.ODataType = "microsoft.graph.emailAuthenticationMethodConfiguration";
        }
	
        /// <summary>
        /// Gets or sets allow external id to use email otp.
        /// Determines whether email OTP is usable by external users for authentication. Possible values are: default, enabled, disabled, unknownFutureValue. Tenants in the default state who did not use public preview will automatically have email OTP enabled beginning in March 2021.
        /// </summary>
        [JsonPropertyName("allowExternalIdToUseEmailOtp")]
        public ExternalEmailOtpState? AllowExternalIdToUseEmailOtp { get; set; }
    
        /// <summary>
        /// Gets or sets include targets.
        /// A collection of users or groups who are enabled to use the authentication method.
        /// </summary>
        [JsonPropertyName("includeTargets")]
        public IEmailAuthenticationMethodConfigurationIncludeTargetsCollectionPage IncludeTargets { get; set; }
    
    }
}

