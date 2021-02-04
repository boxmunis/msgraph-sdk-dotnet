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
    /// The type WorkbookPivotTableRequest.
    /// </summary>
    public partial class WorkbookPivotTableRequest : BaseRequest, IWorkbookPivotTableRequest
    {
        /// <summary>
        /// Constructs a new WorkbookPivotTableRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookPivotTableRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookPivotTable using POST.
        /// </summary>
        /// <param name="workbookPivotTableToCreate">The WorkbookPivotTable to create.</param>
        /// <returns>The created WorkbookPivotTable.</returns>
        public System.Threading.Tasks.Task<WorkbookPivotTable> CreateAsync(WorkbookPivotTable workbookPivotTableToCreate)
        {
            return this.CreateAsync(workbookPivotTableToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookPivotTable using POST.
        /// </summary>
        /// <param name="workbookPivotTableToCreate">The WorkbookPivotTable to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookPivotTable.</returns>
        public async System.Threading.Tasks.Task<WorkbookPivotTable> CreateAsync(WorkbookPivotTable workbookPivotTableToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookPivotTable>(workbookPivotTableToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WorkbookPivotTable using POST and returns a <see cref="GraphResponse{WorkbookPivotTable}"/> object.
        /// </summary>
        /// <param name="workbookPivotTableToCreate">The WorkbookPivotTable to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookPivotTable}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookPivotTable>> CreateResponseAsync(WorkbookPivotTable workbookPivotTableToCreate)
        {
            return this.CreateResponseAsync(workbookPivotTableToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookPivotTable using POST and returns a <see cref="GraphResponse{WorkbookPivotTable}"/> object.
        /// </summary>
        /// <param name="workbookPivotTableToCreate">The WorkbookPivotTable to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookPivotTable}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookPivotTable>> CreateResponseAsync(WorkbookPivotTable workbookPivotTableToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WorkbookPivotTable>(workbookPivotTableToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookPivotTable.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookPivotTable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookPivotTable>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookPivotTable and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookPivotTable and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookPivotTable.
        /// </summary>
        /// <returns>The WorkbookPivotTable.</returns>
        public System.Threading.Tasks.Task<WorkbookPivotTable> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookPivotTable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookPivotTable.</returns>
        public async System.Threading.Tasks.Task<WorkbookPivotTable> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookPivotTable>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookPivotTable using PATCH.
        /// </summary>
        /// <param name="workbookPivotTableToUpdate">The WorkbookPivotTable to update.</param>
        /// <returns>The updated WorkbookPivotTable.</returns>
        public System.Threading.Tasks.Task<WorkbookPivotTable> UpdateAsync(WorkbookPivotTable workbookPivotTableToUpdate)
        {
            return this.UpdateAsync(workbookPivotTableToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookPivotTable using PATCH.
        /// </summary>
        /// <param name="workbookPivotTableToUpdate">The WorkbookPivotTable to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookPivotTable.</returns>
        public async System.Threading.Tasks.Task<WorkbookPivotTable> UpdateAsync(WorkbookPivotTable workbookPivotTableToUpdate, CancellationToken cancellationToken)
        {
			if (workbookPivotTableToUpdate.AdditionalData != null)
			{
				if (workbookPivotTableToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookPivotTableToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookPivotTableToUpdate.GetType().Name)
						});
				}
			}
            if (workbookPivotTableToUpdate.AdditionalData != null)
            {
                if (workbookPivotTableToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookPivotTableToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookPivotTableToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookPivotTable>(workbookPivotTableToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookPivotTableRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookPivotTableRequest Expand(Expression<Func<WorkbookPivotTable, object>> expandExpression)
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
        public IWorkbookPivotTableRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookPivotTableRequest Select(Expression<Func<WorkbookPivotTable, object>> selectExpression)
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
        /// <param name="workbookPivotTableToInitialize">The <see cref="WorkbookPivotTable"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookPivotTable workbookPivotTableToInitialize)
        {

        }
    }
}
