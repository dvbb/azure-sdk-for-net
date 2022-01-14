// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Extensions
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExtensionsOperations.
    /// </summary>
    public static partial class ExtensionsOperationsExtensions
    {
            /// <summary>
            /// Create a new Kubernetes Cluster Extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='extension'>
            /// Properties necessary to Create an Extension.
            /// </param>
            public static Extension Create(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, Extension extension)
            {
                return operations.CreateAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, extension).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new Kubernetes Cluster Extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='extension'>
            /// Properties necessary to Create an Extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Extension> CreateAsync(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, Extension extension, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, extension, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets Kubernetes Cluster Extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            public static Extension Get(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName)
            {
                return operations.GetAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets Kubernetes Cluster Extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Extension> GetAsync(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Kubernetes Cluster Extension. This will cause the Agent to
            /// Uninstall the extension from the cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='forceDelete'>
            /// Delete the extension resource in Azure - not the normal asynchronous
            /// delete.
            /// </param>
            public static void Delete(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, bool? forceDelete = default(bool?))
            {
                operations.DeleteAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, forceDelete).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Kubernetes Cluster Extension. This will cause the Agent to
            /// Uninstall the extension from the cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='forceDelete'>
            /// Delete the extension resource in Azure - not the normal asynchronous
            /// delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, bool? forceDelete = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, forceDelete, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Patch an existing Kubernetes Cluster Extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='patchExtension'>
            /// Properties to Patch in an existing Extension.
            /// </param>
            public static Extension Update(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, PatchExtension patchExtension)
            {
                return operations.UpdateAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, patchExtension).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch an existing Kubernetes Cluster Extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='patchExtension'>
            /// Properties to Patch in an existing Extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Extension> UpdateAsync(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, PatchExtension patchExtension, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, patchExtension, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all Extensions in the cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            public static IPage<Extension> List(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName)
            {
                return operations.ListAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all Extensions in the cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Extension>> ListAsync(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new Kubernetes Cluster Extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='extension'>
            /// Properties necessary to Create an Extension.
            /// </param>
            public static Extension BeginCreate(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, Extension extension)
            {
                return operations.BeginCreateAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, extension).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new Kubernetes Cluster Extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='extension'>
            /// Properties necessary to Create an Extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Extension> BeginCreateAsync(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, Extension extension, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, extension, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Kubernetes Cluster Extension. This will cause the Agent to
            /// Uninstall the extension from the cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='forceDelete'>
            /// Delete the extension resource in Azure - not the normal asynchronous
            /// delete.
            /// </param>
            public static void BeginDelete(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, bool? forceDelete = default(bool?))
            {
                operations.BeginDeleteAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, forceDelete).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Kubernetes Cluster Extension. This will cause the Agent to
            /// Uninstall the extension from the cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='forceDelete'>
            /// Delete the extension resource in Azure - not the normal asynchronous
            /// delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, bool? forceDelete = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, forceDelete, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Patch an existing Kubernetes Cluster Extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='patchExtension'>
            /// Properties to Patch in an existing Extension.
            /// </param>
            public static Extension BeginUpdate(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, PatchExtension patchExtension)
            {
                return operations.BeginUpdateAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, patchExtension).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch an existing Kubernetes Cluster Extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterRp'>
            /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS
            /// clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters). Possible
            /// values include: 'Microsoft.ContainerService', 'Microsoft.Kubernetes'
            /// </param>
            /// <param name='clusterResourceName'>
            /// The Kubernetes cluster resource name - either managedClusters (for AKS
            /// clusters) or connectedClusters (for OnPrem K8S clusters). Possible values
            /// include: 'managedClusters', 'connectedClusters'
            /// </param>
            /// <param name='clusterName'>
            /// The name of the kubernetes cluster.
            /// </param>
            /// <param name='extensionName'>
            /// Name of the Extension.
            /// </param>
            /// <param name='patchExtension'>
            /// Properties to Patch in an existing Extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Extension> BeginUpdateAsync(this IExtensionsOperations operations, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, PatchExtension patchExtension, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, clusterRp, clusterResourceName, clusterName, extensionName, patchExtension, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all Extensions in the cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Extension> ListNext(this IExtensionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all Extensions in the cluster.
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
            public static async Task<IPage<Extension>> ListNextAsync(this IExtensionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
