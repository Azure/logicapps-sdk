//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Craftmypdfip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CraftmypdfipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> Create(Expression<Func<string>> bodydata, Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodyexportType = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyoutputFile = null, Expression<Func<bool>> bodyisCmyk = null)
        {
            var apiCallPath = "/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            bodypropCount++;
            body["template_id"] = CSharpExpressionConverter.ConvertToken(bodytemplateId);
            if (bodyexportType != null)
            {
                body["export_type"] = CSharpExpressionConverter.ConvertToken(bodyexportType);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = CSharpExpressionConverter.ConvertToken(bodyexpiration);
                bodypropCount++;
            }

            if (bodyoutputFile != null)
            {
                body["output_file"] = CSharpExpressionConverter.ConvertToken(bodyoutputFile);
                bodypropCount++;
            }

            if (bodyisCmyk != null)
            {
                body["is_cmyk"] = CSharpExpressionConverter.ConvertToken(bodyisCmyk);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseSuccessSingleFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> CreateMerge(Expression<Func<JToken[]>> bodytemplates, Expression<Func<string>> bodyexportType = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyoutputFile = null, Expression<Func<string>> bodypaging = null)
        {
            var apiCallPath = "/create-merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["templates"] = CSharpExpressionConverter.ConvertToken(bodytemplates);
            if (bodyexportType != null)
            {
                body["export_type"] = CSharpExpressionConverter.ConvertToken(bodyexportType);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = CSharpExpressionConverter.ConvertToken(bodyexpiration);
                bodypropCount++;
            }

            if (bodyoutputFile != null)
            {
                body["output_file"] = CSharpExpressionConverter.ConvertToken(bodyoutputFile);
                bodypropCount++;
            }

            if (bodypaging != null)
            {
                body["paging"] = CSharpExpressionConverter.ConvertToken(bodypaging);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseSuccessSingleFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseListTemplate> ListTemplates(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/list-templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<ResponseListTemplate>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessCreateNewTemplate> NewTemplateFrom(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodyname = null)
        {
            var apiCallPath = "/new-template-from";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["template_id"] = CSharpExpressionConverter.ConvertToken(bodytemplateId);
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseSuccessCreateNewTemplate>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseUpdateTemplate> UpdateTemplate(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyjson = null)
        {
            var apiCallPath = "/update-template";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["template_id"] = CSharpExpressionConverter.ConvertToken(bodytemplateId);
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodyjson != null)
            {
                body["json"] = CSharpExpressionConverter.ConvertToken(bodyjson);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseUpdateTemplate>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessDeleteTemplate> DeleteTemplate(Expression<Func<string>> templateId)
        {
            var apiCallPath = "/delete-template";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template_id"] = CSharpExpressionConverter.ConvertO(templateId);
            return new ApiConnectionAction<ResponseSuccessDeleteTemplate>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessCreateNewEditorSession> CreateEditorSession(Expression<Func<string>> bodytemplateId, Expression<Func<bool>> bodycanSave = null, Expression<Func<bool>> bodycanCreatePDF = null, Expression<Func<bool>> bodycanViewSettings = null, Expression<Func<bool>> bodycanPreview = null, Expression<Func<bool>> bodycanEditJSON = null, Expression<Func<bool>> bodycanShowHeader = null, Expression<Func<int>> bodyjsonMode = null, Expression<Func<string>> bodybackURL = null)
        {
            var apiCallPath = "/create-editor-session";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["template_id"] = CSharpExpressionConverter.ConvertToken(bodytemplateId);
            var expirationObject = new JObject();
            var expirationObjectpropCount = 0;
            if (expirationObjectpropCount > 0)
            {
                body["expiration"] = expirationObject;
                bodypropCount++;
            }

            if (bodycanSave != null)
            {
                body["canSave"] = CSharpExpressionConverter.ConvertToken(bodycanSave);
                bodypropCount++;
            }

            if (bodycanCreatePDF != null)
            {
                body["canCreatePDF"] = CSharpExpressionConverter.ConvertToken(bodycanCreatePDF);
                bodypropCount++;
            }

            if (bodycanViewSettings != null)
            {
                body["canViewSettings"] = CSharpExpressionConverter.ConvertToken(bodycanViewSettings);
                bodypropCount++;
            }

            if (bodycanPreview != null)
            {
                body["canPreview"] = CSharpExpressionConverter.ConvertToken(bodycanPreview);
                bodypropCount++;
            }

            if (bodycanEditJSON != null)
            {
                body["canEditJSON"] = CSharpExpressionConverter.ConvertToken(bodycanEditJSON);
                bodypropCount++;
            }

            if (bodycanShowHeader != null)
            {
                body["canShowHeader"] = CSharpExpressionConverter.ConvertToken(bodycanShowHeader);
                bodypropCount++;
            }

            if (bodyjsonMode != null)
            {
                body["jsonMode"] = CSharpExpressionConverter.ConvertToken(bodyjsonMode);
                bodypropCount++;
            }

            if (bodybackURL != null)
            {
                body["backURL"] = CSharpExpressionConverter.ConvertToken(bodybackURL);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseSuccessCreateNewEditorSession>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseListTransactions> ListTransactions(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/list-transactions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<ResponseListTransactions>(callPayload);
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
            var apiCallPath = "/merge-pdfs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["urls"] = CSharpExpressionConverter.ConvertToken(bodyurls);
            if (bodyexpiration != null)
            {
                body["expiration"] = CSharpExpressionConverter.ConvertToken(bodyexpiration);
                bodypropCount++;
            }

            if (bodyoutputFile != null)
            {
                body["output_file"] = CSharpExpressionConverter.ConvertToken(bodyoutputFile);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseSuccessSingleFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> AddWatermark(Expression<Func<string>> bodyurl, Expression<Func<string>> bodytext, Expression<Func<int>> bodyfontSize = null, Expression<Func<int>> bodyopacity = null, Expression<Func<int>> bodyrotation = null, Expression<Func<string>> bodyhexColor = null, Expression<Func<string>> bodyfontFamily = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyoutputFile = null)
        {
            var apiCallPath = "/add-watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = CSharpExpressionConverter.ConvertToken(bodyurl);
            bodypropCount++;
            body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
            if (bodyfontSize != null)
            {
                body["font_size"] = CSharpExpressionConverter.ConvertToken(bodyfontSize);
                bodypropCount++;
            }

            if (bodyopacity != null)
            {
                body["opacity"] = CSharpExpressionConverter.ConvertToken(bodyopacity);
                bodypropCount++;
            }

            if (bodyrotation != null)
            {
                body["rotation"] = CSharpExpressionConverter.ConvertToken(bodyrotation);
                bodypropCount++;
            }

            if (bodyhexColor != null)
            {
                body["hex_color"] = CSharpExpressionConverter.ConvertToken(bodyhexColor);
                bodypropCount++;
            }

            if (bodyfontFamily != null)
            {
                body["font_family"] = CSharpExpressionConverter.ConvertToken(bodyfontFamily);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = CSharpExpressionConverter.ConvertToken(bodyexpiration);
                bodypropCount++;
            }

            if (bodyoutputFile != null)
            {
                body["output_file"] = CSharpExpressionConverter.ConvertToken(bodyoutputFile);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseSuccessSingleFile>(callPayload);
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