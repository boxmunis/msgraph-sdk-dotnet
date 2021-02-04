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
    /// The interface IConditionalAccessPolicyRequest.
    /// </summary>
    public partial interface IConditionalAccessPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ConditionalAccessPolicy using POST.
        /// </summary>
        /// <param name="conditionalAccessPolicyToCreate">The ConditionalAccessPolicy to create.</param>
        /// <returns>The created ConditionalAccessPolicy.</returns>
        System.Threading.Tasks.Task<ConditionalAccessPolicy> CreateAsync(ConditionalAccessPolicy conditionalAccessPolicyToCreate);

        /// <summary>
        /// Creates the specified ConditionalAccessPolicy using POST.
        /// </summary>
        /// <param name="conditionalAccessPolicyToCreate">The ConditionalAccessPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConditionalAccessPolicy.</returns>
        System.Threading.Tasks.Task<ConditionalAccessPolicy> CreateAsync(ConditionalAccessPolicy conditionalAccessPolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified ConditionalAccessPolicy using POST and returns a <see cref="GraphResponse{ConditionalAccessPolicy}"/> object.
        /// </summary>
        /// <param name="conditionalAccessPolicyToCreate">The ConditionalAccessPolicy to create.</param>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConditionalAccessPolicy>> CreateResponseAsync(ConditionalAccessPolicy conditionalAccessPolicyToCreate);

        /// <summary>
        /// Creates the specified ConditionalAccessPolicy using POST and returns a <see cref="GraphResponse{ConditionalAccessPolicy}"/> object.
        /// </summary>
        /// <param name="conditionalAccessPolicyToCreate">The ConditionalAccessPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConditionalAccessPolicy>> CreateResponseAsync(ConditionalAccessPolicy conditionalAccessPolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ConditionalAccessPolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ConditionalAccessPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ConditionalAccessPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified ConditionalAccessPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ConditionalAccessPolicy.
        /// </summary>
        /// <returns>The ConditionalAccessPolicy.</returns>
        System.Threading.Tasks.Task<ConditionalAccessPolicy> GetAsync();

        /// <summary>
        /// Gets the specified ConditionalAccessPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConditionalAccessPolicy.</returns>
        System.Threading.Tasks.Task<ConditionalAccessPolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ConditionalAccessPolicy using PATCH.
        /// </summary>
        /// <param name="conditionalAccessPolicyToUpdate">The ConditionalAccessPolicy to update.</param>
        /// <returns>The updated ConditionalAccessPolicy.</returns>
        System.Threading.Tasks.Task<ConditionalAccessPolicy> UpdateAsync(ConditionalAccessPolicy conditionalAccessPolicyToUpdate);

        /// <summary>
        /// Updates the specified ConditionalAccessPolicy using PATCH.
        /// </summary>
        /// <param name="conditionalAccessPolicyToUpdate">The ConditionalAccessPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConditionalAccessPolicy.</returns>
        System.Threading.Tasks.Task<ConditionalAccessPolicy> UpdateAsync(ConditionalAccessPolicy conditionalAccessPolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessPolicyRequest Expand(Expression<Func<ConditionalAccessPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessPolicyRequest Select(Expression<Func<ConditionalAccessPolicy, object>> selectExpression);

    }
}
