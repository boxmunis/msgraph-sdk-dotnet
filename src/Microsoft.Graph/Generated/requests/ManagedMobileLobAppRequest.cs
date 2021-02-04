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
    /// The type ManagedMobileLobAppRequest.
    /// </summary>
    public partial class ManagedMobileLobAppRequest : BaseRequest, IManagedMobileLobAppRequest
    {
        /// <summary>
        /// Constructs a new ManagedMobileLobAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedMobileLobAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ManagedMobileLobApp using POST.
        /// </summary>
        /// <param name="managedMobileLobAppToCreate">The ManagedMobileLobApp to create.</param>
        /// <returns>The created ManagedMobileLobApp.</returns>
        public System.Threading.Tasks.Task<ManagedMobileLobApp> CreateAsync(ManagedMobileLobApp managedMobileLobAppToCreate)
        {
            return this.CreateAsync(managedMobileLobAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ManagedMobileLobApp using POST.
        /// </summary>
        /// <param name="managedMobileLobAppToCreate">The ManagedMobileLobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedMobileLobApp.</returns>
        public async System.Threading.Tasks.Task<ManagedMobileLobApp> CreateAsync(ManagedMobileLobApp managedMobileLobAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ManagedMobileLobApp>(managedMobileLobAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ManagedMobileLobApp using POST and returns a <see cref="GraphResponse{ManagedMobileLobApp}"/> object.
        /// </summary>
        /// <param name="managedMobileLobAppToCreate">The ManagedMobileLobApp to create.</param>
        /// <returns>The <see cref="GraphResponse{ManagedMobileLobApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedMobileLobApp>> CreateResponseAsync(ManagedMobileLobApp managedMobileLobAppToCreate)
        {
            return this.CreateResponseAsync(managedMobileLobAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ManagedMobileLobApp using POST and returns a <see cref="GraphResponse{ManagedMobileLobApp}"/> object.
        /// </summary>
        /// <param name="managedMobileLobAppToCreate">The ManagedMobileLobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedMobileLobApp}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ManagedMobileLobApp>> CreateResponseAsync(ManagedMobileLobApp managedMobileLobAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<ManagedMobileLobApp>(managedMobileLobAppToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ManagedMobileLobApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ManagedMobileLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ManagedMobileLobApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ManagedMobileLobApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ManagedMobileLobApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ManagedMobileLobApp.
        /// </summary>
        /// <returns>The ManagedMobileLobApp.</returns>
        public System.Threading.Tasks.Task<ManagedMobileLobApp> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ManagedMobileLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedMobileLobApp.</returns>
        public async System.Threading.Tasks.Task<ManagedMobileLobApp> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ManagedMobileLobApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedMobileLobApp using PATCH.
        /// </summary>
        /// <param name="managedMobileLobAppToUpdate">The ManagedMobileLobApp to update.</param>
        /// <returns>The updated ManagedMobileLobApp.</returns>
        public System.Threading.Tasks.Task<ManagedMobileLobApp> UpdateAsync(ManagedMobileLobApp managedMobileLobAppToUpdate)
        {
            return this.UpdateAsync(managedMobileLobAppToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ManagedMobileLobApp using PATCH.
        /// </summary>
        /// <param name="managedMobileLobAppToUpdate">The ManagedMobileLobApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedMobileLobApp.</returns>
        public async System.Threading.Tasks.Task<ManagedMobileLobApp> UpdateAsync(ManagedMobileLobApp managedMobileLobAppToUpdate, CancellationToken cancellationToken)
        {
			if (managedMobileLobAppToUpdate.AdditionalData != null)
			{
				if (managedMobileLobAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					managedMobileLobAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, managedMobileLobAppToUpdate.GetType().Name)
						});
				}
			}
            if (managedMobileLobAppToUpdate.AdditionalData != null)
            {
                if (managedMobileLobAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    managedMobileLobAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, managedMobileLobAppToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ManagedMobileLobApp>(managedMobileLobAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedMobileLobAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedMobileLobAppRequest Expand(Expression<Func<ManagedMobileLobApp, object>> expandExpression)
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
        public IManagedMobileLobAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedMobileLobAppRequest Select(Expression<Func<ManagedMobileLobApp, object>> selectExpression)
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
        /// <param name="managedMobileLobAppToInitialize">The <see cref="ManagedMobileLobApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ManagedMobileLobApp managedMobileLobAppToInitialize)
        {

            if (managedMobileLobAppToInitialize != null && managedMobileLobAppToInitialize.AdditionalData != null)
            {

                if (managedMobileLobAppToInitialize.ContentVersions != null && managedMobileLobAppToInitialize.ContentVersions.CurrentPage != null)
                {
                    managedMobileLobAppToInitialize.ContentVersions.AdditionalData = managedMobileLobAppToInitialize.AdditionalData;

                    object nextPageLink;
                    managedMobileLobAppToInitialize.AdditionalData.TryGetValue("contentVersions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        managedMobileLobAppToInitialize.ContentVersions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
