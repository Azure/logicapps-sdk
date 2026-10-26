//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Httpv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Httpv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "httpv2")]
        public IBodyWorkflowAction<HttpResponse, ApiConnectionActionConfiguration> InvokeHttpRequest(Expression<Func<InvokeHttpRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<HttpResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/InvokeHttpRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<HttpResponse>(callPayload);
            });
        }
    }

    public class Httpv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class HttpResponse
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("headers")]
        public KeyValue[] Headers { get; set; }

        [JsonProperty("body")]
        public JToken Body { get; set; }
    }

    public class KeyValue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class InvokeHttpRequestInput
    {
        [JsonProperty("headers")]
        public KeyValue[] Headers { get; set; }

        [JsonProperty("queryParameters")]
        public KeyValue[] QueryParameters { get; set; }

        [JsonProperty("body")]
        public JToken Body { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Httpv2;

    public partial class WorkflowManagedActions
    {
        public Httpv2Actions Httpv2(string connectionId) => new Httpv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Httpv2Triggers Httpv2(string connectionId) => new Httpv2Triggers(connectionId);
    }
}