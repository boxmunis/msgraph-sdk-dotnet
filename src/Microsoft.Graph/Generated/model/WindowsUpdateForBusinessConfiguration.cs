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
    /// The type Windows Update For Business Configuration.
    /// </summary>
    public partial class WindowsUpdateForBusinessConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The WindowsUpdateForBusinessConfiguration constructor
		///</summary>
        public WindowsUpdateForBusinessConfiguration()
        {
            this.ODataType = "microsoft.graph.windowsUpdateForBusinessConfiguration";
        }
	
        /// <summary>
        /// Gets or sets automatic update mode.
        /// Automatic update mode. Possible values are: userDefined, notifyDownload, autoInstallAtMaintenanceTime, autoInstallAndRebootAtMaintenanceTime, autoInstallAndRebootAtScheduledTime, autoInstallAndRebootWithoutEndUserControl, windowsDefault.
        /// </summary>
        [JsonPropertyName("automaticUpdateMode")]
        public AutomaticUpdateMode? AutomaticUpdateMode { get; set; }
    
        /// <summary>
        /// Gets or sets business ready updates only.
        /// Determines which branch devices will receive their updates from. Possible values are: userDefined, all, businessReadyOnly, windowsInsiderBuildFast, windowsInsiderBuildSlow, windowsInsiderBuildRelease.
        /// </summary>
        [JsonPropertyName("businessReadyUpdatesOnly")]
        public WindowsUpdateType? BusinessReadyUpdatesOnly { get; set; }
    
        /// <summary>
        /// Gets or sets delivery optimization mode.
        /// Delivery Optimization Mode. Possible values are: userDefined, httpOnly, httpWithPeeringNat, httpWithPeeringPrivateGroup, httpWithInternetPeering, simpleDownload, bypassMode.
        /// </summary>
        [JsonPropertyName("deliveryOptimizationMode")]
        public WindowsDeliveryOptimizationMode? DeliveryOptimizationMode { get; set; }
    
        /// <summary>
        /// Gets or sets drivers excluded.
        /// Exclude Windows update Drivers
        /// </summary>
        [JsonPropertyName("driversExcluded")]
        public bool? DriversExcluded { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates deferral period in days.
        /// Defer Feature Updates by these many days
        /// </summary>
        [JsonPropertyName("featureUpdatesDeferralPeriodInDays")]
        public Int32? FeatureUpdatesDeferralPeriodInDays { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates paused.
        /// Pause Feature Updates
        /// </summary>
        [JsonPropertyName("featureUpdatesPaused")]
        public bool? FeatureUpdatesPaused { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates pause expiry date time.
        /// Feature Updates Pause Expiry datetime
        /// </summary>
        [JsonPropertyName("featureUpdatesPauseExpiryDateTime")]
        public DateTimeOffset? FeatureUpdatesPauseExpiryDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets installation schedule.
        /// Installation schedule
        /// </summary>
        [JsonPropertyName("installationSchedule")]
        public WindowsUpdateInstallScheduleType InstallationSchedule { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft update service allowed.
        /// Allow Microsoft Update Service
        /// </summary>
        [JsonPropertyName("microsoftUpdateServiceAllowed")]
        public bool? MicrosoftUpdateServiceAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets prerelease features.
        /// The pre-release features. Possible values are: userDefined, settingsOnly, settingsAndExperimentations, notAllowed.
        /// </summary>
        [JsonPropertyName("prereleaseFeatures")]
        public PrereleaseFeatures? PrereleaseFeatures { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates deferral period in days.
        /// Defer Quality Updates by these many days
        /// </summary>
        [JsonPropertyName("qualityUpdatesDeferralPeriodInDays")]
        public Int32? QualityUpdatesDeferralPeriodInDays { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates paused.
        /// Pause Quality Updates
        /// </summary>
        [JsonPropertyName("qualityUpdatesPaused")]
        public bool? QualityUpdatesPaused { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates pause expiry date time.
        /// Quality Updates Pause Expiry datetime
        /// </summary>
        [JsonPropertyName("qualityUpdatesPauseExpiryDateTime")]
        public DateTimeOffset? QualityUpdatesPauseExpiryDateTime { get; set; }
    
    }
}

