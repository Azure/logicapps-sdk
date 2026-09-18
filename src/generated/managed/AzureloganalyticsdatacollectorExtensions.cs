//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureloganalyticsdatacollector
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureloganalyticsdatacollectorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureloganalyticsdatacollector")]
        public IWorkflowAction SendData([WorkflowExpression] Func<string> logType, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> timeGeneratedField = null)
        {
            SourceExpression.Validate(logType, nameof(logType), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(timeGeneratedField, nameof(timeGeneratedField), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/logs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Log-Type"] = SourceExpressionConverter.ConvertO(logType);
                if (timeGeneratedField != null)
                    callPayload.Headers["time-generated-field"] = SourceExpressionConverter.ConvertO(timeGeneratedField);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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