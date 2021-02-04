// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWorkbookChartFillRequest.
    /// </summary>
    public partial interface IWorkbookChartFillRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartFill using POST.
        /// </summary>
        /// <param name="workbookChartFillToCreate">The WorkbookChartFill to create.</param>
        /// <returns>The created WorkbookChartFill.</returns>
        System.Threading.Tasks.Task<WorkbookChartFill> CreateAsync(WorkbookChartFill workbookChartFillToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartFill using POST.
        /// </summary>
        /// <param name="workbookChartFillToCreate">The WorkbookChartFill to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartFill.</returns>
        System.Threading.Tasks.Task<WorkbookChartFill> CreateAsync(WorkbookChartFill workbookChartFillToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WorkbookChartFill using POST and returns a <see cref="GraphResponse{WorkbookChartFill}"/> object.
        /// </summary>
        /// <param name="workbookChartFillToCreate">The WorkbookChartFill to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartFill}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartFill>> CreateResponseAsync(WorkbookChartFill workbookChartFillToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartFill using POST and returns a <see cref="GraphResponse{WorkbookChartFill}"/> object.
        /// </summary>
        /// <param name="workbookChartFillToCreate">The WorkbookChartFill to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartFill}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartFill>> CreateResponseAsync(WorkbookChartFill workbookChartFillToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartFill.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartFill.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartFill and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartFill and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartFill.
        /// </summary>
        /// <returns>The WorkbookChartFill.</returns>
        System.Threading.Tasks.Task<WorkbookChartFill> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartFill.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartFill.</returns>
        System.Threading.Tasks.Task<WorkbookChartFill> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartFill using PATCH.
        /// </summary>
        /// <param name="workbookChartFillToUpdate">The WorkbookChartFill to update.</param>
        /// <returns>The updated WorkbookChartFill.</returns>
        System.Threading.Tasks.Task<WorkbookChartFill> UpdateAsync(WorkbookChartFill workbookChartFillToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartFill using PATCH.
        /// </summary>
        /// <param name="workbookChartFillToUpdate">The WorkbookChartFill to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartFill.</returns>
        System.Threading.Tasks.Task<WorkbookChartFill> UpdateAsync(WorkbookChartFill workbookChartFillToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartFillRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartFillRequest Expand(Expression<Func<WorkbookChartFill, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartFillRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartFillRequest Select(Expression<Func<WorkbookChartFill, object>> selectExpression);

    }
}
