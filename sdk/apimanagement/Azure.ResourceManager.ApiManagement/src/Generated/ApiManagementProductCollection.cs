// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementProductResource" /> and their operations.
    /// Each <see cref="ApiManagementProductResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementProductCollection" /> instance call the GetApiManagementProducts method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementProductCollection : ArmCollection, IEnumerable<ApiManagementProductResource>, IAsyncEnumerable<ApiManagementProductResource>
    {
        private readonly ClientDiagnostics _apiManagementProductProductClientDiagnostics;
        private readonly ProductRestOperations _apiManagementProductProductRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementProductCollection"/> class for mocking. </summary>
        protected ApiManagementProductCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementProductCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementProductCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementProductProductClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementProductResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementProductResource.ResourceType, out string apiManagementProductProductApiVersion);
            _apiManagementProductProductRestClient = new ProductRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementProductProductApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or Updates a product.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}
        /// Operation Id: Product_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementProductResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string productId, ApiManagementProductData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementProductProductClientDiagnostics.CreateScope("ApiManagementProductCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementProductProductRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementProductResource>(Response.FromValue(new ApiManagementProductResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or Updates a product.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}
        /// Operation Id: Product_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementProductResource> CreateOrUpdate(WaitUntil waitUntil, string productId, ApiManagementProductData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementProductProductClientDiagnostics.CreateScope("ApiManagementProductCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementProductProductRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementProductResource>(Response.FromValue(new ApiManagementProductResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the product specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}
        /// Operation Id: Product_Get
        /// </summary>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementProductResource>> GetAsync(string productId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));

            using var scope = _apiManagementProductProductClientDiagnostics.CreateScope("ApiManagementProductCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementProductProductRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the product specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}
        /// Operation Id: Product_Get
        /// </summary>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> is null. </exception>
        public virtual Response<ApiManagementProductResource> Get(string productId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));

            using var scope = _apiManagementProductProductClientDiagnostics.CreateScope("ApiManagementProductCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementProductProductRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of products in the specified service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products
        /// Operation Id: Product_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| terms | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;| groups | expand |     |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="expandGroups"> When set to true, the response contains an array of groups that have visibility to the product. The default is false. </param>
        /// <param name="tags"> Products which are part of a specific tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementProductResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementProductResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, bool? expandGroups = null, string tags = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ApiManagementProductResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiManagementProductProductClientDiagnostics.CreateScope("ApiManagementProductCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiManagementProductProductRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, expandGroups, tags, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementProductResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiManagementProductResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiManagementProductProductClientDiagnostics.CreateScope("ApiManagementProductCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiManagementProductProductRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, expandGroups, tags, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementProductResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists a collection of products in the specified service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products
        /// Operation Id: Product_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| terms | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;| groups | expand |     |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="expandGroups"> When set to true, the response contains an array of groups that have visibility to the product. The default is false. </param>
        /// <param name="tags"> Products which are part of a specific tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementProductResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementProductResource> GetAll(string filter = null, int? top = null, int? skip = null, bool? expandGroups = null, string tags = null, CancellationToken cancellationToken = default)
        {
            Page<ApiManagementProductResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiManagementProductProductClientDiagnostics.CreateScope("ApiManagementProductCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiManagementProductProductRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, expandGroups, tags, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementProductResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiManagementProductResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiManagementProductProductClientDiagnostics.CreateScope("ApiManagementProductCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiManagementProductProductRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, expandGroups, tags, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementProductResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}
        /// Operation Id: Product_Get
        /// </summary>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string productId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));

            using var scope = _apiManagementProductProductClientDiagnostics.CreateScope("ApiManagementProductCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementProductProductRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}
        /// Operation Id: Product_Get
        /// </summary>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> is null. </exception>
        public virtual Response<bool> Exists(string productId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));

            using var scope = _apiManagementProductProductClientDiagnostics.CreateScope("ApiManagementProductCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementProductProductRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, productId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementProductResource> IEnumerable<ApiManagementProductResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementProductResource> IAsyncEnumerable<ApiManagementProductResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
