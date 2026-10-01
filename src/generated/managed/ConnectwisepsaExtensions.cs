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
        public IWorkflowAction GetServiceTickets([WorkflowExpression] Func<string> clientId, [WorkflowExpression] Func<string> conditions = null, [WorkflowExpression] Func<string> childConditions = null, [WorkflowExpression] Func<string> customFieldConditions = null, [WorkflowExpression] Func<string> orderBy = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> pageId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4_6_release/apis/3.0/service/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (conditions != null)
                    callPayload.Queries["conditions"] = SourceExpressionConverter.ConvertO(conditions);
                if (childConditions != null)
                    callPayload.Queries["childConditions"] = SourceExpressionConverter.ConvertO(childConditions);
                if (customFieldConditions != null)
                    callPayload.Queries["customFieldConditions"] = SourceExpressionConverter.ConvertO(customFieldConditions);
                if (orderBy != null)
                    callPayload.Queries["orderBy"] = SourceExpressionConverter.ConvertO(orderBy);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (pageId != null)
                    callPayload.Queries["pageId"] = SourceExpressionConverter.ConvertO(pageId);
                callPayload.Headers["clientId"] = SourceExpressionConverter.ConvertO(clientId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectwisepsa")]
        public IWorkflowAction PostServiceTickets([WorkflowExpression] Func<string> clientId, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4_6_release/apis/3.0/service/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["clientId"] = SourceExpressionConverter.ConvertO(clientId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class ConnectwisepsaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
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