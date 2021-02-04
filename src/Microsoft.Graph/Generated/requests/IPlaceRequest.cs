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
    /// The interface IPlaceRequest.
    /// </summary>
    public partial interface IPlaceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Place using POST.
        /// </summary>
        /// <param name="placeToCreate">The Place to create.</param>
        /// <returns>The created Place.</returns>
        System.Threading.Tasks.Task<Place> CreateAsync(Place placeToCreate);

        /// <summary>
        /// Creates the specified Place using POST.
        /// </summary>
        /// <param name="placeToCreate">The Place to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Place.</returns>
        System.Threading.Tasks.Task<Place> CreateAsync(Place placeToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Place using POST and returns a <see cref="GraphResponse{Place}"/> object.
        /// </summary>
        /// <param name="placeToCreate">The Place to create.</param>
        /// <returns>The <see cref="GraphResponse{Place}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Place>> CreateResponseAsync(Place placeToCreate);

        /// <summary>
        /// Creates the specified Place using POST and returns a <see cref="GraphResponse{Place}"/> object.
        /// </summary>
        /// <param name="placeToCreate">The Place to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Place}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Place>> CreateResponseAsync(Place placeToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Place.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Place.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Place and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Place and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Place.
        /// </summary>
        /// <returns>The Place.</returns>
        System.Threading.Tasks.Task<Place> GetAsync();

        /// <summary>
        /// Gets the specified Place.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Place.</returns>
        System.Threading.Tasks.Task<Place> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Place using PATCH.
        /// </summary>
        /// <param name="placeToUpdate">The Place to update.</param>
        /// <returns>The updated Place.</returns>
        System.Threading.Tasks.Task<Place> UpdateAsync(Place placeToUpdate);

        /// <summary>
        /// Updates the specified Place using PATCH.
        /// </summary>
        /// <param name="placeToUpdate">The Place to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Place.</returns>
        System.Threading.Tasks.Task<Place> UpdateAsync(Place placeToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlaceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlaceRequest Expand(Expression<Func<Place, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlaceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlaceRequest Select(Expression<Func<Place, object>> selectExpression);

    }
}
