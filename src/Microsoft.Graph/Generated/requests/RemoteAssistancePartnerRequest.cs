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
    /// The type RemoteAssistancePartnerRequest.
    /// </summary>
    public partial class RemoteAssistancePartnerRequest : BaseRequest, IRemoteAssistancePartnerRequest
    {
        /// <summary>
        /// Constructs a new RemoteAssistancePartnerRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public RemoteAssistancePartnerRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified RemoteAssistancePartner using POST.
        /// </summary>
        /// <param name="remoteAssistancePartnerToCreate">The RemoteAssistancePartner to create.</param>
        /// <returns>The created RemoteAssistancePartner.</returns>
        public System.Threading.Tasks.Task<RemoteAssistancePartner> CreateAsync(RemoteAssistancePartner remoteAssistancePartnerToCreate)
        {
            return this.CreateAsync(remoteAssistancePartnerToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RemoteAssistancePartner using POST.
        /// </summary>
        /// <param name="remoteAssistancePartnerToCreate">The RemoteAssistancePartner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RemoteAssistancePartner.</returns>
        public async System.Threading.Tasks.Task<RemoteAssistancePartner> CreateAsync(RemoteAssistancePartner remoteAssistancePartnerToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<RemoteAssistancePartner>(remoteAssistancePartnerToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified RemoteAssistancePartner using POST and returns a <see cref="GraphResponse{RemoteAssistancePartner}"/> object.
        /// </summary>
        /// <param name="remoteAssistancePartnerToCreate">The RemoteAssistancePartner to create.</param>
        /// <returns>The <see cref="GraphResponse{RemoteAssistancePartner}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RemoteAssistancePartner>> CreateResponseAsync(RemoteAssistancePartner remoteAssistancePartnerToCreate)
        {
            return this.CreateResponseAsync(remoteAssistancePartnerToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RemoteAssistancePartner using POST and returns a <see cref="GraphResponse{RemoteAssistancePartner}"/> object.
        /// </summary>
        /// <param name="remoteAssistancePartnerToCreate">The RemoteAssistancePartner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RemoteAssistancePartner}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<RemoteAssistancePartner>> CreateResponseAsync(RemoteAssistancePartner remoteAssistancePartnerToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<RemoteAssistancePartner>(remoteAssistancePartnerToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified RemoteAssistancePartner.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified RemoteAssistancePartner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<RemoteAssistancePartner>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified RemoteAssistancePartner and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified RemoteAssistancePartner and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified RemoteAssistancePartner.
        /// </summary>
        /// <returns>The RemoteAssistancePartner.</returns>
        public System.Threading.Tasks.Task<RemoteAssistancePartner> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified RemoteAssistancePartner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RemoteAssistancePartner.</returns>
        public async System.Threading.Tasks.Task<RemoteAssistancePartner> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<RemoteAssistancePartner>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified RemoteAssistancePartner using PATCH.
        /// </summary>
        /// <param name="remoteAssistancePartnerToUpdate">The RemoteAssistancePartner to update.</param>
        /// <returns>The updated RemoteAssistancePartner.</returns>
        public System.Threading.Tasks.Task<RemoteAssistancePartner> UpdateAsync(RemoteAssistancePartner remoteAssistancePartnerToUpdate)
        {
            return this.UpdateAsync(remoteAssistancePartnerToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified RemoteAssistancePartner using PATCH.
        /// </summary>
        /// <param name="remoteAssistancePartnerToUpdate">The RemoteAssistancePartner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RemoteAssistancePartner.</returns>
        public async System.Threading.Tasks.Task<RemoteAssistancePartner> UpdateAsync(RemoteAssistancePartner remoteAssistancePartnerToUpdate, CancellationToken cancellationToken)
        {
			if (remoteAssistancePartnerToUpdate.AdditionalData != null)
			{
				if (remoteAssistancePartnerToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					remoteAssistancePartnerToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, remoteAssistancePartnerToUpdate.GetType().Name)
						});
				}
			}
            if (remoteAssistancePartnerToUpdate.AdditionalData != null)
            {
                if (remoteAssistancePartnerToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    remoteAssistancePartnerToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, remoteAssistancePartnerToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<RemoteAssistancePartner>(remoteAssistancePartnerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRemoteAssistancePartnerRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRemoteAssistancePartnerRequest Expand(Expression<Func<RemoteAssistancePartner, object>> expandExpression)
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
        public IRemoteAssistancePartnerRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IRemoteAssistancePartnerRequest Select(Expression<Func<RemoteAssistancePartner, object>> selectExpression)
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
        /// <param name="remoteAssistancePartnerToInitialize">The <see cref="RemoteAssistancePartner"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(RemoteAssistancePartner remoteAssistancePartnerToInitialize)
        {

        }
    }
}
