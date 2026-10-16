//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tulip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TulipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        public IBodyWorkflowAction<JToken> CreateRecord(Expression<Func<string>> tableId, Expression<Func<object>> dynamicTableSchema = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_dynamicTableSchema = WorkflowExpression.Compile(dynamicTableSchema, nameof(dynamicTableSchema), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tables/{0}/records", ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicTableSchema);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        public IBodyWorkflowAction<JToken> GetRecord(Expression<Func<string>> tableId, Expression<Func<string>> recordId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tables/{0}/records/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tulip")]
        public IBodyWorkflowAction<JToken> UpdateRecord(Expression<Func<string>> tableId, Expression<Func<string>> recordId, Expression<Func<object>> dynamicTableSchema = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_dynamicTableSchema = WorkflowExpression.Compile(dynamicTableSchema, nameof(dynamicTableSchema), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tables/{0}/records/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 1));
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
