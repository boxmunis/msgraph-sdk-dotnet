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
    /// The type ColumnLinkRequest.
    /// </summary>
    public partial class ColumnLinkRequest : BaseRequest, IColumnLinkRequest
    {
        /// <summary>
        /// Constructs a new ColumnLinkRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ColumnLinkRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ColumnLink using POST.
        /// </summary>
        /// <param name="columnLinkToCreate">The ColumnLink to create.</param>
        /// <returns>The created ColumnLink.</returns>
        public System.Threading.Tasks.Task<ColumnLink> CreateAsync(ColumnLink columnLinkToCreate)
        {
            return this.CreateAsync(columnLinkToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ColumnLink using POST.
        /// </summary>
        /// <param name="columnLinkToCreate">The ColumnLink to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ColumnLink.</returns>
        public async System.Threading.Tasks.Task<ColumnLink> CreateAsync(ColumnLink columnLinkToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ColumnLink>(columnLinkToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ColumnLink using POST and returns a <see cref="GraphResponse{ColumnLink}"/> object.
        /// </summary>
        /// <param name="columnLinkToCreate">The ColumnLink to create.</param>
        /// <returns>The <see cref="GraphResponse{ColumnLink}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ColumnLink>> CreateResponseAsync(ColumnLink columnLinkToCreate)
        {
            return this.CreateResponseAsync(columnLinkToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ColumnLink using POST and returns a <see cref="GraphResponse{ColumnLink}"/> object.
        /// </summary>
        /// <param name="columnLinkToCreate">The ColumnLink to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ColumnLink}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ColumnLink>> CreateResponseAsync(ColumnLink columnLinkToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<ColumnLink>(columnLinkToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ColumnLink.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ColumnLink.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ColumnLink>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ColumnLink and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ColumnLink and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ColumnLink.
        /// </summary>
        /// <returns>The ColumnLink.</returns>
        public System.Threading.Tasks.Task<ColumnLink> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ColumnLink.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ColumnLink.</returns>
        public async System.Threading.Tasks.Task<ColumnLink> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ColumnLink>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ColumnLink using PATCH.
        /// </summary>
        /// <param name="columnLinkToUpdate">The ColumnLink to update.</param>
        /// <returns>The updated ColumnLink.</returns>
        public System.Threading.Tasks.Task<ColumnLink> UpdateAsync(ColumnLink columnLinkToUpdate)
        {
            return this.UpdateAsync(columnLinkToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ColumnLink using PATCH.
        /// </summary>
        /// <param name="columnLinkToUpdate">The ColumnLink to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ColumnLink.</returns>
        public async System.Threading.Tasks.Task<ColumnLink> UpdateAsync(ColumnLink columnLinkToUpdate, CancellationToken cancellationToken)
        {
			if (columnLinkToUpdate.AdditionalData != null)
			{
				if (columnLinkToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					columnLinkToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, columnLinkToUpdate.GetType().Name)
						});
				}
			}
            if (columnLinkToUpdate.AdditionalData != null)
            {
                if (columnLinkToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    columnLinkToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, columnLinkToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ColumnLink>(columnLinkToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IColumnLinkRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IColumnLinkRequest Expand(Expression<Func<ColumnLink, object>> expandExpression)
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
        public IColumnLinkRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IColumnLinkRequest Select(Expression<Func<ColumnLink, object>> selectExpression)
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
        /// <param name="columnLinkToInitialize">The <see cref="ColumnLink"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ColumnLink columnLinkToInitialize)
        {

        }
    }
}
