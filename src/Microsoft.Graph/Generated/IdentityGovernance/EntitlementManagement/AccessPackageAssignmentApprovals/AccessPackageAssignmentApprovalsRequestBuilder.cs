using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals.Count;
using MicrosoftGraphSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals.FilterByCurrentUserWithOn;
using MicrosoftGraphSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals.Item;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals {
    /// <summary>Provides operations to manage the accessPackageAssignmentApprovals property of the microsoft.graph.entitlementManagement entity.</summary>
    public class AccessPackageAssignmentApprovalsRequestBuilder {
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Gets an item from the MicrosoftGraphSdk.identityGovernance.entitlementManagement.accessPackageAssignmentApprovals.item collection</summary>
        public ApprovalItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("approval_id", position);
            return new ApprovalItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new AccessPackageAssignmentApprovalsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AccessPackageAssignmentApprovalsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignmentApprovals{?top,skip,search,filter,count,orderby,select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new AccessPackageAssignmentApprovalsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AccessPackageAssignmentApprovalsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignmentApprovals{?top,skip,search,filter,count,orderby,select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Approval stages for assignment requests.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to accessPackageAssignmentApprovals for identityGovernance
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.Approval body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the filterByCurrentUser method.
        /// <param name="on">Usage: on='{on}'</param>
        /// </summary>
        public FilterByCurrentUserWithOnRequestBuilder FilterByCurrentUserWithOn(string on) {
            if(string.IsNullOrEmpty(on)) throw new ArgumentNullException(nameof(on));
            return new FilterByCurrentUserWithOnRequestBuilder(PathParameters, RequestAdapter, on);
        }
        /// <summary>
        /// Approval stages for assignment requests.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApprovalCollectionResponse> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ApprovalCollectionResponse>(requestInfo, ApprovalCollectionResponse.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Create new navigation property to accessPackageAssignmentApprovals for identityGovernance
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.Approval> PostAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.Approval body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePostRequestInformation(body, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.Approval>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.Approval.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Approval stages for assignment requests.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Include count of items</summary>
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Filter items by property values</summary>
            public string Filter { get; set; }
            /// <summary>Order items by property values</summary>
            public string[] Orderby { get; set; }
            /// <summary>Search items by search phrases</summary>
            public string Search { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
            /// <summary>Skip the first n items</summary>
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            public int? Top { get; set; }
        }
    }
}