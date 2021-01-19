// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ScheduleRequestBuilder.
    /// </summary>
    public partial class ScheduleRequestBuilder : EntityRequestBuilder, IScheduleRequestBuilder
    {

        /// <summary>
        /// Constructs a new ScheduleRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ScheduleRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IScheduleRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IScheduleRequest Request(IEnumerable<Option> options)
        {
            return new ScheduleRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for OfferShiftRequests.
        /// </summary>
        /// <returns>The <see cref="IScheduleOfferShiftRequestsCollectionRequestBuilder"/>.</returns>
        public IScheduleOfferShiftRequestsCollectionRequestBuilder OfferShiftRequests
        {
            get
            {
                return new ScheduleOfferShiftRequestsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("offerShiftRequests"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for OpenShiftChangeRequests.
        /// </summary>
        /// <returns>The <see cref="IScheduleOpenShiftChangeRequestsCollectionRequestBuilder"/>.</returns>
        public IScheduleOpenShiftChangeRequestsCollectionRequestBuilder OpenShiftChangeRequests
        {
            get
            {
                return new ScheduleOpenShiftChangeRequestsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("openShiftChangeRequests"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for OpenShifts.
        /// </summary>
        /// <returns>The <see cref="IScheduleOpenShiftsCollectionRequestBuilder"/>.</returns>
        public IScheduleOpenShiftsCollectionRequestBuilder OpenShifts
        {
            get
            {
                return new ScheduleOpenShiftsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("openShifts"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SchedulingGroups.
        /// </summary>
        /// <returns>The <see cref="IScheduleSchedulingGroupsCollectionRequestBuilder"/>.</returns>
        public IScheduleSchedulingGroupsCollectionRequestBuilder SchedulingGroups
        {
            get
            {
                return new ScheduleSchedulingGroupsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("schedulingGroups"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Shifts.
        /// </summary>
        /// <returns>The <see cref="IScheduleShiftsCollectionRequestBuilder"/>.</returns>
        public IScheduleShiftsCollectionRequestBuilder Shifts
        {
            get
            {
                return new ScheduleShiftsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("shifts"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SwapShiftsChangeRequests.
        /// </summary>
        /// <returns>The <see cref="IScheduleSwapShiftsChangeRequestsCollectionRequestBuilder"/>.</returns>
        public IScheduleSwapShiftsChangeRequestsCollectionRequestBuilder SwapShiftsChangeRequests
        {
            get
            {
                return new ScheduleSwapShiftsChangeRequestsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("swapShiftsChangeRequests"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TimeOffReasons.
        /// </summary>
        /// <returns>The <see cref="IScheduleTimeOffReasonsCollectionRequestBuilder"/>.</returns>
        public IScheduleTimeOffReasonsCollectionRequestBuilder TimeOffReasons
        {
            get
            {
                return new ScheduleTimeOffReasonsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("timeOffReasons"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TimeOffRequests.
        /// </summary>
        /// <returns>The <see cref="IScheduleTimeOffRequestsCollectionRequestBuilder"/>.</returns>
        public IScheduleTimeOffRequestsCollectionRequestBuilder TimeOffRequests
        {
            get
            {
                return new ScheduleTimeOffRequestsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("timeOffRequests"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TimesOff.
        /// </summary>
        /// <returns>The <see cref="IScheduleTimesOffCollectionRequestBuilder"/>.</returns>
        public IScheduleTimesOffCollectionRequestBuilder TimesOff
        {
            get
            {
                return new ScheduleTimesOffCollectionRequestBuilder(this.AppendSegmentToRequestUrl("timesOff"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ScheduleShare.
        /// </summary>
        /// <returns>The <see cref="IScheduleShareRequestBuilder"/>.</returns>
        public IScheduleShareRequestBuilder Share(
            bool? notifyTeam = null,
            DateTimeOffset? startDateTime = null,
            DateTimeOffset? endDateTime = null)
        {
            return new ScheduleShareRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.share"),
                this.Client,
                notifyTeam,
                startDateTime,
                endDateTime);
        }
    
    }
}
