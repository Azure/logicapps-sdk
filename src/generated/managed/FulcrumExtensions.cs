//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fulcrum
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FulcrumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllAttachments))]
        public IBodyWorkflowAction<AttachmentsResponse> GetAllAttachments([WorkflowExpression] Func<string> recordId = null, [WorkflowExpression] Func<string> formId = null, [WorkflowExpression] Func<string> ownerType = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<sortDirectionInput> sortDirection = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AttachmentsResponse> __BuildGetAllAttachments(WorkflowValue<string> recordId = null, WorkflowValue<string> formId = null, WorkflowValue<string> ownerType = null, WorkflowValue<sortInput> sort = null, WorkflowValue<sortDirectionInput> sortDirection = null)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: false);
            WorkflowValue.Validate(formId, nameof(formId), required: false);
            WorkflowValue.Validate(ownerType, nameof(ownerType), required: false);
            WorkflowValue.Validate(sort, nameof(sort), required: false);
            WorkflowValue.Validate(sortDirection, nameof(sortDirection), required: false);
            return new DeferredBodyAction<AttachmentsResponse>(() =>
            {
                var apiCallPath = "/v2/attachments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(recordId);
                if (formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
                callPayload.Queries["owner_type"] = Convert.ToString("form");
                if (ownerType != null)
                    callPayload.Queries["owner_type"] = ExpressionConverter.Convert(ownerType);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                callPayload.Queries["sort_direction"] = Convert.ToString("asc");
                if (sortDirection != null)
                    callPayload.Queries["sort_direction"] = ExpressionConverter.Convert(sortDirection);
                return new ApiConnectionAction<AttachmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildGetSingleAttachment))]
        public IBodyWorkflowAction<Attachment> GetSingleAttachment([WorkflowExpression] Func<string> attachmentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Attachment> __BuildGetSingleAttachment(WorkflowValue<string> attachmentId)
        {
            WorkflowValue.Validate(attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<Attachment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Attachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildAudioGetAll))]
        public IBodyWorkflowAction<AudiosResponse> AudioGetAll([WorkflowExpression] Func<string> recordId = null, [WorkflowExpression] Func<string> formId = null, [WorkflowExpression] Func<bool> newestFirst = null, [WorkflowExpression] Func<bool> processed = null, [WorkflowExpression] Func<bool> stored = null, [WorkflowExpression] Func<bool> uploaded = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AudiosResponse> __BuildAudioGetAll(WorkflowValue<string> recordId = null, WorkflowValue<string> formId = null, WorkflowValue<bool> newestFirst = null, WorkflowValue<bool> processed = null, WorkflowValue<bool> stored = null, WorkflowValue<bool> uploaded = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: false);
            WorkflowValue.Validate(formId, nameof(formId), required: false);
            WorkflowValue.Validate(newestFirst, nameof(newestFirst), required: false);
            WorkflowValue.Validate(processed, nameof(processed), required: false);
            WorkflowValue.Validate(stored, nameof(stored), required: false);
            WorkflowValue.Validate(uploaded, nameof(uploaded), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<AudiosResponse>(() =>
            {
                var apiCallPath = "/v2/audio.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(recordId);
                if (formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
                if (newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(newestFirst);
                if (processed != null)
                    callPayload.Queries["processed"] = ExpressionConverter.Convert(processed);
                if (stored != null)
                    callPayload.Queries["stored"] = ExpressionConverter.Convert(stored);
                if (uploaded != null)
                    callPayload.Queries["uploaded"] = ExpressionConverter.Convert(uploaded);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<AudiosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildAudioGetOriginalFile))]
        public IBodyWorkflowAction<string> AudioGetOriginalFile([WorkflowExpression] Func<string> audioId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAudioGetOriginalFile(WorkflowValue<string> audioId)
        {
            WorkflowValue.Validate(audioId, nameof(audioId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/audio/{0}.mp4", ExpressionConverter.ConvertWithUrlEncoding(audioId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildPhotosGetAllMetadata))]
        public IBodyWorkflowAction<PhotosResponse> PhotosGetAllMetadata([WorkflowExpression] Func<string> recordId = null, [WorkflowExpression] Func<string> formId = null, [WorkflowExpression] Func<bool> newestFirst = null, [WorkflowExpression] Func<bool> processed = null, [WorkflowExpression] Func<bool> stored = null, [WorkflowExpression] Func<bool> uploaded = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PhotosResponse> __BuildPhotosGetAllMetadata(WorkflowValue<string> recordId = null, WorkflowValue<string> formId = null, WorkflowValue<bool> newestFirst = null, WorkflowValue<bool> processed = null, WorkflowValue<bool> stored = null, WorkflowValue<bool> uploaded = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: false);
            WorkflowValue.Validate(formId, nameof(formId), required: false);
            WorkflowValue.Validate(newestFirst, nameof(newestFirst), required: false);
            WorkflowValue.Validate(processed, nameof(processed), required: false);
            WorkflowValue.Validate(stored, nameof(stored), required: false);
            WorkflowValue.Validate(uploaded, nameof(uploaded), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<PhotosResponse>(() =>
            {
                var apiCallPath = "/v2/photos.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(recordId);
                if (formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
                if (newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(newestFirst);
                if (processed != null)
                    callPayload.Queries["processed"] = ExpressionConverter.Convert(processed);
                if (stored != null)
                    callPayload.Queries["stored"] = ExpressionConverter.Convert(stored);
                if (uploaded != null)
                    callPayload.Queries["uploaded"] = ExpressionConverter.Convert(uploaded);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<PhotosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildPhotosGetSingleFile))]
        public IBodyWorkflowAction<string> PhotosGetSingleFile([WorkflowExpression] Func<string> photoId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPhotosGetSingleFile(WorkflowValue<string> photoId)
        {
            WorkflowValue.Validate(photoId, nameof(photoId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/photos/{0}.jpg", ExpressionConverter.ConvertWithUrlEncoding(photoId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildPhotosGetSingleMetadata))]
        public IBodyWorkflowAction<SinglePhotoResponse> PhotosGetSingleMetadata([WorkflowExpression] Func<string> photoId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SinglePhotoResponse> __BuildPhotosGetSingleMetadata(WorkflowValue<string> photoId)
        {
            WorkflowValue.Validate(photoId, nameof(photoId), required: true);
            return new DeferredBodyAction<SinglePhotoResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/photos/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(photoId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SinglePhotoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildQuery))]
        public IWorkflowAction Query([WorkflowExpression] Func<string> bodyq, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<string> bodytableName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildQuery(WorkflowValue<string> bodyq, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null, WorkflowValue<bodyformatInput> bodyformat = null, WorkflowValue<string> bodytableName = null)
        {
            WorkflowValue.Validate(bodyq, nameof(bodyq), required: true);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            WorkflowValue.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowValue.Validate(bodytableName, nameof(bodytableName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyformat != null)
                {
                    body["format"] = ExpressionConverter.ConvertO(bodyformat);
                    bodypropCount++;
                }

                bodypropCount++;
                body["q"] = ExpressionConverter.ConvertO(bodyq);
                if (bodytableName != null)
                {
                    body["table_name"] = ExpressionConverter.ConvertO(bodytableName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildRecordsGetAll))]
        public IBodyWorkflowAction<RecordsResponse> RecordsGetAll([WorkflowExpression] Func<bool> newestFirst = null, [WorkflowExpression] Func<string> boundingBox = null, [WorkflowExpression] Func<string> changesetId = null, [WorkflowExpression] Func<string> formId = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> clientCreatedBefore = null, [WorkflowExpression] Func<string> clientCreatedSince = null, [WorkflowExpression] Func<string> clientUpdatedBefore = null, [WorkflowExpression] Func<string> clientUpdatedSince = null, [WorkflowExpression] Func<string> createdBefore = null, [WorkflowExpression] Func<string> createdSince = null, [WorkflowExpression] Func<string> updatedBefore = null, [WorkflowExpression] Func<string> updatedSince = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecordsResponse> __BuildRecordsGetAll(WorkflowValue<bool> newestFirst = null, WorkflowValue<string> boundingBox = null, WorkflowValue<string> changesetId = null, WorkflowValue<string> formId = null, WorkflowValue<string> projectId = null, WorkflowValue<string> clientCreatedBefore = null, WorkflowValue<string> clientCreatedSince = null, WorkflowValue<string> clientUpdatedBefore = null, WorkflowValue<string> clientUpdatedSince = null, WorkflowValue<string> createdBefore = null, WorkflowValue<string> createdSince = null, WorkflowValue<string> updatedBefore = null, WorkflowValue<string> updatedSince = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(newestFirst, nameof(newestFirst), required: false);
            WorkflowValue.Validate(boundingBox, nameof(boundingBox), required: false);
            WorkflowValue.Validate(changesetId, nameof(changesetId), required: false);
            WorkflowValue.Validate(formId, nameof(formId), required: false);
            WorkflowValue.Validate(projectId, nameof(projectId), required: false);
            WorkflowValue.Validate(clientCreatedBefore, nameof(clientCreatedBefore), required: false);
            WorkflowValue.Validate(clientCreatedSince, nameof(clientCreatedSince), required: false);
            WorkflowValue.Validate(clientUpdatedBefore, nameof(clientUpdatedBefore), required: false);
            WorkflowValue.Validate(clientUpdatedSince, nameof(clientUpdatedSince), required: false);
            WorkflowValue.Validate(createdBefore, nameof(createdBefore), required: false);
            WorkflowValue.Validate(createdSince, nameof(createdSince), required: false);
            WorkflowValue.Validate(updatedBefore, nameof(updatedBefore), required: false);
            WorkflowValue.Validate(updatedSince, nameof(updatedSince), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<RecordsResponse>(() =>
            {
                var apiCallPath = "/v2/records.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(newestFirst);
                if (boundingBox != null)
                    callPayload.Queries["bounding_box"] = ExpressionConverter.Convert(boundingBox);
                if (changesetId != null)
                    callPayload.Queries["changeset_id"] = ExpressionConverter.Convert(changesetId);
                if (formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
                if (projectId != null)
                    callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
                if (clientCreatedBefore != null)
                    callPayload.Queries["client_created_before"] = ExpressionConverter.Convert(clientCreatedBefore);
                if (clientCreatedSince != null)
                    callPayload.Queries["client_created_since"] = ExpressionConverter.Convert(clientCreatedSince);
                if (clientUpdatedBefore != null)
                    callPayload.Queries["client_updated_before"] = ExpressionConverter.Convert(clientUpdatedBefore);
                if (clientUpdatedSince != null)
                    callPayload.Queries["client_updated_since"] = ExpressionConverter.Convert(clientUpdatedSince);
                if (createdBefore != null)
                    callPayload.Queries["created_before"] = ExpressionConverter.Convert(createdBefore);
                if (createdSince != null)
                    callPayload.Queries["created_since"] = ExpressionConverter.Convert(createdSince);
                if (updatedBefore != null)
                    callPayload.Queries["updated_before"] = ExpressionConverter.Convert(updatedBefore);
                if (updatedSince != null)
                    callPayload.Queries["updated_since"] = ExpressionConverter.Convert(updatedSince);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<RecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildRecordsCreate))]
        public IBodyWorkflowAction<SingleRecordResponse> RecordsCreate([WorkflowExpression] Func<object> bodyrecordgeometrycoordinates, [WorkflowExpression] Func<bodyrecordgeometrytypeInput> bodyrecordgeometrytype, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<bool> xSkipWorkflows = null, [WorkflowExpression] Func<bool> xSkipWebhooks = null, [WorkflowExpression] Func<string> bodyrecordassignedToId = null, [WorkflowExpression] Func<string> bodyrecordformId = null, [WorkflowExpression] Func<double> bodyrecordlatitude = null, [WorkflowExpression] Func<double> bodyrecordlongitude = null, [WorkflowExpression] Func<string> bodyrecordprojectId = null, [WorkflowExpression] Func<string> bodyrecordstatus = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleRecordResponse> __BuildRecordsCreate(WorkflowValue<object> bodyrecordgeometrycoordinates, WorkflowValue<bodyrecordgeometrytypeInput> bodyrecordgeometrytype, WorkflowValue<string> contentType = null, WorkflowValue<bool> xSkipWorkflows = null, WorkflowValue<bool> xSkipWebhooks = null, WorkflowValue<string> bodyrecordassignedToId = null, WorkflowValue<string> bodyrecordformId = null, WorkflowValue<double> bodyrecordlatitude = null, WorkflowValue<double> bodyrecordlongitude = null, WorkflowValue<string> bodyrecordprojectId = null, WorkflowValue<string> bodyrecordstatus = null)
        {
            WorkflowValue.Validate(bodyrecordgeometrycoordinates, nameof(bodyrecordgeometrycoordinates), required: true);
            WorkflowValue.Validate(bodyrecordgeometrytype, nameof(bodyrecordgeometrytype), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(xSkipWorkflows, nameof(xSkipWorkflows), required: false);
            WorkflowValue.Validate(xSkipWebhooks, nameof(xSkipWebhooks), required: false);
            WorkflowValue.Validate(bodyrecordassignedToId, nameof(bodyrecordassignedToId), required: false);
            WorkflowValue.Validate(bodyrecordformId, nameof(bodyrecordformId), required: false);
            WorkflowValue.Validate(bodyrecordlatitude, nameof(bodyrecordlatitude), required: false);
            WorkflowValue.Validate(bodyrecordlongitude, nameof(bodyrecordlongitude), required: false);
            WorkflowValue.Validate(bodyrecordprojectId, nameof(bodyrecordprojectId), required: false);
            WorkflowValue.Validate(bodyrecordstatus, nameof(bodyrecordstatus), required: false);
            return new DeferredBodyAction<SingleRecordResponse>(() =>
            {
                var apiCallPath = "/v2/records.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["X-SkipWorkflows"] = Convert.ToString(false);
                if (xSkipWorkflows != null)
                    callPayload.Headers["X-SkipWorkflows"] = ExpressionConverter.Convert(xSkipWorkflows);
                callPayload.Headers["X-SkipWebhooks"] = Convert.ToString(false);
                if (xSkipWebhooks != null)
                    callPayload.Headers["X-SkipWebhooks"] = ExpressionConverter.Convert(xSkipWebhooks);
                var body = new JObject();
                var bodypropCount = 0;
                var recordObject = new JObject();
                var recordObjectpropCount = 0;
                if (bodyrecordassignedToId != null)
                {
                    recordObject["assigned_to_id"] = ExpressionConverter.ConvertO(bodyrecordassignedToId);
                    recordObjectpropCount++;
                }

                if (bodyrecordformId != null)
                {
                    recordObject["form_id"] = ExpressionConverter.ConvertO(bodyrecordformId);
                    recordObjectpropCount++;
                }

                var formValuesObject = new JObject();
                var formValuesObjectpropCount = 0;
                if (formValuesObjectpropCount > 0)
                {
                    recordObject["form_values"] = formValuesObject;
                    recordObjectpropCount++;
                }

                var geometryObject = new JObject();
                var geometryObjectpropCount = 0;
                geometryObjectpropCount++;
                geometryObject["coordinates"] = ExpressionConverter.ConvertO(bodyrecordgeometrycoordinates);
                geometryObjectpropCount++;
                geometryObject["type"] = ExpressionConverter.ConvertO(bodyrecordgeometrytype);
                if (geometryObjectpropCount > 0)
                {
                    recordObject["geometry"] = geometryObject;
                    recordObjectpropCount++;
                }

                if (bodyrecordlatitude != null)
                {
                    recordObject["latitude"] = ExpressionConverter.ConvertO(bodyrecordlatitude);
                    recordObjectpropCount++;
                }

                if (bodyrecordlongitude != null)
                {
                    recordObject["longitude"] = ExpressionConverter.ConvertO(bodyrecordlongitude);
                    recordObjectpropCount++;
                }

                if (bodyrecordprojectId != null)
                {
                    recordObject["project_id"] = ExpressionConverter.ConvertO(bodyrecordprojectId);
                    recordObjectpropCount++;
                }

                if (bodyrecordstatus != null)
                {
                    recordObject["status"] = ExpressionConverter.ConvertO(bodyrecordstatus);
                    recordObjectpropCount++;
                }

                if (recordObjectpropCount > 0)
                {
                    body["record"] = recordObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildRecordsDelete))]
        public IBodyWorkflowAction<SingleRecordResponse> RecordsDelete([WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<bool> xSkipWorkflows = null, [WorkflowExpression] Func<bool> xSkipWebhooks = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleRecordResponse> __BuildRecordsDelete(WorkflowValue<string> recordId, WorkflowValue<bool> xSkipWorkflows = null, WorkflowValue<bool> xSkipWebhooks = null)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(xSkipWorkflows, nameof(xSkipWorkflows), required: false);
            WorkflowValue.Validate(xSkipWebhooks, nameof(xSkipWebhooks), required: false);
            return new DeferredBodyAction<SingleRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/records/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-SkipWorkflows"] = Convert.ToString(false);
                if (xSkipWorkflows != null)
                    callPayload.Headers["X-SkipWorkflows"] = ExpressionConverter.Convert(xSkipWorkflows);
                callPayload.Headers["X-SkipWebhooks"] = Convert.ToString(false);
                if (xSkipWebhooks != null)
                    callPayload.Headers["X-SkipWebhooks"] = ExpressionConverter.Convert(xSkipWebhooks);
                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildRecordsGetSingle))]
        public IBodyWorkflowAction<SingleRecordResponse> RecordsGetSingle([WorkflowExpression] Func<string> recordId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleRecordResponse> __BuildRecordsGetSingle(WorkflowValue<string> recordId)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<SingleRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/records/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildRecordsPartialUpdate))]
        public IBodyWorkflowAction<SingleRecordResponse> RecordsPartialUpdate([WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> bodyrecordgeometrycoordinates, [WorkflowExpression] Func<bodyrecordgeometrytypeInput> bodyrecordgeometrytype, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<bool> xSkipWorkflows = null, [WorkflowExpression] Func<bool> xSkipWebhooks = null, [WorkflowExpression] Func<string> bodyrecordassignedToId = null, [WorkflowExpression] Func<double> bodyrecordlatitude = null, [WorkflowExpression] Func<double> bodyrecordlongitude = null, [WorkflowExpression] Func<string> bodyrecordprojectId = null, [WorkflowExpression] Func<string> bodyrecordstatus = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleRecordResponse> __BuildRecordsPartialUpdate(WorkflowValue<string> recordId, WorkflowValue<object> bodyrecordgeometrycoordinates, WorkflowValue<bodyrecordgeometrytypeInput> bodyrecordgeometrytype, WorkflowValue<string> contentType = null, WorkflowValue<bool> xSkipWorkflows = null, WorkflowValue<bool> xSkipWebhooks = null, WorkflowValue<string> bodyrecordassignedToId = null, WorkflowValue<double> bodyrecordlatitude = null, WorkflowValue<double> bodyrecordlongitude = null, WorkflowValue<string> bodyrecordprojectId = null, WorkflowValue<string> bodyrecordstatus = null)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(bodyrecordgeometrycoordinates, nameof(bodyrecordgeometrycoordinates), required: true);
            WorkflowValue.Validate(bodyrecordgeometrytype, nameof(bodyrecordgeometrytype), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(xSkipWorkflows, nameof(xSkipWorkflows), required: false);
            WorkflowValue.Validate(xSkipWebhooks, nameof(xSkipWebhooks), required: false);
            WorkflowValue.Validate(bodyrecordassignedToId, nameof(bodyrecordassignedToId), required: false);
            WorkflowValue.Validate(bodyrecordlatitude, nameof(bodyrecordlatitude), required: false);
            WorkflowValue.Validate(bodyrecordlongitude, nameof(bodyrecordlongitude), required: false);
            WorkflowValue.Validate(bodyrecordprojectId, nameof(bodyrecordprojectId), required: false);
            WorkflowValue.Validate(bodyrecordstatus, nameof(bodyrecordstatus), required: false);
            return new DeferredBodyAction<SingleRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/records/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["X-SkipWorkflows"] = Convert.ToString(false);
                if (xSkipWorkflows != null)
                    callPayload.Headers["X-SkipWorkflows"] = ExpressionConverter.Convert(xSkipWorkflows);
                callPayload.Headers["X-SkipWebhooks"] = Convert.ToString(false);
                if (xSkipWebhooks != null)
                    callPayload.Headers["X-SkipWebhooks"] = ExpressionConverter.Convert(xSkipWebhooks);
                var body = new JObject();
                var bodypropCount = 0;
                var recordObject = new JObject();
                var recordObjectpropCount = 0;
                if (bodyrecordassignedToId != null)
                {
                    recordObject["assigned_to_id"] = ExpressionConverter.ConvertO(bodyrecordassignedToId);
                    recordObjectpropCount++;
                }

                var formValuesObject = new JObject();
                var formValuesObjectpropCount = 0;
                if (formValuesObjectpropCount > 0)
                {
                    recordObject["form_values"] = formValuesObject;
                    recordObjectpropCount++;
                }

                var geometryObject = new JObject();
                var geometryObjectpropCount = 0;
                geometryObjectpropCount++;
                geometryObject["coordinates"] = ExpressionConverter.ConvertO(bodyrecordgeometrycoordinates);
                geometryObjectpropCount++;
                geometryObject["type"] = ExpressionConverter.ConvertO(bodyrecordgeometrytype);
                if (geometryObjectpropCount > 0)
                {
                    recordObject["geometry"] = geometryObject;
                    recordObjectpropCount++;
                }

                if (bodyrecordlatitude != null)
                {
                    recordObject["latitude"] = ExpressionConverter.ConvertO(bodyrecordlatitude);
                    recordObjectpropCount++;
                }

                if (bodyrecordlongitude != null)
                {
                    recordObject["longitude"] = ExpressionConverter.ConvertO(bodyrecordlongitude);
                    recordObjectpropCount++;
                }

                if (bodyrecordprojectId != null)
                {
                    recordObject["project_id"] = ExpressionConverter.ConvertO(bodyrecordprojectId);
                    recordObjectpropCount++;
                }

                if (bodyrecordstatus != null)
                {
                    recordObject["status"] = ExpressionConverter.ConvertO(bodyrecordstatus);
                    recordObjectpropCount++;
                }

                if (recordObjectpropCount > 0)
                {
                    body["record"] = recordObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SingleRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildRecordsUpdate))]
        public IWorkflowAction RecordsUpdate([WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> bodyrecordgeometrycoordinates, [WorkflowExpression] Func<bodyrecordgeometrytypeInput> bodyrecordgeometrytype, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<bool> xSkipWorkflows = null, [WorkflowExpression] Func<bool> xSkipWebhooks = null, [WorkflowExpression] Func<string> bodyrecordassignedToId = null, [WorkflowExpression] Func<string> bodyrecordformId = null, [WorkflowExpression] Func<double> bodyrecordlatitude = null, [WorkflowExpression] Func<double> bodyrecordlongitude = null, [WorkflowExpression] Func<string> bodyrecordprojectId = null, [WorkflowExpression] Func<string> bodyrecordstatus = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRecordsUpdate(WorkflowValue<string> recordId, WorkflowValue<object> bodyrecordgeometrycoordinates, WorkflowValue<bodyrecordgeometrytypeInput> bodyrecordgeometrytype, WorkflowValue<string> contentType = null, WorkflowValue<bool> xSkipWorkflows = null, WorkflowValue<bool> xSkipWebhooks = null, WorkflowValue<string> bodyrecordassignedToId = null, WorkflowValue<string> bodyrecordformId = null, WorkflowValue<double> bodyrecordlatitude = null, WorkflowValue<double> bodyrecordlongitude = null, WorkflowValue<string> bodyrecordprojectId = null, WorkflowValue<string> bodyrecordstatus = null)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(bodyrecordgeometrycoordinates, nameof(bodyrecordgeometrycoordinates), required: true);
            WorkflowValue.Validate(bodyrecordgeometrytype, nameof(bodyrecordgeometrytype), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(xSkipWorkflows, nameof(xSkipWorkflows), required: false);
            WorkflowValue.Validate(xSkipWebhooks, nameof(xSkipWebhooks), required: false);
            WorkflowValue.Validate(bodyrecordassignedToId, nameof(bodyrecordassignedToId), required: false);
            WorkflowValue.Validate(bodyrecordformId, nameof(bodyrecordformId), required: false);
            WorkflowValue.Validate(bodyrecordlatitude, nameof(bodyrecordlatitude), required: false);
            WorkflowValue.Validate(bodyrecordlongitude, nameof(bodyrecordlongitude), required: false);
            WorkflowValue.Validate(bodyrecordprojectId, nameof(bodyrecordprojectId), required: false);
            WorkflowValue.Validate(bodyrecordstatus, nameof(bodyrecordstatus), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/records/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["X-SkipWorkflows"] = Convert.ToString(false);
                if (xSkipWorkflows != null)
                    callPayload.Headers["X-SkipWorkflows"] = ExpressionConverter.Convert(xSkipWorkflows);
                callPayload.Headers["X-SkipWebhooks"] = Convert.ToString(false);
                if (xSkipWebhooks != null)
                    callPayload.Headers["X-SkipWebhooks"] = ExpressionConverter.Convert(xSkipWebhooks);
                var body = new JObject();
                var bodypropCount = 0;
                var recordObject = new JObject();
                var recordObjectpropCount = 0;
                if (bodyrecordassignedToId != null)
                {
                    recordObject["assigned_to_id"] = ExpressionConverter.ConvertO(bodyrecordassignedToId);
                    recordObjectpropCount++;
                }

                if (bodyrecordformId != null)
                {
                    recordObject["form_id"] = ExpressionConverter.ConvertO(bodyrecordformId);
                    recordObjectpropCount++;
                }

                var formValuesObject = new JObject();
                var formValuesObjectpropCount = 0;
                if (formValuesObjectpropCount > 0)
                {
                    recordObject["form_values"] = formValuesObject;
                    recordObjectpropCount++;
                }

                var geometryObject = new JObject();
                var geometryObjectpropCount = 0;
                geometryObjectpropCount++;
                geometryObject["coordinates"] = ExpressionConverter.ConvertO(bodyrecordgeometrycoordinates);
                geometryObjectpropCount++;
                geometryObject["type"] = ExpressionConverter.ConvertO(bodyrecordgeometrytype);
                if (geometryObjectpropCount > 0)
                {
                    recordObject["geometry"] = geometryObject;
                    recordObjectpropCount++;
                }

                if (bodyrecordlatitude != null)
                {
                    recordObject["latitude"] = ExpressionConverter.ConvertO(bodyrecordlatitude);
                    recordObjectpropCount++;
                }

                if (bodyrecordlongitude != null)
                {
                    recordObject["longitude"] = ExpressionConverter.ConvertO(bodyrecordlongitude);
                    recordObjectpropCount++;
                }

                if (bodyrecordprojectId != null)
                {
                    recordObject["project_id"] = ExpressionConverter.ConvertO(bodyrecordprojectId);
                    recordObjectpropCount++;
                }

                if (bodyrecordstatus != null)
                {
                    recordObject["status"] = ExpressionConverter.ConvertO(bodyrecordstatus);
                    recordObjectpropCount++;
                }

                if (recordObjectpropCount > 0)
                {
                    body["record"] = recordObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildRecordsGetHistory))]
        public IBodyWorkflowAction<RecordHistoryResponse> RecordsGetHistory([WorkflowExpression] Func<string> recordId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecordHistoryResponse> __BuildRecordsGetHistory(WorkflowValue<string> recordId)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<RecordHistoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/records/{0}/history.json", ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RecordHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildReportsCreate))]
        public IBodyWorkflowAction<ReportResponse> ReportsCreate([WorkflowExpression] Func<string> bodyreportrecordId = null, [WorkflowExpression] Func<string> bodyreporttemplateId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReportResponse> __BuildReportsCreate(WorkflowValue<string> bodyreportrecordId = null, WorkflowValue<string> bodyreporttemplateId = null)
        {
            WorkflowValue.Validate(bodyreportrecordId, nameof(bodyreportrecordId), required: false);
            WorkflowValue.Validate(bodyreporttemplateId, nameof(bodyreporttemplateId), required: false);
            return new DeferredBodyAction<ReportResponse>(() =>
            {
                var apiCallPath = "/v2/reports.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var reportObject = new JObject();
                var reportObjectpropCount = 0;
                if (bodyreportrecordId != null)
                {
                    reportObject["record_id"] = ExpressionConverter.ConvertO(bodyreportrecordId);
                    reportObjectpropCount++;
                }

                if (bodyreporttemplateId != null)
                {
                    reportObject["template_id"] = ExpressionConverter.ConvertO(bodyreporttemplateId);
                    reportObjectpropCount++;
                }

                if (reportObjectpropCount > 0)
                {
                    body["report"] = reportObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildReportsFile))]
        public IBodyWorkflowAction<string> ReportsFile([WorkflowExpression] Func<string> reportId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildReportsFile(WorkflowValue<string> reportId)
        {
            WorkflowValue.Validate(reportId, nameof(reportId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/reports/{0}.pdf", ExpressionConverter.ConvertWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildSignaturesGetAll))]
        public IBodyWorkflowAction<SignaturesResponse> SignaturesGetAll([WorkflowExpression] Func<string> recordId = null, [WorkflowExpression] Func<string> formId = null, [WorkflowExpression] Func<bool> newestFirst = null, [WorkflowExpression] Func<bool> processed = null, [WorkflowExpression] Func<bool> stored = null, [WorkflowExpression] Func<bool> uploaded = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SignaturesResponse> __BuildSignaturesGetAll(WorkflowValue<string> recordId = null, WorkflowValue<string> formId = null, WorkflowValue<bool> newestFirst = null, WorkflowValue<bool> processed = null, WorkflowValue<bool> stored = null, WorkflowValue<bool> uploaded = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: false);
            WorkflowValue.Validate(formId, nameof(formId), required: false);
            WorkflowValue.Validate(newestFirst, nameof(newestFirst), required: false);
            WorkflowValue.Validate(processed, nameof(processed), required: false);
            WorkflowValue.Validate(stored, nameof(stored), required: false);
            WorkflowValue.Validate(uploaded, nameof(uploaded), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SignaturesResponse>(() =>
            {
                var apiCallPath = "/v2/signatures.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(recordId);
                if (formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
                if (newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(newestFirst);
                if (processed != null)
                    callPayload.Queries["processed"] = ExpressionConverter.Convert(processed);
                if (stored != null)
                    callPayload.Queries["stored"] = ExpressionConverter.Convert(stored);
                if (uploaded != null)
                    callPayload.Queries["uploaded"] = ExpressionConverter.Convert(uploaded);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<SignaturesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildSignaturesGetSingleMetadata))]
        public IBodyWorkflowAction<SingleSignatureResponse> SignaturesGetSingleMetadata([WorkflowExpression] Func<string> signatureId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleSignatureResponse> __BuildSignaturesGetSingleMetadata(WorkflowValue<string> signatureId)
        {
            WorkflowValue.Validate(signatureId, nameof(signatureId), required: true);
            return new DeferredBodyAction<SingleSignatureResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/signatures/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(signatureId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleSignatureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildSignaturesGetSingleFile))]
        public IBodyWorkflowAction<string> SignaturesGetSingleFile([WorkflowExpression] Func<string> signatureId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSignaturesGetSingleFile(WorkflowValue<string> signatureId)
        {
            WorkflowValue.Validate(signatureId, nameof(signatureId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/signatures/{0}.png", ExpressionConverter.ConvertWithUrlEncoding(signatureId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildSketchesGetAllMetadata))]
        public IBodyWorkflowAction<SketchesResponse> SketchesGetAllMetadata([WorkflowExpression] Func<string> recordId = null, [WorkflowExpression] Func<string> formId = null, [WorkflowExpression] Func<bool> newestFirst = null, [WorkflowExpression] Func<bool> processed = null, [WorkflowExpression] Func<bool> stored = null, [WorkflowExpression] Func<bool> uploaded = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SketchesResponse> __BuildSketchesGetAllMetadata(WorkflowValue<string> recordId = null, WorkflowValue<string> formId = null, WorkflowValue<bool> newestFirst = null, WorkflowValue<bool> processed = null, WorkflowValue<bool> stored = null, WorkflowValue<bool> uploaded = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: false);
            WorkflowValue.Validate(formId, nameof(formId), required: false);
            WorkflowValue.Validate(newestFirst, nameof(newestFirst), required: false);
            WorkflowValue.Validate(processed, nameof(processed), required: false);
            WorkflowValue.Validate(stored, nameof(stored), required: false);
            WorkflowValue.Validate(uploaded, nameof(uploaded), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SketchesResponse>(() =>
            {
                var apiCallPath = "/v2/sketches.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(recordId);
                if (formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
                if (newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(newestFirst);
                if (processed != null)
                    callPayload.Queries["processed"] = ExpressionConverter.Convert(processed);
                if (stored != null)
                    callPayload.Queries["stored"] = ExpressionConverter.Convert(stored);
                if (uploaded != null)
                    callPayload.Queries["uploaded"] = ExpressionConverter.Convert(uploaded);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<SketchesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildSketchesGetSingleFile))]
        public IBodyWorkflowAction<string> SketchesGetSingleFile([WorkflowExpression] Func<string> sketchId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSketchesGetSingleFile(WorkflowValue<string> sketchId)
        {
            WorkflowValue.Validate(sketchId, nameof(sketchId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/sketches/{0}.jpg", ExpressionConverter.ConvertWithUrlEncoding(sketchId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildSketchesGetSingleMetadata))]
        public IBodyWorkflowAction<SingleSketchResponse> SketchesGetSingleMetadata([WorkflowExpression] Func<string> sketchId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleSketchResponse> __BuildSketchesGetSingleMetadata(WorkflowValue<string> sketchId)
        {
            WorkflowValue.Validate(sketchId, nameof(sketchId), required: true);
            return new DeferredBodyAction<SingleSketchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/sketches/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(sketchId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleSketchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildVideosGetAll))]
        public IBodyWorkflowAction<VideosResponse> VideosGetAll([WorkflowExpression] Func<string> recordId = null, [WorkflowExpression] Func<string> formId = null, [WorkflowExpression] Func<bool> newestFirst = null, [WorkflowExpression] Func<bool> processed = null, [WorkflowExpression] Func<bool> stored = null, [WorkflowExpression] Func<bool> uploaded = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VideosResponse> __BuildVideosGetAll(WorkflowValue<string> recordId = null, WorkflowValue<string> formId = null, WorkflowValue<bool> newestFirst = null, WorkflowValue<bool> processed = null, WorkflowValue<bool> stored = null, WorkflowValue<bool> uploaded = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(recordId, nameof(recordId), required: false);
            WorkflowValue.Validate(formId, nameof(formId), required: false);
            WorkflowValue.Validate(newestFirst, nameof(newestFirst), required: false);
            WorkflowValue.Validate(processed, nameof(processed), required: false);
            WorkflowValue.Validate(stored, nameof(stored), required: false);
            WorkflowValue.Validate(uploaded, nameof(uploaded), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<VideosResponse>(() =>
            {
                var apiCallPath = "/v2/videos.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(recordId);
                if (formId != null)
                    callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
                if (newestFirst != null)
                    callPayload.Queries["newest_first"] = ExpressionConverter.Convert(newestFirst);
                if (processed != null)
                    callPayload.Queries["processed"] = ExpressionConverter.Convert(processed);
                if (stored != null)
                    callPayload.Queries["stored"] = ExpressionConverter.Convert(stored);
                if (uploaded != null)
                    callPayload.Queries["uploaded"] = ExpressionConverter.Convert(uploaded);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = Convert.ToString(20000);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<VideosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fulcrum")]
        [WorkflowExpressionFactory(nameof(__BuildVideosGetOriginalFile))]
        public IBodyWorkflowAction<string> VideosGetOriginalFile([WorkflowExpression] Func<string> videoId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVideosGetOriginalFile(WorkflowValue<string> videoId)
        {
            WorkflowValue.Validate(videoId, nameof(videoId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/videos/{0}.mp4", ExpressionConverter.ConvertWithUrlEncoding(videoId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class FulcrumTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnFulcrumEvent))]
        public IBodyWorkflowTrigger<OnFulcrumEventResponse> OnFulcrumEvent([WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<bool> bodywebhookactive = null, [WorkflowExpression] Func<string> bodywebhookwebhookName = null, [WorkflowExpression] Func<bool> bodywebhookrunForBulkActions = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnFulcrumEventResponse> __BuildOnFulcrumEvent(WorkflowValue<string> contentType = null, WorkflowValue<bool> bodywebhookactive = null, WorkflowValue<string> bodywebhookwebhookName = null, WorkflowValue<bool> bodywebhookrunForBulkActions = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(bodywebhookactive, nameof(bodywebhookactive), required: false);
            WorkflowValue.Validate(bodywebhookwebhookName, nameof(bodywebhookwebhookName), required: false);
            WorkflowValue.Validate(bodywebhookrunForBulkActions, nameof(bodywebhookrunForBulkActions), required: false);
            return new DeferredBodyTrigger<OnFulcrumEventResponse>(() =>
            {
                var apiCallPath = "/v2/webhooks.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var webhookObject = new JObject();
                var webhookObjectpropCount = 0;
                if (bodywebhookactive != null)
                {
                    webhookObject["active"] = ExpressionConverter.ConvertO(bodywebhookactive);
                    webhookObjectpropCount++;
                }

                if (bodywebhookwebhookName != null)
                {
                    if (bodywebhookwebhookName != null)
                    {
                        webhookObject["name"] = ExpressionConverter.ConvertO(bodywebhookwebhookName);
                        webhookObjectpropCount++;
                    }

                    webhookObjectpropCount++;
                }
                else
                {
                    webhookObject["name"] = "Power Platform Trigger";
                    webhookObjectpropCount++;
                }

                if (bodywebhookrunForBulkActions != null)
                {
                    webhookObject["run_for_bulk_actions"] = ExpressionConverter.ConvertO(bodywebhookrunForBulkActions);
                    webhookObjectpropCount++;
                }

                webhookObject["url"] = "#{listCallbackUrl()}";
                webhookObjectpropCount++;
                if (webhookObjectpropCount > 0)
                {
                    body["webhook"] = webhookObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<OnFulcrumEventResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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

    public enum sortInput
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "file_size")]
        FileSize,
        [EnumMember(Value = "uploaded_at")]
        UploadedAt
    }

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

    public enum bodyformatInput
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

    public enum bodyrecordgeometrytypeInput
    {
        Point,
        LineString,
        Polygon,
        MultiPoint,
        MultiLineString,
        MultiPolygon
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
        public string EventID { get; set; }

        [JsonProperty("type")]
        public string EventType { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerID { get; set; }

        [JsonProperty("data")]
        public JToken EventData { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
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
