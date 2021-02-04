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
    /// The interface IDeviceManagementPartnerRequest.
    /// </summary>
    public partial interface IDeviceManagementPartnerRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementPartner using POST.
        /// </summary>
        /// <param name="deviceManagementPartnerToCreate">The DeviceManagementPartner to create.</param>
        /// <returns>The created DeviceManagementPartner.</returns>
        System.Threading.Tasks.Task<DeviceManagementPartner> CreateAsync(DeviceManagementPartner deviceManagementPartnerToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementPartner using POST.
        /// </summary>
        /// <param name="deviceManagementPartnerToCreate">The DeviceManagementPartner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementPartner.</returns>
        System.Threading.Tasks.Task<DeviceManagementPartner> CreateAsync(DeviceManagementPartner deviceManagementPartnerToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceManagementPartner using POST and returns a <see cref="GraphResponse{DeviceManagementPartner}"/> object.
        /// </summary>
        /// <param name="deviceManagementPartnerToCreate">The DeviceManagementPartner to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementPartner}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementPartner>> CreateResponseAsync(DeviceManagementPartner deviceManagementPartnerToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementPartner using POST and returns a <see cref="GraphResponse{DeviceManagementPartner}"/> object.
        /// </summary>
        /// <param name="deviceManagementPartnerToCreate">The DeviceManagementPartner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementPartner}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementPartner>> CreateResponseAsync(DeviceManagementPartner deviceManagementPartnerToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementPartner.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementPartner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementPartner and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementPartner and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementPartner.
        /// </summary>
        /// <returns>The DeviceManagementPartner.</returns>
        System.Threading.Tasks.Task<DeviceManagementPartner> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementPartner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementPartner.</returns>
        System.Threading.Tasks.Task<DeviceManagementPartner> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementPartner using PATCH.
        /// </summary>
        /// <param name="deviceManagementPartnerToUpdate">The DeviceManagementPartner to update.</param>
        /// <returns>The updated DeviceManagementPartner.</returns>
        System.Threading.Tasks.Task<DeviceManagementPartner> UpdateAsync(DeviceManagementPartner deviceManagementPartnerToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementPartner using PATCH.
        /// </summary>
        /// <param name="deviceManagementPartnerToUpdate">The DeviceManagementPartner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementPartner.</returns>
        System.Threading.Tasks.Task<DeviceManagementPartner> UpdateAsync(DeviceManagementPartner deviceManagementPartnerToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementPartnerRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementPartnerRequest Expand(Expression<Func<DeviceManagementPartner, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementPartnerRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementPartnerRequest Select(Expression<Func<DeviceManagementPartner, object>> selectExpression);

    }
}
