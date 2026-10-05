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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetServiceTickets(WorkflowValue<string> clientId, WorkflowValue<string> conditions = null, WorkflowValue<string> childConditions = null, WorkflowValue<string> customFieldConditions = null, WorkflowValue<string> orderBy = null, WorkflowValue<string> fields = null, WorkflowValue<int> page = null, WorkflowValue<int> pageSize = null, WorkflowValue<int> pageId = null)
        {
            WorkflowValue.Validate(clientId, nameof(clientId), required: true);
            WorkflowValue.Validate(conditions, nameof(conditions), required: false);
            WorkflowValue.Validate(childConditions, nameof(childConditions), required: false);
            WorkflowValue.Validate(customFieldConditions, nameof(customFieldConditions), required: false);
            WorkflowValue.Validate(orderBy, nameof(orderBy), required: false);
            WorkflowValue.Validate(fields, nameof(fields), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(pageId, nameof(pageId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostServiceTickets(WorkflowValue<string> clientId, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(clientId, nameof(clientId), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
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
