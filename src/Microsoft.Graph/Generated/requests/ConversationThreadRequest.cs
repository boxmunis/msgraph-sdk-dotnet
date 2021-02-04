// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ConversationThreadRequest.
    /// </summary>
    public partial class ConversationThreadRequest : BaseRequest, IConversationThreadRequest
    {
        /// <summary>
        /// Constructs a new ConversationThreadRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ConversationThreadRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ConversationThread using POST.
        /// </summary>
        /// <param name="conversationThreadToCreate">The ConversationThread to create.</param>
        /// <returns>The created ConversationThread.</returns>
        public System.Threading.Tasks.Task<ConversationThread> CreateAsync(ConversationThread conversationThreadToCreate)
        {
            return this.CreateAsync(conversationThreadToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ConversationThread using POST.
        /// </summary>
        /// <param name="conversationThreadToCreate">The ConversationThread to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConversationThread.</returns>
        public async System.Threading.Tasks.Task<ConversationThread> CreateAsync(ConversationThread conversationThreadToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ConversationThread>(conversationThreadToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ConversationThread using POST and returns a <see cref="GraphResponse{ConversationThread}"/> object.
        /// </summary>
        /// <param name="conversationThreadToCreate">The ConversationThread to create.</param>
        /// <returns>The <see cref="GraphResponse{ConversationThread}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConversationThread>> CreateResponseAsync(ConversationThread conversationThreadToCreate)
        {
            return this.CreateResponseAsync(conversationThreadToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ConversationThread using POST and returns a <see cref="GraphResponse{ConversationThread}"/> object.
        /// </summary>
        /// <param name="conversationThreadToCreate">The ConversationThread to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConversationThread}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ConversationThread>> CreateResponseAsync(ConversationThread conversationThreadToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<ConversationThread>(conversationThreadToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ConversationThread.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ConversationThread.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ConversationThread>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ConversationThread and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ConversationThread and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ConversationThread.
        /// </summary>
        /// <returns>The ConversationThread.</returns>
        public System.Threading.Tasks.Task<ConversationThread> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ConversationThread.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConversationThread.</returns>
        public async System.Threading.Tasks.Task<ConversationThread> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ConversationThread>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ConversationThread using PATCH.
        /// </summary>
        /// <param name="conversationThreadToUpdate">The ConversationThread to update.</param>
        /// <returns>The updated ConversationThread.</returns>
        public System.Threading.Tasks.Task<ConversationThread> UpdateAsync(ConversationThread conversationThreadToUpdate)
        {
            return this.UpdateAsync(conversationThreadToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ConversationThread using PATCH.
        /// </summary>
        /// <param name="conversationThreadToUpdate">The ConversationThread to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConversationThread.</returns>
        public async System.Threading.Tasks.Task<ConversationThread> UpdateAsync(ConversationThread conversationThreadToUpdate, CancellationToken cancellationToken)
        {
			if (conversationThreadToUpdate.AdditionalData != null)
			{
				if (conversationThreadToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					conversationThreadToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, conversationThreadToUpdate.GetType().Name)
						});
				}
			}
            if (conversationThreadToUpdate.AdditionalData != null)
            {
                if (conversationThreadToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    conversationThreadToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, conversationThreadToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ConversationThread>(conversationThreadToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConversationThreadRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConversationThreadRequest Expand(Expression<Func<ConversationThread, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IConversationThreadRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IConversationThreadRequest Select(Expression<Func<ConversationThread, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="conversationThreadToInitialize">The <see cref="ConversationThread"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ConversationThread conversationThreadToInitialize)
        {

            if (conversationThreadToInitialize != null && conversationThreadToInitialize.AdditionalData != null)
            {

                if (conversationThreadToInitialize.Posts != null && conversationThreadToInitialize.Posts.CurrentPage != null)
                {
                    conversationThreadToInitialize.Posts.AdditionalData = conversationThreadToInitialize.AdditionalData;

                    object nextPageLink;
                    conversationThreadToInitialize.AdditionalData.TryGetValue("posts@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        conversationThreadToInitialize.Posts.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
