//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Inloox
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
        public IBodyWorkflowAction<ApiProject> PostProjects(Expression<Func<string>> bodyclientId = null, Expression<Func<string>> bodydescriptionHTML = null, Expression<Func<string>> bodydivisionId = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyisArchived = null, Expression<Func<bool>> bodyisRecycled = null, Expression<Func<int>> bodylockMode = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodynumberIncremential = null, Expression<Func<string>> bodynumberPrefix = null, Expression<Func<string>> bodynumberSuffix = null, Expression<Func<string>> bodyportfolioId = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodyprojectStatusId = null, Expression<Func<int>> bodyriskScore = null, Expression<Func<int>> bodysizeScore = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodyvalueScore = null)
        {
            var apiCallPath = "/Project";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyclientId != null)
            {
                body["ClientId"] = ExpressionConverter.ConvertO(bodyclientId);
                bodypropCount++;
            }

            if (bodydescriptionHTML != null)
            {
                body["DescriptionHTML"] = ExpressionConverter.ConvertO(bodydescriptionHTML);
                bodypropCount++;
            }

            if (bodydivisionId != null)
            {
                body["DivisionId"] = ExpressionConverter.ConvertO(bodydivisionId);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["EndDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyisArchived != null)
            {
                body["IsArchived"] = ExpressionConverter.ConvertO(bodyisArchived);
                bodypropCount++;
            }

            if (bodyisRecycled != null)
            {
                body["IsRecycled"] = ExpressionConverter.ConvertO(bodyisRecycled);
                bodypropCount++;
            }

            if (bodylockMode != null)
            {
                body["LockMode"] = ExpressionConverter.ConvertO(bodylockMode);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynumberIncremential != null)
            {
                body["NumberIncremential"] = ExpressionConverter.ConvertO(bodynumberIncremential);
                bodypropCount++;
            }

            if (bodynumberPrefix != null)
            {
                body["NumberPrefix"] = ExpressionConverter.ConvertO(bodynumberPrefix);
                bodypropCount++;
            }

            if (bodynumberSuffix != null)
            {
                body["NumberSuffix"] = ExpressionConverter.ConvertO(bodynumberSuffix);
                bodypropCount++;
            }

            if (bodyportfolioId != null)
            {
                body["PortfolioId"] = ExpressionConverter.ConvertO(bodyportfolioId);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyprojectStatusId != null)
            {
                body["ProjectStatusId"] = ExpressionConverter.ConvertO(bodyprojectStatusId);
                bodypropCount++;
            }

            if (bodyriskScore != null)
            {
                body["RiskScore"] = ExpressionConverter.ConvertO(bodyriskScore);
                bodypropCount++;
            }

            if (bodysizeScore != null)
            {
                body["SizeScore"] = ExpressionConverter.ConvertO(bodysizeScore);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["StartDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyvalueScore != null)
            {
                body["ValueScore"] = ExpressionConverter.ConvertO(bodyvalueScore);
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
        public IBodyWorkflowAction<UpdateProjectResponse> UpdateProject(Expression<Func<string>> projectId, Expression<Func<string>> bodyclientId = null, Expression<Func<string>> bodydescriptionHTML = null, Expression<Func<string>> bodydivisionId = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyisArchived = null, Expression<Func<bool>> bodyisRecycled = null, Expression<Func<int>> bodylockMode = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodynumberIncremential = null, Expression<Func<string>> bodynumberPrefix = null, Expression<Func<string>> bodynumberSuffix = null, Expression<Func<string>> bodyportfolioId = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodyprojectStatusId = null, Expression<Func<int>> bodyriskScore = null, Expression<Func<int>> bodysizeScore = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodyvalueScore = null)
        {
            var apiCallPath = String.Format("/Project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyclientId != null)
            {
                body["ClientId"] = ExpressionConverter.ConvertO(bodyclientId);
                bodypropCount++;
            }

            if (bodydescriptionHTML != null)
            {
                body["DescriptionHTML"] = ExpressionConverter.ConvertO(bodydescriptionHTML);
                bodypropCount++;
            }

            if (bodydivisionId != null)
            {
                body["DivisionId"] = ExpressionConverter.ConvertO(bodydivisionId);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["EndDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyisArchived != null)
            {
                body["IsArchived"] = ExpressionConverter.ConvertO(bodyisArchived);
                bodypropCount++;
            }

            if (bodyisRecycled != null)
            {
                body["IsRecycled"] = ExpressionConverter.ConvertO(bodyisRecycled);
                bodypropCount++;
            }

            if (bodylockMode != null)
            {
                body["LockMode"] = ExpressionConverter.ConvertO(bodylockMode);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynumberIncremential != null)
            {
                body["NumberIncremential"] = ExpressionConverter.ConvertO(bodynumberIncremential);
                bodypropCount++;
            }

            if (bodynumberPrefix != null)
            {
                body["NumberPrefix"] = ExpressionConverter.ConvertO(bodynumberPrefix);
                bodypropCount++;
            }

            if (bodynumberSuffix != null)
            {
                body["NumberSuffix"] = ExpressionConverter.ConvertO(bodynumberSuffix);
                bodypropCount++;
            }

            if (bodyportfolioId != null)
            {
                body["PortfolioId"] = ExpressionConverter.ConvertO(bodyportfolioId);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyprojectStatusId != null)
            {
                body["ProjectStatusId"] = ExpressionConverter.ConvertO(bodyprojectStatusId);
                bodypropCount++;
            }

            if (bodyriskScore != null)
            {
                body["RiskScore"] = ExpressionConverter.ConvertO(bodyriskScore);
                bodypropCount++;
            }

            if (bodysizeScore != null)
            {
                body["SizeScore"] = ExpressionConverter.ConvertO(bodysizeScore);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["StartDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyvalueScore != null)
            {
                body["ValueScore"] = ExpressionConverter.ConvertO(bodyvalueScore);
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
        public IBodyWorkflowAction<ApiTask> PostTask(Expression<Func<string>> bodydescriptionHTML = null, Expression<Func<string>> bodyendDateTime = null, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<string>> bodystartDateTime = null, Expression<Func<double>> bodyworkAmount = null)
        {
            var apiCallPath = "/Task";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescriptionHTML != null)
            {
                body["DescriptionHTML"] = ExpressionConverter.ConvertO(bodydescriptionHTML);
                bodypropCount++;
            }

            if (bodyendDateTime != null)
            {
                body["EndDateTime"] = ExpressionConverter.ConvertO(bodyendDateTime);
                bodypropCount++;
            }

            if (bodygroupId != null)
            {
                body["GroupId"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["ProjectId"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            if (bodystartDateTime != null)
            {
                body["StartDateTime"] = ExpressionConverter.ConvertO(bodystartDateTime);
                bodypropCount++;
            }

            if (bodyworkAmount != null)
            {
                body["WorkAmount"] = ExpressionConverter.ConvertO(bodyworkAmount);
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
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask(Expression<Func<string>> taskId, Expression<Func<string>> bodydescriptionHTML = null, Expression<Func<string>> bodyendDateTime = null, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<string>> bodystartDateTime = null, Expression<Func<double>> bodyworkAmount = null)
        {
            var apiCallPath = String.Format("/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescriptionHTML != null)
            {
                body["DescriptionHTML"] = ExpressionConverter.ConvertO(bodydescriptionHTML);
                bodypropCount++;
            }

            if (bodyendDateTime != null)
            {
                body["EndDateTime"] = ExpressionConverter.ConvertO(bodyendDateTime);
                bodypropCount++;
            }

            if (bodygroupId != null)
            {
                body["GroupId"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["ProjectId"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            if (bodystartDateTime != null)
            {
                body["StartDateTime"] = ExpressionConverter.ConvertO(bodystartDateTime);
                bodypropCount++;
            }

            if (bodyworkAmount != null)
            {
                body["WorkAmount"] = ExpressionConverter.ConvertO(bodyworkAmount);
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Inloox;

    public partial class WorkflowManagedActions
    {
        public InlooxActions Inloox(string connectionId) => new InlooxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InlooxTriggers Inloox(string connectionId) => new InlooxTriggers(connectionId);
    }
}