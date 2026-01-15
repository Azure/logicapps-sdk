//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cioplenu
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CioplenuActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cioplenu")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> taskDatatitle, Expression<Func<string>> taskDatadescription, Expression<Func<int>> taskDatapriority)
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
    using Microsoft.Azure.Workflows.Sdk.Cioplenu;

    public partial class WorkflowManagedActions
    {
        public CioplenuActions Cioplenu(string connectionId) => new CioplenuActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CioplenuTriggers Cioplenu(string connectionId) => new CioplenuTriggers(connectionId);
    }
}