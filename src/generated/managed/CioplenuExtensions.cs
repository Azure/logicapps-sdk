//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cioplenu
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CioplenuActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cioplenu")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> taskDatatitle, [WorkflowExpression] Func<string> taskDatadescription, [WorkflowExpression] Func<int> taskDatapriority)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var taskData = new JObject();
                var taskDatapropCount = 0;
                taskDatapropCount++;
                taskData["title"] = SourceExpressionConverter.ConvertToken(taskDatatitle);
                taskDatapropCount++;
                taskData["description"] = SourceExpressionConverter.ConvertToken(taskDatadescription);
                taskDatapropCount++;
                taskData["priority"] = SourceExpressionConverter.ConvertToken(taskDatapriority);
                if (taskDatapropCount > 0)
                {
                    callPayload.Body = taskData;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTaskResponse>(BuildSourceInput);
        }
    }

    public class CioplenuTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateTaskResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cioplenu;

    public partial class WorkflowManagedActions
    {
        public CioplenuActions Cioplenu(string connectionId) => new CioplenuActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CioplenuTriggers Cioplenu(string connectionId) => new CioplenuTriggers(connectionId);
    }
}