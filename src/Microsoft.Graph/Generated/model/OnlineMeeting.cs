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
    /// The type Online Meeting.
    /// </summary>
    public partial class OnlineMeeting : Entity
    {
    
		///<summary>
		/// The OnlineMeeting constructor
		///</summary>
        public OnlineMeeting()
        {
            this.ODataType = "microsoft.graph.onlineMeeting";
        }
	
        /// <summary>
        /// Gets or sets allowed presenters.
        /// Specifies who can be a presenter in a meeting. Possible values are everyone, organization, roleIsPresenter, organizer, and unknownFutureValue.
        /// </summary>
        [JsonPropertyName("allowedPresenters")]
        public OnlineMeetingPresenters? AllowedPresenters { get; set; }
    
        /// <summary>
        /// Gets or sets audio conferencing.
        /// The phone access (dial-in) information for an online meeting. Read-only.
        /// </summary>
        [JsonPropertyName("audioConferencing")]
        public AudioConferencing AudioConferencing { get; set; }
    
        /// <summary>
        /// Gets or sets chat info.
        /// The chat information associated with this online meeting.
        /// </summary>
        [JsonPropertyName("chatInfo")]
        public ChatInfo ChatInfo { get; set; }
    
        /// <summary>
        /// Gets or sets creation date time.
        /// The meeting creation time in UTC. Read-only.
        /// </summary>
        [JsonPropertyName("creationDateTime")]
        public DateTimeOffset? CreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets end date time.
        /// The meeting end time in UTC.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// The external ID. A custom ID. Optional.
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets is entry exit announced.
        /// Whether or not to announce when callers join or leave.
        /// </summary>
        [JsonPropertyName("isEntryExitAnnounced")]
        public bool? IsEntryExitAnnounced { get; set; }
    
        /// <summary>
        /// Gets or sets join information.
        /// The join information in the language and locale variant specified in 'Accept-Language' request HTTP header. Read-only
        /// </summary>
        [JsonPropertyName("joinInformation")]
        public ItemBody JoinInformation { get; set; }
    
        /// <summary>
        /// Gets or sets join web url.
        /// The join URL of the online meeting. Read-only.
        /// </summary>
        [JsonPropertyName("joinWebUrl")]
        public string JoinWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets lobby bypass settings.
        /// Specifies which participants can bypass the meeting lobby.
        /// </summary>
        [JsonPropertyName("lobbyBypassSettings")]
        public LobbyBypassSettings LobbyBypassSettings { get; set; }
    
        /// <summary>
        /// Gets or sets participants.
        /// The participants associated with the online meeting.  This includes the organizer and the attendees.
        /// </summary>
        [JsonPropertyName("participants")]
        public MeetingParticipants Participants { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// The meeting start time in UTC.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The subject of the online meeting.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets video teleconference id.
        /// The video teleconferencing ID. Read-only.
        /// </summary>
        [JsonPropertyName("videoTeleconferenceId")]
        public string VideoTeleconferenceId { get; set; }
    
    }
}

