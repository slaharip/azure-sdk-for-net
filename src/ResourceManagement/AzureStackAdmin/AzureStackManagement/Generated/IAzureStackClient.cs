// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.AzureStack.Management;

namespace Microsoft.AzureStack.Management
{
    public partial interface IAzureStackClient : IDisposable
    {
        /// <summary>
        /// Your documentation here.
        /// </summary>
        string ApiVersion
        {
            get; set; 
        }
        
        /// <summary>
        /// Your documentation here.
        /// </summary>
        Uri BaseUri
        {
            get; set; 
        }
        
        /// <summary>
        /// Your documentation here.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; set; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        ICloudOperations Clouds
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        ICurationOperations Curation
        {
            get; 
        }
        
        /// <summary>
        /// Operations for delegated offers.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IDelegatedOfferOperations DelegatedOffers
        {
            get; 
        }
        
        /// <summary>
        /// Operations for delegated provider configuration.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IDelegatedProviderConfigurationOperations DelegatedProviderConfiguration
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IEventTypesOperations EventTypes
        {
            get; 
        }
        
        /// <summary>
        /// Operations for extensions metadata.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IExtensionMetadataOperations ExtensionsMetadata
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IGalleryItemOperations GalleryItem
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IImportedSubscriptionOperations ImportedSubscriptions
        {
            get; 
        }
        
        /// <summary>
        /// Managed locations operations for admin.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IManagedLocationOperations ManagedLocations
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IManagedOfferOperations ManagedOffers
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IManagedPlanOperations ManagedPlans
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IManagedSubscriptionOperations ManagedSubscriptions
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IOfferOperations Offers
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IPackageOperations Package
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IPlanOperations Plans
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IProviderRegistrationOperations ProviderRegistrations
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IPublicGalleryItemOperations PublicGalleryItem
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IResourceGroupOperations ResourceGroups
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IResourceOperations Resources
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IResourceProviderOperations ResourceProviders
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IShallowResourceOperations ShallowResources
        {
            get; 
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        ISubscriptionOperations Subscriptions
        {
            get; 
        }
    }
}
