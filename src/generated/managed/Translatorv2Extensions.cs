//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Translatorv2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Translatorv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "translatorv2")]
        public IBodyWorkflowAction<Language[]> Languages()
        {
            var apiCallPath = "/Languages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["scope"] = Convert.ToString("translation");
            return new ApiConnectionAction<Language[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "translatorv2")]
        public IBodyWorkflowAction<string> Translate(Expression<Func<string>> to, Expression<Func<string>> bodytext, Expression<Func<string>> from = null, Expression<Func<string>> category = null, Expression<Func<textTypeInput>> textType = null)
        {
            var __workflow_to = to == null ? null : WorkflowExpression.Compile(to);
            WorkflowExpression.Validate(__workflow_to, nameof(to), required: true);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: true);
            var __workflow_from = from == null ? null : WorkflowExpression.Compile(from);
            WorkflowExpression.Validate(__workflow_from, nameof(from), required: false);
            var __workflow_category = category == null ? null : WorkflowExpression.Compile(category);
            WorkflowExpression.Validate(__workflow_category, nameof(category), required: false);
            var __workflow_textType = textType == null ? null : WorkflowExpression.Compile(textType);
            WorkflowExpression.Validate(__workflow_textType, nameof(textType), required: false);
            return new DeferredBodyAction<string>(() =>
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
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "translatorv2")]
        public IBodyWorkflowAction<Language> Detect(Expression<Func<string>> bodytext)
        {
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<Language>(() =>
            {
                var apiCallPath = "/Detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum textTypeInput
    {
        [EnumMember(Value = "plain")]
        Plain,
        [EnumMember(Value = "html")]
        Html
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
