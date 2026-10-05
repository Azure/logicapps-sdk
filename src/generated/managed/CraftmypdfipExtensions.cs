//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Craftmypdfip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CraftmypdfipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        [WorkflowExpressionFactory(nameof(__BuildCreate))]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> Create([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodyexportType = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyoutputFile = null, [WorkflowExpression] Func<bool> bodyisCmyk = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> __BuildCreate(WorkflowValue<string> bodydata, WorkflowValue<string> bodytemplateId, WorkflowValue<string> bodyexportType = null, WorkflowValue<int> bodyexpiration = null, WorkflowValue<string> bodyoutputFile = null, WorkflowValue<bool> bodyisCmyk = null)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowValue.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowValue.Validate(bodyexportType, nameof(bodyexportType), required: false);
            WorkflowValue.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            WorkflowValue.Validate(bodyoutputFile, nameof(bodyoutputFile), required: false);
            WorkflowValue.Validate(bodyisCmyk, nameof(bodyisCmyk), required: false);
            return new DeferredBodyAction<ResponseSuccessSingleFile>(() =>
            {
                var apiCallPath = "/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
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

                if (bodyoutputFile != null)
                {
                    body["output_file"] = ExpressionConverter.ConvertO(bodyoutputFile);
                    bodypropCount++;
                }

                if (bodyisCmyk != null)
                {
                    body["is_cmyk"] = ExpressionConverter.ConvertO(bodyisCmyk);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateMerge))]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> CreateMerge([WorkflowExpression] Func<JToken[]> bodytemplates, [WorkflowExpression] Func<string> bodyexportType = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyoutputFile = null, [WorkflowExpression] Func<string> bodypaging = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> __BuildCreateMerge(WorkflowValue<JToken[]> bodytemplates, WorkflowValue<string> bodyexportType = null, WorkflowValue<int> bodyexpiration = null, WorkflowValue<string> bodyoutputFile = null, WorkflowValue<string> bodypaging = null)
        {
            WorkflowValue.Validate(bodytemplates, nameof(bodytemplates), required: true);
            WorkflowValue.Validate(bodyexportType, nameof(bodyexportType), required: false);
            WorkflowValue.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            WorkflowValue.Validate(bodyoutputFile, nameof(bodyoutputFile), required: false);
            WorkflowValue.Validate(bodypaging, nameof(bodypaging), required: false);
            return new DeferredBodyAction<ResponseSuccessSingleFile>(() =>
            {
                var apiCallPath = "/create-merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["templates"] = ExpressionConverter.ConvertO(bodytemplates);
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

                if (bodyoutputFile != null)
                {
                    body["output_file"] = ExpressionConverter.ConvertO(bodyoutputFile);
                    bodypropCount++;
                }

                if (bodypaging != null)
                {
                    body["paging"] = ExpressionConverter.ConvertO(bodypaging);
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
        [WorkflowExpressionFactory(nameof(__BuildListTemplates))]
        public IBodyWorkflowAction<ResponseListTemplate> ListTemplates([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseListTemplate> __BuildListTemplates(WorkflowValue<int> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ResponseListTemplate>(() =>
            {
                var apiCallPath = "/list-templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<ResponseListTemplate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        [WorkflowExpressionFactory(nameof(__BuildNewTemplateFrom))]
        public IBodyWorkflowAction<ResponseSuccessCreateNewTemplate> NewTemplateFrom([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodyname = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessCreateNewTemplate> __BuildNewTemplateFrom(WorkflowValue<string> bodytemplateId, WorkflowValue<string> bodyname = null)
        {
            WorkflowValue.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<ResponseSuccessCreateNewTemplate>(() =>
            {
                var apiCallPath = "/new-template-from";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateTemplate))]
        public IBodyWorkflowAction<ResponseUpdateTemplate> UpdateTemplate([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyjson = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseUpdateTemplate> __BuildUpdateTemplate(WorkflowValue<string> bodytemplateId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyjson = null)
        {
            WorkflowValue.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyjson, nameof(bodyjson), required: false);
            return new DeferredBodyAction<ResponseUpdateTemplate>(() =>
            {
                var apiCallPath = "/update-template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyjson != null)
                {
                    body["json"] = ExpressionConverter.ConvertO(bodyjson);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteTemplate))]
        public IBodyWorkflowAction<ResponseSuccessDeleteTemplate> DeleteTemplate([WorkflowExpression] Func<string> templateId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessDeleteTemplate> __BuildDeleteTemplate(WorkflowValue<string> templateId)
        {
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<ResponseSuccessDeleteTemplate>(() =>
            {
                var apiCallPath = "/delete-template";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                return new ApiConnectionAction<ResponseSuccessDeleteTemplate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEditorSession))]
        public IBodyWorkflowAction<ResponseSuccessCreateNewEditorSession> CreateEditorSession([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<bool> bodycanSave = null, [WorkflowExpression] Func<bool> bodycanCreatePDF = null, [WorkflowExpression] Func<bool> bodycanViewSettings = null, [WorkflowExpression] Func<bool> bodycanPreview = null, [WorkflowExpression] Func<bool> bodycanEditJSON = null, [WorkflowExpression] Func<bool> bodycanShowHeader = null, [WorkflowExpression] Func<int> bodyjsonMode = null, [WorkflowExpression] Func<string> bodybackURL = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessCreateNewEditorSession> __BuildCreateEditorSession(WorkflowValue<string> bodytemplateId, WorkflowValue<bool> bodycanSave = null, WorkflowValue<bool> bodycanCreatePDF = null, WorkflowValue<bool> bodycanViewSettings = null, WorkflowValue<bool> bodycanPreview = null, WorkflowValue<bool> bodycanEditJSON = null, WorkflowValue<bool> bodycanShowHeader = null, WorkflowValue<int> bodyjsonMode = null, WorkflowValue<string> bodybackURL = null)
        {
            WorkflowValue.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowValue.Validate(bodycanSave, nameof(bodycanSave), required: false);
            WorkflowValue.Validate(bodycanCreatePDF, nameof(bodycanCreatePDF), required: false);
            WorkflowValue.Validate(bodycanViewSettings, nameof(bodycanViewSettings), required: false);
            WorkflowValue.Validate(bodycanPreview, nameof(bodycanPreview), required: false);
            WorkflowValue.Validate(bodycanEditJSON, nameof(bodycanEditJSON), required: false);
            WorkflowValue.Validate(bodycanShowHeader, nameof(bodycanShowHeader), required: false);
            WorkflowValue.Validate(bodyjsonMode, nameof(bodyjsonMode), required: false);
            WorkflowValue.Validate(bodybackURL, nameof(bodybackURL), required: false);
            return new DeferredBodyAction<ResponseSuccessCreateNewEditorSession>(() =>
            {
                var apiCallPath = "/create-editor-session";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
                var expirationObject = new JObject();
                var expirationObjectpropCount = 0;
                if (expirationObjectpropCount > 0)
                {
                    body["expiration"] = expirationObject;
                    bodypropCount++;
                }

                if (bodycanSave != null)
                {
                    body["canSave"] = ExpressionConverter.ConvertO(bodycanSave);
                    bodypropCount++;
                }

                if (bodycanCreatePDF != null)
                {
                    body["canCreatePDF"] = ExpressionConverter.ConvertO(bodycanCreatePDF);
                    bodypropCount++;
                }

                if (bodycanViewSettings != null)
                {
                    body["canViewSettings"] = ExpressionConverter.ConvertO(bodycanViewSettings);
                    bodypropCount++;
                }

                if (bodycanPreview != null)
                {
                    body["canPreview"] = ExpressionConverter.ConvertO(bodycanPreview);
                    bodypropCount++;
                }

                if (bodycanEditJSON != null)
                {
                    body["canEditJSON"] = ExpressionConverter.ConvertO(bodycanEditJSON);
                    bodypropCount++;
                }

                if (bodycanShowHeader != null)
                {
                    body["canShowHeader"] = ExpressionConverter.ConvertO(bodycanShowHeader);
                    bodypropCount++;
                }

                if (bodyjsonMode != null)
                {
                    body["jsonMode"] = ExpressionConverter.ConvertO(bodyjsonMode);
                    bodypropCount++;
                }

                if (bodybackURL != null)
                {
                    body["backURL"] = ExpressionConverter.ConvertO(bodybackURL);
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
        [WorkflowExpressionFactory(nameof(__BuildListTransactions))]
        public IBodyWorkflowAction<ResponseListTransactions> ListTransactions([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseListTransactions> __BuildListTransactions(WorkflowValue<int> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ResponseListTransactions>(() =>
            {
                var apiCallPath = "/list-transactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
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
        [WorkflowExpressionFactory(nameof(__BuildMergePdfs))]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> MergePdfs([WorkflowExpression] Func<JToken[]> bodyurls, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyoutputFile = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> __BuildMergePdfs(WorkflowValue<JToken[]> bodyurls, WorkflowValue<int> bodyexpiration = null, WorkflowValue<string> bodyoutputFile = null)
        {
            WorkflowValue.Validate(bodyurls, nameof(bodyurls), required: true);
            WorkflowValue.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            WorkflowValue.Validate(bodyoutputFile, nameof(bodyoutputFile), required: false);
            return new DeferredBodyAction<ResponseSuccessSingleFile>(() =>
            {
                var apiCallPath = "/merge-pdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = ExpressionConverter.ConvertO(bodyurls);
                if (bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                    bodypropCount++;
                }

                if (bodyoutputFile != null)
                {
                    body["output_file"] = ExpressionConverter.ConvertO(bodyoutputFile);
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
        [WorkflowExpressionFactory(nameof(__BuildAddWatermark))]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> AddWatermark([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyfontSize = null, [WorkflowExpression] Func<int> bodyopacity = null, [WorkflowExpression] Func<int> bodyrotation = null, [WorkflowExpression] Func<string> bodyhexColor = null, [WorkflowExpression] Func<string> bodyfontFamily = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyoutputFile = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> __BuildAddWatermark(WorkflowValue<string> bodyurl, WorkflowValue<string> bodytext, WorkflowValue<int> bodyfontSize = null, WorkflowValue<int> bodyopacity = null, WorkflowValue<int> bodyrotation = null, WorkflowValue<string> bodyhexColor = null, WorkflowValue<string> bodyfontFamily = null, WorkflowValue<int> bodyexpiration = null, WorkflowValue<string> bodyoutputFile = null)
        {
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowValue.Validate(bodyfontSize, nameof(bodyfontSize), required: false);
            WorkflowValue.Validate(bodyopacity, nameof(bodyopacity), required: false);
            WorkflowValue.Validate(bodyrotation, nameof(bodyrotation), required: false);
            WorkflowValue.Validate(bodyhexColor, nameof(bodyhexColor), required: false);
            WorkflowValue.Validate(bodyfontFamily, nameof(bodyfontFamily), required: false);
            WorkflowValue.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            WorkflowValue.Validate(bodyoutputFile, nameof(bodyoutputFile), required: false);
            return new DeferredBodyAction<ResponseSuccessSingleFile>(() =>
            {
                var apiCallPath = "/add-watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodyfontSize != null)
                {
                    body["font_size"] = ExpressionConverter.ConvertO(bodyfontSize);
                    bodypropCount++;
                }

                if (bodyopacity != null)
                {
                    body["opacity"] = ExpressionConverter.ConvertO(bodyopacity);
                    bodypropCount++;
                }

                if (bodyrotation != null)
                {
                    body["rotation"] = ExpressionConverter.ConvertO(bodyrotation);
                    bodypropCount++;
                }

                if (bodyhexColor != null)
                {
                    body["hex_color"] = ExpressionConverter.ConvertO(bodyhexColor);
                    bodypropCount++;
                }

                if (bodyfontFamily != null)
                {
                    body["font_family"] = ExpressionConverter.ConvertO(bodyfontFamily);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                    bodypropCount++;
                }

                if (bodyoutputFile != null)
                {
                    body["output_file"] = ExpressionConverter.ConvertO(bodyoutputFile);
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
