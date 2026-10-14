//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cioplenu
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CioplenuActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cioplenu")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> taskDatatitle, Expression<Func<string>> taskDatadescription, Expression<Func<int>> taskDatapriority)
        {
            var __workflow_taskDatatitle = taskDatatitle == null ? null : WorkflowExpression.Compile(taskDatatitle);
            WorkflowExpression.Validate(__workflow_taskDatatitle, nameof(taskDatatitle), required: true);
            var __workflow_taskDatadescription = taskDatadescription == null ? null : WorkflowExpression.Compile(taskDatadescription);
            WorkflowExpression.Validate(__workflow_taskDatadescription, nameof(taskDatadescription), required: true);
            var __workflow_taskDatapriority = taskDatapriority == null ? null : WorkflowExpression.Compile(taskDatapriority);
            WorkflowExpression.Validate(__workflow_taskDatapriority, nameof(taskDatapriority), required: true);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = "/task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var taskData = new JObject();
                var taskDatapropCount = 0;
                taskDatapropCount++;
                taskData["title"] = ExpressionConverter.ConvertO(__workflow_taskDatatitle);
                taskDatapropCount++;
                taskData["description"] = ExpressionConverter.ConvertO(__workflow_taskDatadescription);
                taskDatapropCount++;
                taskData["priority"] = ExpressionConverter.ConvertO(__workflow_taskDatapriority);
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
