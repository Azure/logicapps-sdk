//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Insightly
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InsightlyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListTasksResponse> ListTasks()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<TaskObject> UpdateTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> updatedTasktaskTitle, [WorkflowExpression] Func<bool> updatedTaskisCompleted, [WorkflowExpression] Func<updatedTasktaskStatusInput> updatedTasktaskStatus, [WorkflowExpression] Func<bool> updatedTaskisTaskVisible, [WorkflowExpression] Func<string> updatedTaskdueDateTime = null, [WorkflowExpression] Func<string> updatedTasktaskDetails = null, [WorkflowExpression] Func<int> updatedTasktaskPriority = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(updatedTasktaskTitle, nameof(updatedTasktaskTitle), required: true);
            SourceExpression.Validate(updatedTaskisCompleted, nameof(updatedTaskisCompleted), required: true);
            SourceExpression.Validate(updatedTasktaskStatus, nameof(updatedTasktaskStatus), required: true);
            SourceExpression.Validate(updatedTaskisTaskVisible, nameof(updatedTaskisTaskVisible), required: true);
            SourceExpression.Validate(updatedTaskdueDateTime, nameof(updatedTaskdueDateTime), required: false);
            SourceExpression.Validate(updatedTasktaskDetails, nameof(updatedTasktaskDetails), required: false);
            SourceExpression.Validate(updatedTasktaskPriority, nameof(updatedTasktaskPriority), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Tasks";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                var updatedTask = new JObject();
                var updatedTaskpropCount = 0;
                updatedTaskpropCount++;
                updatedTask["TITLE"] = SourceExpressionConverter.ConvertToken(updatedTasktaskTitle);
                if (updatedTaskdueDateTime != null)
                {
                    updatedTask["DUE_DATE"] = SourceExpressionConverter.ConvertToken(updatedTaskdueDateTime);
                    updatedTaskpropCount++;
                }

                updatedTaskpropCount++;
                updatedTask["COMPLETED"] = SourceExpressionConverter.ConvertToken(updatedTaskisCompleted);
                if (updatedTasktaskDetails != null)
                {
                    updatedTask["DETAILS"] = SourceExpressionConverter.ConvertToken(updatedTasktaskDetails);
                    updatedTaskpropCount++;
                }

                updatedTaskpropCount++;
                updatedTask["STATUS"] = SourceExpressionConverter.Convert(updatedTasktaskStatus);
                if (updatedTasktaskPriority != null)
                {
                    updatedTask["PRIORITY"] = SourceExpressionConverter.ConvertToken(updatedTasktaskPriority);
                    updatedTaskpropCount++;
                }

                updatedTaskpropCount++;
                updatedTask["PUBLICLY_VISIBLE"] = SourceExpressionConverter.ConvertToken(updatedTaskisTaskVisible);
                if (updatedTaskpropCount > 0)
                {
                    callPayload.Body = updatedTask;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskObject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<TaskObject> AddTask([WorkflowExpression] Func<string> newTasktaskTitle, [WorkflowExpression] Func<bool> newTaskisCompleted, [WorkflowExpression] Func<newTasktaskStatusInput> newTasktaskStatus, [WorkflowExpression] Func<bool> newTaskisTaskVisible, [WorkflowExpression] Func<string> newTaskdueDateTime = null, [WorkflowExpression] Func<string> newTasktaskDetails = null, [WorkflowExpression] Func<int> newTasktaskPriority = null)
        {
            SourceExpression.Validate(newTasktaskTitle, nameof(newTasktaskTitle), required: true);
            SourceExpression.Validate(newTaskisCompleted, nameof(newTaskisCompleted), required: true);
            SourceExpression.Validate(newTasktaskStatus, nameof(newTasktaskStatus), required: true);
            SourceExpression.Validate(newTaskisTaskVisible, nameof(newTaskisTaskVisible), required: true);
            SourceExpression.Validate(newTaskdueDateTime, nameof(newTaskdueDateTime), required: false);
            SourceExpression.Validate(newTasktaskDetails, nameof(newTasktaskDetails), required: false);
            SourceExpression.Validate(newTasktaskPriority, nameof(newTasktaskPriority), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newTask = new JObject();
                var newTaskpropCount = 0;
                newTaskpropCount++;
                newTask["TITLE"] = SourceExpressionConverter.ConvertToken(newTasktaskTitle);
                if (newTaskdueDateTime != null)
                {
                    newTask["DUE_DATE"] = SourceExpressionConverter.ConvertToken(newTaskdueDateTime);
                    newTaskpropCount++;
                }

                newTaskpropCount++;
                newTask["COMPLETED"] = SourceExpressionConverter.ConvertToken(newTaskisCompleted);
                if (newTasktaskDetails != null)
                {
                    newTask["DETAILS"] = SourceExpressionConverter.ConvertToken(newTasktaskDetails);
                    newTaskpropCount++;
                }

                newTaskpropCount++;
                newTask["STATUS"] = SourceExpressionConverter.Convert(newTasktaskStatus);
                if (newTasktaskPriority != null)
                {
                    newTask["PRIORITY"] = SourceExpressionConverter.ConvertToken(newTasktaskPriority);
                    newTaskpropCount++;
                }

                newTaskpropCount++;
                newTask["PUBLICLY_VISIBLE"] = SourceExpressionConverter.ConvertToken(newTaskisTaskVisible);
                if (newTaskpropCount > 0)
                {
                    callPayload.Body = newTask;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskObject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListProjectsResponse> ListProjects()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListProjectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Project> UpdateProject([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> updatedProjectprojectName, [WorkflowExpression] Func<updatedProjectprojectStatusInput> updatedProjectprojectStatus, [WorkflowExpression] Func<string> updatedProjectprojectDetails = null, [WorkflowExpression] Func<string> updatedProjectimageURL = null, [WorkflowExpression] Func<updatedProjectprojectVisibilityInput> updatedProjectprojectVisibility = null, [WorkflowExpression] Func<int> updatedProjectvisibleTeamId = null, [WorkflowExpression] Func<int> updatedProjectvisibleUserIDs = null, [WorkflowExpression] Func<int> updatedProjectopportunityId = null, [WorkflowExpression] Func<int> updatedProjectpipelineId = null, [WorkflowExpression] Func<int> updatedProjectstageId = null, [WorkflowExpression] Func<Tag[]> updatedProjecttags = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(updatedProjectprojectName, nameof(updatedProjectprojectName), required: true);
            SourceExpression.Validate(updatedProjectprojectStatus, nameof(updatedProjectprojectStatus), required: true);
            SourceExpression.Validate(updatedProjectprojectDetails, nameof(updatedProjectprojectDetails), required: false);
            SourceExpression.Validate(updatedProjectimageURL, nameof(updatedProjectimageURL), required: false);
            SourceExpression.Validate(updatedProjectprojectVisibility, nameof(updatedProjectprojectVisibility), required: false);
            SourceExpression.Validate(updatedProjectvisibleTeamId, nameof(updatedProjectvisibleTeamId), required: false);
            SourceExpression.Validate(updatedProjectvisibleUserIDs, nameof(updatedProjectvisibleUserIDs), required: false);
            SourceExpression.Validate(updatedProjectopportunityId, nameof(updatedProjectopportunityId), required: false);
            SourceExpression.Validate(updatedProjectpipelineId, nameof(updatedProjectpipelineId), required: false);
            SourceExpression.Validate(updatedProjectstageId, nameof(updatedProjectstageId), required: false);
            SourceExpression.Validate(updatedProjecttags, nameof(updatedProjecttags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Projects";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                var updatedProject = new JObject();
                var updatedProjectpropCount = 0;
                updatedProjectpropCount++;
                updatedProject["PROJECT_NAME"] = SourceExpressionConverter.ConvertToken(updatedProjectprojectName);
                if (updatedProjectprojectDetails != null)
                {
                    updatedProject["PROJECT_DETAILS"] = SourceExpressionConverter.ConvertToken(updatedProjectprojectDetails);
                    updatedProjectpropCount++;
                }

                updatedProjectpropCount++;
                updatedProject["STATUS"] = SourceExpressionConverter.Convert(updatedProjectprojectStatus);
                if (updatedProjectimageURL != null)
                {
                    updatedProject["IMAGE_URL"] = SourceExpressionConverter.ConvertToken(updatedProjectimageURL);
                    updatedProjectpropCount++;
                }

                if (updatedProjectprojectVisibility != null)
                {
                    updatedProject["VISIBLE_TO"] = SourceExpressionConverter.Convert(updatedProjectprojectVisibility);
                    updatedProjectpropCount++;
                }

                if (updatedProjectvisibleTeamId != null)
                {
                    updatedProject["VISIBLE_TEAM_ID"] = SourceExpressionConverter.ConvertToken(updatedProjectvisibleTeamId);
                    updatedProjectpropCount++;
                }

                if (updatedProjectvisibleUserIDs != null)
                {
                    updatedProject["VISIBLE_USER_IDS"] = SourceExpressionConverter.ConvertToken(updatedProjectvisibleUserIDs);
                    updatedProjectpropCount++;
                }

                if (updatedProjectopportunityId != null)
                {
                    updatedProject["OPPORTUNITY_ID"] = SourceExpressionConverter.ConvertToken(updatedProjectopportunityId);
                    updatedProjectpropCount++;
                }

                if (updatedProjectpipelineId != null)
                {
                    updatedProject["PIPELINE_ID"] = SourceExpressionConverter.ConvertToken(updatedProjectpipelineId);
                    updatedProjectpropCount++;
                }

                if (updatedProjectstageId != null)
                {
                    updatedProject["STAGE_ID"] = SourceExpressionConverter.ConvertToken(updatedProjectstageId);
                    updatedProjectpropCount++;
                }

                if (updatedProjecttags != null)
                {
                    updatedProject["TAGS"] = SourceExpressionConverter.ConvertToken(updatedProjecttags);
                    updatedProjectpropCount++;
                }

                if (updatedProjectpropCount > 0)
                {
                    callPayload.Body = updatedProject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Project>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Project> AddProject([WorkflowExpression] Func<string> newProjectprojectName, [WorkflowExpression] Func<newProjectprojectStatusInput> newProjectprojectStatus, [WorkflowExpression] Func<string> newProjectprojectDetails = null, [WorkflowExpression] Func<string> newProjectimageURL = null, [WorkflowExpression] Func<newProjectprojectVisibilityInput> newProjectprojectVisibility = null, [WorkflowExpression] Func<int> newProjectvisibleTeamId = null, [WorkflowExpression] Func<int> newProjectvisibleUserIDs = null, [WorkflowExpression] Func<int> newProjectopportunityId = null, [WorkflowExpression] Func<int> newProjectpipelineId = null, [WorkflowExpression] Func<int> newProjectstageId = null, [WorkflowExpression] Func<Tag[]> newProjecttags = null)
        {
            SourceExpression.Validate(newProjectprojectName, nameof(newProjectprojectName), required: true);
            SourceExpression.Validate(newProjectprojectStatus, nameof(newProjectprojectStatus), required: true);
            SourceExpression.Validate(newProjectprojectDetails, nameof(newProjectprojectDetails), required: false);
            SourceExpression.Validate(newProjectimageURL, nameof(newProjectimageURL), required: false);
            SourceExpression.Validate(newProjectprojectVisibility, nameof(newProjectprojectVisibility), required: false);
            SourceExpression.Validate(newProjectvisibleTeamId, nameof(newProjectvisibleTeamId), required: false);
            SourceExpression.Validate(newProjectvisibleUserIDs, nameof(newProjectvisibleUserIDs), required: false);
            SourceExpression.Validate(newProjectopportunityId, nameof(newProjectopportunityId), required: false);
            SourceExpression.Validate(newProjectpipelineId, nameof(newProjectpipelineId), required: false);
            SourceExpression.Validate(newProjectstageId, nameof(newProjectstageId), required: false);
            SourceExpression.Validate(newProjecttags, nameof(newProjecttags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newProject = new JObject();
                var newProjectpropCount = 0;
                newProjectpropCount++;
                newProject["PROJECT_NAME"] = SourceExpressionConverter.ConvertToken(newProjectprojectName);
                if (newProjectprojectDetails != null)
                {
                    newProject["PROJECT_DETAILS"] = SourceExpressionConverter.ConvertToken(newProjectprojectDetails);
                    newProjectpropCount++;
                }

                newProjectpropCount++;
                newProject["STATUS"] = SourceExpressionConverter.Convert(newProjectprojectStatus);
                if (newProjectimageURL != null)
                {
                    newProject["IMAGE_URL"] = SourceExpressionConverter.ConvertToken(newProjectimageURL);
                    newProjectpropCount++;
                }

                if (newProjectprojectVisibility != null)
                {
                    newProject["VISIBLE_TO"] = SourceExpressionConverter.Convert(newProjectprojectVisibility);
                    newProjectpropCount++;
                }

                if (newProjectvisibleTeamId != null)
                {
                    newProject["VISIBLE_TEAM_ID"] = SourceExpressionConverter.ConvertToken(newProjectvisibleTeamId);
                    newProjectpropCount++;
                }

                if (newProjectvisibleUserIDs != null)
                {
                    newProject["VISIBLE_USER_IDS"] = SourceExpressionConverter.ConvertToken(newProjectvisibleUserIDs);
                    newProjectpropCount++;
                }

                if (newProjectopportunityId != null)
                {
                    newProject["OPPORTUNITY_ID"] = SourceExpressionConverter.ConvertToken(newProjectopportunityId);
                    newProjectpropCount++;
                }

                if (newProjectpipelineId != null)
                {
                    newProject["PIPELINE_ID"] = SourceExpressionConverter.ConvertToken(newProjectpipelineId);
                    newProjectpropCount++;
                }

                if (newProjectstageId != null)
                {
                    newProject["STAGE_ID"] = SourceExpressionConverter.ConvertToken(newProjectstageId);
                    newProjectpropCount++;
                }

                if (newProjecttags != null)
                {
                    newProject["TAGS"] = SourceExpressionConverter.ConvertToken(newProjecttags);
                    newProjectpropCount++;
                }

                if (newProjectpropCount > 0)
                {
                    callPayload.Body = newProject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Project>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListLeadsResponse> ListLeads()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListLeadsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Lead> UpdateLead([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> updatedLeadlastName, [WorkflowExpression] Func<string> updatedLeadtitle = null, [WorkflowExpression] Func<string> updatedLeadfirstName = null, [WorkflowExpression] Func<string> updatedLeadleadDescription = null, [WorkflowExpression] Func<string> updatedLeadconvertedDateTime = null, [WorkflowExpression] Func<updatedLeadleadVisibilityInput> updatedLeadleadVisibility = null, [WorkflowExpression] Func<int> updatedLeadvisibleTeamId = null, [WorkflowExpression] Func<int> updatedLeadvisibleUserIDs = null, [WorkflowExpression] Func<string> updatedLeadorganizationName = null, [WorkflowExpression] Func<string> updatedLeadphoneNumber = null, [WorkflowExpression] Func<string> updatedLeadmobilePhoneNumber = null, [WorkflowExpression] Func<string> updatedLeademailAddress = null, [WorkflowExpression] Func<bool> updatedLeadisConverted = null, [WorkflowExpression] Func<string> updatedLeadwebsiteURL = null, [WorkflowExpression] Func<int> updatedLeadleadOwner = null, [WorkflowExpression] Func<int> updatedLeadleadResponsible = null, [WorkflowExpression] Func<int> updatedLeadleadEmployeeCount = null, [WorkflowExpression] Func<int> updatedLeadleadRating = null, [WorkflowExpression] Func<string> updatedLeadindustry = null, [WorkflowExpression] Func<Tag[]> updatedLeadtag = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(updatedLeadlastName, nameof(updatedLeadlastName), required: true);
            SourceExpression.Validate(updatedLeadtitle, nameof(updatedLeadtitle), required: false);
            SourceExpression.Validate(updatedLeadfirstName, nameof(updatedLeadfirstName), required: false);
            SourceExpression.Validate(updatedLeadleadDescription, nameof(updatedLeadleadDescription), required: false);
            SourceExpression.Validate(updatedLeadconvertedDateTime, nameof(updatedLeadconvertedDateTime), required: false);
            SourceExpression.Validate(updatedLeadleadVisibility, nameof(updatedLeadleadVisibility), required: false);
            SourceExpression.Validate(updatedLeadvisibleTeamId, nameof(updatedLeadvisibleTeamId), required: false);
            SourceExpression.Validate(updatedLeadvisibleUserIDs, nameof(updatedLeadvisibleUserIDs), required: false);
            SourceExpression.Validate(updatedLeadorganizationName, nameof(updatedLeadorganizationName), required: false);
            SourceExpression.Validate(updatedLeadphoneNumber, nameof(updatedLeadphoneNumber), required: false);
            SourceExpression.Validate(updatedLeadmobilePhoneNumber, nameof(updatedLeadmobilePhoneNumber), required: false);
            SourceExpression.Validate(updatedLeademailAddress, nameof(updatedLeademailAddress), required: false);
            SourceExpression.Validate(updatedLeadisConverted, nameof(updatedLeadisConverted), required: false);
            SourceExpression.Validate(updatedLeadwebsiteURL, nameof(updatedLeadwebsiteURL), required: false);
            SourceExpression.Validate(updatedLeadleadOwner, nameof(updatedLeadleadOwner), required: false);
            SourceExpression.Validate(updatedLeadleadResponsible, nameof(updatedLeadleadResponsible), required: false);
            SourceExpression.Validate(updatedLeadleadEmployeeCount, nameof(updatedLeadleadEmployeeCount), required: false);
            SourceExpression.Validate(updatedLeadleadRating, nameof(updatedLeadleadRating), required: false);
            SourceExpression.Validate(updatedLeadindustry, nameof(updatedLeadindustry), required: false);
            SourceExpression.Validate(updatedLeadtag, nameof(updatedLeadtag), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Leads";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                var updatedLead = new JObject();
                var updatedLeadpropCount = 0;
                if (updatedLeadtitle != null)
                {
                    updatedLead["TITLE"] = SourceExpressionConverter.ConvertToken(updatedLeadtitle);
                    updatedLeadpropCount++;
                }

                if (updatedLeadfirstName != null)
                {
                    updatedLead["FIRST_NAME"] = SourceExpressionConverter.ConvertToken(updatedLeadfirstName);
                    updatedLeadpropCount++;
                }

                updatedLeadpropCount++;
                updatedLead["LAST_NAME"] = SourceExpressionConverter.ConvertToken(updatedLeadlastName);
                if (updatedLeadleadDescription != null)
                {
                    updatedLead["LEAD_DESCRIPTION"] = SourceExpressionConverter.ConvertToken(updatedLeadleadDescription);
                    updatedLeadpropCount++;
                }

                if (updatedLeadconvertedDateTime != null)
                {
                    updatedLead["CONVERTED_DATE_UTC"] = SourceExpressionConverter.ConvertToken(updatedLeadconvertedDateTime);
                    updatedLeadpropCount++;
                }

                if (updatedLeadleadVisibility != null)
                {
                    updatedLead["VISIBLE_TO"] = SourceExpressionConverter.Convert(updatedLeadleadVisibility);
                    updatedLeadpropCount++;
                }

                if (updatedLeadvisibleTeamId != null)
                {
                    updatedLead["VISIBLE_TEAM_ID"] = SourceExpressionConverter.ConvertToken(updatedLeadvisibleTeamId);
                    updatedLeadpropCount++;
                }

                if (updatedLeadvisibleUserIDs != null)
                {
                    updatedLead["VISIBLE_USER_IDS"] = SourceExpressionConverter.ConvertToken(updatedLeadvisibleUserIDs);
                    updatedLeadpropCount++;
                }

                if (updatedLeadorganizationName != null)
                {
                    updatedLead["ORGANIZATION_NAME"] = SourceExpressionConverter.ConvertToken(updatedLeadorganizationName);
                    updatedLeadpropCount++;
                }

                if (updatedLeadphoneNumber != null)
                {
                    updatedLead["PHONE_NUMBER"] = SourceExpressionConverter.ConvertToken(updatedLeadphoneNumber);
                    updatedLeadpropCount++;
                }

                if (updatedLeadmobilePhoneNumber != null)
                {
                    updatedLead["MOBILE_PHONE_NUMBER"] = SourceExpressionConverter.ConvertToken(updatedLeadmobilePhoneNumber);
                    updatedLeadpropCount++;
                }

                if (updatedLeademailAddress != null)
                {
                    updatedLead["EMAIL_ADDRESS"] = SourceExpressionConverter.ConvertToken(updatedLeademailAddress);
                    updatedLeadpropCount++;
                }

                if (updatedLeadisConverted != null)
                {
                    updatedLead["CONVERTED"] = SourceExpressionConverter.ConvertToken(updatedLeadisConverted);
                    updatedLeadpropCount++;
                }

                if (updatedLeadwebsiteURL != null)
                {
                    updatedLead["WEBSITE_URL"] = SourceExpressionConverter.ConvertToken(updatedLeadwebsiteURL);
                    updatedLeadpropCount++;
                }

                if (updatedLeadleadOwner != null)
                {
                    updatedLead["OWNER_USER_ID"] = SourceExpressionConverter.ConvertToken(updatedLeadleadOwner);
                    updatedLeadpropCount++;
                }

                if (updatedLeadleadResponsible != null)
                {
                    updatedLead["RESPONSIBLE_USER_ID"] = SourceExpressionConverter.ConvertToken(updatedLeadleadResponsible);
                    updatedLeadpropCount++;
                }

                if (updatedLeadleadEmployeeCount != null)
                {
                    updatedLead["EMPLOYEE_COUNT"] = SourceExpressionConverter.ConvertToken(updatedLeadleadEmployeeCount);
                    updatedLeadpropCount++;
                }

                if (updatedLeadleadRating != null)
                {
                    updatedLead["LEAD_RATING"] = SourceExpressionConverter.ConvertToken(updatedLeadleadRating);
                    updatedLeadpropCount++;
                }

                if (updatedLeadindustry != null)
                {
                    updatedLead["INDUSTRY"] = SourceExpressionConverter.ConvertToken(updatedLeadindustry);
                    updatedLeadpropCount++;
                }

                if (updatedLeadtag != null)
                {
                    updatedLead["TAGS"] = SourceExpressionConverter.ConvertToken(updatedLeadtag);
                    updatedLeadpropCount++;
                }

                if (updatedLeadpropCount > 0)
                {
                    callPayload.Body = updatedLead;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Lead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Lead> AddLead([WorkflowExpression] Func<string> newLeadlastName, [WorkflowExpression] Func<string> newLeadtitle = null, [WorkflowExpression] Func<string> newLeadfirstName = null, [WorkflowExpression] Func<string> newLeadleadDescription = null, [WorkflowExpression] Func<string> newLeadconvertedDateTime = null, [WorkflowExpression] Func<newLeadleadVisibilityInput> newLeadleadVisibility = null, [WorkflowExpression] Func<int> newLeadvisibleTeamId = null, [WorkflowExpression] Func<int> newLeadvisibleUserIDs = null, [WorkflowExpression] Func<string> newLeadorganizationName = null, [WorkflowExpression] Func<string> newLeadphoneNumber = null, [WorkflowExpression] Func<string> newLeadmobilePhoneNumber = null, [WorkflowExpression] Func<string> newLeademailAddress = null, [WorkflowExpression] Func<bool> newLeadisConverted = null, [WorkflowExpression] Func<string> newLeadwebsiteURL = null, [WorkflowExpression] Func<int> newLeadleadOwner = null, [WorkflowExpression] Func<int> newLeadleadResponsible = null, [WorkflowExpression] Func<int> newLeadleadEmployeeCount = null, [WorkflowExpression] Func<int> newLeadleadRating = null, [WorkflowExpression] Func<string> newLeadindustry = null, [WorkflowExpression] Func<Tag[]> newLeadtag = null)
        {
            SourceExpression.Validate(newLeadlastName, nameof(newLeadlastName), required: true);
            SourceExpression.Validate(newLeadtitle, nameof(newLeadtitle), required: false);
            SourceExpression.Validate(newLeadfirstName, nameof(newLeadfirstName), required: false);
            SourceExpression.Validate(newLeadleadDescription, nameof(newLeadleadDescription), required: false);
            SourceExpression.Validate(newLeadconvertedDateTime, nameof(newLeadconvertedDateTime), required: false);
            SourceExpression.Validate(newLeadleadVisibility, nameof(newLeadleadVisibility), required: false);
            SourceExpression.Validate(newLeadvisibleTeamId, nameof(newLeadvisibleTeamId), required: false);
            SourceExpression.Validate(newLeadvisibleUserIDs, nameof(newLeadvisibleUserIDs), required: false);
            SourceExpression.Validate(newLeadorganizationName, nameof(newLeadorganizationName), required: false);
            SourceExpression.Validate(newLeadphoneNumber, nameof(newLeadphoneNumber), required: false);
            SourceExpression.Validate(newLeadmobilePhoneNumber, nameof(newLeadmobilePhoneNumber), required: false);
            SourceExpression.Validate(newLeademailAddress, nameof(newLeademailAddress), required: false);
            SourceExpression.Validate(newLeadisConverted, nameof(newLeadisConverted), required: false);
            SourceExpression.Validate(newLeadwebsiteURL, nameof(newLeadwebsiteURL), required: false);
            SourceExpression.Validate(newLeadleadOwner, nameof(newLeadleadOwner), required: false);
            SourceExpression.Validate(newLeadleadResponsible, nameof(newLeadleadResponsible), required: false);
            SourceExpression.Validate(newLeadleadEmployeeCount, nameof(newLeadleadEmployeeCount), required: false);
            SourceExpression.Validate(newLeadleadRating, nameof(newLeadleadRating), required: false);
            SourceExpression.Validate(newLeadindustry, nameof(newLeadindustry), required: false);
            SourceExpression.Validate(newLeadtag, nameof(newLeadtag), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Leads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newLead = new JObject();
                var newLeadpropCount = 0;
                if (newLeadtitle != null)
                {
                    newLead["TITLE"] = SourceExpressionConverter.ConvertToken(newLeadtitle);
                    newLeadpropCount++;
                }

                if (newLeadfirstName != null)
                {
                    newLead["FIRST_NAME"] = SourceExpressionConverter.ConvertToken(newLeadfirstName);
                    newLeadpropCount++;
                }

                newLeadpropCount++;
                newLead["LAST_NAME"] = SourceExpressionConverter.ConvertToken(newLeadlastName);
                if (newLeadleadDescription != null)
                {
                    newLead["LEAD_DESCRIPTION"] = SourceExpressionConverter.ConvertToken(newLeadleadDescription);
                    newLeadpropCount++;
                }

                if (newLeadconvertedDateTime != null)
                {
                    newLead["CONVERTED_DATE_UTC"] = SourceExpressionConverter.ConvertToken(newLeadconvertedDateTime);
                    newLeadpropCount++;
                }

                if (newLeadleadVisibility != null)
                {
                    newLead["VISIBLE_TO"] = SourceExpressionConverter.Convert(newLeadleadVisibility);
                    newLeadpropCount++;
                }

                if (newLeadvisibleTeamId != null)
                {
                    newLead["VISIBLE_TEAM_ID"] = SourceExpressionConverter.ConvertToken(newLeadvisibleTeamId);
                    newLeadpropCount++;
                }

                if (newLeadvisibleUserIDs != null)
                {
                    newLead["VISIBLE_USER_IDS"] = SourceExpressionConverter.ConvertToken(newLeadvisibleUserIDs);
                    newLeadpropCount++;
                }

                if (newLeadorganizationName != null)
                {
                    newLead["ORGANIZATION_NAME"] = SourceExpressionConverter.ConvertToken(newLeadorganizationName);
                    newLeadpropCount++;
                }

                if (newLeadphoneNumber != null)
                {
                    newLead["PHONE_NUMBER"] = SourceExpressionConverter.ConvertToken(newLeadphoneNumber);
                    newLeadpropCount++;
                }

                if (newLeadmobilePhoneNumber != null)
                {
                    newLead["MOBILE_PHONE_NUMBER"] = SourceExpressionConverter.ConvertToken(newLeadmobilePhoneNumber);
                    newLeadpropCount++;
                }

                if (newLeademailAddress != null)
                {
                    newLead["EMAIL_ADDRESS"] = SourceExpressionConverter.ConvertToken(newLeademailAddress);
                    newLeadpropCount++;
                }

                if (newLeadisConverted != null)
                {
                    newLead["CONVERTED"] = SourceExpressionConverter.ConvertToken(newLeadisConverted);
                    newLeadpropCount++;
                }

                if (newLeadwebsiteURL != null)
                {
                    newLead["WEBSITE_URL"] = SourceExpressionConverter.ConvertToken(newLeadwebsiteURL);
                    newLeadpropCount++;
                }

                if (newLeadleadOwner != null)
                {
                    newLead["OWNER_USER_ID"] = SourceExpressionConverter.ConvertToken(newLeadleadOwner);
                    newLeadpropCount++;
                }

                if (newLeadleadResponsible != null)
                {
                    newLead["RESPONSIBLE_USER_ID"] = SourceExpressionConverter.ConvertToken(newLeadleadResponsible);
                    newLeadpropCount++;
                }

                if (newLeadleadEmployeeCount != null)
                {
                    newLead["EMPLOYEE_COUNT"] = SourceExpressionConverter.ConvertToken(newLeadleadEmployeeCount);
                    newLeadpropCount++;
                }

                if (newLeadleadRating != null)
                {
                    newLead["LEAD_RATING"] = SourceExpressionConverter.ConvertToken(newLeadleadRating);
                    newLeadpropCount++;
                }

                if (newLeadindustry != null)
                {
                    newLead["INDUSTRY"] = SourceExpressionConverter.ConvertToken(newLeadindustry);
                    newLeadpropCount++;
                }

                if (newLeadtag != null)
                {
                    newLead["TAGS"] = SourceExpressionConverter.ConvertToken(newLeadtag);
                    newLeadpropCount++;
                }

                if (newLeadpropCount > 0)
                {
                    callPayload.Body = newLead;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Lead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListContactsResponse> ListContacts()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Contact> UpdateContact([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> updatedContactfirstName, [WorkflowExpression] Func<string> updatedContactlastName, [WorkflowExpression] Func<string> updatedContactsalutation = null, [WorkflowExpression] Func<string> updatedContactbackground = null, [WorkflowExpression] Func<updatedContactcontactVisibilityInput> updatedContactcontactVisibility = null, [WorkflowExpression] Func<int> updatedContactvisibleTeamId = null, [WorkflowExpression] Func<int> updatedContactvisibleUserIDs = null, [WorkflowExpression] Func<ContactInfo[]> updatedContactcontactInformation = null, [WorkflowExpression] Func<Tag[]> updatedContacttag = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(updatedContactfirstName, nameof(updatedContactfirstName), required: true);
            SourceExpression.Validate(updatedContactlastName, nameof(updatedContactlastName), required: true);
            SourceExpression.Validate(updatedContactsalutation, nameof(updatedContactsalutation), required: false);
            SourceExpression.Validate(updatedContactbackground, nameof(updatedContactbackground), required: false);
            SourceExpression.Validate(updatedContactcontactVisibility, nameof(updatedContactcontactVisibility), required: false);
            SourceExpression.Validate(updatedContactvisibleTeamId, nameof(updatedContactvisibleTeamId), required: false);
            SourceExpression.Validate(updatedContactvisibleUserIDs, nameof(updatedContactvisibleUserIDs), required: false);
            SourceExpression.Validate(updatedContactcontactInformation, nameof(updatedContactcontactInformation), required: false);
            SourceExpression.Validate(updatedContacttag, nameof(updatedContacttag), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Contacts";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                var updatedContact = new JObject();
                var updatedContactpropCount = 0;
                if (updatedContactsalutation != null)
                {
                    updatedContact["SALUTATION"] = SourceExpressionConverter.ConvertToken(updatedContactsalutation);
                    updatedContactpropCount++;
                }

                updatedContactpropCount++;
                updatedContact["FIRST_NAME"] = SourceExpressionConverter.ConvertToken(updatedContactfirstName);
                updatedContactpropCount++;
                updatedContact["LAST_NAME"] = SourceExpressionConverter.ConvertToken(updatedContactlastName);
                if (updatedContactbackground != null)
                {
                    updatedContact["BACKGROUND"] = SourceExpressionConverter.ConvertToken(updatedContactbackground);
                    updatedContactpropCount++;
                }

                if (updatedContactcontactVisibility != null)
                {
                    updatedContact["VISIBLE_TO"] = SourceExpressionConverter.Convert(updatedContactcontactVisibility);
                    updatedContactpropCount++;
                }

                if (updatedContactvisibleTeamId != null)
                {
                    updatedContact["VISIBLE_TEAM_ID"] = SourceExpressionConverter.ConvertToken(updatedContactvisibleTeamId);
                    updatedContactpropCount++;
                }

                if (updatedContactvisibleUserIDs != null)
                {
                    updatedContact["VISIBLE_USER_IDS"] = SourceExpressionConverter.ConvertToken(updatedContactvisibleUserIDs);
                    updatedContactpropCount++;
                }

                if (updatedContactcontactInformation != null)
                {
                    updatedContact["CONTACTINFOS"] = SourceExpressionConverter.ConvertToken(updatedContactcontactInformation);
                    updatedContactpropCount++;
                }

                if (updatedContacttag != null)
                {
                    updatedContact["TAGS"] = SourceExpressionConverter.ConvertToken(updatedContacttag);
                    updatedContactpropCount++;
                }

                if (updatedContactpropCount > 0)
                {
                    callPayload.Body = updatedContact;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Contact>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Contact> AddContact([WorkflowExpression] Func<string> newContactfirstName, [WorkflowExpression] Func<string> newContactlastName, [WorkflowExpression] Func<string> newContactsalutation = null, [WorkflowExpression] Func<string> newContactbackground = null, [WorkflowExpression] Func<newContactcontactVisibilityInput> newContactcontactVisibility = null, [WorkflowExpression] Func<int> newContactvisibleTeamId = null, [WorkflowExpression] Func<int> newContactvisibleUserIDs = null, [WorkflowExpression] Func<ContactInfo[]> newContactcontactInformation = null, [WorkflowExpression] Func<Tag[]> newContacttag = null)
        {
            SourceExpression.Validate(newContactfirstName, nameof(newContactfirstName), required: true);
            SourceExpression.Validate(newContactlastName, nameof(newContactlastName), required: true);
            SourceExpression.Validate(newContactsalutation, nameof(newContactsalutation), required: false);
            SourceExpression.Validate(newContactbackground, nameof(newContactbackground), required: false);
            SourceExpression.Validate(newContactcontactVisibility, nameof(newContactcontactVisibility), required: false);
            SourceExpression.Validate(newContactvisibleTeamId, nameof(newContactvisibleTeamId), required: false);
            SourceExpression.Validate(newContactvisibleUserIDs, nameof(newContactvisibleUserIDs), required: false);
            SourceExpression.Validate(newContactcontactInformation, nameof(newContactcontactInformation), required: false);
            SourceExpression.Validate(newContacttag, nameof(newContacttag), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newContact = new JObject();
                var newContactpropCount = 0;
                if (newContactsalutation != null)
                {
                    newContact["SALUTATION"] = SourceExpressionConverter.ConvertToken(newContactsalutation);
                    newContactpropCount++;
                }

                newContactpropCount++;
                newContact["FIRST_NAME"] = SourceExpressionConverter.ConvertToken(newContactfirstName);
                newContactpropCount++;
                newContact["LAST_NAME"] = SourceExpressionConverter.ConvertToken(newContactlastName);
                if (newContactbackground != null)
                {
                    newContact["BACKGROUND"] = SourceExpressionConverter.ConvertToken(newContactbackground);
                    newContactpropCount++;
                }

                if (newContactcontactVisibility != null)
                {
                    newContact["VISIBLE_TO"] = SourceExpressionConverter.Convert(newContactcontactVisibility);
                    newContactpropCount++;
                }

                if (newContactvisibleTeamId != null)
                {
                    newContact["VISIBLE_TEAM_ID"] = SourceExpressionConverter.ConvertToken(newContactvisibleTeamId);
                    newContactpropCount++;
                }

                if (newContactvisibleUserIDs != null)
                {
                    newContact["VISIBLE_USER_IDS"] = SourceExpressionConverter.ConvertToken(newContactvisibleUserIDs);
                    newContactpropCount++;
                }

                if (newContactcontactInformation != null)
                {
                    newContact["CONTACTINFOS"] = SourceExpressionConverter.ConvertToken(newContactcontactInformation);
                    newContactpropCount++;
                }

                if (newContacttag != null)
                {
                    newContact["TAGS"] = SourceExpressionConverter.ConvertToken(newContacttag);
                    newContactpropCount++;
                }

                if (newContactpropCount > 0)
                {
                    callPayload.Body = newContact;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Contact>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken> DeleteTask([WorkflowExpression] Func<int> taskId)
        {
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(taskId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken> FollowTask([WorkflowExpression] Func<int> taskId)
        {
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Tasks/{0}/Follow", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(taskId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken> DeleteProject([WorkflowExpression] Func<int> projectId)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Projects/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken> DeleteLead([WorkflowExpression] Func<int> leadId)
        {
            SourceExpression.Validate(leadId, nameof(leadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Leads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(leadId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken> DeleteContact([WorkflowExpression] Func<int> contactId)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<OrganizationInfo> AddOrganization([WorkflowExpression] Func<string> newOrganizationorganizationName, [WorkflowExpression] Func<string> newOrganizationorganizationBackground = null, [WorkflowExpression] Func<newOrganizationorganizationVisibilityInput> newOrganizationorganizationVisibility = null, [WorkflowExpression] Func<int> newOrganizationvisibleTeamId = null, [WorkflowExpression] Func<int> newOrganizationvisibleUserIDs = null, [WorkflowExpression] Func<Address[]> newOrganizationorganizationAddress = null, [WorkflowExpression] Func<ContactInfo[]> newOrganizationcontactInformation = null, [WorkflowExpression] Func<Tag[]> newOrganizationtags = null)
        {
            SourceExpression.Validate(newOrganizationorganizationName, nameof(newOrganizationorganizationName), required: true);
            SourceExpression.Validate(newOrganizationorganizationBackground, nameof(newOrganizationorganizationBackground), required: false);
            SourceExpression.Validate(newOrganizationorganizationVisibility, nameof(newOrganizationorganizationVisibility), required: false);
            SourceExpression.Validate(newOrganizationvisibleTeamId, nameof(newOrganizationvisibleTeamId), required: false);
            SourceExpression.Validate(newOrganizationvisibleUserIDs, nameof(newOrganizationvisibleUserIDs), required: false);
            SourceExpression.Validate(newOrganizationorganizationAddress, nameof(newOrganizationorganizationAddress), required: false);
            SourceExpression.Validate(newOrganizationcontactInformation, nameof(newOrganizationcontactInformation), required: false);
            SourceExpression.Validate(newOrganizationtags, nameof(newOrganizationtags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Organisations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newOrganization = new JObject();
                var newOrganizationpropCount = 0;
                newOrganizationpropCount++;
                newOrganization["ORGANISATION_NAME"] = SourceExpressionConverter.ConvertToken(newOrganizationorganizationName);
                if (newOrganizationorganizationBackground != null)
                {
                    newOrganization["ORGANISATION_BACKGROUND"] = SourceExpressionConverter.ConvertToken(newOrganizationorganizationBackground);
                    newOrganizationpropCount++;
                }

                if (newOrganizationorganizationVisibility != null)
                {
                    newOrganization["VISIBLE_TO"] = SourceExpressionConverter.Convert(newOrganizationorganizationVisibility);
                    newOrganizationpropCount++;
                }

                if (newOrganizationvisibleTeamId != null)
                {
                    newOrganization["VISIBLE_TEAM_ID"] = SourceExpressionConverter.ConvertToken(newOrganizationvisibleTeamId);
                    newOrganizationpropCount++;
                }

                if (newOrganizationvisibleUserIDs != null)
                {
                    newOrganization["VISIBLE_USER_IDS"] = SourceExpressionConverter.ConvertToken(newOrganizationvisibleUserIDs);
                    newOrganizationpropCount++;
                }

                if (newOrganizationorganizationAddress != null)
                {
                    newOrganization["ADDRESSES"] = SourceExpressionConverter.ConvertToken(newOrganizationorganizationAddress);
                    newOrganizationpropCount++;
                }

                if (newOrganizationcontactInformation != null)
                {
                    newOrganization["CONTACTINFOS"] = SourceExpressionConverter.ConvertToken(newOrganizationcontactInformation);
                    newOrganizationpropCount++;
                }

                if (newOrganizationtags != null)
                {
                    newOrganization["TAGS"] = SourceExpressionConverter.ConvertToken(newOrganizationtags);
                    newOrganizationpropCount++;
                }

                if (newOrganizationpropCount > 0)
                {
                    callPayload.Body = newOrganization;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationInfo>(BuildSourceInput);
        }
    }

    public class InsightlyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTasksResponse> OnTaskAssignedToMe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger1/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListTasksResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListTasksResponse> OnTaskCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger2/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListTasksResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListTasksResponse> OnTaskUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger3/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListTasksResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListProjectsResponse> OnProjectCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger2/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListProjectsResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListProjectsResponse> OnProjectUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger3/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListProjectsResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Lead> OnLeadCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger1/Leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<Lead>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Lead> OnLeadUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger2/Leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<Lead>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListContactsResponse> OnContactCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger1/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListContactsResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListContactsResponse> OnContactUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger2/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListContactsResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListEventsResponse> OnEventCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger1/Events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListEventsResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListEventsResponse> OnEventUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger2/Events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListEventsResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class ListTasksResponse
    {
        [JsonProperty("tasks")]
        public TaskObject[] Tasks { get; set; }
    }

    public class TaskObject
    {
        [JsonProperty("TASK_ID")]
        public int TaskId { get; set; }

        [JsonProperty("TITLE")]
        public string TaskTitle { get; set; }

        [JsonProperty("DUE_DATE")]
        public string DueDateTime { get; set; }

        [JsonProperty("CATEGORY_ID")]
        public int CategoryId { get; set; }

        [JsonProperty("COMPLETED_DATE_UTC")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("COMPLETED")]
        public bool IsCompleted { get; set; }

        [JsonProperty("DETAILS")]
        public string TaskDetails { get; set; }

        [JsonProperty("STATUS")]
        public TaskObjectTaskStatusType TaskStatus { get; set; }

        [JsonProperty("PRIORITY")]
        public int TaskPriority { get; set; }

        [JsonProperty("START_DATE")]
        public string StartDateTime { get; set; }

        [JsonProperty("PROJECT_ID")]
        public int ProjectId { get; set; }

        [JsonProperty("OPPORTUNITY_ID")]
        public int OpportunityId { get; set; }

        [JsonProperty("MILESTONE_ID")]
        public int MilestoneId { get; set; }

        [JsonProperty("PIPELINE_ID")]
        public int PipelineId { get; set; }

        [JsonProperty("STAGE_ID")]
        public int StageId { get; set; }

        [JsonProperty("PERCENT_COMPLETE")]
        public int PercentageComplete { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int TaskOwner { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID")]
        public int AssignedTo { get; set; }

        [JsonProperty("PUBLICLY_VISIBLE")]
        public bool IsTaskVisible { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("ASSIGNED_BY_USER_ID")]
        public int AssignedByUserId { get; set; }

        [JsonProperty("PARENT_TASK_ID")]
        public int ParentTaskId { get; set; }

        [JsonProperty("OWNER_VISIBLE")]
        public bool IsOwnerVisible { get; set; }

        [JsonProperty("ASSIGNED_TEAM_ID")]
        public int AssignedTeamId { get; set; }

        [JsonProperty("ASSIGNED_DATE_UTC")]
        public string AssignedDateTime { get; set; }

        [JsonProperty("REMINDER_DATE_UTC")]
        public string ReminderDateTime { get; set; }

        [JsonProperty("REMINDER_SENT")]
        public bool IsReminderSent { get; set; }

        [JsonProperty("RECURRENCE")]
        public string Recurrence { get; set; }

        [JsonProperty("CAN_EDIT")]
        public bool CanEdit { get; set; }

        [JsonProperty("CAN_DELETE")]
        public bool CanDelete { get; set; }
    }

    public enum TaskObjectTaskStatusType
    {
        Completed,
        Deferred,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Waiting
    }

    public enum updatedTasktaskStatusInput
    {
        Completed,
        Deferred,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Waiting
    }

    public enum newTasktaskStatusInput
    {
        Completed,
        Deferred,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Waiting
    }

    public class ListProjectsResponse
    {
        [JsonProperty("projects")]
        public Project[] Projects { get; set; }
    }

    public class Project
    {
        [JsonProperty("PROJECT_ID")]
        public int ProjectId { get; set; }

        [JsonProperty("PROJECT_NAME")]
        public string ProjectName { get; set; }

        [JsonProperty("STATUS")]
        public string ProjectStatus { get; set; }

        [JsonProperty("PROJECT_DETAILS")]
        public string ProjectDetails { get; set; }

        [JsonProperty("IMAGE_URL")]
        public string ImageURL { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public string ProjectVisible { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("STARTED_DATE")]
        public string StartedDateTime { get; set; }

        [JsonProperty("COMPLETED_DATE")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int ProjectOwner { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID")]
        public int AssignedTo { get; set; }

        [JsonProperty("OPPORTUNITY_ID")]
        public int OpportunityId { get; set; }

        [JsonProperty("PIPELINE_ID")]
        public int PipelineId { get; set; }

        [JsonProperty("STAGE_ID")]
        public int StageId { get; set; }

        [JsonProperty("CATEGORY_ID")]
        public int CategoryId { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int VisibleUserIDs { get; set; }

        [JsonProperty("CAN_EDIT")]
        public bool CanEdit { get; set; }

        [JsonProperty("CAN_DELETE")]
        public bool CanDelete { get; set; }
    }

    public enum updatedProjectprojectStatusInput
    {
        Completed,
        Deferred,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Abandoned,
        Cancelled
    }

    public enum updatedProjectprojectVisibilityInput
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class Tag
    {
        [JsonProperty("TAG_NAME")]
        public string TagName { get; set; }
    }

    public enum newProjectprojectStatusInput
    {
        Completed,
        Deferred,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Abandoned,
        Cancelled
    }

    public enum newProjectprojectVisibilityInput
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class ListLeadsResponse
    {
        [JsonProperty("leads")]
        public Lead[] Leads { get; set; }
    }

    public class Lead
    {
        [JsonProperty("LEAD_ID")]
        public int LeadId { get; set; }

        [JsonProperty("SALUTATION")]
        public string Salutation { get; set; }

        [JsonProperty("TITLE")]
        public string Title { get; set; }

        [JsonProperty("FIRST_NAME")]
        public string FirstName { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("LEAD_DESCRIPTION")]
        public string LeadDescription { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("CONVERTED_DATE_UTC")]
        public string ConvertedDateTime { get; set; }

        [JsonProperty("LEAD_STATUS_ID")]
        public int LeadStatusId { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public string LeadVisibility { get; set; }

        [JsonProperty("ORGANIZATION_NAME")]
        public string OrganizationName { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        [JsonProperty("MOBILE_PHONE_NUMBER")]
        public string MobilePhoneNumber { get; set; }

        [JsonProperty("EMAIL_ADDRESS")]
        public string EmailAddress { get; set; }

        [JsonProperty("CONVERTED")]
        public bool IsConverted { get; set; }

        [JsonProperty("WEBSITE_URL")]
        public string WebsiteURL { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int LeadOwner { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID")]
        public int LeadResponsible { get; set; }

        [JsonProperty("EMPLOYEE_COUNT")]
        public int LeadEmployeeCount { get; set; }

        [JsonProperty("LEAD_RATING")]
        public int LeadRating { get; set; }

        [JsonProperty("INDUSTRY")]
        public string Industry { get; set; }

        [JsonProperty("ADDRESS_STREET")]
        public string AddressStreet { get; set; }

        [JsonProperty("ADDRESS_CITY")]
        public string AddressCity { get; set; }

        [JsonProperty("ADDRESS_STATE")]
        public string AddressState { get; set; }

        [JsonProperty("ADDRESS_POSTCODE")]
        public string AddressPostcode { get; set; }

        [JsonProperty("ADDRESS_COUNTRY")]
        public string AddressCountry { get; set; }

        [JsonProperty("FAX_NUMBER")]
        public string FaxNumber { get; set; }

        [JsonProperty("CONVERTED_CONTACT_ID")]
        public int ConvertedContactId { get; set; }

        [JsonProperty("CONVERTED_ORGANIZATION_ID")]
        public int ConvertedOrganizationId { get; set; }

        [JsonProperty("CONVERTED_OPPORTUNITY_ID")]
        public int ConvertedOpportunityId { get; set; }

        [JsonProperty("LEAD_SOURCE_ID")]
        public int LeadSourceId { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int VisibleUserIDs { get; set; }

        [JsonProperty("IMAGE_URL")]
        public string ImageURL { get; set; }

        [JsonProperty("CAN_EDIT")]
        public bool CanEdit { get; set; }

        [JsonProperty("CAN_DELETE")]
        public bool CanDelete { get; set; }
    }

    public enum updatedLeadleadVisibilityInput
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public enum newLeadleadVisibilityInput
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class ListContactsResponse
    {
        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }
    }

    public class Contact
    {
        [JsonProperty("ADDRESS_WORK")]
        public ContactAddressWorkType AddressWork { get; set; }

        [JsonProperty("ADDRESS_HOME")]
        public ContactAddressHomeType AddressHome { get; set; }

        [JsonProperty("ADDRESS_POSTAL")]
        public ContactAddressPostalType AddressPostal { get; set; }

        [JsonProperty("ADDRESS_PRIMARY")]
        public ContactAddressPrimaryType AddressPrimary { get; set; }

        [JsonProperty("ADDRESS_OTHER")]
        public ContactAddressOtherType AddressOther { get; set; }

        [JsonProperty("EMAIL_WORK")]
        public string EmailWork { get; set; }

        [JsonProperty("EMAIL_HOME")]
        public string EmailHome { get; set; }

        [JsonProperty("EMAIL_PERSONAL")]
        public string EmailPersonal { get; set; }

        [JsonProperty("EMAIL_OTHER")]
        public string EmailOther { get; set; }

        [JsonProperty("PHONE_WORK")]
        public string PhoneWork { get; set; }

        [JsonProperty("PHONE_HOME")]
        public string PhoneHome { get; set; }

        [JsonProperty("PHONE_MOBILE")]
        public string PhoneMobile { get; set; }

        [JsonProperty("PHONE_OTHER")]
        public string PhoneOther { get; set; }

        [JsonProperty("CONTACT_ID")]
        public int ContactId { get; set; }

        [JsonProperty("SALUTATION")]
        public string Salutation { get; set; }

        [JsonProperty("FIRST_NAME")]
        public string FirstName { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("IMAGE_URL")]
        public string ImageURL { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public string ContactVisibility { get; set; }

        [JsonProperty("BACKGROUND")]
        public string Background { get; set; }

        [JsonProperty("DEFAULT_LINKED_ORGANISATION")]
        public int DefaultLinkedOrganization { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int OwnerUserId { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int VisibleUserIDs { get; set; }

        [JsonProperty("CAN_EDIT")]
        public bool CanEdit { get; set; }

        [JsonProperty("CAN_DELETE")]
        public bool CanDelete { get; set; }

        [JsonProperty("SOCIAL_LINKEDIN")]
        public string SocialLinkedIn { get; set; }

        [JsonProperty("SOCIAL_FACEBOOK")]
        public string SocialFacebook { get; set; }

        [JsonProperty("SOCIAL_TWITTER")]
        public string SocialTwitter { get; set; }
    }

    public class ContactAddressWorkType
    {
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }
    }

    public class ContactAddressHomeType
    {
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }
    }

    public class ContactAddressPostalType
    {
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }
    }

    public class ContactAddressPrimaryType
    {
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }
    }

    public class ContactAddressOtherType
    {
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("POSTCODE")]
        public string Postcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }
    }

    public enum updatedContactcontactVisibilityInput
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class ContactInfo
    {
        [JsonProperty("CONTACT_INFO_ID")]
        public int ContactInfoId { get; set; }

        [JsonProperty("TYPE")]
        public ContactInfoTypeType Type { get; set; }

        [JsonProperty("SUBTYPE")]
        public string SubType { get; set; }

        [JsonProperty("LABEL")]
        public string Label { get; set; }

        [JsonProperty("DETAIL")]
        public string Detail { get; set; }
    }

    public enum ContactInfoTypeType
    {
        Phone,
        Email,
        Social,
        Website
    }

    public enum newContactcontactVisibilityInput
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class ListUsersResponse
    {
        [JsonProperty("users")]
        public User[] Users { get; set; }
    }

    public class User
    {
        [JsonProperty("USER_ID")]
        public int UserId { get; set; }

        [JsonProperty("CONTACT_ID")]
        public int ContactId { get; set; }

        [JsonProperty("FIRST_NAME")]
        public string FirstName { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

        [JsonProperty("EMAIL_ADDRESS")]
        public string EmailAddress { get; set; }

        [JsonProperty("TIMEZONE_ID")]
        public string TimeZoneId { get; set; }

        [JsonProperty("EMAIL_DROPBOX_IDENTIFIER")]
        public string EmailDropboxId { get; set; }

        [JsonProperty("EMAIL_DROPBOX_ADDRESS")]
        public string EmailDropboxAddress { get; set; }

        [JsonProperty("ADMINISTRATOR")]
        public bool IsAdministrator { get; set; }

        [JsonProperty("ACCOUNT_OWNER")]
        public bool IsAccountOwner { get; set; }

        [JsonProperty("ACTIVE")]
        public bool IsActive { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("USER_CURRENCY")]
        public string UserCurrency { get; set; }

        [JsonProperty("CONTACT_DISPLAY")]
        public string ContactDisplay { get; set; }

        [JsonProperty("CONTACT_ORDER")]
        public string ContactOrder { get; set; }

        [JsonProperty("TASK_WEEK_START")]
        public int TaskWeekStart { get; set; }

        [JsonProperty("INSTANCE_ID")]
        public int InstanceId { get; set; }
    }

    public class OrganizationInfo
    {
        [JsonProperty("ORGANISATION_ID")]
        public int OrganizationId { get; set; }

        [JsonProperty("ORGANISATION_BACKGROUND")]
        public string OrganizationBackground { get; set; }

        [JsonProperty("ORGANISATION_NAME")]
        public string OrganizationName { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int OrganizationOwner { get; set; }

        [JsonProperty("VISIBLE_TO")]
        public string OrganizationVisibility { get; set; }

        [JsonProperty("ADDRESSES")]
        public Address[] Organization { get; set; }

        [JsonProperty("CONTACTINFOS")]
        public ContactInfo[] ContactInformation { get; set; }

        [JsonProperty("BACKGROUND")]
        public string Background { get; set; }

        [JsonProperty("IMAGE_URL")]
        public string ImageURL { get; set; }

        [JsonProperty("VISIBLE_TEAM_ID")]
        public int VisibleTeamId { get; set; }

        [JsonProperty("VISIBLE_USER_IDS")]
        public int VisibleUserIDs { get; set; }
    }

    public class Address
    {
        [JsonProperty("ADDRESS_ID")]
        public int AddressId { get; set; }

        [JsonProperty("ADDRESS_TYPE")]
        public string AddressType { get; set; }

        [JsonProperty("STREET")]
        public string AddressStreet { get; set; }

        [JsonProperty("CITY")]
        public string AddressCity { get; set; }

        [JsonProperty("STATE")]
        public string AddressState { get; set; }

        [JsonProperty("POSTCODE")]
        public string AddressPostcode { get; set; }

        [JsonProperty("COUNTRY")]
        public string AddressCountry { get; set; }
    }

    public enum newOrganizationorganizationVisibilityInput
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    public class ListEventsResponse
    {
        [JsonProperty("events")]
        public Event[] Events { get; set; }
    }

    public class Event
    {
        [JsonProperty("EVENT_ID")]
        public int EventId { get; set; }

        [JsonProperty("TITLE")]
        public string Title { get; set; }

        [JsonProperty("START_DATE_UTC")]
        public string StartDateTime { get; set; }

        [JsonProperty("END_DATE_UTC")]
        public string EndDateTime { get; set; }

        [JsonProperty("DATE_CREATED_UTC")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DATE_UPDATED_UTC")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("OWNER_USER_ID")]
        public int OwnerUserId { get; set; }

        [JsonProperty("REMINDER_SENT")]
        public bool IsReminderSent { get; set; }

        [JsonProperty("ALL_DAY")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("PUBLICLY_VISIBLE")]
        public bool IsEventVisible { get; set; }

        [JsonProperty("CAN_EDIT")]
        public bool CanEdit { get; set; }

        [JsonProperty("CAN_DELETE")]
        public bool CanDelete { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Insightly;

    public partial class WorkflowManagedActions
    {
        public InsightlyActions Insightly(string connectionId) => new InsightlyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InsightlyTriggers Insightly(string connectionId) => new InsightlyTriggers(connectionId);
    }
}