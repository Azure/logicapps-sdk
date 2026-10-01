//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurelogicappsgithub
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurelogicappsgithubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsgithub")]
        public IWorkflowAction PassthroughDELETE([WorkflowExpression] Func<string> Path)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(Path, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsgithub")]
        public IWorkflowAction PassthroughPOST([WorkflowExpression] Func<string> Path)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(Path, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsgithub")]
        public IWorkflowAction PassthroughPUT([WorkflowExpression] Func<string> Path)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(Path, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsgithub")]
        public IWorkflowAction PassthroughGET([WorkflowExpression] Func<string> Path)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(Path, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class AzurelogicappsgithubTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azurelogicappsgithub;

    public partial class WorkflowManagedActions
    {
        public AzurelogicappsgithubActions Azurelogicappsgithub(string connectionId) => new AzurelogicappsgithubActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzurelogicappsgithubTriggers Azurelogicappsgithub(string connectionId) => new AzurelogicappsgithubTriggers(connectionId);
    }
}