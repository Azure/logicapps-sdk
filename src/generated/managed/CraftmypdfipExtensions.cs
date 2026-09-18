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
        public IBodyWorkflowAction<ResponseSuccessSingleFile> Create([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodyexportType = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyoutputFile = null, [WorkflowExpression] Func<bool> bodyisCmyk = null)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            SourceExpression.Validate(bodyexportType, nameof(bodyexportType), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyoutputFile, nameof(bodyoutputFile), required: false);
            SourceExpression.Validate(bodyisCmyk, nameof(bodyisCmyk), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
                body["template_id"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
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

                if (bodyoutputFile != null)
                {
                    body["output_file"] = SourceExpressionConverter.ConvertToken(bodyoutputFile);
                    bodypropCount++;
                }

                if (bodyisCmyk != null)
                {
                    body["is_cmyk"] = SourceExpressionConverter.ConvertToken(bodyisCmyk);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> CreateMerge([WorkflowExpression] Func<JToken[]> bodytemplates, [WorkflowExpression] Func<string> bodyexportType = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyoutputFile = null, [WorkflowExpression] Func<string> bodypaging = null)
        {
            SourceExpression.Validate(bodytemplates, nameof(bodytemplates), required: true);
            SourceExpression.Validate(bodyexportType, nameof(bodyexportType), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyoutputFile, nameof(bodyoutputFile), required: false);
            SourceExpression.Validate(bodypaging, nameof(bodypaging), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create-merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["templates"] = SourceExpressionConverter.ConvertToken(bodytemplates);
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

                if (bodyoutputFile != null)
                {
                    body["output_file"] = SourceExpressionConverter.ConvertToken(bodyoutputFile);
                    bodypropCount++;
                }

                if (bodypaging != null)
                {
                    body["paging"] = SourceExpressionConverter.ConvertToken(bodypaging);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseListTemplate> ListTemplates([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/list-templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseListTemplate>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessCreateNewTemplate> NewTemplateFrom([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/new-template-from";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccessCreateNewTemplate>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseUpdateTemplate> UpdateTemplate([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyjson = null)
        {
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyjson, nameof(bodyjson), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/update-template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyjson != null)
                {
                    body["json"] = SourceExpressionConverter.ConvertToken(bodyjson);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseUpdateTemplate>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessDeleteTemplate> DeleteTemplate([WorkflowExpression] Func<string> templateId)
        {
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/delete-template";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccessDeleteTemplate>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessCreateNewEditorSession> CreateEditorSession([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<bool> bodycanSave = null, [WorkflowExpression] Func<bool> bodycanCreatePDF = null, [WorkflowExpression] Func<bool> bodycanViewSettings = null, [WorkflowExpression] Func<bool> bodycanPreview = null, [WorkflowExpression] Func<bool> bodycanEditJSON = null, [WorkflowExpression] Func<bool> bodycanShowHeader = null, [WorkflowExpression] Func<int> bodyjsonMode = null, [WorkflowExpression] Func<string> bodybackURL = null)
        {
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            SourceExpression.Validate(bodycanSave, nameof(bodycanSave), required: false);
            SourceExpression.Validate(bodycanCreatePDF, nameof(bodycanCreatePDF), required: false);
            SourceExpression.Validate(bodycanViewSettings, nameof(bodycanViewSettings), required: false);
            SourceExpression.Validate(bodycanPreview, nameof(bodycanPreview), required: false);
            SourceExpression.Validate(bodycanEditJSON, nameof(bodycanEditJSON), required: false);
            SourceExpression.Validate(bodycanShowHeader, nameof(bodycanShowHeader), required: false);
            SourceExpression.Validate(bodyjsonMode, nameof(bodyjsonMode), required: false);
            SourceExpression.Validate(bodybackURL, nameof(bodybackURL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create-editor-session";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template_id"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                var expirationObject = new JObject();
                var expirationObjectpropCount = 0;
                if (expirationObjectpropCount > 0)
                {
                    body["expiration"] = expirationObject;
                    bodypropCount++;
                }

                if (bodycanSave != null)
                {
                    body["canSave"] = SourceExpressionConverter.ConvertToken(bodycanSave);
                    bodypropCount++;
                }

                if (bodycanCreatePDF != null)
                {
                    body["canCreatePDF"] = SourceExpressionConverter.ConvertToken(bodycanCreatePDF);
                    bodypropCount++;
                }

                if (bodycanViewSettings != null)
                {
                    body["canViewSettings"] = SourceExpressionConverter.ConvertToken(bodycanViewSettings);
                    bodypropCount++;
                }

                if (bodycanPreview != null)
                {
                    body["canPreview"] = SourceExpressionConverter.ConvertToken(bodycanPreview);
                    bodypropCount++;
                }

                if (bodycanEditJSON != null)
                {
                    body["canEditJSON"] = SourceExpressionConverter.ConvertToken(bodycanEditJSON);
                    bodypropCount++;
                }

                if (bodycanShowHeader != null)
                {
                    body["canShowHeader"] = SourceExpressionConverter.ConvertToken(bodycanShowHeader);
                    bodypropCount++;
                }

                if (bodyjsonMode != null)
                {
                    body["jsonMode"] = SourceExpressionConverter.ConvertToken(bodyjsonMode);
                    bodypropCount++;
                }

                if (bodybackURL != null)
                {
                    body["backURL"] = SourceExpressionConverter.ConvertToken(bodybackURL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSuccessCreateNewEditorSession>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseListTransactions> ListTransactions([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/list-transactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseListTransactions>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseAccountInformation> GetAccountInfo()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/get-account-info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseAccountInformation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> MergePdfs([WorkflowExpression] Func<JToken[]> bodyurls, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyoutputFile = null)
        {
            SourceExpression.Validate(bodyurls, nameof(bodyurls), required: true);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyoutputFile, nameof(bodyoutputFile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/merge-pdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = SourceExpressionConverter.ConvertToken(bodyurls);
                if (bodyexpiration != null)
                {
                    body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                    bodypropCount++;
                }

                if (bodyoutputFile != null)
                {
                    body["output_file"] = SourceExpressionConverter.ConvertToken(bodyoutputFile);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "craftmypdfip")]
        public IBodyWorkflowAction<ResponseSuccessSingleFile> AddWatermark([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyfontSize = null, [WorkflowExpression] Func<int> bodyopacity = null, [WorkflowExpression] Func<int> bodyrotation = null, [WorkflowExpression] Func<string> bodyhexColor = null, [WorkflowExpression] Func<string> bodyfontFamily = null, [WorkflowExpression] Func<int> bodyexpiration = null, [WorkflowExpression] Func<string> bodyoutputFile = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodyfontSize, nameof(bodyfontSize), required: false);
            SourceExpression.Validate(bodyopacity, nameof(bodyopacity), required: false);
            SourceExpression.Validate(bodyrotation, nameof(bodyrotation), required: false);
            SourceExpression.Validate(bodyhexColor, nameof(bodyhexColor), required: false);
            SourceExpression.Validate(bodyfontFamily, nameof(bodyfontFamily), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyoutputFile, nameof(bodyoutputFile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add-watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodyfontSize != null)
                {
                    body["font_size"] = SourceExpressionConverter.ConvertToken(bodyfontSize);
                    bodypropCount++;
                }

                if (bodyopacity != null)
                {
                    body["opacity"] = SourceExpressionConverter.ConvertToken(bodyopacity);
                    bodypropCount++;
                }

                if (bodyrotation != null)
                {
                    body["rotation"] = SourceExpressionConverter.ConvertToken(bodyrotation);
                    bodypropCount++;
                }

                if (bodyhexColor != null)
                {
                    body["hex_color"] = SourceExpressionConverter.ConvertToken(bodyhexColor);
                    bodypropCount++;
                }

                if (bodyfontFamily != null)
                {
                    body["font_family"] = SourceExpressionConverter.ConvertToken(bodyfontFamily);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                    bodypropCount++;
                }

                if (bodyoutputFile != null)
                {
                    body["output_file"] = SourceExpressionConverter.ConvertToken(bodyoutputFile);
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