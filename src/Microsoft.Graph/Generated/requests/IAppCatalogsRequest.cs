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
    /// The interface IAppCatalogsRequest.
    /// </summary>
    public partial interface IAppCatalogsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AppCatalogs using POST.
        /// </summary>
        /// <param name="appCatalogsToCreate">The AppCatalogs to create.</param>
        /// <returns>The created AppCatalogs.</returns>
        System.Threading.Tasks.Task<AppCatalogs> CreateAsync(AppCatalogs appCatalogsToCreate);

        /// <summary>
        /// Creates the specified AppCatalogs using POST.
        /// </summary>
        /// <param name="appCatalogsToCreate">The AppCatalogs to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppCatalogs.</returns>
        System.Threading.Tasks.Task<AppCatalogs> CreateAsync(AppCatalogs appCatalogsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified AppCatalogs using POST and returns a <see cref="GraphResponse{AppCatalogs}"/> object.
        /// </summary>
        /// <param name="appCatalogsToCreate">The AppCatalogs to create.</param>
        /// <returns>The <see cref="GraphResponse{AppCatalogs}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppCatalogs>> CreateResponseAsync(AppCatalogs appCatalogsToCreate);

        /// <summary>
        /// Creates the specified AppCatalogs using POST and returns a <see cref="GraphResponse{AppCatalogs}"/> object.
        /// </summary>
        /// <param name="appCatalogsToCreate">The AppCatalogs to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppCatalogs}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppCatalogs>> CreateResponseAsync(AppCatalogs appCatalogsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AppCatalogs.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AppCatalogs.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AppCatalogs and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified AppCatalogs and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AppCatalogs.
        /// </summary>
        /// <returns>The AppCatalogs.</returns>
        System.Threading.Tasks.Task<AppCatalogs> GetAsync();

        /// <summary>
        /// Gets the specified AppCatalogs.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppCatalogs.</returns>
        System.Threading.Tasks.Task<AppCatalogs> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AppCatalogs using PATCH.
        /// </summary>
        /// <param name="appCatalogsToUpdate">The AppCatalogs to update.</param>
        /// <returns>The updated AppCatalogs.</returns>
        System.Threading.Tasks.Task<AppCatalogs> UpdateAsync(AppCatalogs appCatalogsToUpdate);

        /// <summary>
        /// Updates the specified AppCatalogs using PATCH.
        /// </summary>
        /// <param name="appCatalogsToUpdate">The AppCatalogs to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AppCatalogs.</returns>
        System.Threading.Tasks.Task<AppCatalogs> UpdateAsync(AppCatalogs appCatalogsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppCatalogsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppCatalogsRequest Expand(Expression<Func<AppCatalogs, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAppCatalogsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAppCatalogsRequest Select(Expression<Func<AppCatalogs, object>> selectExpression);

    }
}
