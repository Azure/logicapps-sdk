//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huedatagate
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuedatagateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huedatagate")]
        public IWorkflowAction Odata(Expression<Func<string>> query, Expression<Func<string>> hostUrl, Expression<Func<string>> roleId, Expression<Func<string>> roleSecret)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            var __workflow_roleSecret = WorkflowExpression.Compile(roleSecret, nameof(roleSecret), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v2/odata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                callPayload.Queries["host_url"] = ExpressionConverter.Convert(__workflow_hostUrl);
                callPayload.Headers["role-id"] = ExpressionConverter.Convert(__workflow_roleId);
                callPayload.Headers["role-secret"] = ExpressionConverter.Convert(__workflow_roleSecret);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HuedatagateTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Huedatagate;

    public partial class WorkflowManagedActions
    {
        public HuedatagateActions Huedatagate(string connectionId) => new HuedatagateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HuedatagateTriggers Huedatagate(string connectionId) => new HuedatagateTriggers(connectionId);
    }
}
