//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Peltarion
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PeltarionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "peltarion")]
        public IBodyWorkflowAction<CallapiResponse> Callapi([WorkflowExpression] Func<string> peltarionbody)
        {
            SourceExpression.Validate(peltarionbody, nameof(peltarionbody), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/forwardcall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["peltarionbody"] = SourceExpressionConverter.ConvertO(peltarionbody);
                return callPayload;
            }

            return new ApiConnectionAction<CallapiResponse>(BuildSourceInput);
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