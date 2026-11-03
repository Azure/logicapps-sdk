//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Odata
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetEntityData(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<double>> top = null, Expression<Func<double>> skip = null, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null)
        {
            var __workflow_odataUri = WorkflowExpression.Compile(odataUri, nameof(odataUri), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getentitydata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(__workflow_odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetSchema(Expression<Func<string>> odataUri, Expression<Func<string>> entity)
        {
            var __workflow_odataUri = WorkflowExpression.Compile(odataUri, nameof(odataUri), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getschema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(__workflow_odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetSingleSchema(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<int>> option = null)
        {
            var __workflow_odataUri = WorkflowExpression.Compile(odataUri, nameof(odataUri), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_option = WorkflowExpression.Compile(option, nameof(option), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getsingleschema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(__workflow_odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                if (__workflow_option != null)
                    callPayload.Queries["option"] = ExpressionConverter.Convert(__workflow_option);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var __workflow_odataUri = WorkflowExpression.Compile(odataUri, nameof(odataUri), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_entryInput = WorkflowExpression.Compile(entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(__workflow_odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var __workflow_odataUri = WorkflowExpression.Compile(odataUri, nameof(odataUri), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_entryInput = WorkflowExpression.Compile(entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(__workflow_odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var __workflow_odataUri = WorkflowExpression.Compile(odataUri, nameof(odataUri), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_entryInput = WorkflowExpression.Compile(entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(__workflow_odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var __workflow_odataUri = WorkflowExpression.Compile(odataUri, nameof(odataUri), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_entryInput = WorkflowExpression.Compile(entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(__workflow_odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class OdataTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Odata;

    public partial class WorkflowManagedActions
    {
        public OdataActions Odata(string connectionId) => new OdataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OdataTriggers Odata(string connectionId) => new OdataTriggers(connectionId);
    }
}