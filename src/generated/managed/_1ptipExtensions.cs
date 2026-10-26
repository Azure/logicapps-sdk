//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._1ptip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _1ptipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1ptip")]
        public IBodyWorkflowAction<URLGetResponse, ApiConnectionActionConfiguration> URLGet(Expression<Func<string>> @long, Expression<Func<string>> @short = null)
        {
            var __workflow_long = WorkflowExpression.Compile(@long, nameof(@long), required: true);
            var __workflow_short = WorkflowExpression.Compile(@short, nameof(@short), required: false);
            return new DeferredBodyAction<URLGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addURL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["long"] = ExpressionConverter.Convert(__workflow_long);
                if (__workflow_short != null)
                    callPayload.Queries["short"] = ExpressionConverter.Convert(__workflow_short);
                return new ApiConnectionAction<URLGetResponse>(callPayload);
            });
        }
    }

    public class _1ptipTriggers([ConnectionName] string connectionId)
    {
    }

    public class URLGetResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._1ptip;

    public partial class WorkflowManagedActions
    {
        public _1ptipActions _1ptip(string connectionId) => new _1ptipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _1ptipTriggers _1ptip(string connectionId) => new _1ptipTriggers(connectionId);
    }
}