// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApiIssueAttachmentOperations.
    /// </summary>
    public static partial class ApiIssueAttachmentOperationsExtensions
    {
            /// <summary>
            /// Lists all attachments for the Issue associated with the specified API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='issueId'>
            /// Issue identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<IssueAttachmentContract> ListByService(this IApiIssueAttachmentOperations operations, string resourceGroupName, string serviceName, string apiId, string issueId, ODataQuery<IssueAttachmentContract> odataQuery = default(ODataQuery<IssueAttachmentContract>))
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, apiId, issueId, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all attachments for the Issue associated with the specified API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='issueId'>
            /// Issue identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IssueAttachmentContract>> ListByServiceAsync(this IApiIssueAttachmentOperations operations, string resourceGroupName, string serviceName, string apiId, string issueId, ODataQuery<IssueAttachmentContract> odataQuery = default(ODataQuery<IssueAttachmentContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, issueId, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the issue Attachment for an API
            /// specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='issueId'>
            /// Issue identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='attachmentId'>
            /// Attachment identifier within an Issue. Must be unique in the current Issue.
            /// </param>
            public static ApiIssueAttachmentGetEntityTagHeaders GetEntityTag(this IApiIssueAttachmentOperations operations, string resourceGroupName, string serviceName, string apiId, string issueId, string attachmentId)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, apiId, issueId, attachmentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the issue Attachment for an API
            /// specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='issueId'>
            /// Issue identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='attachmentId'>
            /// Attachment identifier within an Issue. Must be unique in the current Issue.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiIssueAttachmentGetEntityTagHeaders> GetEntityTagAsync(this IApiIssueAttachmentOperations operations, string resourceGroupName, string serviceName, string apiId, string issueId, string attachmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, issueId, attachmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the details of the issue Attachment for an API specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='issueId'>
            /// Issue identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='attachmentId'>
            /// Attachment identifier within an Issue. Must be unique in the current Issue.
            /// </param>
            public static IssueAttachmentContract Get(this IApiIssueAttachmentOperations operations, string resourceGroupName, string serviceName, string apiId, string issueId, string attachmentId)
            {
                return operations.GetAsync(resourceGroupName, serviceName, apiId, issueId, attachmentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the issue Attachment for an API specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='issueId'>
            /// Issue identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='attachmentId'>
            /// Attachment identifier within an Issue. Must be unique in the current Issue.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IssueAttachmentContract> GetAsync(this IApiIssueAttachmentOperations operations, string resourceGroupName, string serviceName, string apiId, string issueId, string attachmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, issueId, attachmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Attachment for the Issue in an API or updates an existing
            /// one.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='issueId'>
            /// Issue identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='attachmentId'>
            /// Attachment identifier within an Issue. Must be unique in the current Issue.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static IssueAttachmentContract CreateOrUpdate(this IApiIssueAttachmentOperations operations, string resourceGroupName, string serviceName, string apiId, string issueId, string attachmentId, IssueAttachmentContract parameters, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, apiId, issueId, attachmentId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Attachment for the Issue in an API or updates an existing
            /// one.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='issueId'>
            /// Issue identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='attachmentId'>
            /// Attachment identifier within an Issue. Must be unique in the current Issue.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IssueAttachmentContract> CreateOrUpdateAsync(this IApiIssueAttachmentOperations operations, string resourceGroupName, string serviceName, string apiId, string issueId, string attachmentId, IssueAttachmentContract parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, issueId, attachmentId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified comment from an Issue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='issueId'>
            /// Issue identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='attachmentId'>
            /// Attachment identifier within an Issue. Must be unique in the current Issue.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Delete(this IApiIssueAttachmentOperations operations, string resourceGroupName, string serviceName, string apiId, string issueId, string attachmentId, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, apiId, issueId, attachmentId, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified comment from an Issue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='issueId'>
            /// Issue identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='attachmentId'>
            /// Attachment identifier within an Issue. Must be unique in the current Issue.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApiIssueAttachmentOperations operations, string resourceGroupName, string serviceName, string apiId, string issueId, string attachmentId, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, issueId, attachmentId, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all attachments for the Issue associated with the specified API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IssueAttachmentContract> ListByServiceNext(this IApiIssueAttachmentOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all attachments for the Issue associated with the specified API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IssueAttachmentContract>> ListByServiceNextAsync(this IApiIssueAttachmentOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
