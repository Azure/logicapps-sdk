//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Intentionaldatasources
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntentionaldatasourcesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<SingleEntity> SingleEntity(Expression<Func<string>> token, Expression<Func<string>> service, Expression<Func<string>> entity, Expression<Func<string>> id = null, Expression<Func<string>> oDataQuery = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["token"] = CSharpExpressionConverter.ConvertO(token);
            if (id != null)
                callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            if (oDataQuery != null)
                callPayload.Queries["oDataQuery"] = CSharpExpressionConverter.ConvertO(oDataQuery);
            return new ApiConnectionAction<SingleEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<SingleEntity> SingleEntityById(Expression<Func<string>> token, Expression<Func<string>> service, Expression<Func<string>> entity, Expression<Func<string>> id, Expression<Func<string>> oDataQuery = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["token"] = CSharpExpressionConverter.ConvertO(token);
            if (oDataQuery != null)
                callPayload.Queries["oDataQuery"] = CSharpExpressionConverter.ConvertO(oDataQuery);
            return new ApiConnectionAction<SingleEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<ListEntity> ListEntity(Expression<Func<string>> token, Expression<Func<string>> service, Expression<Func<string>> entity, Expression<Func<string>> id = null, Expression<Func<string>> oDataQuery = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}/list", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["token"] = CSharpExpressionConverter.ConvertO(token);
            if (id != null)
                callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            if (oDataQuery != null)
                callPayload.Queries["oDataQuery"] = CSharpExpressionConverter.ConvertO(oDataQuery);
            return new ApiConnectionAction<ListEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<ListEntity> ListEntityById(Expression<Func<string>> token, Expression<Func<string>> service, Expression<Func<string>> entity, Expression<Func<string>> id, Expression<Func<string>> oDataQuery = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}/list", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["token"] = CSharpExpressionConverter.ConvertO(token);
            if (oDataQuery != null)
                callPayload.Queries["oDataQuery"] = CSharpExpressionConverter.ConvertO(oDataQuery);
            return new ApiConnectionAction<ListEntity>(callPayload);
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