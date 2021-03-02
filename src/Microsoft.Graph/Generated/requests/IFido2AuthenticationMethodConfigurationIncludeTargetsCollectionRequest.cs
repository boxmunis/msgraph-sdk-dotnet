// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest.
    /// </summary>
    public partial interface IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified AuthenticationMethodTarget to the collection via POST.
        /// </summary>
        /// <param name="authenticationMethodTarget">The AuthenticationMethodTarget to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuthenticationMethodTarget.</returns>
        System.Threading.Tasks.Task<AuthenticationMethodTarget> AddAsync(AuthenticationMethodTarget authenticationMethodTarget, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified AuthenticationMethodTarget to the collection via POST and returns a <see cref="GraphResponse{AuthenticationMethodTarget}"/> object of the request.
        /// </summary>
        /// <param name="authenticationMethodTarget">The AuthenticationMethodTarget to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethodTarget}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodTarget>> AddResponseAsync(AuthenticationMethodTarget authenticationMethodTarget, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionPage> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{Fido2AuthenticationMethodConfigurationIncludeTargetsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Fido2AuthenticationMethodConfigurationIncludeTargetsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<Fido2AuthenticationMethodConfigurationIncludeTargetsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest Expand(Expression<Func<AuthenticationMethodTarget, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest Select(Expression<Func<AuthenticationMethodTarget, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest OrderBy(string value);
    }
}
