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
        [WorkflowExpressionFactory(nameof(__BuildCreateRecord))]
        public IBodyWorkflowAction<JToken> CreateRecord([WorkflowExpression] Func<string> tableId, [WorkflowExpression] Func<object> dynamicTableSchema = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateRecord(WorkflowValue<string> tableId, WorkflowValue<object> dynamicTableSchema = null)
        {
            WorkflowValue.Validate(tableId, nameof(tableId), required: true);
            WorkflowValue.Validate(dynamicTableSchema, nameof(dynamicTableSchema), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tables/{0}/records", ExpressionConverter.ConvertWithUrlEncoding(tableId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(dynamicTableSchema);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecord))]
        public IBodyWorkflowAction<JToken> GetRecord([WorkflowExpression] Func<string> tableId, [WorkflowExpression] Func<string> recordId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetRecord(WorkflowValue<string> tableId, WorkflowValue<string> recordId)
        {
            WorkflowValue.Validate(tableId, nameof(tableId), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tables/{0}/records/{1}", ExpressionConverter.ConvertWithUrlEncoding(tableId, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRecord))]
        public IBodyWorkflowAction<JToken> UpdateRecord([WorkflowExpression] Func<string> tableId, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> dynamicTableSchema = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateRecord(WorkflowValue<string> tableId, WorkflowValue<string> recordId, WorkflowValue<object> dynamicTableSchema = null)
        {
            WorkflowValue.Validate(tableId, nameof(tableId), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(dynamicTableSchema, nameof(dynamicTableSchema), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tables/{0}/records/{1}", ExpressionConverter.ConvertWithUrlEncoding(tableId, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(dynamicTableSchema);
                return new ApiConnectionAction<JToken>(callPayload);
            });
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
