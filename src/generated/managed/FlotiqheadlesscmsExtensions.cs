//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flotiqheadlesscms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlotiqheadlesscmsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flotiqheadlesscms")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContentObject))]
        public IWorkflowAction CreateContentObject([WorkflowExpression] Func<string> contentTypeId, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateContentObject(WorkflowExpression<string> contentTypeId, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(contentTypeId, nameof(contentTypeId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/content/{0}", ExpressionConverter.ConvertWithUrlEncoding(contentTypeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class FlotiqheadlesscmsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Flotiqheadlesscms;

    public partial class WorkflowManagedActions
    {
        public FlotiqheadlesscmsActions Flotiqheadlesscms(string connectionId) => new FlotiqheadlesscmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlotiqheadlesscmsTriggers Flotiqheadlesscms(string connectionId) => new FlotiqheadlesscmsTriggers(connectionId);
    }
}