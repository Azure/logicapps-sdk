//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flotiqheadlesscms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlotiqheadlesscmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flotiqheadlesscms")]
        public IWorkflowAction CreateContentObject([WorkflowExpression] Func<string> contentTypeId, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(contentTypeId, nameof(contentTypeId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/content/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contentTypeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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