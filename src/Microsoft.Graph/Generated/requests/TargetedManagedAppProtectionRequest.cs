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
    /// The type TargetedManagedAppProtectionRequest.
    /// </summary>
    public partial class TargetedManagedAppProtectionRequest : BaseRequest, ITargetedManagedAppProtectionRequest
    {
        /// <summary>
        /// Constructs a new TargetedManagedAppProtectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TargetedManagedAppProtectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TargetedManagedAppProtection using POST.
        /// </summary>
        /// <param name="targetedManagedAppProtectionToCreate">The TargetedManagedAppProtection to create.</param>
        /// <returns>The created TargetedManagedAppProtection.</returns>
        public System.Threading.Tasks.Task<TargetedManagedAppProtection> CreateAsync(TargetedManagedAppProtection targetedManagedAppProtectionToCreate)
        {
            return this.CreateAsync(targetedManagedAppProtectionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TargetedManagedAppProtection using POST.
        /// </summary>
        /// <param name="targetedManagedAppProtectionToCreate">The TargetedManagedAppProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TargetedManagedAppProtection.</returns>
        public async System.Threading.Tasks.Task<TargetedManagedAppProtection> CreateAsync(TargetedManagedAppProtection targetedManagedAppProtectionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<TargetedManagedAppProtection>(targetedManagedAppProtectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TargetedManagedAppProtection using POST and returns a <see cref="GraphResponse{TargetedManagedAppProtection}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppProtectionToCreate">The TargetedManagedAppProtection to create.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppProtection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppProtection>> CreateResponseAsync(TargetedManagedAppProtection targetedManagedAppProtectionToCreate)
        {
            return this.CreateResponseAsync(targetedManagedAppProtectionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TargetedManagedAppProtection using POST and returns a <see cref="GraphResponse{TargetedManagedAppProtection}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppProtectionToCreate">The TargetedManagedAppProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppProtection}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppProtection>> CreateResponseAsync(TargetedManagedAppProtection targetedManagedAppProtectionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<TargetedManagedAppProtection>(targetedManagedAppProtectionToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TargetedManagedAppProtection.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TargetedManagedAppProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<TargetedManagedAppProtection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TargetedManagedAppProtection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TargetedManagedAppProtection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified TargetedManagedAppProtection.
        /// </summary>
        /// <returns>The TargetedManagedAppProtection.</returns>
        public System.Threading.Tasks.Task<TargetedManagedAppProtection> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TargetedManagedAppProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TargetedManagedAppProtection.</returns>
        public async System.Threading.Tasks.Task<TargetedManagedAppProtection> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<TargetedManagedAppProtection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified TargetedManagedAppProtection using PATCH.
        /// </summary>
        /// <param name="targetedManagedAppProtectionToUpdate">The TargetedManagedAppProtection to update.</param>
        /// <returns>The updated TargetedManagedAppProtection.</returns>
        public System.Threading.Tasks.Task<TargetedManagedAppProtection> UpdateAsync(TargetedManagedAppProtection targetedManagedAppProtectionToUpdate)
        {
            return this.UpdateAsync(targetedManagedAppProtectionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TargetedManagedAppProtection using PATCH.
        /// </summary>
        /// <param name="targetedManagedAppProtectionToUpdate">The TargetedManagedAppProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TargetedManagedAppProtection.</returns>
        public async System.Threading.Tasks.Task<TargetedManagedAppProtection> UpdateAsync(TargetedManagedAppProtection targetedManagedAppProtectionToUpdate, CancellationToken cancellationToken)
        {
			if (targetedManagedAppProtectionToUpdate.AdditionalData != null)
			{
				if (targetedManagedAppProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					targetedManagedAppProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, targetedManagedAppProtectionToUpdate.GetType().Name)
						});
				}
			}
            if (targetedManagedAppProtectionToUpdate.AdditionalData != null)
            {
                if (targetedManagedAppProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    targetedManagedAppProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, targetedManagedAppProtectionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<TargetedManagedAppProtection>(targetedManagedAppProtectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITargetedManagedAppProtectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITargetedManagedAppProtectionRequest Expand(Expression<Func<TargetedManagedAppProtection, object>> expandExpression)
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
        public ITargetedManagedAppProtectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITargetedManagedAppProtectionRequest Select(Expression<Func<TargetedManagedAppProtection, object>> selectExpression)
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
        /// <param name="targetedManagedAppProtectionToInitialize">The <see cref="TargetedManagedAppProtection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TargetedManagedAppProtection targetedManagedAppProtectionToInitialize)
        {

            if (targetedManagedAppProtectionToInitialize != null && targetedManagedAppProtectionToInitialize.AdditionalData != null)
            {

                if (targetedManagedAppProtectionToInitialize.Assignments != null && targetedManagedAppProtectionToInitialize.Assignments.CurrentPage != null)
                {
                    targetedManagedAppProtectionToInitialize.Assignments.AdditionalData = targetedManagedAppProtectionToInitialize.AdditionalData;

                    object nextPageLink;
                    targetedManagedAppProtectionToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        targetedManagedAppProtectionToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
