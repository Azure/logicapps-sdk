//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cmi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CmiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cmi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HttpRequest(Expression<Func<string>> xCMITENANTNAME, Expression<Func<HttpRequestInput>> parameters)
        {
            var __workflow_xCMITENANTNAME = WorkflowExpression.Compile(xCMITENANTNAME, nameof(xCMITENANTNAME), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/virtual/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-CMI-TENANT-NAME"] = ExpressionConverter.Convert(__workflow_xCMITENANTNAME);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CmiTriggers([ConnectionName] string connectionId)
    {
    }

    public class HttpRequestInput
    {
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        public HttpRequestInputMethodType Method { get; set; } = HttpRequestInputMethodType.GET;

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HttpRequestInputMethodType
    {
        GET,
        PUT,
        POST,
        PATCH,
        DELETE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cmi;

    public partial class WorkflowManagedActions
    {
        public CmiActions Cmi(string connectionId) => new CmiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CmiTriggers Cmi(string connectionId) => new CmiTriggers(connectionId);
    }
}