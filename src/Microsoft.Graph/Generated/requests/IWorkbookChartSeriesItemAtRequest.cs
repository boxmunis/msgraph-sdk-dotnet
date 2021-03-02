// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWorkbookChartSeriesItemAtRequest.
    /// </summary>
    public partial interface IWorkbookChartSeriesItemAtRequest : IBaseRequest
    {

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> GetAsync(
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeries>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="workbookchartseries">The WorkbookChartSeries object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> PatchAsync(WorkbookChartSeries workbookchartseries,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Issues the PATCH request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="workbookchartseries">The WorkbookChartSeries object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeries>> PatchResponseAsync(WorkbookChartSeries workbookchartseries, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="workbookchartseries">The WorkbookChartSeries object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> PutAsync(WorkbookChartSeries workbookchartseries,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Issues the PUT request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="workbookchartseries">The WorkbookChartSeries object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeries>> PutResponseAsync(WorkbookChartSeries workbookchartseries, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesItemAtRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesItemAtRequest Select(string value);
    }
}
