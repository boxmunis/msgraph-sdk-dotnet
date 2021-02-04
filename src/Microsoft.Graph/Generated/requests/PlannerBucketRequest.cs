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
    /// The type PlannerBucketRequest.
    /// </summary>
    public partial class PlannerBucketRequest : BaseRequest, IPlannerBucketRequest
    {
        /// <summary>
        /// Constructs a new PlannerBucketRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PlannerBucketRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PlannerBucket using POST.
        /// </summary>
        /// <param name="plannerBucketToCreate">The PlannerBucket to create.</param>
        /// <returns>The created PlannerBucket.</returns>
        public System.Threading.Tasks.Task<PlannerBucket> CreateAsync(PlannerBucket plannerBucketToCreate)
        {
            return this.CreateAsync(plannerBucketToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PlannerBucket using POST.
        /// </summary>
        /// <param name="plannerBucketToCreate">The PlannerBucket to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerBucket.</returns>
        public async System.Threading.Tasks.Task<PlannerBucket> CreateAsync(PlannerBucket plannerBucketToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<PlannerBucket>(plannerBucketToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PlannerBucket using POST and returns a <see cref="GraphResponse{PlannerBucket}"/> object.
        /// </summary>
        /// <param name="plannerBucketToCreate">The PlannerBucket to create.</param>
        /// <returns>The <see cref="GraphResponse{PlannerBucket}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PlannerBucket>> CreateResponseAsync(PlannerBucket plannerBucketToCreate)
        {
            return this.CreateResponseAsync(plannerBucketToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PlannerBucket using POST and returns a <see cref="GraphResponse{PlannerBucket}"/> object.
        /// </summary>
        /// <param name="plannerBucketToCreate">The PlannerBucket to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerBucket}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PlannerBucket>> CreateResponseAsync(PlannerBucket plannerBucketToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<PlannerBucket>(plannerBucketToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PlannerBucket.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PlannerBucket.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<PlannerBucket>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PlannerBucket and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PlannerBucket and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified PlannerBucket.
        /// </summary>
        /// <returns>The PlannerBucket.</returns>
        public System.Threading.Tasks.Task<PlannerBucket> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PlannerBucket.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerBucket.</returns>
        public async System.Threading.Tasks.Task<PlannerBucket> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<PlannerBucket>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified PlannerBucket using PATCH.
        /// </summary>
        /// <param name="plannerBucketToUpdate">The PlannerBucket to update.</param>
        /// <returns>The updated PlannerBucket.</returns>
        public System.Threading.Tasks.Task<PlannerBucket> UpdateAsync(PlannerBucket plannerBucketToUpdate)
        {
            return this.UpdateAsync(plannerBucketToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PlannerBucket using PATCH.
        /// </summary>
        /// <param name="plannerBucketToUpdate">The PlannerBucket to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerBucket.</returns>
        public async System.Threading.Tasks.Task<PlannerBucket> UpdateAsync(PlannerBucket plannerBucketToUpdate, CancellationToken cancellationToken)
        {
			if (plannerBucketToUpdate.AdditionalData != null)
			{
				if (plannerBucketToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					plannerBucketToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, plannerBucketToUpdate.GetType().Name)
						});
				}
			}
            if (plannerBucketToUpdate.AdditionalData != null)
            {
                if (plannerBucketToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    plannerBucketToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, plannerBucketToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<PlannerBucket>(plannerBucketToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerBucketRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerBucketRequest Expand(Expression<Func<PlannerBucket, object>> expandExpression)
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
        public IPlannerBucketRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerBucketRequest Select(Expression<Func<PlannerBucket, object>> selectExpression)
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
        /// <param name="plannerBucketToInitialize">The <see cref="PlannerBucket"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PlannerBucket plannerBucketToInitialize)
        {

            if (plannerBucketToInitialize != null && plannerBucketToInitialize.AdditionalData != null)
            {

                if (plannerBucketToInitialize.Tasks != null && plannerBucketToInitialize.Tasks.CurrentPage != null)
                {
                    plannerBucketToInitialize.Tasks.AdditionalData = plannerBucketToInitialize.AdditionalData;

                    object nextPageLink;
                    plannerBucketToInitialize.AdditionalData.TryGetValue("tasks@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        plannerBucketToInitialize.Tasks.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
