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
    /// The type WorkbookRangeFontRequest.
    /// </summary>
    public partial class WorkbookRangeFontRequest : BaseRequest, IWorkbookRangeFontRequest
    {
        /// <summary>
        /// Constructs a new WorkbookRangeFontRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookRangeFontRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFont using POST.
        /// </summary>
        /// <param name="workbookRangeFontToCreate">The WorkbookRangeFont to create.</param>
        /// <returns>The created WorkbookRangeFont.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeFont> CreateAsync(WorkbookRangeFont workbookRangeFontToCreate)
        {
            return this.CreateAsync(workbookRangeFontToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFont using POST.
        /// </summary>
        /// <param name="workbookRangeFontToCreate">The WorkbookRangeFont to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRangeFont.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFont> CreateAsync(WorkbookRangeFont workbookRangeFontToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookRangeFont>(workbookRangeFontToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFont.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFont.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookRangeFont>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookRangeFont.
        /// </summary>
        /// <returns>The WorkbookRangeFont.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeFont> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookRangeFont.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRangeFont.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFont> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookRangeFont>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFont using PATCH.
        /// </summary>
        /// <param name="workbookRangeFontToUpdate">The WorkbookRangeFont to update.</param>
        /// <returns>The updated WorkbookRangeFont.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeFont> UpdateAsync(WorkbookRangeFont workbookRangeFontToUpdate)
        {
            return this.UpdateAsync(workbookRangeFontToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFont using PATCH.
        /// </summary>
        /// <param name="workbookRangeFontToUpdate">The WorkbookRangeFont to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookRangeFont.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFont> UpdateAsync(WorkbookRangeFont workbookRangeFontToUpdate, CancellationToken cancellationToken)
        {
			if (workbookRangeFontToUpdate.AdditionalData != null)
			{
				if (workbookRangeFontToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookRangeFontToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookRangeFontToUpdate.GetType().Name)
						});
				}
			}
            if (workbookRangeFontToUpdate.AdditionalData != null)
            {
                if (workbookRangeFontToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookRangeFontToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookRangeFontToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookRangeFont>(workbookRangeFontToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFontRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFontRequest Expand(Expression<Func<WorkbookRangeFont, object>> expandExpression)
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
        public IWorkbookRangeFontRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFontRequest Select(Expression<Func<WorkbookRangeFont, object>> selectExpression)
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
        /// <param name="workbookRangeFontToInitialize">The <see cref="WorkbookRangeFont"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookRangeFont workbookRangeFontToInitialize)
        {

        }
    }
}
