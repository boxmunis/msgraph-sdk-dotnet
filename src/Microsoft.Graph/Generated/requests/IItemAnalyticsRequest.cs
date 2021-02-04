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
    /// The interface IItemAnalyticsRequest.
    /// </summary>
    public partial interface IItemAnalyticsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ItemAnalytics using POST.
        /// </summary>
        /// <param name="itemAnalyticsToCreate">The ItemAnalytics to create.</param>
        /// <returns>The created ItemAnalytics.</returns>
        System.Threading.Tasks.Task<ItemAnalytics> CreateAsync(ItemAnalytics itemAnalyticsToCreate);

        /// <summary>
        /// Creates the specified ItemAnalytics using POST.
        /// </summary>
        /// <param name="itemAnalyticsToCreate">The ItemAnalytics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemAnalytics.</returns>
        System.Threading.Tasks.Task<ItemAnalytics> CreateAsync(ItemAnalytics itemAnalyticsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified ItemAnalytics using POST and returns a <see cref="GraphResponse{ItemAnalytics}"/> object.
        /// </summary>
        /// <param name="itemAnalyticsToCreate">The ItemAnalytics to create.</param>
        /// <returns>The <see cref="GraphResponse{ItemAnalytics}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemAnalytics>> CreateResponseAsync(ItemAnalytics itemAnalyticsToCreate);

        /// <summary>
        /// Creates the specified ItemAnalytics using POST and returns a <see cref="GraphResponse{ItemAnalytics}"/> object.
        /// </summary>
        /// <param name="itemAnalyticsToCreate">The ItemAnalytics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemAnalytics}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemAnalytics>> CreateResponseAsync(ItemAnalytics itemAnalyticsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ItemAnalytics.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ItemAnalytics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ItemAnalytics and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified ItemAnalytics and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ItemAnalytics.
        /// </summary>
        /// <returns>The ItemAnalytics.</returns>
        System.Threading.Tasks.Task<ItemAnalytics> GetAsync();

        /// <summary>
        /// Gets the specified ItemAnalytics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemAnalytics.</returns>
        System.Threading.Tasks.Task<ItemAnalytics> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ItemAnalytics using PATCH.
        /// </summary>
        /// <param name="itemAnalyticsToUpdate">The ItemAnalytics to update.</param>
        /// <returns>The updated ItemAnalytics.</returns>
        System.Threading.Tasks.Task<ItemAnalytics> UpdateAsync(ItemAnalytics itemAnalyticsToUpdate);

        /// <summary>
        /// Updates the specified ItemAnalytics using PATCH.
        /// </summary>
        /// <param name="itemAnalyticsToUpdate">The ItemAnalytics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ItemAnalytics.</returns>
        System.Threading.Tasks.Task<ItemAnalytics> UpdateAsync(ItemAnalytics itemAnalyticsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemAnalyticsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemAnalyticsRequest Expand(Expression<Func<ItemAnalytics, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemAnalyticsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IItemAnalyticsRequest Select(Expression<Func<ItemAnalytics, object>> selectExpression);

    }
}
