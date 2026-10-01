//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentaikonfuzio
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentaikonfuzioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        public IWorkflowAction DocsDelete([WorkflowExpression] Func<string> doc)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/docs/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(doc, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        public IWorkflowAction DocsPartialUpdate([WorkflowExpression] Func<string> doc)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/docs/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(doc, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        public IWorkflowAction DocsRead([WorkflowExpression] Func<string> doc)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/docs/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(doc, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class DocumentaikonfuzioTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documentaikonfuzio;

    public partial class WorkflowManagedActions
    {
        public DocumentaikonfuzioActions Documentaikonfuzio(string connectionId) => new DocumentaikonfuzioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentaikonfuzioTriggers Documentaikonfuzio(string connectionId) => new DocumentaikonfuzioTriggers(connectionId);
    }
}