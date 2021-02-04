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
    /// The interface IWorkbookChartFontRequest.
    /// </summary>
    public partial interface IWorkbookChartFontRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartFont using POST.
        /// </summary>
        /// <param name="workbookChartFontToCreate">The WorkbookChartFont to create.</param>
        /// <returns>The created WorkbookChartFont.</returns>
        System.Threading.Tasks.Task<WorkbookChartFont> CreateAsync(WorkbookChartFont workbookChartFontToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartFont using POST.
        /// </summary>
        /// <param name="workbookChartFontToCreate">The WorkbookChartFont to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartFont.</returns>
        System.Threading.Tasks.Task<WorkbookChartFont> CreateAsync(WorkbookChartFont workbookChartFontToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WorkbookChartFont using POST and returns a <see cref="GraphResponse{WorkbookChartFont}"/> object.
        /// </summary>
        /// <param name="workbookChartFontToCreate">The WorkbookChartFont to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartFont}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartFont>> CreateResponseAsync(WorkbookChartFont workbookChartFontToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartFont using POST and returns a <see cref="GraphResponse{WorkbookChartFont}"/> object.
        /// </summary>
        /// <param name="workbookChartFontToCreate">The WorkbookChartFont to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartFont}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartFont>> CreateResponseAsync(WorkbookChartFont workbookChartFontToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartFont.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartFont.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartFont and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartFont and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartFont.
        /// </summary>
        /// <returns>The WorkbookChartFont.</returns>
        System.Threading.Tasks.Task<WorkbookChartFont> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartFont.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartFont.</returns>
        System.Threading.Tasks.Task<WorkbookChartFont> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartFont using PATCH.
        /// </summary>
        /// <param name="workbookChartFontToUpdate">The WorkbookChartFont to update.</param>
        /// <returns>The updated WorkbookChartFont.</returns>
        System.Threading.Tasks.Task<WorkbookChartFont> UpdateAsync(WorkbookChartFont workbookChartFontToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartFont using PATCH.
        /// </summary>
        /// <param name="workbookChartFontToUpdate">The WorkbookChartFont to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartFont.</returns>
        System.Threading.Tasks.Task<WorkbookChartFont> UpdateAsync(WorkbookChartFont workbookChartFontToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartFontRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartFontRequest Expand(Expression<Func<WorkbookChartFont, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartFontRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartFontRequest Select(Expression<Func<WorkbookChartFont, object>> selectExpression);

    }
}
