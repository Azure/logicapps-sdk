//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webcontentsv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Webcontentsv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webcontentsv2")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InvokeHttp(Expression<Func<InvokeHttpInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/InvokeHttp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class Webcontentsv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class InvokeHttpInput
    {
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        public InvokeHttpInputMethodType Method { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UrlOfTheRequest { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("body")]
        public string BodyOfTheRequest { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvokeHttpInputMethodType
    {
        GET,
        DELETE,
        PATCH,
        POST,
        PUT
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Webcontentsv2;

    public partial class WorkflowManagedActions
    {
        public Webcontentsv2Actions Webcontentsv2(string connectionId) => new Webcontentsv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Webcontentsv2Triggers Webcontentsv2(string connectionId) => new Webcontentsv2Triggers(connectionId);
    }
}