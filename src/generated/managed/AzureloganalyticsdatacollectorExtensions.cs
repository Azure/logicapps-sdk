//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureloganalyticsdatacollector
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureloganalyticsdatacollectorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureloganalyticsdatacollector")]
        [WorkflowExpressionFactory(nameof(__BuildSendData))]
        public IWorkflowAction SendData([WorkflowExpression] Func<string> logType, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> timeGeneratedField = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendData(WorkflowValue<string> logType, WorkflowValue<string> body = null, WorkflowValue<string> timeGeneratedField = null)
        {
            WorkflowValue.Validate(logType, nameof(logType), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            WorkflowValue.Validate(timeGeneratedField, nameof(timeGeneratedField), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/logs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Log-Type"] = ExpressionConverter.Convert(logType);
                if (timeGeneratedField != null)
                    callPayload.Headers["time-generated-field"] = ExpressionConverter.Convert(timeGeneratedField);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AzureloganalyticsdatacollectorTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureloganalyticsdatacollector;

    public partial class WorkflowManagedActions
    {
        public AzureloganalyticsdatacollectorActions Azureloganalyticsdatacollector(string connectionId) => new AzureloganalyticsdatacollectorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureloganalyticsdatacollectorTriggers Azureloganalyticsdatacollector(string connectionId) => new AzureloganalyticsdatacollectorTriggers(connectionId);
    }
}
