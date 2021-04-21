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
    /// The type GraphServiceIdentityProvidersCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceIdentityProvidersCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceIdentityProvidersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceIdentityProvidersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceIdentityProvidersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceIdentityProvidersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceIdentityProvidersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceIdentityProvidersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IIdentityProviderRequestBuilder"/> for the specified GraphServiceIdentityProvider.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceIdentityProvider.</param>
        /// <returns>The <see cref="IIdentityProviderRequestBuilder"/>.</returns>
        public IIdentityProviderRequestBuilder this[string id]
        {
            get
            {
                return new IdentityProviderRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IdentityProviderAvailableProviderTypes.
        /// </summary>
        /// <returns>The <see cref="IIdentityProviderAvailableProviderTypesRequestBuilder"/>.</returns>
        public IIdentityProviderAvailableProviderTypesRequestBuilder AvailableProviderTypes()
        {
            return new IdentityProviderAvailableProviderTypesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.availableProviderTypes"),
                this.Client);
        }
    }
}
