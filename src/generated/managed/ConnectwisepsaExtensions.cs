//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Connectwisepsa
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConnectwisepsaActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectwisepsa")]
        [WorkflowExpressionFactory(nameof(__BuildGetServiceTickets))]
        public IWorkflowAction GetServiceTickets([WorkflowExpression] Func<string> clientId, [WorkflowExpression] Func<string> conditions = null, [WorkflowExpression] Func<string> childConditions = null, [WorkflowExpression] Func<string> customFieldConditions = null, [WorkflowExpression] Func<string> orderBy = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> pageId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectwisepsa")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetServiceTickets(WorkflowExpression<string> clientId, WorkflowExpression<string> conditions = null, WorkflowExpression<string> childConditions = null, WorkflowExpression<string> customFieldConditions = null, WorkflowExpression<string> orderBy = null, WorkflowExpression<string> fields = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<int> pageId = null)
        {
            WorkflowExpression.Validate(clientId, nameof(clientId), required: true);
            WorkflowExpression.Validate(conditions, nameof(conditions), required: false);
            WorkflowExpression.Validate(childConditions, nameof(childConditions), required: false);
            WorkflowExpression.Validate(customFieldConditions, nameof(customFieldConditions), required: false);
            WorkflowExpression.Validate(orderBy, nameof(orderBy), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(pageId, nameof(pageId), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectwisepsa")]
        [WorkflowExpressionFactory(nameof(__BuildPostServiceTickets))]
        public IWorkflowAction PostServiceTickets([WorkflowExpression] Func<string> clientId, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectwisepsa")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostServiceTickets(WorkflowExpression<string> clientId, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(clientId, nameof(clientId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v4_6_release/apis/3.0/service/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["clientId"] = ExpressionConverter.Convert(clientId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
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