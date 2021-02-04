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
    /// The interface IDirectoryRoleTemplateRequest.
    /// </summary>
    public partial interface IDirectoryRoleTemplateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DirectoryRoleTemplate using POST.
        /// </summary>
        /// <param name="directoryRoleTemplateToCreate">The DirectoryRoleTemplate to create.</param>
        /// <returns>The created DirectoryRoleTemplate.</returns>
        System.Threading.Tasks.Task<DirectoryRoleTemplate> CreateAsync(DirectoryRoleTemplate directoryRoleTemplateToCreate);

        /// <summary>
        /// Creates the specified DirectoryRoleTemplate using POST.
        /// </summary>
        /// <param name="directoryRoleTemplateToCreate">The DirectoryRoleTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryRoleTemplate.</returns>
        System.Threading.Tasks.Task<DirectoryRoleTemplate> CreateAsync(DirectoryRoleTemplate directoryRoleTemplateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DirectoryRoleTemplate using POST and returns a <see cref="GraphResponse{DirectoryRoleTemplate}"/> object.
        /// </summary>
        /// <param name="directoryRoleTemplateToCreate">The DirectoryRoleTemplate to create.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryRoleTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryRoleTemplate>> CreateResponseAsync(DirectoryRoleTemplate directoryRoleTemplateToCreate);

        /// <summary>
        /// Creates the specified DirectoryRoleTemplate using POST and returns a <see cref="GraphResponse{DirectoryRoleTemplate}"/> object.
        /// </summary>
        /// <param name="directoryRoleTemplateToCreate">The DirectoryRoleTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryRoleTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryRoleTemplate>> CreateResponseAsync(DirectoryRoleTemplate directoryRoleTemplateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DirectoryRoleTemplate.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DirectoryRoleTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DirectoryRoleTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DirectoryRoleTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DirectoryRoleTemplate.
        /// </summary>
        /// <returns>The DirectoryRoleTemplate.</returns>
        System.Threading.Tasks.Task<DirectoryRoleTemplate> GetAsync();

        /// <summary>
        /// Gets the specified DirectoryRoleTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectoryRoleTemplate.</returns>
        System.Threading.Tasks.Task<DirectoryRoleTemplate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DirectoryRoleTemplate using PATCH.
        /// </summary>
        /// <param name="directoryRoleTemplateToUpdate">The DirectoryRoleTemplate to update.</param>
        /// <returns>The updated DirectoryRoleTemplate.</returns>
        System.Threading.Tasks.Task<DirectoryRoleTemplate> UpdateAsync(DirectoryRoleTemplate directoryRoleTemplateToUpdate);

        /// <summary>
        /// Updates the specified DirectoryRoleTemplate using PATCH.
        /// </summary>
        /// <param name="directoryRoleTemplateToUpdate">The DirectoryRoleTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DirectoryRoleTemplate.</returns>
        System.Threading.Tasks.Task<DirectoryRoleTemplate> UpdateAsync(DirectoryRoleTemplate directoryRoleTemplateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleTemplateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleTemplateRequest Expand(Expression<Func<DirectoryRoleTemplate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleTemplateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleTemplateRequest Select(Expression<Func<DirectoryRoleTemplate, object>> selectExpression);

    }
}
