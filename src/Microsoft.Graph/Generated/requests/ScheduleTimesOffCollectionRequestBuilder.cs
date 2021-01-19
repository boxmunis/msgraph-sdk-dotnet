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
    /// The type ScheduleTimesOffCollectionRequestBuilder.
    /// </summary>
    public partial class ScheduleTimesOffCollectionRequestBuilder : BaseRequestBuilder, IScheduleTimesOffCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ScheduleTimesOffCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ScheduleTimesOffCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IScheduleTimesOffCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IScheduleTimesOffCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ScheduleTimesOffCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITimeOffRequestBuilder"/> for the specified ScheduleTimeOff.
        /// </summary>
        /// <param name="id">The ID for the ScheduleTimeOff.</param>
        /// <returns>The <see cref="ITimeOffRequestBuilder"/>.</returns>
        public ITimeOffRequestBuilder this[string id]
        {
            get
            {
                return new TimeOffRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
