//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Didyoumeanthisip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DidyoumeanthisipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "didyoumeanthisip")]
        public IBodyWorkflowAction<CheckResponse> Check([WorkflowExpression] Func<string> q)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/did_you_mean_this";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<CheckResponse>(BuildSourceInput);
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