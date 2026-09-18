//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dox42
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Dox42Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dox42")]
        public IWorkflowAction Dox42Call([WorkflowExpression] Func<string> domainname, [WorkflowExpression] Func<string> querystring, [WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> accept = null)
        {
            SourceExpression.Validate(domainname, nameof(domainname), required: true);
            SourceExpression.Validate(querystring, nameof(querystring), required: true);
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dox42RestService.ashx";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["querystring"] = SourceExpressionConverter.ConvertO(querystring);
                callPayload.Headers["domainname"] = SourceExpressionConverter.ConvertO(domainname);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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