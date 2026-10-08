//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.ServiceNow
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServiceNowActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildGetAttachmentMetdata))]
        public IWorkflowAction GetAttachmentMetdata([WorkflowExpression] Func<string> sysparmLimit = null, [WorkflowExpression] Func<string> sysparmOffset = null, [WorkflowExpression] Func<string> sysparmQuery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetAttachmentMetdata(WorkflowExpression<string> sysparmLimit = null, WorkflowExpression<string> sysparmOffset = null, WorkflowExpression<string> sysparmQuery = null)
        {
            WorkflowExpression.Validate(sysparmLimit, nameof(sysparmLimit), required: false);
            WorkflowExpression.Validate(sysparmOffset, nameof(sysparmOffset), required: false);
            WorkflowExpression.Validate(sysparmQuery, nameof(sysparmQuery), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/now/v1/attachment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sysparm_limit"] = Convert.ToString("1000");
                if (sysparmLimit != null)
                    callPayload.Queries["sysparm_limit"] = ExpressionConverter.Convert(sysparmLimit);
                callPayload.Queries["sysparm_offset"] = Convert.ToString("0");
                if (sysparmOffset != null)
                    callPayload.Queries["sysparm_offset"] = ExpressionConverter.Convert(sysparmOffset);
                if (sysparmQuery != null)
                    callPayload.Queries["sysparm_query"] = ExpressionConverter.Convert(sysparmQuery);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildUploadAttachmentFile))]
        public IBodyWorkflowAction<UploadAttachmentResponse> UploadAttachmentFile([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> tableSysId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> file = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadAttachmentResponse> __BuildUploadAttachmentFile(WorkflowExpression<string> tableName, WorkflowExpression<string> tableSysId, WorkflowExpression<string> fileName, WorkflowExpression<string> file = null)
        {
            WorkflowExpression.Validate(tableName, nameof(tableName), required: true);
            WorkflowExpression.Validate(tableSysId, nameof(tableSysId), required: true);
            WorkflowExpression.Validate(fileName, nameof(fileName), required: true);
            WorkflowExpression.Validate(file, nameof(file), required: false);
            return new DeferredBodyAction<UploadAttachmentResponse>(() =>
            {
                var apiCallPath = "/api/now/v1/attachment/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["table_name"] = ExpressionConverter.Convert(tableName);
                callPayload.Queries["table_sys_id"] = ExpressionConverter.Convert(tableSysId);
                callPayload.Queries["file_name"] = ExpressionConverter.Convert(fileName);
                callPayload.Body = ExpressionConverter.ConvertO(file);
                return new ApiConnectionAction<UploadAttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildUploadAttachment))]
        public IBodyWorkflowAction<UploadAttachmentResponse> UploadAttachment([WorkflowExpression] Func<object> attachmentContent, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> tableSysId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadAttachmentResponse> __BuildUploadAttachment(WorkflowExpression<object> attachmentContent, WorkflowExpression<string> tableName, WorkflowExpression<string> tableSysId)
        {
            WorkflowExpression.Validate(attachmentContent, nameof(attachmentContent), required: true);
            WorkflowExpression.Validate(tableName, nameof(tableName), required: true);
            WorkflowExpression.Validate(tableSysId, nameof(tableSysId), required: true);
            return new DeferredBodyAction<UploadAttachmentResponse>(() =>
            {
                var apiCallPath = "/api/now/v1/attachment/upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadAttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAttachmentMetadata))]
        public IWorkflowAction RetrieveAttachmentMetadata([WorkflowExpression] Func<string> sysId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRetrieveAttachmentMetadata(WorkflowExpression<string> sysId)
        {
            WorkflowExpression.Validate(sysId, nameof(sysId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/now/v1/attachment/{0}", ExpressionConverter.ConvertWithUrlEncoding(sysId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAttachment))]
        public IWorkflowAction DeleteAttachment([WorkflowExpression] Func<string> sysId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteAttachment(WorkflowExpression<string> sysId)
        {
            WorkflowExpression.Validate(sysId, nameof(sysId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/now/v1/attachment/{0}", ExpressionConverter.ConvertWithUrlEncoding(sysId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAttachmentContent))]
        public IWorkflowAction RetrieveAttachmentContent([WorkflowExpression] Func<string> sysId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRetrieveAttachmentContent(WorkflowExpression<string> sysId)
        {
            WorkflowExpression.Validate(sysId, nameof(sysId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/now/v1/attachment/{0}/file", ExpressionConverter.ConvertWithUrlEncoding(sysId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecords))]
        public IBodyWorkflowAction<GetRecordsResponse> GetRecords([WorkflowExpression] Func<string> tableType, [WorkflowExpression] Func<bool> sysparmDisplayValue = null, [WorkflowExpression] Func<bool> sysparmExcludeReferenceLink = null, [WorkflowExpression] Func<string> sysparmQuery = null, [WorkflowExpression] Func<int> sysparmLimit = null, [WorkflowExpression] Func<int> sysparmOffset = null, [WorkflowExpression] Func<string> sysparmFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRecordsResponse> __BuildGetRecords(WorkflowExpression<string> tableType, WorkflowExpression<bool> sysparmDisplayValue = null, WorkflowExpression<bool> sysparmExcludeReferenceLink = null, WorkflowExpression<string> sysparmQuery = null, WorkflowExpression<int> sysparmLimit = null, WorkflowExpression<int> sysparmOffset = null, WorkflowExpression<string> sysparmFields = null)
        {
            WorkflowExpression.Validate(tableType, nameof(tableType), required: true);
            WorkflowExpression.Validate(sysparmDisplayValue, nameof(sysparmDisplayValue), required: false);
            WorkflowExpression.Validate(sysparmExcludeReferenceLink, nameof(sysparmExcludeReferenceLink), required: false);
            WorkflowExpression.Validate(sysparmQuery, nameof(sysparmQuery), required: false);
            WorkflowExpression.Validate(sysparmLimit, nameof(sysparmLimit), required: false);
            WorkflowExpression.Validate(sysparmOffset, nameof(sysparmOffset), required: false);
            WorkflowExpression.Validate(sysparmFields, nameof(sysparmFields), required: false);
            return new DeferredBodyAction<GetRecordsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}", ExpressionConverter.ConvertWithUrlEncoding(tableType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
                if (sysparmDisplayValue != null)
                    callPayload.Queries["sysparm_display_value"] = ExpressionConverter.Convert(sysparmDisplayValue);
                callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
                if (sysparmExcludeReferenceLink != null)
                    callPayload.Queries["sysparm_exclude_reference_link"] = ExpressionConverter.Convert(sysparmExcludeReferenceLink);
                if (sysparmQuery != null)
                    callPayload.Queries["sysparm_query"] = ExpressionConverter.Convert(sysparmQuery);
                if (sysparmLimit != null)
                    callPayload.Queries["sysparm_limit"] = ExpressionConverter.Convert(sysparmLimit);
                if (sysparmOffset != null)
                    callPayload.Queries["sysparm_offset"] = ExpressionConverter.Convert(sysparmOffset);
                if (sysparmFields != null)
                    callPayload.Queries["sysparm_fields"] = ExpressionConverter.Convert(sysparmFields);
                return new ApiConnectionAction<GetRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRecord))]
        public IBodyWorkflowAction<SingleRecordResponse> CreateRecord([WorkflowExpression] Func<string> tableType, [WorkflowExpression] Func<object> body = null, [WorkflowExpression] Func<bool> sysparmDisplayValue = null, [WorkflowExpression] Func<bool> sysparmExcludeReferenceLink = null, [WorkflowExpression] Func<string> sysparmFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleRecordResponse> __BuildCreateRecord(WorkflowExpression<string> tableType, WorkflowExpression<object> body = null, WorkflowExpression<bool> sysparmDisplayValue = null, WorkflowExpression<bool> sysparmExcludeReferenceLink = null, WorkflowExpression<string> sysparmFields = null)
        {
            WorkflowExpression.Validate(tableType, nameof(tableType), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(sysparmDisplayValue, nameof(sysparmDisplayValue), required: false);
            WorkflowExpression.Validate(sysparmExcludeReferenceLink, nameof(sysparmExcludeReferenceLink), required: false);
            WorkflowExpression.Validate(sysparmFields, nameof(sysparmFields), required: false);
            return new DeferredBodyAction<SingleRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}", ExpressionConverter.ConvertWithUrlEncoding(tableType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
                if (sysparmDisplayValue != null)
                    callPayload.Queries["sysparm_display_value"] = ExpressionConverter.Convert(sysparmDisplayValue);
                callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
                if (sysparmExcludeReferenceLink != null)
                    callPayload.Queries["sysparm_exclude_reference_link"] = ExpressionConverter.Convert(sysparmExcludeReferenceLink);
                if (sysparmFields != null)
                    callPayload.Queries["sysparm_fields"] = ExpressionConverter.Convert(sysparmFields);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecord))]
        public IBodyWorkflowAction<SingleRecordResponse> GetRecord([WorkflowExpression] Func<string> tableType, [WorkflowExpression] Func<string> sysid, [WorkflowExpression] Func<bool> sysparmDisplayValue = null, [WorkflowExpression] Func<bool> sysparmExcludeReferenceLink = null, [WorkflowExpression] Func<string> sysparmFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleRecordResponse> __BuildGetRecord(WorkflowExpression<string> tableType, WorkflowExpression<string> sysid, WorkflowExpression<bool> sysparmDisplayValue = null, WorkflowExpression<bool> sysparmExcludeReferenceLink = null, WorkflowExpression<string> sysparmFields = null)
        {
            WorkflowExpression.Validate(tableType, nameof(tableType), required: true);
            WorkflowExpression.Validate(sysid, nameof(sysid), required: true);
            WorkflowExpression.Validate(sysparmDisplayValue, nameof(sysparmDisplayValue), required: false);
            WorkflowExpression.Validate(sysparmExcludeReferenceLink, nameof(sysparmExcludeReferenceLink), required: false);
            WorkflowExpression.Validate(sysparmFields, nameof(sysparmFields), required: false);
            return new DeferredBodyAction<SingleRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(tableType, 1), ExpressionConverter.ConvertWithUrlEncoding(sysid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
                if (sysparmDisplayValue != null)
                    callPayload.Queries["sysparm_display_value"] = ExpressionConverter.Convert(sysparmDisplayValue);
                callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
                if (sysparmExcludeReferenceLink != null)
                    callPayload.Queries["sysparm_exclude_reference_link"] = ExpressionConverter.Convert(sysparmExcludeReferenceLink);
                if (sysparmFields != null)
                    callPayload.Queries["sysparm_fields"] = ExpressionConverter.Convert(sysparmFields);
                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRecord))]
        public IBodyWorkflowAction<SingleRecordResponse> UpdateRecord([WorkflowExpression] Func<string> tableType, [WorkflowExpression] Func<string> sysid, [WorkflowExpression] Func<object> body = null, [WorkflowExpression] Func<bool> sysparmDisplayValue = null, [WorkflowExpression] Func<bool> sysparmExcludeReferenceLink = null, [WorkflowExpression] Func<string> sysparmFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleRecordResponse> __BuildUpdateRecord(WorkflowExpression<string> tableType, WorkflowExpression<string> sysid, WorkflowExpression<object> body = null, WorkflowExpression<bool> sysparmDisplayValue = null, WorkflowExpression<bool> sysparmExcludeReferenceLink = null, WorkflowExpression<string> sysparmFields = null)
        {
            WorkflowExpression.Validate(tableType, nameof(tableType), required: true);
            WorkflowExpression.Validate(sysid, nameof(sysid), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(sysparmDisplayValue, nameof(sysparmDisplayValue), required: false);
            WorkflowExpression.Validate(sysparmExcludeReferenceLink, nameof(sysparmExcludeReferenceLink), required: false);
            WorkflowExpression.Validate(sysparmFields, nameof(sysparmFields), required: false);
            return new DeferredBodyAction<SingleRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(tableType, 1), ExpressionConverter.ConvertWithUrlEncoding(sysid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
                if (sysparmDisplayValue != null)
                    callPayload.Queries["sysparm_display_value"] = ExpressionConverter.Convert(sysparmDisplayValue);
                callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
                if (sysparmExcludeReferenceLink != null)
                    callPayload.Queries["sysparm_exclude_reference_link"] = ExpressionConverter.Convert(sysparmExcludeReferenceLink);
                if (sysparmFields != null)
                    callPayload.Queries["sysparm_fields"] = ExpressionConverter.Convert(sysparmFields);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRecord))]
        public IWorkflowAction DeleteRecord([WorkflowExpression] Func<string> tableType, [WorkflowExpression] Func<string> sysid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteRecord(WorkflowExpression<string> tableType, WorkflowExpression<string> sysid)
        {
            WorkflowExpression.Validate(tableType, nameof(tableType), required: true);
            WorkflowExpression.Validate(sysid, nameof(sysid), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(tableType, 1), ExpressionConverter.ConvertWithUrlEncoding(sysid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetTypesResponse> GetRecordTypes()
        {
            var apiCallPath = "/api/now/doc/table/schema";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildGetCatalogs))]
        public IBodyWorkflowAction<GetCatalogsResponse> GetCatalogs([WorkflowExpression] Func<int> sysparmLimit = null, [WorkflowExpression] Func<string> sysparmText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCatalogsResponse> __BuildGetCatalogs(WorkflowExpression<int> sysparmLimit = null, WorkflowExpression<string> sysparmText = null)
        {
            WorkflowExpression.Validate(sysparmLimit, nameof(sysparmLimit), required: false);
            WorkflowExpression.Validate(sysparmText, nameof(sysparmText), required: false);
            return new DeferredBodyAction<GetCatalogsResponse>(() =>
            {
                var apiCallPath = "/api/sn_sc/servicecatalog/catalogs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sysparmLimit != null)
                    callPayload.Queries["sysparm_limit"] = ExpressionConverter.Convert(sysparmLimit);
                if (sysparmText != null)
                    callPayload.Queries["sysparm_text"] = ExpressionConverter.Convert(sysparmText);
                return new ApiConnectionAction<GetCatalogsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildGetCatalogCategories))]
        public IBodyWorkflowAction<GetCatalogCategoriesResponse> GetCatalogCategories([WorkflowExpression] Func<string> catalogId, [WorkflowExpression] Func<int> sysparmLimit = null, [WorkflowExpression] Func<int> sysparmOffset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCatalogCategoriesResponse> __BuildGetCatalogCategories(WorkflowExpression<string> catalogId, WorkflowExpression<int> sysparmLimit = null, WorkflowExpression<int> sysparmOffset = null)
        {
            WorkflowExpression.Validate(catalogId, nameof(catalogId), required: true);
            WorkflowExpression.Validate(sysparmLimit, nameof(sysparmLimit), required: false);
            WorkflowExpression.Validate(sysparmOffset, nameof(sysparmOffset), required: false);
            return new DeferredBodyAction<GetCatalogCategoriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/sn_sc/servicecatalog/catalogs/{0}/categories", ExpressionConverter.ConvertWithUrlEncoding(catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sysparmLimit != null)
                    callPayload.Queries["sysparm_limit"] = ExpressionConverter.Convert(sysparmLimit);
                if (sysparmOffset != null)
                    callPayload.Queries["sysparm_offset"] = ExpressionConverter.Convert(sysparmOffset);
                return new ApiConnectionAction<GetCatalogCategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildGetCatalogItems))]
        public IBodyWorkflowAction<GetCatalogItemsResponse> GetCatalogItems([WorkflowExpression] Func<int> sysparmLimit, [WorkflowExpression] Func<string> sysparmCategory = null, [WorkflowExpression] Func<string> sysparmText = null, [WorkflowExpression] Func<string> sysparmCatalog = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCatalogItemsResponse> __BuildGetCatalogItems(WorkflowExpression<int> sysparmLimit, WorkflowExpression<string> sysparmCategory = null, WorkflowExpression<string> sysparmText = null, WorkflowExpression<string> sysparmCatalog = null)
        {
            WorkflowExpression.Validate(sysparmLimit, nameof(sysparmLimit), required: true);
            WorkflowExpression.Validate(sysparmCategory, nameof(sysparmCategory), required: false);
            WorkflowExpression.Validate(sysparmText, nameof(sysparmText), required: false);
            WorkflowExpression.Validate(sysparmCatalog, nameof(sysparmCatalog), required: false);
            return new DeferredBodyAction<GetCatalogItemsResponse>(() =>
            {
                var apiCallPath = "/api/sn_sc/servicecatalog/items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sysparmCategory != null)
                    callPayload.Queries["sysparm_category"] = ExpressionConverter.Convert(sysparmCategory);
                callPayload.Queries["sysparm_limit"] = ExpressionConverter.Convert(sysparmLimit);
                if (sysparmText != null)
                    callPayload.Queries["sysparm_text"] = ExpressionConverter.Convert(sysparmText);
                if (sysparmCatalog != null)
                    callPayload.Queries["sysparm_catalog"] = ExpressionConverter.Convert(sysparmCatalog);
                return new ApiConnectionAction<GetCatalogItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildGetCatalogItem))]
        public IBodyWorkflowAction<GetCatalogItemResponse> GetCatalogItem([WorkflowExpression] Func<string> sysId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCatalogItemResponse> __BuildGetCatalogItem(WorkflowExpression<string> sysId)
        {
            WorkflowExpression.Validate(sysId, nameof(sysId), required: true);
            return new DeferredBodyAction<GetCatalogItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/sn_sc/servicecatalog/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(sysId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCatalogItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildOrderItem))]
        public IBodyWorkflowAction<OrderItemResponse> OrderItem([WorkflowExpression] Func<string> sysId, [WorkflowExpression] Func<int> bodysysparmQuantity, [WorkflowExpression] Func<string> bodysysparmRequestedFor = null, [WorkflowExpression] Func<object> bodyvariables = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OrderItemResponse> __BuildOrderItem(WorkflowExpression<string> sysId, WorkflowExpression<int> bodysysparmQuantity, WorkflowExpression<string> bodysysparmRequestedFor = null, WorkflowExpression<object> bodyvariables = null)
        {
            WorkflowExpression.Validate(sysId, nameof(sysId), required: true);
            WorkflowExpression.Validate(bodysysparmQuantity, nameof(bodysysparmQuantity), required: true);
            WorkflowExpression.Validate(bodysysparmRequestedFor, nameof(bodysysparmRequestedFor), required: false);
            WorkflowExpression.Validate(bodyvariables, nameof(bodyvariables), required: false);
            return new DeferredBodyAction<OrderItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/sn_sc/servicecatalog/items/{0}/order_now", ExpressionConverter.ConvertWithUrlEncoding(sysId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sysparm_quantity"] = ExpressionConverter.ConvertO(bodysysparmQuantity);
                if (bodysysparmRequestedFor != null)
                {
                    body["sysparm_requested_for"] = ExpressionConverter.ConvertO(bodysysparmRequestedFor);
                    bodypropCount++;
                }

                if (bodyvariables != null)
                {
                    body["variables"] = ExpressionConverter.ConvertO(bodyvariables);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OrderItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        [WorkflowExpressionFactory(nameof(__BuildGetKnowledgeArticles))]
        public IBodyWorkflowAction<GetArticlesResponse> GetKnowledgeArticles([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> kb = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetArticlesResponse> __BuildGetKnowledgeArticles(WorkflowExpression<string> query, WorkflowExpression<string> fields = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> filter = null, WorkflowExpression<string> kb = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(kb, nameof(kb), required: false);
            return new DeferredBodyAction<GetArticlesResponse>(() =>
            {
                var apiCallPath = "/api/sn_km_api/knowledge/articles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (kb != null)
                    callPayload.Queries["kb"] = ExpressionConverter.Convert(kb);
                return new ApiConnectionAction<GetArticlesResponse>(callPayload);
            });
        }
    }

    public class ServiceNowTriggers([ConnectionName] string connectionId)
    {
    }

    public class UploadAttachmentResponse
    {
        [JsonProperty("result")]
        public UploadAttachmentResponseResultType Result { get; set; }
    }

    public class UploadAttachmentResponseResultType
    {
        [JsonProperty("average_image_color")]
        public string AverageImageColor { get; set; }

        [JsonProperty("compressed")]
        public UploadAttachmentResponseResultTypeCompressedType Compressed { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("created_by_name")]
        public string CreatedByName { get; set; }

        [JsonProperty("download_link")]
        public string DownloadLink { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("image_height")]
        public string ImageHeight { get; set; }

        [JsonProperty("image_width")]
        public string ImageWidth { get; set; }

        [JsonProperty("size_bytes")]
        public string SizeBytes { get; set; }

        [JsonProperty("size_compressed")]
        public string SizeCompressed { get; set; }

        [JsonProperty("sys_created_by")]
        public string SysCreatedBy { get; set; }

        [JsonProperty("sys_created_on")]
        public string SysCreatedOn { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("sys_mod_count")]
        public string SysModCount { get; set; }

        [JsonProperty("sys_tags")]
        public string SysTags { get; set; }

        [JsonProperty("sys_updated_by")]
        public string SysUpdatedBy { get; set; }

        [JsonProperty("sys_updated_on")]
        public string SysUpdatedOn { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("table_sys_id")]
        public string TableSysId { get; set; }

        [JsonProperty("updated_by_name")]
        public string UpdatedByName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UploadAttachmentResponseResultTypeCompressedType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class GetRecordsResponse
    {
        [JsonProperty("result")]
        public JToken[] Result { get; set; }
    }

    public class SingleRecordResponse
    {
        [JsonProperty("result")]
        public JToken Result { get; set; }
    }

    public class GetTypesResponse
    {
        [JsonProperty("result")]
        public GetTypesResponseResultTypeItem[] Result { get; set; }
    }

    public class GetTypesResponseResultTypeItem
    {
        [JsonProperty("label")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetCatalogsResponse
    {
        [JsonProperty("result")]
        public GetCatalogsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetCatalogsResponseResultTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("has_categories")]
        public bool HasCategories { get; set; }

        [JsonProperty("has_items")]
        public bool HasItems { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("desktop_image")]
        public string DesktopImage { get; set; }
    }

    public class GetCatalogCategoriesResponse
    {
        [JsonProperty("result")]
        public GetCatalogCategoriesResponseResultTypeItem[] Result { get; set; }
    }

    public class GetCatalogCategoriesResponseResultTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("full_description")]
        public string FullDescription { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("header_icon")]
        public string HeaderIcon { get; set; }

        [JsonProperty("homepage_image")]
        public string HomepageImage { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("subcategories")]
        public GetCatalogCategoriesResponseResultTypeItemSubcategoriesTypeItem[] Subcategories { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }
    }

    public class GetCatalogCategoriesResponseResultTypeItemSubcategoriesTypeItem
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemsResponse
    {
        [JsonProperty("result")]
        public GetCatalogItemsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetCatalogItemsResponseResultTypeItem
    {
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("kb_article")]
        public string KbArticle { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("mandatory_attachment")]
        public bool MandatoryAttachment { get; set; }

        [JsonProperty("request_method")]
        public string RequestMethod { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visible_standalone")]
        public bool VisibleStandalone { get; set; }

        [JsonProperty("local_currency")]
        public string LocalCurrency { get; set; }

        [JsonProperty("sys_class_name")]
        public string SysClassName { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("recurring_frequency")]
        public string RecurringFrequency { get; set; }

        [JsonProperty("price_currency")]
        public string PriceCurrency { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("make_item_non_conversational")]
        public bool MakeItemNonConversational { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("show_price")]
        public bool ShowPrice { get; set; }

        [JsonProperty("recurring_price")]
        public string RecurringPrice { get; set; }

        [JsonProperty("show_quantity")]
        public bool ShowQuantity { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("recurring_price_currency")]
        public string RecurringPriceCurrency { get; set; }

        [JsonProperty("localized_price")]
        public string LocalizedPrice { get; set; }

        [JsonProperty("catalogs")]
        public GetCatalogItemsResponseResultTypeItemCatalogsTypeItem[] Catalogs { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("localized_recurring_price")]
        public string LocalizedRecurringPrice { get; set; }

        [JsonProperty("show_wishlist")]
        public bool ShowWishlist { get; set; }

        [JsonProperty("category")]
        public GetCatalogItemsResponseResultTypeItemCategoryType Category { get; set; }

        [JsonProperty("turn_off_nowassist_conversation")]
        public bool TurnOffNowassistConversation { get; set; }

        [JsonProperty("show_delivery_time")]
        public bool ShowDeliveryTime { get; set; }
    }

    public class GetCatalogItemsResponseResultTypeItemCatalogsTypeItem
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemsResponseResultTypeItemCategoryType
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemResponse
    {
        [JsonProperty("result")]
        public GetCatalogItemResponseResultType Result { get; set; }
    }

    public class GetCatalogItemResponseResultType
    {
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("kb_article")]
        public string KbArticle { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("mandatory_attachment")]
        public bool MandatoryAttachment { get; set; }

        [JsonProperty("request_method")]
        public string RequestMethod { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visible_standalone")]
        public bool VisibleStandalone { get; set; }

        [JsonProperty("sys_class_name")]
        public string SysClassName { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("make_item_non_conversational")]
        public bool MakeItemNonConversational { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("show_price")]
        public bool ShowPrice { get; set; }

        [JsonProperty("show_quantity")]
        public bool ShowQuantity { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("catalogs")]
        public GetCatalogItemResponseResultTypeCatalogsTypeItem[] Catalogs { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("show_wishlist")]
        public bool ShowWishlist { get; set; }

        [JsonProperty("category")]
        public GetCatalogItemResponseResultTypeCategoryType Category { get; set; }

        [JsonProperty("turn_off_nowassist_conversation")]
        public bool TurnOffNowassistConversation { get; set; }

        [JsonProperty("show_delivery_time")]
        public bool ShowDeliveryTime { get; set; }

        [JsonProperty("categories")]
        public GetCatalogItemResponseResultTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("variables")]
        public JToken[] Variables { get; set; }

        [JsonProperty("ui_policy")]
        public JToken[] UiPolicy { get; set; }

        [JsonProperty("client_script")]
        public GetCatalogItemResponseResultTypeClientScriptType ClientScript { get; set; }

        [JsonProperty("data_lookup")]
        public JToken[] DataLookup { get; set; }

        [JsonProperty("variablesSchema")]
        public JToken VariablesSchema { get; set; }
    }

    public class GetCatalogItemResponseResultTypeCatalogsTypeItem
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemResponseResultTypeCategoryType
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemResponseResultTypeCategoriesTypeItem
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("category")]
        public GetCatalogItemResponseResultTypeCategoriesTypeItemCategoryType Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemResponseResultTypeCategoriesTypeItemCategoryType
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemResponseResultTypeClientScriptType
    {
        [JsonProperty("onChange")]
        public JToken[] OnChange { get; set; }

        [JsonProperty("onSubmit")]
        public JToken[] OnSubmit { get; set; }

        [JsonProperty("onLoad")]
        public JToken[] OnLoad { get; set; }
    }

    public class OrderItemResponse
    {
        [JsonProperty("result")]
        public OrderItemResponseResultType Result { get; set; }
    }

    public class OrderItemResponseResultType
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("request_number")]
        public string RequestNumber { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("table")]
        public string Table { get; set; }
    }

    public class GetArticlesResponse
    {
        [JsonProperty("meta")]
        public GetArticlesResponseMetaType Meta { get; set; }

        [JsonProperty("articles")]
        public GetArticlesResponseArticlesTypeItem[] Articles { get; set; }
    }

    public class GetArticlesResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("fields")]
        public string Fields { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("ts_query_id")]
        public string Kb { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("status")]
        public GetArticlesResponseMetaTypeStatusType Status { get; set; }
    }

    public class GetArticlesResponseMetaTypeStatusType
    {
        [JsonProperty("code")]
        public string Status { get; set; }
    }

    public class GetArticlesResponseArticlesTypeItem
    {
        [JsonProperty("fields")]
        public GetArticlesResponseArticlesTypeItemFieldsType Fields { get; set; }
        public string Link { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("rank")]
        public double Rank { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetArticlesResponseArticlesTypeItemFieldsType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.ServiceNow;

    public partial class WorkflowManagedActions
    {
        public ServiceNowActions ServiceNow(string connectionId) => new ServiceNowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ServiceNowTriggers ServiceNow(string connectionId) => new ServiceNowTriggers(connectionId);
    }
}