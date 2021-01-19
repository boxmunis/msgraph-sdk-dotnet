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
    /// The type WorkbookFunctionsNominalRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsNominalRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsNominalRequest>, IWorkbookFunctionsNominalRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsNominalRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="effectRate">A effectRate parameter for the OData method call.</param>
        /// <param name="npery">A npery parameter for the OData method call.</param>
        public WorkbookFunctionsNominalRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken effectRate,
            Newtonsoft.Json.Linq.JToken npery)
            : base(requestUrl, client)
        {
            this.SetParameter("effectRate", effectRate, true);
            this.SetParameter("npery", npery, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsNominalRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsNominalRequest(functionUrl, this.Client, options);

            if (this.HasParameter("effectRate"))
            {
                request.RequestBody.EffectRate = this.GetParameter<Newtonsoft.Json.Linq.JToken>("effectRate");
            }

            if (this.HasParameter("npery"))
            {
                request.RequestBody.Npery = this.GetParameter<Newtonsoft.Json.Linq.JToken>("npery");
            }

            return request;
        }
    }
}
