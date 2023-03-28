using Microsoft.Graph.DirectoryRoles.Item.Members.Item.GraphApplication;
using Microsoft.Graph.DirectoryRoles.Item.Members.Item.GraphDevice;
using Microsoft.Graph.DirectoryRoles.Item.Members.Item.GraphGroup;
using Microsoft.Graph.DirectoryRoles.Item.Members.Item.GraphOrgContact;
using Microsoft.Graph.DirectoryRoles.Item.Members.Item.GraphServicePrincipal;
using Microsoft.Graph.DirectoryRoles.Item.Members.Item.GraphUser;
using Microsoft.Graph.DirectoryRoles.Item.Members.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Microsoft.Graph.DirectoryRoles.Item.Members.Item {
    /// <summary>
    /// Builds and executes requests for operations under \directoryRoles\{directoryRole-id}\members\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Casts the previous resource to application.</summary>
        public GraphApplicationRequestBuilder GraphApplication { get =>
            new GraphApplicationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to device.</summary>
        public GraphDeviceRequestBuilder GraphDevice { get =>
            new GraphDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to group.</summary>
        public GraphGroupRequestBuilder GraphGroup { get =>
            new GraphGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to orgContact.</summary>
        public GraphOrgContactRequestBuilder GraphOrgContact { get =>
            new GraphOrgContactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to servicePrincipal.</summary>
        public GraphServicePrincipalRequestBuilder GraphServicePrincipal { get =>
            new GraphServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to user.</summary>
        public GraphUserRequestBuilder GraphUser { get =>
            new GraphUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of directoryRole entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directoryRoles/{directoryRole%2Did}/members/{directoryObject%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directoryRoles/{directoryRole%2Did}/members/{directoryObject%2Did}", rawUrl) {
        }
    }
}
