//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Peltarion
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PeltarionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "peltarion")]
        [WorkflowExpressionFactory(nameof(__BuildCallapi))]
        public IBodyWorkflowAction<CallapiResponse> Callapi([WorkflowExpression] Func<string> peltarionbody)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallapiResponse> __BuildCallapi(WorkflowValue<string> peltarionbody)
        {
            WorkflowValue.Validate(peltarionbody, nameof(peltarionbody), required: true);
            return new DeferredBodyAction<CallapiResponse>(() =>
            {
                var apiCallPath = "/api/forwardcall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["peltarionbody"] = ExpressionConverter.Convert(peltarionbody);
                return new ApiConnectionAction<CallapiResponse>(callPayload);
            });
        }
    }

    public class PeltarionTriggers([ConnectionName] string connectionId)
    {
    }

    public class CallapiResponse
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("val")]
        public string Val { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Peltarion;

    public partial class WorkflowManagedActions
    {
        public PeltarionActions Peltarion(string connectionId) => new PeltarionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PeltarionTriggers Peltarion(string connectionId) => new PeltarionTriggers(connectionId);
    }
}
