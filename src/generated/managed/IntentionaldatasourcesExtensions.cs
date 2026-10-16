//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Intentionaldatasources
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IntentionaldatasourcesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<SingleEntity> SingleEntity(Expression<Func<string>> token, Expression<Func<string>> service, Expression<Func<string>> entity, Expression<Func<string>> id = null, Expression<Func<string>> oDataQuery = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_service = WorkflowExpression.Compile(service, nameof(service), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_oDataQuery = WorkflowExpression.Compile(oDataQuery, nameof(oDataQuery), required: false);
            return new DeferredBodyAction<SingleEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_service, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_entity, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(__workflow_oDataQuery);
                return new ApiConnectionAction<SingleEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<SingleEntity> SingleEntityById(Expression<Func<string>> token, Expression<Func<string>> service, Expression<Func<string>> entity, Expression<Func<string>> id, Expression<Func<string>> oDataQuery = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_service = WorkflowExpression.Compile(service, nameof(service), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_oDataQuery = WorkflowExpression.Compile(oDataQuery, nameof(oDataQuery), required: false);
            return new DeferredBodyAction<SingleEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_service, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_entity, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(__workflow_oDataQuery);
                return new ApiConnectionAction<SingleEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<ListEntity> ListEntity(Expression<Func<string>> token, Expression<Func<string>> service, Expression<Func<string>> entity, Expression<Func<string>> id = null, Expression<Func<string>> oDataQuery = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_service = WorkflowExpression.Compile(service, nameof(service), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_oDataQuery = WorkflowExpression.Compile(oDataQuery, nameof(oDataQuery), required: false);
            return new DeferredBodyAction<ListEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/list", ExpressionConverter.ConvertWithUrlEncoding(__workflow_service, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_entity, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(__workflow_oDataQuery);
                return new ApiConnectionAction<ListEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<ListEntity> ListEntityById(Expression<Func<string>> token, Expression<Func<string>> service, Expression<Func<string>> entity, Expression<Func<string>> id, Expression<Func<string>> oDataQuery = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_service = WorkflowExpression.Compile(service, nameof(service), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_oDataQuery = WorkflowExpression.Compile(oDataQuery, nameof(oDataQuery), required: false);
            return new DeferredBodyAction<ListEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}/list", ExpressionConverter.ConvertWithUrlEncoding(__workflow_service, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_entity, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(__workflow_oDataQuery);
                return new ApiConnectionAction<ListEntity>(callPayload);
            });
        }
    }

    public class IntentionaldatasourcesTriggers([ConnectionName] string connectionId)
    {
    }

    public class SingleEntity
    {
        public JToken DynamicProperties { get; set; }
    }

    public class ListEntity
    {
        public JToken DynamicProperties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Intentionaldatasources;

    public partial class WorkflowManagedActions
    {
        public IntentionaldatasourcesActions Intentionaldatasources(string connectionId) => new IntentionaldatasourcesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IntentionaldatasourcesTriggers Intentionaldatasources(string connectionId) => new IntentionaldatasourcesTriggers(connectionId);
    }
}
