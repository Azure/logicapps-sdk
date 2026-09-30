//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Translatorv2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        public IBodyWorkflowAction<string> Translate([WorkflowExpression] Func<string> to, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<textTypeInput> textType = null)
        {
            var apiCallPath = "/Translate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["to"] = ExpressionConverter.Convert(to);
            if (from != null)
                callPayload.Queries["from"] = ExpressionConverter.Convert(from);
            if (category != null)
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            if (textType != null)
                callPayload.Queries["textType"] = ExpressionConverter.Convert(textType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "translatorv2")]
        public IBodyWorkflowAction<Language> Detect([WorkflowExpression] Func<string> bodytext)
        {
            var apiCallPath = "/Detect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Language>(callPayload);
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