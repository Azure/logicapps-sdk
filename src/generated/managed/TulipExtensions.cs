//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tulip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TulipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateRecord(Expression<Func<string>> tableId, Expression<Func<object>> dynamicTableSchema)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_dynamicTableSchema = WorkflowExpression.Compile(dynamicTableSchema, nameof(dynamicTableSchema), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tables/{0}/records", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicTableSchema);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetRecord(Expression<Func<string>> tableId, Expression<Func<string>> recordId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tables/{0}/records/{1}", __workflow_tableId.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateRecord(Expression<Func<string>> tableId, Expression<Func<string>> recordId, Expression<Func<object>> dynamicTableSchema)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_dynamicTableSchema = WorkflowExpression.Compile(dynamicTableSchema, nameof(dynamicTableSchema), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tables/{0}/records/{1}", __workflow_tableId.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicTableSchema);
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