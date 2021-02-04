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
    /// The interface IWorkbookChartTitleRequest.
    /// </summary>
    public partial interface IWorkbookChartTitleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartTitle using POST.
        /// </summary>
        /// <param name="workbookChartTitleToCreate">The WorkbookChartTitle to create.</param>
        /// <returns>The created WorkbookChartTitle.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitle> CreateAsync(WorkbookChartTitle workbookChartTitleToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartTitle using POST.
        /// </summary>
        /// <param name="workbookChartTitleToCreate">The WorkbookChartTitle to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartTitle.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitle> CreateAsync(WorkbookChartTitle workbookChartTitleToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WorkbookChartTitle using POST and returns a <see cref="GraphResponse{WorkbookChartTitle}"/> object.
        /// </summary>
        /// <param name="workbookChartTitleToCreate">The WorkbookChartTitle to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartTitle}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartTitle>> CreateResponseAsync(WorkbookChartTitle workbookChartTitleToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartTitle using POST and returns a <see cref="GraphResponse{WorkbookChartTitle}"/> object.
        /// </summary>
        /// <param name="workbookChartTitleToCreate">The WorkbookChartTitle to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartTitle}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartTitle>> CreateResponseAsync(WorkbookChartTitle workbookChartTitleToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartTitle.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartTitle.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartTitle and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartTitle and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartTitle.
        /// </summary>
        /// <returns>The WorkbookChartTitle.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitle> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartTitle.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartTitle.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitle> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartTitle using PATCH.
        /// </summary>
        /// <param name="workbookChartTitleToUpdate">The WorkbookChartTitle to update.</param>
        /// <returns>The updated WorkbookChartTitle.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitle> UpdateAsync(WorkbookChartTitle workbookChartTitleToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartTitle using PATCH.
        /// </summary>
        /// <param name="workbookChartTitleToUpdate">The WorkbookChartTitle to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartTitle.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitle> UpdateAsync(WorkbookChartTitle workbookChartTitleToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartTitleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartTitleRequest Expand(Expression<Func<WorkbookChartTitle, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartTitleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartTitleRequest Select(Expression<Func<WorkbookChartTitle, object>> selectExpression);

    }
}
