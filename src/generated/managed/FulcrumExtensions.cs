//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fulcrum
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FulcrumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<AttachmentsResponse, ApiConnectionActionConfiguration> GetAllAttachments(Expression<Func<string>> recordId = null, Expression<Func<string>> formId = null, Expression<Func<string>> ownerType = null, Expression<Func<sortInput>> sort = null, Expression<Func<sortDirectionInput>> sortDirection = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: false);
            var __workflow_ownerType = WorkflowExpression.Compile(ownerType, nameof(ownerType), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_sortDirection = WorkflowExpression.Compile(sortDirection, nameof(sortDirection), required: false);
            return new DeferredBodyAction<AttachmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/attachments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                callPayload.Queries["owner_type"] = Convert.ToString("form");
                if (__workflow_ownerType != null)
                    callPayload.Queries["owner_type"] = ExpressionConverter.Convert(__workflow_ownerType);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                callPayload.Queries["sort_direction"] = Convert.ToString("asc");
                if (__workflow_sortDirection != null)
                    callPayload.Queries["sort_direction"] = ExpressionConverter.Convert(__workflow_sortDirection);
                return new ApiConnectionAction<AttachmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<Attachment, ApiConnectionActionConfiguration> GetSingleAttachment(Expression<Func<string>> attachmentId)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<Attachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Attachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<AudiosResponse, ApiConnectionActionConfiguration> AudioGetAll(Expression<Func<string>> recordId = null, Expression<Func<string>> formId = null, Expression<Func<bool>> newestFirst = null, Expression<Func<bool>> processed = null, Expression<Func<bool>> stored = null, Expression<Func<bool>> uploaded = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: false);
            var __workflow_newestFirst = WorkflowExpression.Compile(newestFirst, nameof(newestFirst), required: false);
            var __workflow_processed = WorkflowExpression.Compile(processed, nameof(processed), required: false);
            var __workflow_stored = WorkflowExpression.Compile(stored, nameof(stored), required: false);
            var __workflow_uploaded = WorkflowExpression.Compile(uploaded, nameof(uploaded), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<AudiosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/audio.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                if (__workflow_newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(__workflow_newestFirst);
                if (__workflow_processed != null)
                    callPayload.Queries["processed"] = ExpressionConverter.Convert(__workflow_processed);
                if (__workflow_stored != null)
                    callPayload.Queries["stored"] = ExpressionConverter.Convert(__workflow_stored);
                if (__workflow_uploaded != null)
                    callPayload.Queries["uploaded"] = ExpressionConverter.Convert(__workflow_uploaded);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<AudiosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AudioGetOriginalFile(Expression<Func<string>> audioId)
        {
            var __workflow_audioId = WorkflowExpression.Compile(audioId, nameof(audioId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/audio/{0}.mp4", __workflow_audioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<PhotosResponse, ApiConnectionActionConfiguration> PhotosGetAllMetadata(Expression<Func<string>> recordId = null, Expression<Func<string>> formId = null, Expression<Func<bool>> newestFirst = null, Expression<Func<bool>> processed = null, Expression<Func<bool>> stored = null, Expression<Func<bool>> uploaded = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: false);
            var __workflow_newestFirst = WorkflowExpression.Compile(newestFirst, nameof(newestFirst), required: false);
            var __workflow_processed = WorkflowExpression.Compile(processed, nameof(processed), required: false);
            var __workflow_stored = WorkflowExpression.Compile(stored, nameof(stored), required: false);
            var __workflow_uploaded = WorkflowExpression.Compile(uploaded, nameof(uploaded), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<PhotosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/photos.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                if (__workflow_newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(__workflow_newestFirst);
                if (__workflow_processed != null)
                    callPayload.Queries["processed"] = ExpressionConverter.Convert(__workflow_processed);
                if (__workflow_stored != null)
                    callPayload.Queries["stored"] = ExpressionConverter.Convert(__workflow_stored);
                if (__workflow_uploaded != null)
                    callPayload.Queries["uploaded"] = ExpressionConverter.Convert(__workflow_uploaded);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<PhotosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PhotosGetSingleFile(Expression<Func<string>> photoId)
        {
            var __workflow_photoId = WorkflowExpression.Compile(photoId, nameof(photoId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/photos/{0}.jpg", __workflow_photoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<SinglePhotoResponse, ApiConnectionActionConfiguration> PhotosGetSingleMetadata(Expression<Func<string>> photoId)
        {
            var __workflow_photoId = WorkflowExpression.Compile(photoId, nameof(photoId), required: true);
            return new DeferredBodyAction<SinglePhotoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/photos/{0}.json", __workflow_photoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SinglePhotoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Query(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<QueryPostInput>> body = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<RecordsResponse, ApiConnectionActionConfiguration> RecordsGetAll(Expression<Func<bool>> newestFirst = null, Expression<Func<string>> boundingBox = null, Expression<Func<string>> changesetId = null, Expression<Func<string>> formId = null, Expression<Func<string>> projectId = null, Expression<Func<string>> clientCreatedBefore = null, Expression<Func<string>> clientCreatedSince = null, Expression<Func<string>> clientUpdatedBefore = null, Expression<Func<string>> clientUpdatedSince = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> createdSince = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> updatedSince = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_newestFirst = WorkflowExpression.Compile(newestFirst, nameof(newestFirst), required: false);
            var __workflow_boundingBox = WorkflowExpression.Compile(boundingBox, nameof(boundingBox), required: false);
            var __workflow_changesetId = WorkflowExpression.Compile(changesetId, nameof(changesetId), required: false);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_clientCreatedBefore = WorkflowExpression.Compile(clientCreatedBefore, nameof(clientCreatedBefore), required: false);
            var __workflow_clientCreatedSince = WorkflowExpression.Compile(clientCreatedSince, nameof(clientCreatedSince), required: false);
            var __workflow_clientUpdatedBefore = WorkflowExpression.Compile(clientUpdatedBefore, nameof(clientUpdatedBefore), required: false);
            var __workflow_clientUpdatedSince = WorkflowExpression.Compile(clientUpdatedSince, nameof(clientUpdatedSince), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_createdSince = WorkflowExpression.Compile(createdSince, nameof(createdSince), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_updatedSince = WorkflowExpression.Compile(updatedSince, nameof(updatedSince), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<RecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/records.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(__workflow_newestFirst);
                if (__workflow_boundingBox != null)
                    callPayload.Queries["bounding_box"] = ExpressionConverter.Convert(__workflow_boundingBox);
                if (__workflow_changesetId != null)
                    callPayload.Queries["changeset_id"] = ExpressionConverter.Convert(__workflow_changesetId);
                if (__workflow_formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                if (__workflow_projectId != null)
                    callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_clientCreatedBefore != null)
                    callPayload.Queries["client_created_before"] = ExpressionConverter.Convert(__workflow_clientCreatedBefore);
                if (__workflow_clientCreatedSince != null)
                    callPayload.Queries["client_created_since"] = ExpressionConverter.Convert(__workflow_clientCreatedSince);
                if (__workflow_clientUpdatedBefore != null)
                    callPayload.Queries["client_updated_before"] = ExpressionConverter.Convert(__workflow_clientUpdatedBefore);
                if (__workflow_clientUpdatedSince != null)
                    callPayload.Queries["client_updated_since"] = ExpressionConverter.Convert(__workflow_clientUpdatedSince);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["created_before"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_createdSince != null)
                    callPayload.Queries["created_since"] = ExpressionConverter.Convert(__workflow_createdSince);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updated_before"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_updatedSince != null)
                    callPayload.Queries["updated_since"] = ExpressionConverter.Convert(__workflow_updatedSince);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<RecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<SingleRecordResponse, ApiConnectionActionConfiguration> RecordsCreate(Expression<Func<string>> contentType = null, Expression<Func<bool>> xSkipWorkflows = null, Expression<Func<bool>> xSkipWebhooks = null, Expression<Func<RecordsCreateInput>> body = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_xSkipWorkflows = WorkflowExpression.Compile(xSkipWorkflows, nameof(xSkipWorkflows), required: false);
            var __workflow_xSkipWebhooks = WorkflowExpression.Compile(xSkipWebhooks, nameof(xSkipWebhooks), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SingleRecordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/records.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-SkipWorkflows"] = Convert.ToString(false);
                if (__workflow_xSkipWorkflows != null)
                    callPayload.Headers["X-SkipWorkflows"] = ExpressionConverter.Convert(__workflow_xSkipWorkflows);
                callPayload.Headers["X-SkipWebhooks"] = Convert.ToString(false);
                if (__workflow_xSkipWebhooks != null)
                    callPayload.Headers["X-SkipWebhooks"] = ExpressionConverter.Convert(__workflow_xSkipWebhooks);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<SingleRecordResponse, ApiConnectionActionConfiguration> RecordsDelete(Expression<Func<string>> recordId, Expression<Func<bool>> xSkipWorkflows = null, Expression<Func<bool>> xSkipWebhooks = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_xSkipWorkflows = WorkflowExpression.Compile(xSkipWorkflows, nameof(xSkipWorkflows), required: false);
            var __workflow_xSkipWebhooks = WorkflowExpression.Compile(xSkipWebhooks, nameof(xSkipWebhooks), required: false);
            return new DeferredBodyAction<SingleRecordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/records/{0}.json", __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-SkipWorkflows"] = Convert.ToString(false);
                if (__workflow_xSkipWorkflows != null)
                    callPayload.Headers["X-SkipWorkflows"] = ExpressionConverter.Convert(__workflow_xSkipWorkflows);
                callPayload.Headers["X-SkipWebhooks"] = Convert.ToString(false);
                if (__workflow_xSkipWebhooks != null)
                    callPayload.Headers["X-SkipWebhooks"] = ExpressionConverter.Convert(__workflow_xSkipWebhooks);
                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<SingleRecordResponse, ApiConnectionActionConfiguration> RecordsGetSingle(Expression<Func<string>> recordId)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<SingleRecordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/records/{0}.json", __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<SingleRecordResponse, ApiConnectionActionConfiguration> RecordsPartialUpdate(Expression<Func<string>> recordId, Expression<Func<string>> contentType = null, Expression<Func<bool>> xSkipWorkflows = null, Expression<Func<bool>> xSkipWebhooks = null, Expression<Func<RecordsPartialUpdateInput>> body = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_xSkipWorkflows = WorkflowExpression.Compile(xSkipWorkflows, nameof(xSkipWorkflows), required: false);
            var __workflow_xSkipWebhooks = WorkflowExpression.Compile(xSkipWebhooks, nameof(xSkipWebhooks), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SingleRecordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/records/{0}.json", __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-SkipWorkflows"] = Convert.ToString(false);
                if (__workflow_xSkipWorkflows != null)
                    callPayload.Headers["X-SkipWorkflows"] = ExpressionConverter.Convert(__workflow_xSkipWorkflows);
                callPayload.Headers["X-SkipWebhooks"] = Convert.ToString(false);
                if (__workflow_xSkipWebhooks != null)
                    callPayload.Headers["X-SkipWebhooks"] = ExpressionConverter.Convert(__workflow_xSkipWebhooks);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RecordsUpdate(Expression<Func<string>> recordId, Expression<Func<string>> contentType = null, Expression<Func<bool>> xSkipWorkflows = null, Expression<Func<bool>> xSkipWebhooks = null, Expression<Func<RecordsUpdateInput>> body = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_xSkipWorkflows = WorkflowExpression.Compile(xSkipWorkflows, nameof(xSkipWorkflows), required: false);
            var __workflow_xSkipWebhooks = WorkflowExpression.Compile(xSkipWebhooks, nameof(xSkipWebhooks), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/records/{0}.json", __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-SkipWorkflows"] = Convert.ToString(false);
                if (__workflow_xSkipWorkflows != null)
                    callPayload.Headers["X-SkipWorkflows"] = ExpressionConverter.Convert(__workflow_xSkipWorkflows);
                callPayload.Headers["X-SkipWebhooks"] = Convert.ToString(false);
                if (__workflow_xSkipWebhooks != null)
                    callPayload.Headers["X-SkipWebhooks"] = ExpressionConverter.Convert(__workflow_xSkipWebhooks);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<RecordHistoryResponse, ApiConnectionActionConfiguration> RecordsGetHistory(Expression<Func<string>> recordId)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<RecordHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/records/{0}/history.json", __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RecordHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<ReportResponse, ApiConnectionActionConfiguration> ReportsCreate(Expression<Func<ReportsCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/reports.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ReportsFile(Expression<Func<string>> reportId)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/reports/{0}.pdf", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<SignaturesResponse, ApiConnectionActionConfiguration> SignaturesGetAll(Expression<Func<string>> recordId = null, Expression<Func<string>> formId = null, Expression<Func<bool>> newestFirst = null, Expression<Func<bool>> processed = null, Expression<Func<bool>> stored = null, Expression<Func<bool>> uploaded = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: false);
            var __workflow_newestFirst = WorkflowExpression.Compile(newestFirst, nameof(newestFirst), required: false);
            var __workflow_processed = WorkflowExpression.Compile(processed, nameof(processed), required: false);
            var __workflow_stored = WorkflowExpression.Compile(stored, nameof(stored), required: false);
            var __workflow_uploaded = WorkflowExpression.Compile(uploaded, nameof(uploaded), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SignaturesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/signatures.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                if (__workflow_newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(__workflow_newestFirst);
                if (__workflow_processed != null)
                    callPayload.Queries["processed"] = ExpressionConverter.Convert(__workflow_processed);
                if (__workflow_stored != null)
                    callPayload.Queries["stored"] = ExpressionConverter.Convert(__workflow_stored);
                if (__workflow_uploaded != null)
                    callPayload.Queries["uploaded"] = ExpressionConverter.Convert(__workflow_uploaded);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SignaturesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<SingleSignatureResponse, ApiConnectionActionConfiguration> SignaturesGetSingleMetadata(Expression<Func<string>> signatureId)
        {
            var __workflow_signatureId = WorkflowExpression.Compile(signatureId, nameof(signatureId), required: true);
            return new DeferredBodyAction<SingleSignatureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/signatures/{0}.json", __workflow_signatureId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleSignatureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SignaturesGetSingleFile(Expression<Func<string>> signatureId)
        {
            var __workflow_signatureId = WorkflowExpression.Compile(signatureId, nameof(signatureId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/signatures/{0}.png", __workflow_signatureId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<SketchesResponse, ApiConnectionActionConfiguration> SketchesGetAllMetadata(Expression<Func<string>> recordId = null, Expression<Func<string>> formId = null, Expression<Func<bool>> newestFirst = null, Expression<Func<bool>> processed = null, Expression<Func<bool>> stored = null, Expression<Func<bool>> uploaded = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: false);
            var __workflow_newestFirst = WorkflowExpression.Compile(newestFirst, nameof(newestFirst), required: false);
            var __workflow_processed = WorkflowExpression.Compile(processed, nameof(processed), required: false);
            var __workflow_stored = WorkflowExpression.Compile(stored, nameof(stored), required: false);
            var __workflow_uploaded = WorkflowExpression.Compile(uploaded, nameof(uploaded), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SketchesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/sketches.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                if (__workflow_newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(__workflow_newestFirst);
                if (__workflow_processed != null)
                    callPayload.Queries["processed"] = ExpressionConverter.Convert(__workflow_processed);
                if (__workflow_stored != null)
                    callPayload.Queries["stored"] = ExpressionConverter.Convert(__workflow_stored);
                if (__workflow_uploaded != null)
                    callPayload.Queries["uploaded"] = ExpressionConverter.Convert(__workflow_uploaded);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SketchesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SketchesGetSingleFile(Expression<Func<string>> sketchId)
        {
            var __workflow_sketchId = WorkflowExpression.Compile(sketchId, nameof(sketchId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/sketches/{0}.jpg", __workflow_sketchId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<SingleSketchResponse, ApiConnectionActionConfiguration> SketchesGetSingleMetadata(Expression<Func<string>> sketchId)
        {
            var __workflow_sketchId = WorkflowExpression.Compile(sketchId, nameof(sketchId), required: true);
            return new DeferredBodyAction<SingleSketchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/sketches/{0}.json", __workflow_sketchId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleSketchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<VideosResponse, ApiConnectionActionConfiguration> VideosGetAll(Expression<Func<string>> recordId = null, Expression<Func<string>> formId = null, Expression<Func<bool>> newestFirst = null, Expression<Func<bool>> processed = null, Expression<Func<bool>> stored = null, Expression<Func<bool>> uploaded = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: false);
            var __workflow_newestFirst = WorkflowExpression.Compile(newestFirst, nameof(newestFirst), required: false);
            var __workflow_processed = WorkflowExpression.Compile(processed, nameof(processed), required: false);
            var __workflow_stored = WorkflowExpression.Compile(stored, nameof(stored), required: false);
            var __workflow_uploaded = WorkflowExpression.Compile(uploaded, nameof(uploaded), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<VideosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/videos.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                if (__workflow_newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(__workflow_newestFirst);
                if (__workflow_processed != null)
                    callPayload.Queries["processed"] = ExpressionConverter.Convert(__workflow_processed);
                if (__workflow_stored != null)
                    callPayload.Queries["stored"] = ExpressionConverter.Convert(__workflow_stored);
                if (__workflow_uploaded != null)
                    callPayload.Queries["uploaded"] = ExpressionConverter.Convert(__workflow_uploaded);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<VideosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> VideosGetOriginalFile(Expression<Func<string>> videoId)
        {
            var __workflow_videoId = WorkflowExpression.Compile(videoId, nameof(videoId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/videos/{0}.mp4", __workflow_videoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class FulcrumTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnFulcrumEventResponse, ApiConnectionTriggerConfiguration> OnFulcrumEvent(Expression<Func<OnFulcrumEventInput>> body, Expression<Func<string>> contentType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyTrigger<OnFulcrumEventResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/webhooks.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<OnFulcrumEventResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AttachmentsResponse
    {
        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class Attachment
    {
        [JsonProperty("attached_to_id")]
        public string AttachedToId { get; set; }

        [JsonProperty("attached_to_type")]
        public string AttachedToType { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owners")]
        public AttachmentOwnersTypeItem[] Owners { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("uploaded_at")]
        public string UploadedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AttachmentOwnersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortInput
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "file_size")]
        FileSize,
        [EnumMember(Value = "uploaded_at")]
        UploadedAt
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortDirectionInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class AudiosResponse
    {
        [JsonProperty("audio")]
        public Audio[] Audio { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class Audio
    {
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_by_id")]
        public string CreatedById { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("processed")]
        public bool Processed { get; set; }

        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("stored")]
        public bool Stored { get; set; }

        [JsonProperty("track")]
        public string Track { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updated_by_id")]
        public string UpdatedById { get; set; }

        [JsonProperty("uploaded")]
        public bool Uploaded { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PhotosResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("photos")]
        public Photo[] Photos { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class Photo
    {
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_by_id")]
        public string CreatedById { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("exif")]
        public JToken Exif { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("processed")]
        public bool Processed { get; set; }

        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        [JsonProperty("stored")]
        public bool Stored { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updated_by_id")]
        public string UpdatedById { get; set; }

        [JsonProperty("uploaded")]
        public bool Uploaded { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SinglePhotoResponse
    {
        [JsonProperty("photo")]
        public Photo Photo { get; set; }
    }

    public class QueryPostInput
    {
        [JsonProperty("format")]
        public QueryPostInputFormatType? Format { get; set; }

        [JsonProperty("q", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Q { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryPostInputFormatType
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "geojson")]
        Geojson
    }

    public class RecordsResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("records")]
        public Record[] Records { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class Record
    {
        [JsonProperty("altitude")]
        public double Altitude { get; set; }

        [JsonProperty("assigned_to")]
        public string AssignedTo { get; set; }

        [JsonProperty("assigned_to_id")]
        public string AssignedToId { get; set; }

        [JsonProperty("client_created_at")]
        public string ClientCreatedAt { get; set; }

        [JsonProperty("client_updated_at")]
        public string ClientUpdatedAt { get; set; }

        [JsonProperty("course")]
        public double Course { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_by_id")]
        public string CreatedById { get; set; }

        [JsonProperty("created_duration")]
        public double CreatedDuration { get; set; }

        [JsonProperty("created_location")]
        public AuditLocation CreatedLocation { get; set; }

        [JsonProperty("edited_duration")]
        public double EditedDuration { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("form_values")]
        public JToken FormValues { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("horizontal_accuracy")]
        public double HorizontalAccuracy { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("record_series_id")]
        public string RecordSeriesId { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("system_status")]
        public string SystemStatus { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updated_by_id")]
        public string UpdatedById { get; set; }

        [JsonProperty("updated_duration")]
        public double UpdatedDuration { get; set; }

        [JsonProperty("updated_location")]
        public AuditLocation UpdatedLocation { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("vertical_accuracy")]
        public double VerticalAccuracy { get; set; }
    }

    public class AuditLocation
    {
        [JsonProperty("altitude")]
        public double Altitude { get; set; }

        [JsonProperty("horizontal_accuracy")]
        public double HorizontalAccuracy { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class Geometry
    {
        [JsonProperty("coordinates")]
        public JToken Coordinates { get; set; }

        [JsonProperty("type")]
        public GeometryTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GeometryTypeType
    {
        Point,
        LineString,
        Polygon,
        MultiPoint,
        MultiLineString,
        MultiPolygon
    }

    public class SingleRecordResponse
    {
        [JsonProperty("record")]
        public Record Record { get; set; }
    }

    public class RecordsCreateInput
    {
        [JsonProperty("record", DefaultValueHandling = DefaultValueHandling.Include)]
        public RecordsCreateInputRecordType Record { get; set; }
    }

    public class RecordsCreateInputRecordType
    {
        [JsonProperty("assigned_to_id")]
        public string AssignedToId { get; set; }

        [JsonProperty("form_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FormId { get; set; }

        [JsonProperty("form_values")]
        public JToken FormValues { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class RecordsPartialUpdateInput
    {
        [JsonProperty("record", DefaultValueHandling = DefaultValueHandling.Include)]
        public RecordsPartialUpdateInputRecordType Record { get; set; }
    }

    public class RecordsPartialUpdateInputRecordType
    {
        [JsonProperty("assigned_to_id")]
        public string AssignedToId { get; set; }

        [JsonProperty("form_values")]
        public JToken FormValues { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class RecordsUpdateInput
    {
        [JsonProperty("record", DefaultValueHandling = DefaultValueHandling.Include)]
        public RecordsUpdateInputRecordType Record { get; set; }
    }

    public class RecordsUpdateInputRecordType
    {
        [JsonProperty("assigned_to_id")]
        public string AssignedToId { get; set; }

        [JsonProperty("form_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FormId { get; set; }

        [JsonProperty("form_values")]
        public JToken FormValues { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class RecordHistoryResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("next_sequence")]
        public int NextSequence { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("records")]
        public RecordHistoryItem[] Records { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class RecordHistoryItem
    {
        [JsonProperty("altitude")]
        public double Altitude { get; set; }

        [JsonProperty("assigned_to")]
        public string AssignedTo { get; set; }

        [JsonProperty("assigned_to_id")]
        public string AssignedToId { get; set; }

        [JsonProperty("changeset_id")]
        public string ChangesetId { get; set; }

        [JsonProperty("client_created_at")]
        public string ClientCreatedAt { get; set; }

        [JsonProperty("client_updated_at")]
        public string ClientUpdatedAt { get; set; }

        [JsonProperty("course")]
        public double Course { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_by_id")]
        public string CreatedById { get; set; }

        [JsonProperty("created_duration")]
        public int CreatedDuration { get; set; }

        [JsonProperty("created_location")]
        public AuditLocation CreatedLocation { get; set; }

        [JsonProperty("edited_duration")]
        public int EditedDuration { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("form_values")]
        public JToken FormValues { get; set; }

        [JsonProperty("form_version")]
        public int FormVersion { get; set; }

        [JsonProperty("geometry")]
        public RecordHistoryItemGeometryType Geometry { get; set; }

        [JsonProperty("history_change_type")]
        public RecordHistoryItemHistoryChangeTypeType HistoryChangeType { get; set; }

        [JsonProperty("history_changed_by")]
        public string HistoryChangedBy { get; set; }

        [JsonProperty("history_changed_by_id")]
        public string HistoryChangedById { get; set; }

        [JsonProperty("history_created_at")]
        public string HistoryCreatedAt { get; set; }

        [JsonProperty("history_id")]
        public string HistoryId { get; set; }

        [JsonProperty("horizontal_accuracy")]
        public double HorizontalAccuracy { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("record_key")]
        public string RecordKey { get; set; }

        [JsonProperty("record_sequence")]
        public int RecordSequence { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updated_by_id")]
        public string UpdatedById { get; set; }

        [JsonProperty("updated_duration")]
        public int UpdatedDuration { get; set; }

        [JsonProperty("updated_location")]
        public AuditLocation UpdatedLocation { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("vertical_accuracy")]
        public double VerticalAccuracy { get; set; }
    }

    public class RecordHistoryItemGeometryType
    {
        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecordHistoryItemHistoryChangeTypeType
    {
        [EnumMember(Value = "c")]
        C,
        [EnumMember(Value = "u")]
        U,
        [EnumMember(Value = "d")]
        D
    }

    public class ReportResponse
    {
        [JsonProperty("report")]
        public ReportResponseReportType Report { get; set; }
    }

    public class ReportResponseReportType
    {
        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("failed_at")]
        public string FailedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("state")]
        public ReportResponseReportTypeStateType State { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReportResponseReportTypeStateType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed
    }

    public class ReportsCreateInput
    {
        [JsonProperty("report", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReportsCreateInputReportType Report { get; set; }
    }

    public class ReportsCreateInputReportType
    {
        [JsonProperty("record_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecordId { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }

    public class SignaturesResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("signatures")]
        public Signature[] Signatures { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class Signature
    {
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_by_id")]
        public string CreatedById { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("processed")]
        public bool Processed { get; set; }

        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        [JsonProperty("stored")]
        public bool Stored { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updated_by_id")]
        public string UpdatedById { get; set; }

        [JsonProperty("uploaded")]
        public bool Uploaded { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SingleSignatureResponse
    {
        [JsonProperty("signature")]
        public Signature Signature { get; set; }
    }

    public class SketchesResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("sketches")]
        public Sketch[] Sketches { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class Sketch
    {
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_by_id")]
        public string CreatedById { get; set; }

        [JsonProperty("exif")]
        public JToken Exif { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("processed")]
        public bool Processed { get; set; }

        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("stored")]
        public bool Stored { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updated_by_id")]
        public string UpdatedById { get; set; }

        [JsonProperty("uploaded")]
        public bool Uploaded { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SingleSketchResponse
    {
        [JsonProperty("sketch")]
        public Sketch Sketch { get; set; }
    }

    public class VideosResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("videos")]
        public Video[] Videos { get; set; }
    }

    public class Video
    {
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_by_id")]
        public string CreatedById { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("processed")]
        public bool Processed { get; set; }

        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("stored")]
        public bool Stored { get; set; }

        [JsonProperty("thumbnail_huge")]
        public string ThumbnailHuge { get; set; }

        [JsonProperty("thumbnail_huge_square")]
        public string ThumbnailHugeSquare { get; set; }

        [JsonProperty("thumbnail_large")]
        public string ThumbnailLarge { get; set; }

        [JsonProperty("thumbnail_large_square")]
        public string ThumbnailLargeSquare { get; set; }

        [JsonProperty("thumbnail_medium")]
        public string ThumbnailMedium { get; set; }

        [JsonProperty("thumbnail_medium_square")]
        public string ThumbnailMediumSquare { get; set; }

        [JsonProperty("thumbnail_small")]
        public string ThumbnailSmall { get; set; }

        [JsonProperty("thumbnail_small_square")]
        public string ThumbnailSmallSquare { get; set; }

        [JsonProperty("track")]
        public string Track { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updated_by_id")]
        public string UpdatedById { get; set; }

        [JsonProperty("uploaded")]
        public bool Uploaded { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class OnFulcrumEventResponse
    {
        [JsonProperty("webhook")]
        public OnFulcrumEventResponseWebhookType Webhook { get; set; }

        [JsonProperty("_webhook_payload_example")]
        public FulcrumWebhookPayload WebhookPayloadExample { get; set; }
    }

    public class OnFulcrumEventResponseWebhookType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("run_for_bulk_actions")]
        public bool RunForBulkActions { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FulcrumWebhookPayload
    {
        [JsonProperty("id")]
        public string EventId { get; set; }

        [JsonProperty("type")]
        public string EventType { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("data")]
        public JToken EventData { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class OnFulcrumEventInput
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        public OnFulcrumEventInputWebhookType Webhook { get; set; }
    }

    public class OnFulcrumEventInputWebhookType
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WebhookName { get; set; } = "Power Platform Trigger";

        [JsonProperty("run_for_bulk_actions")]
        public bool? RunForBulkActions { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fulcrum;

    public partial class WorkflowManagedActions
    {
        public FulcrumActions Fulcrum(string connectionId) => new FulcrumActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FulcrumTriggers Fulcrum(string connectionId) => new FulcrumTriggers(connectionId);
    }
}