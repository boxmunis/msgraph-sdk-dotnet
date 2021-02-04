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
    /// The type OnenoteOperationRequest.
    /// </summary>
    public partial class OnenoteOperationRequest : BaseRequest, IOnenoteOperationRequest
    {
        /// <summary>
        /// Constructs a new OnenoteOperationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OnenoteOperationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OnenoteOperation using POST.
        /// </summary>
        /// <param name="onenoteOperationToCreate">The OnenoteOperation to create.</param>
        /// <returns>The created OnenoteOperation.</returns>
        public System.Threading.Tasks.Task<OnenoteOperation> CreateAsync(OnenoteOperation onenoteOperationToCreate)
        {
            return this.CreateAsync(onenoteOperationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OnenoteOperation using POST.
        /// </summary>
        /// <param name="onenoteOperationToCreate">The OnenoteOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteOperation.</returns>
        public async System.Threading.Tasks.Task<OnenoteOperation> CreateAsync(OnenoteOperation onenoteOperationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OnenoteOperation>(onenoteOperationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OnenoteOperation using POST and returns a <see cref="GraphResponse{OnenoteOperation}"/> object.
        /// </summary>
        /// <param name="onenoteOperationToCreate">The OnenoteOperation to create.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnenoteOperation>> CreateResponseAsync(OnenoteOperation onenoteOperationToCreate)
        {
            return this.CreateResponseAsync(onenoteOperationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OnenoteOperation using POST and returns a <see cref="GraphResponse{OnenoteOperation}"/> object.
        /// </summary>
        /// <param name="onenoteOperationToCreate">The OnenoteOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteOperation}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OnenoteOperation>> CreateResponseAsync(OnenoteOperation onenoteOperationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<OnenoteOperation>(onenoteOperationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OnenoteOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OnenoteOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OnenoteOperation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OnenoteOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OnenoteOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OnenoteOperation.
        /// </summary>
        /// <returns>The OnenoteOperation.</returns>
        public System.Threading.Tasks.Task<OnenoteOperation> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OnenoteOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnenoteOperation.</returns>
        public async System.Threading.Tasks.Task<OnenoteOperation> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OnenoteOperation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified OnenoteOperation using PATCH.
        /// </summary>
        /// <param name="onenoteOperationToUpdate">The OnenoteOperation to update.</param>
        /// <returns>The updated OnenoteOperation.</returns>
        public System.Threading.Tasks.Task<OnenoteOperation> UpdateAsync(OnenoteOperation onenoteOperationToUpdate)
        {
            return this.UpdateAsync(onenoteOperationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OnenoteOperation using PATCH.
        /// </summary>
        /// <param name="onenoteOperationToUpdate">The OnenoteOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnenoteOperation.</returns>
        public async System.Threading.Tasks.Task<OnenoteOperation> UpdateAsync(OnenoteOperation onenoteOperationToUpdate, CancellationToken cancellationToken)
        {
			if (onenoteOperationToUpdate.AdditionalData != null)
			{
				if (onenoteOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					onenoteOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, onenoteOperationToUpdate.GetType().Name)
						});
				}
			}
            if (onenoteOperationToUpdate.AdditionalData != null)
            {
                if (onenoteOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    onenoteOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, onenoteOperationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OnenoteOperation>(onenoteOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteOperationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteOperationRequest Expand(Expression<Func<OnenoteOperation, object>> expandExpression)
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
        public IOnenoteOperationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteOperationRequest Select(Expression<Func<OnenoteOperation, object>> selectExpression)
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
        /// <param name="onenoteOperationToInitialize">The <see cref="OnenoteOperation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OnenoteOperation onenoteOperationToInitialize)
        {

        }
    }
}
