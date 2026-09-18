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
        public IBodyWorkflowAction<GetContactsResponse> GetContacts([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<double> top = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetProjectsResponse> GetProjects([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<double> top = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Project";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<ApiProject> PostProjects([WorkflowExpression] Func<string> bodyclientId = null, [WorkflowExpression] Func<string> bodydescriptionHTML = null, [WorkflowExpression] Func<string> bodydivisionId = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyisArchived = null, [WorkflowExpression] Func<bool> bodyisRecycled = null, [WorkflowExpression] Func<int> bodylockMode = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodynumberIncremential = null, [WorkflowExpression] Func<string> bodynumberPrefix = null, [WorkflowExpression] Func<string> bodynumberSuffix = null, [WorkflowExpression] Func<string> bodyportfolioId = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodyprojectStatusId = null, [WorkflowExpression] Func<int> bodyriskScore = null, [WorkflowExpression] Func<int> bodysizeScore = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<int> bodyvalueScore = null)
        {
            SourceExpression.Validate(bodyclientId, nameof(bodyclientId), required: false);
            SourceExpression.Validate(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            SourceExpression.Validate(bodydivisionId, nameof(bodydivisionId), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyisArchived, nameof(bodyisArchived), required: false);
            SourceExpression.Validate(bodyisRecycled, nameof(bodyisRecycled), required: false);
            SourceExpression.Validate(bodylockMode, nameof(bodylockMode), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodynumberIncremential, nameof(bodynumberIncremential), required: false);
            SourceExpression.Validate(bodynumberPrefix, nameof(bodynumberPrefix), required: false);
            SourceExpression.Validate(bodynumberSuffix, nameof(bodynumberSuffix), required: false);
            SourceExpression.Validate(bodyportfolioId, nameof(bodyportfolioId), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodyprojectStatusId, nameof(bodyprojectStatusId), required: false);
            SourceExpression.Validate(bodyriskScore, nameof(bodyriskScore), required: false);
            SourceExpression.Validate(bodysizeScore, nameof(bodysizeScore), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyvalueScore, nameof(bodyvalueScore), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyclientId != null)
                {
                    body["ClientId"] = SourceExpressionConverter.ConvertToken(bodyclientId);
                    bodypropCount++;
                }

                if (bodydescriptionHTML != null)
                {
                    body["DescriptionHTML"] = SourceExpressionConverter.ConvertToken(bodydescriptionHTML);
                    bodypropCount++;
                }

                if (bodydivisionId != null)
                {
                    body["DivisionId"] = SourceExpressionConverter.ConvertToken(bodydivisionId);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["EndDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyisArchived != null)
                {
                    body["IsArchived"] = SourceExpressionConverter.ConvertToken(bodyisArchived);
                    bodypropCount++;
                }

                if (bodyisRecycled != null)
                {
                    body["IsRecycled"] = SourceExpressionConverter.ConvertToken(bodyisRecycled);
                    bodypropCount++;
                }

                if (bodylockMode != null)
                {
                    body["LockMode"] = SourceExpressionConverter.ConvertToken(bodylockMode);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodynumberIncremential != null)
                {
                    body["NumberIncremential"] = SourceExpressionConverter.ConvertToken(bodynumberIncremential);
                    bodypropCount++;
                }

                if (bodynumberPrefix != null)
                {
                    body["NumberPrefix"] = SourceExpressionConverter.ConvertToken(bodynumberPrefix);
                    bodypropCount++;
                }

                if (bodynumberSuffix != null)
                {
                    body["NumberSuffix"] = SourceExpressionConverter.ConvertToken(bodynumberSuffix);
                    bodypropCount++;
                }

                if (bodyportfolioId != null)
                {
                    body["PortfolioId"] = SourceExpressionConverter.ConvertToken(bodyportfolioId);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyprojectStatusId != null)
                {
                    body["ProjectStatusId"] = SourceExpressionConverter.ConvertToken(bodyprojectStatusId);
                    bodypropCount++;
                }

                if (bodyriskScore != null)
                {
                    body["RiskScore"] = SourceExpressionConverter.ConvertToken(bodyriskScore);
                    bodypropCount++;
                }

                if (bodysizeScore != null)
                {
                    body["SizeScore"] = SourceExpressionConverter.ConvertToken(bodysizeScore);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["StartDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyvalueScore != null)
                {
                    body["ValueScore"] = SourceExpressionConverter.ConvertToken(bodyvalueScore);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiProject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IWorkflowAction DeleteProject([WorkflowExpression] Func<string> projectId)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Project/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetProjectByIdResponse> GetProjectById([WorkflowExpression] Func<string> projectId)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Project/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<UpdateProjectResponse> UpdateProject([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodyclientId = null, [WorkflowExpression] Func<string> bodydescriptionHTML = null, [WorkflowExpression] Func<string> bodydivisionId = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyisArchived = null, [WorkflowExpression] Func<bool> bodyisRecycled = null, [WorkflowExpression] Func<int> bodylockMode = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodynumberIncremential = null, [WorkflowExpression] Func<string> bodynumberPrefix = null, [WorkflowExpression] Func<string> bodynumberSuffix = null, [WorkflowExpression] Func<string> bodyportfolioId = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodyprojectStatusId = null, [WorkflowExpression] Func<int> bodyriskScore = null, [WorkflowExpression] Func<int> bodysizeScore = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<int> bodyvalueScore = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(bodyclientId, nameof(bodyclientId), required: false);
            SourceExpression.Validate(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            SourceExpression.Validate(bodydivisionId, nameof(bodydivisionId), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyisArchived, nameof(bodyisArchived), required: false);
            SourceExpression.Validate(bodyisRecycled, nameof(bodyisRecycled), required: false);
            SourceExpression.Validate(bodylockMode, nameof(bodylockMode), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodynumberIncremential, nameof(bodynumberIncremential), required: false);
            SourceExpression.Validate(bodynumberPrefix, nameof(bodynumberPrefix), required: false);
            SourceExpression.Validate(bodynumberSuffix, nameof(bodynumberSuffix), required: false);
            SourceExpression.Validate(bodyportfolioId, nameof(bodyportfolioId), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodyprojectStatusId, nameof(bodyprojectStatusId), required: false);
            SourceExpression.Validate(bodyriskScore, nameof(bodyriskScore), required: false);
            SourceExpression.Validate(bodysizeScore, nameof(bodysizeScore), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyvalueScore, nameof(bodyvalueScore), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Project/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyclientId != null)
                {
                    body["ClientId"] = SourceExpressionConverter.ConvertToken(bodyclientId);
                    bodypropCount++;
                }

                if (bodydescriptionHTML != null)
                {
                    body["DescriptionHTML"] = SourceExpressionConverter.ConvertToken(bodydescriptionHTML);
                    bodypropCount++;
                }

                if (bodydivisionId != null)
                {
                    body["DivisionId"] = SourceExpressionConverter.ConvertToken(bodydivisionId);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["EndDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyisArchived != null)
                {
                    body["IsArchived"] = SourceExpressionConverter.ConvertToken(bodyisArchived);
                    bodypropCount++;
                }

                if (bodyisRecycled != null)
                {
                    body["IsRecycled"] = SourceExpressionConverter.ConvertToken(bodyisRecycled);
                    bodypropCount++;
                }

                if (bodylockMode != null)
                {
                    body["LockMode"] = SourceExpressionConverter.ConvertToken(bodylockMode);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodynumberIncremential != null)
                {
                    body["NumberIncremential"] = SourceExpressionConverter.ConvertToken(bodynumberIncremential);
                    bodypropCount++;
                }

                if (bodynumberPrefix != null)
                {
                    body["NumberPrefix"] = SourceExpressionConverter.ConvertToken(bodynumberPrefix);
                    bodypropCount++;
                }

                if (bodynumberSuffix != null)
                {
                    body["NumberSuffix"] = SourceExpressionConverter.ConvertToken(bodynumberSuffix);
                    bodypropCount++;
                }

                if (bodyportfolioId != null)
                {
                    body["PortfolioId"] = SourceExpressionConverter.ConvertToken(bodyportfolioId);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyprojectStatusId != null)
                {
                    body["ProjectStatusId"] = SourceExpressionConverter.ConvertToken(bodyprojectStatusId);
                    bodypropCount++;
                }

                if (bodyriskScore != null)
                {
                    body["RiskScore"] = SourceExpressionConverter.ConvertToken(bodyriskScore);
                    bodypropCount++;
                }

                if (bodysizeScore != null)
                {
                    body["SizeScore"] = SourceExpressionConverter.ConvertToken(bodysizeScore);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["StartDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyvalueScore != null)
                {
                    body["ValueScore"] = SourceExpressionConverter.ConvertToken(bodyvalueScore);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IWorkflowAction AddProjectMember([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodycontactId, [WorkflowExpression] Func<int> bodyrole)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(bodycontactId, nameof(bodycontactId), required: true);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Project/{0}/AddMember", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contactId"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                bodypropCount++;
                body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetTasksResponse> GetTasks([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<double> top = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Task";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<GetTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<ApiTask> PostTask([WorkflowExpression] Func<string> bodydescriptionHTML = null, [WorkflowExpression] Func<string> bodyendDateTime = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodystartDateTime = null, [WorkflowExpression] Func<double> bodyworkAmount = null)
        {
            SourceExpression.Validate(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            SourceExpression.Validate(bodyendDateTime, nameof(bodyendDateTime), required: false);
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodystartDateTime, nameof(bodystartDateTime), required: false);
            SourceExpression.Validate(bodyworkAmount, nameof(bodyworkAmount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescriptionHTML != null)
                {
                    body["DescriptionHTML"] = SourceExpressionConverter.ConvertToken(bodydescriptionHTML);
                    bodypropCount++;
                }

                if (bodyendDateTime != null)
                {
                    body["EndDateTime"] = SourceExpressionConverter.ConvertToken(bodyendDateTime);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["GroupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["ProjectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodystartDateTime != null)
                {
                    body["StartDateTime"] = SourceExpressionConverter.ConvertToken(bodystartDateTime);
                    bodypropCount++;
                }

                if (bodyworkAmount != null)
                {
                    body["WorkAmount"] = SourceExpressionConverter.ConvertToken(bodyworkAmount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiTask>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IWorkflowAction DeleteTask([WorkflowExpression] Func<string> taskId)
        {
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Task/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<GetTaskByIdResponse> GetTaskById([WorkflowExpression] Func<string> taskId)
        {
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Task/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inloox")]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask([WorkflowExpression] Func<string> taskId, [WorkflowExpression] Func<string> bodydescriptionHTML = null, [WorkflowExpression] Func<string> bodyendDateTime = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodystartDateTime = null, [WorkflowExpression] Func<double> bodyworkAmount = null)
        {
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            SourceExpression.Validate(bodydescriptionHTML, nameof(bodydescriptionHTML), required: false);
            SourceExpression.Validate(bodyendDateTime, nameof(bodyendDateTime), required: false);
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodystartDateTime, nameof(bodystartDateTime), required: false);
            SourceExpression.Validate(bodyworkAmount, nameof(bodyworkAmount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Task/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescriptionHTML != null)
                {
                    body["DescriptionHTML"] = SourceExpressionConverter.ConvertToken(bodydescriptionHTML);
                    bodypropCount++;
                }

                if (bodyendDateTime != null)
                {
                    body["EndDateTime"] = SourceExpressionConverter.ConvertToken(bodyendDateTime);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["GroupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["ProjectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodystartDateTime != null)
                {
                    body["StartDateTime"] = SourceExpressionConverter.ConvertToken(bodystartDateTime);
                    bodypropCount++;
                }

                if (bodyworkAmount != null)
                {
                    body["WorkAmount"] = SourceExpressionConverter.ConvertToken(bodyworkAmount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateTaskResponse>(BuildSourceInput);
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