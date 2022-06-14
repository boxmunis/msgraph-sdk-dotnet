// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ScheduleShiftsCollectionRequestBuilder.
    /// </summary>
    public partial class ScheduleShiftsCollectionRequestBuilder : BaseRequestBuilder, IScheduleShiftsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ScheduleShiftsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ScheduleShiftsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IScheduleShiftsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IScheduleShiftsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ScheduleShiftsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IShiftRequestBuilder"/> for the specified ScheduleShift.
        /// </summary>
        /// <param name="id">The ID for the ScheduleShift.</param>
        /// <returns>The <see cref="IShiftRequestBuilder"/>.</returns>
        public IShiftRequestBuilder this[string id]
        {
            get
            {
                return new ShiftRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}