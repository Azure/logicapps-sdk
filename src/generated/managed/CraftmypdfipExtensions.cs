//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Craftmypdfip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CraftmypdfipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> Create(Expression<Func<string>> bodydata, Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodyexportType = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyoutputFile = null, Expression<Func<bool>> bodyisCmyk = null)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodyexportType = WorkflowExpression.Compile(bodyexportType, nameof(bodyexportType), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyoutputFile = WorkflowExpression.Compile(bodyoutputFile, nameof(bodyoutputFile), required: false);
            var __workflow_bodyisCmyk = WorkflowExpression.Compile(bodyisCmyk, nameof(bodyisCmyk), required: false);
            return new DeferredBodyAction<ResponseSuccessSingleFile>(() =>
            {
                var apiCallPath = "/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
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

                if (__workflow_bodyoutputFile != null)
                {
                    body["output_file"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFile);
                    bodypropCount++;
                }

                if (__workflow_bodyisCmyk != null)
                {
                    body["is_cmyk"] = ExpressionConverter.ConvertO(__workflow_bodyisCmyk);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResponseSuccessSingleFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> CreateMerge(Expression<Func<JToken[]>> bodytemplates, Expression<Func<string>> bodyexportType = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyoutputFile = null, Expression<Func<string>> bodypaging = null)
        {
            var __workflow_bodytemplates = WorkflowExpression.Compile(bodytemplates, nameof(bodytemplates), required: true);
            var __workflow_bodyexportType = WorkflowExpression.Compile(bodyexportType, nameof(bodyexportType), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyoutputFile = WorkflowExpression.Compile(bodyoutputFile, nameof(bodyoutputFile), required: false);
            var __workflow_bodypaging = WorkflowExpression.Compile(bodypaging, nameof(bodypaging), required: false);
            return new DeferredBodyAction<ResponseSuccessSingleFile>(() =>
            {
                var apiCallPath = "/create-merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["templates"] = ExpressionConverter.ConvertO(__workflow_bodytemplates);
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

                if (__workflow_bodyoutputFile != null)
                {
                    body["output_file"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFile);
                    bodypropCount++;
                }

                if (__workflow_bodypaging != null)
                {
                    body["paging"] = ExpressionConverter.ConvertO(__workflow_bodypaging);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResponseSuccessSingleFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseListTemplate> ListTemplates(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ResponseListTemplate>(() =>
            {
                var apiCallPath = "/list-templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ResponseListTemplate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessCreateNewTemplate> NewTemplateFrom(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodyname = null)
        {
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<ResponseSuccessCreateNewTemplate>(() =>
            {
                var apiCallPath = "/new-template-from";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResponseSuccessCreateNewTemplate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseUpdateTemplate> UpdateTemplate(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyjson = null)
        {
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyjson = WorkflowExpression.Compile(bodyjson, nameof(bodyjson), required: false);
            return new DeferredBodyAction<ResponseUpdateTemplate>(() =>
            {
                var apiCallPath = "/update-template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyjson != null)
                {
                    body["json"] = ExpressionConverter.ConvertO(__workflow_bodyjson);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResponseUpdateTemplate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessDeleteTemplate> DeleteTemplate(Expression<Func<string>> templateId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<ResponseSuccessDeleteTemplate>(() =>
            {
                var apiCallPath = "/delete-template";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                return new ApiConnectionAction<ResponseSuccessDeleteTemplate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessCreateNewEditorSession> CreateEditorSession(Expression<Func<string>> bodytemplateId, Expression<Func<bool>> bodycanSave = null, Expression<Func<bool>> bodycanCreatePDF = null, Expression<Func<bool>> bodycanViewSettings = null, Expression<Func<bool>> bodycanPreview = null, Expression<Func<bool>> bodycanEditJSON = null, Expression<Func<bool>> bodycanShowHeader = null, Expression<Func<int>> bodyjsonMode = null, Expression<Func<string>> bodybackURL = null)
        {
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodycanSave = WorkflowExpression.Compile(bodycanSave, nameof(bodycanSave), required: false);
            var __workflow_bodycanCreatePDF = WorkflowExpression.Compile(bodycanCreatePDF, nameof(bodycanCreatePDF), required: false);
            var __workflow_bodycanViewSettings = WorkflowExpression.Compile(bodycanViewSettings, nameof(bodycanViewSettings), required: false);
            var __workflow_bodycanPreview = WorkflowExpression.Compile(bodycanPreview, nameof(bodycanPreview), required: false);
            var __workflow_bodycanEditJSON = WorkflowExpression.Compile(bodycanEditJSON, nameof(bodycanEditJSON), required: false);
            var __workflow_bodycanShowHeader = WorkflowExpression.Compile(bodycanShowHeader, nameof(bodycanShowHeader), required: false);
            var __workflow_bodyjsonMode = WorkflowExpression.Compile(bodyjsonMode, nameof(bodyjsonMode), required: false);
            var __workflow_bodybackURL = WorkflowExpression.Compile(bodybackURL, nameof(bodybackURL), required: false);
            return new DeferredBodyAction<ResponseSuccessCreateNewEditorSession>(() =>
            {
                var apiCallPath = "/create-editor-session";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                var expirationObject = new JObject();
                var expirationObjectpropCount = 0;
                if (expirationObjectpropCount > 0)
                {
                    body["expiration"] = expirationObject;
                    bodypropCount++;
                }

                if (__workflow_bodycanSave != null)
                {
                    body["canSave"] = ExpressionConverter.ConvertO(__workflow_bodycanSave);
                    bodypropCount++;
                }

                if (__workflow_bodycanCreatePDF != null)
                {
                    body["canCreatePDF"] = ExpressionConverter.ConvertO(__workflow_bodycanCreatePDF);
                    bodypropCount++;
                }

                if (__workflow_bodycanViewSettings != null)
                {
                    body["canViewSettings"] = ExpressionConverter.ConvertO(__workflow_bodycanViewSettings);
                    bodypropCount++;
                }

                if (__workflow_bodycanPreview != null)
                {
                    body["canPreview"] = ExpressionConverter.ConvertO(__workflow_bodycanPreview);
                    bodypropCount++;
                }

                if (__workflow_bodycanEditJSON != null)
                {
                    body["canEditJSON"] = ExpressionConverter.ConvertO(__workflow_bodycanEditJSON);
                    bodypropCount++;
                }

                if (__workflow_bodycanShowHeader != null)
                {
                    body["canShowHeader"] = ExpressionConverter.ConvertO(__workflow_bodycanShowHeader);
                    bodypropCount++;
                }

                if (__workflow_bodyjsonMode != null)
                {
                    body["jsonMode"] = ExpressionConverter.ConvertO(__workflow_bodyjsonMode);
                    bodypropCount++;
                }

                if (__workflow_bodybackURL != null)
                {
                    body["backURL"] = ExpressionConverter.ConvertO(__workflow_bodybackURL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResponseSuccessCreateNewEditorSession>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseListTransactions> ListTransactions(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ResponseListTransactions>(() =>
            {
                var apiCallPath = "/list-transactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ResponseListTransactions>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseAccountInformation> GetAccountInfo()
        {
            var apiCallPath = "/get-account-info";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseAccountInformation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> MergePdfs(Expression<Func<JToken[]>> bodyurls, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyoutputFile = null)
        {
            var __workflow_bodyurls = WorkflowExpression.Compile(bodyurls, nameof(bodyurls), required: true);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyoutputFile = WorkflowExpression.Compile(bodyoutputFile, nameof(bodyoutputFile), required: false);
            return new DeferredBodyAction<ResponseSuccessSingleFile>(() =>
            {
                var apiCallPath = "/merge-pdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = ExpressionConverter.ConvertO(__workflow_bodyurls);
                if (__workflow_bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                    bodypropCount++;
                }

                if (__workflow_bodyoutputFile != null)
                {
                    body["output_file"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFile);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResponseSuccessSingleFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> AddWatermark(Expression<Func<string>> bodyurl, Expression<Func<string>> bodytext, Expression<Func<int>> bodyfontSize = null, Expression<Func<int>> bodyopacity = null, Expression<Func<int>> bodyrotation = null, Expression<Func<string>> bodyhexColor = null, Expression<Func<string>> bodyfontFamily = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyoutputFile = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyfontSize = WorkflowExpression.Compile(bodyfontSize, nameof(bodyfontSize), required: false);
            var __workflow_bodyopacity = WorkflowExpression.Compile(bodyopacity, nameof(bodyopacity), required: false);
            var __workflow_bodyrotation = WorkflowExpression.Compile(bodyrotation, nameof(bodyrotation), required: false);
            var __workflow_bodyhexColor = WorkflowExpression.Compile(bodyhexColor, nameof(bodyhexColor), required: false);
            var __workflow_bodyfontFamily = WorkflowExpression.Compile(bodyfontFamily, nameof(bodyfontFamily), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyoutputFile = WorkflowExpression.Compile(bodyoutputFile, nameof(bodyoutputFile), required: false);
            return new DeferredBodyAction<ResponseSuccessSingleFile>(() =>
            {
                var apiCallPath = "/add-watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodyfontSize != null)
                {
                    body["font_size"] = ExpressionConverter.ConvertO(__workflow_bodyfontSize);
                    bodypropCount++;
                }

                if (__workflow_bodyopacity != null)
                {
                    body["opacity"] = ExpressionConverter.ConvertO(__workflow_bodyopacity);
                    bodypropCount++;
                }

                if (__workflow_bodyrotation != null)
                {
                    body["rotation"] = ExpressionConverter.ConvertO(__workflow_bodyrotation);
                    bodypropCount++;
                }

                if (__workflow_bodyhexColor != null)
                {
                    body["hex_color"] = ExpressionConverter.ConvertO(__workflow_bodyhexColor);
                    bodypropCount++;
                }

                if (__workflow_bodyfontFamily != null)
                {
                    body["font_family"] = ExpressionConverter.ConvertO(__workflow_bodyfontFamily);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                    bodypropCount++;
                }

                if (__workflow_bodyoutputFile != null)
                {
                    body["output_file"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFile);
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

    public class CraftmypdfipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ResponseSuccessSingleFile
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("transaction_ref")]
        public string TransactionRef { get; set; }
    }

    public class ResponseListTemplate
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("templates")]
        public JToken[] Templates { get; set; }
    }

    public class ResponseSuccessCreateNewTemplate
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }

    public class ResponseUpdateTemplate
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResponseSuccessDeleteTemplate
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResponseSuccessCreateNewEditorSession
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ResponseListTransactions
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactions")]
        public JToken[] Transactions { get; set; }
    }

    public class ResponseAccountInformation
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactions")]
        public JToken[] Transactions { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Craftmypdfip;

    public partial class WorkflowManagedActions
    {
        public CraftmypdfipActions Craftmypdfip(string connectionId) => new CraftmypdfipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CraftmypdfipTriggers Craftmypdfip(string connectionId) => new CraftmypdfipTriggers(connectionId);
    }
}
