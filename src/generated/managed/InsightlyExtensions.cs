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
            var apiCallPath = "/Tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<TaskObject> UpdateTask(Expression<Func<string>> id, Expression<Func<string>> updatedTasktaskTitle, Expression<Func<bool>> updatedTaskisCompleted, Expression<Func<updatedTasktaskStatusInput>> updatedTasktaskStatus, Expression<Func<bool>> updatedTaskisTaskVisible, Expression<Func<string>> updatedTaskdueDateTime = null, Expression<Func<string>> updatedTasktaskDetails = null, Expression<Func<int>> updatedTasktaskPriority = null)
        {
            var apiCallPath = "/Tasks";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            var updatedTask = new JObject();
            var updatedTaskpropCount = 0;
            updatedTaskpropCount++;
            updatedTask["TITLE"] = ExpressionConverter.ConvertO(updatedTasktaskTitle);
            if (updatedTaskdueDateTime != null)
            {
                updatedTask["DUE_DATE"] = ExpressionConverter.ConvertO(updatedTaskdueDateTime);
                updatedTaskpropCount++;
            }

            updatedTaskpropCount++;
            updatedTask["COMPLETED"] = ExpressionConverter.ConvertO(updatedTaskisCompleted);
            if (updatedTasktaskDetails != null)
            {
                updatedTask["DETAILS"] = ExpressionConverter.ConvertO(updatedTasktaskDetails);
                updatedTaskpropCount++;
            }

            updatedTaskpropCount++;
            updatedTask["STATUS"] = ExpressionConverter.ConvertO(updatedTasktaskStatus);
            if (updatedTasktaskPriority != null)
            {
                updatedTask["PRIORITY"] = ExpressionConverter.ConvertO(updatedTasktaskPriority);
                updatedTaskpropCount++;
            }

            updatedTaskpropCount++;
            updatedTask["PUBLICLY_VISIBLE"] = ExpressionConverter.ConvertO(updatedTaskisTaskVisible);
            if (updatedTaskpropCount > 0)
            {
                callPayload.Body = updatedTask;
            }

            return new ApiConnectionAction<TaskObject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<TaskObject> AddTask(Expression<Func<string>> newTasktaskTitle, Expression<Func<bool>> newTaskisCompleted, Expression<Func<newTasktaskStatusInput>> newTasktaskStatus, Expression<Func<bool>> newTaskisTaskVisible, Expression<Func<string>> newTaskdueDateTime = null, Expression<Func<string>> newTasktaskDetails = null, Expression<Func<int>> newTasktaskPriority = null)
        {
            var apiCallPath = "/Tasks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newTask = new JObject();
            var newTaskpropCount = 0;
            newTaskpropCount++;
            newTask["TITLE"] = ExpressionConverter.ConvertO(newTasktaskTitle);
            if (newTaskdueDateTime != null)
            {
                newTask["DUE_DATE"] = ExpressionConverter.ConvertO(newTaskdueDateTime);
                newTaskpropCount++;
            }

            newTaskpropCount++;
            newTask["COMPLETED"] = ExpressionConverter.ConvertO(newTaskisCompleted);
            if (newTasktaskDetails != null)
            {
                newTask["DETAILS"] = ExpressionConverter.ConvertO(newTasktaskDetails);
                newTaskpropCount++;
            }

            newTaskpropCount++;
            newTask["STATUS"] = ExpressionConverter.ConvertO(newTasktaskStatus);
            if (newTasktaskPriority != null)
            {
                newTask["PRIORITY"] = ExpressionConverter.ConvertO(newTasktaskPriority);
                newTaskpropCount++;
            }

            newTaskpropCount++;
            newTask["PUBLICLY_VISIBLE"] = ExpressionConverter.ConvertO(newTaskisTaskVisible);
            if (newTaskpropCount > 0)
            {
                callPayload.Body = newTask;
            }

            return new ApiConnectionAction<TaskObject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListProjectsResponse> ListProjects()
        {
            var apiCallPath = "/Projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Project> UpdateProject(Expression<Func<string>> id, Expression<Func<string>> updatedProjectprojectName, Expression<Func<updatedProjectprojectStatusInput>> updatedProjectprojectStatus, Expression<Func<string>> updatedProjectprojectDetails = null, Expression<Func<string>> updatedProjectimageURL = null, Expression<Func<updatedProjectprojectVisibilityInput>> updatedProjectprojectVisibility = null, Expression<Func<int>> updatedProjectvisibleTeamId = null, Expression<Func<int>> updatedProjectvisibleUserIDs = null, Expression<Func<int>> updatedProjectopportunityId = null, Expression<Func<int>> updatedProjectpipelineId = null, Expression<Func<int>> updatedProjectstageId = null, Expression<Func<Tag[]>> updatedProjecttags = null)
        {
            var apiCallPath = "/Projects";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            var updatedProject = new JObject();
            var updatedProjectpropCount = 0;
            updatedProjectpropCount++;
            updatedProject["PROJECT_NAME"] = ExpressionConverter.ConvertO(updatedProjectprojectName);
            if (updatedProjectprojectDetails != null)
            {
                updatedProject["PROJECT_DETAILS"] = ExpressionConverter.ConvertO(updatedProjectprojectDetails);
                updatedProjectpropCount++;
            }

            updatedProjectpropCount++;
            updatedProject["STATUS"] = ExpressionConverter.ConvertO(updatedProjectprojectStatus);
            if (updatedProjectimageURL != null)
            {
                updatedProject["IMAGE_URL"] = ExpressionConverter.ConvertO(updatedProjectimageURL);
                updatedProjectpropCount++;
            }

            if (updatedProjectprojectVisibility != null)
            {
                updatedProject["VISIBLE_TO"] = ExpressionConverter.ConvertO(updatedProjectprojectVisibility);
                updatedProjectpropCount++;
            }

            if (updatedProjectvisibleTeamId != null)
            {
                updatedProject["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(updatedProjectvisibleTeamId);
                updatedProjectpropCount++;
            }

            if (updatedProjectvisibleUserIDs != null)
            {
                updatedProject["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(updatedProjectvisibleUserIDs);
                updatedProjectpropCount++;
            }

            if (updatedProjectopportunityId != null)
            {
                updatedProject["OPPORTUNITY_ID"] = ExpressionConverter.ConvertO(updatedProjectopportunityId);
                updatedProjectpropCount++;
            }

            if (updatedProjectpipelineId != null)
            {
                updatedProject["PIPELINE_ID"] = ExpressionConverter.ConvertO(updatedProjectpipelineId);
                updatedProjectpropCount++;
            }

            if (updatedProjectstageId != null)
            {
                updatedProject["STAGE_ID"] = ExpressionConverter.ConvertO(updatedProjectstageId);
                updatedProjectpropCount++;
            }

            if (updatedProjecttags != null)
            {
                updatedProject["TAGS"] = ExpressionConverter.ConvertO(updatedProjecttags);
                updatedProjectpropCount++;
            }

            if (updatedProjectpropCount > 0)
            {
                callPayload.Body = updatedProject;
            }

            return new ApiConnectionAction<Project>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Project> AddProject(Expression<Func<string>> newProjectprojectName, Expression<Func<newProjectprojectStatusInput>> newProjectprojectStatus, Expression<Func<string>> newProjectprojectDetails = null, Expression<Func<string>> newProjectimageURL = null, Expression<Func<newProjectprojectVisibilityInput>> newProjectprojectVisibility = null, Expression<Func<int>> newProjectvisibleTeamId = null, Expression<Func<int>> newProjectvisibleUserIDs = null, Expression<Func<int>> newProjectopportunityId = null, Expression<Func<int>> newProjectpipelineId = null, Expression<Func<int>> newProjectstageId = null, Expression<Func<Tag[]>> newProjecttags = null)
        {
            var apiCallPath = "/Projects";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newProject = new JObject();
            var newProjectpropCount = 0;
            newProjectpropCount++;
            newProject["PROJECT_NAME"] = ExpressionConverter.ConvertO(newProjectprojectName);
            if (newProjectprojectDetails != null)
            {
                newProject["PROJECT_DETAILS"] = ExpressionConverter.ConvertO(newProjectprojectDetails);
                newProjectpropCount++;
            }

            newProjectpropCount++;
            newProject["STATUS"] = ExpressionConverter.ConvertO(newProjectprojectStatus);
            if (newProjectimageURL != null)
            {
                newProject["IMAGE_URL"] = ExpressionConverter.ConvertO(newProjectimageURL);
                newProjectpropCount++;
            }

            if (newProjectprojectVisibility != null)
            {
                newProject["VISIBLE_TO"] = ExpressionConverter.ConvertO(newProjectprojectVisibility);
                newProjectpropCount++;
            }

            if (newProjectvisibleTeamId != null)
            {
                newProject["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(newProjectvisibleTeamId);
                newProjectpropCount++;
            }

            if (newProjectvisibleUserIDs != null)
            {
                newProject["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(newProjectvisibleUserIDs);
                newProjectpropCount++;
            }

            if (newProjectopportunityId != null)
            {
                newProject["OPPORTUNITY_ID"] = ExpressionConverter.ConvertO(newProjectopportunityId);
                newProjectpropCount++;
            }

            if (newProjectpipelineId != null)
            {
                newProject["PIPELINE_ID"] = ExpressionConverter.ConvertO(newProjectpipelineId);
                newProjectpropCount++;
            }

            if (newProjectstageId != null)
            {
                newProject["STAGE_ID"] = ExpressionConverter.ConvertO(newProjectstageId);
                newProjectpropCount++;
            }

            if (newProjecttags != null)
            {
                newProject["TAGS"] = ExpressionConverter.ConvertO(newProjecttags);
                newProjectpropCount++;
            }

            if (newProjectpropCount > 0)
            {
                callPayload.Body = newProject;
            }

            return new ApiConnectionAction<Project>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListLeadsResponse> ListLeads()
        {
            var apiCallPath = "/Leads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListLeadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Lead> UpdateLead(Expression<Func<string>> id, Expression<Func<string>> updatedLeadlastName, Expression<Func<string>> updatedLeadtitle = null, Expression<Func<string>> updatedLeadfirstName = null, Expression<Func<string>> updatedLeadleadDescription = null, Expression<Func<string>> updatedLeadconvertedDateTime = null, Expression<Func<updatedLeadleadVisibilityInput>> updatedLeadleadVisibility = null, Expression<Func<int>> updatedLeadvisibleTeamId = null, Expression<Func<int>> updatedLeadvisibleUserIDs = null, Expression<Func<string>> updatedLeadorganizationName = null, Expression<Func<string>> updatedLeadphoneNumber = null, Expression<Func<string>> updatedLeadmobilePhoneNumber = null, Expression<Func<string>> updatedLeademailAddress = null, Expression<Func<bool>> updatedLeadisConverted = null, Expression<Func<string>> updatedLeadwebsiteURL = null, Expression<Func<int>> updatedLeadleadOwner = null, Expression<Func<int>> updatedLeadleadResponsible = null, Expression<Func<int>> updatedLeadleadEmployeeCount = null, Expression<Func<int>> updatedLeadleadRating = null, Expression<Func<string>> updatedLeadindustry = null, Expression<Func<Tag[]>> updatedLeadtag = null)
        {
            var apiCallPath = "/Leads";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            var updatedLead = new JObject();
            var updatedLeadpropCount = 0;
            if (updatedLeadtitle != null)
            {
                updatedLead["TITLE"] = ExpressionConverter.ConvertO(updatedLeadtitle);
                updatedLeadpropCount++;
            }

            if (updatedLeadfirstName != null)
            {
                updatedLead["FIRST_NAME"] = ExpressionConverter.ConvertO(updatedLeadfirstName);
                updatedLeadpropCount++;
            }

            updatedLeadpropCount++;
            updatedLead["LAST_NAME"] = ExpressionConverter.ConvertO(updatedLeadlastName);
            if (updatedLeadleadDescription != null)
            {
                updatedLead["LEAD_DESCRIPTION"] = ExpressionConverter.ConvertO(updatedLeadleadDescription);
                updatedLeadpropCount++;
            }

            if (updatedLeadconvertedDateTime != null)
            {
                updatedLead["CONVERTED_DATE_UTC"] = ExpressionConverter.ConvertO(updatedLeadconvertedDateTime);
                updatedLeadpropCount++;
            }

            if (updatedLeadleadVisibility != null)
            {
                updatedLead["VISIBLE_TO"] = ExpressionConverter.ConvertO(updatedLeadleadVisibility);
                updatedLeadpropCount++;
            }

            if (updatedLeadvisibleTeamId != null)
            {
                updatedLead["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(updatedLeadvisibleTeamId);
                updatedLeadpropCount++;
            }

            if (updatedLeadvisibleUserIDs != null)
            {
                updatedLead["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(updatedLeadvisibleUserIDs);
                updatedLeadpropCount++;
            }

            if (updatedLeadorganizationName != null)
            {
                updatedLead["ORGANIZATION_NAME"] = ExpressionConverter.ConvertO(updatedLeadorganizationName);
                updatedLeadpropCount++;
            }

            if (updatedLeadphoneNumber != null)
            {
                updatedLead["PHONE_NUMBER"] = ExpressionConverter.ConvertO(updatedLeadphoneNumber);
                updatedLeadpropCount++;
            }

            if (updatedLeadmobilePhoneNumber != null)
            {
                updatedLead["MOBILE_PHONE_NUMBER"] = ExpressionConverter.ConvertO(updatedLeadmobilePhoneNumber);
                updatedLeadpropCount++;
            }

            if (updatedLeademailAddress != null)
            {
                updatedLead["EMAIL_ADDRESS"] = ExpressionConverter.ConvertO(updatedLeademailAddress);
                updatedLeadpropCount++;
            }

            if (updatedLeadisConverted != null)
            {
                updatedLead["CONVERTED"] = ExpressionConverter.ConvertO(updatedLeadisConverted);
                updatedLeadpropCount++;
            }

            if (updatedLeadwebsiteURL != null)
            {
                updatedLead["WEBSITE_URL"] = ExpressionConverter.ConvertO(updatedLeadwebsiteURL);
                updatedLeadpropCount++;
            }

            if (updatedLeadleadOwner != null)
            {
                updatedLead["OWNER_USER_ID"] = ExpressionConverter.ConvertO(updatedLeadleadOwner);
                updatedLeadpropCount++;
            }

            if (updatedLeadleadResponsible != null)
            {
                updatedLead["RESPONSIBLE_USER_ID"] = ExpressionConverter.ConvertO(updatedLeadleadResponsible);
                updatedLeadpropCount++;
            }

            if (updatedLeadleadEmployeeCount != null)
            {
                updatedLead["EMPLOYEE_COUNT"] = ExpressionConverter.ConvertO(updatedLeadleadEmployeeCount);
                updatedLeadpropCount++;
            }

            if (updatedLeadleadRating != null)
            {
                updatedLead["LEAD_RATING"] = ExpressionConverter.ConvertO(updatedLeadleadRating);
                updatedLeadpropCount++;
            }

            if (updatedLeadindustry != null)
            {
                updatedLead["INDUSTRY"] = ExpressionConverter.ConvertO(updatedLeadindustry);
                updatedLeadpropCount++;
            }

            if (updatedLeadtag != null)
            {
                updatedLead["TAGS"] = ExpressionConverter.ConvertO(updatedLeadtag);
                updatedLeadpropCount++;
            }

            if (updatedLeadpropCount > 0)
            {
                callPayload.Body = updatedLead;
            }

            return new ApiConnectionAction<Lead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Lead> AddLead(Expression<Func<string>> newLeadlastName, Expression<Func<string>> newLeadtitle = null, Expression<Func<string>> newLeadfirstName = null, Expression<Func<string>> newLeadleadDescription = null, Expression<Func<string>> newLeadconvertedDateTime = null, Expression<Func<newLeadleadVisibilityInput>> newLeadleadVisibility = null, Expression<Func<int>> newLeadvisibleTeamId = null, Expression<Func<int>> newLeadvisibleUserIDs = null, Expression<Func<string>> newLeadorganizationName = null, Expression<Func<string>> newLeadphoneNumber = null, Expression<Func<string>> newLeadmobilePhoneNumber = null, Expression<Func<string>> newLeademailAddress = null, Expression<Func<bool>> newLeadisConverted = null, Expression<Func<string>> newLeadwebsiteURL = null, Expression<Func<int>> newLeadleadOwner = null, Expression<Func<int>> newLeadleadResponsible = null, Expression<Func<int>> newLeadleadEmployeeCount = null, Expression<Func<int>> newLeadleadRating = null, Expression<Func<string>> newLeadindustry = null, Expression<Func<Tag[]>> newLeadtag = null)
        {
            var apiCallPath = "/Leads";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newLead = new JObject();
            var newLeadpropCount = 0;
            if (newLeadtitle != null)
            {
                newLead["TITLE"] = ExpressionConverter.ConvertO(newLeadtitle);
                newLeadpropCount++;
            }

            if (newLeadfirstName != null)
            {
                newLead["FIRST_NAME"] = ExpressionConverter.ConvertO(newLeadfirstName);
                newLeadpropCount++;
            }

            newLeadpropCount++;
            newLead["LAST_NAME"] = ExpressionConverter.ConvertO(newLeadlastName);
            if (newLeadleadDescription != null)
            {
                newLead["LEAD_DESCRIPTION"] = ExpressionConverter.ConvertO(newLeadleadDescription);
                newLeadpropCount++;
            }

            if (newLeadconvertedDateTime != null)
            {
                newLead["CONVERTED_DATE_UTC"] = ExpressionConverter.ConvertO(newLeadconvertedDateTime);
                newLeadpropCount++;
            }

            if (newLeadleadVisibility != null)
            {
                newLead["VISIBLE_TO"] = ExpressionConverter.ConvertO(newLeadleadVisibility);
                newLeadpropCount++;
            }

            if (newLeadvisibleTeamId != null)
            {
                newLead["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(newLeadvisibleTeamId);
                newLeadpropCount++;
            }

            if (newLeadvisibleUserIDs != null)
            {
                newLead["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(newLeadvisibleUserIDs);
                newLeadpropCount++;
            }

            if (newLeadorganizationName != null)
            {
                newLead["ORGANIZATION_NAME"] = ExpressionConverter.ConvertO(newLeadorganizationName);
                newLeadpropCount++;
            }

            if (newLeadphoneNumber != null)
            {
                newLead["PHONE_NUMBER"] = ExpressionConverter.ConvertO(newLeadphoneNumber);
                newLeadpropCount++;
            }

            if (newLeadmobilePhoneNumber != null)
            {
                newLead["MOBILE_PHONE_NUMBER"] = ExpressionConverter.ConvertO(newLeadmobilePhoneNumber);
                newLeadpropCount++;
            }

            if (newLeademailAddress != null)
            {
                newLead["EMAIL_ADDRESS"] = ExpressionConverter.ConvertO(newLeademailAddress);
                newLeadpropCount++;
            }

            if (newLeadisConverted != null)
            {
                newLead["CONVERTED"] = ExpressionConverter.ConvertO(newLeadisConverted);
                newLeadpropCount++;
            }

            if (newLeadwebsiteURL != null)
            {
                newLead["WEBSITE_URL"] = ExpressionConverter.ConvertO(newLeadwebsiteURL);
                newLeadpropCount++;
            }

            if (newLeadleadOwner != null)
            {
                newLead["OWNER_USER_ID"] = ExpressionConverter.ConvertO(newLeadleadOwner);
                newLeadpropCount++;
            }

            if (newLeadleadResponsible != null)
            {
                newLead["RESPONSIBLE_USER_ID"] = ExpressionConverter.ConvertO(newLeadleadResponsible);
                newLeadpropCount++;
            }

            if (newLeadleadEmployeeCount != null)
            {
                newLead["EMPLOYEE_COUNT"] = ExpressionConverter.ConvertO(newLeadleadEmployeeCount);
                newLeadpropCount++;
            }

            if (newLeadleadRating != null)
            {
                newLead["LEAD_RATING"] = ExpressionConverter.ConvertO(newLeadleadRating);
                newLeadpropCount++;
            }

            if (newLeadindustry != null)
            {
                newLead["INDUSTRY"] = ExpressionConverter.ConvertO(newLeadindustry);
                newLeadpropCount++;
            }

            if (newLeadtag != null)
            {
                newLead["TAGS"] = ExpressionConverter.ConvertO(newLeadtag);
                newLeadpropCount++;
            }

            if (newLeadpropCount > 0)
            {
                callPayload.Body = newLead;
            }

            return new ApiConnectionAction<Lead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListContactsResponse> ListContacts()
        {
            var apiCallPath = "/Contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListContactsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Contact> UpdateContact(Expression<Func<string>> id, Expression<Func<string>> updatedContactfirstName, Expression<Func<string>> updatedContactlastName, Expression<Func<string>> updatedContactsalutation = null, Expression<Func<string>> updatedContactbackground = null, Expression<Func<updatedContactcontactVisibilityInput>> updatedContactcontactVisibility = null, Expression<Func<int>> updatedContactvisibleTeamId = null, Expression<Func<int>> updatedContactvisibleUserIDs = null, Expression<Func<ContactInfo[]>> updatedContactcontactInformation = null, Expression<Func<Tag[]>> updatedContacttag = null)
        {
            var apiCallPath = "/Contacts";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            var updatedContact = new JObject();
            var updatedContactpropCount = 0;
            if (updatedContactsalutation != null)
            {
                updatedContact["SALUTATION"] = ExpressionConverter.ConvertO(updatedContactsalutation);
                updatedContactpropCount++;
            }

            updatedContactpropCount++;
            updatedContact["FIRST_NAME"] = ExpressionConverter.ConvertO(updatedContactfirstName);
            updatedContactpropCount++;
            updatedContact["LAST_NAME"] = ExpressionConverter.ConvertO(updatedContactlastName);
            if (updatedContactbackground != null)
            {
                updatedContact["BACKGROUND"] = ExpressionConverter.ConvertO(updatedContactbackground);
                updatedContactpropCount++;
            }

            if (updatedContactcontactVisibility != null)
            {
                updatedContact["VISIBLE_TO"] = ExpressionConverter.ConvertO(updatedContactcontactVisibility);
                updatedContactpropCount++;
            }

            if (updatedContactvisibleTeamId != null)
            {
                updatedContact["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(updatedContactvisibleTeamId);
                updatedContactpropCount++;
            }

            if (updatedContactvisibleUserIDs != null)
            {
                updatedContact["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(updatedContactvisibleUserIDs);
                updatedContactpropCount++;
            }

            if (updatedContactcontactInformation != null)
            {
                updatedContact["CONTACTINFOS"] = ExpressionConverter.ConvertO(updatedContactcontactInformation);
                updatedContactpropCount++;
            }

            if (updatedContacttag != null)
            {
                updatedContact["TAGS"] = ExpressionConverter.ConvertO(updatedContacttag);
                updatedContactpropCount++;
            }

            if (updatedContactpropCount > 0)
            {
                callPayload.Body = updatedContact;
            }

            return new ApiConnectionAction<Contact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<Contact> AddContact(Expression<Func<string>> newContactfirstName, Expression<Func<string>> newContactlastName, Expression<Func<string>> newContactsalutation = null, Expression<Func<string>> newContactbackground = null, Expression<Func<newContactcontactVisibilityInput>> newContactcontactVisibility = null, Expression<Func<int>> newContactvisibleTeamId = null, Expression<Func<int>> newContactvisibleUserIDs = null, Expression<Func<ContactInfo[]>> newContactcontactInformation = null, Expression<Func<Tag[]>> newContacttag = null)
        {
            var apiCallPath = "/Contacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newContact = new JObject();
            var newContactpropCount = 0;
            if (newContactsalutation != null)
            {
                newContact["SALUTATION"] = ExpressionConverter.ConvertO(newContactsalutation);
                newContactpropCount++;
            }

            newContactpropCount++;
            newContact["FIRST_NAME"] = ExpressionConverter.ConvertO(newContactfirstName);
            newContactpropCount++;
            newContact["LAST_NAME"] = ExpressionConverter.ConvertO(newContactlastName);
            if (newContactbackground != null)
            {
                newContact["BACKGROUND"] = ExpressionConverter.ConvertO(newContactbackground);
                newContactpropCount++;
            }

            if (newContactcontactVisibility != null)
            {
                newContact["VISIBLE_TO"] = ExpressionConverter.ConvertO(newContactcontactVisibility);
                newContactpropCount++;
            }

            if (newContactvisibleTeamId != null)
            {
                newContact["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(newContactvisibleTeamId);
                newContactpropCount++;
            }

            if (newContactvisibleUserIDs != null)
            {
                newContact["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(newContactvisibleUserIDs);
                newContactpropCount++;
            }

            if (newContactcontactInformation != null)
            {
                newContact["CONTACTINFOS"] = ExpressionConverter.ConvertO(newContactcontactInformation);
                newContactpropCount++;
            }

            if (newContacttag != null)
            {
                newContact["TAGS"] = ExpressionConverter.ConvertO(newContacttag);
                newContactpropCount++;
            }

            if (newContactpropCount > 0)
            {
                callPayload.Body = newContact;
            }

            return new ApiConnectionAction<Contact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers()
        {
            var apiCallPath = "/Users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken> DeleteTask(Expression<Func<int>> taskId)
        {
            var apiCallPath = String.Format("/Tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken> FollowTask(Expression<Func<int>> taskId)
        {
            var apiCallPath = String.Format("/Tasks/{0}/Follow", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken> DeleteProject(Expression<Func<int>> projectId)
        {
            var apiCallPath = String.Format("/Projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken> DeleteLead(Expression<Func<int>> leadId)
        {
            var apiCallPath = String.Format("/Leads/{0}", ExpressionConverter.ConvertWithUrlEncoding(leadId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<JToken> DeleteContact(Expression<Func<int>> contactId)
        {
            var apiCallPath = String.Format("/Contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "insightly")]
        public IBodyWorkflowAction<OrganizationInfo> AddOrganization(Expression<Func<string>> newOrganizationorganizationName, Expression<Func<string>> newOrganizationorganizationBackground = null, Expression<Func<newOrganizationorganizationVisibilityInput>> newOrganizationorganizationVisibility = null, Expression<Func<int>> newOrganizationvisibleTeamId = null, Expression<Func<int>> newOrganizationvisibleUserIDs = null, Expression<Func<Address[]>> newOrganizationorganizationAddress = null, Expression<Func<ContactInfo[]>> newOrganizationcontactInformation = null, Expression<Func<Tag[]>> newOrganizationtags = null)
        {
            var apiCallPath = "/Organisations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newOrganization = new JObject();
            var newOrganizationpropCount = 0;
            newOrganizationpropCount++;
            newOrganization["ORGANISATION_NAME"] = ExpressionConverter.ConvertO(newOrganizationorganizationName);
            if (newOrganizationorganizationBackground != null)
            {
                newOrganization["ORGANISATION_BACKGROUND"] = ExpressionConverter.ConvertO(newOrganizationorganizationBackground);
                newOrganizationpropCount++;
            }

            if (newOrganizationorganizationVisibility != null)
            {
                newOrganization["VISIBLE_TO"] = ExpressionConverter.ConvertO(newOrganizationorganizationVisibility);
                newOrganizationpropCount++;
            }

            if (newOrganizationvisibleTeamId != null)
            {
                newOrganization["VISIBLE_TEAM_ID"] = ExpressionConverter.ConvertO(newOrganizationvisibleTeamId);
                newOrganizationpropCount++;
            }

            if (newOrganizationvisibleUserIDs != null)
            {
                newOrganization["VISIBLE_USER_IDS"] = ExpressionConverter.ConvertO(newOrganizationvisibleUserIDs);
                newOrganizationpropCount++;
            }

            if (newOrganizationorganizationAddress != null)
            {
                newOrganization["ADDRESSES"] = ExpressionConverter.ConvertO(newOrganizationorganizationAddress);
                newOrganizationpropCount++;
            }

            if (newOrganizationcontactInformation != null)
            {
                newOrganization["CONTACTINFOS"] = ExpressionConverter.ConvertO(newOrganizationcontactInformation);
                newOrganizationpropCount++;
            }

            if (newOrganizationtags != null)
            {
                newOrganization["TAGS"] = ExpressionConverter.ConvertO(newOrganizationtags);
                newOrganizationpropCount++;
            }

            if (newOrganizationpropCount > 0)
            {
                callPayload.Body = newOrganization;
            }

            return new ApiConnectionAction<OrganizationInfo>(callPayload);
        }
    }

    public class InsightlyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTasksResponse> OnTaskAssignedToMe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger1/Tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListTasksResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListTasksResponse> OnTaskCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger2/Tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListTasksResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListTasksResponse> OnTaskUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger3/Tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListTasksResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListProjectsResponse> OnProjectCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger2/Projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListProjectsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListProjectsResponse> OnProjectUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger3/Projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListProjectsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Lead> OnLeadCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger1/Leads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<Lead>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Lead> OnLeadUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger2/Leads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<Lead>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListContactsResponse> OnContactCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger1/Contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListContactsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListContactsResponse> OnContactUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger2/Contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListContactsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListEventsResponse> OnEventCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger1/Events";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListEventsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListEventsResponse> OnEventUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger2/Events";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListEventsResponse>(callPayload, triggerName, recurrence);
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