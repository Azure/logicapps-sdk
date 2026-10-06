//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apitemplateip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApitemplateipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessPDFFile> PDF([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> exportType = null, [WorkflowExpression] Func<int> expiration = null, [WorkflowExpression] Func<string> outputHtml = null, [WorkflowExpression] Func<string> outputFormat = null, [WorkflowExpression] Func<string> filename = null, [WorkflowExpression] Func<string> imageResampleRes = null, [WorkflowExpression] Func<string> isCmyk = null, [WorkflowExpression] Func<int> cloudStorage = null, [WorkflowExpression] Func<string> meta = null, [WorkflowExpression] Func<string> async = null, [WorkflowExpression] Func<string> webhookUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/create-pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                if (exportType != null)
                    callPayload.Queries["export_type"] = SourceExpressionConverter.ConvertO(exportType);
                if (expiration != null)
                    callPayload.Queries["expiration"] = SourceExpressionConverter.ConvertO(expiration);
                if (outputHtml != null)
                    callPayload.Queries["output_html"] = SourceExpressionConverter.ConvertO(outputHtml);
                if (outputFormat != null)
                    callPayload.Queries["output_format"] = SourceExpressionConverter.ConvertO(outputFormat);
                if (filename != null)
                    callPayload.Queries["filename"] = SourceExpressionConverter.ConvertO(filename);
                if (imageResampleRes != null)
                    callPayload.Queries["image_resample_res"] = SourceExpressionConverter.ConvertO(imageResampleRes);
                if (isCmyk != null)
                    callPayload.Queries["is_cmyk"] = SourceExpressionConverter.ConvertO(isCmyk);
                if (cloudStorage != null)
                    callPayload.Queries["cloud_storage"] = SourceExpressionConverter.ConvertO(cloudStorage);
                if (meta != null)
                    callPayload.Queries["meta"] = SourceExpressionConverter.ConvertO(meta);
                if (async != null)
                    callPayload.Queries["async"] = SourceExpressionConverter.ConvertO(async);
                if (webhookUrl != null)
                    callPayload.Queries["webhook_url"] = SourceExpressionConverter.ConvertO(webhookUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccessPDFFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessImageFile> Image([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<int> expiration = null, [WorkflowExpression] Func<int> cloudStorage = null, [WorkflowExpression] Func<string> outputImageType = null, [WorkflowExpression] Func<string> meta = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/create-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                if (expiration != null)
                    callPayload.Queries["expiration"] = SourceExpressionConverter.ConvertO(expiration);
                if (cloudStorage != null)
                    callPayload.Queries["cloud_storage"] = SourceExpressionConverter.ConvertO(cloudStorage);
                if (outputImageType != null)
                    callPayload.Queries["output_image_type"] = SourceExpressionConverter.ConvertO(outputImageType);
                if (meta != null)
                    callPayload.Queries["meta"] = SourceExpressionConverter.ConvertO(meta);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccessImageFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessListObjects> ObjectsGet([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> offset = null, [WorkflowExpression] Func<string> templateId = null, [WorkflowExpression] Func<string> transactionType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/list-objects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (templateId != null)
                    callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                if (transactionType != null)
                    callPayload.Queries["transaction_type"] = SourceExpressionConverter.ConvertO(transactionType);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccessListObjects>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessDeleteObject> ObjectDelete([WorkflowExpression] Func<string> transactionRef)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/delete-object";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["transaction_ref"] = SourceExpressionConverter.ConvertO(transactionRef);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccessDeleteObject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessListTemplates> TemplatesGet([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> offset = null, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<string> templateId = null, [WorkflowExpression] Func<string> groupName = null, [WorkflowExpression] Func<string> withLayerInfo = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/list-templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.ConvertO(format);
                if (templateId != null)
                    callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                if (groupName != null)
                    callPayload.Queries["group_name"] = SourceExpressionConverter.ConvertO(groupName);
                if (withLayerInfo != null)
                    callPayload.Queries["with_layer_info"] = SourceExpressionConverter.ConvertO(withLayerInfo);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccessListTemplates>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessTemplate> TemplateGet([WorkflowExpression] Func<string> templateId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/get-template";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (templateId != null)
                    callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccessTemplate>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccess> TemplateUpdate([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodycss = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/update-template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodycss != null)
                {
                    body["css"] = SourceExpressionConverter.ConvertToken(bodycss);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccess>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> PDFMerge([WorkflowExpression] Func<string[]> bodyurls, [WorkflowExpression] Func<string> meta = null, [WorkflowExpression] Func<string> bodyexportType = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<int> bodycloudStorage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/merge-pdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (meta != null)
                    callPayload.Queries["meta"] = SourceExpressionConverter.ConvertO(meta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = SourceExpressionConverter.ConvertToken(bodyurls);
                if (bodyexportType != null)
                {
                    body["export_type"] = SourceExpressionConverter.ConvertToken(bodyexportType);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                    bodypropCount++;
                }

                if (bodycloudStorage != null)
                {
                    body["cloud_storage"] = SourceExpressionConverter.ConvertToken(bodycloudStorage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccessSingleFile>(BuildSourceInput);
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