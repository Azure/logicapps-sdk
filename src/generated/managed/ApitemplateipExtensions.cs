//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apitemplateip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ApitemplateipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessPDFFile> PDF(Expression<Func<string>> templateId, Expression<Func<string>> exportType = null, Expression<Func<int>> expiration = null, Expression<Func<string>> outputHtml = null, Expression<Func<string>> outputFormat = null, Expression<Func<string>> filename = null, Expression<Func<string>> imageResampleRes = null, Expression<Func<string>> isCmyk = null, Expression<Func<int>> cloudStorage = null, Expression<Func<string>> meta = null, Expression<Func<string>> async = null, Expression<Func<string>> webhookUrl = null)
        {
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: true);
            var __workflow_exportType = exportType == null ? null : WorkflowExpression.Compile(exportType);
            WorkflowExpression.Validate(__workflow_exportType, nameof(exportType), required: false);
            var __workflow_expiration = expiration == null ? null : WorkflowExpression.Compile(expiration);
            WorkflowExpression.Validate(__workflow_expiration, nameof(expiration), required: false);
            var __workflow_outputHtml = outputHtml == null ? null : WorkflowExpression.Compile(outputHtml);
            WorkflowExpression.Validate(__workflow_outputHtml, nameof(outputHtml), required: false);
            var __workflow_outputFormat = outputFormat == null ? null : WorkflowExpression.Compile(outputFormat);
            WorkflowExpression.Validate(__workflow_outputFormat, nameof(outputFormat), required: false);
            var __workflow_filename = filename == null ? null : WorkflowExpression.Compile(filename);
            WorkflowExpression.Validate(__workflow_filename, nameof(filename), required: false);
            var __workflow_imageResampleRes = imageResampleRes == null ? null : WorkflowExpression.Compile(imageResampleRes);
            WorkflowExpression.Validate(__workflow_imageResampleRes, nameof(imageResampleRes), required: false);
            var __workflow_isCmyk = isCmyk == null ? null : WorkflowExpression.Compile(isCmyk);
            WorkflowExpression.Validate(__workflow_isCmyk, nameof(isCmyk), required: false);
            var __workflow_cloudStorage = cloudStorage == null ? null : WorkflowExpression.Compile(cloudStorage);
            WorkflowExpression.Validate(__workflow_cloudStorage, nameof(cloudStorage), required: false);
            var __workflow_meta = meta == null ? null : WorkflowExpression.Compile(meta);
            WorkflowExpression.Validate(__workflow_meta, nameof(meta), required: false);
            var __workflow_async = async == null ? null : WorkflowExpression.Compile(async);
            WorkflowExpression.Validate(__workflow_async, nameof(async), required: false);
            var __workflow_webhookUrl = webhookUrl == null ? null : WorkflowExpression.Compile(webhookUrl);
            WorkflowExpression.Validate(__workflow_webhookUrl, nameof(webhookUrl), required: false);
            return new DeferredBodyAction<ResponseSuccessPDFFile>(() =>
            {
                var apiCallPath = "/v2/create-pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                if (__workflow_exportType != null)
                    callPayload.Queries["export_type"] = ExpressionConverter.Convert(__workflow_exportType);
                if (__workflow_expiration != null)
                    callPayload.Queries["expiration"] = ExpressionConverter.Convert(__workflow_expiration);
                if (__workflow_outputHtml != null)
                    callPayload.Queries["output_html"] = ExpressionConverter.Convert(__workflow_outputHtml);
                if (__workflow_outputFormat != null)
                    callPayload.Queries["output_format"] = ExpressionConverter.Convert(__workflow_outputFormat);
                if (__workflow_filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_filename);
                if (__workflow_imageResampleRes != null)
                    callPayload.Queries["image_resample_res"] = ExpressionConverter.Convert(__workflow_imageResampleRes);
                if (__workflow_isCmyk != null)
                    callPayload.Queries["is_cmyk"] = ExpressionConverter.Convert(__workflow_isCmyk);
                if (__workflow_cloudStorage != null)
                    callPayload.Queries["cloud_storage"] = ExpressionConverter.Convert(__workflow_cloudStorage);
                if (__workflow_meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(__workflow_meta);
                if (__workflow_async != null)
                    callPayload.Queries["async"] = ExpressionConverter.Convert(__workflow_async);
                if (__workflow_webhookUrl != null)
                    callPayload.Queries["webhook_url"] = ExpressionConverter.Convert(__workflow_webhookUrl);
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
        public IBodyWorkflowAction<ResponseSuccessImageFile> Image(Expression<Func<string>> templateId, Expression<Func<int>> expiration = null, Expression<Func<int>> cloudStorage = null, Expression<Func<string>> outputImageType = null, Expression<Func<string>> meta = null)
        {
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: true);
            var __workflow_expiration = expiration == null ? null : WorkflowExpression.Compile(expiration);
            WorkflowExpression.Validate(__workflow_expiration, nameof(expiration), required: false);
            var __workflow_cloudStorage = cloudStorage == null ? null : WorkflowExpression.Compile(cloudStorage);
            WorkflowExpression.Validate(__workflow_cloudStorage, nameof(cloudStorage), required: false);
            var __workflow_outputImageType = outputImageType == null ? null : WorkflowExpression.Compile(outputImageType);
            WorkflowExpression.Validate(__workflow_outputImageType, nameof(outputImageType), required: false);
            var __workflow_meta = meta == null ? null : WorkflowExpression.Compile(meta);
            WorkflowExpression.Validate(__workflow_meta, nameof(meta), required: false);
            return new DeferredBodyAction<ResponseSuccessImageFile>(() =>
            {
                var apiCallPath = "/v2/create-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                if (__workflow_expiration != null)
                    callPayload.Queries["expiration"] = ExpressionConverter.Convert(__workflow_expiration);
                if (__workflow_cloudStorage != null)
                    callPayload.Queries["cloud_storage"] = ExpressionConverter.Convert(__workflow_cloudStorage);
                if (__workflow_outputImageType != null)
                    callPayload.Queries["output_image_type"] = ExpressionConverter.Convert(__workflow_outputImageType);
                if (__workflow_meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(__workflow_meta);
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
        public IBodyWorkflowAction<ResponseSuccessListObjects> ObjectsGet(Expression<Func<string>> limit = null, Expression<Func<string>> offset = null, Expression<Func<string>> templateId = null, Expression<Func<string>> transactionType = null)
        {
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: false);
            var __workflow_transactionType = transactionType == null ? null : WorkflowExpression.Compile(transactionType);
            WorkflowExpression.Validate(__workflow_transactionType, nameof(transactionType), required: false);
            return new DeferredBodyAction<ResponseSuccessListObjects>(() =>
            {
                var apiCallPath = "/v2/list-objects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_templateId != null)
                    callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                if (__workflow_transactionType != null)
                    callPayload.Queries["transaction_type"] = ExpressionConverter.Convert(__workflow_transactionType);
                return new ApiConnectionAction<ResponseSuccessListObjects>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessDeleteObject> ObjectDelete(Expression<Func<string>> transactionRef)
        {
            var __workflow_transactionRef = transactionRef == null ? null : WorkflowExpression.Compile(transactionRef);
            WorkflowExpression.Validate(__workflow_transactionRef, nameof(transactionRef), required: true);
            return new DeferredBodyAction<ResponseSuccessDeleteObject>(() =>
            {
                var apiCallPath = "/v2/delete-object";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["transaction_ref"] = ExpressionConverter.Convert(__workflow_transactionRef);
                return new ApiConnectionAction<ResponseSuccessDeleteObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessListTemplates> TemplatesGet(Expression<Func<string>> limit = null, Expression<Func<string>> offset = null, Expression<Func<string>> format = null, Expression<Func<string>> templateId = null, Expression<Func<string>> groupName = null, Expression<Func<string>> withLayerInfo = null)
        {
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: false);
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: false);
            var __workflow_groupName = groupName == null ? null : WorkflowExpression.Compile(groupName);
            WorkflowExpression.Validate(__workflow_groupName, nameof(groupName), required: false);
            var __workflow_withLayerInfo = withLayerInfo == null ? null : WorkflowExpression.Compile(withLayerInfo);
            WorkflowExpression.Validate(__workflow_withLayerInfo, nameof(withLayerInfo), required: false);
            return new DeferredBodyAction<ResponseSuccessListTemplates>(() =>
            {
                var apiCallPath = "/v2/list-templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_templateId != null)
                    callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                if (__workflow_groupName != null)
                    callPayload.Queries["group_name"] = ExpressionConverter.Convert(__workflow_groupName);
                if (__workflow_withLayerInfo != null)
                    callPayload.Queries["with_layer_info"] = ExpressionConverter.Convert(__workflow_withLayerInfo);
                return new ApiConnectionAction<ResponseSuccessListTemplates>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccessTemplate> TemplateGet(Expression<Func<string>> templateId = null)
        {
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: false);
            return new DeferredBodyAction<ResponseSuccessTemplate>(() =>
            {
                var apiCallPath = "/v2/get-template";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_templateId != null)
                    callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                return new ApiConnectionAction<ResponseSuccessTemplate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apitemplateip")]
        public IBodyWorkflowAction<ResponseSuccess> TemplateUpdate(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodycss = null)
        {
            var __workflow_bodytemplateId = bodytemplateId == null ? null : WorkflowExpression.Compile(bodytemplateId);
            WorkflowExpression.Validate(__workflow_bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodybody = bodybody == null ? null : WorkflowExpression.Compile(bodybody);
            WorkflowExpression.Validate(__workflow_bodybody, nameof(bodybody), required: false);
            var __workflow_bodycss = bodycss == null ? null : WorkflowExpression.Compile(bodycss);
            WorkflowExpression.Validate(__workflow_bodycss, nameof(bodycss), required: false);
            return new DeferredBodyAction<ResponseSuccess>(() =>
            {
                var apiCallPath = "/v2/update-template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (__workflow_bodycss != null)
                {
                    body["css"] = ExpressionConverter.ConvertO(__workflow_bodycss);
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
        public IBodyWorkflowAction<ResponseSuccessSingleFile> PDFMerge(Expression<Func<string[]>> bodyurls, Expression<Func<string>> meta = null, Expression<Func<string>> bodyexportType = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<int>> bodycloudStorage = null)
        {
            var __workflow_bodyurls = bodyurls == null ? null : WorkflowExpression.Compile(bodyurls);
            WorkflowExpression.Validate(__workflow_bodyurls, nameof(bodyurls), required: true);
            var __workflow_meta = meta == null ? null : WorkflowExpression.Compile(meta);
            WorkflowExpression.Validate(__workflow_meta, nameof(meta), required: false);
            var __workflow_bodyexportType = bodyexportType == null ? null : WorkflowExpression.Compile(bodyexportType);
            WorkflowExpression.Validate(__workflow_bodyexportType, nameof(bodyexportType), required: false);
            var __workflow_bodyexpiration = bodyexpiration == null ? null : WorkflowExpression.Compile(bodyexpiration);
            WorkflowExpression.Validate(__workflow_bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodycloudStorage = bodycloudStorage == null ? null : WorkflowExpression.Compile(bodycloudStorage);
            WorkflowExpression.Validate(__workflow_bodycloudStorage, nameof(bodycloudStorage), required: false);
            return new DeferredBodyAction<ResponseSuccessSingleFile>(() =>
            {
                var apiCallPath = "/v2/merge-pdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(__workflow_meta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = ExpressionConverter.ConvertO(__workflow_bodyurls);
                if (__workflow_bodyexportType != null)
                {
                    body["export_type"] = ExpressionConverter.ConvertO(__workflow_bodyexportType);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                    bodypropCount++;
                }

                if (__workflow_bodycloudStorage != null)
                {
                    body["cloud_storage"] = ExpressionConverter.ConvertO(__workflow_bodycloudStorage);
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
