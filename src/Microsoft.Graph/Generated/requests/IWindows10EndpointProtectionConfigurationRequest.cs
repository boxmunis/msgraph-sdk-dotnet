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
    /// The interface IWindows10EndpointProtectionConfigurationRequest.
    /// </summary>
    public partial interface IWindows10EndpointProtectionConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10EndpointProtectionConfiguration using POST.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToCreate">The Windows10EndpointProtectionConfiguration to create.</param>
        /// <returns>The created Windows10EndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> CreateAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToCreate);

        /// <summary>
        /// Creates the specified Windows10EndpointProtectionConfiguration using POST.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToCreate">The Windows10EndpointProtectionConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10EndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> CreateAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified Windows10EndpointProtectionConfiguration using POST and returns a <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToCreate">The Windows10EndpointProtectionConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10EndpointProtectionConfiguration>> CreateResponseAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToCreate);

        /// <summary>
        /// Creates the specified Windows10EndpointProtectionConfiguration using POST and returns a <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToCreate">The Windows10EndpointProtectionConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10EndpointProtectionConfiguration>> CreateResponseAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10EndpointProtectionConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10EndpointProtectionConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10EndpointProtectionConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Windows10EndpointProtectionConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10EndpointProtectionConfiguration.
        /// </summary>
        /// <returns>The Windows10EndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified Windows10EndpointProtectionConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10EndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10EndpointProtectionConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToUpdate">The Windows10EndpointProtectionConfiguration to update.</param>
        /// <returns>The updated Windows10EndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> UpdateAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToUpdate);

        /// <summary>
        /// Updates the specified Windows10EndpointProtectionConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToUpdate">The Windows10EndpointProtectionConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10EndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> UpdateAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10EndpointProtectionConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10EndpointProtectionConfigurationRequest Expand(Expression<Func<Windows10EndpointProtectionConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10EndpointProtectionConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10EndpointProtectionConfigurationRequest Select(Expression<Func<Windows10EndpointProtectionConfiguration, object>> selectExpression);

    }
}
