//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Connectwisepsa
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConnectwisepsaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectwisepsa")]
        public IWorkflowAction GetServiceTickets(Expression<Func<string>> clientId, Expression<Func<string>> conditions = null, Expression<Func<string>> childConditions = null, Expression<Func<string>> customFieldConditions = null, Expression<Func<string>> orderBy = null, Expression<Func<string>> fields = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> pageId = null)
        {
            var apiCallPath = "/v4_6_release/apis/3.0/service/tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (conditions != null)
                callPayload.Queries["conditions"] = ExpressionConverter.Convert(conditions);
            if (childConditions != null)
                callPayload.Queries["childConditions"] = ExpressionConverter.Convert(childConditions);
            if (customFieldConditions != null)
                callPayload.Queries["customFieldConditions"] = ExpressionConverter.Convert(customFieldConditions);
            if (orderBy != null)
                callPayload.Queries["orderBy"] = ExpressionConverter.Convert(orderBy);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (pageId != null)
                callPayload.Queries["pageId"] = ExpressionConverter.Convert(pageId);
            callPayload.Headers["clientId"] = ExpressionConverter.Convert(clientId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectwisepsa")]
        public IWorkflowAction PostServiceTickets(Expression<Func<string>> clientId, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/v4_6_release/apis/3.0/service/tickets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["clientId"] = ExpressionConverter.Convert(clientId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class ConnectwisepsaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Connectwisepsa;

    public partial class WorkflowManagedActions
    {
        public ConnectwisepsaActions Connectwisepsa(string connectionId) => new ConnectwisepsaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConnectwisepsaTriggers Connectwisepsa(string connectionId) => new ConnectwisepsaTriggers(connectionId);
    }
}