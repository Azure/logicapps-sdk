//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Inloox
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InlooxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildGetContacts))]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<double> top = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetContactsResponse> __BuildGetContacts(WorkflowValue<string> filter = null, WorkflowValue<double> top = null)
        {
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<GetContactsResponse>(() =>
            {
                var apiCallPath = "/Contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<GetContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjects))]
        public IBodyWorkflowAction<GetProjectsResponse> GetProjects([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<double> top = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectsResponse> __BuildGetProjects(WorkflowValue<string> filter = null, WorkflowValue<double> top = null)
        {
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<GetProjectsResponse>(() =>
            {
                var apiCallPath = "/Project";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<GetProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildPostProjects))]
        public IBodyWorkflowAction<ApiProject> PostProjects([WorkflowExpression] Func<string> bodyclientId = null, [WorkflowExpression] Func<string> bodydescriptionHTML = null, [WorkflowExpression] Func<string> bodydivisionId = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyisArchived = null, [WorkflowExpression] Func<bool> bodyisRecycled = null, [WorkflowExpression] Func<int> bodylockMode = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodynumberIncremential = null, [WorkflowExpression] Func<string> bodynumberPrefix = null, [WorkflowExpression] Func<string> bodynumberSuffix = null, [WorkflowExpression] Func<string> bodyportfolioId = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodyprojectStatusId = null, [WorkflowExpression] Func<int> bodyriskScore = null, [WorkflowExpression] Func<int> bodysizeScore = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<int> bodyvalueScore = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiProject> __BuildPostProjects(WorkflowValue<string> bodyclientId = null, WorkflowValue<string> bodydescriptionHTML = null, WorkflowValue<string> bodydivisionId = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<bool> bodyisArchived = null, WorkflowValue<bool> bodyisRecycled = null, WorkflowValue<int> bodylockMode = null, WorkflowValue<string> bodyname = null, WorkflowValue<int> bodynumberIncremential = null, WorkflowValue<string> bodynumberPrefix = null, WorkflowValue<string> bodynumberSuffix = null, WorkflowValue<string> bodyportfolioId = null, WorkflowValue<int> bodypriority = null, WorkflowValue<string> bodyprojectStatusId = null, WorkflowValue<int> bodyriskScore = null, WorkflowValue<int> bodysizeScore = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<int> bodyvalueScore = null)
        {
            WorkflowValue.Validate(bodyclientId, nameof(bodyclientId), required: false);
            WorkflowValue.Validate(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            WorkflowValue.Validate(bodydivisionId, nameof(bodydivisionId), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodyisArchived, nameof(bodyisArchived), required: false);
            WorkflowValue.Validate(bodyisRecycled, nameof(bodyisRecycled), required: false);
            WorkflowValue.Validate(bodylockMode, nameof(bodylockMode), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodynumberIncremential, nameof(bodynumberIncremential), required: false);
            WorkflowValue.Validate(bodynumberPrefix, nameof(bodynumberPrefix), required: false);
            WorkflowValue.Validate(bodynumberSuffix, nameof(bodynumberSuffix), required: false);
            WorkflowValue.Validate(bodyportfolioId, nameof(bodyportfolioId), required: false);
            WorkflowValue.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowValue.Validate(bodyprojectStatusId, nameof(bodyprojectStatusId), required: false);
            WorkflowValue.Validate(bodyriskScore, nameof(bodyriskScore), required: false);
            WorkflowValue.Validate(bodysizeScore, nameof(bodysizeScore), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyvalueScore, nameof(bodyvalueScore), required: false);
            return new DeferredBodyAction<ApiProject>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteProject))]
        public IWorkflowAction DeleteProject([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteProject(WorkflowValue<string> projectId)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjectById))]
        public IBodyWorkflowAction<GetProjectByIdResponse> GetProjectById([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectByIdResponse> __BuildGetProjectById(WorkflowValue<string> projectId)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateProject))]
        public IBodyWorkflowAction<UpdateProjectResponse> UpdateProject([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodyclientId = null, [WorkflowExpression] Func<string> bodydescriptionHTML = null, [WorkflowExpression] Func<string> bodydivisionId = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyisArchived = null, [WorkflowExpression] Func<bool> bodyisRecycled = null, [WorkflowExpression] Func<int> bodylockMode = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodynumberIncremential = null, [WorkflowExpression] Func<string> bodynumberPrefix = null, [WorkflowExpression] Func<string> bodynumberSuffix = null, [WorkflowExpression] Func<string> bodyportfolioId = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodyprojectStatusId = null, [WorkflowExpression] Func<int> bodyriskScore = null, [WorkflowExpression] Func<int> bodysizeScore = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<int> bodyvalueScore = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateProjectResponse> __BuildUpdateProject(WorkflowValue<string> projectId, WorkflowValue<string> bodyclientId = null, WorkflowValue<string> bodydescriptionHTML = null, WorkflowValue<string> bodydivisionId = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<bool> bodyisArchived = null, WorkflowValue<bool> bodyisRecycled = null, WorkflowValue<int> bodylockMode = null, WorkflowValue<string> bodyname = null, WorkflowValue<int> bodynumberIncremential = null, WorkflowValue<string> bodynumberPrefix = null, WorkflowValue<string> bodynumberSuffix = null, WorkflowValue<string> bodyportfolioId = null, WorkflowValue<int> bodypriority = null, WorkflowValue<string> bodyprojectStatusId = null, WorkflowValue<int> bodyriskScore = null, WorkflowValue<int> bodysizeScore = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<int> bodyvalueScore = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(bodyclientId, nameof(bodyclientId), required: false);
            WorkflowValue.Validate(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            WorkflowValue.Validate(bodydivisionId, nameof(bodydivisionId), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodyisArchived, nameof(bodyisArchived), required: false);
            WorkflowValue.Validate(bodyisRecycled, nameof(bodyisRecycled), required: false);
            WorkflowValue.Validate(bodylockMode, nameof(bodylockMode), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodynumberIncremential, nameof(bodynumberIncremential), required: false);
            WorkflowValue.Validate(bodynumberPrefix, nameof(bodynumberPrefix), required: false);
            WorkflowValue.Validate(bodynumberSuffix, nameof(bodynumberSuffix), required: false);
            WorkflowValue.Validate(bodyportfolioId, nameof(bodyportfolioId), required: false);
            WorkflowValue.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowValue.Validate(bodyprojectStatusId, nameof(bodyprojectStatusId), required: false);
            WorkflowValue.Validate(bodyriskScore, nameof(bodyriskScore), required: false);
            WorkflowValue.Validate(bodysizeScore, nameof(bodysizeScore), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyvalueScore, nameof(bodyvalueScore), required: false);
            return new DeferredBodyAction<UpdateProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildAddProjectMember))]
        public IWorkflowAction AddProjectMember([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodycontactId, [WorkflowExpression] Func<int> bodyrole)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddProjectMember(WorkflowValue<string> projectId, WorkflowValue<string> bodycontactId, WorkflowValue<int> bodyrole)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(bodycontactId, nameof(bodycontactId), required: true);
            WorkflowValue.Validate(bodyrole, nameof(bodyrole), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Project/{0}/AddMember", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildGetTasks))]
        public IBodyWorkflowAction<GetTasksResponse> GetTasks([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<double> top = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTasksResponse> __BuildGetTasks(WorkflowValue<string> filter = null, WorkflowValue<double> top = null)
        {
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<GetTasksResponse>(() =>
            {
                var apiCallPath = "/Task";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<GetTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildPostTask))]
        public IBodyWorkflowAction<ApiTask> PostTask([WorkflowExpression] Func<string> bodydescriptionHTML = null, [WorkflowExpression] Func<string> bodyendDateTime = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodystartDateTime = null, [WorkflowExpression] Func<double> bodyworkAmount = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiTask> __BuildPostTask(WorkflowValue<string> bodydescriptionHTML = null, WorkflowValue<string> bodyendDateTime = null, WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyprojectId = null, WorkflowValue<string> bodystartDateTime = null, WorkflowValue<double> bodyworkAmount = null)
        {
            WorkflowValue.Validate(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            WorkflowValue.Validate(bodyendDateTime, nameof(bodyendDateTime), required: false);
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            WorkflowValue.Validate(bodystartDateTime, nameof(bodystartDateTime), required: false);
            WorkflowValue.Validate(bodyworkAmount, nameof(bodyworkAmount), required: false);
            return new DeferredBodyAction<ApiTask>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTask))]
        public IWorkflowAction DeleteTask([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTask(WorkflowValue<string> taskId)
        {
            WorkflowValue.Validate(taskId, nameof(taskId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildGetTaskById))]
        public IBodyWorkflowAction<GetTaskByIdResponse> GetTaskById([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskByIdResponse> __BuildGetTaskById(WorkflowValue<string> taskId)
        {
            WorkflowValue.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetTaskByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTask))]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask([WorkflowExpression] Func<string> taskId, [WorkflowExpression] Func<string> bodydescriptionHTML = null, [WorkflowExpression] Func<string> bodyendDateTime = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodystartDateTime = null, [WorkflowExpression] Func<double> bodyworkAmount = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateTaskResponse> __BuildUpdateTask(WorkflowValue<string> taskId, WorkflowValue<string> bodydescriptionHTML = null, WorkflowValue<string> bodyendDateTime = null, WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyprojectId = null, WorkflowValue<string> bodystartDateTime = null, WorkflowValue<double> bodyworkAmount = null)
        {
            WorkflowValue.Validate(taskId, nameof(taskId), required: true);
            WorkflowValue.Validate(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            WorkflowValue.Validate(bodyendDateTime, nameof(bodyendDateTime), required: false);
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            WorkflowValue.Validate(bodystartDateTime, nameof(bodystartDateTime), required: false);
            WorkflowValue.Validate(bodyworkAmount, nameof(bodyworkAmount), required: false);
            return new DeferredBodyAction<UpdateTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
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
