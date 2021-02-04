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
    /// The type WorkbookChartSeriesRequest.
    /// </summary>
    public partial class WorkbookChartSeriesRequest : BaseRequest, IWorkbookChartSeriesRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartSeriesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartSeriesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChartSeries using POST.
        /// </summary>
        /// <param name="workbookChartSeriesToCreate">The WorkbookChartSeries to create.</param>
        /// <returns>The created WorkbookChartSeries.</returns>
        public System.Threading.Tasks.Task<WorkbookChartSeries> CreateAsync(WorkbookChartSeries workbookChartSeriesToCreate)
        {
            return this.CreateAsync(workbookChartSeriesToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartSeries using POST.
        /// </summary>
        /// <param name="workbookChartSeriesToCreate">The WorkbookChartSeries to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartSeries.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartSeries> CreateAsync(WorkbookChartSeries workbookChartSeriesToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookChartSeries>(workbookChartSeriesToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WorkbookChartSeries using POST and returns a <see cref="GraphResponse{WorkbookChartSeries}"/> object.
        /// </summary>
        /// <param name="workbookChartSeriesToCreate">The WorkbookChartSeries to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartSeries}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeries>> CreateResponseAsync(WorkbookChartSeries workbookChartSeriesToCreate)
        {
            return this.CreateResponseAsync(workbookChartSeriesToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartSeries using POST and returns a <see cref="GraphResponse{WorkbookChartSeries}"/> object.
        /// </summary>
        /// <param name="workbookChartSeriesToCreate">The WorkbookChartSeries to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartSeries}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeries>> CreateResponseAsync(WorkbookChartSeries workbookChartSeriesToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WorkbookChartSeries>(workbookChartSeriesToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartSeries.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartSeries.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChartSeries>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartSeries and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartSeries and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChartSeries.
        /// </summary>
        /// <returns>The WorkbookChartSeries.</returns>
        public System.Threading.Tasks.Task<WorkbookChartSeries> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartSeries.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartSeries.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartSeries> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChartSeries>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChartSeries using PATCH.
        /// </summary>
        /// <param name="workbookChartSeriesToUpdate">The WorkbookChartSeries to update.</param>
        /// <returns>The updated WorkbookChartSeries.</returns>
        public System.Threading.Tasks.Task<WorkbookChartSeries> UpdateAsync(WorkbookChartSeries workbookChartSeriesToUpdate)
        {
            return this.UpdateAsync(workbookChartSeriesToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartSeries using PATCH.
        /// </summary>
        /// <param name="workbookChartSeriesToUpdate">The WorkbookChartSeries to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartSeries.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartSeries> UpdateAsync(WorkbookChartSeries workbookChartSeriesToUpdate, CancellationToken cancellationToken)
        {
			if (workbookChartSeriesToUpdate.AdditionalData != null)
			{
				if (workbookChartSeriesToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookChartSeriesToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartSeriesToUpdate.GetType().Name)
						});
				}
			}
            if (workbookChartSeriesToUpdate.AdditionalData != null)
            {
                if (workbookChartSeriesToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookChartSeriesToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartSeriesToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChartSeries>(workbookChartSeriesToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartSeriesRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartSeriesRequest Expand(Expression<Func<WorkbookChartSeries, object>> expandExpression)
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
        public IWorkbookChartSeriesRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartSeriesRequest Select(Expression<Func<WorkbookChartSeries, object>> selectExpression)
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
        /// <param name="workbookChartSeriesToInitialize">The <see cref="WorkbookChartSeries"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChartSeries workbookChartSeriesToInitialize)
        {

            if (workbookChartSeriesToInitialize != null && workbookChartSeriesToInitialize.AdditionalData != null)
            {

                if (workbookChartSeriesToInitialize.Points != null && workbookChartSeriesToInitialize.Points.CurrentPage != null)
                {
                    workbookChartSeriesToInitialize.Points.AdditionalData = workbookChartSeriesToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookChartSeriesToInitialize.AdditionalData.TryGetValue("points@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookChartSeriesToInitialize.Points.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
