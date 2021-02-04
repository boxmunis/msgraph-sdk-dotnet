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
    /// The type TargetedManagedAppConfigurationRequest.
    /// </summary>
    public partial class TargetedManagedAppConfigurationRequest : BaseRequest, ITargetedManagedAppConfigurationRequest
    {
        /// <summary>
        /// Constructs a new TargetedManagedAppConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TargetedManagedAppConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TargetedManagedAppConfiguration using POST.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToCreate">The TargetedManagedAppConfiguration to create.</param>
        /// <returns>The created TargetedManagedAppConfiguration.</returns>
        public System.Threading.Tasks.Task<TargetedManagedAppConfiguration> CreateAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToCreate)
        {
            return this.CreateAsync(targetedManagedAppConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TargetedManagedAppConfiguration using POST.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToCreate">The TargetedManagedAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TargetedManagedAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<TargetedManagedAppConfiguration> CreateAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<TargetedManagedAppConfiguration>(targetedManagedAppConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TargetedManagedAppConfiguration using POST and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToCreate">The TargetedManagedAppConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> CreateResponseAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToCreate)
        {
            return this.CreateResponseAsync(targetedManagedAppConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TargetedManagedAppConfiguration using POST and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToCreate">The TargetedManagedAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> CreateResponseAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<TargetedManagedAppConfiguration>(targetedManagedAppConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<TargetedManagedAppConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified TargetedManagedAppConfiguration.
        /// </summary>
        /// <returns>The TargetedManagedAppConfiguration.</returns>
        public System.Threading.Tasks.Task<TargetedManagedAppConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TargetedManagedAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TargetedManagedAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<TargetedManagedAppConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<TargetedManagedAppConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified TargetedManagedAppConfiguration using PATCH.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToUpdate">The TargetedManagedAppConfiguration to update.</param>
        /// <returns>The updated TargetedManagedAppConfiguration.</returns>
        public System.Threading.Tasks.Task<TargetedManagedAppConfiguration> UpdateAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToUpdate)
        {
            return this.UpdateAsync(targetedManagedAppConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TargetedManagedAppConfiguration using PATCH.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToUpdate">The TargetedManagedAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TargetedManagedAppConfiguration.</returns>
        public async System.Threading.Tasks.Task<TargetedManagedAppConfiguration> UpdateAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (targetedManagedAppConfigurationToUpdate.AdditionalData != null)
			{
				if (targetedManagedAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					targetedManagedAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, targetedManagedAppConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (targetedManagedAppConfigurationToUpdate.AdditionalData != null)
            {
                if (targetedManagedAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    targetedManagedAppConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, targetedManagedAppConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<TargetedManagedAppConfiguration>(targetedManagedAppConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITargetedManagedAppConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITargetedManagedAppConfigurationRequest Expand(Expression<Func<TargetedManagedAppConfiguration, object>> expandExpression)
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
        public ITargetedManagedAppConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITargetedManagedAppConfigurationRequest Select(Expression<Func<TargetedManagedAppConfiguration, object>> selectExpression)
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
        /// <param name="targetedManagedAppConfigurationToInitialize">The <see cref="TargetedManagedAppConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TargetedManagedAppConfiguration targetedManagedAppConfigurationToInitialize)
        {

            if (targetedManagedAppConfigurationToInitialize != null && targetedManagedAppConfigurationToInitialize.AdditionalData != null)
            {

                if (targetedManagedAppConfigurationToInitialize.Apps != null && targetedManagedAppConfigurationToInitialize.Apps.CurrentPage != null)
                {
                    targetedManagedAppConfigurationToInitialize.Apps.AdditionalData = targetedManagedAppConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    targetedManagedAppConfigurationToInitialize.AdditionalData.TryGetValue("apps@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        targetedManagedAppConfigurationToInitialize.Apps.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (targetedManagedAppConfigurationToInitialize.Assignments != null && targetedManagedAppConfigurationToInitialize.Assignments.CurrentPage != null)
                {
                    targetedManagedAppConfigurationToInitialize.Assignments.AdditionalData = targetedManagedAppConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    targetedManagedAppConfigurationToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        targetedManagedAppConfigurationToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
