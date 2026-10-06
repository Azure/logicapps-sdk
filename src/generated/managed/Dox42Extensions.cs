//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dox42
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Dox42Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dox42")]
        [WorkflowExpressionFactory(nameof(__BuildDox42Call))]
        public IWorkflowAction Dox42Call([WorkflowExpression] Func<string> domainname, [WorkflowExpression] Func<string> querystring, [WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> accept = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dox42")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDox42Call(WorkflowExpression<string> domainname, WorkflowExpression<string> querystring, WorkflowExpression<string> token, WorkflowExpression<string> accept = null)
        {
            WorkflowExpression.Validate(domainname, nameof(domainname), required: true);
            WorkflowExpression.Validate(querystring, nameof(querystring), required: true);
            WorkflowExpression.Validate(token, nameof(token), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/dox42RestService.ashx";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["querystring"] = ExpressionConverter.Convert(querystring);
                callPayload.Headers["domainname"] = ExpressionConverter.Convert(domainname);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["accept"] = ExpressionConverter.Convert(accept);
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