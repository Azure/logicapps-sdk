//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Arcgis
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ArcgisActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<AddAttachmentResponse> AddAttachment(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<double>> objectId, Expression<Func<string>> attachmentName, Expression<Func<string>> data = null, Expression<Func<string>> keywords = null)
        {
            var apiCallPath = "/v1/attachment/addAttachment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(contentFilter);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            callPayload.Queries["attachmentName"] = ExpressionConverter.Convert(attachmentName);
            if (keywords != null)
                callPayload.Queries["keywords"] = ExpressionConverter.Convert(keywords);
            callPayload.Body = ExpressionConverter.ConvertO(data);
            return new ApiConnectionAction<AddAttachmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<UpdateAttachmentResponse> UpdateAttachment(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<double>> objectid, Expression<Func<double>> attachmentId, Expression<Func<string>> attachmentName, Expression<Func<string>> data = null)
        {
            var apiCallPath = "/v1/attachment/updateAttachment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(contentFilter);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Queries["objectid"] = ExpressionConverter.Convert(objectid);
            callPayload.Queries["attachmentId"] = ExpressionConverter.Convert(attachmentId);
            callPayload.Queries["attachmentName"] = ExpressionConverter.Convert(attachmentName);
            callPayload.Body = ExpressionConverter.ConvertO(data);
            return new ApiConnectionAction<UpdateAttachmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<QueryAttachmentResponseItem[]> QueryAttachment(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<double>> objectId, Expression<Func<string>> keywords = null)
        {
            var apiCallPath = "/v1/attachment/queryAttachments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(contentFilter);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            if (keywords != null)
                callPayload.Queries["keywords"] = ExpressionConverter.Convert(keywords);
            return new ApiConnectionAction<QueryAttachmentResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<string> GetAttachment(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<double>> objectid, Expression<Func<double>> attachmentId)
        {
            var apiCallPath = "/v1/attachment/getAttachment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(contentFilter);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Queries["objectid"] = ExpressionConverter.Convert(objectid);
            callPayload.Queries["attachmentId"] = ExpressionConverter.Convert(attachmentId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<string> GetAttachmentFromUrl(Expression<Func<string>> attachmentUrl)
        {
            var apiCallPath = "/v1/attachment/getAttachment";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["attachmentUrl"] = ExpressionConverter.Convert(attachmentUrl);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<DeleteAttachmentsResponseItem[]> DeleteAttachments(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<double>> objectid, Expression<Func<string>> attachmentIds)
        {
            var apiCallPath = "/v2/attachment/deleteAttachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(contentFilter);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Queries["objectid"] = ExpressionConverter.Convert(objectid);
            callPayload.Queries["attachmentIds"] = ExpressionConverter.Convert(attachmentIds);
            return new ApiConnectionAction<DeleteAttachmentsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<RunResult> RunDataPipeline(Expression<Func<string>> dataPipelineFilter, Expression<Func<string>> submitRunBodydataPipeline, Expression<Func<double>> submitRunBodymaximumRunDurationMinutes)
        {
            var apiCallPath = "/v1/dataPipelines/runs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["dataPipelineFilter"] = ExpressionConverter.Convert(dataPipelineFilter);
            var submitRunBody = new JObject();
            var submitRunBodypropCount = 0;
            submitRunBodypropCount++;
            submitRunBody["dataPipelineItem"] = ExpressionConverter.ConvertO(submitRunBodydataPipeline);
            submitRunBodypropCount++;
            submitRunBody["timeoutInMinutes"] = ExpressionConverter.ConvertO(submitRunBodymaximumRunDurationMinutes);
            if (submitRunBodypropCount > 0)
            {
                callPayload.Body = submitRunBody;
            }

            return new ApiConnectionAction<RunResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<BatchAddUpdateFeatures> AddFeaturesBatch(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/v1/featureLayer/addFeatures";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(contentFilter);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BatchAddUpdateFeatures>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<CreateItemInFeatureLayerDomainsResponse> CreateItemInFeatureLayerDomains(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<object>> data = null)
        {
            var apiCallPath = "/v2/featureLayer/createFeature";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(contentFilter);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Body = ExpressionConverter.ConvertO(data);
            return new ApiConnectionAction<CreateItemInFeatureLayerDomainsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<UpdateItemInFeatureLayerDomainsResponse> UpdateItemInFeatureLayerDomains(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<string>> idField, Expression<Func<object>> data = null)
        {
            var apiCallPath = "/v2/featureLayer/updateFeature";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(contentFilter);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Queries["idField"] = ExpressionConverter.Convert(idField);
            callPayload.Body = ExpressionConverter.ConvertO(data);
            return new ApiConnectionAction<UpdateItemInFeatureLayerDomainsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<BatchAddUpdateFeatures> UpdateFeaturesBatch(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<string>> idField, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/v1/featureLayer/updateFeatures";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(contentFilter);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Queries["idField"] = ExpressionConverter.Convert(idField);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BatchAddUpdateFeatures>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<DeleteItemInFeatureLayerResponseItem[]> DeleteItemInFeatureLayer(Expression<Func<string>> contentFilter, Expression<Func<string>> userLayer, Expression<Func<string>> idField, Expression<Func<string>> datadeleteRecords = null)
        {
            var apiCallPath = "/v1/featureLayer/deleteFeature";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentFilter"] = ExpressionConverter.Convert(contentFilter);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Queries["idField"] = ExpressionConverter.Convert(idField);
            var data = new JObject();
            var datapropCount = 0;
            if (datadeleteRecords != null)
            {
                data["deletedIds"] = ExpressionConverter.ConvertO(datadeleteRecords);
                datapropCount++;
            }

            if (datapropCount > 0)
            {
                callPayload.Body = data;
            }

            return new ApiConnectionAction<DeleteItemInFeatureLayerResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken> GetCodedDomains(Expression<Func<string>> userLayer)
        {
            var apiCallPath = "/v1/featureLayer/codedDomain";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken> GeocodeAddressesV2(Expression<Func<string>> geocoder, Expression<Func<string>> dataaddresses)
        {
            var apiCallPath = "/v2/geocode/geocodeAddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["geocoder"] = ExpressionConverter.Convert(geocoder);
            var data = new JObject();
            var datapropCount = 0;
            datapropCount++;
            data["addresses"] = ExpressionConverter.ConvertO(dataaddresses);
            if (datapropCount > 0)
            {
                callPayload.Body = data;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken> FindAddressCandidatesV2(Expression<Func<string>> geocoder, Expression<Func<object>> body = null, Expression<Func<locationTypeInput>> locationType = null, Expression<Func<string>> srs = null)
        {
            var apiCallPath = "/v2/geocode/findAddressCandidates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["geocoder"] = ExpressionConverter.Convert(geocoder);
            callPayload.Queries["locationType"] = Convert.ToString("Rooftop");
            if (locationType != null)
                callPayload.Queries["locationType"] = ExpressionConverter.Convert(locationType);
            if (srs != null)
                callPayload.Queries["srs"] = ExpressionConverter.Convert(srs);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<ReverseGeocodeResponse> ReverseGeocode(Expression<Func<string>> geocoder, Expression<Func<double>> x, Expression<Func<double>> y, Expression<Func<string>> srs = null, Expression<Func<locationTypeInput>> locationType = null)
        {
            var apiCallPath = "/v1/geocode/reverseGeocode";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["geocoder"] = ExpressionConverter.Convert(geocoder);
            callPayload.Queries["x"] = ExpressionConverter.Convert(x);
            callPayload.Queries["y"] = ExpressionConverter.Convert(y);
            if (srs != null)
                callPayload.Queries["srs"] = ExpressionConverter.Convert(srs);
            callPayload.Queries["locationType"] = Convert.ToString("Rooftop");
            if (locationType != null)
                callPayload.Queries["locationType"] = ExpressionConverter.Convert(locationType);
            return new ApiConnectionAction<ReverseGeocodeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<GeoenrichV2Response> GeoenrichV2(Expression<Func<string>> country, Expression<Func<string>> datacollection, Expression<Func<string>> parameter, Expression<Func<buffertypeInput>> buffertype, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/v2/geoenrichment/enrich";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            callPayload.Queries["datacollection"] = ExpressionConverter.Convert(datacollection);
            callPayload.Queries["parameter"] = ExpressionConverter.Convert(parameter);
            callPayload.Queries["buffertype"] = ExpressionConverter.Convert(buffertype);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<GeoenrichV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken> GeometryService(Expression<Func<string>> operation, Expression<Func<object>> data = null)
        {
            var apiCallPath = "/v1/geometry/process";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["operation"] = ExpressionConverter.Convert(operation);
            callPayload.Body = ExpressionConverter.ConvertO(data);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<TimeConversionHelperResponse> TimeConversionHelper(Expression<Func<string>> datadateTime)
        {
            var apiCallPath = "/v1/helper/convertTime";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var data = new JObject();
            var datapropCount = 0;
            datapropCount++;
            data["dateTime"] = ExpressionConverter.ConvertO(datadateTime);
            if (datapropCount > 0)
            {
                callPayload.Body = data;
            }

            return new ApiConnectionAction<TimeConversionHelperResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<CreatePointGeometryHelperResponse> CreatePointGeometryHelper(Expression<Func<double>> x, Expression<Func<double>> y, Expression<Func<string>> srs = null)
        {
            var apiCallPath = "/v1/helper/createPointGeometry";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x"] = ExpressionConverter.Convert(x);
            callPayload.Queries["y"] = ExpressionConverter.Convert(y);
            if (srs != null)
                callPayload.Queries["srs"] = ExpressionConverter.Convert(srs);
            return new ApiConnectionAction<CreatePointGeometryHelperResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken> EXIF(Expression<Func<string>> data = null)
        {
            var apiCallPath = "/v1/helper/exif";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(data);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken> GetPortalItemInformation(Expression<Func<string>> searchTerm, Expression<Func<string>> item)
        {
            var apiCallPath = "/v1/itemDetail/itemInformation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(searchTerm);
            callPayload.Queries["item"] = ExpressionConverter.Convert(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<GetRouteV2Response> GetRouteV2(Expression<Func<string>> routingroutingStops, Expression<Func<string>> travelModeName = null, Expression<Func<bool>> findBestSequence = null, Expression<Func<bool>> preserveFirstStop = null, Expression<Func<bool>> returnDirections = null)
        {
            var apiCallPath = "/v2/routing";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (travelModeName != null)
                callPayload.Queries["travelModeName"] = ExpressionConverter.Convert(travelModeName);
            if (findBestSequence != null)
                callPayload.Queries["findBestSequence"] = ExpressionConverter.Convert(findBestSequence);
            if (preserveFirstStop != null)
                callPayload.Queries["preserveFirstStop"] = ExpressionConverter.Convert(preserveFirstStop);
            callPayload.Queries["returnDirections"] = Convert.ToString(true);
            if (returnDirections != null)
                callPayload.Queries["returnDirections"] = ExpressionConverter.Convert(returnDirections);
            var routing = new JObject();
            var routingpropCount = 0;
            routingpropCount++;
            routing["stops"] = ExpressionConverter.ConvertO(routingroutingStops);
            if (routingpropCount > 0)
            {
                callPayload.Body = routing;
            }

            return new ApiConnectionAction<GetRouteV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IWorkflowAction GetOwnedSurveyList()
        {
            var apiCallPath = "/v1/survey123/survey/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["isPublished"] = Convert.ToString(true);
            callPayload.Queries["isSearchAll"] = Convert.ToString(true);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgis")]
        public IBodyWorkflowAction<JToken> WebhookGetAsync(Expression<Func<string>> changesUrl, Expression<Func<string>> userLayer, Expression<Func<double>> layerId, Expression<Func<object>> data = null)
        {
            var apiCallPath = "/v1/webhook/fetchLayerChangesAsync";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["changesUrl"] = ExpressionConverter.Convert(changesUrl);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            callPayload.Queries["layerId"] = ExpressionConverter.Convert(layerId);
            callPayload.Body = ExpressionConverter.ConvertO(data);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class ArcgisTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookFLCreatedResponse> WebhookFLCreated(Expression<Func<string>> userLayer, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/createWebhook/featuresCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            var body = new JObject();
            var bodypropCount = 0;
            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookFLCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookFLDeletedResponse> WebhookFLDeleted(Expression<Func<string>> userLayer, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/createWebhook/featuresDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            var body = new JObject();
            var bodypropCount = 0;
            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookFLDeletedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookFLEditedResponse> WebhookFLEdited(Expression<Func<string>> userLayer, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/createWebhook/featuresUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            var body = new JObject();
            var bodypropCount = 0;
            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookFLEditedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookAttachmentCreatedResponse> WebhookAttachmentCreated(Expression<Func<string>> userLayer, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/createWebhook/attachmentsCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            var body = new JObject();
            var bodypropCount = 0;
            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookAttachmentCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookAttachmentUpdatedResponse> WebhookAttachmentUpdated(Expression<Func<string>> userLayer, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/createWebhook/attachmentsUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            var body = new JObject();
            var bodypropCount = 0;
            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookAttachmentUpdatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookAttachmentDeletedResponse> WebhookAttachmentDeleted(Expression<Func<string>> userLayer, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/createWebhook/attachmentsDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userLayer"] = ExpressionConverter.Convert(userLayer);
            var body = new JObject();
            var bodypropCount = 0;
            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookAttachmentDeletedResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class AddAttachmentResponse
    {
        [JsonProperty("objectId")]
        public double ObjectID { get; set; }

        [JsonProperty("globalId")]
        public string GlobalID { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class UpdateAttachmentResponse
    {
        [JsonProperty("objectId")]
        public double ObjectID { get; set; }

        [JsonProperty("globalId")]
        public string GlobalID { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class QueryAttachmentResponseItem
    {
        [JsonProperty("id")]
        public double AttachmentObjectID { get; set; }

        [JsonProperty("globalId")]
        public string AttachmentGlobalID { get; set; }

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
        public double ObjectID { get; set; }

        [JsonProperty("globalId")]
        public string GlobalID { get; set; }

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

    public class BatchAddUpdateFeatures
    {
        [JsonProperty("errorCount")]
        public double ErrorCount { get; set; }

        [JsonProperty("successCount")]
        public double SuccessesCount { get; set; }

        [JsonProperty("result")]
        public BatchAddUpdateFeaturesResultType Result { get; set; }
    }

    public class BatchAddUpdateFeaturesResultType
    {
        [JsonProperty("success")]
        public BatchAddUpdateFeaturesResultTypeSuccessTypeItem[] Success { get; set; }

        [JsonProperty("error")]
        public BatchAddUpdateFeaturesResultTypeErrorTypeItem[] Error { get; set; }
    }

    public class BatchAddUpdateFeaturesResultTypeSuccessTypeItem
    {
        [JsonProperty("objectId")]
        public double ObjectID { get; set; }

        [JsonProperty("globalId")]
        public string GlobalID { get; set; }
    }

    public class BatchAddUpdateFeaturesResultTypeErrorTypeItem
    {
        [JsonProperty("objectId")]
        public double ObjectID { get; set; }

        [JsonProperty("globalId")]
        public string GlobalID { get; set; }
    }

    public class CreateItemInFeatureLayerDomainsResponse
    {
        [JsonProperty("success")]
        public bool CreateOperationSuccessStatus { get; set; }

        [JsonProperty("objectId")]
        public double ObjectID { get; set; }

        [JsonProperty("globalId")]
        public string GlobalID { get; set; }
    }

    public class UpdateItemInFeatureLayerDomainsResponse
    {
        [JsonProperty("success")]
        public bool UpdateOperationSuccessStatus { get; set; }

        [JsonProperty("objectId")]
        public double ObjectID { get; set; }

        [JsonProperty("globalId")]
        public string GlobalID { get; set; }
    }

    public class DeleteItemInFeatureLayerResponseItem
    {
        [JsonProperty("success")]
        public bool DeleteStatus { get; set; }

        [JsonProperty("objectId")]
        public double ObjectID { get; set; }

        [JsonProperty("globalId")]
        public string GlobalID { get; set; }
    }

    public enum locationTypeInput
    {
        Rooftop,
        Street
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

    public class GeoenrichV2Response
    {
        [JsonProperty("value")]
        public double ParameterValue { get; set; }

        [JsonProperty("parameterName")]
        public string ParameterName { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public enum buffertypeInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "ringbuffer")]
        RingBuffer,
        [EnumMember(Value = "networkservicearea")]
        NetworkServiceArea
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

    public class CreatePointGeometryHelperResponse
    {
        [JsonProperty("geometry")]
        public JToken Geometry { get; set; }
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

    public class WebhookFLCreatedResponse
    {
        [JsonProperty("id")]
        public double WebhookID { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookFLDeletedResponse
    {
        [JsonProperty("id")]
        public double WebhookID { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookFLEditedResponse
    {
        [JsonProperty("id")]
        public double WebhookID { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookAttachmentCreatedResponse
    {
        [JsonProperty("id")]
        public double WebhookID { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookAttachmentUpdatedResponse
    {
        [JsonProperty("id")]
        public double WebhookID { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookAttachmentDeletedResponse
    {
        [JsonProperty("id")]
        public double WebhookID { get; set; }

        [JsonProperty("url")]
        public string TriggerURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
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