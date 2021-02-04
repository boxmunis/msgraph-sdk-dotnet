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
    /// The type IosStoreAppRequest.
    /// </summary>
    public partial class IosStoreAppRequest : BaseRequest, IIosStoreAppRequest
    {
        /// <summary>
        /// Constructs a new IosStoreAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosStoreAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosStoreApp using POST.
        /// </summary>
        /// <param name="iosStoreAppToCreate">The IosStoreApp to create.</param>
        /// <returns>The created IosStoreApp.</returns>
        public System.Threading.Tasks.Task<IosStoreApp> CreateAsync(IosStoreApp iosStoreAppToCreate)
        {
            return this.CreateAsync(iosStoreAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IosStoreApp using POST.
        /// </summary>
        /// <param name="iosStoreAppToCreate">The IosStoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosStoreApp.</returns>
        public async System.Threading.Tasks.Task<IosStoreApp> CreateAsync(IosStoreApp iosStoreAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<IosStoreApp>(iosStoreAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IosStoreApp using POST and returns a <see cref="GraphResponse{IosStoreApp}"/> object.
        /// </summary>
        /// <param name="iosStoreAppToCreate">The IosStoreApp to create.</param>
        /// <returns>The <see cref="GraphResponse{IosStoreApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosStoreApp>> CreateResponseAsync(IosStoreApp iosStoreAppToCreate)
        {
            return this.CreateResponseAsync(iosStoreAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IosStoreApp using POST and returns a <see cref="GraphResponse{IosStoreApp}"/> object.
        /// </summary>
        /// <param name="iosStoreAppToCreate">The IosStoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosStoreApp}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<IosStoreApp>> CreateResponseAsync(IosStoreApp iosStoreAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<IosStoreApp>(iosStoreAppToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosStoreApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IosStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<IosStoreApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosStoreApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IosStoreApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified IosStoreApp.
        /// </summary>
        /// <returns>The IosStoreApp.</returns>
        public System.Threading.Tasks.Task<IosStoreApp> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IosStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosStoreApp.</returns>
        public async System.Threading.Tasks.Task<IosStoreApp> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<IosStoreApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified IosStoreApp using PATCH.
        /// </summary>
        /// <param name="iosStoreAppToUpdate">The IosStoreApp to update.</param>
        /// <returns>The updated IosStoreApp.</returns>
        public System.Threading.Tasks.Task<IosStoreApp> UpdateAsync(IosStoreApp iosStoreAppToUpdate)
        {
            return this.UpdateAsync(iosStoreAppToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IosStoreApp using PATCH.
        /// </summary>
        /// <param name="iosStoreAppToUpdate">The IosStoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosStoreApp.</returns>
        public async System.Threading.Tasks.Task<IosStoreApp> UpdateAsync(IosStoreApp iosStoreAppToUpdate, CancellationToken cancellationToken)
        {
			if (iosStoreAppToUpdate.AdditionalData != null)
			{
				if (iosStoreAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					iosStoreAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosStoreAppToUpdate.GetType().Name)
						});
				}
			}
            if (iosStoreAppToUpdate.AdditionalData != null)
            {
                if (iosStoreAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    iosStoreAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosStoreAppToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<IosStoreApp>(iosStoreAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosStoreAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosStoreAppRequest Expand(Expression<Func<IosStoreApp, object>> expandExpression)
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
        public IIosStoreAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosStoreAppRequest Select(Expression<Func<IosStoreApp, object>> selectExpression)
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
        /// <param name="iosStoreAppToInitialize">The <see cref="IosStoreApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosStoreApp iosStoreAppToInitialize)
        {

        }
    }
}
