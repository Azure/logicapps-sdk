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
        public IBodyWorkflowAction<HttpResponse, ApiConnectionActionConfiguration> InvokeHttpRequest(Expression<Func<KeyValue[]>> requestheaders = null, Expression<Func<KeyValue[]>> requestqueryParameters = null, Expression<Func<object>> requestbody = null)
        {
            var __workflow_requestheaders = WorkflowExpression.Compile(requestheaders, nameof(requestheaders), required: false);
            var __workflow_requestqueryParameters = WorkflowExpression.Compile(requestqueryParameters, nameof(requestqueryParameters), required: false);
            var __workflow_requestbody = WorkflowExpression.Compile(requestbody, nameof(requestbody), required: false);
            return new DeferredBodyAction<HttpResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/InvokeHttpRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestheaders != null)
                {
                    request["headers"] = ExpressionConverter.ConvertO(__workflow_requestheaders);
                    requestpropCount++;
                }

                if (__workflow_requestqueryParameters != null)
                {
                    request["queryParameters"] = ExpressionConverter.ConvertO(__workflow_requestqueryParameters);
                    requestpropCount++;
                }

                if (__workflow_requestbody != null)
                {
                    request["body"] = ExpressionConverter.ConvertO(__workflow_requestbody);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

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