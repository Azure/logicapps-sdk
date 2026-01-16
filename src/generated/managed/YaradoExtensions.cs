//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yarado
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YaradoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yarado")]
        public IBodyWorkflowAction<GetRobotsResponseItem[]> GetRobots()
        {
            var apiCallPath = "/v1/robots";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRobotsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yarado")]
        public IBodyWorkflowAction<GetTaskFilesResponseItem[]> GetTaskFiles()
        {
            var apiCallPath = "/v1/task-files";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTaskFilesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yarado")]
        public IWorkflowAction CreateScheduleTaskRun(Expression<Func<string>> bodyrobotId, Expression<Func<string>> bodytaskFileId)
        {
            var apiCallPath = "/v1/task-schedules";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["robot_id"] = ExpressionConverter.ConvertO(bodyrobotId);
            bodypropCount++;
            body["task_file_id"] = ExpressionConverter.ConvertO(bodytaskFileId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class YaradoTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetRobotsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organisation_name")]
        public string OrganisationName { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }
    }

    public class GetTaskFilesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Yarado;

    public partial class WorkflowManagedActions
    {
        public YaradoActions Yarado(string connectionId) => new YaradoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YaradoTriggers Yarado(string connectionId) => new YaradoTriggers(connectionId);
    }
}