//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Translatorv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Translatorv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "translatorv2")]
        public IBodyWorkflowAction<Language[], ApiConnectionActionConfiguration> Languages()
        {
            return new DeferredBodyAction<Language[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Languages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["scope"] = Convert.ToString("translation");
                return new ApiConnectionAction<Language[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "translatorv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Translate(Expression<Func<string>> to, Expression<Func<TranslateInput>> body, Expression<Func<string>> from = null, Expression<Func<string>> category = null, Expression<Func<textTypeInput>> textType = null)
        {
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_textType = WorkflowExpression.Compile(textType, nameof(textType), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_textType != null)
                    callPayload.Queries["textType"] = ExpressionConverter.Convert(__workflow_textType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "translatorv2")]
        public IBodyWorkflowAction<Language, ApiConnectionActionConfiguration> Detect(Expression<Func<DetectInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Language, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Language>(callPayload);
            });
        }
    }

    public class Translatorv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class Language
    {
        [JsonProperty("Code")]
        public string LanguageCode { get; set; }

        [JsonProperty("Name")]
        public string LanguageName { get; set; }
    }

    public class TranslateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum textTypeInput
    {
        [EnumMember(Value = "plain")]
        Plain,
        [EnumMember(Value = "html")]
        Html
    }

    public class DetectInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Translatorv2;

    public partial class WorkflowManagedActions
    {
        public Translatorv2Actions Translatorv2(string connectionId) => new Translatorv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Translatorv2Triggers Translatorv2(string connectionId) => new Translatorv2Triggers(connectionId);
    }
}