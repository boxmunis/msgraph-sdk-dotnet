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
    /// The interface IThumbnailSetRequest.
    /// </summary>
    public partial interface IThumbnailSetRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ThumbnailSet using POST.
        /// </summary>
        /// <param name="thumbnailSetToCreate">The ThumbnailSet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ThumbnailSet.</returns>
        System.Threading.Tasks.Task<ThumbnailSet> CreateAsync(ThumbnailSet thumbnailSetToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ThumbnailSet using POST and returns a <see cref="GraphResponse{ThumbnailSet}"/> object.
        /// </summary>
        /// <param name="thumbnailSetToCreate">The ThumbnailSet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ThumbnailSet}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ThumbnailSet>> CreateResponseAsync(ThumbnailSet thumbnailSetToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ThumbnailSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ThumbnailSet and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ThumbnailSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ThumbnailSet.</returns>
        System.Threading.Tasks.Task<ThumbnailSet> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ThumbnailSet and returns a <see cref="GraphResponse{ThumbnailSet}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ThumbnailSet}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ThumbnailSet>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ThumbnailSet using PATCH.
        /// </summary>
        /// <param name="thumbnailSetToUpdate">The ThumbnailSet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ThumbnailSet.</returns>
        System.Threading.Tasks.Task<ThumbnailSet> UpdateAsync(ThumbnailSet thumbnailSetToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ThumbnailSet using PATCH and returns a <see cref="GraphResponse{ThumbnailSet}"/> object.
        /// </summary>
        /// <param name="thumbnailSetToUpdate">The ThumbnailSet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ThumbnailSet}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ThumbnailSet>> UpdateResponseAsync(ThumbnailSet thumbnailSetToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IThumbnailSetRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IThumbnailSetRequest Expand(Expression<Func<ThumbnailSet, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IThumbnailSetRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IThumbnailSetRequest Select(Expression<Func<ThumbnailSet, object>> selectExpression);

    }
}
