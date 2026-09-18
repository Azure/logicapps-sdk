//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tulip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TulipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        public IBodyWorkflowAction<JToken> CreateRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tableId, [WorkflowExpression] Func<object> dynamicTableSchema = null)
        {
            var apiCallPath = String.Format("/tables/{0}/records", ExpressionConverter.ConvertWithUrlEncoding(tableId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicTableSchema);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        public IBodyWorkflowAction<JToken> GetRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tableId, [WorkflowExpression] Func<string> recordId)
        {
            var apiCallPath = String.Format("/tables/{0}/records/{1}", ExpressionConverter.ConvertWithUrlEncoding(tableId, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        public IBodyWorkflowAction<JToken> UpdateRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tableId, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> dynamicTableSchema = null)
        {
            var apiCallPath = String.Format("/tables/{0}/records/{1}", ExpressionConverter.ConvertWithUrlEncoding(tableId, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicTableSchema);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class TulipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tulip;

    public partial class WorkflowManagedActions
    {
        public TulipActions Tulip(string connectionId) => new TulipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TulipTriggers Tulip(string connectionId) => new TulipTriggers(connectionId);
    }
}