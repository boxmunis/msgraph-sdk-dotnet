using Microsoft.Kiota.Abstractions;
using MicrosoftGraphSdk.Users.Item.Insights.Used.Item.Resource.PrintJob.Abort;
using MicrosoftGraphSdk.Users.Item.Insights.Used.Item.Resource.PrintJob.Cancel;
using MicrosoftGraphSdk.Users.Item.Insights.Used.Item.Resource.PrintJob.Redirect;
using MicrosoftGraphSdk.Users.Item.Insights.Used.Item.Resource.PrintJob.Start;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Users.Item.Insights.Used.Item.Resource.PrintJob {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\used\{usedInsight-id}\resource\microsoft.graph.printJob</summary>
    public class PrintJobRequestBuilder {
        public AbortRequestBuilder Abort { get =>
            new AbortRequestBuilder(PathParameters, RequestAdapter);
        }
        public CancelRequestBuilder Cancel { get =>
            new CancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public RedirectRequestBuilder Redirect { get =>
            new RedirectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public StartRequestBuilder Start { get =>
            new StartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new PrintJobRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public PrintJobRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/used/{usedInsight_id}/resource/microsoft.graph.printJob";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new PrintJobRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public PrintJobRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/used/{usedInsight_id}/resource/microsoft.graph.printJob";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
