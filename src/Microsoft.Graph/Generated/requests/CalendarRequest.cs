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
    /// The type CalendarRequest.
    /// </summary>
    public partial class CalendarRequest : BaseRequest, ICalendarRequest
    {
        /// <summary>
        /// Constructs a new CalendarRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CalendarRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Calendar using POST.
        /// </summary>
        /// <param name="calendarToCreate">The Calendar to create.</param>
        /// <returns>The created Calendar.</returns>
        public System.Threading.Tasks.Task<Calendar> CreateAsync(Calendar calendarToCreate)
        {
            return this.CreateAsync(calendarToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Calendar using POST.
        /// </summary>
        /// <param name="calendarToCreate">The Calendar to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Calendar.</returns>
        public async System.Threading.Tasks.Task<Calendar> CreateAsync(Calendar calendarToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Calendar>(calendarToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Calendar using POST and returns a <see cref="GraphResponse{Calendar}"/> object.
        /// </summary>
        /// <param name="calendarToCreate">The Calendar to create.</param>
        /// <returns>The <see cref="GraphResponse{Calendar}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Calendar>> CreateResponseAsync(Calendar calendarToCreate)
        {
            return this.CreateResponseAsync(calendarToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Calendar using POST and returns a <see cref="GraphResponse{Calendar}"/> object.
        /// </summary>
        /// <param name="calendarToCreate">The Calendar to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Calendar}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Calendar>> CreateResponseAsync(Calendar calendarToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Calendar>(calendarToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Calendar.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Calendar.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Calendar>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Calendar and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Calendar and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Calendar.
        /// </summary>
        /// <returns>The Calendar.</returns>
        public System.Threading.Tasks.Task<Calendar> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Calendar.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Calendar.</returns>
        public async System.Threading.Tasks.Task<Calendar> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Calendar>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Calendar using PATCH.
        /// </summary>
        /// <param name="calendarToUpdate">The Calendar to update.</param>
        /// <returns>The updated Calendar.</returns>
        public System.Threading.Tasks.Task<Calendar> UpdateAsync(Calendar calendarToUpdate)
        {
            return this.UpdateAsync(calendarToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Calendar using PATCH.
        /// </summary>
        /// <param name="calendarToUpdate">The Calendar to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Calendar.</returns>
        public async System.Threading.Tasks.Task<Calendar> UpdateAsync(Calendar calendarToUpdate, CancellationToken cancellationToken)
        {
			if (calendarToUpdate.AdditionalData != null)
			{
				if (calendarToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					calendarToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, calendarToUpdate.GetType().Name)
						});
				}
			}
            if (calendarToUpdate.AdditionalData != null)
            {
                if (calendarToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    calendarToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, calendarToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Calendar>(calendarToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICalendarRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICalendarRequest Expand(Expression<Func<Calendar, object>> expandExpression)
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
        public ICalendarRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICalendarRequest Select(Expression<Func<Calendar, object>> selectExpression)
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
        /// <param name="calendarToInitialize">The <see cref="Calendar"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Calendar calendarToInitialize)
        {

            if (calendarToInitialize != null && calendarToInitialize.AdditionalData != null)
            {

                if (calendarToInitialize.CalendarPermissions != null && calendarToInitialize.CalendarPermissions.CurrentPage != null)
                {
                    calendarToInitialize.CalendarPermissions.AdditionalData = calendarToInitialize.AdditionalData;

                    object nextPageLink;
                    calendarToInitialize.AdditionalData.TryGetValue("calendarPermissions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        calendarToInitialize.CalendarPermissions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (calendarToInitialize.CalendarView != null && calendarToInitialize.CalendarView.CurrentPage != null)
                {
                    calendarToInitialize.CalendarView.AdditionalData = calendarToInitialize.AdditionalData;

                    object nextPageLink;
                    calendarToInitialize.AdditionalData.TryGetValue("calendarView@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        calendarToInitialize.CalendarView.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (calendarToInitialize.Events != null && calendarToInitialize.Events.CurrentPage != null)
                {
                    calendarToInitialize.Events.AdditionalData = calendarToInitialize.AdditionalData;

                    object nextPageLink;
                    calendarToInitialize.AdditionalData.TryGetValue("events@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        calendarToInitialize.Events.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (calendarToInitialize.MultiValueExtendedProperties != null && calendarToInitialize.MultiValueExtendedProperties.CurrentPage != null)
                {
                    calendarToInitialize.MultiValueExtendedProperties.AdditionalData = calendarToInitialize.AdditionalData;

                    object nextPageLink;
                    calendarToInitialize.AdditionalData.TryGetValue("multiValueExtendedProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        calendarToInitialize.MultiValueExtendedProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (calendarToInitialize.SingleValueExtendedProperties != null && calendarToInitialize.SingleValueExtendedProperties.CurrentPage != null)
                {
                    calendarToInitialize.SingleValueExtendedProperties.AdditionalData = calendarToInitialize.AdditionalData;

                    object nextPageLink;
                    calendarToInitialize.AdditionalData.TryGetValue("singleValueExtendedProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        calendarToInitialize.SingleValueExtendedProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
