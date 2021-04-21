// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AccessReviewInstanceBatchRecordDecisionsRequestBuilder.
    /// </summary>
    public partial class AccessReviewInstanceBatchRecordDecisionsRequestBuilder : BaseActionMethodRequestBuilder<IAccessReviewInstanceBatchRecordDecisionsRequest>, IAccessReviewInstanceBatchRecordDecisionsRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="AccessReviewInstanceBatchRecordDecisionsRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="decision">A decision parameter for the OData method call.</param>
        /// <param name="justification">A justification parameter for the OData method call.</param>
        /// <param name="principalId">A principalId parameter for the OData method call.</param>
        /// <param name="resourceId">A resourceId parameter for the OData method call.</param>
        public AccessReviewInstanceBatchRecordDecisionsRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string decision,
            string justification,
            string principalId,
            string resourceId)
            : base(requestUrl, client)
        {
            this.SetParameter("decision", decision, true);
            this.SetParameter("justification", justification, true);
            this.SetParameter("principalId", principalId, true);
            this.SetParameter("resourceId", resourceId, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IAccessReviewInstanceBatchRecordDecisionsRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new AccessReviewInstanceBatchRecordDecisionsRequest(functionUrl, this.Client, options);

            if (this.HasParameter("decision"))
            {
                request.RequestBody.Decision = this.GetParameter<string>("decision");
            }

            if (this.HasParameter("justification"))
            {
                request.RequestBody.Justification = this.GetParameter<string>("justification");
            }

            if (this.HasParameter("principalId"))
            {
                request.RequestBody.PrincipalId = this.GetParameter<string>("principalId");
            }

            if (this.HasParameter("resourceId"))
            {
                request.RequestBody.ResourceId = this.GetParameter<string>("resourceId");
            }

            return request;
        }
    }
}
