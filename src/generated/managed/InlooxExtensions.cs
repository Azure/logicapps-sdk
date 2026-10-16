//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Inloox
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class InlooxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts(Expression<Func<string>> filter = null, Expression<Func<double>> top = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<GetContactsResponse>(() =>
            {
                var apiCallPath = "/Contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<GetContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetProjectsResponse> GetProjects(Expression<Func<string>> filter = null, Expression<Func<double>> top = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<GetProjectsResponse>(() =>
            {
                var apiCallPath = "/Project";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<GetProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<ApiProject> PostProjects(Expression<Func<string>> bodyclientId = null, Expression<Func<string>> bodydescriptionHTML = null, Expression<Func<string>> bodydivisionId = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyisArchived = null, Expression<Func<bool>> bodyisRecycled = null, Expression<Func<int>> bodylockMode = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodynumberIncremential = null, Expression<Func<string>> bodynumberPrefix = null, Expression<Func<string>> bodynumberSuffix = null, Expression<Func<string>> bodyportfolioId = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodyprojectStatusId = null, Expression<Func<int>> bodyriskScore = null, Expression<Func<int>> bodysizeScore = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodyvalueScore = null)
        {
            var __workflow_bodyclientId = WorkflowExpression.Compile(bodyclientId, nameof(bodyclientId), required: false);
            var __workflow_bodydescriptionHTML = WorkflowExpression.Compile(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            var __workflow_bodydivisionId = WorkflowExpression.Compile(bodydivisionId, nameof(bodydivisionId), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyisArchived = WorkflowExpression.Compile(bodyisArchived, nameof(bodyisArchived), required: false);
            var __workflow_bodyisRecycled = WorkflowExpression.Compile(bodyisRecycled, nameof(bodyisRecycled), required: false);
            var __workflow_bodylockMode = WorkflowExpression.Compile(bodylockMode, nameof(bodylockMode), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodynumberIncremential = WorkflowExpression.Compile(bodynumberIncremential, nameof(bodynumberIncremential), required: false);
            var __workflow_bodynumberPrefix = WorkflowExpression.Compile(bodynumberPrefix, nameof(bodynumberPrefix), required: false);
            var __workflow_bodynumberSuffix = WorkflowExpression.Compile(bodynumberSuffix, nameof(bodynumberSuffix), required: false);
            var __workflow_bodyportfolioId = WorkflowExpression.Compile(bodyportfolioId, nameof(bodyportfolioId), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyprojectStatusId = WorkflowExpression.Compile(bodyprojectStatusId, nameof(bodyprojectStatusId), required: false);
            var __workflow_bodyriskScore = WorkflowExpression.Compile(bodyriskScore, nameof(bodyriskScore), required: false);
            var __workflow_bodysizeScore = WorkflowExpression.Compile(bodysizeScore, nameof(bodysizeScore), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyvalueScore = WorkflowExpression.Compile(bodyvalueScore, nameof(bodyvalueScore), required: false);
            return new DeferredBodyAction<ApiProject>(() =>
            {
                var apiCallPath = "/Project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyclientId != null)
                {
                    body["ClientId"] = ExpressionConverter.ConvertO(__workflow_bodyclientId);
                    bodypropCount++;
                }

                if (__workflow_bodydescriptionHTML != null)
                {
                    body["DescriptionHTML"] = ExpressionConverter.ConvertO(__workflow_bodydescriptionHTML);
                    bodypropCount++;
                }

                if (__workflow_bodydivisionId != null)
                {
                    body["DivisionId"] = ExpressionConverter.ConvertO(__workflow_bodydivisionId);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["EndDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyisArchived != null)
                {
                    body["IsArchived"] = ExpressionConverter.ConvertO(__workflow_bodyisArchived);
                    bodypropCount++;
                }

                if (__workflow_bodyisRecycled != null)
                {
                    body["IsRecycled"] = ExpressionConverter.ConvertO(__workflow_bodyisRecycled);
                    bodypropCount++;
                }

                if (__workflow_bodylockMode != null)
                {
                    body["LockMode"] = ExpressionConverter.ConvertO(__workflow_bodylockMode);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodynumberIncremential != null)
                {
                    body["NumberIncremential"] = ExpressionConverter.ConvertO(__workflow_bodynumberIncremential);
                    bodypropCount++;
                }

                if (__workflow_bodynumberPrefix != null)
                {
                    body["NumberPrefix"] = ExpressionConverter.ConvertO(__workflow_bodynumberPrefix);
                    bodypropCount++;
                }

                if (__workflow_bodynumberSuffix != null)
                {
                    body["NumberSuffix"] = ExpressionConverter.ConvertO(__workflow_bodynumberSuffix);
                    bodypropCount++;
                }

                if (__workflow_bodyportfolioId != null)
                {
                    body["PortfolioId"] = ExpressionConverter.ConvertO(__workflow_bodyportfolioId);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectStatusId != null)
                {
                    body["ProjectStatusId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodyriskScore != null)
                {
                    body["RiskScore"] = ExpressionConverter.ConvertO(__workflow_bodyriskScore);
                    bodypropCount++;
                }

                if (__workflow_bodysizeScore != null)
                {
                    body["SizeScore"] = ExpressionConverter.ConvertO(__workflow_bodysizeScore);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["StartDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueScore != null)
                {
                    body["ValueScore"] = ExpressionConverter.ConvertO(__workflow_bodyvalueScore);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ApiProject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IWorkflowAction DeleteProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Project/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetProjectByIdResponse> GetProjectById(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Project/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<UpdateProjectResponse> UpdateProject(Expression<Func<string>> projectId, Expression<Func<string>> bodyclientId = null, Expression<Func<string>> bodydescriptionHTML = null, Expression<Func<string>> bodydivisionId = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyisArchived = null, Expression<Func<bool>> bodyisRecycled = null, Expression<Func<int>> bodylockMode = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodynumberIncremential = null, Expression<Func<string>> bodynumberPrefix = null, Expression<Func<string>> bodynumberSuffix = null, Expression<Func<string>> bodyportfolioId = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodyprojectStatusId = null, Expression<Func<int>> bodyriskScore = null, Expression<Func<int>> bodysizeScore = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodyvalueScore = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_bodyclientId = WorkflowExpression.Compile(bodyclientId, nameof(bodyclientId), required: false);
            var __workflow_bodydescriptionHTML = WorkflowExpression.Compile(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            var __workflow_bodydivisionId = WorkflowExpression.Compile(bodydivisionId, nameof(bodydivisionId), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyisArchived = WorkflowExpression.Compile(bodyisArchived, nameof(bodyisArchived), required: false);
            var __workflow_bodyisRecycled = WorkflowExpression.Compile(bodyisRecycled, nameof(bodyisRecycled), required: false);
            var __workflow_bodylockMode = WorkflowExpression.Compile(bodylockMode, nameof(bodylockMode), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodynumberIncremential = WorkflowExpression.Compile(bodynumberIncremential, nameof(bodynumberIncremential), required: false);
            var __workflow_bodynumberPrefix = WorkflowExpression.Compile(bodynumberPrefix, nameof(bodynumberPrefix), required: false);
            var __workflow_bodynumberSuffix = WorkflowExpression.Compile(bodynumberSuffix, nameof(bodynumberSuffix), required: false);
            var __workflow_bodyportfolioId = WorkflowExpression.Compile(bodyportfolioId, nameof(bodyportfolioId), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyprojectStatusId = WorkflowExpression.Compile(bodyprojectStatusId, nameof(bodyprojectStatusId), required: false);
            var __workflow_bodyriskScore = WorkflowExpression.Compile(bodyriskScore, nameof(bodyriskScore), required: false);
            var __workflow_bodysizeScore = WorkflowExpression.Compile(bodysizeScore, nameof(bodysizeScore), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyvalueScore = WorkflowExpression.Compile(bodyvalueScore, nameof(bodyvalueScore), required: false);
            return new DeferredBodyAction<UpdateProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Project/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyclientId != null)
                {
                    body["ClientId"] = ExpressionConverter.ConvertO(__workflow_bodyclientId);
                    bodypropCount++;
                }

                if (__workflow_bodydescriptionHTML != null)
                {
                    body["DescriptionHTML"] = ExpressionConverter.ConvertO(__workflow_bodydescriptionHTML);
                    bodypropCount++;
                }

                if (__workflow_bodydivisionId != null)
                {
                    body["DivisionId"] = ExpressionConverter.ConvertO(__workflow_bodydivisionId);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["EndDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyisArchived != null)
                {
                    body["IsArchived"] = ExpressionConverter.ConvertO(__workflow_bodyisArchived);
                    bodypropCount++;
                }

                if (__workflow_bodyisRecycled != null)
                {
                    body["IsRecycled"] = ExpressionConverter.ConvertO(__workflow_bodyisRecycled);
                    bodypropCount++;
                }

                if (__workflow_bodylockMode != null)
                {
                    body["LockMode"] = ExpressionConverter.ConvertO(__workflow_bodylockMode);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodynumberIncremential != null)
                {
                    body["NumberIncremential"] = ExpressionConverter.ConvertO(__workflow_bodynumberIncremential);
                    bodypropCount++;
                }

                if (__workflow_bodynumberPrefix != null)
                {
                    body["NumberPrefix"] = ExpressionConverter.ConvertO(__workflow_bodynumberPrefix);
                    bodypropCount++;
                }

                if (__workflow_bodynumberSuffix != null)
                {
                    body["NumberSuffix"] = ExpressionConverter.ConvertO(__workflow_bodynumberSuffix);
                    bodypropCount++;
                }

                if (__workflow_bodyportfolioId != null)
                {
                    body["PortfolioId"] = ExpressionConverter.ConvertO(__workflow_bodyportfolioId);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectStatusId != null)
                {
                    body["ProjectStatusId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodyriskScore != null)
                {
                    body["RiskScore"] = ExpressionConverter.ConvertO(__workflow_bodyriskScore);
                    bodypropCount++;
                }

                if (__workflow_bodysizeScore != null)
                {
                    body["SizeScore"] = ExpressionConverter.ConvertO(__workflow_bodysizeScore);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["StartDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueScore != null)
                {
                    body["ValueScore"] = ExpressionConverter.ConvertO(__workflow_bodyvalueScore);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IWorkflowAction AddProjectMember(Expression<Func<string>> projectId, Expression<Func<string>> bodycontactId, Expression<Func<int>> bodyrole)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: true);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Project/{0}/AddMember", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contactId"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                bodypropCount++;
                body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetTasksResponse> GetTasks(Expression<Func<string>> filter = null, Expression<Func<double>> top = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<GetTasksResponse>(() =>
            {
                var apiCallPath = "/Task";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<GetTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<ApiTask> PostTask(Expression<Func<string>> bodydescriptionHTML = null, Expression<Func<string>> bodyendDateTime = null, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<string>> bodystartDateTime = null, Expression<Func<double>> bodyworkAmount = null)
        {
            var __workflow_bodydescriptionHTML = WorkflowExpression.Compile(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            var __workflow_bodyendDateTime = WorkflowExpression.Compile(bodyendDateTime, nameof(bodyendDateTime), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodystartDateTime = WorkflowExpression.Compile(bodystartDateTime, nameof(bodystartDateTime), required: false);
            var __workflow_bodyworkAmount = WorkflowExpression.Compile(bodyworkAmount, nameof(bodyworkAmount), required: false);
            return new DeferredBodyAction<ApiTask>(() =>
            {
                var apiCallPath = "/Task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescriptionHTML != null)
                {
                    body["DescriptionHTML"] = ExpressionConverter.ConvertO(__workflow_bodydescriptionHTML);
                    bodypropCount++;
                }

                if (__workflow_bodyendDateTime != null)
                {
                    body["EndDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyendDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["GroupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["ProjectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodystartDateTime != null)
                {
                    body["StartDateTime"] = ExpressionConverter.ConvertO(__workflow_bodystartDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodyworkAmount != null)
                {
                    body["WorkAmount"] = ExpressionConverter.ConvertO(__workflow_bodyworkAmount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ApiTask>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IWorkflowAction DeleteTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetTaskByIdResponse> GetTaskById(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetTaskByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask(Expression<Func<string>> taskId, Expression<Func<string>> bodydescriptionHTML = null, Expression<Func<string>> bodyendDateTime = null, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<string>> bodystartDateTime = null, Expression<Func<double>> bodyworkAmount = null)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_bodydescriptionHTML = WorkflowExpression.Compile(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            var __workflow_bodyendDateTime = WorkflowExpression.Compile(bodyendDateTime, nameof(bodyendDateTime), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodystartDateTime = WorkflowExpression.Compile(bodystartDateTime, nameof(bodystartDateTime), required: false);
            var __workflow_bodyworkAmount = WorkflowExpression.Compile(bodyworkAmount, nameof(bodyworkAmount), required: false);
            return new DeferredBodyAction<UpdateTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescriptionHTML != null)
                {
                    body["DescriptionHTML"] = ExpressionConverter.ConvertO(__workflow_bodydescriptionHTML);
                    bodypropCount++;
                }

                if (__workflow_bodyendDateTime != null)
                {
                    body["EndDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyendDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["GroupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["ProjectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodystartDateTime != null)
                {
                    body["StartDateTime"] = ExpressionConverter.ConvertO(__workflow_bodystartDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodyworkAmount != null)
                {
                    body["WorkAmount"] = ExpressionConverter.ConvertO(__workflow_bodyworkAmount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateTaskResponse>(callPayload);
            });
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
