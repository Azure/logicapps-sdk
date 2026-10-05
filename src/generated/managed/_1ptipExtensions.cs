//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._1ptip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _1ptipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1ptip")]
        [WorkflowExpressionFactory(nameof(__BuildURLGet))]
        public IBodyWorkflowAction<URLGetResponse> URLGet([WorkflowExpression] Func<string> @long, [WorkflowExpression] Func<string> @short = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<URLGetResponse> __BuildURLGet(WorkflowValue<string> @long, WorkflowValue<string> @short = null)
        {
            WorkflowValue.Validate(@long, nameof(@long), required: true);
            WorkflowValue.Validate(@short, nameof(@short), required: false);
            return new DeferredBodyAction<URLGetResponse>(() =>
            {
                var apiCallPath = "/addURL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["long"] = ExpressionConverter.Convert(@long);
                if (@short != null)
                    callPayload.Queries["short"] = ExpressionConverter.Convert(@short);
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
