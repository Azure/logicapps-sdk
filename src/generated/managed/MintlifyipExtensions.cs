//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mintlifyip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MintlifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mintlifyip")]
        public IBodyWorkflowAction<DocGenResponse, ApiConnectionActionConfiguration> DocGen(Expression<Func<DocGenInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DocGenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DocGenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mintlifyip")]
        public IBodyWorkflowAction<LanguageListResponse, ApiConnectionActionConfiguration> LanguageList()
        {
            return new DeferredBodyAction<LanguageListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/list/languages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LanguageListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mintlifyip")]
        public IBodyWorkflowAction<DocListResponse, ApiConnectionActionConfiguration> DocList()
        {
            return new DeferredBodyAction<DocListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/list/formats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocListResponse>(callPayload);
            });
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

    public class DocGenInput
    {
        [JsonProperty("commented", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Commented { get; set; } = true;

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocGenInputLanguageType Language { get; set; } = DocGenInputLanguageType.Javascript;

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("format")]
        public DocGenInputFormatType? Format { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocGenInputLanguageType
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
    public enum DocGenInputFormatType
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