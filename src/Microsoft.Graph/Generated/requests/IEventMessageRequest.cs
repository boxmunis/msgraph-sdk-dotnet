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
    /// The interface IEventMessageRequest.
    /// </summary>
    public partial interface IEventMessageRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EventMessage using POST.
        /// </summary>
        /// <param name="eventMessageToCreate">The EventMessage to create.</param>
        /// <returns>The created EventMessage.</returns>
        System.Threading.Tasks.Task<EventMessage> CreateAsync(EventMessage eventMessageToCreate);

        /// <summary>
        /// Creates the specified EventMessage using POST.
        /// </summary>
        /// <param name="eventMessageToCreate">The EventMessage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EventMessage.</returns>
        System.Threading.Tasks.Task<EventMessage> CreateAsync(EventMessage eventMessageToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified EventMessage using POST and returns a <see cref="GraphResponse{EventMessage}"/> object.
        /// </summary>
        /// <param name="eventMessageToCreate">The EventMessage to create.</param>
        /// <returns>The <see cref="GraphResponse{EventMessage}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EventMessage>> CreateResponseAsync(EventMessage eventMessageToCreate);

        /// <summary>
        /// Creates the specified EventMessage using POST and returns a <see cref="GraphResponse{EventMessage}"/> object.
        /// </summary>
        /// <param name="eventMessageToCreate">The EventMessage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EventMessage}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EventMessage>> CreateResponseAsync(EventMessage eventMessageToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EventMessage.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EventMessage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EventMessage and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified EventMessage and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EventMessage.
        /// </summary>
        /// <returns>The EventMessage.</returns>
        System.Threading.Tasks.Task<EventMessage> GetAsync();

        /// <summary>
        /// Gets the specified EventMessage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EventMessage.</returns>
        System.Threading.Tasks.Task<EventMessage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EventMessage using PATCH.
        /// </summary>
        /// <param name="eventMessageToUpdate">The EventMessage to update.</param>
        /// <returns>The updated EventMessage.</returns>
        System.Threading.Tasks.Task<EventMessage> UpdateAsync(EventMessage eventMessageToUpdate);

        /// <summary>
        /// Updates the specified EventMessage using PATCH.
        /// </summary>
        /// <param name="eventMessageToUpdate">The EventMessage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EventMessage.</returns>
        System.Threading.Tasks.Task<EventMessage> UpdateAsync(EventMessage eventMessageToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEventMessageRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEventMessageRequest Expand(Expression<Func<EventMessage, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEventMessageRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEventMessageRequest Select(Expression<Func<EventMessage, object>> selectExpression);

    }
}
