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
    /// The type Agreement Acceptance.
    /// </summary>
    public partial class AgreementAcceptance : Entity
    {
    
		///<summary>
		/// The AgreementAcceptance constructor
		///</summary>
        public AgreementAcceptance()
        {
            this.ODataType = "microsoft.graph.agreementAcceptance";
        }
	
        /// <summary>
        /// Gets or sets agreement file id.
        /// ID of the agreement file accepted by the user.
        /// </summary>
        [JsonPropertyName("agreementFileId")]
        public string AgreementFileId { get; set; }
    
        /// <summary>
        /// Gets or sets agreement id.
        /// ID of the agreement.
        /// </summary>
        [JsonPropertyName("agreementId")]
        public string AgreementId { get; set; }
    
        /// <summary>
        /// Gets or sets device display name.
        /// The display name of the device used for accepting the agreement.
        /// </summary>
        [JsonPropertyName("deviceDisplayName")]
        public string DeviceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// The unique identifier of the device used for accepting the agreement.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device ostype.
        /// The operating system used for accepting the agreement.
        /// </summary>
        [JsonPropertyName("deviceOSType")]
        public string DeviceOSType { get; set; }
    
        /// <summary>
        /// Gets or sets device osversion.
        /// The operating system version of the device used for accepting the agreement.
        /// </summary>
        [JsonPropertyName("deviceOSVersion")]
        public string DeviceOSVersion { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets recorded date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("recordedDateTime")]
        public DateTimeOffset? RecordedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Possible values are: accepted, declined.
        /// </summary>
        [JsonPropertyName("state")]
        public AgreementAcceptanceState? State { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// Display name of the user when the acceptance was recorded.
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user email.
        /// Email of the user when the acceptance was recorded.
        /// </summary>
        [JsonPropertyName("userEmail")]
        public string UserEmail { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// ID of the user who accepted the agreement.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// UPN of the user when the acceptance was recorded.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

