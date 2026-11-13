//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyvista
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyvistaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<FinishActionResponse, ApiConnectionActionConfiguration> FinishAction(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<FinishActionBodyInput>> body = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FinishActionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/actions/{1}", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FinishActionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetsListResponse, ApiConnectionActionConfiguration> ViewAssetsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewAssetsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewAssetsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateAssetResponse, ApiConnectionActionConfiguration> CreateAsset(Expression<Func<string>> account, Expression<Func<CreateAssetBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateAssetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetResponse, ApiConnectionActionConfiguration> ViewAsset(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<ViewAssetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateAssetResponse, ApiConnectionActionConfiguration> UpdateAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<UpdateAssetBodyInput>> body = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateAssetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetLinksResponse, ApiConnectionActionConfiguration> ViewAssetLinks(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<ViewAssetLinksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}/asset-links", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_parentAssetId = WorkflowExpression.Compile(parentAssetId, nameof(parentAssetId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1), __workflow_parentAssetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateAssetLinkResponse, ApiConnectionActionConfiguration> CreateAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId, Expression<Func<CreateAssetLinkBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_parentAssetId = WorkflowExpression.Compile(parentAssetId, nameof(parentAssetId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateAssetLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1), __workflow_parentAssetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAssetLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateAssetLinkResponse, ApiConnectionActionConfiguration> UpdateAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId, Expression<Func<CreateAssetLinkBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_parentAssetId = WorkflowExpression.Compile(parentAssetId, nameof(parentAssetId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateAssetLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1), __workflow_parentAssetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateAssetLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetLinkResponse, ApiConnectionActionConfiguration> ViewAssetLink(Expression<Func<string>> account, Expression<Func<string>> parentAssetId, Expression<Func<string>> childAssetId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parentAssetId = WorkflowExpression.Compile(parentAssetId, nameof(parentAssetId), required: true);
            var __workflow_childAssetId = WorkflowExpression.Compile(childAssetId, nameof(childAssetId), required: true);
            return new DeferredBodyAction<ViewAssetLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_parentAssetId.WithUrlEncoding(1), __workflow_childAssetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogAssetsListResponse, ApiConnectionActionConfiguration> ViewCatalogAssetsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewCatalogAssetsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-assets", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewCatalogAssetsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogAssetResponse, ApiConnectionActionConfiguration> ViewCatalogAsset(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_catalogId = WorkflowExpression.Compile(catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogAssetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-assets/{1}", __workflow_account.WithUrlEncoding(1), __workflow_catalogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestsListResponse, ApiConnectionActionConfiguration> ViewCatalogRequestsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ViewCatalogRequestsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-requests", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<ViewCatalogRequestsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestsPathListResponse, ApiConnectionActionConfiguration> ViewCatalogRequestsPathList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewCatalogRequestsPathListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-requests-paths", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewCatalogRequestsPathListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestPathResponse, ApiConnectionActionConfiguration> ViewCatalogRequestPath(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_catalogId = WorkflowExpression.Compile(catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogRequestPathResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-requests-paths/{1}", __workflow_account.WithUrlEncoding(1), __workflow_catalogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogRequestPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestResponse, ApiConnectionActionConfiguration> ViewCatalogRequest(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_catalogId = WorkflowExpression.Compile(catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-requests/{1}", __workflow_account.WithUrlEncoding(1), __workflow_catalogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemsListResponse, ApiConnectionActionConfiguration> ViewConfigurationItemsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewConfigurationItemsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewConfigurationItemsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemResponse, ApiConnectionActionConfiguration> ViewConfigurationItem(Expression<Func<string>> account, Expression<Func<string>> ciId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_ciId = WorkflowExpression.Compile(ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}", __workflow_account.WithUrlEncoding(1), __workflow_ciId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemLinksResponse, ApiConnectionActionConfiguration> ViewConfigurationItemLinks(Expression<Func<string>> account, Expression<Func<string>> ciId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_ciId = WorkflowExpression.Compile(ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemLinksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links", __workflow_account.WithUrlEncoding(1), __workflow_ciId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parentCiId = WorkflowExpression.Compile(parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = WorkflowExpression.Compile(childCiId, nameof(childCiId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_parentCiId.WithUrlEncoding(1), __workflow_childCiId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemLinkResponse, ApiConnectionActionConfiguration> ViewConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parentCiId = WorkflowExpression.Compile(parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = WorkflowExpression.Compile(childCiId, nameof(childCiId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_parentCiId.WithUrlEncoding(1), __workflow_childCiId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateConfigurationItemLinkResponse, ApiConnectionActionConfiguration> CreateConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId, Expression<Func<CreateConfigurationItemLinkBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parentCiId = WorkflowExpression.Compile(parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = WorkflowExpression.Compile(childCiId, nameof(childCiId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateConfigurationItemLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_parentCiId.WithUrlEncoding(1), __workflow_childCiId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateConfigurationItemLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateConfigurationItemLinkResponse, ApiConnectionActionConfiguration> UpdateConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId, Expression<Func<UpdateConfigurationItemLinkBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parentCiId = WorkflowExpression.Compile(parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = WorkflowExpression.Compile(childCiId, nameof(childCiId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateConfigurationItemLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_parentCiId.WithUrlEncoding(1), __workflow_childCiId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateConfigurationItemLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEntitiesListResponse, ApiConnectionActionConfiguration> ViewEntitiesList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewEntitiesListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/departments", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewEntitiesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEntityResponse, ApiConnectionActionConfiguration> ViewEntity(Expression<Func<string>> account, Expression<Func<string>> departmentId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_departmentId = WorkflowExpression.Compile(departmentId, nameof(departmentId), required: true);
            return new DeferredBodyAction<ViewEntityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/departments/{1}", __workflow_account.WithUrlEncoding(1), __workflow_departmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewEntityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEmployeesListResponse, ApiConnectionActionConfiguration> ViewEmployeesList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewEmployeesListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/employees", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewEmployeesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateEmployeeResponse, ApiConnectionActionConfiguration> CreateEmployee(Expression<Func<string>> account, Expression<Func<CreateEmployeeBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateEmployeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/employees", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEmployeeResponse, ApiConnectionActionConfiguration> ViewEmployee(Expression<Func<string>> account, Expression<Func<string>> employeeId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            return new DeferredBodyAction<ViewEmployeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/employees/{1}", __workflow_account.WithUrlEncoding(1), __workflow_employeeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateEmployeeResponse, ApiConnectionActionConfiguration> UpdateEmployee(Expression<Func<string>> account, Expression<Func<string>> employeeId, Expression<Func<UpdateEmployeeBodyInput>> body = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateEmployeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/employees/{1}", __workflow_account.WithUrlEncoding(1), __workflow_employeeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewKnownErrorsListResponse, ApiConnectionActionConfiguration> ViewKnownErrorsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewKnownErrorsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/known-problems", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewKnownErrorsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewKnownErrorsResponse, ApiConnectionActionConfiguration> ViewKnownErrors(Expression<Func<string>> account, Expression<Func<string>> kpId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_kpId = WorkflowExpression.Compile(kpId, nameof(kpId), required: true);
            return new DeferredBodyAction<ViewKnownErrorsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/known-problems/{1}", __workflow_account.WithUrlEncoding(1), __workflow_kpId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewKnownErrorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewLocationsListResponse, ApiConnectionActionConfiguration> ViewLocationsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewLocationsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/locations", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewLocationsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewLocationResponse, ApiConnectionActionConfiguration> ViewLocation(Expression<Func<string>> account, Expression<Func<string>> locationId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            return new DeferredBodyAction<ViewLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/locations/{1}", __workflow_account.WithUrlEncoding(1), __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewManufacturerListResponse, ApiConnectionActionConfiguration> ViewManufacturerList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewManufacturerListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/manufacturers", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewManufacturerListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewManufacturerResponse, ApiConnectionActionConfiguration> ViewManufacturer(Expression<Func<string>> account, Expression<Func<string>> manufacturerId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_manufacturerId = WorkflowExpression.Compile(manufacturerId, nameof(manufacturerId), required: true);
            return new DeferredBodyAction<ViewManufacturerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/manufacturers/{1}", __workflow_account.WithUrlEncoding(1), __workflow_manufacturerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewManufacturerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewRequestsIncidentsListResponse, ApiConnectionActionConfiguration> ViewRequestsIncidentsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewRequestsIncidentsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewRequestsIncidentsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateRequestIncidentResponse, ApiConnectionActionConfiguration> CreateRequestIncident(Expression<Func<string>> account, Expression<Func<CreateRequestIncidentBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateRequestIncidentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewRequestIncidentResponse, ApiConnectionActionConfiguration> ViewRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewRequestIncidentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CloseRequestIncidentResponse, ApiConnectionActionConfiguration> CloseRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<CloseRequestIncidentBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CloseRequestIncidentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CloseRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateRequestIncidentResponse, ApiConnectionActionConfiguration> UpdateRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<UpdateRequestIncidentBodyInput>> body = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateRequestIncidentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewRequestIncidentCommentResponse, ApiConnectionActionConfiguration> ViewRequestIncidentComment(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewRequestIncidentCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/comment", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewRequestIncidentCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<GetRequestIncidentDocumentListResponse, ApiConnectionActionConfiguration> GetRequestIncidentDocumentList(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<GetRequestIncidentDocumentListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/documents", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRequestIncidentDocumentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UploadAndAttachADocumentToARequestIncidentResponse, ApiConnectionActionConfiguration> UploadAndAttachADocumentToARequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<UploadAndAttachADocumentToARequestIncidentBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UploadAndAttachADocumentToARequestIncidentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/documents", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadAndAttachADocumentToARequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<RestartRequestIncidentResponse, ApiConnectionActionConfiguration> RestartRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<RestartRequestIncidentBodyInput>> body = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RestartRequestIncidentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/restart", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RestartRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<SuspendRequestIncidentResponse, ApiConnectionActionConfiguration> SuspendRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<SuspendRequestIncidentBodyInput>> body = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SuspendRequestIncidentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/suspend", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SuspendRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<CreateTaskBodyInput>> body)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/tasks", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewSlasListResponse, ApiConnectionActionConfiguration> ViewSlasList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewSlasListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/slas", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewSlasListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewSlaResponse, ApiConnectionActionConfiguration> ViewSla(Expression<Func<string>> account, Expression<Func<string>> slaId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slaId = WorkflowExpression.Compile(slaId, nameof(slaId), required: true);
            return new DeferredBodyAction<ViewSlaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/slas/{1}", __workflow_account.WithUrlEncoding(1), __workflow_slaId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewSlaResponse>(callPayload);
            });
        }
    }

    public class EasyvistaTriggers([ConnectionName] string connectionId)
    {
    }

    public class FinishActionResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class FinishActionBodyInput
    {
        [JsonProperty("end_action")]
        public BodyInputEndActionType EndAction { get; set; }
    }

    public class BodyInputEndActionType
    {
        public string Choice { get; set; }
        public string Description { get; set; }
    }

    public class ViewAssetsListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewAssetsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewAssetsListResponseRecordsTypeItem
    {
        [JsonProperty("ASSET_ID")]
        public string AssetId { get; set; }

        [JsonProperty("ASSET_LABEL")]
        public string AssetLabel { get; set; }

        [JsonProperty("ASSET_TAG")]
        public string AssetTag { get; set; }

        [JsonProperty("CATALOG_ASSET")]
        public ViewAssetsListResponseRecordsTypeItemCatalogAssetType CatalogAsset { get; set; }

        [JsonProperty("DEPARTMENT")]
        public ViewAssetsListResponseRecordsTypeItemDepartmentType Department { get; set; }

        [JsonProperty("EMPLOYEE")]
        public ViewAssetsListResponseRecordsTypeItemEmployeeType Employee { get; set; }

        [JsonProperty("END_OF_WARANTY")]
        public string EndOfWaranty { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("INSTALLATION_DATE")]
        public string InstallationDate { get; set; }

        [JsonProperty("LOCATION")]
        public ViewAssetsListResponseRecordsTypeItemLocationType Location { get; set; }

        [JsonProperty("PURCHASE_DATE")]
        public string PurchaseDate { get; set; }

        [JsonProperty("SERIAL_NUMBER")]
        public string SerialNumber { get; set; }
    }

    public class ViewAssetsListResponseRecordsTypeItemCatalogAssetType
    {
        [JsonProperty("ARTICLE_MODEL")]
        public string ArticleModel { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CatalogId { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NetPrice { get; set; }

        [JsonProperty("SMBIOS_NAME")]
        public string SmbiosName { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TitleFr { get; set; }
    }

    public class ViewAssetsListResponseRecordsTypeItemDepartmentType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DepartmentCode { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DepartmentFr { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DepartmentLabel { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }
    }

    public class ViewAssetsListResponseRecordsTypeItemEmployeeType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class ViewAssetsListResponseRecordsTypeItemLocationType
    {
        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LocationCode { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LocationFr { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }
    }

    public class CreateAssetResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class CreateAssetBodyInput
    {
        [JsonProperty("assets")]
        public BodyInputAssetsTypeItem[] Assets { get; set; }
    }

    public class BodyInputAssetsTypeItem
    {
        [JsonProperty("Acquisition_Type_ID")]
        public string AcquisitionTypeId { get; set; }

        [JsonProperty("Asset_Tag")]
        public string AssetTag { get; set; }

        [JsonProperty("Catalog_ID")]
        public int? CatalogId { get; set; }

        [JsonProperty("Comment_Asset")]
        public string CommentAsset { get; set; }

        [JsonProperty("Configuration_ID")]
        public string ConfigurationId { get; set; }

        [JsonProperty("Delivery_Date")]
        public string DeliveryDate { get; set; }

        [JsonProperty("Department_Code")]
        public string DepartmentCode { get; set; }

        [JsonProperty("Employee_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("End_of_Waranty")]
        public string EndOfWaranty { get; set; }

        [JsonProperty("Estimated_Percentage_Use")]
        public string EstimatedPercentageUse { get; set; }

        [JsonProperty("Installation_Date")]
        public string InstallationDate { get; set; }

        [JsonProperty("Location_Code")]
        public string LocationCode { get; set; }

        [JsonProperty("Power_Consumption_WH")]
        public string PowerConsumptionWH { get; set; }

        [JsonProperty("Recycling_Provider_ID")]
        public string RecyclingProviderId { get; set; }

        [JsonProperty("Serial_Number")]
        public string SerialNumber { get; set; }

        [JsonProperty("Status_ID")]
        public int? StatusId { get; set; }

        [JsonProperty("Waranty_Type_ID")]
        public string WarantyTypeId { get; set; }
    }

    public class ViewAssetResponse
    {
        [JsonProperty("ACQUISITION_TYPE_ID")]
        public string AcquisitionTypeId { get; set; }

        [JsonProperty("ASSET_GUID")]
        public string AssetGuid { get; set; }

        [JsonProperty("ASSET_ID")]
        public string AssetId { get; set; }

        [JsonProperty("ASSET_LABEL")]
        public string AssetLabel { get; set; }

        [JsonProperty("ASSET_TAG")]
        public string AssetTag { get; set; }

        [JsonProperty("AUTOMATIC_RENEWAL")]
        public string AutomaticRenewal { get; set; }

        [JsonProperty("AVAILABILITY_SLA_ID")]
        public string AvailabilitySlaId { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("BEFORE_LOAN_DEPARTMENT_ID")]
        public string BeforeLoanDepartmentId { get; set; }

        [JsonProperty("BEFORE_LOAN_DEPARTMENT_PATH")]
        public string BeforeLoanDepartmentPath { get; set; }

        [JsonProperty("BEFORE_LOAN_EMPLOYEE_ID")]
        public string BeforeLoanEmployeeId { get; set; }

        [JsonProperty("BEFORE_LOAN_LOCATION_ID")]
        public string BeforeLoanLocationId { get; set; }

        [JsonProperty("BEFORE_LOAN_LOCATION_PATH")]
        public string BeforeLoanLocationPath { get; set; }

        [JsonProperty("BILLING_PERIODICITY_IN_MONTH")]
        public string BillingPeriodicityInMonth { get; set; }

        [JsonProperty("BUDGET_ID")]
        public string BudgetId { get; set; }

        [JsonProperty("BUY_BACK_VALUE")]
        public string BuyBackValue { get; set; }

        [JsonProperty("BUY_BACK_VALUE_CUR_ID")]
        public string BuyBackValueCurId { get; set; }

        [JsonProperty("CATALOG_ASSET")]
        public ViewAssetResponseCatalogAssetType CatalogAsset { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CatalogId { get; set; }

        [JsonProperty("CHARGE_BACK")]
        public string ChargeBack { get; set; }

        [JsonProperty("CHARGE_BACK_CUR_ID")]
        public string ChargeBackCurId { get; set; }

        [JsonProperty("CI_BACKUP_BY_DEFAULT")]
        public string CiBackupByDefault { get; set; }

        [JsonProperty("CI_STATUS_ID")]
        public string CiStatusId { get; set; }

        [JsonProperty("CI_VERSION")]
        public string CiVersion { get; set; }

        [JsonProperty("CM_DEFAULT_CHANGE_ID")]
        public string CmDefaultChangeId { get; set; }

        [JsonProperty("CM_DEFAULT_CHANGE_PATH")]
        public string CmDefaultChangePath { get; set; }

        [JsonProperty("COMMENT_ASSET")]
        public ViewAssetResponseCommentAssetType CommentAsset { get; set; }

        [JsonProperty("CONFIGURATION_ID")]
        public string ConfigurationId { get; set; }

        [JsonProperty("CONTRACT_TYPE_ID")]
        public string ContractTypeId { get; set; }

        [JsonProperty("CRITICAL_LEVEL_ID")]
        public string CriticalLevelId { get; set; }

        [JsonProperty("DELIVERY_DATE")]
        public string DeliveryDate { get; set; }

        [JsonProperty("DELIVERY_NUMBER")]
        public string DeliveryNumber { get; set; }

        [JsonProperty("DEPARTMENT")]
        public ViewAssetResponseDepartmentType Department { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("DEPRECIATION_RULE_ID")]
        public string DepreciationRuleId { get; set; }

        [JsonProperty("D_HARDWARE_GUID")]
        public string DHardwareGuid { get; set; }

        [JsonProperty("EMPLOYEE")]
        public ViewAssetResponseEmployeeType Employee { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("END_OF_WARANTY")]
        public string EndOfWaranty { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("ESTIMATED_PERCENTAGE_USE")]
        public string EstimatedPercentageUse { get; set; }

        [JsonProperty("EXPECTED_END_LEND_DATE")]
        public string ExpectedEndLendDate { get; set; }

        [JsonProperty("EXPECTED_RETURN_DATE")]
        public string ExpectedReturnDate { get; set; }

        [JsonProperty("FALLEN_TERM")]
        public string FallenTerm { get; set; }

        [JsonProperty("FIXED_ASSET_NUMBER")]
        public string FixedAssetNumber { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("INITIAL_START")]
        public string InitialStart { get; set; }

        [JsonProperty("INSTALLATION_DATE")]
        public string InstallationDate { get; set; }

        [JsonProperty("INTERNAL_DELIVERY_DATE")]
        public string InternalDeliveryDate { get; set; }

        [JsonProperty("INTERNAL_DISPO")]
        public string InternalDispo { get; set; }

        [JsonProperty("INVENTORY_ID")]
        public string InventoryId { get; set; }

        [JsonProperty("INVOICE_NUMBER")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("IS_CI")]
        public string IsCi { get; set; }

        [JsonProperty("IS_DML")]
        public string IsDml { get; set; }

        [JsonProperty("IS_LOCKED")]
        public string IsLocked { get; set; }

        [JsonProperty("IS_SERVICE")]
        public string IsService { get; set; }

        [JsonProperty("LAST_AUTOMATIC_DISCOVERY")]
        public string LastAutomaticDiscovery { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LastIntegration { get; set; }

        [JsonProperty("LAST_PAYMENT")]
        public string LastPayment { get; set; }

        [JsonProperty("LAST_PAYMENT_CUR_ID")]
        public string LastPaymentCurId { get; set; }

        [JsonProperty("LAST_PHYSICAL_INVENTORY")]
        public string LastPhysicalInventory { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("LICENSE_VERSION")]
        public string LicenseVersion { get; set; }

        [JsonProperty("LOCATION")]
        public ViewAssetResponseLocationType Location { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("LOCATION_TO_CHECK_REQUEST_ID")]
        public string LocationToCheckRequestId { get; set; }

        [JsonProperty("MAINTENANCE_COST")]
        public string MaintenanceCost { get; set; }

        [JsonProperty("MAINTENANCE_COST_CUR_ID")]
        public string MaintenanceCostCurId { get; set; }

        [JsonProperty("MAIN_USAGE_ID")]
        public string MainUsageId { get; set; }

        [JsonProperty("MAX_INSTALLS")]
        public string MaxInstalls { get; set; }

        [JsonProperty("MONTHLY_FIXED_COST")]
        public string MonthlyFixedCost { get; set; }

        [JsonProperty("MONTHLY_FIXED_COST_CUR_ID")]
        public string MonthlyFixedCostCurId { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL")]
        public string MonthlyNetRental { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL_CUR_ID")]
        public string MonthlyNetRentalCurId { get; set; }

        [JsonProperty("MONTH_DURATION")]
        public string MonthDuration { get; set; }

        [JsonProperty("NETWORK_IDENTIFIER")]
        public string NetworkIdentifier { get; set; }

        [JsonProperty("NEXT_CI_VERSION")]
        public string NextCiVersion { get; set; }

        [JsonProperty("NEXT_DEPARTMENT_ID")]
        public string NextDepartmentId { get; set; }

        [JsonProperty("NEXT_DEPARTMENT_PATH")]
        public string NextDepartmentPath { get; set; }

        [JsonProperty("NEXT_MAINTENANCE_DATE")]
        public string NextMaintenanceDate { get; set; }

        [JsonProperty("NEXT_STATUS_ID")]
        public string NextStatusId { get; set; }

        [JsonProperty("NEXT_USER_APPLICATION_DATE")]
        public string NextUserApplicationDate { get; set; }

        [JsonProperty("NEXT_USER_ID")]
        public string NextUserId { get; set; }

        [JsonProperty("NOTICE")]
        public string Notice { get; set; }

        [JsonProperty("ORDER_DETAILS_ID")]
        public string OrderDetailsId { get; set; }

        [JsonProperty("ORDER_NUMBER")]
        public string OrderNumber { get; set; }

        [JsonProperty("OWNERSHIP_TO_CHECK_REQUEST_ID")]
        public string OwnershipToCheckRequestId { get; set; }

        [JsonProperty("PACKAGE_PATH")]
        public string PackagePath { get; set; }

        [JsonProperty("PIPELINE_STATUS_ID")]
        public string PipelineStatusId { get; set; }

        [JsonProperty("POWER_CONSUMPTION_WH")]
        public string PowerConsumptionWh { get; set; }

        [JsonProperty("PROCESSOR_COUNT")]
        public string ProcessorCount { get; set; }

        [JsonProperty("PROCESSOR_SOCKET_COUNT")]
        public string ProcessorSocketCount { get; set; }

        [JsonProperty("PROJECT_ID")]
        public string ProjectId { get; set; }

        [JsonProperty("PROVIDER_ID")]
        public string ProviderId { get; set; }

        [JsonProperty("PROVIDER_PATH")]
        public string ProviderPath { get; set; }

        [JsonProperty("PURCHASE_DATE")]
        public string PurchaseDate { get; set; }

        [JsonProperty("PURCHASE_PRICE")]
        public string PurchasePrice { get; set; }

        [JsonProperty("PURCHASE_PRICE_CUR_ID")]
        public string PurchasePriceCurId { get; set; }

        [JsonProperty("PURCHASE_RATE_ID")]
        public string PurchaseRateId { get; set; }

        [JsonProperty("RECYCLED_DATE")]
        public string RecycledDate { get; set; }

        [JsonProperty("RECYCLING_PROVIDER_ID")]
        public string RecyclingProviderId { get; set; }

        [JsonProperty("RECYCLING_PROVIDER_PATH")]
        public string RecyclingProviderPath { get; set; }

        [JsonProperty("REFORM_NUMBER")]
        public string ReformNumber { get; set; }

        [JsonProperty("REMOVED_DATE")]
        public string RemovedDate { get; set; }

        [JsonProperty("RENEWAL_DECISION_ID")]
        public string RenewalDecisionId { get; set; }

        [JsonProperty("RENEWAL_VALUE")]
        public string RenewalValue { get; set; }

        [JsonProperty("RENEWAL_VALUE_CUR_ID")]
        public string RenewalValueCurId { get; set; }

        [JsonProperty("REPAIRED_BY_ID")]
        public string RepairedById { get; set; }

        [JsonProperty("REPAIRED_BY_PATH")]
        public string RepairedByPath { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string RequestId { get; set; }

        [JsonProperty("RESALES_VALUE")]
        public string ResalesValue { get; set; }

        [JsonProperty("SCHEDULED_END")]
        public string ScheduledEnd { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SdCatalogPath { get; set; }

        [JsonProperty("SD_DEFAULT_INCIDENT_ID")]
        public string SdDefaultIncidentId { get; set; }

        [JsonProperty("SD_DEFAULT_INCIDENT_PATH")]
        public string SdDefaultIncidentPath { get; set; }

        [JsonProperty("SD_DEFAULT_REQUEST_ID")]
        public string SdDefaultRequestId { get; set; }

        [JsonProperty("SD_DEFAULT_REQUEST_PATH")]
        public string SdDefaultRequestPath { get; set; }

        [JsonProperty("SERIAL_NUMBER")]
        public string SerialNumber { get; set; }

        [JsonProperty("SERVER_TYPE_ID")]
        public string ServerTypeId { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }

        [JsonProperty("STATUS_ID")]
        public string StatusId { get; set; }

        [JsonProperty("SUPPLIER_ID")]
        public string SupplierId { get; set; }

        [JsonProperty("SUPPLIER_PATH")]
        public string SupplierPath { get; set; }

        [JsonProperty("TERM")]
        public string Term { get; set; }

        [JsonProperty("UPDATED_BY_DISCOVERY")]
        public string UpdatedByDiscovery { get; set; }

        [JsonProperty("UPDATE_COVERAGE_TERM")]
        public string UpdateCoverageTerm { get; set; }

        [JsonProperty("WARANTY_TYPE_ID")]
        public string WarantyTypeId { get; set; }

        [JsonProperty("XPOS")]
        public string Xpos { get; set; }

        [JsonProperty("YPOS")]
        public string Ypos { get; set; }

        [JsonProperty("ZPOS")]
        public string Zpos { get; set; }
    }

    public class ViewAssetResponseCatalogAssetType
    {
        [JsonProperty("ARTICLE_MODEL")]
        public string ArticleModel { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CatalogId { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NetPrice { get; set; }

        [JsonProperty("SMBIOS_NAME")]
        public string SmbiosName { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TitleFr { get; set; }
    }

    public class ViewAssetResponseCommentAssetType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewAssetResponseDepartmentType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DepartmentCode { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DepartmentFr { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DepartmentLabel { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }
    }

    public class ViewAssetResponseEmployeeType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class ViewAssetResponseLocationType
    {
        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LocationCode { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LocationFr { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }
    }

    public class UpdateAssetResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class UpdateAssetBodyInput
    {
        [JsonProperty("BEFORE_LOAN_DEPARTMENT_ID")]
        public string BeforeLoanDepartmentId { get; set; }

        [JsonProperty("BEFORE_LOAN_EMPLOYEE_ID")]
        public string BeforeLoanEmployeeId { get; set; }

        [JsonProperty("BEFORE_LOAN_LOCATION_ID")]
        public string BeforeLoanLocationId { get; set; }

        [JsonProperty("BILLING_PERIODICITY_IN_MONTH")]
        public string BillingPeriodicityInMonth { get; set; }

        [JsonProperty("BUY_BACK_VALUE")]
        public string BuyBackValue { get; set; }

        [JsonProperty("BUY_BACK_VALUE_CUR_ID")]
        public string BuyBackValueCurId { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CatalogId { get; set; }

        [JsonProperty("CHARGE_BACK")]
        public string ChargeBack { get; set; }

        [JsonProperty("CHARGE_BACK_CUR_ID")]
        public string ChargeBackCurId { get; set; }

        [JsonProperty("CI_STATUS_ID")]
        public string CiStatusId { get; set; }

        [JsonProperty("CI_VERSION")]
        public string CiVersion { get; set; }

        [JsonProperty("CM_DEFAULT_CHANGE_ID")]
        public string CmDefaultChangeId { get; set; }

        [JsonProperty("CONFIGURATION_ID")]
        public string ConfigurationId { get; set; }

        [JsonProperty("CRITICAL_LEVEL_ID")]
        public string CriticalLevelId { get; set; }

        [JsonProperty("DELIVERY_DATE")]
        public string DeliveryDate { get; set; }

        [JsonProperty("DELIVERY_NUMBER")]
        public string DeliveryNumber { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPRECIATION_RULE_ID")]
        public string DepreciationRuleId { get; set; }

        [JsonProperty("D_HARDWARE_GUID")]
        public string DHardwareGuid { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("END_OF_WARANTY")]
        public string EndOfWaranty { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("ESTIMATED_PERCENTAGE_USE")]
        public string EstimatedPercentageUse { get; set; }

        [JsonProperty("EXPECTED_END_LEND_DATE")]
        public string ExpectedEndLendDate { get; set; }

        [JsonProperty("EXPECTED_RETURN_DATE")]
        public string ExpectedReturnDate { get; set; }

        [JsonProperty("FALLEN_TERM")]
        public string FallenTerm { get; set; }

        [JsonProperty("FIXED_ASSET_NUMBER")]
        public string FixedAssetNumber { get; set; }

        [JsonProperty("INITIAL_START")]
        public string InitialStart { get; set; }

        [JsonProperty("INSTALLATION_DATE")]
        public string InstallationDate { get; set; }

        [JsonProperty("INTERNAL_DELIVERY_DATE")]
        public string InternalDeliveryDate { get; set; }

        [JsonProperty("INVOICE_NUMBER")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("IS_DML")]
        public string IsDml { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LastIntegration { get; set; }

        [JsonProperty("LAST_PHYSICAL_INVENTORY")]
        public string LastPhysicalInventory { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("LICENSE_VERSION")]
        public string LicenseVersion { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("MAINTENANCE_COST")]
        public string MaintenanceCost { get; set; }

        [JsonProperty("MAINTENANCE_COST_CUR_ID")]
        public string MaintenanceCostCurId { get; set; }

        [JsonProperty("MAIN_USAGE_ID")]
        public string MainUsageId { get; set; }

        [JsonProperty("MAX_INSTALLS")]
        public string MaxInstalls { get; set; }

        [JsonProperty("MONTHLY_FIXED_COST")]
        public string MonthlyFixedCost { get; set; }

        [JsonProperty("MONTHLY_FIXED_COST_CUR_ID")]
        public string MonthlyFixedCostCurId { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL")]
        public string MonthlyNetRental { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL_CUR_ID")]
        public string MonthlyNetRentalCurId { get; set; }

        [JsonProperty("MONTH_DURATION")]
        public string MonthDuration { get; set; }

        [JsonProperty("NETWORK_IDENTIFIER")]
        public string NetworkIdentifier { get; set; }

        [JsonProperty("NEXT_DEPARTMENT_ID")]
        public string NextDepartmentId { get; set; }

        [JsonProperty("NEXT_MAINTENANCE_DATE")]
        public string NextMaintenanceDate { get; set; }

        [JsonProperty("NEXT_STATUS_ID")]
        public string NextStatusId { get; set; }

        [JsonProperty("NEXT_USER_APPLICATION_DATE")]
        public string NextUserApplicationDate { get; set; }

        [JsonProperty("NEXT_USER_ID")]
        public string NextUserId { get; set; }

        [JsonProperty("NOTICE")]
        public string Notice { get; set; }

        [JsonProperty("ORDER_DETAILS_ID")]
        public string OrderDetailsId { get; set; }

        [JsonProperty("ORDER_NUMBER")]
        public string OrderNumber { get; set; }

        [JsonProperty("PIPELINE_STATUS_ID")]
        public string PipelineStatusId { get; set; }

        [JsonProperty("POWER_CONSUMPTION_WH")]
        public string PowerConsumptionWh { get; set; }

        [JsonProperty("PROCESSOR_COUNT")]
        public string ProcessorCount { get; set; }

        [JsonProperty("PROCESSOR_SOCKET_COUNT")]
        public string ProcessorSocketCount { get; set; }

        [JsonProperty("PURCHASE_DATE")]
        public string PurchaseDate { get; set; }

        [JsonProperty("PURCHASE_PRICE")]
        public string PurchasePrice { get; set; }

        [JsonProperty("PURCHASE_PRICE_CUR_ID")]
        public string PurchasePriceCurId { get; set; }

        [JsonProperty("PURCHASE_RATE_ID")]
        public string PurchaseRateId { get; set; }

        [JsonProperty("RECYCLED_DATE")]
        public string RecycledDate { get; set; }

        [JsonProperty("RECYCLING_PROVIDER_ID")]
        public string RecyclingProviderId { get; set; }

        [JsonProperty("REFORM_NUMBER")]
        public string ReformNumber { get; set; }

        [JsonProperty("REMOVED_DATE")]
        public string RemovedDate { get; set; }

        [JsonProperty("RENEWAL_DECISION_ID")]
        public string RenewalDecisionId { get; set; }

        [JsonProperty("RENEWAL_VALUE")]
        public string RenewalValue { get; set; }

        [JsonProperty("RENEWAL_VALUE_CUR_ID")]
        public string RenewalValueCurId { get; set; }

        [JsonProperty("REPAIRED_BY_ID")]
        public string RepairedById { get; set; }

        [JsonProperty("RESALES_VALUE")]
        public string ResalesValue { get; set; }

        [JsonProperty("SCHEDULED_END")]
        public string ScheduledEnd { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("SERIAL_NUMBER")]
        public string SerialNumber { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }

        [JsonProperty("STATUS_ID")]
        public string StatusId { get; set; }

        [JsonProperty("SUPPLIER_ID")]
        public string SupplierId { get; set; }

        [JsonProperty("TERM")]
        public string Term { get; set; }

        [JsonProperty("UPDATE_COVERAGE_TERM")]
        public string UpdateCoverageTerm { get; set; }

        [JsonProperty("WARANTY_TYPE_ID")]
        public string WarantyTypeId { get; set; }

        [JsonProperty("asset_label")]
        public string AssetLabel { get; set; }

        [JsonProperty("asset_tag")]
        public string AssetTag { get; set; }

        [JsonProperty("automatic_renewal")]
        public string AutomaticRenewal { get; set; }

        [JsonProperty("availability_sla_id")]
        public string AvailabilitySlaId { get; set; }

        [JsonProperty("available_field_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("available_field_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("available_field_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("available_field_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("available_field_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("available_field_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("comment_asset")]
        public string CommentAsset { get; set; }
    }

    public class ViewAssetLinksResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewAssetLinksResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewAssetLinksResponseRecordsTypeItem
    {
        [JsonProperty("ASSET_ID")]
        public string AssetId { get; set; }

        [JsonProperty("CONTRACT_ROW")]
        public string ContractRow { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("MONTHLY_PAYMENT")]
        public string MonthlyPayment { get; set; }

        [JsonProperty("PARENT_ASSET_ID")]
        public string ParentAssetId { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string ParentHref { get; set; }
    }

    public class CreateAssetLinkResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class CreateAssetLinkBodyInput
    {
        [JsonProperty("Contract_Row")]
        public string ContractRow { get; set; }

        [JsonProperty("Monthly_Payment")]
        public string MonthlyPayment { get; set; }
    }

    public class UpdateAssetLinkResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewAssetLinkResponse
    {
        [JsonProperty("ASSET_ID")]
        public string AssetId { get; set; }

        [JsonProperty("CONTRACT_ROW")]
        public string ContractRow { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("MONTHLY_PAYMENT")]
        public string MonthlyPayment { get; set; }

        [JsonProperty("PARENT_ASSET_ID")]
        public string ParentAssetId { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string ParentHref { get; set; }
    }

    public class ViewCatalogAssetsListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewCatalogAssetsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewCatalogAssetsListResponseRecordsTypeItem
    {
        [JsonProperty("ARTICLE_MODEL")]
        public string ArticleModel { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CatalogId { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("MANUFACTURER")]
        public ViewCatalogAssetsListResponseRecordsTypeItemManufacturerType Manufacturer { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NetPrice { get; set; }

        [JsonProperty("SMBIOS_NAME")]
        public string SmbiosName { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TitleFr { get; set; }
    }

    public class ViewCatalogAssetsListResponseRecordsTypeItemManufacturerType
    {
        [JsonProperty("DISCOVERY_NAME")]
        public string DiscoveryName { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("MANUFACTURER")]
        public string Manufacturer { get; set; }

        [JsonProperty("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
    }

    public class ViewCatalogAssetResponse
    {
        [JsonProperty("ARTICLE_MODEL")]
        public string ArticleModel { get; set; }

        [JsonProperty("ARTICLE_MODEL_URL")]
        public string ArticleModelUrl { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("CAN_BE_PURCHASED")]
        public string CanBePurchased { get; set; }

        [JsonProperty("CATALOG_GUID")]
        public string CatalogGuid { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CatalogId { get; set; }

        [JsonProperty("CURRENT_LICENSE_VERSION")]
        public string CurrentLicenseVersion { get; set; }

        [JsonProperty("DEFAULT_BUY_BACK_VALUE")]
        public string DefaultBuyBackValue { get; set; }

        [JsonProperty("DEFAULT_BUY_BACK_VALUE_CUR_ID")]
        public string DefaultBuyBackValueCurId { get; set; }

        [JsonProperty("DEFAULT_CHARGE_BACK")]
        public string DefaultChargeBack { get; set; }

        [JsonProperty("DEFAULT_CHARGE_BACK_CUR_ID")]
        public string DefaultChargeBackCurId { get; set; }

        [JsonProperty("DEFAULT_DISPOSAL_VALUE")]
        public string DefaultDisposalValue { get; set; }

        [JsonProperty("DEFAULT_DISPOSAL_VALUE_CUR_ID")]
        public string DefaultDisposalValueCurId { get; set; }

        [JsonProperty("DEFAULT_RENEWAL_VALUE")]
        public string DefaultRenewalValue { get; set; }

        [JsonProperty("DEFAULT_RENEWAL_VALUE_CUR_ID")]
        public string DefaultRenewalValueCurId { get; set; }

        [JsonProperty("DESCRIPTION_EN")]
        public ViewCatalogAssetResponseDescriptionEnType DescriptionEn { get; set; }

        [JsonProperty("DESCRIPTION_FR")]
        public ViewCatalogAssetResponseDescriptionFrType DescriptionFr { get; set; }

        [JsonProperty("DESCRIPTION_GE")]
        public ViewCatalogAssetResponseDescriptionGeType DescriptionGe { get; set; }

        [JsonProperty("DESCRIPTION_IT")]
        public ViewCatalogAssetResponseDescriptionItType DescriptionIt { get; set; }

        [JsonProperty("DESCRIPTION_L1")]
        public ViewCatalogAssetResponseDescriptionL1Type DescriptionL1 { get; set; }

        [JsonProperty("DESCRIPTION_L2")]
        public ViewCatalogAssetResponseDescriptionL2Type DescriptionL2 { get; set; }

        [JsonProperty("DESCRIPTION_L3")]
        public ViewCatalogAssetResponseDescriptionL3Type DescriptionL3 { get; set; }

        [JsonProperty("DESCRIPTION_L4")]
        public ViewCatalogAssetResponseDescriptionL4Type DescriptionL4 { get; set; }

        [JsonProperty("DESCRIPTION_L5")]
        public ViewCatalogAssetResponseDescriptionL5Type DescriptionL5 { get; set; }

        [JsonProperty("DESCRIPTION_L6")]
        public ViewCatalogAssetResponseDescriptionL6Type DescriptionL6 { get; set; }

        [JsonProperty("DESCRIPTION_PO")]
        public ViewCatalogAssetResponseDescriptionPoType DescriptionPo { get; set; }

        [JsonProperty("DESCRIPTION_SP")]
        public ViewCatalogAssetResponseDescriptionSpType DescriptionSp { get; set; }

        [JsonProperty("END_DATE")]
        public string EndDate { get; set; }

        [JsonProperty("END_OF_NEWS")]
        public string EndOfNews { get; set; }

        [JsonProperty("ESTIMATED_PERCENTAGE_USE")]
        public string EstimatedPercentageUse { get; set; }

        [JsonProperty("ESTIMATED_POWER_CONSUMPTION_WH")]
        public string EstimatedPowerConsumptionWh { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("IMPACT_ID")]
        public string ImpactId { get; set; }

        [JsonProperty("INITIAL_STOCK")]
        public string InitialStock { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LastIntegration { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("LEVEL_VERSION")]
        public string LevelVersion { get; set; }

        [JsonProperty("LICENSE_PRICE_PER_SEAT")]
        public string LicensePricePerSeat { get; set; }

        [JsonProperty("LICENSE_PRICE_PER_SEAT_CUR_ID")]
        public string LicensePricePerSeatCurId { get; set; }

        [JsonProperty("LICENSE_PROGRAM")]
        public string LicenseProgram { get; set; }

        [JsonProperty("MAINTENANCE_DURATION")]
        public string MaintenanceDuration { get; set; }

        [JsonProperty("MANAGED_LICENSE")]
        public string ManagedLicense { get; set; }

        [JsonProperty("MANAGER_ID")]
        public string ManagerId { get; set; }

        [JsonProperty("MANUFACTURER")]
        public ViewCatalogAssetResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }

        [JsonProperty("MANUFACTURER_REF")]
        public string ManufacturerRef { get; set; }

        [JsonProperty("MANUFACTURER_WARRANTY_DURATION")]
        public string ManufacturerWarrantyDuration { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL")]
        public string MonthlyNetRental { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL_CUR_ID")]
        public string MonthlyNetRentalCurId { get; set; }

        [JsonProperty("NB_INSTALLS")]
        public string NbInstalls { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NetPrice { get; set; }

        [JsonProperty("NET_PRICE_CUR_ID")]
        public string NetPriceCurId { get; set; }

        [JsonProperty("PERCENT_MAINTENANCE_COST")]
        public string PercentMaintenanceCost { get; set; }

        [JsonProperty("QTY_PACKAGED")]
        public string QtyPackaged { get; set; }

        [JsonProperty("REF_GLPI")]
        public string RefGlpi { get; set; }

        [JsonProperty("REF_LANDESK")]
        public string RefLandesk { get; set; }

        [JsonProperty("REF_SCCM")]
        public string RefSccm { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }

        [JsonProperty("SMBIOS_NAME")]
        public string SmbiosName { get; set; }

        [JsonProperty("START_DATE")]
        public string StartDate { get; set; }

        [JsonProperty("TAX_ID")]
        public string TaxId { get; set; }

        [JsonProperty("TECHNICAL_VALIDATION_REQUIRED")]
        public string TechnicalValidationRequired { get; set; }

        [JsonProperty("TITLE_EN")]
        public string TitleEn { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TitleFr { get; set; }

        [JsonProperty("TITLE_GE")]
        public string TitleGe { get; set; }

        [JsonProperty("TITLE_IT")]
        public string TitleIt { get; set; }

        [JsonProperty("TITLE_L1")]
        public string TitleL1 { get; set; }

        [JsonProperty("TITLE_L2")]
        public string TitleL2 { get; set; }

        [JsonProperty("TITLE_L3")]
        public string TitleL3 { get; set; }

        [JsonProperty("TITLE_L4")]
        public string TitleL4 { get; set; }

        [JsonProperty("TITLE_L5")]
        public string TitleL5 { get; set; }

        [JsonProperty("TITLE_L6")]
        public string TitleL6 { get; set; }

        [JsonProperty("TITLE_PO")]
        public string TitlePo { get; set; }

        [JsonProperty("TITLE_SP")]
        public string TitleSp { get; set; }

        [JsonProperty("YEARS_EXPECTED_USAGE")]
        public string YearsExpectedUsage { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionEnType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionFrType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionGeType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionItType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionL1Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionL2Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionL3Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionL4Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionL5Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionL6Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionPoType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseDescriptionSpType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogAssetResponseManufacturerType
    {
        [JsonProperty("DISCOVERY_NAME")]
        public string DiscoveryName { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("MANUFACTURER")]
        public string Manufacturer { get; set; }

        [JsonProperty("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
    }

    public class ViewCatalogRequestsListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewCatalogRequestsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewCatalogRequestsListResponseRecordsTypeItem
    {
        [JsonProperty("CATALOG_REQUESTS_PATH")]
        public ViewCatalogRequestsListResponseRecordsTypeItemCatalogRequestsPathType CatalogRequestsPath { get; set; }

        [JsonProperty("CATALOG_REQUEST_PATH")]
        public string CatalogRequestPath { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("MANAGER")]
        public ViewCatalogRequestsListResponseRecordsTypeItemManagerType Manager { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("SLA")]
        public ViewCatalogRequestsListResponseRecordsTypeItemSlaType Sla { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TitleFr { get; set; }
    }

    public class ViewCatalogRequestsListResponseRecordsTypeItemCatalogRequestsPathType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("SD_CATALOG_PATH_FR")]
        public string SdCatalogPathFr { get; set; }
    }

    public class ViewCatalogRequestsListResponseRecordsTypeItemManagerType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class ViewCatalogRequestsListResponseRecordsTypeItemSlaType
    {
        [JsonProperty("DELAY")]
        public string Delay { get; set; }

        [JsonProperty("NAME_FR")]
        public string NameFr { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }
    }

    public class ViewCatalogRequestsPathListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewCatalogRequestsPathListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewCatalogRequestsPathListResponseRecordsTypeItem
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("SD_CATALOG_PATH_FR")]
        public string SdCatalogPathFr { get; set; }
    }

    public class ViewCatalogRequestPathResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("SD_CATALOG_PATH_EN")]
        public string SdCatalogPathEn { get; set; }

        [JsonProperty("SD_CATALOG_PATH_FR")]
        public string SdCatalogPathFr { get; set; }

        [JsonProperty("SD_CATALOG_PATH_GE")]
        public string SdCatalogPathGe { get; set; }

        [JsonProperty("SD_CATALOG_PATH_IT")]
        public string SdCatalogPathIt { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L1")]
        public string SdCatalogPathL1 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L2")]
        public string SdCatalogPathL2 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L3")]
        public string SdCatalogPathL3 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L4")]
        public string SdCatalogPathL4 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L5")]
        public string SdCatalogPathL5 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L6")]
        public string SdCatalogPathL6 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_PO")]
        public string SdCatalogPathPo { get; set; }

        [JsonProperty("SD_CATALOG_PATH_SP")]
        public string SdCatalogPathSp { get; set; }
    }

    public class ViewCatalogRequestResponse
    {
        [JsonProperty("ALLOW_GROUP_CHANGE")]
        public string AllowGroupChange { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("CANNOT_BE_ORDERED")]
        public string CannotBeOrdered { get; set; }

        [JsonProperty("CAN_BE_PURCHASED")]
        public string CanBePurchased { get; set; }

        [JsonProperty("CATALOG_GUID")]
        public string CatalogGuid { get; set; }

        [JsonProperty("CATALOG_REQUESTS_PATH")]
        public ViewCatalogRequestResponseCatalogRequestsPathType CatalogRequestsPath { get; set; }

        [JsonProperty("CATALOG_REQUEST_PATH")]
        public string CatalogRequestPath { get; set; }

        [JsonProperty("CI_MANDATORY")]
        public string CiMandatory { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("COMMENT_CATALOG")]
        public ViewCatalogRequestResponseCommentCatalogType CommentCatalog { get; set; }

        [JsonProperty("DEFAULT_REQUEST_BO")]
        public string DefaultRequestBo { get; set; }

        [JsonProperty("DEFAULT_REQUEST_FO")]
        public string DefaultRequestFo { get; set; }

        [JsonProperty("DEFAULT_REQUEST_TA")]
        public string DefaultRequestTa { get; set; }

        [JsonProperty("DEFAULT_URGENCY_ID")]
        public string DefaultUrgencyId { get; set; }

        [JsonProperty("DESCRIPTION_EN")]
        public ViewCatalogRequestResponseDescriptionEnType DescriptionEn { get; set; }

        [JsonProperty("DESCRIPTION_FR")]
        public ViewCatalogRequestResponseDescriptionFrType DescriptionFr { get; set; }

        [JsonProperty("DESCRIPTION_GE")]
        public ViewCatalogRequestResponseDescriptionGeType DescriptionGe { get; set; }

        [JsonProperty("DESCRIPTION_IT")]
        public ViewCatalogRequestResponseDescriptionItType DescriptionIt { get; set; }

        [JsonProperty("DESCRIPTION_L1")]
        public ViewCatalogRequestResponseDescriptionL1Type DescriptionL1 { get; set; }

        [JsonProperty("DESCRIPTION_L2")]
        public ViewCatalogRequestResponseDescriptionL2Type DescriptionL2 { get; set; }

        [JsonProperty("DESCRIPTION_L3")]
        public ViewCatalogRequestResponseDescriptionL3Type DescriptionL3 { get; set; }

        [JsonProperty("DESCRIPTION_L4")]
        public ViewCatalogRequestResponseDescriptionL4Type DescriptionL4 { get; set; }

        [JsonProperty("DESCRIPTION_L5")]
        public ViewCatalogRequestResponseDescriptionL5Type DescriptionL5 { get; set; }

        [JsonProperty("DESCRIPTION_L6")]
        public ViewCatalogRequestResponseDescriptionL6Type DescriptionL6 { get; set; }

        [JsonProperty("DESCRIPTION_PO")]
        public ViewCatalogRequestResponseDescriptionPoType DescriptionPo { get; set; }

        [JsonProperty("DESCRIPTION_SP")]
        public ViewCatalogRequestResponseDescriptionSpType DescriptionSp { get; set; }

        [JsonProperty("END_DATE")]
        public string EndDate { get; set; }

        [JsonProperty("END_OF_NEWS")]
        public string EndOfNews { get; set; }

        [JsonProperty("GROUP_ID")]
        public string GroupId { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("IMPACT_ID")]
        public string ImpactId { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LastIntegration { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("MANAGER")]
        public ViewCatalogRequestResponseManagerType Manager { get; set; }

        [JsonProperty("MAX_CALLS")]
        public string MaxCalls { get; set; }

        [JsonProperty("MAX_QTY")]
        public string MaxQty { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL")]
        public string MonthlyNetRental { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL_CUR_ID")]
        public string MonthlyNetRentalCurId { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NetPrice { get; set; }

        [JsonProperty("NET_PRICE_CUR_ID")]
        public string NetPriceCurId { get; set; }

        [JsonProperty("PACKAGE_NAME")]
        public string PackageName { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("SLA")]
        public ViewCatalogRequestResponseSlaType Sla { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }

        [JsonProperty("START_DATE")]
        public string StartDate { get; set; }

        [JsonProperty("TITLE_EN")]
        public string TitleEn { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TitleFr { get; set; }

        [JsonProperty("TITLE_GE")]
        public string TitleGe { get; set; }

        [JsonProperty("TITLE_IT")]
        public string TitleIt { get; set; }

        [JsonProperty("TITLE_L1")]
        public string TitleL1 { get; set; }

        [JsonProperty("TITLE_L2")]
        public string TitleL2 { get; set; }

        [JsonProperty("TITLE_L3")]
        public string TitleL3 { get; set; }

        [JsonProperty("TITLE_L4")]
        public string TitleL4 { get; set; }

        [JsonProperty("TITLE_L5")]
        public string TitleL5 { get; set; }

        [JsonProperty("TITLE_L6")]
        public string TitleL6 { get; set; }

        [JsonProperty("TITLE_PO")]
        public string TitlePo { get; set; }

        [JsonProperty("TITLE_SP")]
        public string TitleSp { get; set; }

        [JsonProperty("TITLE_URL")]
        public string TitleUrl { get; set; }
    }

    public class ViewCatalogRequestResponseCatalogRequestsPathType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("SD_CATALOG_PATH_FR")]
        public string SdCatalogPathFr { get; set; }
    }

    public class ViewCatalogRequestResponseCommentCatalogType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionEnType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionFrType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionGeType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionItType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionL1Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionL2Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionL3Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionL4Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionL5Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionL6Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionPoType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseDescriptionSpType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewCatalogRequestResponseManagerType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class ViewCatalogRequestResponseSlaType
    {
        [JsonProperty("DELAY")]
        public string Delay { get; set; }

        [JsonProperty("NAME_FR")]
        public string NameFr { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }
    }

    public class ViewConfigurationItemsListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewConfigurationItemsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewConfigurationItemsListResponseRecordsTypeItem
    {
        [JsonProperty("ASSET_ID")]
        public string AssetId { get; set; }

        [JsonProperty("ASSET_TAG")]
        public string AssetTag { get; set; }

        [JsonProperty("CI_STATUS_ID")]
        public string CiStatusId { get; set; }

        [JsonProperty("CI_VERSION")]
        public string CiVersion { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("NETWORK_IDENTIFIER")]
        public string NetworkIdentifier { get; set; }
    }

    public class ViewConfigurationItemResponse
    {
        [JsonProperty("ACQUISITION_TYPE_ID")]
        public string AcquisitionTypeId { get; set; }

        [JsonProperty("ASSET_GUID")]
        public string AssetGuid { get; set; }

        [JsonProperty("ASSET_ID")]
        public string AssetId { get; set; }

        [JsonProperty("ASSET_LABEL")]
        public string AssetLabel { get; set; }

        [JsonProperty("ASSET_TAG")]
        public string AssetTag { get; set; }

        [JsonProperty("AUTOMATIC_RENEWAL")]
        public string AutomaticRenewal { get; set; }

        [JsonProperty("AVAILABILITY_SLA_ID")]
        public string AvailabilitySlaId { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("BEFORE_LOAN_DEPARTMENT_ID")]
        public string BeforeLoanDepartmentId { get; set; }

        [JsonProperty("BEFORE_LOAN_DEPARTMENT_PATH")]
        public string BeforeLoanDepartmentPath { get; set; }

        [JsonProperty("BEFORE_LOAN_EMPLOYEE_ID")]
        public string BeforeLoanEmployeeId { get; set; }

        [JsonProperty("BEFORE_LOAN_LOCATION_ID")]
        public string BeforeLoanLocationId { get; set; }

        [JsonProperty("BEFORE_LOAN_LOCATION_PATH")]
        public string BeforeLoanLocationPath { get; set; }

        [JsonProperty("BILLING_PERIODICITY_IN_MONTH")]
        public string BillingPeriodicityInMonth { get; set; }

        [JsonProperty("BUDGET_ID")]
        public string BudgetId { get; set; }

        [JsonProperty("BUY_BACK_VALUE")]
        public string BuyBackValue { get; set; }

        [JsonProperty("BUY_BACK_VALUE_CUR_ID")]
        public string BuyBackValueCurId { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CatalogId { get; set; }

        [JsonProperty("CHARGE_BACK")]
        public string ChargeBack { get; set; }

        [JsonProperty("CHARGE_BACK_CUR_ID")]
        public string ChargeBackCurId { get; set; }

        [JsonProperty("CI_BACKUP_BY_DEFAULT")]
        public string CiBackupByDefault { get; set; }

        [JsonProperty("CI_STATUS_ID")]
        public string CiStatusId { get; set; }

        [JsonProperty("CI_VERSION")]
        public string CiVersion { get; set; }

        [JsonProperty("CM_DEFAULT_CHANGE_ID")]
        public string CmDefaultChangeId { get; set; }

        [JsonProperty("CM_DEFAULT_CHANGE_PATH")]
        public string CmDefaultChangePath { get; set; }

        [JsonProperty("COMMENT_ASSET")]
        public ViewConfigurationItemResponseCommentAssetType CommentAsset { get; set; }

        [JsonProperty("CONFIGURATION_ID")]
        public string ConfigurationId { get; set; }

        [JsonProperty("CONTRACT_TYPE_ID")]
        public string ContractTypeId { get; set; }

        [JsonProperty("CRITICAL_LEVEL_ID")]
        public string CriticalLevelId { get; set; }

        [JsonProperty("DELIVERY_DATE")]
        public string DeliveryDate { get; set; }

        [JsonProperty("DELIVERY_NUMBER")]
        public string DeliveryNumber { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("DEPRECIATION_RULE_ID")]
        public string DepreciationRuleId { get; set; }

        [JsonProperty("D_HARDWARE_GUID")]
        public string DHardwareGuid { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("END_OF_WARANTY")]
        public string EndOfWaranty { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string EntryDate { get; set; }

        [JsonProperty("ESTIMATED_PERCENTAGE_USE")]
        public string EstimatedPercentageUse { get; set; }

        [JsonProperty("EXPECTED_END_LEND_DATE")]
        public string ExpectedEndLendDate { get; set; }

        [JsonProperty("EXPECTED_RETURN_DATE")]
        public string ExpectedReturnDate { get; set; }

        [JsonProperty("FALLEN_TERM")]
        public string FallenTerm { get; set; }

        [JsonProperty("FIXED_ASSET_NUMBER")]
        public string FixedAssetNumber { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("INITIAL_START")]
        public string InitialStart { get; set; }

        [JsonProperty("INSTALLATION_DATE")]
        public string InstallationDate { get; set; }

        [JsonProperty("INTERNAL_DELIVERY_DATE")]
        public string InternalDeliveryDate { get; set; }

        [JsonProperty("INTERNAL_DISPO")]
        public string InternalDispo { get; set; }

        [JsonProperty("INVENTORY_ID")]
        public string InventoryId { get; set; }

        [JsonProperty("INVOICE_NUMBER")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("IS_CI")]
        public string IsCi { get; set; }

        [JsonProperty("IS_DML")]
        public string IsDml { get; set; }

        [JsonProperty("IS_LOCKED")]
        public string IsLocked { get; set; }

        [JsonProperty("IS_SERVICE")]
        public string IsService { get; set; }

        [JsonProperty("LAST_AUTOMATIC_DISCOVERY")]
        public string LastAutomaticDiscovery { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LastIntegration { get; set; }

        [JsonProperty("LAST_PAYMENT")]
        public string LastPayment { get; set; }

        [JsonProperty("LAST_PAYMENT_CUR_ID")]
        public string LastPaymentCurId { get; set; }

        [JsonProperty("LAST_PHYSICAL_INVENTORY")]
        public string LastPhysicalInventory { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("LICENSE_VERSION")]
        public string LicenseVersion { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("LOCATION_TO_CHECK_REQUEST_ID")]
        public string LocationToCheckRequestId { get; set; }

        [JsonProperty("MAINTENANCE_COST")]
        public string MaintenanceCost { get; set; }

        [JsonProperty("MAINTENANCE_COST_CUR_ID")]
        public string MaintenanceCostCurId { get; set; }

        [JsonProperty("MAIN_USAGE_ID")]
        public string MainUsageId { get; set; }

        [JsonProperty("MAX_INSTALLS")]
        public string MaxInstalls { get; set; }

        [JsonProperty("MONTHLY_FIXED_COST")]
        public string MonthlyFixedCost { get; set; }

        [JsonProperty("MONTHLY_FIXED_COST_CUR_ID")]
        public string MonthlyFixedCostCurId { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL")]
        public string MonthlyNetRental { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL_CUR_ID")]
        public string MonthlyNetRentalCurId { get; set; }

        [JsonProperty("MONTH_DURATION")]
        public string MonthDuration { get; set; }

        [JsonProperty("NETWORK_IDENTIFIER")]
        public string NetworkIdentifier { get; set; }

        [JsonProperty("NEXT_CI_VERSION")]
        public string NextCiVersion { get; set; }

        [JsonProperty("NEXT_DEPARTMENT_ID")]
        public string NextDepartmentId { get; set; }

        [JsonProperty("NEXT_DEPARTMENT_PATH")]
        public string NextDepartmentPath { get; set; }

        [JsonProperty("NEXT_MAINTENANCE_DATE")]
        public string NextMaintenanceDate { get; set; }

        [JsonProperty("NEXT_STATUS_ID")]
        public string NextStatusId { get; set; }

        [JsonProperty("NEXT_USER_APPLICATION_DATE")]
        public string NextUserApplicationDate { get; set; }

        [JsonProperty("NEXT_USER_ID")]
        public string NextUserId { get; set; }

        [JsonProperty("NOTICE")]
        public string Notice { get; set; }

        [JsonProperty("ORDER_DETAILS_ID")]
        public string OrderDetailsId { get; set; }

        [JsonProperty("ORDER_NUMBER")]
        public string OrderNumber { get; set; }

        [JsonProperty("OWNERSHIP_TO_CHECK_REQUEST_ID")]
        public string OwnershipToCheckRequestId { get; set; }

        [JsonProperty("PACKAGE_PATH")]
        public string PackagePath { get; set; }

        [JsonProperty("PIPELINE_STATUS_ID")]
        public string PipelineStatusId { get; set; }

        [JsonProperty("POWER_CONSUMPTION_WH")]
        public string PowerConsumptionWh { get; set; }

        [JsonProperty("PROCESSOR_COUNT")]
        public string ProcessorCount { get; set; }

        [JsonProperty("PROCESSOR_SOCKET_COUNT")]
        public string ProcessorSocketCount { get; set; }

        [JsonProperty("PROJECT_ID")]
        public string ProjectId { get; set; }

        [JsonProperty("PROVIDER_ID")]
        public string ProviderId { get; set; }

        [JsonProperty("PROVIDER_PATH")]
        public string ProviderPath { get; set; }

        [JsonProperty("PURCHASE_DATE")]
        public string PurchaseDate { get; set; }

        [JsonProperty("PURCHASE_PRICE")]
        public string PurchasePrice { get; set; }

        [JsonProperty("PURCHASE_PRICE_CUR_ID")]
        public string PurchasePriceCurId { get; set; }

        [JsonProperty("PURCHASE_RATE_ID")]
        public string PurchaseRateId { get; set; }

        [JsonProperty("RECYCLED_DATE")]
        public string RecycledDate { get; set; }

        [JsonProperty("RECYCLING_PROVIDER_ID")]
        public string RecyclingProviderId { get; set; }

        [JsonProperty("RECYCLING_PROVIDER_PATH")]
        public string RecyclingProviderPath { get; set; }

        [JsonProperty("REFORM_NUMBER")]
        public string ReformNumber { get; set; }

        [JsonProperty("REMOVED_DATE")]
        public string RemovedDate { get; set; }

        [JsonProperty("RENEWAL_DECISION_ID")]
        public string RenewalDecisionId { get; set; }

        [JsonProperty("RENEWAL_VALUE")]
        public string RenewalValue { get; set; }

        [JsonProperty("RENEWAL_VALUE_CUR_ID")]
        public string RenewalValueCurId { get; set; }

        [JsonProperty("REPAIRED_BY_ID")]
        public string RepairedById { get; set; }

        [JsonProperty("REPAIRED_BY_PATH")]
        public string RepairedByPath { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string RequestId { get; set; }

        [JsonProperty("RESALES_VALUE")]
        public string ResalesValue { get; set; }

        [JsonProperty("SCHEDULED_END")]
        public string ScheduledEnd { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SdCatalogPath { get; set; }

        [JsonProperty("SD_DEFAULT_INCIDENT_ID")]
        public string SdDefaultIncidentId { get; set; }

        [JsonProperty("SD_DEFAULT_INCIDENT_PATH")]
        public string SdDefaultIncidentPath { get; set; }

        [JsonProperty("SD_DEFAULT_REQUEST_ID")]
        public string SdDefaultRequestId { get; set; }

        [JsonProperty("SD_DEFAULT_REQUEST_PATH")]
        public string SdDefaultRequestPath { get; set; }

        [JsonProperty("SERIAL_NUMBER")]
        public string SerialNumber { get; set; }

        [JsonProperty("SERVER_TYPE_ID")]
        public string ServerTypeId { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }

        [JsonProperty("STATUS_ID")]
        public string StatusId { get; set; }

        [JsonProperty("SUPPLIER_ID")]
        public string SupplierId { get; set; }

        [JsonProperty("SUPPLIER_PATH")]
        public string SupplierPath { get; set; }

        [JsonProperty("TERM")]
        public string Term { get; set; }

        [JsonProperty("UPDATED_BY_DISCOVERY")]
        public string UpdatedByDiscovery { get; set; }

        [JsonProperty("UPDATE_COVERAGE_TERM")]
        public string UpdateCoverageTerm { get; set; }

        [JsonProperty("WARANTY_TYPE_ID")]
        public string WarantyTypeId { get; set; }

        [JsonProperty("XPOS")]
        public string Xpos { get; set; }

        [JsonProperty("YPOS")]
        public string Ypos { get; set; }

        [JsonProperty("ZPOS")]
        public string Zpos { get; set; }
    }

    public class ViewConfigurationItemResponseCommentAssetType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewConfigurationItemLinksResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewConfigurationItemLinksResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewConfigurationItemLinksResponseRecordsTypeItem
    {
        [JsonProperty("BLOCKING")]
        public string Blocking { get; set; }

        [JsonProperty("CHILD_CI_ID")]
        public string ChildCiId { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("PARENT_CI_ID")]
        public string ParentCiId { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string ParentHref { get; set; }

        [JsonProperty("RELATION_TYPE")]
        public ViewConfigurationItemLinksResponseRecordsTypeItemRelationTypeType RelationType { get; set; }

        [JsonProperty("RELATION_TYPE_ID")]
        public string RelationTypeId { get; set; }
    }

    public class ViewConfigurationItemLinksResponseRecordsTypeItemRelationTypeType
    {
        [JsonProperty("REFERENCE_FR")]
        public string ReferenceFr { get; set; }

        [JsonProperty("REFERENCE_ID")]
        public string ReferenceId { get; set; }
    }

    public class ViewConfigurationItemLinkResponse
    {
        [JsonProperty("BLOCKING")]
        public string Blocking { get; set; }

        [JsonProperty("CHILD_CI_ID")]
        public string ChildCiId { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("PARENT_CI_ID")]
        public string ParentCiId { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string ParentHref { get; set; }

        [JsonProperty("RELATION_TYPE")]
        public ViewConfigurationItemLinkResponseRelationTypeType RelationType { get; set; }

        [JsonProperty("RELATION_TYPE_ID")]
        public string RelationTypeId { get; set; }
    }

    public class ViewConfigurationItemLinkResponseRelationTypeType
    {
        [JsonProperty("REFERENCE_FR")]
        public string ReferenceFr { get; set; }

        [JsonProperty("REFERENCE_ID")]
        public string ReferenceId { get; set; }
    }

    public class CreateConfigurationItemLinkResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class CreateConfigurationItemLinkBodyInput
    {
        public CreateConfigurationItemLinkBodyInput(string relationTypeId)
        {
            this.RelationTypeId = relationTypeId;
        }

        public string Blocking { get; set; }

        [JsonProperty("Relation_Type_ID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RelationTypeId { get; set; }
    }

    public class UpdateConfigurationItemLinkResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class UpdateConfigurationItemLinkBodyInput
    {
        public string Blocking { get; set; }

        [JsonProperty("Relation_Type_ID")]
        public string RelationTypeId { get; set; }
    }

    public class ViewEntitiesListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewEntitiesListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewEntitiesListResponseRecordsTypeItem
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DepartmentCode { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DepartmentFr { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DepartmentLabel { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewEntityResponse
    {
        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("COMMENT_DEPARTMENT")]
        public ViewEntityResponseCommentDepartmentType CommentDepartment { get; set; }

        [JsonProperty("CURRENCY_ID")]
        public string CurrencyId { get; set; }

        [JsonProperty("DEFAULT_COST_CENTER_ID")]
        public string DefaultCostCenterId { get; set; }

        [JsonProperty("DEPARTMENT_CODE")]
        public string DepartmentCode { get; set; }

        [JsonProperty("DEPARTMENT_EN")]
        public string DepartmentEn { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DepartmentFr { get; set; }

        [JsonProperty("DEPARTMENT_GE")]
        public string DepartmentGe { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_IT")]
        public string DepartmentIt { get; set; }

        [JsonProperty("DEPARTMENT_L1")]
        public string DepartmentL1 { get; set; }

        [JsonProperty("DEPARTMENT_L2")]
        public string DepartmentL2 { get; set; }

        [JsonProperty("DEPARTMENT_L3")]
        public string DepartmentL3 { get; set; }

        [JsonProperty("DEPARTMENT_L4")]
        public string DepartmentL4 { get; set; }

        [JsonProperty("DEPARTMENT_L5")]
        public string DepartmentL5 { get; set; }

        [JsonProperty("DEPARTMENT_L6")]
        public string DepartmentL6 { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DepartmentLabel { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("DEPARTMENT_PO")]
        public string DepartmentPo { get; set; }

        [JsonProperty("DEPARTMENT_SP")]
        public string DepartmentSp { get; set; }

        [JsonProperty("END_DATE")]
        public string EndDate { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LastIntegration { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("LEVEL")]
        public string Level { get; set; }

        [JsonProperty("MANAGER_ID")]
        public string ManagerId { get; set; }

        [JsonProperty("PARENT_DEPARTMENT_ID")]
        public string ParentDepartmentId { get; set; }

        [JsonProperty("PARENT_DEPARTMENT_PATH")]
        public string ParentDepartmentPath { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }

        [JsonProperty("START_DATE")]
        public string StartDate { get; set; }

        [JsonProperty("URL_MAP")]
        public string UrlMap { get; set; }
    }

    public class ViewEntityResponseCommentDepartmentType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewEmployeesListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewEmployeesListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewEmployeesListResponseRecordsTypeItem
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT")]
        public ViewEmployeesListResponseRecordsTypeItemDepartmentType Department { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION")]
        public ViewEmployeesListResponseRecordsTypeItemLocationType Location { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("MANAGER")]
        public ViewEmployeesListResponseRecordsTypeItemManagerType Manager { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class ViewEmployeesListResponseRecordsTypeItemDepartmentType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DepartmentCode { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DepartmentFr { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DepartmentLabel { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewEmployeesListResponseRecordsTypeItemLocationType
    {
        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LocationCode { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LocationFr { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }
    }

    public class ViewEmployeesListResponseRecordsTypeItemManagerType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class CreateEmployeeResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class CreateEmployeeBodyInput
    {
        [JsonProperty("employees")]
        public BodyInputEmployeesTypeItem[] Employees { get; set; }
    }

    public class BodyInputEmployeesTypeItem
    {
        [JsonProperty("Begin_of_Contract")]
        public string BeginOfContract { get; set; }

        [JsonProperty("Comment_Employee")]
        public string CommentEmployee { get; set; }

        [JsonProperty("E_mail")]
        public string EMail { get; set; }

        [JsonProperty("Last_Name")]
        public string LastName { get; set; }
        public string Login { get; set; }

        [JsonProperty("Phone_Number")]
        public string PhoneNumber { get; set; }
    }

    public class ViewEmployeeResponse
    {
        [JsonProperty("APPROVED_TO_VALIDATE")]
        public string ApprovedToValidate { get; set; }

        [JsonProperty("AVAILABILITY_STATUS_ID")]
        public string AvailabilityStatusId { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("CHAT_LOGIN")]
        public string ChatLogin { get; set; }

        [JsonProperty("CIVIL_STATUS_ID")]
        public string CivilStatusId { get; set; }

        [JsonProperty("COMMENT_EMPLOYEE")]
        public ViewEmployeeResponseCommentEmployeeType CommentEmployee { get; set; }

        [JsonProperty("COST_PER_HOUR")]
        public string CostPerHour { get; set; }

        [JsonProperty("COST_PER_HOUR_CUR_ID")]
        public string CostPerHourCurId { get; set; }

        [JsonProperty("DEFAULT_COST_CENTER_ID")]
        public string DefaultCostCenterId { get; set; }

        [JsonProperty("DELEGATION_FROM")]
        public string DelegationFrom { get; set; }

        [JsonProperty("DELEGATION_ID")]
        public string DelegationId { get; set; }

        [JsonProperty("DELEGATION_TO")]
        public string DelegationTo { get; set; }

        [JsonProperty("DEPARTMENT")]
        public ViewEmployeeResponseDepartmentType Department { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("END_OF_CONTRACT")]
        public string EndOfContract { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("E_PTO")]
        public string EPto { get; set; }

        [JsonProperty("E_SANDBOX_USER")]
        public string ESandboxUser { get; set; }

        [JsonProperty("FAX_NUMBER")]
        public string FaxNumber { get; set; }

        [JsonProperty("FUNCTION_ID")]
        public string FunctionId { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("ICQ_NUMBER")]
        public string IcqNumber { get; set; }

        [JsonProperty("IDENTIFICATION")]
        public string Identification { get; set; }

        [JsonProperty("IMPACT")]
        public string Impact { get; set; }

        [JsonProperty("IS_AUTOMATIC_STATUS")]
        public string IsAutomaticStatus { get; set; }

        [JsonProperty("IS_SYSTEM")]
        public string IsSystem { get; set; }

        [JsonProperty("IT_CORRESPONDENT")]
        public string ItCorrespondent { get; set; }

        [JsonProperty("LANGUAGE_ID")]
        public string LanguageId { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LastIntegration { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("LOCATION")]
        public ViewEmployeeResponseLocationType Location { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("LOCATION_TO_CHECK_REQUEST_ID")]
        public string LocationToCheckRequestId { get; set; }

        [JsonProperty("LOGIN")]
        public string Login { get; set; }

        [JsonProperty("MAIL_ALERT")]
        public string MailAlert { get; set; }

        [JsonProperty("MANAGER")]
        public ViewEmployeeResponseManagerType Manager { get; set; }

        [JsonProperty("MANAGER_ID")]
        public string ManagerId { get; set; }

        [JsonProperty("MESSENGER_SIGN_NAME")]
        public string MessengerSignName { get; set; }

        [JsonProperty("NOTIFICATION_TYPE_ID")]
        public string NotificationTypeId { get; set; }

        [JsonProperty("PASSWD_LAST_UPDATE_UT")]
        public string PasswdLastUpdateUt { get; set; }

        [JsonProperty("PERSON_IN_CHARGE")]
        public string PersonInCharge { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        [JsonProperty("PICTURE_PATH")]
        public string PicturePath { get; set; }

        [JsonProperty("PLANNING_ID")]
        public string PlanningId { get; set; }

        [JsonProperty("STYLE_ID")]
        public string StyleId { get; set; }

        [JsonProperty("SUPPLIER_ID")]
        public string SupplierId { get; set; }

        [JsonProperty("SUPPLIER_PATH")]
        public string SupplierPath { get; set; }

        [JsonProperty("TITLE_ID")]
        public string TitleId { get; set; }

        [JsonProperty("TRIAL_END")]
        public string TrialEnd { get; set; }

        [JsonProperty("VALIDATION_LEVEL")]
        public string ValidationLevel { get; set; }

        [JsonProperty("VALIDATOR_ID")]
        public string ValidatorId { get; set; }

        [JsonProperty("VIP")]
        public string Vip { get; set; }

        [JsonProperty("VIP_LEVEL_ID")]
        public string VipLevelId { get; set; }

        [JsonProperty("WAVE_ADDRESS")]
        public string WaveAddress { get; set; }
    }

    public class ViewEmployeeResponseCommentEmployeeType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewEmployeeResponseDepartmentType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DepartmentCode { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DepartmentFr { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DepartmentLabel { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewEmployeeResponseLocationType
    {
        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LocationCode { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LocationFr { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }
    }

    public class ViewEmployeeResponseManagerType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class UpdateEmployeeResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class UpdateEmployeeBodyInput
    {
        [JsonProperty("APPROVED_TO_VALIDATE")]
        public string ApprovedToValidate { get; set; }

        [JsonProperty("AVAILABILITY_STATUS_ID")]
        public string AvailabilityStatusId { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("CHAT_LOGIN")]
        public string ChatLogin { get; set; }

        [JsonProperty("CIVIL_STATUS_ID")]
        public string CivilStatusId { get; set; }

        [JsonProperty("COMMENT_EMPLOYEE")]
        public string CommentEmployee { get; set; }

        [JsonProperty("COST_PER_HOUR")]
        public string CostPerHour { get; set; }

        [JsonProperty("COST_PER_HOUR_CUR_ID")]
        public string CostPerHourCurId { get; set; }

        [JsonProperty("DEFAULT_COST_CENTER_ID")]
        public string DefaultCostCenterId { get; set; }

        [JsonProperty("DELEGATION_FROM")]
        public string DelegationFrom { get; set; }

        [JsonProperty("DELEGATION_ID")]
        public string DelegationId { get; set; }

        [JsonProperty("DELEGATION_TO")]
        public string DelegationTo { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("END_OF_CONTRACT")]
        public string EndOfContract { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("FAX_NUMBER")]
        public string FaxNumber { get; set; }

        [JsonProperty("FUNCTION_ID")]
        public string FunctionId { get; set; }

        [JsonProperty("ICQ_NUMBER")]
        public string IcqNumber { get; set; }

        [JsonProperty("IDENTIFICATION")]
        public string Identification { get; set; }

        [JsonProperty("IS_AUTOMATIC_STATUS")]
        public string IsAutomaticStatus { get; set; }

        [JsonProperty("IT_CORRESPONDENT")]
        public string ItCorrespondent { get; set; }

        [JsonProperty("LANGUAGE_ID")]
        public string LanguageId { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LastIntegration { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOGIN")]
        public string Login { get; set; }

        [JsonProperty("MANAGER_ID")]
        public string ManagerId { get; set; }

        [JsonProperty("MESSENGER_SIGN_NAME")]
        public string MessengerSignName { get; set; }

        [JsonProperty("NOTIFICATION_TYPE_ID")]
        public string NotificationTypeId { get; set; }

        [JsonProperty("PASSWD_LAST_UPDATE_UT")]
        public string PasswdLastUpdateUt { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        [JsonProperty("PICTURE_PATH")]
        public string PicturePath { get; set; }

        [JsonProperty("SUPPLIER_ID")]
        public string SupplierId { get; set; }

        [JsonProperty("VALIDATOR_ID")]
        public string ValidatorId { get; set; }

        [JsonProperty("VIP_LEVEL_ID")]
        public string VipLevelId { get; set; }

        [JsonProperty("WAVE_ADDRESS")]
        public string WaveAddress { get; set; }
    }

    public class ViewKnownErrorsListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewKnownErrorsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewKnownErrorsListResponseRecordsTypeItem
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KnownProblemsId { get; set; }

        [JsonProperty("KNOWN_PROBLEM_PATH")]
        public string KnownProblemPath { get; set; }

        [JsonProperty("KP_NUMBER")]
        public string KpNumber { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QuestionFr { get; set; }
    }

    public class ViewKnownErrorsResponse
    {
        [JsonProperty("ANSWER_EN")]
        public ViewKnownErrorsResponseAnswerEnType AnswerEn { get; set; }

        [JsonProperty("ANSWER_FR")]
        public ViewKnownErrorsResponseAnswerFrType AnswerFr { get; set; }

        [JsonProperty("ANSWER_GE")]
        public ViewKnownErrorsResponseAnswerGeType AnswerGe { get; set; }

        [JsonProperty("ANSWER_IT")]
        public ViewKnownErrorsResponseAnswerItType AnswerIt { get; set; }

        [JsonProperty("ANSWER_L1")]
        public ViewKnownErrorsResponseAnswerL1Type AnswerL1 { get; set; }

        [JsonProperty("ANSWER_L2")]
        public ViewKnownErrorsResponseAnswerL2Type AnswerL2 { get; set; }

        [JsonProperty("ANSWER_L3")]
        public ViewKnownErrorsResponseAnswerL3Type AnswerL3 { get; set; }

        [JsonProperty("ANSWER_L4")]
        public ViewKnownErrorsResponseAnswerL4Type AnswerL4 { get; set; }

        [JsonProperty("ANSWER_L5")]
        public ViewKnownErrorsResponseAnswerL5Type AnswerL5 { get; set; }

        [JsonProperty("ANSWER_L6")]
        public ViewKnownErrorsResponseAnswerL6Type AnswerL6 { get; set; }

        [JsonProperty("ANSWER_PO")]
        public ViewKnownErrorsResponseAnswerPoType AnswerPo { get; set; }

        [JsonProperty("ANSWER_SP")]
        public ViewKnownErrorsResponseAnswerSpType AnswerSp { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("CREATION_DATE")]
        public string CreationDate { get; set; }

        [JsonProperty("END_DATE")]
        public string EndDate { get; set; }

        [JsonProperty("EXPECTED_RESOLUTION_DATE")]
        public string ExpectedResolutionDate { get; set; }

        [JsonProperty("E_URL")]
        public ViewKnownErrorsResponseEUrlType EUrl { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("IMPLEMENTATION_TIME")]
        public string ImplementationTime { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KnownProblemsId { get; set; }

        [JsonProperty("KNOWN_PROBLEM_PATH")]
        public string KnownProblemPath { get; set; }

        [JsonProperty("KP_NUMBER")]
        public string KpNumber { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("LAST_UPDATE_UT")]
        public string LastUpdateUt { get; set; }

        [JsonProperty("QUESTION_EN")]
        public string QuestionEn { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QuestionFr { get; set; }

        [JsonProperty("QUESTION_GE")]
        public string QuestionGe { get; set; }

        [JsonProperty("QUESTION_IT")]
        public string QuestionIt { get; set; }

        [JsonProperty("QUESTION_L1")]
        public string QuestionL1 { get; set; }

        [JsonProperty("QUESTION_L2")]
        public string QuestionL2 { get; set; }

        [JsonProperty("QUESTION_L3")]
        public string QuestionL3 { get; set; }

        [JsonProperty("QUESTION_L4")]
        public string QuestionL4 { get; set; }

        [JsonProperty("QUESTION_L5")]
        public string QuestionL5 { get; set; }

        [JsonProperty("QUESTION_L6")]
        public string QuestionL6 { get; set; }

        [JsonProperty("QUESTION_PO")]
        public string QuestionPo { get; set; }

        [JsonProperty("QUESTION_SP")]
        public string QuestionSp { get; set; }

        [JsonProperty("REVISION_DATE")]
        public string RevisionDate { get; set; }

        [JsonProperty("REVISION_DATE_UT")]
        public string RevisionDateUt { get; set; }

        [JsonProperty("VERSION")]
        public string Version { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerEnType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerFrType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerGeType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerItType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerL1Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerL2Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerL3Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerL4Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerL5Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerL6Type
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerPoType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseAnswerSpType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewKnownErrorsResponseEUrlType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewLocationsListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewLocationsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewLocationsListResponseRecordsTypeItem
    {
        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LocationCode { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LocationFr { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }
    }

    public class ViewLocationResponse
    {
        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("COMMENT_LOCATION")]
        public ViewLocationResponseCommentLocationType CommentLocation { get; set; }

        [JsonProperty("COUNTRY_ID")]
        public string CountryId { get; set; }

        [JsonProperty("DISCOVERY_NAME")]
        public string DiscoveryName { get; set; }

        [JsonProperty("END_DATE")]
        public string EndDate { get; set; }

        [JsonProperty("E_CAPACITY")]
        public string ECapacity { get; set; }

        [JsonProperty("E_IS_MEETING_ROOM")]
        public string EIsMeetingRoom { get; set; }

        [JsonProperty("E_WIFI_LOGIN")]
        public string EWifiLogin { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("G_MAP_LAT")]
        public string GMapLat { get; set; }

        [JsonProperty("G_MAP_LNG")]
        public string GMapLng { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("IS_DELIVERY_ADDRESS")]
        public string IsDeliveryAddress { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LastIntegration { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("LEVEL")]
        public string Level { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LocationCode { get; set; }

        [JsonProperty("LOCATION_EN")]
        public string LocationEn { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LocationFr { get; set; }

        [JsonProperty("LOCATION_GE")]
        public string LocationGe { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_IT")]
        public string LocationIt { get; set; }

        [JsonProperty("LOCATION_L1")]
        public string LocationL1 { get; set; }

        [JsonProperty("LOCATION_L2")]
        public string LocationL2 { get; set; }

        [JsonProperty("LOCATION_L3")]
        public string LocationL3 { get; set; }

        [JsonProperty("LOCATION_L4")]
        public string LocationL4 { get; set; }

        [JsonProperty("LOCATION_L5")]
        public string LocationL5 { get; set; }

        [JsonProperty("LOCATION_L6")]
        public string LocationL6 { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("LOCATION_PO")]
        public string LocationPo { get; set; }

        [JsonProperty("LOCATION_SP")]
        public string LocationSp { get; set; }

        [JsonProperty("MANAGER_ID")]
        public string ManagerId { get; set; }

        [JsonProperty("PARENT_LOCATION_ID")]
        public string ParentLocationId { get; set; }

        [JsonProperty("PARENT_LOCATION_PATH")]
        public string ParentLocationPath { get; set; }

        [JsonProperty("PHONE")]
        public string Phone { get; set; }

        [JsonProperty("REGION_ZONE_ID")]
        public string RegionZoneId { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }

        [JsonProperty("START_DATE")]
        public string StartDate { get; set; }

        [JsonProperty("STATE_ID")]
        public string StateId { get; set; }

        [JsonProperty("STATUS_ID")]
        public string StatusId { get; set; }

        [JsonProperty("STREET_ADDRESS_1")]
        public string StreetAddress1 { get; set; }

        [JsonProperty("STREET_ADDRESS_2")]
        public string StreetAddress2 { get; set; }

        [JsonProperty("TIME_ZONE_ID")]
        public string TimeZoneId { get; set; }

        [JsonProperty("URL_MAP")]
        public string UrlMap { get; set; }

        [JsonProperty("ZIP_CODE")]
        public string ZipCode { get; set; }
    }

    public class ViewLocationResponseCommentLocationType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewManufacturerListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewManufacturerListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewManufacturerListResponseRecordsTypeItem
    {
        [JsonProperty("DISCOVERY_NAME")]
        public string DiscoveryName { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("MANUFACTURER")]
        public string Manufacturer { get; set; }

        [JsonProperty("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
    }

    public class ViewManufacturerResponse
    {
        [JsonProperty("DISCOVERY_NAME")]
        public string DiscoveryName { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("IS_MANUFACTURER")]
        public string IsManufacturer { get; set; }

        [JsonProperty("IS_PUBLISHER")]
        public string IsPublisher { get; set; }

        [JsonProperty("MANUFACTURER")]
        public string Manufacturer { get; set; }

        [JsonProperty("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }

        [JsonProperty("WEB_SITE")]
        public string WebSite { get; set; }
    }

    public class ViewRequestsIncidentsListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewRequestsIncidentsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItem
    {
        [JsonProperty("CATALOG_REQUEST")]
        public ViewRequestsIncidentsListResponseRecordsTypeItemCatalogRequestType CatalogRequest { get; set; }

        [JsonProperty("COMMENT")]
        public ViewRequestsIncidentsListResponseRecordsTypeItemCommentType Comment { get; set; }

        [JsonProperty("DEPARTMENT")]
        public ViewRequestsIncidentsListResponseRecordsTypeItemDepartmentType Department { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("KNOWN_PROBLEM")]
        public ViewRequestsIncidentsListResponseRecordsTypeItemKnownProblemType KnownProblem { get; set; }

        [JsonProperty("LOCATION")]
        public ViewRequestsIncidentsListResponseRecordsTypeItemLocationType Location { get; set; }

        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MaxResolutionDateUt { get; set; }

        [JsonProperty("RECIPIENT")]
        public ViewRequestsIncidentsListResponseRecordsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("REQUESTOR")]
        public ViewRequestsIncidentsListResponseRecordsTypeItemRequestorType Requestor { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RfcNumber { get; set; }

        [JsonProperty("STATUS")]
        public ViewRequestsIncidentsListResponseRecordsTypeItemStatusType Status { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SubmitDateUt { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemCatalogRequestType
    {
        [JsonProperty("CATALOG_REQUEST_PATH")]
        public string CatalogRequestPath { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TitleFr { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemCommentType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemDepartmentType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DepartmentCode { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DepartmentFr { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DepartmentLabel { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemKnownProblemType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KnownProblemsId { get; set; }

        [JsonProperty("KNOWN_PROBLEM_PATH")]
        public string KnownProblemPath { get; set; }

        [JsonProperty("KP_NUMBER")]
        public string KpNumber { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QuestionFr { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemLocationType
    {
        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LocationCode { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LocationFr { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemRecipientType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemRequestorType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemStatusType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("STATUS_FR")]
        public string StatusFr { get; set; }

        [JsonProperty("STATUS_GUID")]
        public string StatusGuid { get; set; }

        [JsonProperty("STATUS_ID")]
        public string StatusId { get; set; }
    }

    public class CreateRequestIncidentResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class CreateRequestIncidentBodyInput
    {
        [JsonProperty("requests")]
        public BodyInputRequestsTypeItem[] Requests { get; set; }
    }

    public class BodyInputRequestsTypeItem
    {
        [JsonProperty("Asset_ID")]
        public string AssetId { get; set; }

        [JsonProperty("Asset_Label")]
        public string AssetLabel { get; set; }

        [JsonProperty("Asset_Tag")]
        public string AssetTag { get; set; }

        [JsonProperty("CI_Asset_Tag")]
        public string CIAssetTag { get; set; }

        [JsonProperty("CI_ID")]
        public string CiId { get; set; }

        [JsonProperty("CI_Name")]
        public string CIName { get; set; }

        [JsonProperty("Catalog_Code")]
        public string CatalogCode { get; set; }

        [JsonProperty("Department_Code")]
        public string DepartmentCode { get; set; }

        [JsonProperty("Department_ID")]
        public string DepartmentId { get; set; }
        public string Description { get; set; }

        [JsonProperty("External_reference")]
        public string ExternalReference { get; set; }

        [JsonProperty("Location_Code")]
        public string LocationCode { get; set; }

        [JsonProperty("Location_ID")]
        public string LocationId { get; set; }
        public string Origin { get; set; }
        public string ParentRequest { get; set; }
        public string Phone { get; set; }

        [JsonProperty("Recipient_ID")]
        public string RecipientId { get; set; }

        [JsonProperty("Recipient_Identification")]
        public string RecipientIdentification { get; set; }

        [JsonProperty("Recipient_Mail")]
        public string RecipientMail { get; set; }

        [JsonProperty("Recipient_Name")]
        public string RecipientName { get; set; }

        [JsonProperty("Requestor_Identification")]
        public string RequestorIdentification { get; set; }

        [JsonProperty("Requestor_Mail")]
        public string RequestorMail { get; set; }

        [JsonProperty("Requestor_Name")]
        public string RequestorName { get; set; }

        [JsonProperty("Severity_ID")]
        public string SeverityId { get; set; }

        [JsonProperty("Urgency_ID")]
        public string UrgencyId { get; set; }
    }

    public class ViewRequestIncidentResponse
    {
        [JsonProperty("ANALYTICAL_CHARGE_ID")]
        public string AnalyticalChargeId { get; set; }

        [JsonProperty("ANALYTICAL_CHARGE_PATH")]
        public string AnalyticalChargePath { get; set; }

        [JsonProperty("ASSET_ID")]
        public string AssetId { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("BUDGET_EFFECTIVE")]
        public string BudgetEffective { get; set; }

        [JsonProperty("BUDGET_ID")]
        public string BudgetId { get; set; }

        [JsonProperty("BUDGET_PLANNED")]
        public string BudgetPlanned { get; set; }

        [JsonProperty("CAN_BE_DUPLICATED")]
        public string CanBeDuplicated { get; set; }

        [JsonProperty("CATALOG_REQUEST")]
        public ViewRequestIncidentResponseCatalogRequestType CatalogRequest { get; set; }

        [JsonProperty("CI_ID")]
        public string CiId { get; set; }

        [JsonProperty("CLICK_2_GET_INSTALL_RESULT")]
        public string Click2GetInstallResult { get; set; }

        [JsonProperty("COMMENT")]
        public ViewRequestIncidentResponseCommentType Comment { get; set; }

        [JsonProperty("CONTINUITY_PLAN_ID")]
        public string ContinuityPlanId { get; set; }

        [JsonProperty("COST_CENTER_ID")]
        public string CostCenterId { get; set; }

        [JsonProperty("CREATION_DATE_UT")]
        public string CreationDateUt { get; set; }

        [JsonProperty("DELAY")]
        public string Delay { get; set; }

        [JsonProperty("DEPARTMENT")]
        public ViewRequestIncidentResponseDepartmentType Department { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("DESCRIPTION")]
        public ViewRequestIncidentResponseDescriptionType Description { get; set; }

        [JsonProperty("DYNAMIC_DETAILS")]
        public ViewRequestIncidentResponseDynamicDetailsType DynamicDetails { get; set; }

        [JsonProperty("EFFECTIVE_CHANGE_DATE_END")]
        public string EffectiveChangeDateEnd { get; set; }

        [JsonProperty("EFFECTIVE_CHANGE_DATE_START")]
        public string EffectiveChangeDateStart { get; set; }

        [JsonProperty("END_DATE_UT")]
        public string EndDateUt { get; set; }

        [JsonProperty("ESTIMATED_NET_PRICE")]
        public string EstimatedNetPrice { get; set; }

        [JsonProperty("ESTIMATED_PERCENT_COMPLETE")]
        public string EstimatedPercentComplete { get; set; }

        [JsonProperty("EXPECTED_DATE_UT")]
        public string ExpectedDateUt { get; set; }

        [JsonProperty("EXPECTED_DURATION")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("EXPECTED_END_DATE_UT")]
        public string ExpectedEndDateUt { get; set; }

        [JsonProperty("EXPECTED_START_DATE_UT")]
        public string ExpectedStartDateUt { get; set; }

        [JsonProperty("EXTERNAL_REFERENCE")]
        public string ExternalReference { get; set; }

        [JsonProperty("FIRST_CALL_RESOLUTION")]
        public string FirstCallResolution { get; set; }

        [JsonProperty("HOUR_PER_DAY")]
        public string HourPerDay { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("IMPACT_ID")]
        public string ImpactId { get; set; }

        [JsonProperty("IMPUTATION_DATE")]
        public string ImputationDate { get; set; }

        [JsonProperty("INITIAL_SD_CATALOG_ID")]
        public string InitialSdCatalogId { get; set; }

        [JsonProperty("INITIAL_SD_CATALOG_PATH")]
        public string InitialSdCatalogPath { get; set; }

        [JsonProperty("IS_FINANCIAL_COMPTED")]
        public string IsFinancialCompted { get; set; }

        [JsonProperty("IS_MAJOR_INCIDENT")]
        public string IsMajorIncident { get; set; }

        [JsonProperty("IS_TEMPLATE")]
        public string IsTemplate { get; set; }

        [JsonProperty("KBASE_ID")]
        public string KbaseId { get; set; }

        [JsonProperty("KNOWN_PROBLEM")]
        public ViewRequestIncidentResponseKnownProblemType KnownProblem { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KnownProblemsId { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_PATH")]
        public string KnownProblemsPath { get; set; }

        [JsonProperty("LAST_DONE_BY_ID")]
        public string LastDoneById { get; set; }

        [JsonProperty("LAST_GROUP_ID")]
        public string LastGroupId { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LastUpdate { get; set; }

        [JsonProperty("LOCATION")]
        public ViewRequestIncidentResponseLocationType Location { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("MARK_1")]
        public string Mark1 { get; set; }

        [JsonProperty("MARK_2")]
        public string Mark2 { get; set; }

        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MaxResolutionDateUt { get; set; }

        [JsonProperty("MS_PROJECT_IMPORT_VALIDATION_WAITING")]
        public string MSProjectImportValidationWaiting { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NetPrice { get; set; }

        [JsonProperty("NET_PRICE_CUR_ID")]
        public string NetPriceCurId { get; set; }

        [JsonProperty("NEWS_ID")]
        public string NewsId { get; set; }

        [JsonProperty("NOT_DEDUCED_CALL")]
        public string NotDeducedCall { get; set; }

        [JsonProperty("ORDER_ID")]
        public string OrderId { get; set; }

        [JsonProperty("ORDER_NET_PRICE")]
        public string OrderNetPrice { get; set; }

        [JsonProperty("ORIGIN_TOOL_ID")]
        public string OriginToolId { get; set; }

        [JsonProperty("OWNER_ID")]
        public string OwnerId { get; set; }

        [JsonProperty("OWNING_GROUP_ID")]
        public string OwningGroupId { get; set; }

        [JsonProperty("PARENT_REQUEST_ID")]
        public string ParentRequestId { get; set; }

        [JsonProperty("PLANNED_CHANGE_DATE_END")]
        public string PlannedChangeDateEnd { get; set; }

        [JsonProperty("PLANNED_CHANGE_DATE_START")]
        public string PlannedChangeDateStart { get; set; }

        [JsonProperty("PM_STATUS_ID")]
        public string PmStatusId { get; set; }

        [JsonProperty("PROJECT_ID")]
        public string ProjectId { get; set; }

        [JsonProperty("PROJECT_NAME")]
        public string ProjectName { get; set; }

        [JsonProperty("PROJECT_START_DATE_UT")]
        public string ProjectStartDateUt { get; set; }

        [JsonProperty("QTY")]
        public string Qty { get; set; }

        [JsonProperty("RECIPIENT")]
        public ViewRequestIncidentResponseRecipientType Recipient { get; set; }

        [JsonProperty("RECIPIENT_ID")]
        public string RecipientId { get; set; }

        [JsonProperty("RELEASE_ID")]
        public string ReleaseId { get; set; }

        [JsonProperty("RENTAL_NET_PRICE")]
        public string RentalNetPrice { get; set; }

        [JsonProperty("RENTAL_NET_PRICE_CUR_ID")]
        public string RentalNetPriceCurId { get; set; }

        [JsonProperty("REQUALIFICATION_PROCESSING")]
        public string RequalificationProcessing { get; set; }

        [JsonProperty("REQUESTED_CHANGE_DATE_END")]
        public string RequestedChangeDateEnd { get; set; }

        [JsonProperty("REQUESTED_CHANGE_DATE_START")]
        public string RequestedChangeDateStart { get; set; }

        [JsonProperty("REQUESTOR")]
        public ViewRequestIncidentResponseRequestorType Requestor { get; set; }

        [JsonProperty("REQUESTOR_FEEDBACK")]
        public string RequestorFeedback { get; set; }

        [JsonProperty("REQUESTOR_ID")]
        public string RequestorId { get; set; }

        [JsonProperty("REQUESTOR_IP_ADDRESS")]
        public string RequestorIPAddress { get; set; }

        [JsonProperty("REQUESTOR_PHONE")]
        public string RequestorPhone { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string RequestId { get; set; }

        [JsonProperty("REQUEST_ORIGIN_ID")]
        public string RequestOriginId { get; set; }

        [JsonProperty("REQUEST_PROJECT_ID")]
        public string RequestProjectId { get; set; }

        [JsonProperty("REQUIRED_DOWNTIME")]
        public string RequiredDowntime { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RfcNumber { get; set; }

        [JsonProperty("RISK_AMOUNT")]
        public string RiskAmount { get; set; }

        [JsonProperty("RISK_DESCRIPTION")]
        public ViewRequestIncidentResponseRiskDescriptionType RiskDescription { get; set; }

        [JsonProperty("RISK_LEVEL_ID")]
        public string RiskLevelId { get; set; }

        [JsonProperty("ROOT_CAUSE_ID")]
        public string RootCauseId { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SdCatalogPath { get; set; }

        [JsonProperty("SEVERITY_ID")]
        public string SeverityId { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }

        [JsonProperty("STATUS")]
        public ViewRequestIncidentResponseStatusType Status { get; set; }

        [JsonProperty("STATUS_ID")]
        public string StatusId { get; set; }

        [JsonProperty("SUBMITTED_BY")]
        public string SubmittedBy { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SubmitDateUt { get; set; }

        [JsonProperty("SYSTEM_ID")]
        public string SystemId { get; set; }

        [JsonProperty("TIME_USED_TO_DELIVER_FEEDBACK")]
        public string TimeUsedToDeliverFeedback { get; set; }

        [JsonProperty("TIME_USED_TO_SOLVE_REQUEST")]
        public string TimeUsedToSolveRequest { get; set; }

        [JsonProperty("URGENCY_ID")]
        public string UrgencyId { get; set; }

        [JsonProperty("VALIDATION_LEVEL_REQUIRED")]
        public string ValidationLevelRequired { get; set; }

        [JsonProperty("WAVE_ID_TARGET")]
        public string WaveIdTarget { get; set; }
    }

    public class ViewRequestIncidentResponseCatalogRequestType
    {
        [JsonProperty("CATALOG_REQUEST_PATH")]
        public string CatalogRequestPath { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SdCatalogId { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TitleFr { get; set; }
    }

    public class ViewRequestIncidentResponseCommentType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewRequestIncidentResponseDepartmentType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DepartmentCode { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DepartmentFr { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DepartmentId { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DepartmentLabel { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewRequestIncidentResponseDescriptionType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewRequestIncidentResponseDynamicDetailsType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewRequestIncidentResponseKnownProblemType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KnownProblemsId { get; set; }

        [JsonProperty("KNOWN_PROBLEM_PATH")]
        public string KnownProblemPath { get; set; }

        [JsonProperty("KP_NUMBER")]
        public string KpNumber { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QuestionFr { get; set; }
    }

    public class ViewRequestIncidentResponseLocationType
    {
        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LocationCode { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LocationFr { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LocationId { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }
    }

    public class ViewRequestIncidentResponseRecipientType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class ViewRequestIncidentResponseRequestorType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BeginOfContract { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CellularNumber { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DepartmentPath { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EmployeeId { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LocationPath { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }

    public class ViewRequestIncidentResponseRiskDescriptionType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class ViewRequestIncidentResponseStatusType
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("STATUS_FR")]
        public string StatusFr { get; set; }

        [JsonProperty("STATUS_GUID")]
        public string StatusGuid { get; set; }

        [JsonProperty("STATUS_ID")]
        public string StatusId { get; set; }
    }

    public class CloseRequestIncidentResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class CloseRequestIncidentBodyInput
    {
        [JsonProperty("closed")]
        public BodyInputClosedTypeItem[] Closed { get; set; }
    }

    public class BodyInputClosedTypeItem
    {
        [JsonProperty("catalog_GUID")]
        public string CatalogGuid { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("delete_actions")]
        public int? DeleteActions { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("status_GUID")]
        public string StatusGuid { get; set; }
    }

    public class UpdateRequestIncidentResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class UpdateRequestIncidentBodyInput
    {
        [JsonProperty("Analytical_Charge_Id")]
        public string AnalyticalChargeId { get; set; }

        [JsonProperty("Asset_Id")]
        public string AssetId { get; set; }

        [JsonProperty("Available_Field_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("Available_Field_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("Available_Field_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("Available_Field_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("Available_Field_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("Available_Field_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("Budget_Planned")]
        public string BudgetPlanned { get; set; }

        [JsonProperty("Can_Be_Duplicated")]
        public string CanBeDuplicated { get; set; }

        [JsonProperty("Ci_Id")]
        public string CiId { get; set; }
        public string Comment { get; set; }

        [JsonProperty("Continuity_Plan_Id")]
        public string ContinuityPlanId { get; set; }

        [JsonProperty("Cost_Center_Id")]
        public string CostCenterId { get; set; }

        [JsonProperty("Creation_Date_Ut")]
        public string CreationDateUt { get; set; }
        public string Delay { get; set; }
        public string Description { get; set; }

        [JsonProperty("Dynamic_Details")]
        public string DynamicDetails { get; set; }

        [JsonProperty("Effective_Change_Date_End")]
        public string EffectiveChangeDateEnd { get; set; }

        [JsonProperty("Effective_Change_Date_Start")]
        public string EffectiveChangeDateStart { get; set; }

        [JsonProperty("End_Date_Ut")]
        public string EndDateUt { get; set; }

        [JsonProperty("Estimated_Net_Price")]
        public string EstimatedNetPrice { get; set; }

        [JsonProperty("Expected_Date_Ut")]
        public string ExpectedDateUt { get; set; }

        [JsonProperty("Expected_Duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("Expected_End_Date_Ut")]
        public string ExpectedEndDateUt { get; set; }

        [JsonProperty("Expected_Start_Date_Ut")]
        public string ExpectedStartDateUt { get; set; }

        [JsonProperty("External_Reference")]
        public string ExternalReference { get; set; }

        [JsonProperty("First_Call_Resolution")]
        public string FirstCallResolution { get; set; }

        [JsonProperty("Hour_Per_Day")]
        public string HourPerDay { get; set; }

        [JsonProperty("Impact_Id")]
        public string ImpactId { get; set; }

        [JsonProperty("Imputation_Date")]
        public string ImputationDate { get; set; }

        [JsonProperty("Is_Major_Incident")]
        public string IsMajorIncident { get; set; }

        [JsonProperty("Is_Template")]
        public string IsTemplate { get; set; }

        [JsonProperty("Known_Problems_Id")]
        public string KnownProblemsId { get; set; }

        [JsonProperty("Last_Update")]
        public string LastUpdate { get; set; }

        [JsonProperty("Mark_1")]
        public string Mark1 { get; set; }

        [JsonProperty("Mark_2")]
        public string Mark2 { get; set; }

        [JsonProperty("Max_Resolution_Date_Ut")]
        public string MaxResolutionDateUt { get; set; }

        [JsonProperty("Ms_Project_Import_Validation_Waiting")]
        public string MsProjectImportValidationWaiting { get; set; }

        [JsonProperty("Net_Price")]
        public string NetPrice { get; set; }

        [JsonProperty("Net_Price_Cur_Id")]
        public string NetPriceCurId { get; set; }

        [JsonProperty("Origin_Tool_Id")]
        public string OriginToolId { get; set; }

        [JsonProperty("Owner_Id")]
        public string OwnerId { get; set; }

        [JsonProperty("Owning_Group_Id")]
        public string OwningGroupId { get; set; }

        [JsonProperty("Planned_Change_Date_End")]
        public string PlannedChangeDateEnd { get; set; }

        [JsonProperty("Planned_Change_Date_Start")]
        public string PlannedChangeDateStart { get; set; }

        [JsonProperty("Pm_Status_Id")]
        public string PmStatusId { get; set; }

        [JsonProperty("Project_Name")]
        public string ProjectName { get; set; }

        [JsonProperty("Project_Start_Date_Ut")]
        public string ProjectStartDateUt { get; set; }
        public string Qty { get; set; }

        [JsonProperty("Release_Id")]
        public string ReleaseId { get; set; }

        [JsonProperty("Rental_Net_Price")]
        public string RentalNetPrice { get; set; }

        [JsonProperty("Rental_Net_Price_Cur_Id")]
        public string RentalNetPriceCurId { get; set; }

        [JsonProperty("Request_Origin_Id")]
        public string RequestOriginId { get; set; }

        [JsonProperty("Requested_Change_Date_End")]
        public string RequestedChangeDateEnd { get; set; }

        [JsonProperty("Requested_Change_Date_Start")]
        public string RequestedChangeDateStart { get; set; }

        [JsonProperty("Requestor_Id")]
        public string RequestorId { get; set; }

        [JsonProperty("Requestor_Ip_Address")]
        public string RequestorIpAddress { get; set; }

        [JsonProperty("Requestor_Phone")]
        public string RequestorPhone { get; set; }

        [JsonProperty("Risk_Amount")]
        public string RiskAmount { get; set; }

        [JsonProperty("Risk_Description")]
        public string RiskDescription { get; set; }

        [JsonProperty("Risk_Level_Id")]
        public string RiskLevelId { get; set; }

        [JsonProperty("Root_Cause_Id")]
        public string RootCauseId { get; set; }

        [JsonProperty("Submit_Date_Ut")]
        public string SubmitDateUt { get; set; }

        [JsonProperty("Time_Used_To_Solve_Request")]
        public string TimeUsedToSolveRequest { get; set; }
        public string Title { get; set; }
    }

    public class ViewRequestIncidentCommentResponse
    {
        [JsonProperty("COMMENT")]
        public string Comment { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string ParentHref { get; set; }
    }

    public class GetRequestIncidentDocumentListResponse
    {
        public JToken[] Documents { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string ParentHref { get; set; }
    }

    public class UploadAndAttachADocumentToARequestIncidentResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class UploadAndAttachADocumentToARequestIncidentBodyInput
    {
        public UploadAndAttachADocumentToARequestIncidentBodyInput(BodyInputDocumentsTypeItem[] documents)
        {
            this.Documents = documents;
        }

        [JsonProperty("documents", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentsTypeItem[] Documents { get; set; }
    }

    public class BodyInputDocumentsTypeItem
    {
        public BodyInputDocumentsTypeItem(string filedata, string fileName)
        {
            this.Filedata = filedata;
            this.FileName = fileName;
        }

        [JsonProperty("filedata", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filedata { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }
    }

    public class RestartRequestIncidentResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class RestartRequestIncidentBodyInput
    {
        public string Comment { get; set; }

        [JsonProperty("done_by_id")]
        public int? DoneById { get; set; }
    }

    public class SuspendRequestIncidentResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }
    }

    public class SuspendRequestIncidentBodyInput
    {
        public string Comment { get; set; }

        [JsonProperty("done_by_id")]
        public string DoneById { get; set; }
    }

    public class CreateTaskBodyInput
    {
        public CreateTaskBodyInput(string actionTypeId)
        {
            this.ActionTypeId = actionTypeId;
        }

        [JsonProperty("Elapsed_Time")]
        public string ElapsedTime { get; set; }

        [JsonProperty("action_type_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ActionTypeId { get; set; }

        [JsonProperty("available_field_1")]
        public string AvailableField1 { get; set; }

        [JsonProperty("available_field_2")]
        public string AvailableField2 { get; set; }

        [JsonProperty("available_field_3")]
        public string AvailableField3 { get; set; }

        [JsonProperty("available_field_4")]
        public string AvailableField4 { get; set; }

        [JsonProperty("available_field_5")]
        public string AvailableField5 { get; set; }

        [JsonProperty("available_field_6")]
        public string AvailableField6 { get; set; }

        [JsonProperty("contractual_cost")]
        public string ContractualCost { get; set; }

        [JsonProperty("creation_date_ut")]
        public string CreationDateUt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_date_ut")]
        public string EndDateUt { get; set; }

        [JsonProperty("group_mail")]
        public string GroupMail { get; set; }

        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        [JsonProperty("start_date_ut")]
        public string StartDateUt { get; set; }

        [JsonProperty("time_cost")]
        public string TimeCost { get; set; }
    }

    public class ViewSlasListResponse
    {
        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewSlasListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewSlasListResponseRecordsTypeItem
    {
        [JsonProperty("DELAY")]
        public string Delay { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("NAME_FR")]
        public string NameFr { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }
    }

    public class ViewSlaResponse
    {
        [JsonProperty("DELAY")]
        public string Delay { get; set; }

        [JsonProperty("HOLIDAY_LIST_ID")]
        public string HolidayListId { get; set; }

        [JsonProperty("HREF")]
        public string Href { get; set; }

        [JsonProperty("NAME_EN")]
        public string NameEn { get; set; }

        [JsonProperty("NAME_FR")]
        public string NameFr { get; set; }

        [JsonProperty("NAME_GE")]
        public string NameGe { get; set; }

        [JsonProperty("NAME_IT")]
        public string NameIt { get; set; }

        [JsonProperty("NAME_L1")]
        public string NameL1 { get; set; }

        [JsonProperty("NAME_L2")]
        public string NameL2 { get; set; }

        [JsonProperty("NAME_L3")]
        public string NameL3 { get; set; }

        [JsonProperty("NAME_L4")]
        public string NameL4 { get; set; }

        [JsonProperty("NAME_L5")]
        public string NameL5 { get; set; }

        [JsonProperty("NAME_L6")]
        public string NameL6 { get; set; }

        [JsonProperty("NAME_PO")]
        public string NamePo { get; set; }

        [JsonProperty("NAME_SP")]
        public string NameSp { get; set; }

        [JsonProperty("NEXT_BUSINESS_DAY")]
        public string NextBusinessDay { get; set; }

        [JsonProperty("SLA_GUID")]
        public string SlaGuid { get; set; }

        [JsonProperty("SLA_ID")]
        public string SlaId { get; set; }

        [JsonProperty("TIME_LIMIT")]
        public string TimeLimit { get; set; }

        [JsonProperty("TIME_TARGET")]
        public string TimeTarget { get; set; }

        [JsonProperty("WORKING_HOURS_ID")]
        public string WorkingHoursId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Easyvista;

    public partial class WorkflowManagedActions
    {
        public EasyvistaActions Easyvista(string connectionId) => new EasyvistaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EasyvistaTriggers Easyvista(string connectionId) => new EasyvistaTriggers(connectionId);
    }
}