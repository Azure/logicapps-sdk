//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureappservice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureappserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureappservice")]
        public IWorkflowAction WebAppStart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> webAppName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Web/sites/{2}/start", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webAppName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-08-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureappservice")]
        public IWorkflowAction WebAppStop([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> webAppName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Web/sites/{2}/stop", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webAppName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-08-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureappservice")]
        public IWorkflowAction WebAppRestart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> webAppName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Web/sites/{2}/restart", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webAppName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-08-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class AzureappserviceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureappservice;

    public partial class WorkflowManagedActions
    {
        public AzureappserviceActions Azureappservice(string connectionId) => new AzureappserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureappserviceTriggers Azureappservice(string connectionId) => new AzureappserviceTriggers(connectionId);
    }
}