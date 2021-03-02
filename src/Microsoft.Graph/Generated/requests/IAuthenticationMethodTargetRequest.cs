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
    /// The interface IAuthenticationMethodTargetRequest.
    /// </summary>
    public partial interface IAuthenticationMethodTargetRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AuthenticationMethodTarget using POST.
        /// </summary>
        /// <param name="authenticationMethodTargetToCreate">The AuthenticationMethodTarget to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuthenticationMethodTarget.</returns>
        System.Threading.Tasks.Task<AuthenticationMethodTarget> CreateAsync(AuthenticationMethodTarget authenticationMethodTargetToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AuthenticationMethodTarget using POST and returns a <see cref="GraphResponse{AuthenticationMethodTarget}"/> object.
        /// </summary>
        /// <param name="authenticationMethodTargetToCreate">The AuthenticationMethodTarget to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethodTarget}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodTarget>> CreateResponseAsync(AuthenticationMethodTarget authenticationMethodTargetToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AuthenticationMethodTarget.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AuthenticationMethodTarget and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AuthenticationMethodTarget.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuthenticationMethodTarget.</returns>
        System.Threading.Tasks.Task<AuthenticationMethodTarget> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AuthenticationMethodTarget and returns a <see cref="GraphResponse{AuthenticationMethodTarget}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethodTarget}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodTarget>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AuthenticationMethodTarget using PATCH.
        /// </summary>
        /// <param name="authenticationMethodTargetToUpdate">The AuthenticationMethodTarget to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AuthenticationMethodTarget.</returns>
        System.Threading.Tasks.Task<AuthenticationMethodTarget> UpdateAsync(AuthenticationMethodTarget authenticationMethodTargetToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AuthenticationMethodTarget using PATCH and returns a <see cref="GraphResponse{AuthenticationMethodTarget}"/> object.
        /// </summary>
        /// <param name="authenticationMethodTargetToUpdate">The AuthenticationMethodTarget to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethodTarget}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodTarget>> UpdateResponseAsync(AuthenticationMethodTarget authenticationMethodTargetToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodTargetRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodTargetRequest Expand(Expression<Func<AuthenticationMethodTarget, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodTargetRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodTargetRequest Select(Expression<Func<AuthenticationMethodTarget, object>> selectExpression);

    }
}
