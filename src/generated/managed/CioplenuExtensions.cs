//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cioplenu
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CioplenuActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cioplenu")]
        public IBodyWorkflowAction<CreateTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<CreateTaskInput>> taskData)
        {
            var __workflow_taskData = WorkflowExpression.Compile(taskData, nameof(taskData), required: true);
            return new DeferredBodyAction<CreateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_taskData);
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

    public class CreateTaskInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; } = "";

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Priority { get; set; } = 5;
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