//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Azureloganalyticsdatacollector
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureloganalyticsdatacollectorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureloganalyticsdatacollector")]
        public IWorkflowAction SendData(Expression<Func<string>> logType, Expression<Func<string>> body = null, Expression<Func<string>> timeGeneratedField = null)
        {
            var apiCallPath = "/api/logs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Log-Type"] = ExpressionConverter.Convert(logType);
            if (timeGeneratedField != null)
                callPayload.Headers["time-generated-field"] = ExpressionConverter.Convert(timeGeneratedField);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class AzureloganalyticsdatacollectorTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Azureloganalyticsdatacollector;

    public partial class WorkflowManagedActions
    {
        public AzureloganalyticsdatacollectorActions Azureloganalyticsdatacollector(string connectionId) => new AzureloganalyticsdatacollectorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureloganalyticsdatacollectorTriggers Azureloganalyticsdatacollector(string connectionId) => new AzureloganalyticsdatacollectorTriggers(connectionId);
    }
}