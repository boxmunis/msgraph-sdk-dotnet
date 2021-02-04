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
    /// The interface IShiftRequest.
    /// </summary>
    public partial interface IShiftRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Shift using POST.
        /// </summary>
        /// <param name="shiftToCreate">The Shift to create.</param>
        /// <returns>The created Shift.</returns>
        System.Threading.Tasks.Task<Shift> CreateAsync(Shift shiftToCreate);

        /// <summary>
        /// Creates the specified Shift using POST.
        /// </summary>
        /// <param name="shiftToCreate">The Shift to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Shift.</returns>
        System.Threading.Tasks.Task<Shift> CreateAsync(Shift shiftToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Shift using POST and returns a <see cref="GraphResponse{Shift}"/> object.
        /// </summary>
        /// <param name="shiftToCreate">The Shift to create.</param>
        /// <returns>The <see cref="GraphResponse{Shift}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Shift>> CreateResponseAsync(Shift shiftToCreate);

        /// <summary>
        /// Creates the specified Shift using POST and returns a <see cref="GraphResponse{Shift}"/> object.
        /// </summary>
        /// <param name="shiftToCreate">The Shift to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Shift}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Shift>> CreateResponseAsync(Shift shiftToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Shift.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Shift.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Shift and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Shift and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Shift.
        /// </summary>
        /// <returns>The Shift.</returns>
        System.Threading.Tasks.Task<Shift> GetAsync();

        /// <summary>
        /// Gets the specified Shift.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Shift.</returns>
        System.Threading.Tasks.Task<Shift> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Shift using PATCH.
        /// </summary>
        /// <param name="shiftToUpdate">The Shift to update.</param>
        /// <returns>The updated Shift.</returns>
        System.Threading.Tasks.Task<Shift> UpdateAsync(Shift shiftToUpdate);

        /// <summary>
        /// Updates the specified Shift using PATCH.
        /// </summary>
        /// <param name="shiftToUpdate">The Shift to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Shift.</returns>
        System.Threading.Tasks.Task<Shift> UpdateAsync(Shift shiftToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IShiftRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IShiftRequest Expand(Expression<Func<Shift, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IShiftRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IShiftRequest Select(Expression<Func<Shift, object>> selectExpression);

    }
}
