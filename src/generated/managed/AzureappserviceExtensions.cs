//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureappservice
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureappserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureappservice")]
        [WorkflowExpressionFactory(nameof(__BuildWebAppStart))]
        public IWorkflowAction WebAppStart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> webAppName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildWebAppStart(WorkflowValue<string> subscriptionId, WorkflowValue<string> resourceGroupName, WorkflowValue<string> webAppName)
        {
            WorkflowValue.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowValue.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowValue.Validate(webAppName, nameof(webAppName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Web/sites/{2}/start", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(webAppName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-08-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureappservice")]
        [WorkflowExpressionFactory(nameof(__BuildWebAppStop))]
        public IWorkflowAction WebAppStop([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> webAppName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildWebAppStop(WorkflowValue<string> subscriptionId, WorkflowValue<string> resourceGroupName, WorkflowValue<string> webAppName)
        {
            WorkflowValue.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowValue.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowValue.Validate(webAppName, nameof(webAppName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Web/sites/{2}/stop", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(webAppName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-08-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureappservice")]
        [WorkflowExpressionFactory(nameof(__BuildWebAppRestart))]
        public IWorkflowAction WebAppRestart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> webAppName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildWebAppRestart(WorkflowValue<string> subscriptionId, WorkflowValue<string> resourceGroupName, WorkflowValue<string> webAppName)
        {
            WorkflowValue.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowValue.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowValue.Validate(webAppName, nameof(webAppName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Web/sites/{2}/restart", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(webAppName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-08-01");
                return new ApiConnectionAction(callPayload);
            });
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
