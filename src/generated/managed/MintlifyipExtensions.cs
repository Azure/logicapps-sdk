//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mintlifyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MintlifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mintlifyip")]
        public IBodyWorkflowAction<DocGenResponse> DocGen([WorkflowExpression] Func<bodylanguageInput> bodylanguage, [WorkflowExpression] Func<string> bodycode, [WorkflowExpression] Func<bool> bodycommented = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<string> bodycontext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycommented != null)
                {
                    if (bodycommented != null)
                    {
                        body["commented"] = SourceExpressionConverter.ConvertToken(bodycommented);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["commented"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["language"] = SourceExpressionConverter.Convert(bodylanguage);
                bodypropCount++;
                body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                if (bodyformat != null)
                {
                    body["format"] = SourceExpressionConverter.Convert(bodyformat);
                    bodypropCount++;
                }

                if (bodycontext != null)
                {
                    body["context"] = SourceExpressionConverter.ConvertToken(bodycontext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocGenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mintlifyip")]
        public IBodyWorkflowAction<LanguageListResponse> LanguageList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/list/languages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LanguageListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mintlifyip")]
        public IBodyWorkflowAction<DocListResponse> DocList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/list/formats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DocListResponse>(BuildSourceInput);
        }
    }

    public class MintlifyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class DocGenResponse
    {
        [JsonProperty("documentation")]
        public string Documentation { get; set; }
    }

    public enum bodylanguageInput
    {
        [EnumMember(Value = "javascript")]
        Javascript,
        [EnumMember(Value = "typescript")]
        Typescript,
        [EnumMember(Value = "javascriptreact")]
        Javascriptreact,
        [EnumMember(Value = "typescriptreact")]
        Typescriptreact,
        [EnumMember(Value = "python")]
        Python,
        [EnumMember(Value = "php")]
        Php
    }

    public enum bodyformatInput
    {
        [EnumMember(Value = "")]
        None,
        JSDoc,
        [EnumMember(Value = "reST")]
        ReST,
        DocBlock,
        Google
    }

    public class LanguageListResponse
    {
        [JsonProperty("languages")]
        public string[] Languages { get; set; }
    }

    public class DocListResponse
    {
        [JsonProperty("formats")]
        public DocListResponseFormatsTypeItem[] Formats { get; set; }
    }

    public class DocListResponseFormatsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("defaultLanguages")]
        public string[] DefaultLanguages { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mintlifyip;

    public partial class WorkflowManagedActions
    {
        public MintlifyipActions Mintlifyip(string connectionId) => new MintlifyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MintlifyipTriggers Mintlifyip(string connectionId) => new MintlifyipTriggers(connectionId);
    }
}