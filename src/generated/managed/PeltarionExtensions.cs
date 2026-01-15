//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Peltarion
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PeltarionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "peltarion")]
        public IBodyWorkflowAction<CallapiResponse> Callapi(Expression<Func<string>> peltarionbody)
        {
            var apiCallPath = "/api/forwardcall";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["peltarionbody"] = ExpressionConverter.Convert(peltarionbody);
            return new ApiConnectionAction<CallapiResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Peltarion;

    public partial class WorkflowManagedActions
    {
        public PeltarionActions Peltarion(string connectionId) => new PeltarionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PeltarionTriggers Peltarion(string connectionId) => new PeltarionTriggers(connectionId);
    }
}