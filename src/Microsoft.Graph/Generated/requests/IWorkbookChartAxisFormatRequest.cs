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
    /// The interface IWorkbookChartAxisFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartAxisFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartAxisFormat using POST.
        /// </summary>
        /// <param name="workbookChartAxisFormatToCreate">The WorkbookChartAxisFormat to create.</param>
        /// <returns>The created WorkbookChartAxisFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisFormat> CreateAsync(WorkbookChartAxisFormat workbookChartAxisFormatToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartAxisFormat using POST.
        /// </summary>
        /// <param name="workbookChartAxisFormatToCreate">The WorkbookChartAxisFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartAxisFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisFormat> CreateAsync(WorkbookChartAxisFormat workbookChartAxisFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WorkbookChartAxisFormat using POST and returns a <see cref="GraphResponse{WorkbookChartAxisFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisFormatToCreate">The WorkbookChartAxisFormat to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxisFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxisFormat>> CreateResponseAsync(WorkbookChartAxisFormat workbookChartAxisFormatToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartAxisFormat using POST and returns a <see cref="GraphResponse{WorkbookChartAxisFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisFormatToCreate">The WorkbookChartAxisFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxisFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxisFormat>> CreateResponseAsync(WorkbookChartAxisFormat workbookChartAxisFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartAxisFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartAxisFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartAxisFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartAxisFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartAxisFormat.
        /// </summary>
        /// <returns>The WorkbookChartAxisFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisFormat> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartAxisFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartAxisFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartAxisFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartAxisFormatToUpdate">The WorkbookChartAxisFormat to update.</param>
        /// <returns>The updated WorkbookChartAxisFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisFormat> UpdateAsync(WorkbookChartAxisFormat workbookChartAxisFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartAxisFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartAxisFormatToUpdate">The WorkbookChartAxisFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartAxisFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisFormat> UpdateAsync(WorkbookChartAxisFormat workbookChartAxisFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisFormatRequest Expand(Expression<Func<WorkbookChartAxisFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisFormatRequest Select(Expression<Func<WorkbookChartAxisFormat, object>> selectExpression);

    }
}
