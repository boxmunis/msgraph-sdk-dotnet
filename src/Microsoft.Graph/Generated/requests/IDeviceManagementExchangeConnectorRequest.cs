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
    /// The interface IDeviceManagementExchangeConnectorRequest.
    /// </summary>
    public partial interface IDeviceManagementExchangeConnectorRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementExchangeConnector using POST.
        /// </summary>
        /// <param name="deviceManagementExchangeConnectorToCreate">The DeviceManagementExchangeConnector to create.</param>
        /// <returns>The created DeviceManagementExchangeConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeConnector> CreateAsync(DeviceManagementExchangeConnector deviceManagementExchangeConnectorToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementExchangeConnector using POST.
        /// </summary>
        /// <param name="deviceManagementExchangeConnectorToCreate">The DeviceManagementExchangeConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementExchangeConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeConnector> CreateAsync(DeviceManagementExchangeConnector deviceManagementExchangeConnectorToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceManagementExchangeConnector using POST and returns a <see cref="GraphResponse{DeviceManagementExchangeConnector}"/> object.
        /// </summary>
        /// <param name="deviceManagementExchangeConnectorToCreate">The DeviceManagementExchangeConnector to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementExchangeConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementExchangeConnector>> CreateResponseAsync(DeviceManagementExchangeConnector deviceManagementExchangeConnectorToCreate);

        /// <summary>
        /// Creates the specified DeviceManagementExchangeConnector using POST and returns a <see cref="GraphResponse{DeviceManagementExchangeConnector}"/> object.
        /// </summary>
        /// <param name="deviceManagementExchangeConnectorToCreate">The DeviceManagementExchangeConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementExchangeConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementExchangeConnector>> CreateResponseAsync(DeviceManagementExchangeConnector deviceManagementExchangeConnectorToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementExchangeConnector.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementExchangeConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementExchangeConnector and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementExchangeConnector and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementExchangeConnector.
        /// </summary>
        /// <returns>The DeviceManagementExchangeConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeConnector> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementExchangeConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementExchangeConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeConnector> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementExchangeConnector using PATCH.
        /// </summary>
        /// <param name="deviceManagementExchangeConnectorToUpdate">The DeviceManagementExchangeConnector to update.</param>
        /// <returns>The updated DeviceManagementExchangeConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeConnector> UpdateAsync(DeviceManagementExchangeConnector deviceManagementExchangeConnectorToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementExchangeConnector using PATCH.
        /// </summary>
        /// <param name="deviceManagementExchangeConnectorToUpdate">The DeviceManagementExchangeConnector to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementExchangeConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeConnector> UpdateAsync(DeviceManagementExchangeConnector deviceManagementExchangeConnectorToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExchangeConnectorRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExchangeConnectorRequest Expand(Expression<Func<DeviceManagementExchangeConnector, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExchangeConnectorRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExchangeConnectorRequest Select(Expression<Func<DeviceManagementExchangeConnector, object>> selectExpression);

    }
}
