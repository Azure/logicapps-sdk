//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apitemplateip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApitemplateipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        [WorkflowExpressionFactory(nameof(__BuildPDF))]
        public IBodyWorkflowAction<ResponseSuccessPDFFile> PDF([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> exportType = null, [WorkflowExpression] Func<int> expiration = null, [WorkflowExpression] Func<string> outputHtml = null, [WorkflowExpression] Func<string> outputFormat = null, [WorkflowExpression] Func<string> filename = null, [WorkflowExpression] Func<string> imageResampleRes = null, [WorkflowExpression] Func<string> isCmyk = null, [WorkflowExpression] Func<int> cloudStorage = null, [WorkflowExpression] Func<string> meta = null, [WorkflowExpression] Func<string> async = null, [WorkflowExpression] Func<string> webhookUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessPDFFile> __BuildPDF(WorkflowValue<string> templateId, WorkflowValue<string> exportType = null, WorkflowValue<int> expiration = null, WorkflowValue<string> outputHtml = null, WorkflowValue<string> outputFormat = null, WorkflowValue<string> filename = null, WorkflowValue<string> imageResampleRes = null, WorkflowValue<string> isCmyk = null, WorkflowValue<int> cloudStorage = null, WorkflowValue<string> meta = null, WorkflowValue<string> async = null, WorkflowValue<string> webhookUrl = null)
        {
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(exportType, nameof(exportType), required: false);
            WorkflowValue.Validate(expiration, nameof(expiration), required: false);
            WorkflowValue.Validate(outputHtml, nameof(outputHtml), required: false);
            WorkflowValue.Validate(outputFormat, nameof(outputFormat), required: false);
            WorkflowValue.Validate(filename, nameof(filename), required: false);
            WorkflowValue.Validate(imageResampleRes, nameof(imageResampleRes), required: false);
            WorkflowValue.Validate(isCmyk, nameof(isCmyk), required: false);
            WorkflowValue.Validate(cloudStorage, nameof(cloudStorage), required: false);
            WorkflowValue.Validate(meta, nameof(meta), required: false);
            WorkflowValue.Validate(async, nameof(async), required: false);
            WorkflowValue.Validate(webhookUrl, nameof(webhookUrl), required: false);
            return new DeferredBodyAction<ResponseSuccessPDFFile>(() =>
            {
                var apiCallPath = "/v2/create-pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                if (exportType != null)
                    callPayload.Queries["export_type"] = ExpressionConverter.Convert(exportType);
                if (expiration != null)
                    callPayload.Queries["expiration"] = ExpressionConverter.Convert(expiration);
                if (outputHtml != null)
                    callPayload.Queries["output_html"] = ExpressionConverter.Convert(outputHtml);
                if (outputFormat != null)
                    callPayload.Queries["output_format"] = ExpressionConverter.Convert(outputFormat);
                if (filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
                if (imageResampleRes != null)
                    callPayload.Queries["image_resample_res"] = ExpressionConverter.Convert(imageResampleRes);
                if (isCmyk != null)
                    callPayload.Queries["is_cmyk"] = ExpressionConverter.Convert(isCmyk);
                if (cloudStorage != null)
                    callPayload.Queries["cloud_storage"] = ExpressionConverter.Convert(cloudStorage);
                if (meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(meta);
                if (async != null)
                    callPayload.Queries["async"] = ExpressionConverter.Convert(async);
                if (webhookUrl != null)
                    callPayload.Queries["webhook_url"] = ExpressionConverter.Convert(webhookUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResponseSuccessPDFFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        [WorkflowExpressionFactory(nameof(__BuildImage))]
        public IBodyWorkflowAction<ResponseSuccessImageFile> Image([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<int> expiration = null, [WorkflowExpression] Func<int> cloudStorage = null, [WorkflowExpression] Func<string> outputImageType = null, [WorkflowExpression] Func<string> meta = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessImageFile> __BuildImage(WorkflowValue<string> templateId, WorkflowValue<int> expiration = null, WorkflowValue<int> cloudStorage = null, WorkflowValue<string> outputImageType = null, WorkflowValue<string> meta = null)
        {
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(expiration, nameof(expiration), required: false);
            WorkflowValue.Validate(cloudStorage, nameof(cloudStorage), required: false);
            WorkflowValue.Validate(outputImageType, nameof(outputImageType), required: false);
            WorkflowValue.Validate(meta, nameof(meta), required: false);
            return new DeferredBodyAction<ResponseSuccessImageFile>(() =>
            {
                var apiCallPath = "/v2/create-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                if (expiration != null)
                    callPayload.Queries["expiration"] = ExpressionConverter.Convert(expiration);
                if (cloudStorage != null)
                    callPayload.Queries["cloud_storage"] = ExpressionConverter.Convert(cloudStorage);
                if (outputImageType != null)
                    callPayload.Queries["output_image_type"] = ExpressionConverter.Convert(outputImageType);
                if (meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(meta);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResponseSuccessImageFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        [WorkflowExpressionFactory(nameof(__BuildObjectsGet))]
        public IBodyWorkflowAction<ResponseSuccessListObjects> ObjectsGet([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> offset = null, [WorkflowExpression] Func<string> templateId = null, [WorkflowExpression] Func<string> transactionType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessListObjects> __BuildObjectsGet(WorkflowValue<string> limit = null, WorkflowValue<string> offset = null, WorkflowValue<string> templateId = null, WorkflowValue<string> transactionType = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(templateId, nameof(templateId), required: false);
            WorkflowValue.Validate(transactionType, nameof(transactionType), required: false);
            return new DeferredBodyAction<ResponseSuccessListObjects>(() =>
            {
                var apiCallPath = "/v2/list-objects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (templateId != null)
                    callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                if (transactionType != null)
                    callPayload.Queries["transaction_type"] = ExpressionConverter.Convert(transactionType);
                return new ApiConnectionAction<ResponseSuccessListObjects>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        [WorkflowExpressionFactory(nameof(__BuildObjectDelete))]
        public IBodyWorkflowAction<ResponseSuccessDeleteObject> ObjectDelete([WorkflowExpression] Func<string> transactionRef)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessDeleteObject> __BuildObjectDelete(WorkflowValue<string> transactionRef)
        {
            WorkflowValue.Validate(transactionRef, nameof(transactionRef), required: true);
            return new DeferredBodyAction<ResponseSuccessDeleteObject>(() =>
            {
                var apiCallPath = "/v2/delete-object";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["transaction_ref"] = ExpressionConverter.Convert(transactionRef);
                return new ApiConnectionAction<ResponseSuccessDeleteObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplatesGet))]
        public IBodyWorkflowAction<ResponseSuccessListTemplates> TemplatesGet([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> offset = null, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<string> templateId = null, [WorkflowExpression] Func<string> groupName = null, [WorkflowExpression] Func<string> withLayerInfo = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessListTemplates> __BuildTemplatesGet(WorkflowValue<string> limit = null, WorkflowValue<string> offset = null, WorkflowValue<string> format = null, WorkflowValue<string> templateId = null, WorkflowValue<string> groupName = null, WorkflowValue<string> withLayerInfo = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(templateId, nameof(templateId), required: false);
            WorkflowValue.Validate(groupName, nameof(groupName), required: false);
            WorkflowValue.Validate(withLayerInfo, nameof(withLayerInfo), required: false);
            return new DeferredBodyAction<ResponseSuccessListTemplates>(() =>
            {
                var apiCallPath = "/v2/list-templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (templateId != null)
                    callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                if (groupName != null)
                    callPayload.Queries["group_name"] = ExpressionConverter.Convert(groupName);
                if (withLayerInfo != null)
                    callPayload.Queries["with_layer_info"] = ExpressionConverter.Convert(withLayerInfo);
                return new ApiConnectionAction<ResponseSuccessListTemplates>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplateGet))]
        public IBodyWorkflowAction<ResponseSuccessTemplate> TemplateGet([WorkflowExpression] Func<string> templateId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessTemplate> __BuildTemplateGet(WorkflowValue<string> templateId = null)
        {
            WorkflowValue.Validate(templateId, nameof(templateId), required: false);
            return new DeferredBodyAction<ResponseSuccessTemplate>(() =>
            {
                var apiCallPath = "/v2/get-template";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (templateId != null)
                    callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                return new ApiConnectionAction<ResponseSuccessTemplate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplateUpdate))]
        public IBodyWorkflowAction<ResponseSuccess> TemplateUpdate([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodycss = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccess> __BuildTemplateUpdate(WorkflowValue<string> bodytemplateId, WorkflowValue<string> bodybody = null, WorkflowValue<string> bodycss = null)
        {
            WorkflowValue.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowValue.Validate(bodybody, nameof(bodybody), required: false);
            WorkflowValue.Validate(bodycss, nameof(bodycss), required: false);
            return new DeferredBodyAction<ResponseSuccess>(() =>
            {
                var apiCallPath = "/v2/update-template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
                if (bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
                    bodypropCount++;
                }

                if (bodycss != null)
                {
                    body["css"] = ExpressionConverter.ConvertO(bodycss);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResponseSuccess>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        [WorkflowExpressionFactory(nameof(__BuildPDFMerge))]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> PDFMerge([WorkflowExpression] Func<string[]> bodyurls, [WorkflowExpression] Func<string> meta = null, [WorkflowExpression] Func<string> bodyexportType = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<int> bodycloudStorage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> __BuildPDFMerge(WorkflowValue<string[]> bodyurls, WorkflowValue<string> meta = null, WorkflowValue<string> bodyexportType = null, WorkflowValue<int> bodyexpiration = null, WorkflowValue<int> bodycloudStorage = null)
        {
            WorkflowValue.Validate(bodyurls, nameof(bodyurls), required: true);
            WorkflowValue.Validate(meta, nameof(meta), required: false);
            WorkflowValue.Validate(bodyexportType, nameof(bodyexportType), required: false);
            WorkflowValue.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            WorkflowValue.Validate(bodycloudStorage, nameof(bodycloudStorage), required: false);
            return new DeferredBodyAction<ResponseSuccessSingleFile>(() =>
            {
                var apiCallPath = "/v2/merge-pdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(meta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = ExpressionConverter.ConvertO(bodyurls);
                if (bodyexportType != null)
                {
                    body["export_type"] = ExpressionConverter.ConvertO(bodyexportType);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                    bodypropCount++;
                }

                if (bodycloudStorage != null)
                {
                    body["cloud_storage"] = ExpressionConverter.ConvertO(bodycloudStorage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResponseSuccessSingleFile>(callPayload);
            });
        }
    }

    public class ApitemplateipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ResponseSuccessPDFFile
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("transaction_ref")]
        public string TransactionRef { get; set; }

        [JsonProperty("post_actions")]
        public JToken[] PostActions { get; set; }
    }

    public class ResponseSuccessImageFile
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("download_url_png")]
        public string DownloadUrlPng { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("transaction_ref")]
        public string TransactionRef { get; set; }

        [JsonProperty("post_actions")]
        public JToken[] PostActions { get; set; }
    }

    public class ResponseSuccessListObjects
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("objects")]
        public JToken[] Objects { get; set; }
    }

    public class ResponseSuccessDeleteObject
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResponseSuccessListTemplates
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("templates")]
        public JToken[] Templates { get; set; }
    }

    public class ResponseSuccessTemplate
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("css")]
        public string Css { get; set; }

        [JsonProperty("settings")]
        public string Settings { get; set; }
    }

    public class ResponseSuccess
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResponseSuccessSingleFile
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("primary_url")]
        public string PrimaryUrl { get; set; }

        [JsonProperty("transaction_ref")]
        public string TransactionRef { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Apitemplateip;

    public partial class WorkflowManagedActions
    {
        public ApitemplateipActions Apitemplateip(string connectionId) => new ApitemplateipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApitemplateipTriggers Apitemplateip(string connectionId) => new ApitemplateipTriggers(connectionId);
    }
}
