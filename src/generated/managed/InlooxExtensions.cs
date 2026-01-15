//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Inloox
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InlooxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts(Expression<Func<string>> filter = null, Expression<Func<double>> top = null)
        {
            var apiCallPath = "/Contact";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<GetContactsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetProjectsResponse> GetProjects(Expression<Func<string>> filter = null, Expression<Func<double>> top = null)
        {
            var apiCallPath = "/Project";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<GetProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<ApiProject> PostProjects(Expression<Func<string>> bodyClientId = null, Expression<Func<string>> bodyDescriptionHTML = null, Expression<Func<string>> bodyDivisionId = null, Expression<Func<string>> bodyEndDate = null, Expression<Func<bool>> bodyIsArchived = null, Expression<Func<bool>> bodyIsRecycled = null, Expression<Func<int>> bodyLockMode = null, Expression<Func<string>> bodyName = null, Expression<Func<int>> bodyNumberIncremential = null, Expression<Func<string>> bodyNumberPrefix = null, Expression<Func<string>> bodyNumberSuffix = null, Expression<Func<string>> bodyPortfolioId = null, Expression<Func<int>> bodyPriority = null, Expression<Func<string>> bodyProjectStatusId = null, Expression<Func<int>> bodyRiskScore = null, Expression<Func<int>> bodySizeScore = null, Expression<Func<string>> bodyStartDate = null, Expression<Func<int>> bodyValueScore = null)
        {
            var apiCallPath = "/Project";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyClientId != null)
            {
                body["ClientId"] = ExpressionConverter.ConvertO(bodyClientId);
                bodypropCount++;
            }

            if (bodyDescriptionHTML != null)
            {
                body["DescriptionHTML"] = ExpressionConverter.ConvertO(bodyDescriptionHTML);
                bodypropCount++;
            }

            if (bodyDivisionId != null)
            {
                body["DivisionId"] = ExpressionConverter.ConvertO(bodyDivisionId);
                bodypropCount++;
            }

            if (bodyEndDate != null)
            {
                body["EndDate"] = ExpressionConverter.ConvertO(bodyEndDate);
                bodypropCount++;
            }

            if (bodyIsArchived != null)
            {
                body["IsArchived"] = ExpressionConverter.ConvertO(bodyIsArchived);
                bodypropCount++;
            }

            if (bodyIsRecycled != null)
            {
                body["IsRecycled"] = ExpressionConverter.ConvertO(bodyIsRecycled);
                bodypropCount++;
            }

            if (bodyLockMode != null)
            {
                body["LockMode"] = ExpressionConverter.ConvertO(bodyLockMode);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyNumberIncremential != null)
            {
                body["NumberIncremential"] = ExpressionConverter.ConvertO(bodyNumberIncremential);
                bodypropCount++;
            }

            if (bodyNumberPrefix != null)
            {
                body["NumberPrefix"] = ExpressionConverter.ConvertO(bodyNumberPrefix);
                bodypropCount++;
            }

            if (bodyNumberSuffix != null)
            {
                body["NumberSuffix"] = ExpressionConverter.ConvertO(bodyNumberSuffix);
                bodypropCount++;
            }

            if (bodyPortfolioId != null)
            {
                body["PortfolioId"] = ExpressionConverter.ConvertO(bodyPortfolioId);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyProjectStatusId != null)
            {
                body["ProjectStatusId"] = ExpressionConverter.ConvertO(bodyProjectStatusId);
                bodypropCount++;
            }

            if (bodyRiskScore != null)
            {
                body["RiskScore"] = ExpressionConverter.ConvertO(bodyRiskScore);
                bodypropCount++;
            }

            if (bodySizeScore != null)
            {
                body["SizeScore"] = ExpressionConverter.ConvertO(bodySizeScore);
                bodypropCount++;
            }

            if (bodyStartDate != null)
            {
                body["StartDate"] = ExpressionConverter.ConvertO(bodyStartDate);
                bodypropCount++;
            }

            if (bodyValueScore != null)
            {
                body["ValueScore"] = ExpressionConverter.ConvertO(bodyValueScore);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ApiProject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IWorkflowAction DeleteProject(Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/Project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetProjectByIdResponse> GetProjectById(Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/Project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetProjectByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<UpdateProjectResponse> UpdateProject(Expression<Func<string>> projectId, Expression<Func<string>> bodyClientId = null, Expression<Func<string>> bodyDescriptionHTML = null, Expression<Func<string>> bodyDivisionId = null, Expression<Func<string>> bodyEndDate = null, Expression<Func<bool>> bodyIsArchived = null, Expression<Func<bool>> bodyIsRecycled = null, Expression<Func<int>> bodyLockMode = null, Expression<Func<string>> bodyName = null, Expression<Func<int>> bodyNumberIncremential = null, Expression<Func<string>> bodyNumberPrefix = null, Expression<Func<string>> bodyNumberSuffix = null, Expression<Func<string>> bodyPortfolioId = null, Expression<Func<int>> bodyPriority = null, Expression<Func<string>> bodyProjectStatusId = null, Expression<Func<int>> bodyRiskScore = null, Expression<Func<int>> bodySizeScore = null, Expression<Func<string>> bodyStartDate = null, Expression<Func<int>> bodyValueScore = null)
        {
            var apiCallPath = String.Format("/Project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyClientId != null)
            {
                body["ClientId"] = ExpressionConverter.ConvertO(bodyClientId);
                bodypropCount++;
            }

            if (bodyDescriptionHTML != null)
            {
                body["DescriptionHTML"] = ExpressionConverter.ConvertO(bodyDescriptionHTML);
                bodypropCount++;
            }

            if (bodyDivisionId != null)
            {
                body["DivisionId"] = ExpressionConverter.ConvertO(bodyDivisionId);
                bodypropCount++;
            }

            if (bodyEndDate != null)
            {
                body["EndDate"] = ExpressionConverter.ConvertO(bodyEndDate);
                bodypropCount++;
            }

            if (bodyIsArchived != null)
            {
                body["IsArchived"] = ExpressionConverter.ConvertO(bodyIsArchived);
                bodypropCount++;
            }

            if (bodyIsRecycled != null)
            {
                body["IsRecycled"] = ExpressionConverter.ConvertO(bodyIsRecycled);
                bodypropCount++;
            }

            if (bodyLockMode != null)
            {
                body["LockMode"] = ExpressionConverter.ConvertO(bodyLockMode);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyNumberIncremential != null)
            {
                body["NumberIncremential"] = ExpressionConverter.ConvertO(bodyNumberIncremential);
                bodypropCount++;
            }

            if (bodyNumberPrefix != null)
            {
                body["NumberPrefix"] = ExpressionConverter.ConvertO(bodyNumberPrefix);
                bodypropCount++;
            }

            if (bodyNumberSuffix != null)
            {
                body["NumberSuffix"] = ExpressionConverter.ConvertO(bodyNumberSuffix);
                bodypropCount++;
            }

            if (bodyPortfolioId != null)
            {
                body["PortfolioId"] = ExpressionConverter.ConvertO(bodyPortfolioId);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyProjectStatusId != null)
            {
                body["ProjectStatusId"] = ExpressionConverter.ConvertO(bodyProjectStatusId);
                bodypropCount++;
            }

            if (bodyRiskScore != null)
            {
                body["RiskScore"] = ExpressionConverter.ConvertO(bodyRiskScore);
                bodypropCount++;
            }

            if (bodySizeScore != null)
            {
                body["SizeScore"] = ExpressionConverter.ConvertO(bodySizeScore);
                bodypropCount++;
            }

            if (bodyStartDate != null)
            {
                body["StartDate"] = ExpressionConverter.ConvertO(bodyStartDate);
                bodypropCount++;
            }

            if (bodyValueScore != null)
            {
                body["ValueScore"] = ExpressionConverter.ConvertO(bodyValueScore);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IWorkflowAction AddProjectMember(Expression<Func<string>> projectId, Expression<Func<string>> bodycontactId, Expression<Func<int>> bodyrole)
        {
            var apiCallPath = String.Format("/Project/{0}/AddMember", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["contactId"] = ExpressionConverter.ConvertO(bodycontactId);
            bodypropCount++;
            body["role"] = ExpressionConverter.ConvertO(bodyrole);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetTasksResponse> GetTasks(Expression<Func<string>> filter = null, Expression<Func<double>> top = null)
        {
            var apiCallPath = "/Task";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<GetTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<ApiTask> PostTask(Expression<Func<string>> bodyDescriptionHTML = null, Expression<Func<string>> bodyEndDateTime = null, Expression<Func<string>> bodyGroupId = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyProjectId = null, Expression<Func<string>> bodyStartDateTime = null, Expression<Func<double>> bodyWorkAmount = null)
        {
            var apiCallPath = "/Task";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDescriptionHTML != null)
            {
                body["DescriptionHTML"] = ExpressionConverter.ConvertO(bodyDescriptionHTML);
                bodypropCount++;
            }

            if (bodyEndDateTime != null)
            {
                body["EndDateTime"] = ExpressionConverter.ConvertO(bodyEndDateTime);
                bodypropCount++;
            }

            if (bodyGroupId != null)
            {
                body["GroupId"] = ExpressionConverter.ConvertO(bodyGroupId);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyProjectId != null)
            {
                body["ProjectId"] = ExpressionConverter.ConvertO(bodyProjectId);
                bodypropCount++;
            }

            if (bodyStartDateTime != null)
            {
                body["StartDateTime"] = ExpressionConverter.ConvertO(bodyStartDateTime);
                bodypropCount++;
            }

            if (bodyWorkAmount != null)
            {
                body["WorkAmount"] = ExpressionConverter.ConvertO(bodyWorkAmount);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ApiTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IWorkflowAction DeleteTask(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetTaskByIdResponse> GetTaskById(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTaskByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask(Expression<Func<string>> taskId, Expression<Func<string>> bodyDescriptionHTML = null, Expression<Func<string>> bodyEndDateTime = null, Expression<Func<string>> bodyGroupId = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyProjectId = null, Expression<Func<string>> bodyStartDateTime = null, Expression<Func<double>> bodyWorkAmount = null)
        {
            var apiCallPath = String.Format("/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDescriptionHTML != null)
            {
                body["DescriptionHTML"] = ExpressionConverter.ConvertO(bodyDescriptionHTML);
                bodypropCount++;
            }

            if (bodyEndDateTime != null)
            {
                body["EndDateTime"] = ExpressionConverter.ConvertO(bodyEndDateTime);
                bodypropCount++;
            }

            if (bodyGroupId != null)
            {
                body["GroupId"] = ExpressionConverter.ConvertO(bodyGroupId);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyProjectId != null)
            {
                body["ProjectId"] = ExpressionConverter.ConvertO(bodyProjectId);
                bodypropCount++;
            }

            if (bodyStartDateTime != null)
            {
                body["StartDateTime"] = ExpressionConverter.ConvertO(bodyStartDateTime);
                bodypropCount++;
            }

            if (bodyWorkAmount != null)
            {
                body["WorkAmount"] = ExpressionConverter.ConvertO(bodyWorkAmount);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateTaskResponse>(callPayload);
        }
    }

    public class InlooxTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetContactsResponse
    {
        [JsonProperty("value")]
        public ApiContact[] Value { get; set; }
    }

    public class ApiContact
    {
        public string CompanyName { get; set; }
        public string ContactId { get; set; }
        public string DescriptionHTML { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public bool IsIdentity { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    }

    public class GetProjectsResponse
    {
        [JsonProperty("value")]
        public ApiProject[] Value { get; set; }
    }

    public class ApiProject
    {
        public string ProjectId { get; set; }
    }

    public class GetProjectByIdResponse
    {
        [JsonProperty("value")]
        public ApiProject[] Value { get; set; }
    }

    public class UpdateProjectResponse
    {
        [JsonProperty("value")]
        public ApiProject[] Value { get; set; }
    }

    public class GetTasksResponse
    {
        [JsonProperty("value")]
        public ApiTask[] Value { get; set; }
    }

    public class ApiTask
    {
        public string DescriptionHTML { get; set; }
        public string EndDateTime { get; set; }
        public string Name { get; set; }
        public string ProjectId { get; set; }
        public string StartDateTime { get; set; }
        public string TaskId { get; set; }
    }

    public class GetTaskByIdResponse
    {
        [JsonProperty("value")]
        public ApiTask[] Value { get; set; }
    }

    public class UpdateTaskResponse
    {
        [JsonProperty("value")]
        public ApiTask[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Inloox;

    public partial class WorkflowManagedActions
    {
        public InlooxActions Inloox(string connectionId) => new InlooxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InlooxTriggers Inloox(string connectionId) => new InlooxTriggers(connectionId);
    }
}