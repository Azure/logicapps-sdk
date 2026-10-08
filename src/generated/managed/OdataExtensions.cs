//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Odata
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OdataActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntityData))]
        public IBodyWorkflowAction<JToken[]> GetEntityData([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<double> top = null, [WorkflowExpression] Func<double> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildGetEntityData(WorkflowExpression<string> odataUri, WorkflowExpression<string> entity, WorkflowExpression<double> top = null, WorkflowExpression<double> skip = null, WorkflowExpression<string> select = null, WorkflowExpression<string> filter = null, WorkflowExpression<string> expand = null)
        {
            WorkflowExpression.Validate(odataUri, nameof(odataUri), required: true);
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/getentitydata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(expand);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        [WorkflowExpressionFactory(nameof(__BuildGetSchema))]
        public IBodyWorkflowAction<JToken> GetSchema([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetSchema(WorkflowExpression<string> odataUri, WorkflowExpression<string> entity)
        {
            WorkflowExpression.Validate(odataUri, nameof(odataUri), required: true);
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/getschema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        [WorkflowExpressionFactory(nameof(__BuildGetSingleSchema))]
        public IBodyWorkflowAction<JToken> GetSingleSchema([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<int> option = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetSingleSchema(WorkflowExpression<string> odataUri, WorkflowExpression<string> entity, WorkflowExpression<int> option = null)
        {
            WorkflowExpression.Validate(odataUri, nameof(odataUri), required: true);
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(option, nameof(option), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/getsingleschema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                if (option != null)
                    callPayload.Queries["option"] = ExpressionConverter.Convert(option);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntry))]
        public IBodyWorkflowAction<JToken> GetEntry([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetEntry(WorkflowExpression<string> odataUri, WorkflowExpression<string> entity, WorkflowExpression<object> entryInput = null)
        {
            WorkflowExpression.Validate(odataUri, nameof(odataUri), required: true);
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/getentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                callPayload.Body = ExpressionConverter.ConvertO(entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEntry))]
        public IBodyWorkflowAction<JToken> CreateEntry([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateEntry(WorkflowExpression<string> odataUri, WorkflowExpression<string> entity, WorkflowExpression<object> entryInput = null)
        {
            WorkflowExpression.Validate(odataUri, nameof(odataUri), required: true);
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/createentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                callPayload.Body = ExpressionConverter.ConvertO(entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEntry))]
        public IBodyWorkflowAction<JToken> UpdateEntry([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateEntry(WorkflowExpression<string> odataUri, WorkflowExpression<string> entity, WorkflowExpression<object> entryInput = null)
        {
            WorkflowExpression.Validate(odataUri, nameof(odataUri), required: true);
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/updateentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                callPayload.Body = ExpressionConverter.ConvertO(entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEntry))]
        public IBodyWorkflowAction<JToken> DeleteEntry([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteEntry(WorkflowExpression<string> odataUri, WorkflowExpression<string> entity, WorkflowExpression<object> entryInput = null)
        {
            WorkflowExpression.Validate(odataUri, nameof(odataUri), required: true);
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(entryInput, nameof(entryInput), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/deleteentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                callPayload.Body = ExpressionConverter.ConvertO(entryInput);
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