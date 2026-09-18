//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureautomation
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureautomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        public IBodyWorkflowAction<string> GetJobOutput([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> automationAccount, [WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(automationAccount, nameof(automationAccount), required: true);
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs/{3}/output", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(automationAccount, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        public IBodyWorkflowAction<CreateJobResponse> GetStatusOfJob([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> automationAccount, [WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(automationAccount, nameof(automationAccount), required: true);
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(automationAccount, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                return callPayload;
            }

            return new ApiConnectionAction<CreateJobResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        public IBodyWorkflowAction<CreateJobResponse> CreateJob([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> automationAccount, [WorkflowExpression] Func<string> runbookName = null, [WorkflowExpression] Func<object> bodypropertiesrunbookParameters = null, [WorkflowExpression] Func<string> bodypropertieshybridAutomationWorkerGroup = null, [WorkflowExpression] Func<bool> wait = null)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(automationAccount, nameof(automationAccount), required: true);
            SourceExpression.Validate(runbookName, nameof(runbookName), required: false);
            SourceExpression.Validate(bodypropertiesrunbookParameters, nameof(bodypropertiesrunbookParameters), required: false);
            SourceExpression.Validate(bodypropertieshybridAutomationWorkerGroup, nameof(bodypropertieshybridAutomationWorkerGroup), required: false);
            SourceExpression.Validate(wait, nameof(wait), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(automationAccount, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                if (runbookName != null)
                    callPayload.Queries["runbookName"] = SourceExpressionConverter.ConvertO(runbookName);
                callPayload.Queries["wait"] = Convert.ToString(false);
                if (wait != null)
                    callPayload.Queries["wait"] = SourceExpressionConverter.ConvertO(wait);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesrunbookParameters != null)
                {
                    propertiesObject["parameters"] = SourceExpressionConverter.ConvertToken(bodypropertiesrunbookParameters);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshybridAutomationWorkerGroup != null)
                {
                    propertiesObject["runOn"] = SourceExpressionConverter.ConvertToken(bodypropertieshybridAutomationWorkerGroup);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateJobResponse>(BuildSourceInput);
        }
    }

    public class AzureautomationTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateJobResponse
    {
        [JsonProperty("id")]
        public string ResourceID { get; set; }

        [JsonProperty("properties")]
        public CreateJobResponsePropertiesType Properties { get; set; }
    }

    public class CreateJobResponsePropertiesType
    {
        [JsonProperty("jobId")]
        public string JobID { get; set; }

        [JsonProperty("provisioningState")]
        public string ProvisioningState { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDetails")]
        public string StatusDetails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureautomation;

    public partial class WorkflowManagedActions
    {
        public AzureautomationActions Azureautomation(string connectionId) => new AzureautomationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureautomationTriggers Azureautomation(string connectionId) => new AzureautomationTriggers(connectionId);
    }
}