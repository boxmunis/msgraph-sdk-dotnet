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
    /// The interface IIosCertificateProfileRequest.
    /// </summary>
    public partial interface IIosCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosCertificateProfile using POST.
        /// </summary>
        /// <param name="iosCertificateProfileToCreate">The IosCertificateProfile to create.</param>
        /// <returns>The created IosCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosCertificateProfile> CreateAsync(IosCertificateProfile iosCertificateProfileToCreate);

        /// <summary>
        /// Creates the specified IosCertificateProfile using POST.
        /// </summary>
        /// <param name="iosCertificateProfileToCreate">The IosCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosCertificateProfile> CreateAsync(IosCertificateProfile iosCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified IosCertificateProfile using POST and returns a <see cref="GraphResponse{IosCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosCertificateProfileToCreate">The IosCertificateProfile to create.</param>
        /// <returns>The <see cref="GraphResponse{IosCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosCertificateProfile>> CreateResponseAsync(IosCertificateProfile iosCertificateProfileToCreate);

        /// <summary>
        /// Creates the specified IosCertificateProfile using POST and returns a <see cref="GraphResponse{IosCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosCertificateProfileToCreate">The IosCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosCertificateProfile>> CreateResponseAsync(IosCertificateProfile iosCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified IosCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosCertificateProfile.
        /// </summary>
        /// <returns>The IosCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified IosCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosCertificateProfileToUpdate">The IosCertificateProfile to update.</param>
        /// <returns>The updated IosCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosCertificateProfile> UpdateAsync(IosCertificateProfile iosCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified IosCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosCertificateProfileToUpdate">The IosCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosCertificateProfile> UpdateAsync(IosCertificateProfile iosCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosCertificateProfileRequest Expand(Expression<Func<IosCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosCertificateProfileRequest Select(Expression<Func<IosCertificateProfile, object>> selectExpression);

    }
}
