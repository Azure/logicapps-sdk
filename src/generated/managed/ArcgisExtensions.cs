//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Arcgis
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ArcgisActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<AddAttachmentResponse, ApiConnectionActionConfiguration> AddAttachment(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<double>> objectId, Expression<Func<string>> attachmentName, Expression<Func<string>> data, Expression<Func<string>> keywords = null)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_attachmentName = WorkflowExpression.Compile(attachmentName, nameof(attachmentName), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            var __workflow_keywords = WorkflowExpression.Compile(keywords, nameof(keywords), required: false);
            return new DeferredBodyAction<AddAttachmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/attachment/addAttachment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Queries["attachmentName"] = ExpressionConverter.Convert(__workflow_attachmentName);
                if (__workflow_keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(__workflow_keywords);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<AddAttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<UpdateAttachmentResponse, ApiConnectionActionConfiguration> UpdateAttachment(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<double>> objectid, Expression<Func<double>> attachmentId, Expression<Func<string>> attachmentName, Expression<Func<string>> data)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_objectid = WorkflowExpression.Compile(objectid, nameof(objectid), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_attachmentName = WorkflowExpression.Compile(attachmentName, nameof(attachmentName), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<UpdateAttachmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/attachment/updateAttachment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Queries["objectid"] = ExpressionConverter.Convert(__workflow_objectid);
                callPayload.Queries["attachmentId"] = ExpressionConverter.Convert(__workflow_attachmentId);
                callPayload.Queries["attachmentName"] = ExpressionConverter.Convert(__workflow_attachmentName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<UpdateAttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<QueryAttachmentResponseItem[], ApiConnectionActionConfiguration> QueryAttachment(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<double>> objectId, Expression<Func<string>> keywords = null)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_keywords = WorkflowExpression.Compile(keywords, nameof(keywords), required: false);
            return new DeferredBodyAction<QueryAttachmentResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/attachment/queryAttachments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                if (__workflow_keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(__workflow_keywords);
                return new ApiConnectionAction<QueryAttachmentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetAttachment(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<double>> objectid, Expression<Func<double>> attachmentId)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_objectid = WorkflowExpression.Compile(objectid, nameof(objectid), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/attachment/getAttachment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Queries["objectid"] = ExpressionConverter.Convert(__workflow_objectid);
                callPayload.Queries["attachmentId"] = ExpressionConverter.Convert(__workflow_attachmentId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetAttachmentFromUrl(Expression<Func<string>> attachmentUrl)
        {
            var __workflow_attachmentUrl = WorkflowExpression.Compile(attachmentUrl, nameof(attachmentUrl), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/attachment/getAttachment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["attachmentUrl"] = ExpressionConverter.Convert(__workflow_attachmentUrl);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<DeleteAttachmentsResponseItem[], ApiConnectionActionConfiguration> DeleteAttachments(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<double>> objectid, Expression<Func<string>> attachmentIds)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_objectid = WorkflowExpression.Compile(objectid, nameof(objectid), required: true);
            var __workflow_attachmentIds = WorkflowExpression.Compile(attachmentIds, nameof(attachmentIds), required: true);
            return new DeferredBodyAction<DeleteAttachmentsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/attachment/deleteAttachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Queries["objectid"] = ExpressionConverter.Convert(__workflow_objectid);
                callPayload.Queries["attachmentIds"] = ExpressionConverter.Convert(__workflow_attachmentIds);
                return new ApiConnectionAction<DeleteAttachmentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<RunResult, ApiConnectionActionConfiguration> RunDataPipeline(Expression<Func<string>> dataPipelineFilter, Expression<Func<RunDataPipelineInput>> submitRunBody)
        {
            var __workflow_dataPipelineFilter = WorkflowExpression.Compile(dataPipelineFilter, nameof(dataPipelineFilter), required: true);
            var __workflow_submitRunBody = WorkflowExpression.Compile(submitRunBody, nameof(submitRunBody), required: true);
            return new DeferredBodyAction<RunResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/dataPipelines/runs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["dataPipelineFilter"] = ExpressionConverter.Convert(__workflow_dataPipelineFilter);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_submitRunBody);
                return new ApiConnectionAction<RunResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<BatchAddFeatures, ApiConnectionActionConfiguration> AddFeaturesBatch(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<object>> body)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BatchAddFeatures, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/featureLayer/addFeatures";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BatchAddFeatures>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<CreateItemInFeatureLayerDomainsResponse, ApiConnectionActionConfiguration> CreateItemInFeatureLayerDomains(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<object>> data)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<CreateItemInFeatureLayerDomainsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/featureLayer/createFeature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<CreateItemInFeatureLayerDomainsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<UpdateItemInFeatureLayerDomainsResponse, ApiConnectionActionConfiguration> UpdateItemInFeatureLayerDomains(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<string>> idField, Expression<Func<object>> data)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_idField = WorkflowExpression.Compile(idField, nameof(idField), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<UpdateItemInFeatureLayerDomainsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/featureLayer/updateFeature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Queries["idField"] = ExpressionConverter.Convert(__workflow_idField);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<UpdateItemInFeatureLayerDomainsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<BatchUpdateFeatures, ApiConnectionActionConfiguration> UpdateFeaturesBatch(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<string>> idField, Expression<Func<object>> body)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_idField = WorkflowExpression.Compile(idField, nameof(idField), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BatchUpdateFeatures, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/featureLayer/updateFeatures";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Queries["idField"] = ExpressionConverter.Convert(__workflow_idField);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BatchUpdateFeatures>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<DeleteItemInFeatureLayerResponseItem[], ApiConnectionActionConfiguration> DeleteItemInFeatureLayer(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<string>> idField, Expression<Func<DeleteItemInFeatureLayerInput>> data = null)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_idField = WorkflowExpression.Compile(idField, nameof(idField), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: false);
            return new DeferredBodyAction<DeleteItemInFeatureLayerResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/featureLayer/deleteFeature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Queries["idField"] = ExpressionConverter.Convert(__workflow_idField);
                if (__workflow_data != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<DeleteItemInFeatureLayerResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetCodedDomains(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/featureLayer/codedDomain";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetFeatureLayerInfo(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/featureLayer/information";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<ReverseGeocodeResponse, ApiConnectionActionConfiguration> ReverseGeocode(Expression<Func<string>> geocoder, Expression<Func<double>> x, Expression<Func<double>> y, Expression<Func<string>> srs = null, Expression<Func<locationTypeInput>> locationType = null)
        {
            var __workflow_geocoder = WorkflowExpression.Compile(geocoder, nameof(geocoder), required: true);
            var __workflow_x = WorkflowExpression.Compile(x, nameof(x), required: true);
            var __workflow_y = WorkflowExpression.Compile(y, nameof(y), required: true);
            var __workflow_srs = WorkflowExpression.Compile(srs, nameof(srs), required: false);
            var __workflow_locationType = WorkflowExpression.Compile(locationType, nameof(locationType), required: false);
            return new DeferredBodyAction<ReverseGeocodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/geocode/reverseGeocode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocoder"] = ExpressionConverter.Convert(__workflow_geocoder);
                callPayload.Queries["x"] = ExpressionConverter.Convert(__workflow_x);
                callPayload.Queries["y"] = ExpressionConverter.Convert(__workflow_y);
                if (__workflow_srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(__workflow_srs);
                callPayload.Queries["locationType"] = Convert.ToString("Rooftop");
                if (__workflow_locationType != null)
                    callPayload.Queries["locationType"] = ExpressionConverter.Convert(__workflow_locationType);
                return new ApiConnectionAction<ReverseGeocodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GeometryService(Expression<Func<string>> operation, Expression<Func<object>> data)
        {
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/geometry/process";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["operation"] = ExpressionConverter.Convert(__workflow_operation);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<TimeConversionHelperResponse, ApiConnectionActionConfiguration> TimeConversionHelper(Expression<Func<TimeConversionHelperInput>> data)
        {
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<TimeConversionHelperResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/helper/convertTime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<TimeConversionHelperResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<CreatePointGeometryHelperResponse, ApiConnectionActionConfiguration> CreatePointGeometryHelper(Expression<Func<double>> x, Expression<Func<double>> y, Expression<Func<string>> srs = null)
        {
            var __workflow_x = WorkflowExpression.Compile(x, nameof(x), required: true);
            var __workflow_y = WorkflowExpression.Compile(y, nameof(y), required: true);
            var __workflow_srs = WorkflowExpression.Compile(srs, nameof(srs), required: false);
            return new DeferredBodyAction<CreatePointGeometryHelperResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/helper/createPointGeometry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x"] = ExpressionConverter.Convert(__workflow_x);
                callPayload.Queries["y"] = ExpressionConverter.Convert(__workflow_y);
                if (__workflow_srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(__workflow_srs);
                return new ApiConnectionAction<CreatePointGeometryHelperResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EXIF(Expression<Func<string>> data)
        {
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/helper/exif";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetPortalItemInformation(Expression<Func<string>> searchTerm, Expression<Func<string>> item)
        {
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/itemDetail/itemInformation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(__workflow_searchTerm);
                callPayload.Queries["item"] = ExpressionConverter.Convert(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetOwnedSurveyList()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/survey123/survey/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isPublished"] = Convert.ToString(true);
                callPayload.Queries["isSearchAll"] = Convert.ToString(true);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<FeatureReportSubmitJobResponse, ApiConnectionActionConfiguration> FeatureReportSubmitJob(Expression<Func<FeatureReportSubmitJobInput>> createFeatureReportBody)
        {
            var __workflow_createFeatureReportBody = WorkflowExpression.Compile(createFeatureReportBody, nameof(createFeatureReportBody), required: true);
            return new DeferredBodyAction<FeatureReportSubmitJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/survey123/featureReport/createReport/submitJob";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createFeatureReportBody);
                return new ApiConnectionAction<FeatureReportSubmitJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FindAddressCandidates(Expression<Func<string>> geocoder, Expression<Func<object>> body, Expression<Func<locationTypeInput>> locationType = null, Expression<Func<string>> srs = null)
        {
            var __workflow_geocoder = WorkflowExpression.Compile(geocoder, nameof(geocoder), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_locationType = WorkflowExpression.Compile(locationType, nameof(locationType), required: false);
            var __workflow_srs = WorkflowExpression.Compile(srs, nameof(srs), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/geocode/findAddressCandidates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocoder"] = ExpressionConverter.Convert(__workflow_geocoder);
                callPayload.Queries["locationType"] = Convert.ToString("Rooftop");
                if (__workflow_locationType != null)
                    callPayload.Queries["locationType"] = ExpressionConverter.Convert(__workflow_locationType);
                if (__workflow_srs != null)
                    callPayload.Queries["srs"] = ExpressionConverter.Convert(__workflow_srs);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GeocodeAddresses(Expression<Func<string>> geocoder, Expression<Func<GeocodeAddressesV2Input>> data)
        {
            var __workflow_geocoder = WorkflowExpression.Compile(geocoder, nameof(geocoder), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/geocode/geocodeAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocoder"] = ExpressionConverter.Convert(__workflow_geocoder);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<GeoenrichV2Response, ApiConnectionActionConfiguration> Geoenrich(Expression<Func<string>> country, Expression<Func<string>> datacollection, Expression<Func<string>> parameter, Expression<Func<bufferTypeInput>> bufferType, Expression<Func<object>> body)
        {
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            var __workflow_datacollection = WorkflowExpression.Compile(datacollection, nameof(datacollection), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            var __workflow_bufferType = WorkflowExpression.Compile(bufferType, nameof(bufferType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GeoenrichV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/geoenrichment/enrich";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                callPayload.Queries["datacollection"] = ExpressionConverter.Convert(__workflow_datacollection);
                callPayload.Queries["parameter"] = ExpressionConverter.Convert(__workflow_parameter);
                callPayload.Queries["bufferType"] = ExpressionConverter.Convert(__workflow_bufferType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GeoenrichV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<GetRouteV2Response, ApiConnectionActionConfiguration> GetRoute(Expression<Func<GetRouteV2Input>> routing, Expression<Func<string>> travelModeName = null, Expression<Func<bool>> findBestSequence = null, Expression<Func<bool>> preserveFirstStop = null, Expression<Func<bool>> returnDirections = null)
        {
            var __workflow_routing = WorkflowExpression.Compile(routing, nameof(routing), required: true);
            var __workflow_travelModeName = WorkflowExpression.Compile(travelModeName, nameof(travelModeName), required: false);
            var __workflow_findBestSequence = WorkflowExpression.Compile(findBestSequence, nameof(findBestSequence), required: false);
            var __workflow_preserveFirstStop = WorkflowExpression.Compile(preserveFirstStop, nameof(preserveFirstStop), required: false);
            var __workflow_returnDirections = WorkflowExpression.Compile(returnDirections, nameof(returnDirections), required: false);
            return new DeferredBodyAction<GetRouteV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/routing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_travelModeName != null)
                    callPayload.Queries["travelModeName"] = ExpressionConverter.Convert(__workflow_travelModeName);
                if (__workflow_findBestSequence != null)
                    callPayload.Queries["findBestSequence"] = ExpressionConverter.Convert(__workflow_findBestSequence);
                if (__workflow_preserveFirstStop != null)
                    callPayload.Queries["preserveFirstStop"] = ExpressionConverter.Convert(__workflow_preserveFirstStop);
                callPayload.Queries["returnDirections"] = Convert.ToString(true);
                if (__workflow_returnDirections != null)
                    callPayload.Queries["returnDirections"] = ExpressionConverter.Convert(__workflow_returnDirections);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_routing);
                return new ApiConnectionAction<GetRouteV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> WebhookGetAsync(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<string>> changesUrl, Expression<Func<object>> data)
        {
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            var __workflow_changesUrl = WorkflowExpression.Compile(changesUrl, nameof(changesUrl), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/webhook/fetchLayerChangesAsync";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Queries["changesUrl"] = ExpressionConverter.Convert(__workflow_changesUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ArcgisTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> AddData(Expression<Func<string>> surveyId, Expression<Func<AddDataInput>> addWebhookBody, FlowRecurrence recurrence = null)
        {
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            var __workflow_addWebhookBody = WorkflowExpression.Compile(addWebhookBody, nameof(addWebhookBody), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/survey123/survey/{0}/webhook/add", __workflow_surveyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addWebhookBody);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookAttachmentCreatedV2Response, ApiConnectionTriggerConfiguration> WebhookAttachmentCreated(Expression<Func<WebhookAttachmentCreatedV2Input>> body, Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            return new DeferredBodyTrigger<WebhookAttachmentCreatedV2Response, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/webhook/createWebhook/attachmentsCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookAttachmentCreatedV2Response>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookAttachmentDeletedV2Response, ApiConnectionTriggerConfiguration> WebhookAttachmentDeleted(Expression<Func<WebhookAttachmentDeletedV2Input>> body, Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            return new DeferredBodyTrigger<WebhookAttachmentDeletedV2Response, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/webhook/createWebhook/attachmentsDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookAttachmentDeletedV2Response>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookAttachmentUpdatedV2Response, ApiConnectionTriggerConfiguration> WebhookAttachmentUpdated(Expression<Func<WebhookAttachmentUpdatedV2Input>> body, Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            return new DeferredBodyTrigger<WebhookAttachmentUpdatedV2Response, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/webhook/createWebhook/attachmentsUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookAttachmentUpdatedV2Response>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookFLCreatedV2Response, ApiConnectionTriggerConfiguration> WebhookFLCreated(Expression<Func<WebhookFLCreatedV2Input>> body, Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            return new DeferredBodyTrigger<WebhookFLCreatedV2Response, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/webhook/createWebhook/featuresCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookFLCreatedV2Response>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookFLDeletedV2Response, ApiConnectionTriggerConfiguration> WebhookFLDeleted(Expression<Func<WebhookFLDeletedV2Input>> body, Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            return new DeferredBodyTrigger<WebhookFLDeletedV2Response, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/webhook/createWebhook/featuresDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookFLDeletedV2Response>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookFLEditedV2Response, ApiConnectionTriggerConfiguration> WebhookFLEdited(Expression<Func<WebhookFLEditedV2Input>> body, Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: true);
            var __workflow_userLayer = WorkflowExpression.Compile(userLayer, nameof(userLayer), required: true);
            return new DeferredBodyTrigger<WebhookFLEditedV2Response, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/webhook/createWebhook/featuresUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                callPayload.Queries["userLayer"] = ExpressionConverter.Convert(__workflow_userLayer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookFLEditedV2Response>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AddAttachmentResponse
    {
        [JsonProperty("objectId")]
        public double ObjectId { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class UpdateAttachmentResponse
    {
        [JsonProperty("objectId")]
        public double ObjectId { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class QueryAttachmentResponseItem
    {
        [JsonProperty("id")]
        public double AttachmentObjectId { get; set; }

        [JsonProperty("globalId")]
        public string AttachmentGlobalId { get; set; }

        [JsonProperty("name")]
        public string AttachmentName { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("size")]
        public double AttachmentSize { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        [JsonProperty("url")]
        public string AttachmentURL { get; set; }
    }

    public class DeleteAttachmentsResponseItem
    {
        [JsonProperty("objectId")]
        public double ObjectId { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class RunResult
    {
        [JsonProperty("appUrl")]
        public string AppUrl { get; set; }

        [JsonProperty("runId")]
        public string RunId { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class RunDataPipelineInput
    {
        [JsonProperty("dataPipelineItem", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataPipeline { get; set; }

        [JsonProperty("timeoutInMinutes", DefaultValueHandling = DefaultValueHandling.Include)]
        public double MaximumRunDurationMinutes { get; set; } = 30;
    }

    public class BatchAddFeatures
    {
        [JsonProperty("errorCount")]
        public double ErrorCount { get; set; }

        [JsonProperty("successCount")]
        public double SuccessesCount { get; set; }

        [JsonProperty("result")]
        public BatchAddFeaturesResultType Result { get; set; }
    }

    public class BatchAddFeaturesResultType
    {
        [JsonProperty("success")]
        public BatchAddFeaturesResultTypeSuccessTypeItem[] Success { get; set; }

        [JsonProperty("error")]
        public BatchAddFeaturesResultTypeErrorTypeItem[] Error { get; set; }
    }

    public class BatchAddFeaturesResultTypeSuccessTypeItem
    {
        [JsonProperty("objectId")]
        public double ObjectId { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }
    }

    public class BatchAddFeaturesResultTypeErrorTypeItem
    {
        [JsonProperty("objectId")]
        public double ObjectId { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }
    }

    public class CreateItemInFeatureLayerDomainsResponse
    {
        [JsonProperty("success")]
        public bool CreateOperationSuccessStatus { get; set; }

        [JsonProperty("objectId")]
        public double ObjectId { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }
    }

    public class UpdateItemInFeatureLayerDomainsResponse
    {
        [JsonProperty("success")]
        public bool UpdateOperationSuccessStatus { get; set; }

        [JsonProperty("objectId")]
        public double ObjectId { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }
    }

    public class BatchUpdateFeatures
    {
        [JsonProperty("errorCount")]
        public double ErrorCount { get; set; }

        [JsonProperty("successCount")]
        public double SuccessesCount { get; set; }

        [JsonProperty("result")]
        public BatchUpdateFeaturesResultType Result { get; set; }
    }

    public class BatchUpdateFeaturesResultType
    {
        [JsonProperty("success")]
        public BatchUpdateFeaturesResultTypeSuccessTypeItem[] Success { get; set; }

        [JsonProperty("error")]
        public BatchUpdateFeaturesResultTypeErrorTypeItem[] Error { get; set; }
    }

    public class BatchUpdateFeaturesResultTypeSuccessTypeItem
    {
        [JsonProperty("objectId")]
        public double ObjectId { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }
    }

    public class BatchUpdateFeaturesResultTypeErrorTypeItem
    {
        [JsonProperty("objectId")]
        public double ObjectId { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }
    }

    public class DeleteItemInFeatureLayerResponseItem
    {
        [JsonProperty("success")]
        public bool DeleteStatus { get; set; }

        [JsonProperty("objectId")]
        public double ObjectId { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }
    }

    public class DeleteItemInFeatureLayerInput
    {
        [JsonProperty("deletedIds")]
        public string DeleteRecords { get; set; }
    }

    public class ReverseGeocodeResponse
    {
        [JsonProperty("address")]
        public ReverseGeocodeResponseAddressType Address { get; set; }

        [JsonProperty("location")]
        public ReverseGeocodeResponseLocationType Location { get; set; }
    }

    public class ReverseGeocodeResponseAddressType
    {
        [JsonProperty("Address")]
        public string ShortAddress { get; set; }

        [JsonProperty("LongLabel")]
        public string FullAddress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        [JsonProperty("CntryName")]
        public string Country { get; set; }

        [JsonProperty("Postal")]
        public string ZIPOrPostalCode { get; set; }
    }

    public class ReverseGeocodeResponseLocationType
    {
        [JsonProperty("x")]
        public double LongitudeX { get; set; }

        [JsonProperty("y")]
        public double LatitudeY { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum locationTypeInput
    {
        Rooftop,
        Street
    }

    public class TimeConversionHelperResponse
    {
        [JsonProperty("stringTime")]
        public string DateTime { get; set; }

        [JsonProperty("unixTimeStampSeconds")]
        public double UnixTimeStampInSeconds { get; set; }

        [JsonProperty("unixTimeStampMilliseconds")]
        public double UnixTimeStampInMilliseconds { get; set; }
    }

    public class TimeConversionHelperInput
    {
        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTime { get; set; }
    }

    public class CreatePointGeometryHelperResponse
    {
        [JsonProperty("geometry")]
        public JToken Geometry { get; set; }
    }

    public class FeatureReportSubmitJobResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("jobStatus")]
        public string JobStatus { get; set; }

        [JsonProperty("submitted")]
        public int Submitted { get; set; }

        [JsonProperty("completed")]
        public int Completed { get; set; }

        [JsonProperty("resultInfo")]
        public FeatureReportSubmitJobResponseResultInfoType ResultInfo { get; set; }

        [JsonProperty("inputInfo")]
        public FeatureReportSubmitJobResponseInputInfoType InputInfo { get; set; }
    }

    public class FeatureReportSubmitJobResponseResultInfoType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("succeededObjectIds")]
        public int[] SucceededObjectIds { get; set; }

        [JsonProperty("failedObjectIds")]
        public JToken[] FailedObjectIds { get; set; }

        [JsonProperty("details")]
        public JToken[] Details { get; set; }

        [JsonProperty("resultFiles")]
        public FeatureReportSubmitJobResponseResultInfoTypeResultFilesTypeItem[] ResultFiles { get; set; }

        [JsonProperty("resultFile")]
        public FeatureReportSubmitJobResponseResultInfoTypeResultFileType ResultFile { get; set; }
    }

    public class FeatureReportSubmitJobResponseResultInfoTypeResultFilesTypeItem
    {
        [JsonProperty("objectIds")]
        public int[] ObjectIds { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FeatureReportSubmitJobResponseResultInfoTypeResultFileType
    {
        [JsonProperty("objectIds")]
        public int[] ObjectIds { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FeatureReportSubmitJobResponseInputInfoType
    {
        [JsonProperty("jobType")]
        public string JobType { get; set; }

        [JsonProperty("parameters")]
        public FeatureReportSubmitJobResponseInputInfoTypeParametersType Parameters { get; set; }
    }

    public class FeatureReportSubmitJobResponseInputInfoTypeParametersType
    {
        [JsonProperty("featureLayerUrl")]
        public string FeatureLayerUrl { get; set; }

        [JsonProperty("queryParameters")]
        public FeatureReportSubmitJobResponseInputInfoTypeParametersTypeQueryParametersType QueryParameters { get; set; }

        [JsonProperty("templateItemId")]
        public string TemplateItemId { get; set; }

        [JsonProperty("surveyItemId")]
        public string SurveyItemId { get; set; }

        [JsonProperty("portalUrl")]
        public string PortalUrl { get; set; }

        [JsonProperty("outputFormat")]
        public string OutputFormat { get; set; }
    }

    public class FeatureReportSubmitJobResponseInputInfoTypeParametersTypeQueryParametersType
    {
        [JsonProperty("objectIds")]
        public string ObjectIds { get; set; }
    }

    public class FeatureReportSubmitJobInput
    {
        [JsonProperty("surveyItemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Survey { get; set; }

        [JsonProperty("featureLayerUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeatureLayer { get; set; }

        [JsonProperty("templateItemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReportTemplate { get; set; }

        [JsonProperty("queryParameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public FeatureReportSubmitJobInputValueType Value { get; set; }

        [JsonProperty("utcOffset")]
        public string UTCOffset { get; set; }

        [JsonProperty("outputFileName")]
        public string ReportName { get; set; }

        [JsonProperty("outputFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public FeatureReportSubmitJobInputFormatType? Format { get; set; } = FeatureReportSubmitJobInputFormatType.Docx;

        [JsonProperty("asyncPattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool EnableAsyncPattern { get; set; } = true;
    }

    public class FeatureReportSubmitJobInputValueType
    {
        [JsonProperty("objectIds")]
        public string FeatureObjectId { get; set; }

        [JsonProperty("where")]
        public string FeatureWHEREClause { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FeatureReportSubmitJobInputFormatType
    {
        [EnumMember(Value = "docx")]
        Docx,
        [EnumMember(Value = "pdf")]
        Pdf
    }

    public class GeocodeAddressesV2Input
    {
        [JsonProperty("addresses", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Addresses { get; set; }
    }

    public class GeoenrichV2Response
    {
        [JsonProperty("value")]
        public double ParameterValue { get; set; }

        [JsonProperty("parameterName")]
        public string ParameterName { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bufferTypeInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "ringbuffer")]
        RingBuffer,
        [EnumMember(Value = "networkservicearea")]
        NetworkServiceArea
    }

    public class GetRouteV2Response
    {
        public GetRouteV2ResponseDirectionsTypeItem[] Directions { get; set; }
        public string Name { get; set; }

        [JsonProperty("Kilometers")]
        public double DistanceInKilometers { get; set; }

        [JsonProperty("Miles")]
        public double DistanceInMiles { get; set; }
        public double TravelTime { get; set; }

        [JsonProperty("Geometry")]
        public JToken RouteGeometry { get; set; }
    }

    public class GetRouteV2ResponseDirectionsTypeItem
    {
        [JsonProperty("text")]
        public string DirectionText { get; set; }
    }

    public class GetRouteV2Input
    {
        [JsonProperty("stops", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RoutingStops { get; set; }
    }

    public class AddDataInput
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddDataInputValueType Value { get; set; } = new AddDataInputValueType();
    }

    public class AddDataInputValueType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "MS-FLOW";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] Events { get; set; } = new string[]
        {
            "addData"
        };

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("includePortalInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludePortalInfo { get; set; } = true;

        [JsonProperty("includeUserInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeUserInfo { get; set; } = true;

        [JsonProperty("includeSurveyInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeSurveyInfo { get; set; } = true;

        [JsonProperty("includeServiceRequest", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeServiceRequest { get; set; } = true;

        [JsonProperty("includeServiceResponse", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeServiceResponse { get; set; } = true;
    }

    public class WebhookAttachmentCreatedV2Response
    {
        [JsonProperty("id")]
        public double WebhookId { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookAttachmentCreatedV2Input
    {
        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookAttachmentCreatedV2InputConfigType Config { get; set; } = new WebhookAttachmentCreatedV2InputConfigType();
    }

    public class WebhookAttachmentCreatedV2InputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookAttachmentDeletedV2Response
    {
        [JsonProperty("id")]
        public double WebhookId { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookAttachmentDeletedV2Input
    {
        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookAttachmentDeletedV2InputConfigType Config { get; set; } = new WebhookAttachmentDeletedV2InputConfigType();
    }

    public class WebhookAttachmentDeletedV2InputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookAttachmentUpdatedV2Response
    {
        [JsonProperty("id")]
        public double WebhookId { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookAttachmentUpdatedV2Input
    {
        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookAttachmentUpdatedV2InputConfigType Config { get; set; } = new WebhookAttachmentUpdatedV2InputConfigType();
    }

    public class WebhookAttachmentUpdatedV2InputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookFLCreatedV2Response
    {
        [JsonProperty("id")]
        public double WebhookId { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookFLCreatedV2Input
    {
        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookFLCreatedV2InputConfigType Config { get; set; } = new WebhookFLCreatedV2InputConfigType();
    }

    public class WebhookFLCreatedV2InputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookFLDeletedV2Response
    {
        [JsonProperty("id")]
        public double WebhookId { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookFLDeletedV2Input
    {
        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookFLDeletedV2InputConfigType Config { get; set; } = new WebhookFLDeletedV2InputConfigType();
    }

    public class WebhookFLDeletedV2InputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookFLEditedV2Response
    {
        [JsonProperty("id")]
        public double WebhookId { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookFLEditedV2Input
    {
        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookFLEditedV2InputConfigType Config { get; set; } = new WebhookFLEditedV2InputConfigType();
    }

    public class WebhookFLEditedV2InputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Arcgis;

    public partial class WorkflowManagedActions
    {
        public ArcgisActions Arcgis(string connectionId) => new ArcgisActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ArcgisTriggers Arcgis(string connectionId) => new ArcgisTriggers(connectionId);
    }
}