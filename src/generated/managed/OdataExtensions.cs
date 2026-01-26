//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Odata
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken[]> GetEntityData(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<double>> top = null, Expression<Func<double>> skip = null, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> GetSchema(Expression<Func<string>> odataUri, Expression<Func<string>> entity)
        {
            var apiCallPath = "/getschema";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
            callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> GetSingleSchema(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<int>> option = null)
        {
            var apiCallPath = "/getsingleschema";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
            callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
            if (option != null)
                callPayload.Queries["option"] = ExpressionConverter.Convert(option);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> GetEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var apiCallPath = "/getentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
            callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
            callPayload.Body = ExpressionConverter.ConvertO(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> CreateEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var apiCallPath = "/createentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
            callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
            callPayload.Body = ExpressionConverter.ConvertO(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> UpdateEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var apiCallPath = "/updateentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
            callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
            callPayload.Body = ExpressionConverter.ConvertO(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> DeleteEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var apiCallPath = "/deleteentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = ExpressionConverter.Convert(odataUri);
            callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
            callPayload.Body = ExpressionConverter.ConvertO(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
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