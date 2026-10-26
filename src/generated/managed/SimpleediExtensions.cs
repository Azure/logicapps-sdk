//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Simpleedi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SimpleediActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EdiToJson(Expression<Func<EdiToJsonInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EdiToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> XmlToXml(Expression<Func<XmlToXmlInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EdiToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class SimpleediTriggers([ConnectionName] string connectionId)
    {
    }

    public class EdiToJsonInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class XmlToXmlInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Simpleedi;

    public partial class WorkflowManagedActions
    {
        public SimpleediActions Simpleedi(string connectionId) => new SimpleediActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SimpleediTriggers Simpleedi(string connectionId) => new SimpleediTriggers(connectionId);
    }
}