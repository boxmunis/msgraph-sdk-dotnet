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
    /// The interface IWindowsPhone81CompliancePolicyRequest.
    /// </summary>
    public partial interface IWindowsPhone81CompliancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsPhone81CompliancePolicy using POST.
        /// </summary>
        /// <param name="windowsPhone81CompliancePolicyToCreate">The WindowsPhone81CompliancePolicy to create.</param>
        /// <returns>The created WindowsPhone81CompliancePolicy.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CompliancePolicy> CreateAsync(WindowsPhone81CompliancePolicy windowsPhone81CompliancePolicyToCreate);

        /// <summary>
        /// Creates the specified WindowsPhone81CompliancePolicy using POST.
        /// </summary>
        /// <param name="windowsPhone81CompliancePolicyToCreate">The WindowsPhone81CompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81CompliancePolicy.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CompliancePolicy> CreateAsync(WindowsPhone81CompliancePolicy windowsPhone81CompliancePolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WindowsPhone81CompliancePolicy using POST and returns a <see cref="GraphResponse{WindowsPhone81CompliancePolicy}"/> object.
        /// </summary>
        /// <param name="windowsPhone81CompliancePolicyToCreate">The WindowsPhone81CompliancePolicy to create.</param>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81CompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsPhone81CompliancePolicy>> CreateResponseAsync(WindowsPhone81CompliancePolicy windowsPhone81CompliancePolicyToCreate);

        /// <summary>
        /// Creates the specified WindowsPhone81CompliancePolicy using POST and returns a <see cref="GraphResponse{WindowsPhone81CompliancePolicy}"/> object.
        /// </summary>
        /// <param name="windowsPhone81CompliancePolicyToCreate">The WindowsPhone81CompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81CompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsPhone81CompliancePolicy>> CreateResponseAsync(WindowsPhone81CompliancePolicy windowsPhone81CompliancePolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsPhone81CompliancePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsPhone81CompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsPhone81CompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WindowsPhone81CompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsPhone81CompliancePolicy.
        /// </summary>
        /// <returns>The WindowsPhone81CompliancePolicy.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CompliancePolicy> GetAsync();

        /// <summary>
        /// Gets the specified WindowsPhone81CompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81CompliancePolicy.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CompliancePolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsPhone81CompliancePolicy using PATCH.
        /// </summary>
        /// <param name="windowsPhone81CompliancePolicyToUpdate">The WindowsPhone81CompliancePolicy to update.</param>
        /// <returns>The updated WindowsPhone81CompliancePolicy.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CompliancePolicy> UpdateAsync(WindowsPhone81CompliancePolicy windowsPhone81CompliancePolicyToUpdate);

        /// <summary>
        /// Updates the specified WindowsPhone81CompliancePolicy using PATCH.
        /// </summary>
        /// <param name="windowsPhone81CompliancePolicyToUpdate">The WindowsPhone81CompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsPhone81CompliancePolicy.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CompliancePolicy> UpdateAsync(WindowsPhone81CompliancePolicy windowsPhone81CompliancePolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81CompliancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81CompliancePolicyRequest Expand(Expression<Func<WindowsPhone81CompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81CompliancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81CompliancePolicyRequest Select(Expression<Func<WindowsPhone81CompliancePolicy, object>> selectExpression);

    }
}
