//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Connectwisepsa
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ConnectwisepsaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectwisepsa")]
        public IWorkflowAction GetServiceTickets(Expression<Func<string>> clientId, Expression<Func<string>> conditions = null, Expression<Func<string>> childConditions = null, Expression<Func<string>> customFieldConditions = null, Expression<Func<string>> orderBy = null, Expression<Func<string>> fields = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> pageId = null)
        {
            var __workflow_clientId = clientId == null ? null : WorkflowExpression.Compile(clientId);
            WorkflowExpression.Validate(__workflow_clientId, nameof(clientId), required: true);
            var __workflow_conditions = conditions == null ? null : WorkflowExpression.Compile(conditions);
            WorkflowExpression.Validate(__workflow_conditions, nameof(conditions), required: false);
            var __workflow_childConditions = childConditions == null ? null : WorkflowExpression.Compile(childConditions);
            WorkflowExpression.Validate(__workflow_childConditions, nameof(childConditions), required: false);
            var __workflow_customFieldConditions = customFieldConditions == null ? null : WorkflowExpression.Compile(customFieldConditions);
            WorkflowExpression.Validate(__workflow_customFieldConditions, nameof(customFieldConditions), required: false);
            var __workflow_orderBy = orderBy == null ? null : WorkflowExpression.Compile(orderBy);
            WorkflowExpression.Validate(__workflow_orderBy, nameof(orderBy), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_pageId = pageId == null ? null : WorkflowExpression.Compile(pageId);
            WorkflowExpression.Validate(__workflow_pageId, nameof(pageId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v4_6_release/apis/3.0/service/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_conditions != null)
                    callPayload.Queries["conditions"] = ExpressionConverter.Convert(__workflow_conditions);
                if (__workflow_childConditions != null)
                    callPayload.Queries["childConditions"] = ExpressionConverter.Convert(__workflow_childConditions);
                if (__workflow_customFieldConditions != null)
                    callPayload.Queries["customFieldConditions"] = ExpressionConverter.Convert(__workflow_customFieldConditions);
                if (__workflow_orderBy != null)
                    callPayload.Queries["orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageId != null)
                    callPayload.Queries["pageId"] = ExpressionConverter.Convert(__workflow_pageId);
                callPayload.Headers["clientId"] = ExpressionConverter.Convert(__workflow_clientId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectwisepsa")]
        public IWorkflowAction PostServiceTickets(Expression<Func<string>> clientId, Expression<Func<object>> body = null)
        {
            var __workflow_clientId = clientId == null ? null : WorkflowExpression.Compile(clientId);
            WorkflowExpression.Validate(__workflow_clientId, nameof(clientId), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v4_6_release/apis/3.0/service/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["clientId"] = ExpressionConverter.Convert(__workflow_clientId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
