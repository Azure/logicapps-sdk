//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Enadoc
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EnadocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enadoc")]
        public IBodyWorkflowAction<SuccessResponse> SendToMyWorkspace(Expression<Func<string>> document, Expression<Func<string>> name)
        {
            var __workflow_document = document == null ? null : WorkflowExpression.Compile(document);
            WorkflowExpression.Validate(__workflow_document, nameof(document), required: true);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: true);
            return new DeferredBodyAction<SuccessResponse>(() =>
            {
                var apiCallPath = "/api/v3/workspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SuccessResponse>(callPayload);
            });
        }
    }

    public class EnadocTriggers([ConnectionName] string connectionId)
    {
    }

    public class SuccessResponse
    {
        public string Status { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Enadoc;

    public partial class WorkflowManagedActions
    {
        public EnadocActions Enadoc(string connectionId) => new EnadocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EnadocTriggers Enadoc(string connectionId) => new EnadocTriggers(connectionId);
    }
}
