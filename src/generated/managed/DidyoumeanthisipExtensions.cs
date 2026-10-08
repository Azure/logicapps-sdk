//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Didyoumeanthisip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DidyoumeanthisipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "didyoumeanthisip")]
        [WorkflowExpressionFactory(nameof(__BuildCheck))]
        public IBodyWorkflowAction<CheckResponse> Check([WorkflowExpression] Func<string> q)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckResponse> __BuildCheck(WorkflowExpression<string> q)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            return new DeferredBodyAction<CheckResponse>(() =>
            {
                var apiCallPath = "/did_you_mean_this";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionAction<CheckResponse>(callPayload);
            });
        }
    }

    public class DidyoumeanthisipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CheckResponse
    {
        [JsonProperty("is_modified")]
        public bool IsModified { get; set; }

        [JsonProperty("original_text")]
        public string OriginalText { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Didyoumeanthisip;

    public partial class WorkflowManagedActions
    {
        public DidyoumeanthisipActions Didyoumeanthisip(string connectionId) => new DidyoumeanthisipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DidyoumeanthisipTriggers Didyoumeanthisip(string connectionId) => new DidyoumeanthisipTriggers(connectionId);
    }
}