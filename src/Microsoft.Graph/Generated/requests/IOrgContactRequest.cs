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
    /// The interface IOrgContactRequest.
    /// </summary>
    public partial interface IOrgContactRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OrgContact using POST.
        /// </summary>
        /// <param name="orgContactToCreate">The OrgContact to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OrgContact.</returns>
        System.Threading.Tasks.Task<OrgContact> CreateAsync(OrgContact orgContactToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified OrgContact using POST and returns a <see cref="GraphResponse{OrgContact}"/> object.
        /// </summary>
        /// <param name="orgContactToCreate">The OrgContact to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OrgContact}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OrgContact>> CreateResponseAsync(OrgContact orgContactToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OrgContact.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OrgContact and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OrgContact.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OrgContact.</returns>
        System.Threading.Tasks.Task<OrgContact> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OrgContact and returns a <see cref="GraphResponse{OrgContact}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OrgContact}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OrgContact>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OrgContact using PATCH.
        /// </summary>
        /// <param name="orgContactToUpdate">The OrgContact to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OrgContact.</returns>
        System.Threading.Tasks.Task<OrgContact> UpdateAsync(OrgContact orgContactToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OrgContact using PATCH and returns a <see cref="GraphResponse{OrgContact}"/> object.
        /// </summary>
        /// <param name="orgContactToUpdate">The OrgContact to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OrgContact}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OrgContact>> UpdateResponseAsync(OrgContact orgContactToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOrgContactRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOrgContactRequest Expand(Expression<Func<OrgContact, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOrgContactRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOrgContactRequest Select(Expression<Func<OrgContact, object>> selectExpression);

    }
}
