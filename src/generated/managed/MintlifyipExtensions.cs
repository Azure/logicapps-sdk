//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mintlifyip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class MintlifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mintlifyip")]
        public IBodyWorkflowAction<DocGenResponse> DocGen(Expression<Func<bodylanguageInput>> bodylanguage, Expression<Func<string>> bodycode, Expression<Func<bool>> bodycommented = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<string>> bodycontext = null)
        {
            var __workflow_bodylanguage = bodylanguage == null ? null : WorkflowExpression.Compile(bodylanguage);
            WorkflowExpression.Validate(__workflow_bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodycode = bodycode == null ? null : WorkflowExpression.Compile(bodycode);
            WorkflowExpression.Validate(__workflow_bodycode, nameof(bodycode), required: true);
            var __workflow_bodycommented = bodycommented == null ? null : WorkflowExpression.Compile(bodycommented);
            WorkflowExpression.Validate(__workflow_bodycommented, nameof(bodycommented), required: false);
            var __workflow_bodyformat = bodyformat == null ? null : WorkflowExpression.Compile(bodyformat);
            WorkflowExpression.Validate(__workflow_bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodycontext = bodycontext == null ? null : WorkflowExpression.Compile(bodycontext);
            WorkflowExpression.Validate(__workflow_bodycontext, nameof(bodycontext), required: false);
            return new DeferredBodyAction<DocGenResponse>(() =>
            {
                var apiCallPath = "/v1/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycommented != null)
                {
                    if (__workflow_bodycommented != null)
                    {
                        body["commented"] = ExpressionConverter.ConvertO(__workflow_bodycommented);
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
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                if (__workflow_bodyformat != null)
                {
                    body["format"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                    bodypropCount++;
                }

                if (__workflow_bodycontext != null)
                {
                    body["context"] = ExpressionConverter.ConvertO(__workflow_bodycontext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DocGenResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
