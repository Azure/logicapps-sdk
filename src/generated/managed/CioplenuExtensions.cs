//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cioplenu
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CioplenuActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cioplenu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> taskDatatitle, [WorkflowExpression] Func<string> taskDatadescription, [WorkflowExpression] Func<int> taskDatapriority)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTaskResponse> __BuildCreateTask(WorkflowExpression<string> taskDatatitle, WorkflowExpression<string> taskDatadescription, WorkflowExpression<int> taskDatapriority)
        {
            WorkflowExpression.Validate(taskDatatitle, nameof(taskDatatitle), required: true);
            WorkflowExpression.Validate(taskDatadescription, nameof(taskDatadescription), required: true);
            WorkflowExpression.Validate(taskDatapriority, nameof(taskDatapriority), required: true);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = "/task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var taskData = new JObject();
                var taskDatapropCount = 0;
                taskDatapropCount++;
                taskData["title"] = ExpressionConverter.ConvertO(taskDatatitle);
                taskDatapropCount++;
                taskData["description"] = ExpressionConverter.ConvertO(taskDatadescription);
                taskDatapropCount++;
                taskData["priority"] = ExpressionConverter.ConvertO(taskDatapriority);
                if (taskDatapropCount > 0)
                {
                    callPayload.Body = taskData;
                }

                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
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