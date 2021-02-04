// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IRoleDefinitionWithReferenceRequest.
    /// </summary>
    public partial interface IRoleDefinitionWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified RoleDefinition.
        /// </summary>
        /// <returns>The RoleDefinition.</returns>
        System.Threading.Tasks.Task<RoleDefinition> GetAsync();

        /// <summary>
        /// Gets the specified RoleDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RoleDefinition.</returns>
        System.Threading.Tasks.Task<RoleDefinition> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified RoleDefinition using POST.
        /// </summary>
        /// <param name="roleDefinitionToCreate">The RoleDefinition to create.</param>
        /// <returns>The created RoleDefinition.</returns>
        System.Threading.Tasks.Task<RoleDefinition> CreateAsync(RoleDefinition roleDefinitionToCreate);

        /// <summary>
        /// Creates the specified RoleDefinition using POST.
        /// </summary>
        /// <param name="roleDefinitionToCreate">The RoleDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RoleDefinition.</returns>
        System.Threading.Tasks.Task<RoleDefinition> CreateAsync(RoleDefinition roleDefinitionToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified RoleDefinition using POST and returns a <see cref="GraphResponse{RoleDefinition}"/> object.
        /// </summary>
        /// <param name="roleDefinitionToCreate">The RoleDefinition to create.</param>
        /// <returns>The <see cref="GraphResponse{RoleDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RoleDefinition>> CreateResponseAsync(RoleDefinition roleDefinitionToCreate);

        /// <summary>
        /// Creates the specified RoleDefinition using POST and returns a <see cref="GraphResponse{RoleDefinition}"/> object.
        /// </summary>
        /// <param name="roleDefinitionToCreate">The RoleDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RoleDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RoleDefinition>> CreateResponseAsync(RoleDefinition roleDefinitionToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified RoleDefinition using PATCH.
        /// </summary>
        /// <param name="roleDefinitionToUpdate">The RoleDefinition to update.</param>
        /// <returns>The updated RoleDefinition.</returns>
        System.Threading.Tasks.Task<RoleDefinition> UpdateAsync(RoleDefinition roleDefinitionToUpdate);

        /// <summary>
        /// Updates the specified RoleDefinition using PATCH.
        /// </summary>
        /// <param name="roleDefinitionToUpdate">The RoleDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RoleDefinition.</returns>
        System.Threading.Tasks.Task<RoleDefinition> UpdateAsync(RoleDefinition roleDefinitionToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified RoleDefinition.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RoleDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified RoleDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified RoleDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoleDefinitionWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoleDefinitionWithReferenceRequest Expand(Expression<Func<RoleDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRoleDefinitionWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRoleDefinitionWithReferenceRequest Select(Expression<Func<RoleDefinition, object>> selectExpression);

    }
}
