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
    /// The type Win32LobAppRequest.
    /// </summary>
    public partial class Win32LobAppRequest : BaseRequest, IWin32LobAppRequest
    {
        /// <summary>
        /// Constructs a new Win32LobAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Win32LobAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Win32LobApp using POST.
        /// </summary>
        /// <param name="win32LobAppToCreate">The Win32LobApp to create.</param>
        /// <returns>The created Win32LobApp.</returns>
        public System.Threading.Tasks.Task<Win32LobApp> CreateAsync(Win32LobApp win32LobAppToCreate)
        {
            return this.CreateAsync(win32LobAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Win32LobApp using POST.
        /// </summary>
        /// <param name="win32LobAppToCreate">The Win32LobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Win32LobApp.</returns>
        public async System.Threading.Tasks.Task<Win32LobApp> CreateAsync(Win32LobApp win32LobAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Win32LobApp>(win32LobAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Win32LobApp using POST and returns a <see cref="GraphResponse{Win32LobApp}"/> object.
        /// </summary>
        /// <param name="win32LobAppToCreate">The Win32LobApp to create.</param>
        /// <returns>The <see cref="GraphResponse{Win32LobApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Win32LobApp>> CreateResponseAsync(Win32LobApp win32LobAppToCreate)
        {
            return this.CreateResponseAsync(win32LobAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Win32LobApp using POST and returns a <see cref="GraphResponse{Win32LobApp}"/> object.
        /// </summary>
        /// <param name="win32LobAppToCreate">The Win32LobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Win32LobApp}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Win32LobApp>> CreateResponseAsync(Win32LobApp win32LobAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Win32LobApp>(win32LobAppToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Win32LobApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Win32LobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Win32LobApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Win32LobApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Win32LobApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Win32LobApp.
        /// </summary>
        /// <returns>The Win32LobApp.</returns>
        public System.Threading.Tasks.Task<Win32LobApp> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Win32LobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Win32LobApp.</returns>
        public async System.Threading.Tasks.Task<Win32LobApp> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Win32LobApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Win32LobApp using PATCH.
        /// </summary>
        /// <param name="win32LobAppToUpdate">The Win32LobApp to update.</param>
        /// <returns>The updated Win32LobApp.</returns>
        public System.Threading.Tasks.Task<Win32LobApp> UpdateAsync(Win32LobApp win32LobAppToUpdate)
        {
            return this.UpdateAsync(win32LobAppToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Win32LobApp using PATCH.
        /// </summary>
        /// <param name="win32LobAppToUpdate">The Win32LobApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Win32LobApp.</returns>
        public async System.Threading.Tasks.Task<Win32LobApp> UpdateAsync(Win32LobApp win32LobAppToUpdate, CancellationToken cancellationToken)
        {
			if (win32LobAppToUpdate.AdditionalData != null)
			{
				if (win32LobAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					win32LobAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, win32LobAppToUpdate.GetType().Name)
						});
				}
			}
            if (win32LobAppToUpdate.AdditionalData != null)
            {
                if (win32LobAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    win32LobAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, win32LobAppToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Win32LobApp>(win32LobAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWin32LobAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWin32LobAppRequest Expand(Expression<Func<Win32LobApp, object>> expandExpression)
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
        public IWin32LobAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWin32LobAppRequest Select(Expression<Func<Win32LobApp, object>> selectExpression)
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
        /// <param name="win32LobAppToInitialize">The <see cref="Win32LobApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Win32LobApp win32LobAppToInitialize)
        {

        }
    }
}
