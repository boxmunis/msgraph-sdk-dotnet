// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type OAuth2PermissionGrantWithReferenceRequest.
    /// </summary>
    public partial class OAuth2PermissionGrantWithReferenceRequest : BaseRequest, IOAuth2PermissionGrantWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new OAuth2PermissionGrantWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OAuth2PermissionGrantWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified OAuth2PermissionGrant.
        /// </summary>
        /// <returns>The OAuth2PermissionGrant.</returns>
        public System.Threading.Tasks.Task<OAuth2PermissionGrant> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OAuth2PermissionGrant.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OAuth2PermissionGrant.</returns>
        public async System.Threading.Tasks.Task<OAuth2PermissionGrant> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OAuth2PermissionGrant>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified OAuth2PermissionGrant using POST.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToCreate">The OAuth2PermissionGrant to create.</param>
        /// <returns>The created OAuth2PermissionGrant.</returns>
        public System.Threading.Tasks.Task<OAuth2PermissionGrant> CreateAsync(OAuth2PermissionGrant oAuth2PermissionGrantToCreate)
        {
            return this.CreateAsync(oAuth2PermissionGrantToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OAuth2PermissionGrant using POST.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToCreate">The OAuth2PermissionGrant to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OAuth2PermissionGrant.</returns>
        public async System.Threading.Tasks.Task<OAuth2PermissionGrant> CreateAsync(OAuth2PermissionGrant oAuth2PermissionGrantToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OAuth2PermissionGrant>(oAuth2PermissionGrantToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified OAuth2PermissionGrant using POST and returns a <see cref="GraphResponse{OAuth2PermissionGrant}"/> object.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToCreate">The OAuth2PermissionGrant to create.</param>
        /// <returns>The <see cref="GraphResponse{OAuth2PermissionGrant}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OAuth2PermissionGrant>> CreateResponseAsync(OAuth2PermissionGrant oAuth2PermissionGrantToCreate)
        {
            return this.CreateResponseAsync(oAuth2PermissionGrantToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OAuth2PermissionGrant using POST and returns a <see cref="GraphResponse{OAuth2PermissionGrant}"/> object.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToCreate">The OAuth2PermissionGrant to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OAuth2PermissionGrant}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OAuth2PermissionGrant>> CreateResponseAsync(OAuth2PermissionGrant oAuth2PermissionGrantToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<OAuth2PermissionGrant>(oAuth2PermissionGrantToCreate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Updates the specified OAuth2PermissionGrant using PATCH.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToUpdate">The OAuth2PermissionGrant to update.</param>
        /// <returns>The updated OAuth2PermissionGrant.</returns>
        public System.Threading.Tasks.Task<OAuth2PermissionGrant> UpdateAsync(OAuth2PermissionGrant oAuth2PermissionGrantToUpdate)
        {
            return this.UpdateAsync(oAuth2PermissionGrantToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OAuth2PermissionGrant using PATCH.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToUpdate">The OAuth2PermissionGrant to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OAuth2PermissionGrant.</returns>
        public async System.Threading.Tasks.Task<OAuth2PermissionGrant> UpdateAsync(OAuth2PermissionGrant oAuth2PermissionGrantToUpdate, CancellationToken cancellationToken)
        {
			if (oAuth2PermissionGrantToUpdate.AdditionalData != null)
			{
				if (oAuth2PermissionGrantToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					oAuth2PermissionGrantToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, oAuth2PermissionGrantToUpdate.GetType().Name)
						});
				}
			}
            if (oAuth2PermissionGrantToUpdate.AdditionalData != null)
            {
                if (oAuth2PermissionGrantToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    oAuth2PermissionGrantToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, oAuth2PermissionGrantToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OAuth2PermissionGrant>(oAuth2PermissionGrantToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified OAuth2PermissionGrant.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OAuth2PermissionGrant.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OAuth2PermissionGrant>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified OAuth2PermissionGrant and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OAuth2PermissionGrant and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOAuth2PermissionGrantWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOAuth2PermissionGrantWithReferenceRequest Expand(Expression<Func<OAuth2PermissionGrant, object>> expandExpression)
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
        public IOAuth2PermissionGrantWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOAuth2PermissionGrantWithReferenceRequest Select(Expression<Func<OAuth2PermissionGrant, object>> selectExpression)
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

    }
}
