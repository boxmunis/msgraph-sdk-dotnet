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
    /// The interface IOfficeGraphInsightsRequest.
    /// </summary>
    public partial interface IOfficeGraphInsightsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OfficeGraphInsights using POST.
        /// </summary>
        /// <param name="officeGraphInsightsToCreate">The OfficeGraphInsights to create.</param>
        /// <returns>The created OfficeGraphInsights.</returns>
        System.Threading.Tasks.Task<OfficeGraphInsights> CreateAsync(OfficeGraphInsights officeGraphInsightsToCreate);

        /// <summary>
        /// Creates the specified OfficeGraphInsights using POST.
        /// </summary>
        /// <param name="officeGraphInsightsToCreate">The OfficeGraphInsights to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OfficeGraphInsights.</returns>
        System.Threading.Tasks.Task<OfficeGraphInsights> CreateAsync(OfficeGraphInsights officeGraphInsightsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified OfficeGraphInsights using POST and returns a <see cref="GraphResponse{OfficeGraphInsights}"/> object.
        /// </summary>
        /// <param name="officeGraphInsightsToCreate">The OfficeGraphInsights to create.</param>
        /// <returns>The <see cref="GraphResponse{OfficeGraphInsights}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OfficeGraphInsights>> CreateResponseAsync(OfficeGraphInsights officeGraphInsightsToCreate);

        /// <summary>
        /// Creates the specified OfficeGraphInsights using POST and returns a <see cref="GraphResponse{OfficeGraphInsights}"/> object.
        /// </summary>
        /// <param name="officeGraphInsightsToCreate">The OfficeGraphInsights to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OfficeGraphInsights}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OfficeGraphInsights>> CreateResponseAsync(OfficeGraphInsights officeGraphInsightsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OfficeGraphInsights.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OfficeGraphInsights.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OfficeGraphInsights and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified OfficeGraphInsights and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OfficeGraphInsights.
        /// </summary>
        /// <returns>The OfficeGraphInsights.</returns>
        System.Threading.Tasks.Task<OfficeGraphInsights> GetAsync();

        /// <summary>
        /// Gets the specified OfficeGraphInsights.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OfficeGraphInsights.</returns>
        System.Threading.Tasks.Task<OfficeGraphInsights> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OfficeGraphInsights using PATCH.
        /// </summary>
        /// <param name="officeGraphInsightsToUpdate">The OfficeGraphInsights to update.</param>
        /// <returns>The updated OfficeGraphInsights.</returns>
        System.Threading.Tasks.Task<OfficeGraphInsights> UpdateAsync(OfficeGraphInsights officeGraphInsightsToUpdate);

        /// <summary>
        /// Updates the specified OfficeGraphInsights using PATCH.
        /// </summary>
        /// <param name="officeGraphInsightsToUpdate">The OfficeGraphInsights to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OfficeGraphInsights.</returns>
        System.Threading.Tasks.Task<OfficeGraphInsights> UpdateAsync(OfficeGraphInsights officeGraphInsightsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeGraphInsightsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeGraphInsightsRequest Expand(Expression<Func<OfficeGraphInsights, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeGraphInsightsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeGraphInsightsRequest Select(Expression<Func<OfficeGraphInsights, object>> selectExpression);

    }
}
