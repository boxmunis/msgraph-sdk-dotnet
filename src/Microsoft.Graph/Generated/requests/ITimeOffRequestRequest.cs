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
    /// The interface ITimeOffRequestRequest.
    /// </summary>
    public partial interface ITimeOffRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TimeOffRequestObject using POST.
        /// </summary>
        /// <param name="timeOffRequestObjectToCreate">The TimeOffRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TimeOffRequestObject.</returns>
        System.Threading.Tasks.Task<TimeOffRequestObject> CreateAsync(TimeOffRequestObject timeOffRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified TimeOffRequestObject using POST and returns a <see cref="GraphResponse{TimeOffRequestObject}"/> object.
        /// </summary>
        /// <param name="timeOffRequestObjectToCreate">The TimeOffRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TimeOffRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TimeOffRequestObject>> CreateResponseAsync(TimeOffRequestObject timeOffRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TimeOffRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TimeOffRequestObject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TimeOffRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TimeOffRequestObject.</returns>
        System.Threading.Tasks.Task<TimeOffRequestObject> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TimeOffRequestObject and returns a <see cref="GraphResponse{TimeOffRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TimeOffRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TimeOffRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TimeOffRequestObject using PATCH.
        /// </summary>
        /// <param name="timeOffRequestObjectToUpdate">The TimeOffRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TimeOffRequestObject.</returns>
        System.Threading.Tasks.Task<TimeOffRequestObject> UpdateAsync(TimeOffRequestObject timeOffRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TimeOffRequestObject using PATCH and returns a <see cref="GraphResponse{TimeOffRequestObject}"/> object.
        /// </summary>
        /// <param name="timeOffRequestObjectToUpdate">The TimeOffRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TimeOffRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TimeOffRequestObject>> UpdateResponseAsync(TimeOffRequestObject timeOffRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequestRequest Expand(Expression<Func<TimeOffRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequestRequest Select(Expression<Func<TimeOffRequestObject, object>> selectExpression);

    }
}
