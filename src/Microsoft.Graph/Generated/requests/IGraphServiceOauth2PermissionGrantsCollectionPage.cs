// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IGraphServiceOauth2PermissionGrantsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<GraphServiceOauth2PermissionGrantsCollectionPage>))]
    public interface IGraphServiceOauth2PermissionGrantsCollectionPage : ICollectionPage<OAuth2PermissionGrant>
    {
        /// <summary>
        /// Gets the next page <see cref="IGraphServiceOauth2PermissionGrantsCollectionRequest"/> instance.
        /// </summary>
        IGraphServiceOauth2PermissionGrantsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
