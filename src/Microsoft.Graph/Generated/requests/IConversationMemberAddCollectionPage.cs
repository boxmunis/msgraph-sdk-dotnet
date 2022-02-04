// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IConversationMemberAddCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<ConversationMemberAddCollectionPage>))]
    public interface IConversationMemberAddCollectionPage : ICollectionPage<ActionResultPart>
    {
        /// <summary>
        /// Gets the next page <see cref="IConversationMemberAddRequest"/> instance.
        /// </summary>
        IConversationMemberAddRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}