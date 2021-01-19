// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AuditLogRootRestrictedSignInsCollectionRequestBuilder.
    /// </summary>
    public partial class AuditLogRootRestrictedSignInsCollectionRequestBuilder : BaseRequestBuilder, IAuditLogRootRestrictedSignInsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AuditLogRootRestrictedSignInsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuditLogRootRestrictedSignInsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAuditLogRootRestrictedSignInsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAuditLogRootRestrictedSignInsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AuditLogRootRestrictedSignInsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IRestrictedSignInRequestBuilder"/> for the specified AuditLogRootRestrictedSignIn.
        /// </summary>
        /// <param name="id">The ID for the AuditLogRootRestrictedSignIn.</param>
        /// <returns>The <see cref="IRestrictedSignInRequestBuilder"/>.</returns>
        public IRestrictedSignInRequestBuilder this[string id]
        {
            get
            {
                return new RestrictedSignInRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
