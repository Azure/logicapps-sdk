//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Odata
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class OdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken[]> GetEntityData(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<double>> top = null, Expression<Func<double>> skip = null, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null)
        {
            var __workflow_odataUri = odataUri == null ? null : WorkflowExpression.Compile(odataUri);
            WorkflowExpression.Validate(__workflow_odataUri, nameof(odataUri), required: true);
            var __workflow_entity = entity == null ? null : WorkflowExpression.Compile(entity);
            WorkflowExpression.Validate(__workflow_entity, nameof(entity), required: true);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_expand = expand == null ? null : WorkflowExpression.Compile(expand);
            WorkflowExpression.Validate(__workflow_expand, nameof(expand), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
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
        public IBodyWorkflowAction<JToken> GetSchema(Expression<Func<string>> odataUri, Expression<Func<string>> entity)
        {
            var __workflow_odataUri = odataUri == null ? null : WorkflowExpression.Compile(odataUri);
            WorkflowExpression.Validate(__workflow_odataUri, nameof(odataUri), required: true);
            var __workflow_entity = entity == null ? null : WorkflowExpression.Compile(entity);
            WorkflowExpression.Validate(__workflow_entity, nameof(entity), required: true);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<JToken> GetSingleSchema(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<int>> option = null)
        {
            var __workflow_odataUri = odataUri == null ? null : WorkflowExpression.Compile(odataUri);
            WorkflowExpression.Validate(__workflow_odataUri, nameof(odataUri), required: true);
            var __workflow_entity = entity == null ? null : WorkflowExpression.Compile(entity);
            WorkflowExpression.Validate(__workflow_entity, nameof(entity), required: true);
            var __workflow_option = option == null ? null : WorkflowExpression.Compile(option);
            WorkflowExpression.Validate(__workflow_option, nameof(option), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<JToken> GetEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var __workflow_odataUri = odataUri == null ? null : WorkflowExpression.Compile(odataUri);
            WorkflowExpression.Validate(__workflow_odataUri, nameof(odataUri), required: true);
            var __workflow_entity = entity == null ? null : WorkflowExpression.Compile(entity);
            WorkflowExpression.Validate(__workflow_entity, nameof(entity), required: true);
            var __workflow_entryInput = entryInput == null ? null : WorkflowExpression.Compile(entryInput);
            WorkflowExpression.Validate(__workflow_entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<JToken> CreateEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var __workflow_odataUri = odataUri == null ? null : WorkflowExpression.Compile(odataUri);
            WorkflowExpression.Validate(__workflow_odataUri, nameof(odataUri), required: true);
            var __workflow_entity = entity == null ? null : WorkflowExpression.Compile(entity);
            WorkflowExpression.Validate(__workflow_entity, nameof(entity), required: true);
            var __workflow_entryInput = entryInput == null ? null : WorkflowExpression.Compile(entryInput);
            WorkflowExpression.Validate(__workflow_entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<JToken> UpdateEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var __workflow_odataUri = odataUri == null ? null : WorkflowExpression.Compile(odataUri);
            WorkflowExpression.Validate(__workflow_odataUri, nameof(odataUri), required: true);
            var __workflow_entity = entity == null ? null : WorkflowExpression.Compile(entity);
            WorkflowExpression.Validate(__workflow_entity, nameof(entity), required: true);
            var __workflow_entryInput = entryInput == null ? null : WorkflowExpression.Compile(entryInput);
            WorkflowExpression.Validate(__workflow_entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<JToken> DeleteEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var __workflow_odataUri = odataUri == null ? null : WorkflowExpression.Compile(odataUri);
            WorkflowExpression.Validate(__workflow_odataUri, nameof(odataUri), required: true);
            var __workflow_entity = entity == null ? null : WorkflowExpression.Compile(entity);
            WorkflowExpression.Validate(__workflow_entity, nameof(entity), required: true);
            var __workflow_entryInput = entryInput == null ? null : WorkflowExpression.Compile(entryInput);
            WorkflowExpression.Validate(__workflow_entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
