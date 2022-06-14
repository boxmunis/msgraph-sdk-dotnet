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
    /// The interface IBitlockerRequest.
    /// </summary>
    public partial interface IBitlockerRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Bitlocker using POST.
        /// </summary>
        /// <param name="bitlockerToCreate">The Bitlocker to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Bitlocker.</returns>
        System.Threading.Tasks.Task<Bitlocker> CreateAsync(Bitlocker bitlockerToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Bitlocker using POST and returns a <see cref="GraphResponse{Bitlocker}"/> object.
        /// </summary>
        /// <param name="bitlockerToCreate">The Bitlocker to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Bitlocker}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Bitlocker>> CreateResponseAsync(Bitlocker bitlockerToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Bitlocker.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Bitlocker and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Bitlocker.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Bitlocker.</returns>
        System.Threading.Tasks.Task<Bitlocker> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Bitlocker and returns a <see cref="GraphResponse{Bitlocker}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Bitlocker}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Bitlocker>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Bitlocker using PATCH.
        /// </summary>
        /// <param name="bitlockerToUpdate">The Bitlocker to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Bitlocker.</returns>
        System.Threading.Tasks.Task<Bitlocker> UpdateAsync(Bitlocker bitlockerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Bitlocker using PATCH and returns a <see cref="GraphResponse{Bitlocker}"/> object.
        /// </summary>
        /// <param name="bitlockerToUpdate">The Bitlocker to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Bitlocker}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Bitlocker>> UpdateResponseAsync(Bitlocker bitlockerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Bitlocker using PUT.
        /// </summary>
        /// <param name="bitlockerToUpdate">The Bitlocker object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Bitlocker> PutAsync(Bitlocker bitlockerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Bitlocker using PUT and returns a <see cref="GraphResponse{Bitlocker}"/> object.
        /// </summary>
        /// <param name="bitlockerToUpdate">The Bitlocker object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Bitlocker}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Bitlocker>> PutResponseAsync(Bitlocker bitlockerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBitlockerRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBitlockerRequest Expand(Expression<Func<Bitlocker, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBitlockerRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBitlockerRequest Select(Expression<Func<Bitlocker, object>> selectExpression);

    }
}