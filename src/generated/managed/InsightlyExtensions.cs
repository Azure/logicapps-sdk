//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Insightly
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InsightlyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListTasksResponse, ApiConnectionActionConfiguration> ListTasks()
        {
            return new DeferredBodyAction<ListTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<string>> id, Expression<Func<string>> updatedTasktaskTitle, Expression<Func<bool>> updatedTaskisCompleted, Expression<Func<updatedTasktaskStatusInput>> updatedTasktaskStatus, Expression<Func<bool>> updatedTaskisTaskVisible, Expression<Func<string>> updatedTaskdueDateTime = null, Expression<Func<string>> updatedTasktaskDetails = null, Expression<Func<int>> updatedTasktaskPriority = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_updatedTasktaskTitle = WorkflowExpression.Compile(updatedTasktaskTitle, nameof(updatedTasktaskTitle), required: true);
            var __workflow_updatedTaskisCompleted = WorkflowExpression.Compile(updatedTaskisCompleted, nameof(updatedTaskisCompleted), required: true);
            var __workflow_updatedTasktaskStatus = WorkflowExpression.Compile(updatedTasktaskStatus, nameof(updatedTasktaskStatus), required: true);
            var __workflow_updatedTaskisTaskVisible = WorkflowExpression.Compile(updatedTaskisTaskVisible, nameof(updatedTaskisTaskVisible), required: true);
            var __workflow_updatedTaskdueDateTime = WorkflowExpression.Compile(updatedTaskdueDateTime, nameof(updatedTaskdueDateTime), required: false);
            var __workflow_updatedTasktaskDetails = WorkflowExpression.Compile(updatedTasktaskDetails, nameof(updatedTasktaskDetails), required: false);
            var __workflow_updatedTasktaskPriority = WorkflowExpression.Compile(updatedTasktaskPriority, nameof(updatedTasktaskPriority), required: false);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Tasks";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                var updatedTask = new JObject();
                var updatedTaskpropCount = 0;
                updatedTaskpropCount++;
                updatedTask["TITLE"] = ExpressionConverter.ConvertO(__workflow_updatedTasktaskTitle);
                if (__workflow_updatedTaskdueDateTime != null)
                {
                    updatedTask["DUE_DATE"] = ExpressionConverter.ConvertO(__workflow_updatedTaskdueDateTime);
                    updatedTaskpropCount++;
                }

                updatedTaskpropCount++;
                updatedTask["COMPLETED"] = ExpressionConverter.ConvertO(__workflow_updatedTaskisCompleted);
                if (__workflow_updatedTasktaskDetails != null)
                {
                    updatedTask["DETAILS"] = ExpressionConverter.ConvertO(__workflow_updatedTasktaskDetails);
                    updatedTaskpropCount++;
                }

                updatedTaskpropCount++;
                updatedTask["STATUS"] = ExpressionConverter.ConvertO(__workflow_updatedTasktaskStatus);
                if (__workflow_updatedTasktaskPriority != null)
                {
                    updatedTask["PRIORITY"] = ExpressionConverter.ConvertO(__workflow_updatedTasktaskPriority);
                    updatedTaskpropCount++;
                }

                updatedTaskpropCount++;
                updatedTask["PUBLICLY_VISIBLE"] = ExpressionConverter.ConvertO(__workflow_updatedTaskisTaskVisible);
                if (updatedTaskpropCount > 0)
                {
                    callPayload.Body = updatedTask;
                }

                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> AddTask(Expression<Func<string>> newTasktaskTitle, Expression<Func<bool>> newTaskisCompleted, Expression<Func<newTasktaskStatusInput>> newTasktaskStatus, Expression<Func<bool>> newTaskisTaskVisible, Expression<Func<string>> newTaskdueDateTime = null, Expression<Func<string>> newTasktaskDetails = null, Expression<Func<int>> newTasktaskPriority = null)
        {
            var __workflow_newTasktaskTitle = WorkflowExpression.Compile(newTasktaskTitle, nameof(newTasktaskTitle), required: true);
            var __workflow_newTaskisCompleted = WorkflowExpression.Compile(newTaskisCompleted, nameof(newTaskisCompleted), required: true);
            var __workflow_newTasktaskStatus = WorkflowExpression.Compile(newTasktaskStatus, nameof(newTasktaskStatus), required: true);
            var __workflow_newTaskisTaskVisible = WorkflowExpression.Compile(newTaskisTaskVisible, nameof(newTaskisTaskVisible), required: true);
            var __workflow_newTaskdueDateTime = WorkflowExpression.Compile(newTaskdueDateTime, nameof(newTaskdueDateTime), required: false);
            var __workflow_newTasktaskDetails = WorkflowExpression.Compile(newTasktaskDetails, nameof(newTasktaskDetails), required: false);
            var __workflow_newTasktaskPriority = WorkflowExpression.Compile(newTasktaskPriority, nameof(newTasktaskPriority), required: false);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newTask = new JObject();
                var newTaskpropCount = 0;
                newTaskpropCount++;
                newTask["TITLE"] = ExpressionConverter.ConvertO(__workflow_newTasktaskTitle);
                if (__workflow_newTaskdueDateTime != null)
                {
                    newTask["DUE_DATE"] = ExpressionConverter.ConvertO(__workflow_newTaskdueDateTime);
                    newTaskpropCount++;
                }

                newTaskpropCount++;
                newTask["COMPLETED"] = ExpressionConverter.ConvertO(__workflow_newTaskisCompleted);
                if (__workflow_newTasktaskDetails != null)
                {
                    newTask["DETAILS"] = ExpressionConverter.ConvertO(__workflow_newTasktaskDetails);
                    newTaskpropCount++;
                }

                newTaskpropCount++;
                newTask["STATUS"] = ExpressionConverter.ConvertO(__workflow_newTasktaskStatus);
                if (__workflow_newTasktaskPriority != null)
                {
                    newTask["PRIORITY"] = ExpressionConverter.ConvertO(__workflow_newTasktaskPriority);
                    newTaskpropCount++;
                }

                newTaskpropCount++;
                newTask["PUBLICLY_VISIBLE"] = ExpressionConverter.ConvertO(__workflow_newTaskisTaskVisible);
                if (newTaskpropCount > 0)
                {
                    callPayload.Body = newTask;
                }

                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListProjectsResponse, ApiConnectionActionConfiguration> ListProjects()
        {
            return new DeferredBodyAction<ListProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Project, ApiConnectionActionConfiguration> UpdateProject(Expression<Func<string>> id, Expression<Func<string>> updatedProjectprojectName, Expression<Func<updatedProjectprojectStatusInput>> updatedProjectprojectStatus, Expression<Func<string>> updatedProjectprojectDetails = null, Expression<Func<string>> updatedProjectimageURL = null, Expression<Func<updatedProjectprojectVisibilityInput>> updatedProjectprojectVisibility = null, Expression<Func<int>> updatedProjectvisibleTeamId = null, Expression<Func<int>> updatedProjectvisibleUserIDs = null, Expression<Func<int>> updatedProjectopportunityId = null, Expression<Func<int>> updatedProjectpipelineId = null, Expression<Func<int>> updatedProjectstageId = null, Expression<Func<Tag[]>> updatedProjecttags = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_updatedProjectprojectName = WorkflowExpression.Compile(updatedProjectprojectName, nameof(updatedProjectprojectName), required: true);
            var __workflow_updatedProjectprojectStatus = WorkflowExpression.Compile(updatedProjectprojectStatus, nameof(updatedProjectprojectStatus), required: true);
            var __workflow_updatedProjectprojectDetails = WorkflowExpression.Compile(updatedProjectprojectDetails, nameof(updatedProjectprojectDetails), required: false);
            var __workflow_updatedProjectimageURL = WorkflowExpression.Compile(updatedProjectimageURL, nameof(updatedProjectimageURL), required: false);
            var __workflow_updatedProjectprojectVisibility = WorkflowExpression.Compile(updatedProjectprojectVisibility, nameof(updatedProjectprojectVisibility), required: false);
            var __workflow_updatedProjectvisibleTeamId = WorkflowExpression.Compile(updatedProjectvisibleTeamId, nameof(updatedProjectvisibleTeamId), required: false);
            var __workflow_updatedProjectvisibleUserIDs = WorkflowExpression.Compile(updatedProjectvisibleUserIDs, nameof(updatedProjectvisibleUserIDs), required: false);
            var __workflow_updatedProjectopportunityId = WorkflowExpression.Compile(updatedProjectopportunityId, nameof(updatedProjectopportunityId), required: false);
            var __workflow_updatedProjectpipelineId = WorkflowExpression.Compile(updatedProjectpipelineId, nameof(updatedProjectpipelineId), required: false);
            var __workflow_updatedProjectstageId = WorkflowExpression.Compile(updatedProjectstageId, nameof(updatedProjectstageId), required: false);
            var __workflow_updatedProjecttags = WorkflowExpression.Compile(updatedProjecttags, nameof(updatedProjecttags), required: false);
            return new DeferredBodyAction<Project, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Projects";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                var updatedProject = new JObject();
                var updatedProjectpropCount = 0;
                updatedProjectpropCount++;
                updatedProject["PROJECT_NAME"] = ExpressionConverter.ConvertO(__workflow_updatedProjectprojectName);
                if (__workflow_updatedProjectprojectDetails != null)
                {
                    updatedProject["PROJECT_DETAILS"] = ExpressionConverter.ConvertO(__workflow_updatedProjectprojectDetails);
                    updatedProjectpropCount++;
                }

                updatedProjectpropCount++;
                updatedProject["STATUS"] = ExpressionConverter.ConvertO(__workflow_updatedProjectprojectStatus);
                if (__workflow_updatedProjectimageURL != null)
                {
                    updatedProject["IMAGE_URL"] = ExpressionConverter.ConvertO(__workflow_updatedProjectimageURL);
                    updatedProjectpropCount++;
                }

                if (__workflow_updatedProjectprojectVisibility != null)
                {
                    updatedProject["VISIBLE_TO"] = ExpressionConverter.ConvertO(__workflow_updatedProjectprojectVisibility);
                    updatedProjectpropCount++;
                }

                if (__workflow_updatedProjectvisibleTeamId != null)
                {
                    updatedProject["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(__workflow_updatedProjectvisibleTeamId);
                    updatedProjectpropCount++;
                }

                if (__workflow_updatedProjectvisibleUserIDs != null)
                {
                    updatedProject["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(__workflow_updatedProjectvisibleUserIDs);
                    updatedProjectpropCount++;
                }

                if (__workflow_updatedProjectopportunityId != null)
                {
                    updatedProject["OPPORTUNITY_ID"] = ExpressionConverter.ConvertO(__workflow_updatedProjectopportunityId);
                    updatedProjectpropCount++;
                }

                if (__workflow_updatedProjectpipelineId != null)
                {
                    updatedProject["PIPELINE_ID"] = ExpressionConverter.ConvertO(__workflow_updatedProjectpipelineId);
                    updatedProjectpropCount++;
                }

                if (__workflow_updatedProjectstageId != null)
                {
                    updatedProject["STAGE_ID"] = ExpressionConverter.ConvertO(__workflow_updatedProjectstageId);
                    updatedProjectpropCount++;
                }

                if (__workflow_updatedProjecttags != null)
                {
                    updatedProject["TAGS"] = ExpressionConverter.ConvertO(__workflow_updatedProjecttags);
                    updatedProjectpropCount++;
                }

                if (updatedProjectpropCount > 0)
                {
                    callPayload.Body = updatedProject;
                }

                return new ApiConnectionAction<Project>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Project, ApiConnectionActionConfiguration> AddProject(Expression<Func<string>> newProjectprojectName, Expression<Func<newProjectprojectStatusInput>> newProjectprojectStatus, Expression<Func<string>> newProjectprojectDetails = null, Expression<Func<string>> newProjectimageURL = null, Expression<Func<newProjectprojectVisibilityInput>> newProjectprojectVisibility = null, Expression<Func<int>> newProjectvisibleTeamId = null, Expression<Func<int>> newProjectvisibleUserIDs = null, Expression<Func<int>> newProjectopportunityId = null, Expression<Func<int>> newProjectpipelineId = null, Expression<Func<int>> newProjectstageId = null, Expression<Func<Tag[]>> newProjecttags = null)
        {
            var __workflow_newProjectprojectName = WorkflowExpression.Compile(newProjectprojectName, nameof(newProjectprojectName), required: true);
            var __workflow_newProjectprojectStatus = WorkflowExpression.Compile(newProjectprojectStatus, nameof(newProjectprojectStatus), required: true);
            var __workflow_newProjectprojectDetails = WorkflowExpression.Compile(newProjectprojectDetails, nameof(newProjectprojectDetails), required: false);
            var __workflow_newProjectimageURL = WorkflowExpression.Compile(newProjectimageURL, nameof(newProjectimageURL), required: false);
            var __workflow_newProjectprojectVisibility = WorkflowExpression.Compile(newProjectprojectVisibility, nameof(newProjectprojectVisibility), required: false);
            var __workflow_newProjectvisibleTeamId = WorkflowExpression.Compile(newProjectvisibleTeamId, nameof(newProjectvisibleTeamId), required: false);
            var __workflow_newProjectvisibleUserIDs = WorkflowExpression.Compile(newProjectvisibleUserIDs, nameof(newProjectvisibleUserIDs), required: false);
            var __workflow_newProjectopportunityId = WorkflowExpression.Compile(newProjectopportunityId, nameof(newProjectopportunityId), required: false);
            var __workflow_newProjectpipelineId = WorkflowExpression.Compile(newProjectpipelineId, nameof(newProjectpipelineId), required: false);
            var __workflow_newProjectstageId = WorkflowExpression.Compile(newProjectstageId, nameof(newProjectstageId), required: false);
            var __workflow_newProjecttags = WorkflowExpression.Compile(newProjecttags, nameof(newProjecttags), required: false);
            return new DeferredBodyAction<Project, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newProject = new JObject();
                var newProjectpropCount = 0;
                newProjectpropCount++;
                newProject["PROJECT_NAME"] = ExpressionConverter.ConvertO(__workflow_newProjectprojectName);
                if (__workflow_newProjectprojectDetails != null)
                {
                    newProject["PROJECT_DETAILS"] = ExpressionConverter.ConvertO(__workflow_newProjectprojectDetails);
                    newProjectpropCount++;
                }

                newProjectpropCount++;
                newProject["STATUS"] = ExpressionConverter.ConvertO(__workflow_newProjectprojectStatus);
                if (__workflow_newProjectimageURL != null)
                {
                    newProject["IMAGE_URL"] = ExpressionConverter.ConvertO(__workflow_newProjectimageURL);
                    newProjectpropCount++;
                }

                if (__workflow_newProjectprojectVisibility != null)
                {
                    newProject["VISIBLE_TO"] = ExpressionConverter.ConvertO(__workflow_newProjectprojectVisibility);
                    newProjectpropCount++;
                }

                if (__workflow_newProjectvisibleTeamId != null)
                {
                    newProject["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(__workflow_newProjectvisibleTeamId);
                    newProjectpropCount++;
                }

                if (__workflow_newProjectvisibleUserIDs != null)
                {
                    newProject["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(__workflow_newProjectvisibleUserIDs);
                    newProjectpropCount++;
                }

                if (__workflow_newProjectopportunityId != null)
                {
                    newProject["OPPORTUNITY_ID"] = ExpressionConverter.ConvertO(__workflow_newProjectopportunityId);
                    newProjectpropCount++;
                }

                if (__workflow_newProjectpipelineId != null)
                {
                    newProject["PIPELINE_ID"] = ExpressionConverter.ConvertO(__workflow_newProjectpipelineId);
                    newProjectpropCount++;
                }

                if (__workflow_newProjectstageId != null)
                {
                    newProject["STAGE_ID"] = ExpressionConverter.ConvertO(__workflow_newProjectstageId);
                    newProjectpropCount++;
                }

                if (__workflow_newProjecttags != null)
                {
                    newProject["TAGS"] = ExpressionConverter.ConvertO(__workflow_newProjecttags);
                    newProjectpropCount++;
                }

                if (newProjectpropCount > 0)
                {
                    callPayload.Body = newProject;
                }

                return new ApiConnectionAction<Project>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListLeadsResponse, ApiConnectionActionConfiguration> ListLeads()
        {
            return new DeferredBodyAction<ListLeadsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListLeadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Lead, ApiConnectionActionConfiguration> UpdateLead(Expression<Func<string>> id, Expression<Func<string>> updatedLeadlastName, Expression<Func<string>> updatedLeadtitle = null, Expression<Func<string>> updatedLeadfirstName = null, Expression<Func<string>> updatedLeadleadDescription = null, Expression<Func<string>> updatedLeadconvertedDateTime = null, Expression<Func<updatedLeadleadVisibilityInput>> updatedLeadleadVisibility = null, Expression<Func<int>> updatedLeadvisibleTeamId = null, Expression<Func<int>> updatedLeadvisibleUserIDs = null, Expression<Func<string>> updatedLeadorganizationName = null, Expression<Func<string>> updatedLeadphoneNumber = null, Expression<Func<string>> updatedLeadmobilePhoneNumber = null, Expression<Func<string>> updatedLeademailAddress = null, Expression<Func<bool>> updatedLeadisConverted = null, Expression<Func<string>> updatedLeadwebsiteURL = null, Expression<Func<int>> updatedLeadleadOwner = null, Expression<Func<int>> updatedLeadleadResponsible = null, Expression<Func<int>> updatedLeadleadEmployeeCount = null, Expression<Func<int>> updatedLeadleadRating = null, Expression<Func<string>> updatedLeadindustry = null, Expression<Func<Tag[]>> updatedLeadtag = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_updatedLeadlastName = WorkflowExpression.Compile(updatedLeadlastName, nameof(updatedLeadlastName), required: true);
            var __workflow_updatedLeadtitle = WorkflowExpression.Compile(updatedLeadtitle, nameof(updatedLeadtitle), required: false);
            var __workflow_updatedLeadfirstName = WorkflowExpression.Compile(updatedLeadfirstName, nameof(updatedLeadfirstName), required: false);
            var __workflow_updatedLeadleadDescription = WorkflowExpression.Compile(updatedLeadleadDescription, nameof(updatedLeadleadDescription), required: false);
            var __workflow_updatedLeadconvertedDateTime = WorkflowExpression.Compile(updatedLeadconvertedDateTime, nameof(updatedLeadconvertedDateTime), required: false);
            var __workflow_updatedLeadleadVisibility = WorkflowExpression.Compile(updatedLeadleadVisibility, nameof(updatedLeadleadVisibility), required: false);
            var __workflow_updatedLeadvisibleTeamId = WorkflowExpression.Compile(updatedLeadvisibleTeamId, nameof(updatedLeadvisibleTeamId), required: false);
            var __workflow_updatedLeadvisibleUserIDs = WorkflowExpression.Compile(updatedLeadvisibleUserIDs, nameof(updatedLeadvisibleUserIDs), required: false);
            var __workflow_updatedLeadorganizationName = WorkflowExpression.Compile(updatedLeadorganizationName, nameof(updatedLeadorganizationName), required: false);
            var __workflow_updatedLeadphoneNumber = WorkflowExpression.Compile(updatedLeadphoneNumber, nameof(updatedLeadphoneNumber), required: false);
            var __workflow_updatedLeadmobilePhoneNumber = WorkflowExpression.Compile(updatedLeadmobilePhoneNumber, nameof(updatedLeadmobilePhoneNumber), required: false);
            var __workflow_updatedLeademailAddress = WorkflowExpression.Compile(updatedLeademailAddress, nameof(updatedLeademailAddress), required: false);
            var __workflow_updatedLeadisConverted = WorkflowExpression.Compile(updatedLeadisConverted, nameof(updatedLeadisConverted), required: false);
            var __workflow_updatedLeadwebsiteURL = WorkflowExpression.Compile(updatedLeadwebsiteURL, nameof(updatedLeadwebsiteURL), required: false);
            var __workflow_updatedLeadleadOwner = WorkflowExpression.Compile(updatedLeadleadOwner, nameof(updatedLeadleadOwner), required: false);
            var __workflow_updatedLeadleadResponsible = WorkflowExpression.Compile(updatedLeadleadResponsible, nameof(updatedLeadleadResponsible), required: false);
            var __workflow_updatedLeadleadEmployeeCount = WorkflowExpression.Compile(updatedLeadleadEmployeeCount, nameof(updatedLeadleadEmployeeCount), required: false);
            var __workflow_updatedLeadleadRating = WorkflowExpression.Compile(updatedLeadleadRating, nameof(updatedLeadleadRating), required: false);
            var __workflow_updatedLeadindustry = WorkflowExpression.Compile(updatedLeadindustry, nameof(updatedLeadindustry), required: false);
            var __workflow_updatedLeadtag = WorkflowExpression.Compile(updatedLeadtag, nameof(updatedLeadtag), required: false);
            return new DeferredBodyAction<Lead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Leads";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                var updatedLead = new JObject();
                var updatedLeadpropCount = 0;
                if (__workflow_updatedLeadtitle != null)
                {
                    updatedLead["TITLE"] = ExpressionConverter.ConvertO(__workflow_updatedLeadtitle);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadfirstName != null)
                {
                    updatedLead["FIRST_NAME"] = ExpressionConverter.ConvertO(__workflow_updatedLeadfirstName);
                    updatedLeadpropCount++;
                }

                updatedLeadpropCount++;
                updatedLead["LAST_NAME"] = ExpressionConverter.ConvertO(__workflow_updatedLeadlastName);
                if (__workflow_updatedLeadleadDescription != null)
                {
                    updatedLead["LEAD_DESCRIPTION"] = ExpressionConverter.ConvertO(__workflow_updatedLeadleadDescription);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadconvertedDateTime != null)
                {
                    updatedLead["CONVERTED_DATE_UTC"] = ExpressionConverter.ConvertO(__workflow_updatedLeadconvertedDateTime);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadleadVisibility != null)
                {
                    updatedLead["VISIBLE_TO"] = ExpressionConverter.ConvertO(__workflow_updatedLeadleadVisibility);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadvisibleTeamId != null)
                {
                    updatedLead["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(__workflow_updatedLeadvisibleTeamId);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadvisibleUserIDs != null)
                {
                    updatedLead["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(__workflow_updatedLeadvisibleUserIDs);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadorganizationName != null)
                {
                    updatedLead["ORGANIZATION_NAME"] = ExpressionConverter.ConvertO(__workflow_updatedLeadorganizationName);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadphoneNumber != null)
                {
                    updatedLead["PHONE_NUMBER"] = ExpressionConverter.ConvertO(__workflow_updatedLeadphoneNumber);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadmobilePhoneNumber != null)
                {
                    updatedLead["MOBILE_PHONE_NUMBER"] = ExpressionConverter.ConvertO(__workflow_updatedLeadmobilePhoneNumber);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeademailAddress != null)
                {
                    updatedLead["EMAIL_ADDRESS"] = ExpressionConverter.ConvertO(__workflow_updatedLeademailAddress);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadisConverted != null)
                {
                    updatedLead["CONVERTED"] = ExpressionConverter.ConvertO(__workflow_updatedLeadisConverted);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadwebsiteURL != null)
                {
                    updatedLead["WEBSITE_URL"] = ExpressionConverter.ConvertO(__workflow_updatedLeadwebsiteURL);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadleadOwner != null)
                {
                    updatedLead["OWNER_USER_ID"] = ExpressionConverter.ConvertO(__workflow_updatedLeadleadOwner);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadleadResponsible != null)
                {
                    updatedLead["RESPONSIBLE_USER_ID"] = ExpressionConverter.ConvertO(__workflow_updatedLeadleadResponsible);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadleadEmployeeCount != null)
                {
                    updatedLead["EMPLOYEE_COUNT"] = ExpressionConverter.ConvertO(__workflow_updatedLeadleadEmployeeCount);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadleadRating != null)
                {
                    updatedLead["LEAD_RATING"] = ExpressionConverter.ConvertO(__workflow_updatedLeadleadRating);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadindustry != null)
                {
                    updatedLead["INDUSTRY"] = ExpressionConverter.ConvertO(__workflow_updatedLeadindustry);
                    updatedLeadpropCount++;
                }

                if (__workflow_updatedLeadtag != null)
                {
                    updatedLead["TAGS"] = ExpressionConverter.ConvertO(__workflow_updatedLeadtag);
                    updatedLeadpropCount++;
                }

                if (updatedLeadpropCount > 0)
                {
                    callPayload.Body = updatedLead;
                }

                return new ApiConnectionAction<Lead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Lead, ApiConnectionActionConfiguration> AddLead(Expression<Func<string>> newLeadlastName, Expression<Func<string>> newLeadtitle = null, Expression<Func<string>> newLeadfirstName = null, Expression<Func<string>> newLeadleadDescription = null, Expression<Func<string>> newLeadconvertedDateTime = null, Expression<Func<newLeadleadVisibilityInput>> newLeadleadVisibility = null, Expression<Func<int>> newLeadvisibleTeamId = null, Expression<Func<int>> newLeadvisibleUserIDs = null, Expression<Func<string>> newLeadorganizationName = null, Expression<Func<string>> newLeadphoneNumber = null, Expression<Func<string>> newLeadmobilePhoneNumber = null, Expression<Func<string>> newLeademailAddress = null, Expression<Func<bool>> newLeadisConverted = null, Expression<Func<string>> newLeadwebsiteURL = null, Expression<Func<int>> newLeadleadOwner = null, Expression<Func<int>> newLeadleadResponsible = null, Expression<Func<int>> newLeadleadEmployeeCount = null, Expression<Func<int>> newLeadleadRating = null, Expression<Func<string>> newLeadindustry = null, Expression<Func<Tag[]>> newLeadtag = null)
        {
            var __workflow_newLeadlastName = WorkflowExpression.Compile(newLeadlastName, nameof(newLeadlastName), required: true);
            var __workflow_newLeadtitle = WorkflowExpression.Compile(newLeadtitle, nameof(newLeadtitle), required: false);
            var __workflow_newLeadfirstName = WorkflowExpression.Compile(newLeadfirstName, nameof(newLeadfirstName), required: false);
            var __workflow_newLeadleadDescription = WorkflowExpression.Compile(newLeadleadDescription, nameof(newLeadleadDescription), required: false);
            var __workflow_newLeadconvertedDateTime = WorkflowExpression.Compile(newLeadconvertedDateTime, nameof(newLeadconvertedDateTime), required: false);
            var __workflow_newLeadleadVisibility = WorkflowExpression.Compile(newLeadleadVisibility, nameof(newLeadleadVisibility), required: false);
            var __workflow_newLeadvisibleTeamId = WorkflowExpression.Compile(newLeadvisibleTeamId, nameof(newLeadvisibleTeamId), required: false);
            var __workflow_newLeadvisibleUserIDs = WorkflowExpression.Compile(newLeadvisibleUserIDs, nameof(newLeadvisibleUserIDs), required: false);
            var __workflow_newLeadorganizationName = WorkflowExpression.Compile(newLeadorganizationName, nameof(newLeadorganizationName), required: false);
            var __workflow_newLeadphoneNumber = WorkflowExpression.Compile(newLeadphoneNumber, nameof(newLeadphoneNumber), required: false);
            var __workflow_newLeadmobilePhoneNumber = WorkflowExpression.Compile(newLeadmobilePhoneNumber, nameof(newLeadmobilePhoneNumber), required: false);
            var __workflow_newLeademailAddress = WorkflowExpression.Compile(newLeademailAddress, nameof(newLeademailAddress), required: false);
            var __workflow_newLeadisConverted = WorkflowExpression.Compile(newLeadisConverted, nameof(newLeadisConverted), required: false);
            var __workflow_newLeadwebsiteURL = WorkflowExpression.Compile(newLeadwebsiteURL, nameof(newLeadwebsiteURL), required: false);
            var __workflow_newLeadleadOwner = WorkflowExpression.Compile(newLeadleadOwner, nameof(newLeadleadOwner), required: false);
            var __workflow_newLeadleadResponsible = WorkflowExpression.Compile(newLeadleadResponsible, nameof(newLeadleadResponsible), required: false);
            var __workflow_newLeadleadEmployeeCount = WorkflowExpression.Compile(newLeadleadEmployeeCount, nameof(newLeadleadEmployeeCount), required: false);
            var __workflow_newLeadleadRating = WorkflowExpression.Compile(newLeadleadRating, nameof(newLeadleadRating), required: false);
            var __workflow_newLeadindustry = WorkflowExpression.Compile(newLeadindustry, nameof(newLeadindustry), required: false);
            var __workflow_newLeadtag = WorkflowExpression.Compile(newLeadtag, nameof(newLeadtag), required: false);
            return new DeferredBodyAction<Lead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Leads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newLead = new JObject();
                var newLeadpropCount = 0;
                if (__workflow_newLeadtitle != null)
                {
                    newLead["TITLE"] = ExpressionConverter.ConvertO(__workflow_newLeadtitle);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadfirstName != null)
                {
                    newLead["FIRST_NAME"] = ExpressionConverter.ConvertO(__workflow_newLeadfirstName);
                    newLeadpropCount++;
                }

                newLeadpropCount++;
                newLead["LAST_NAME"] = ExpressionConverter.ConvertO(__workflow_newLeadlastName);
                if (__workflow_newLeadleadDescription != null)
                {
                    newLead["LEAD_DESCRIPTION"] = ExpressionConverter.ConvertO(__workflow_newLeadleadDescription);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadconvertedDateTime != null)
                {
                    newLead["CONVERTED_DATE_UTC"] = ExpressionConverter.ConvertO(__workflow_newLeadconvertedDateTime);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadleadVisibility != null)
                {
                    newLead["VISIBLE_TO"] = ExpressionConverter.ConvertO(__workflow_newLeadleadVisibility);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadvisibleTeamId != null)
                {
                    newLead["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(__workflow_newLeadvisibleTeamId);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadvisibleUserIDs != null)
                {
                    newLead["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(__workflow_newLeadvisibleUserIDs);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadorganizationName != null)
                {
                    newLead["ORGANIZATION_NAME"] = ExpressionConverter.ConvertO(__workflow_newLeadorganizationName);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadphoneNumber != null)
                {
                    newLead["PHONE_NUMBER"] = ExpressionConverter.ConvertO(__workflow_newLeadphoneNumber);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadmobilePhoneNumber != null)
                {
                    newLead["MOBILE_PHONE_NUMBER"] = ExpressionConverter.ConvertO(__workflow_newLeadmobilePhoneNumber);
                    newLeadpropCount++;
                }

                if (__workflow_newLeademailAddress != null)
                {
                    newLead["EMAIL_ADDRESS"] = ExpressionConverter.ConvertO(__workflow_newLeademailAddress);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadisConverted != null)
                {
                    newLead["CONVERTED"] = ExpressionConverter.ConvertO(__workflow_newLeadisConverted);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadwebsiteURL != null)
                {
                    newLead["WEBSITE_URL"] = ExpressionConverter.ConvertO(__workflow_newLeadwebsiteURL);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadleadOwner != null)
                {
                    newLead["OWNER_USER_ID"] = ExpressionConverter.ConvertO(__workflow_newLeadleadOwner);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadleadResponsible != null)
                {
                    newLead["RESPONSIBLE_USER_ID"] = ExpressionConverter.ConvertO(__workflow_newLeadleadResponsible);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadleadEmployeeCount != null)
                {
                    newLead["EMPLOYEE_COUNT"] = ExpressionConverter.ConvertO(__workflow_newLeadleadEmployeeCount);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadleadRating != null)
                {
                    newLead["LEAD_RATING"] = ExpressionConverter.ConvertO(__workflow_newLeadleadRating);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadindustry != null)
                {
                    newLead["INDUSTRY"] = ExpressionConverter.ConvertO(__workflow_newLeadindustry);
                    newLeadpropCount++;
                }

                if (__workflow_newLeadtag != null)
                {
                    newLead["TAGS"] = ExpressionConverter.ConvertO(__workflow_newLeadtag);
                    newLeadpropCount++;
                }

                if (newLeadpropCount > 0)
                {
                    callPayload.Body = newLead;
                }

                return new ApiConnectionAction<Lead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListContactsResponse, ApiConnectionActionConfiguration> ListContacts()
        {
            return new DeferredBodyAction<ListContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Contact, ApiConnectionActionConfiguration> UpdateContact(Expression<Func<string>> id, Expression<Func<string>> updatedContactfirstName, Expression<Func<string>> updatedContactlastName, Expression<Func<string>> updatedContactsalutation = null, Expression<Func<string>> updatedContactbackground = null, Expression<Func<updatedContactcontactVisibilityInput>> updatedContactcontactVisibility = null, Expression<Func<int>> updatedContactvisibleTeamId = null, Expression<Func<int>> updatedContactvisibleUserIDs = null, Expression<Func<ContactInfo[]>> updatedContactcontactInformation = null, Expression<Func<Tag[]>> updatedContacttag = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_updatedContactfirstName = WorkflowExpression.Compile(updatedContactfirstName, nameof(updatedContactfirstName), required: true);
            var __workflow_updatedContactlastName = WorkflowExpression.Compile(updatedContactlastName, nameof(updatedContactlastName), required: true);
            var __workflow_updatedContactsalutation = WorkflowExpression.Compile(updatedContactsalutation, nameof(updatedContactsalutation), required: false);
            var __workflow_updatedContactbackground = WorkflowExpression.Compile(updatedContactbackground, nameof(updatedContactbackground), required: false);
            var __workflow_updatedContactcontactVisibility = WorkflowExpression.Compile(updatedContactcontactVisibility, nameof(updatedContactcontactVisibility), required: false);
            var __workflow_updatedContactvisibleTeamId = WorkflowExpression.Compile(updatedContactvisibleTeamId, nameof(updatedContactvisibleTeamId), required: false);
            var __workflow_updatedContactvisibleUserIDs = WorkflowExpression.Compile(updatedContactvisibleUserIDs, nameof(updatedContactvisibleUserIDs), required: false);
            var __workflow_updatedContactcontactInformation = WorkflowExpression.Compile(updatedContactcontactInformation, nameof(updatedContactcontactInformation), required: false);
            var __workflow_updatedContacttag = WorkflowExpression.Compile(updatedContacttag, nameof(updatedContacttag), required: false);
            return new DeferredBodyAction<Contact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contacts";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                var updatedContact = new JObject();
                var updatedContactpropCount = 0;
                if (__workflow_updatedContactsalutation != null)
                {
                    updatedContact["SALUTATION"] = ExpressionConverter.ConvertO(__workflow_updatedContactsalutation);
                    updatedContactpropCount++;
                }

                updatedContactpropCount++;
                updatedContact["FIRST_NAME"] = ExpressionConverter.ConvertO(__workflow_updatedContactfirstName);
                updatedContactpropCount++;
                updatedContact["LAST_NAME"] = ExpressionConverter.ConvertO(__workflow_updatedContactlastName);
                if (__workflow_updatedContactbackground != null)
                {
                    updatedContact["BACKGROUND"] = ExpressionConverter.ConvertO(__workflow_updatedContactbackground);
                    updatedContactpropCount++;
                }

                if (__workflow_updatedContactcontactVisibility != null)
                {
                    updatedContact["VISIBLE_TO"] = ExpressionConverter.ConvertO(__workflow_updatedContactcontactVisibility);
                    updatedContactpropCount++;
                }

                if (__workflow_updatedContactvisibleTeamId != null)
                {
                    updatedContact["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(__workflow_updatedContactvisibleTeamId);
                    updatedContactpropCount++;
                }

                if (__workflow_updatedContactvisibleUserIDs != null)
                {
                    updatedContact["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(__workflow_updatedContactvisibleUserIDs);
                    updatedContactpropCount++;
                }

                if (__workflow_updatedContactcontactInformation != null)
                {
                    updatedContact["CONTACTINFOS"] = ExpressionConverter.ConvertO(__workflow_updatedContactcontactInformation);
                    updatedContactpropCount++;
                }

                if (__workflow_updatedContacttag != null)
                {
                    updatedContact["TAGS"] = ExpressionConverter.ConvertO(__workflow_updatedContacttag);
                    updatedContactpropCount++;
                }

                if (updatedContactpropCount > 0)
                {
                    callPayload.Body = updatedContact;
                }

                return new ApiConnectionAction<Contact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Contact, ApiConnectionActionConfiguration> AddContact(Expression<Func<string>> newContactfirstName, Expression<Func<string>> newContactlastName, Expression<Func<string>> newContactsalutation = null, Expression<Func<string>> newContactbackground = null, Expression<Func<newContactcontactVisibilityInput>> newContactcontactVisibility = null, Expression<Func<int>> newContactvisibleTeamId = null, Expression<Func<int>> newContactvisibleUserIDs = null, Expression<Func<ContactInfo[]>> newContactcontactInformation = null, Expression<Func<Tag[]>> newContacttag = null)
        {
            var __workflow_newContactfirstName = WorkflowExpression.Compile(newContactfirstName, nameof(newContactfirstName), required: true);
            var __workflow_newContactlastName = WorkflowExpression.Compile(newContactlastName, nameof(newContactlastName), required: true);
            var __workflow_newContactsalutation = WorkflowExpression.Compile(newContactsalutation, nameof(newContactsalutation), required: false);
            var __workflow_newContactbackground = WorkflowExpression.Compile(newContactbackground, nameof(newContactbackground), required: false);
            var __workflow_newContactcontactVisibility = WorkflowExpression.Compile(newContactcontactVisibility, nameof(newContactcontactVisibility), required: false);
            var __workflow_newContactvisibleTeamId = WorkflowExpression.Compile(newContactvisibleTeamId, nameof(newContactvisibleTeamId), required: false);
            var __workflow_newContactvisibleUserIDs = WorkflowExpression.Compile(newContactvisibleUserIDs, nameof(newContactvisibleUserIDs), required: false);
            var __workflow_newContactcontactInformation = WorkflowExpression.Compile(newContactcontactInformation, nameof(newContactcontactInformation), required: false);
            var __workflow_newContacttag = WorkflowExpression.Compile(newContacttag, nameof(newContacttag), required: false);
            return new DeferredBodyAction<Contact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newContact = new JObject();
                var newContactpropCount = 0;
                if (__workflow_newContactsalutation != null)
                {
                    newContact["SALUTATION"] = ExpressionConverter.ConvertO(__workflow_newContactsalutation);
                    newContactpropCount++;
                }

                newContactpropCount++;
                newContact["FIRST_NAME"] = ExpressionConverter.ConvertO(__workflow_newContactfirstName);
                newContactpropCount++;
                newContact["LAST_NAME"] = ExpressionConverter.ConvertO(__workflow_newContactlastName);
                if (__workflow_newContactbackground != null)
                {
                    newContact["BACKGROUND"] = ExpressionConverter.ConvertO(__workflow_newContactbackground);
                    newContactpropCount++;
                }

                if (__workflow_newContactcontactVisibility != null)
                {
                    newContact["VISIBLE_TO"] = ExpressionConverter.ConvertO(__workflow_newContactcontactVisibility);
                    newContactpropCount++;
                }

                if (__workflow_newContactvisibleTeamId != null)
                {
                    newContact["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(__workflow_newContactvisibleTeamId);
                    newContactpropCount++;
                }

                if (__workflow_newContactvisibleUserIDs != null)
                {
                    newContact["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(__workflow_newContactvisibleUserIDs);
                    newContactpropCount++;
                }

                if (__workflow_newContactcontactInformation != null)
                {
                    newContact["CONTACTINFOS"] = ExpressionConverter.ConvertO(__workflow_newContactcontactInformation);
                    newContactpropCount++;
                }

                if (__workflow_newContacttag != null)
                {
                    newContact["TAGS"] = ExpressionConverter.ConvertO(__workflow_newContacttag);
                    newContactpropCount++;
                }

                if (newContactpropCount > 0)
                {
                    callPayload.Body = newContact;
                }

                return new ApiConnectionAction<Contact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListUsersResponse, ApiConnectionActionConfiguration> ListUsers()
        {
            return new DeferredBodyAction<ListUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteTask(Expression<Func<int>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Tasks/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FollowTask(Expression<Func<int>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Tasks/{0}/Follow", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteProject(Expression<Func<int>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Projects/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteLead(Expression<Func<int>> leadId)
        {
            var __workflow_leadId = WorkflowExpression.Compile(leadId, nameof(leadId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Leads/{0}", __workflow_leadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteContact(Expression<Func<int>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<OrganizationInfo, ApiConnectionActionConfiguration> AddOrganization(Expression<Func<string>> newOrganizationorganizationName, Expression<Func<string>> newOrganizationorganizationBackground = null, Expression<Func<newOrganizationorganizationVisibilityInput>> newOrganizationorganizationVisibility = null, Expression<Func<int>> newOrganizationvisibleTeamId = null, Expression<Func<int>> newOrganizationvisibleUserIDs = null, Expression<Func<Address[]>> newOrganizationorganizationAddress = null, Expression<Func<ContactInfo[]>> newOrganizationcontactInformation = null, Expression<Func<Tag[]>> newOrganizationtags = null)
        {
            var __workflow_newOrganizationorganizationName = WorkflowExpression.Compile(newOrganizationorganizationName, nameof(newOrganizationorganizationName), required: true);
            var __workflow_newOrganizationorganizationBackground = WorkflowExpression.Compile(newOrganizationorganizationBackground, nameof(newOrganizationorganizationBackground), required: false);
            var __workflow_newOrganizationorganizationVisibility = WorkflowExpression.Compile(newOrganizationorganizationVisibility, nameof(newOrganizationorganizationVisibility), required: false);
            var __workflow_newOrganizationvisibleTeamId = WorkflowExpression.Compile(newOrganizationvisibleTeamId, nameof(newOrganizationvisibleTeamId), required: false);
            var __workflow_newOrganizationvisibleUserIDs = WorkflowExpression.Compile(newOrganizationvisibleUserIDs, nameof(newOrganizationvisibleUserIDs), required: false);
            var __workflow_newOrganizationorganizationAddress = WorkflowExpression.Compile(newOrganizationorganizationAddress, nameof(newOrganizationorganizationAddress), required: false);
            var __workflow_newOrganizationcontactInformation = WorkflowExpression.Compile(newOrganizationcontactInformation, nameof(newOrganizationcontactInformation), required: false);
            var __workflow_newOrganizationtags = WorkflowExpression.Compile(newOrganizationtags, nameof(newOrganizationtags), required: false);
            return new DeferredBodyAction<OrganizationInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Organisations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newOrganization = new JObject();
                var newOrganizationpropCount = 0;
                newOrganizationpropCount++;
                newOrganization["ORGANISATION_NAME"] = ExpressionConverter.ConvertO(__workflow_newOrganizationorganizationName);
                if (__workflow_newOrganizationorganizationBackground != null)
                {
                    newOrganization["ORGANISATION_BACKGROUND"] = ExpressionConverter.ConvertO(__workflow_newOrganizationorganizationBackground);
                    newOrganizationpropCount++;
                }

                if (__workflow_newOrganizationorganizationVisibility != null)
                {
                    newOrganization["VISIBLE_TO"] = ExpressionConverter.ConvertO(__workflow_newOrganizationorganizationVisibility);
                    newOrganizationpropCount++;
                }

                if (__workflow_newOrganizationvisibleTeamId != null)
                {
                    newOrganization["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(__workflow_newOrganizationvisibleTeamId);
                    newOrganizationpropCount++;
                }

                if (__workflow_newOrganizationvisibleUserIDs != null)
                {
                    newOrganization["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(__workflow_newOrganizationvisibleUserIDs);
                    newOrganizationpropCount++;
                }

                if (__workflow_newOrganizationorganizationAddress != null)
                {
                    newOrganization["ADDRESSES"] = ExpressionConverter.ConvertO(__workflow_newOrganizationorganizationAddress);
                    newOrganizationpropCount++;
                }

                if (__workflow_newOrganizationcontactInformation != null)
                {
                    newOrganization["CONTACTINFOS"] = ExpressionConverter.ConvertO(__workflow_newOrganizationcontactInformation);
                    newOrganizationpropCount++;
                }

                if (__workflow_newOrganizationtags != null)
                {
                    newOrganization["TAGS"] = ExpressionConverter.ConvertO(__workflow_newOrganizationtags);
                    newOrganizationpropCount++;
                }

                if (newOrganizationpropCount > 0)
                {
                    callPayload.Body = newOrganization;
                }

                return new ApiConnectionAction<OrganizationInfo>(callPayload);
            });
        }
    }

    public class InsightlyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration> OnTaskAssignedToMe(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger1/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListTasksResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration> OnTaskCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger2/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListTasksResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration> OnTaskUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListTasksResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger3/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListTasksResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListProjectsResponse, ApiConnectionTriggerConfiguration> OnProjectCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListProjectsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger2/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListProjectsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListProjectsResponse, ApiConnectionTriggerConfiguration> OnProjectUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListProjectsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger3/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListProjectsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Lead, ApiConnectionTriggerConfiguration> OnLeadCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Lead, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger1/Leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<Lead>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Lead, ApiConnectionTriggerConfiguration> OnLeadUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Lead, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger2/Leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<Lead>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListContactsResponse, ApiConnectionTriggerConfiguration> OnContactCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListContactsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger1/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListContactsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListContactsResponse, ApiConnectionTriggerConfiguration> OnContactUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListContactsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger2/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListContactsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListEventsResponse, ApiConnectionTriggerConfiguration> OnEventCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListEventsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger1/Events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListEventsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListEventsResponse, ApiConnectionTriggerConfiguration> OnEventUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListEventsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger2/Events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListEventsResponse>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum updatedLeadleadVisibilityInput
    {
        Everyone,
        Individuals,
        Owner,
        Team
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContactInfoTypeType
    {
        Phone,
        Email,
        Social,
        Website
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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