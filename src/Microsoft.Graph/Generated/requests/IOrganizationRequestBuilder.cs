// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IOrganizationRequestBuilder.
    /// </summary>
    public partial interface IOrganizationRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IOrganizationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IOrganizationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for CertificateBasedAuthConfiguration.
        /// </summary>
        /// <returns>The <see cref="IOrganizationCertificateBasedAuthConfigurationCollectionWithReferencesRequestBuilder"/>.</returns>
        IOrganizationCertificateBasedAuthConfigurationCollectionWithReferencesRequestBuilder CertificateBasedAuthConfiguration { get; }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IOrganizationExtensionsCollectionRequestBuilder"/>.</returns>
        IOrganizationExtensionsCollectionRequestBuilder Extensions { get; }
    
        /// <summary>
        /// Gets the request builder for OrganizationSetMobileDeviceManagementAuthority.
        /// </summary>
        /// <returns>The <see cref="IOrganizationSetMobileDeviceManagementAuthorityRequestBuilder"/>.</returns>
        IOrganizationSetMobileDeviceManagementAuthorityRequestBuilder SetMobileDeviceManagementAuthority();
    
    }
}
