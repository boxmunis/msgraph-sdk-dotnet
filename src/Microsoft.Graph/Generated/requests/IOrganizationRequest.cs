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
    /// The interface IOrganizationRequest.
    /// </summary>
    public partial interface IOrganizationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Organization using POST.
        /// </summary>
        /// <param name="organizationToCreate">The Organization to create.</param>
        /// <returns>The created Organization.</returns>
        System.Threading.Tasks.Task<Organization> CreateAsync(Organization organizationToCreate);

        /// <summary>
        /// Creates the specified Organization using POST.
        /// </summary>
        /// <param name="organizationToCreate">The Organization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Organization.</returns>
        System.Threading.Tasks.Task<Organization> CreateAsync(Organization organizationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Organization using POST and returns a <see cref="GraphResponse{Organization}"/> object.
        /// </summary>
        /// <param name="organizationToCreate">The Organization to create.</param>
        /// <returns>The <see cref="GraphResponse{Organization}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Organization>> CreateResponseAsync(Organization organizationToCreate);

        /// <summary>
        /// Creates the specified Organization using POST and returns a <see cref="GraphResponse{Organization}"/> object.
        /// </summary>
        /// <param name="organizationToCreate">The Organization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Organization}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Organization>> CreateResponseAsync(Organization organizationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Organization.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Organization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Organization and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Organization and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Organization.
        /// </summary>
        /// <returns>The Organization.</returns>
        System.Threading.Tasks.Task<Organization> GetAsync();

        /// <summary>
        /// Gets the specified Organization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Organization.</returns>
        System.Threading.Tasks.Task<Organization> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Organization using PATCH.
        /// </summary>
        /// <param name="organizationToUpdate">The Organization to update.</param>
        /// <returns>The updated Organization.</returns>
        System.Threading.Tasks.Task<Organization> UpdateAsync(Organization organizationToUpdate);

        /// <summary>
        /// Updates the specified Organization using PATCH.
        /// </summary>
        /// <param name="organizationToUpdate">The Organization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Organization.</returns>
        System.Threading.Tasks.Task<Organization> UpdateAsync(Organization organizationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationRequest Expand(Expression<Func<Organization, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationRequest Select(Expression<Func<Organization, object>> selectExpression);

    }
}
