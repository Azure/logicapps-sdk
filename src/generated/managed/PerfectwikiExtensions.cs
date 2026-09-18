//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Perfectwiki
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PerfectwikiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "perfectwiki")]
        public IWorkflowAction GetCurrentUser()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/chatgpt/users/session";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "perfectwiki")]
        public IWorkflowAction QueryKnowledgebase([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> chatId)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(chatId, nameof(chatId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/chatgpt/organization/bot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Queries["chatId"] = SourceExpressionConverter.ConvertO(chatId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class PerfectwikiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Perfectwiki;

    public partial class WorkflowManagedActions
    {
        public PerfectwikiActions Perfectwiki(string connectionId) => new PerfectwikiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PerfectwikiTriggers Perfectwiki(string connectionId) => new PerfectwikiTriggers(connectionId);
    }
}