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
        public IBodyWorkflowAction<DocGenResponse> DocGen(Expression<Func<bodylanguageInput>> bodylanguage, Expression<Func<string>> bodycode, Expression<Func<bool>> bodycommented = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<string>> bodycontext = null)
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
                    body["commented"] = ExpressionConverter.ConvertO(bodycommented);
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
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["code"] = ExpressionConverter.ConvertO(bodycode);
            if (bodyformat != null)
            {
                body["format"] = ExpressionConverter.ConvertO(bodyformat);
                bodypropCount++;
            }

            if (bodycontext != null)
            {
                body["context"] = ExpressionConverter.ConvertO(bodycontext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DocGenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mintlifyip")]
        public IBodyWorkflowAction<LanguageListResponse> LanguageList()
        {
            var apiCallPath = "/v1/list/languages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LanguageListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mintlifyip")]
        public IBodyWorkflowAction<DocListResponse> DocList()
        {
            var apiCallPath = "/v1/list/formats";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocListResponse>(callPayload);
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