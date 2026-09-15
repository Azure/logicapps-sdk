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
            callPayload.Queries["odataUri"] = CSharpExpressionConverter.ConvertO(odataUri);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            if (top != null)
                callPayload.Queries["top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (expand != null)
                callPayload.Queries["expand"] = CSharpExpressionConverter.ConvertO(expand);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> GetSchema(Expression<Func<string>> odataUri, Expression<Func<string>> entity)
        {
            var apiCallPath = "/getschema";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = CSharpExpressionConverter.ConvertO(odataUri);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> GetSingleSchema(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<int>> option = null)
        {
            var apiCallPath = "/getsingleschema";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = CSharpExpressionConverter.ConvertO(odataUri);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            if (option != null)
                callPayload.Queries["option"] = CSharpExpressionConverter.ConvertO(option);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> GetEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var apiCallPath = "/getentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = CSharpExpressionConverter.ConvertO(odataUri);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> CreateEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var apiCallPath = "/createentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = CSharpExpressionConverter.ConvertO(odataUri);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> UpdateEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var apiCallPath = "/updateentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = CSharpExpressionConverter.ConvertO(odataUri);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> DeleteEntry(Expression<Func<string>> odataUri, Expression<Func<string>> entity, Expression<Func<object>> entryInput = null)
        {
            var apiCallPath = "/deleteentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["odataUri"] = CSharpExpressionConverter.ConvertO(odataUri);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(entryInput);
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