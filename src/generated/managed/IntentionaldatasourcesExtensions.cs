//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Intentionaldatasources
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}", __workflow_service.WithUrlEncoding(1), __workflow_entity.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(__workflow_oDataQuery);
                return new ApiConnectionAction<SingleEntity>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}", __workflow_service.WithUrlEncoding(1), __workflow_entity.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(__workflow_oDataQuery);
                return new ApiConnectionAction<SingleEntity>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/list", __workflow_service.WithUrlEncoding(1), __workflow_entity.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(__workflow_oDataQuery);
                return new ApiConnectionAction<ListEntity>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}/list", __workflow_service.WithUrlEncoding(1), __workflow_entity.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(__workflow_oDataQuery);
                return new ApiConnectionAction<ListEntity>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
