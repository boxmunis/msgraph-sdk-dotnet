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
    /// The interface IEducationClassRequest.
    /// </summary>
    public partial interface IEducationClassRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationClass using POST.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <returns>The created EducationClass.</returns>
        System.Threading.Tasks.Task<EducationClass> CreateAsync(EducationClass educationClassToCreate);

        /// <summary>
        /// Creates the specified EducationClass using POST.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationClass.</returns>
        System.Threading.Tasks.Task<EducationClass> CreateAsync(EducationClass educationClassToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified EducationClass using POST and returns a <see cref="GraphResponse{EducationClass}"/> object.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <returns>The <see cref="GraphResponse{EducationClass}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationClass>> CreateResponseAsync(EducationClass educationClassToCreate);

        /// <summary>
        /// Creates the specified EducationClass using POST and returns a <see cref="GraphResponse{EducationClass}"/> object.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationClass}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationClass>> CreateResponseAsync(EducationClass educationClassToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EducationClass.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EducationClass.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EducationClass and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified EducationClass and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EducationClass.
        /// </summary>
        /// <returns>The EducationClass.</returns>
        System.Threading.Tasks.Task<EducationClass> GetAsync();

        /// <summary>
        /// Gets the specified EducationClass.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationClass.</returns>
        System.Threading.Tasks.Task<EducationClass> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EducationClass using PATCH.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass to update.</param>
        /// <returns>The updated EducationClass.</returns>
        System.Threading.Tasks.Task<EducationClass> UpdateAsync(EducationClass educationClassToUpdate);

        /// <summary>
        /// Updates the specified EducationClass using PATCH.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationClass.</returns>
        System.Threading.Tasks.Task<EducationClass> UpdateAsync(EducationClass educationClassToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationClassRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationClassRequest Expand(Expression<Func<EducationClass, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationClassRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationClassRequest Select(Expression<Func<EducationClass, object>> selectExpression);

    }
}
