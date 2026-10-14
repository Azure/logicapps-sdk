//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureloganalyticsdatacollector
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzureloganalyticsdatacollectorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureloganalyticsdatacollector")]
        public IWorkflowAction SendData(Expression<Func<string>> logType, Expression<Func<string>> body = null, Expression<Func<string>> timeGeneratedField = null)
        {
            var __workflow_logType = logType == null ? null : WorkflowExpression.Compile(logType);
            WorkflowExpression.Validate(__workflow_logType, nameof(logType), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_timeGeneratedField = timeGeneratedField == null ? null : WorkflowExpression.Compile(timeGeneratedField);
            WorkflowExpression.Validate(__workflow_timeGeneratedField, nameof(timeGeneratedField), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/logs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Log-Type"] = ExpressionConverter.Convert(__workflow_logType);
                if (__workflow_timeGeneratedField != null)
                    callPayload.Headers["time-generated-field"] = ExpressionConverter.Convert(__workflow_timeGeneratedField);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
