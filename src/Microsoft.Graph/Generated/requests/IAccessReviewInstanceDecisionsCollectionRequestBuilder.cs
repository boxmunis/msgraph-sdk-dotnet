// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IAccessReviewInstanceDecisionsCollectionRequestBuilder.
    /// </summary>
    public partial interface IAccessReviewInstanceDecisionsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IAccessReviewInstanceDecisionsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IAccessReviewInstanceDecisionsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAccessReviewInstanceDecisionItemRequestBuilder"/> for the specified AccessReviewInstanceDecisionItem.
        /// </summary>
        /// <param name="id">The ID for the AccessReviewInstanceDecisionItem.</param>
        /// <returns>The <see cref="IAccessReviewInstanceDecisionItemRequestBuilder"/>.</returns>
        IAccessReviewInstanceDecisionItemRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceDecisionItemFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceDecisionItemFilterByCurrentUserRequestBuilder"/>.</returns>
        IAccessReviewInstanceDecisionItemFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            AccessReviewInstanceDecisionItemFilterByCurrentUserOptions on);
    }
}
