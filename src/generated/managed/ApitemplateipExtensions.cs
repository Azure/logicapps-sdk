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
        public IBodyWorkflowAction<ResponseSuccessPDFFile> PDFPost(Expression<Func<string>> templateId, Expression<Func<string>> exportType = null, Expression<Func<int>> expiration = null, Expression<Func<string>> outputHtml = null, Expression<Func<string>> outputFormat = null, Expression<Func<string>> filename = null, Expression<Func<string>> imageResampleRes = null, Expression<Func<string>> isCmyk = null, Expression<Func<int>> cloudStorage = null, Expression<Func<string>> meta = null, Expression<Func<string>> async = null, Expression<Func<string>> webhookUrl = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessImageFile> ImagePost(Expression<Func<string>> templateId, Expression<Func<int>> expiration = null, Expression<Func<int>> cloudStorage = null, Expression<Func<string>> outputImageType = null, Expression<Func<string>> meta = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessListObjects> ObjectsGet(Expression<Func<string>> limit = null, Expression<Func<string>> offset = null, Expression<Func<string>> templateId = null, Expression<Func<string>> transactionType = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessDeleteObject> ObjectDelete(Expression<Func<string>> transactionRef)
        {
            var apiCallPath = "/v2/delete-object";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["transaction_ref"] = ExpressionConverter.Convert(transactionRef);
            return new ApiConnectionAction<ResponseSuccessDeleteObject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessListTemplates> TemplatesGet(Expression<Func<string>> limit = null, Expression<Func<string>> offset = null, Expression<Func<string>> format = null, Expression<Func<string>> templateId = null, Expression<Func<string>> groupName = null, Expression<Func<string>> withLayerInfo = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessTemplate> TemplateGet(Expression<Func<string>> templateId = null)
        {
            var apiCallPath = "/v2/get-template";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (templateId != null)
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
            return new ApiConnectionAction<ResponseSuccessTemplate>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccess> TemplateUpdate(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodycss = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> PDFMerge(Expression<Func<string[]>> bodyurls, Expression<Func<string>> meta = null, Expression<Func<string>> bodyexportType = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<int>> bodycloudStorage = null)
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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