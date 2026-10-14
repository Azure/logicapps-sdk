//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dox42
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Dox42Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dox42")]
        public IWorkflowAction Dox42Call(Expression<Func<string>> domainname, Expression<Func<string>> querystring, Expression<Func<string>> token, Expression<Func<string>> accept = null)
        {
            var __workflow_domainname = domainname == null ? null : WorkflowExpression.Compile(domainname);
            WorkflowExpression.Validate(__workflow_domainname, nameof(domainname), required: true);
            var __workflow_querystring = querystring == null ? null : WorkflowExpression.Compile(querystring);
            WorkflowExpression.Validate(__workflow_querystring, nameof(querystring), required: true);
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_accept = accept == null ? null : WorkflowExpression.Compile(accept);
            WorkflowExpression.Validate(__workflow_accept, nameof(accept), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/dox42RestService.ashx";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["querystring"] = ExpressionConverter.Convert(__workflow_querystring);
                callPayload.Headers["domainname"] = ExpressionConverter.Convert(__workflow_domainname);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["accept"] = Convert.ToString("application/json");
                if (__workflow_accept != null)
                    callPayload.Headers["accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Dox42Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dox42;

    public partial class WorkflowManagedActions
    {
        public Dox42Actions Dox42(string connectionId) => new Dox42Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Dox42Triggers Dox42(string connectionId) => new Dox42Triggers(connectionId);
    }
}
