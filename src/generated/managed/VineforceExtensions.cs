//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vineforce
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VineforceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyfromEmail = null, Expression<Func<string>> bodytoEmail = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bodypriorityTextInput>> bodypriorityText = null, Expression<Func<string>> bodyassociatedContactEmail = null, Expression<Func<bodyresourceAppNameInput>> bodyresourceAppName = null, Expression<Func<string>> bodyresourceAppUrl = null, Expression<Func<string>> bodyresourceAppID = null, Expression<Func<string>> bodyresourceAppData = null, Expression<Func<string>> bodyreferenceId = null, Expression<Func<string>> bodyreferenceData = null, Expression<Func<string>> bodyreferenceSource = null, Expression<Func<string>> bodyprojectName = null, Expression<Func<string>> bodyprojectSectionName = null, Expression<Func<string>> bodyprojectTags = null, Expression<Func<bodychecklistsInputItem[]>> bodychecklists = null, Expression<Func<bodyfilesInputItem[]>> bodyfiles = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyfromEmail = WorkflowExpression.Compile(bodyfromEmail, nameof(bodyfromEmail), required: false);
            var __workflow_bodytoEmail = WorkflowExpression.Compile(bodytoEmail, nameof(bodytoEmail), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodypriorityText = WorkflowExpression.Compile(bodypriorityText, nameof(bodypriorityText), required: false);
            var __workflow_bodyassociatedContactEmail = WorkflowExpression.Compile(bodyassociatedContactEmail, nameof(bodyassociatedContactEmail), required: false);
            var __workflow_bodyresourceAppName = WorkflowExpression.Compile(bodyresourceAppName, nameof(bodyresourceAppName), required: false);
            var __workflow_bodyresourceAppUrl = WorkflowExpression.Compile(bodyresourceAppUrl, nameof(bodyresourceAppUrl), required: false);
            var __workflow_bodyresourceAppID = WorkflowExpression.Compile(bodyresourceAppID, nameof(bodyresourceAppID), required: false);
            var __workflow_bodyresourceAppData = WorkflowExpression.Compile(bodyresourceAppData, nameof(bodyresourceAppData), required: false);
            var __workflow_bodyreferenceId = WorkflowExpression.Compile(bodyreferenceId, nameof(bodyreferenceId), required: false);
            var __workflow_bodyreferenceData = WorkflowExpression.Compile(bodyreferenceData, nameof(bodyreferenceData), required: false);
            var __workflow_bodyreferenceSource = WorkflowExpression.Compile(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            var __workflow_bodyprojectName = WorkflowExpression.Compile(bodyprojectName, nameof(bodyprojectName), required: false);
            var __workflow_bodyprojectSectionName = WorkflowExpression.Compile(bodyprojectSectionName, nameof(bodyprojectSectionName), required: false);
            var __workflow_bodyprojectTags = WorkflowExpression.Compile(bodyprojectTags, nameof(bodyprojectTags), required: false);
            var __workflow_bodychecklists = WorkflowExpression.Compile(bodychecklists, nameof(bodychecklists), required: false);
            var __workflow_bodyfiles = WorkflowExpression.Compile(bodyfiles, nameof(bodyfiles), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateExternalTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                if (__workflow_bodyfromEmail != null)
                {
                    body["fromEmail"] = ExpressionConverter.ConvertO(__workflow_bodyfromEmail);
                    bodypropCount++;
                }

                if (__workflow_bodytoEmail != null)
                {
                    body["toEmail"] = ExpressionConverter.ConvertO(__workflow_bodytoEmail);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityText != null)
                {
                    body["priorityText"] = ExpressionConverter.ConvertO(__workflow_bodypriorityText);
                    bodypropCount++;
                }

                if (__workflow_bodyassociatedContactEmail != null)
                {
                    body["associatedContactEmail"] = ExpressionConverter.ConvertO(__workflow_bodyassociatedContactEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceAppName != null)
                {
                    body["resourceAppName"] = ExpressionConverter.ConvertO(__workflow_bodyresourceAppName);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceAppUrl != null)
                {
                    body["resourceAppUrl"] = ExpressionConverter.ConvertO(__workflow_bodyresourceAppUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceAppID != null)
                {
                    body["resourceAppID"] = ExpressionConverter.ConvertO(__workflow_bodyresourceAppID);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceAppData != null)
                {
                    body["resourceAppData"] = ExpressionConverter.ConvertO(__workflow_bodyresourceAppData);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceId != null)
                {
                    body["referenceId"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceId);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceData != null)
                {
                    body["referenceData"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceData);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceSource != null)
                {
                    body["referenceSource"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceSource);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectName != null)
                {
                    body["projectName"] = ExpressionConverter.ConvertO(__workflow_bodyprojectName);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectSectionName != null)
                {
                    body["projectSectionName"] = ExpressionConverter.ConvertO(__workflow_bodyprojectSectionName);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectTags != null)
                {
                    body["projectTags"] = ExpressionConverter.ConvertO(__workflow_bodyprojectTags);
                    bodypropCount++;
                }

                if (__workflow_bodychecklists != null)
                {
                    body["checklists"] = ExpressionConverter.ConvertO(__workflow_bodychecklists);
                    bodypropCount++;
                }

                if (__workflow_bodyfiles != null)
                {
                    body["files"] = ExpressionConverter.ConvertO(__workflow_bodyfiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<AlertResponse> Alert(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyalertToEmail, Expression<Func<string>> bodytitle, Expression<Func<string>> bodymessage, Expression<Func<bodyresourceNameInput>> bodyresourceName = null, Expression<Func<string>> bodyresourceUrl = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodyalertToEmail = WorkflowExpression.Compile(bodyalertToEmail, nameof(bodyalertToEmail), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodyresourceName = WorkflowExpression.Compile(bodyresourceName, nameof(bodyresourceName), required: false);
            var __workflow_bodyresourceUrl = WorkflowExpression.Compile(bodyresourceUrl, nameof(bodyresourceUrl), required: false);
            return new DeferredBodyAction<AlertResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/PushNotificationFromExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["alertToEmail"] = ExpressionConverter.ConvertO(__workflow_bodyalertToEmail);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                if (__workflow_bodyresourceName != null)
                {
                    body["resourceName"] = ExpressionConverter.ConvertO(__workflow_bodyresourceName);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceUrl != null)
                {
                    body["ResourceUrl"] = ExpressionConverter.ConvertO(__workflow_bodyresourceUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AlertResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject(Expression<Func<string>> bodyprojectName, Expression<Func<string>> bodycreatorEmail, Expression<Func<string>> bodyapiKey, Expression<Func<bodyfilesInputItem2[]>> bodyfiles, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bool>> bodyisPrivate = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodymembers = null, Expression<Func<string>> bodysections = null, Expression<Func<string>> bodyreferenceId = null, Expression<Func<string>> bodyreferenceData = null, Expression<Func<string>> bodyreferenceSource = null)
        {
            var __workflow_bodyprojectName = WorkflowExpression.Compile(bodyprojectName, nameof(bodyprojectName), required: true);
            var __workflow_bodycreatorEmail = WorkflowExpression.Compile(bodycreatorEmail, nameof(bodycreatorEmail), required: true);
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodyfiles = WorkflowExpression.Compile(bodyfiles, nameof(bodyfiles), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodymembers = WorkflowExpression.Compile(bodymembers, nameof(bodymembers), required: false);
            var __workflow_bodysections = WorkflowExpression.Compile(bodysections, nameof(bodysections), required: false);
            var __workflow_bodyreferenceId = WorkflowExpression.Compile(bodyreferenceId, nameof(bodyreferenceId), required: false);
            var __workflow_bodyreferenceData = WorkflowExpression.Compile(bodyreferenceData, nameof(bodyreferenceData), required: false);
            var __workflow_bodyreferenceSource = WorkflowExpression.Compile(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            return new DeferredBodyAction<CreateProjectResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateExternalProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["projectName"] = ExpressionConverter.ConvertO(__workflow_bodyprojectName);
                bodypropCount++;
                body["creatorEmail"] = ExpressionConverter.ConvertO(__workflow_bodycreatorEmail);
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrivate != null)
                {
                    if (__workflow_bodyisPrivate != null)
                    {
                        body["isPrivate"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["isPrivate"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodymembers != null)
                {
                    body["members"] = ExpressionConverter.ConvertO(__workflow_bodymembers);
                    bodypropCount++;
                }

                if (__workflow_bodysections != null)
                {
                    body["sections"] = ExpressionConverter.ConvertO(__workflow_bodysections);
                    bodypropCount++;
                }

                bodypropCount++;
                body["files"] = ExpressionConverter.ConvertO(__workflow_bodyfiles);
                if (__workflow_bodyreferenceId != null)
                {
                    body["referenceId"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceId);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceData != null)
                {
                    body["referenceData"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceData);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceSource != null)
                {
                    body["referenceSource"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceSource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodytaskID, Expression<Func<string>> bodytoEmail, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyfromEmail = null, Expression<Func<bodytaskStatusInput>> bodytaskStatus = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bodypriorityTextInput>> bodypriorityText = null, Expression<Func<string>> bodyassociatedContactEmail = null, Expression<Func<bodyresourceAppNameInput>> bodyresourceAppName = null, Expression<Func<string>> bodyresourceAppUrl = null, Expression<Func<string>> bodyresourceAppID = null, Expression<Func<string>> bodyresourceAppData = null, Expression<Func<string>> bodyreferenceId = null, Expression<Func<string>> bodyreferenceData = null, Expression<Func<string>> bodyreferenceSource = null, Expression<Func<string>> bodyprojectName = null, Expression<Func<string>> bodyprojectSectionName = null, Expression<Func<string>> bodyprojectTags = null, Expression<Func<bodychecklistsInputItem[]>> bodychecklists = null, Expression<Func<bodyfilesInputItem22[]>> bodyfiles = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodytaskID = WorkflowExpression.Compile(bodytaskID, nameof(bodytaskID), required: true);
            var __workflow_bodytoEmail = WorkflowExpression.Compile(bodytoEmail, nameof(bodytoEmail), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyfromEmail = WorkflowExpression.Compile(bodyfromEmail, nameof(bodyfromEmail), required: false);
            var __workflow_bodytaskStatus = WorkflowExpression.Compile(bodytaskStatus, nameof(bodytaskStatus), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodypriorityText = WorkflowExpression.Compile(bodypriorityText, nameof(bodypriorityText), required: false);
            var __workflow_bodyassociatedContactEmail = WorkflowExpression.Compile(bodyassociatedContactEmail, nameof(bodyassociatedContactEmail), required: false);
            var __workflow_bodyresourceAppName = WorkflowExpression.Compile(bodyresourceAppName, nameof(bodyresourceAppName), required: false);
            var __workflow_bodyresourceAppUrl = WorkflowExpression.Compile(bodyresourceAppUrl, nameof(bodyresourceAppUrl), required: false);
            var __workflow_bodyresourceAppID = WorkflowExpression.Compile(bodyresourceAppID, nameof(bodyresourceAppID), required: false);
            var __workflow_bodyresourceAppData = WorkflowExpression.Compile(bodyresourceAppData, nameof(bodyresourceAppData), required: false);
            var __workflow_bodyreferenceId = WorkflowExpression.Compile(bodyreferenceId, nameof(bodyreferenceId), required: false);
            var __workflow_bodyreferenceData = WorkflowExpression.Compile(bodyreferenceData, nameof(bodyreferenceData), required: false);
            var __workflow_bodyreferenceSource = WorkflowExpression.Compile(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            var __workflow_bodyprojectName = WorkflowExpression.Compile(bodyprojectName, nameof(bodyprojectName), required: false);
            var __workflow_bodyprojectSectionName = WorkflowExpression.Compile(bodyprojectSectionName, nameof(bodyprojectSectionName), required: false);
            var __workflow_bodyprojectTags = WorkflowExpression.Compile(bodyprojectTags, nameof(bodyprojectTags), required: false);
            var __workflow_bodychecklists = WorkflowExpression.Compile(bodychecklists, nameof(bodychecklists), required: false);
            var __workflow_bodyfiles = WorkflowExpression.Compile(bodyfiles, nameof(bodyfiles), required: false);
            return new DeferredBodyAction<UpdateTaskResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/UpdateExternalTask";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["taskID"] = ExpressionConverter.ConvertO(__workflow_bodytaskID);
                if (__workflow_bodyfromEmail != null)
                {
                    body["fromEmail"] = ExpressionConverter.ConvertO(__workflow_bodyfromEmail);
                    bodypropCount++;
                }

                bodypropCount++;
                body["toEmail"] = ExpressionConverter.ConvertO(__workflow_bodytoEmail);
                if (__workflow_bodytaskStatus != null)
                {
                    body["TaskStatus"] = ExpressionConverter.ConvertO(__workflow_bodytaskStatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityText != null)
                {
                    body["priorityText"] = ExpressionConverter.ConvertO(__workflow_bodypriorityText);
                    bodypropCount++;
                }

                if (__workflow_bodyassociatedContactEmail != null)
                {
                    body["associatedContactEmail"] = ExpressionConverter.ConvertO(__workflow_bodyassociatedContactEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceAppName != null)
                {
                    body["resourceAppName"] = ExpressionConverter.ConvertO(__workflow_bodyresourceAppName);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceAppUrl != null)
                {
                    body["resourceAppUrl"] = ExpressionConverter.ConvertO(__workflow_bodyresourceAppUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceAppID != null)
                {
                    body["resourceAppID"] = ExpressionConverter.ConvertO(__workflow_bodyresourceAppID);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceAppData != null)
                {
                    body["resourceAppData"] = ExpressionConverter.ConvertO(__workflow_bodyresourceAppData);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceId != null)
                {
                    body["referenceId"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceId);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceData != null)
                {
                    body["referenceData"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceData);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceSource != null)
                {
                    body["referenceSource"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceSource);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectName != null)
                {
                    body["projectName"] = ExpressionConverter.ConvertO(__workflow_bodyprojectName);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectSectionName != null)
                {
                    body["projectSectionName"] = ExpressionConverter.ConvertO(__workflow_bodyprojectSectionName);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectTags != null)
                {
                    body["projectTags"] = ExpressionConverter.ConvertO(__workflow_bodyprojectTags);
                    bodypropCount++;
                }

                if (__workflow_bodychecklists != null)
                {
                    body["checklists"] = ExpressionConverter.ConvertO(__workflow_bodychecklists);
                    bodypropCount++;
                }

                if (__workflow_bodyfiles != null)
                {
                    body["files"] = ExpressionConverter.ConvertO(__workflow_bodyfiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactNote(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyownerEmail, Expression<Func<string>> bodycontactEmail, Expression<Func<string>> bodynotes)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodyownerEmail = WorkflowExpression.Compile(bodyownerEmail, nameof(bodyownerEmail), required: true);
            var __workflow_bodycontactEmail = WorkflowExpression.Compile(bodycontactEmail, nameof(bodycontactEmail), required: true);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactNotes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["ownerEmail"] = ExpressionConverter.ConvertO(__workflow_bodyownerEmail);
                bodypropCount++;
                body["contactEmail"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmail);
                bodypropCount++;
                body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateCompany(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodycompanyName, Expression<Func<string>> bodyuserEmail, Expression<Func<string>> bodystreet = null, Expression<Func<string>> bodysuiteUnitNumber = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodycountryName = null, Expression<Func<string>> bodytaxId = null, Expression<Func<string>> bodysiteUrl = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: true);
            var __workflow_bodyuserEmail = WorkflowExpression.Compile(bodyuserEmail, nameof(bodyuserEmail), required: true);
            var __workflow_bodystreet = WorkflowExpression.Compile(bodystreet, nameof(bodystreet), required: false);
            var __workflow_bodysuiteUnitNumber = WorkflowExpression.Compile(bodysuiteUnitNumber, nameof(bodysuiteUnitNumber), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodycountryName = WorkflowExpression.Compile(bodycountryName, nameof(bodycountryName), required: false);
            var __workflow_bodytaxId = WorkflowExpression.Compile(bodytaxId, nameof(bodytaxId), required: false);
            var __workflow_bodysiteUrl = WorkflowExpression.Compile(bodysiteUrl, nameof(bodysiteUrl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/services/app/ExternalCompany/CreateCompanyExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["companyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                bodypropCount++;
                body["userEmail"] = ExpressionConverter.ConvertO(__workflow_bodyuserEmail);
                if (__workflow_bodystreet != null)
                {
                    body["street"] = ExpressionConverter.ConvertO(__workflow_bodystreet);
                    bodypropCount++;
                }

                if (__workflow_bodysuiteUnitNumber != null)
                {
                    body["suite_UnitNumber"] = ExpressionConverter.ConvertO(__workflow_bodysuiteUnitNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostalCode != null)
                {
                    body["postalCode"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodycountryName != null)
                {
                    body["countryName"] = ExpressionConverter.ConvertO(__workflow_bodycountryName);
                    bodypropCount++;
                }

                if (__workflow_bodytaxId != null)
                {
                    body["taxId"] = ExpressionConverter.ConvertO(__workflow_bodytaxId);
                    bodypropCount++;
                }

                if (__workflow_bodysiteUrl != null)
                {
                    body["siteUrl"] = ExpressionConverter.ConvertO(__workflow_bodysiteUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyownerEmailAddress, Expression<Func<string>> bodycontactEmailAddress1, Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodycontactEmailAddress2 = null, Expression<Func<string>> bodycontactEmailAddress3 = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodybirthDay = null, Expression<Func<int>> bodybirthMonth = null, Expression<Func<int>> bodybirthYear = null, Expression<Func<string>> bodycontactType = null, Expression<Func<string>> bodycompanyID1 = null, Expression<Func<string>> bodycompanyID2 = null, Expression<Func<string>> bodycompanyID3 = null, Expression<Func<string>> bodyaccountNumber = null, Expression<Func<string>> bodysocialSecurityNumber = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodyownerEmailAddress = WorkflowExpression.Compile(bodyownerEmailAddress, nameof(bodyownerEmailAddress), required: true);
            var __workflow_bodycontactEmailAddress1 = WorkflowExpression.Compile(bodycontactEmailAddress1, nameof(bodycontactEmailAddress1), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodycontactEmailAddress2 = WorkflowExpression.Compile(bodycontactEmailAddress2, nameof(bodycontactEmailAddress2), required: false);
            var __workflow_bodycontactEmailAddress3 = WorkflowExpression.Compile(bodycontactEmailAddress3, nameof(bodycontactEmailAddress3), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodybirthDay = WorkflowExpression.Compile(bodybirthDay, nameof(bodybirthDay), required: false);
            var __workflow_bodybirthMonth = WorkflowExpression.Compile(bodybirthMonth, nameof(bodybirthMonth), required: false);
            var __workflow_bodybirthYear = WorkflowExpression.Compile(bodybirthYear, nameof(bodybirthYear), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodycompanyID1 = WorkflowExpression.Compile(bodycompanyID1, nameof(bodycompanyID1), required: false);
            var __workflow_bodycompanyID2 = WorkflowExpression.Compile(bodycompanyID2, nameof(bodycompanyID2), required: false);
            var __workflow_bodycompanyID3 = WorkflowExpression.Compile(bodycompanyID3, nameof(bodycompanyID3), required: false);
            var __workflow_bodyaccountNumber = WorkflowExpression.Compile(bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            var __workflow_bodysocialSecurityNumber = WorkflowExpression.Compile(bodysocialSecurityNumber, nameof(bodysocialSecurityNumber), required: false);
            return new DeferredBodyAction<CreateContactResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["ownerEmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyownerEmailAddress);
                bodypropCount++;
                body["contactEmailAddress1"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmailAddress1);
                if (__workflow_bodycontactEmailAddress2 != null)
                {
                    body["contactEmailAddress2"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmailAddress2);
                    bodypropCount++;
                }

                if (__workflow_bodycontactEmailAddress3 != null)
                {
                    body["contactEmailAddress3"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmailAddress3);
                    bodypropCount++;
                }

                bodypropCount++;
                body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodybirthDay != null)
                {
                    body["birthDay"] = ExpressionConverter.ConvertO(__workflow_bodybirthDay);
                    bodypropCount++;
                }

                if (__workflow_bodybirthMonth != null)
                {
                    body["birthMonth"] = ExpressionConverter.ConvertO(__workflow_bodybirthMonth);
                    bodypropCount++;
                }

                if (__workflow_bodybirthYear != null)
                {
                    body["birthYear"] = ExpressionConverter.ConvertO(__workflow_bodybirthYear);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyID1 != null)
                {
                    body["companyID1"] = ExpressionConverter.ConvertO(__workflow_bodycompanyID1);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyID2 != null)
                {
                    body["companyID2"] = ExpressionConverter.ConvertO(__workflow_bodycompanyID2);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyID3 != null)
                {
                    body["companyID3"] = ExpressionConverter.ConvertO(__workflow_bodycompanyID3);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountNumber != null)
                {
                    body["accountNumber"] = ExpressionConverter.ConvertO(__workflow_bodyaccountNumber);
                    bodypropCount++;
                }

                if (__workflow_bodysocialSecurityNumber != null)
                {
                    body["socialSecurityNumber"] = ExpressionConverter.ConvertO(__workflow_bodysocialSecurityNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactPhone(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodycontactEmail, Expression<Func<string>> bodyuserEmail, Expression<Func<string>> bodyphone, Expression<Func<bodyphoneTypeInput>> bodyphoneType, Expression<Func<string>> bodyextension = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodycontactEmail = WorkflowExpression.Compile(bodycontactEmail, nameof(bodycontactEmail), required: true);
            var __workflow_bodyuserEmail = WorkflowExpression.Compile(bodyuserEmail, nameof(bodyuserEmail), required: true);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: true);
            var __workflow_bodyphoneType = WorkflowExpression.Compile(bodyphoneType, nameof(bodyphoneType), required: true);
            var __workflow_bodyextension = WorkflowExpression.Compile(bodyextension, nameof(bodyextension), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactPhoneExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["contactEmail"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmail);
                bodypropCount++;
                body["userEmail"] = ExpressionConverter.ConvertO(__workflow_bodyuserEmail);
                bodypropCount++;
                body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                bodypropCount++;
                body["phoneType"] = ExpressionConverter.ConvertO(__workflow_bodyphoneType);
                if (__workflow_bodyextension != null)
                {
                    body["extension"] = ExpressionConverter.ConvertO(__workflow_bodyextension);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactAddress(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodycontactEmail, Expression<Func<string>> bodyuserEmail, Expression<Func<bodyaddressTypeInput>> bodyaddressType, Expression<Func<string>> bodystreet = null, Expression<Func<string>> bodysuiteUnitNumber = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycountryName = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodycontactEmail = WorkflowExpression.Compile(bodycontactEmail, nameof(bodycontactEmail), required: true);
            var __workflow_bodyuserEmail = WorkflowExpression.Compile(bodyuserEmail, nameof(bodyuserEmail), required: true);
            var __workflow_bodyaddressType = WorkflowExpression.Compile(bodyaddressType, nameof(bodyaddressType), required: true);
            var __workflow_bodystreet = WorkflowExpression.Compile(bodystreet, nameof(bodystreet), required: false);
            var __workflow_bodysuiteUnitNumber = WorkflowExpression.Compile(bodysuiteUnitNumber, nameof(bodysuiteUnitNumber), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodyzipCode = WorkflowExpression.Compile(bodyzipCode, nameof(bodyzipCode), required: false);
            var __workflow_bodycountryName = WorkflowExpression.Compile(bodycountryName, nameof(bodycountryName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactAddressExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["contactEmail"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmail);
                bodypropCount++;
                body["userEmail"] = ExpressionConverter.ConvertO(__workflow_bodyuserEmail);
                bodypropCount++;
                body["addressType"] = ExpressionConverter.ConvertO(__workflow_bodyaddressType);
                if (__workflow_bodystreet != null)
                {
                    body["street"] = ExpressionConverter.ConvertO(__workflow_bodystreet);
                    bodypropCount++;
                }

                if (__workflow_bodysuiteUnitNumber != null)
                {
                    body["suiteUnitNumber"] = ExpressionConverter.ConvertO(__workflow_bodysuiteUnitNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyzipCode != null)
                {
                    body["zipCode"] = ExpressionConverter.ConvertO(__workflow_bodyzipCode);
                    bodypropCount++;
                }

                if (__workflow_bodycountryName != null)
                {
                    body["countryName"] = ExpressionConverter.ConvertO(__workflow_bodycountryName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactFamily(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodycontactEmail, Expression<Func<string>> bodyuserEmail, Expression<Func<string>> bodyfirstName, Expression<Func<bodyrelationshipInput>> bodyrelationship, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodybirthDate = null, Expression<Func<int>> bodybirthMonth = null, Expression<Func<int>> bodybirthYear = null, Expression<Func<string>> bodycountryName = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodycontactEmail = WorkflowExpression.Compile(bodycontactEmail, nameof(bodycontactEmail), required: true);
            var __workflow_bodyuserEmail = WorkflowExpression.Compile(bodyuserEmail, nameof(bodyuserEmail), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodyrelationship = WorkflowExpression.Compile(bodyrelationship, nameof(bodyrelationship), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodybirthDate = WorkflowExpression.Compile(bodybirthDate, nameof(bodybirthDate), required: false);
            var __workflow_bodybirthMonth = WorkflowExpression.Compile(bodybirthMonth, nameof(bodybirthMonth), required: false);
            var __workflow_bodybirthYear = WorkflowExpression.Compile(bodybirthYear, nameof(bodybirthYear), required: false);
            var __workflow_bodycountryName = WorkflowExpression.Compile(bodycountryName, nameof(bodycountryName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactFamilyExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["contactEmail"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmail);
                bodypropCount++;
                body["userEmail"] = ExpressionConverter.ConvertO(__workflow_bodyuserEmail);
                bodypropCount++;
                body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["relationship"] = ExpressionConverter.ConvertO(__workflow_bodyrelationship);
                if (__workflow_bodybirthDate != null)
                {
                    body["birthDate"] = ExpressionConverter.ConvertO(__workflow_bodybirthDate);
                    bodypropCount++;
                }

                if (__workflow_bodybirthMonth != null)
                {
                    body["birthMonth"] = ExpressionConverter.ConvertO(__workflow_bodybirthMonth);
                    bodypropCount++;
                }

                if (__workflow_bodybirthYear != null)
                {
                    body["birthYear"] = ExpressionConverter.ConvertO(__workflow_bodybirthYear);
                    bodypropCount++;
                }

                if (__workflow_bodycountryName != null)
                {
                    body["countryName"] = ExpressionConverter.ConvertO(__workflow_bodycountryName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetContactFolderDetailsResponse> GetContactFolderDetails(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail, Expression<Func<string>> contactEmail)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_userEmail = WorkflowExpression.Compile(userEmail, nameof(userEmail), required: true);
            var __workflow_contactEmail = WorkflowExpression.Compile(contactEmail, nameof(contactEmail), required: true);
            return new DeferredBodyAction<GetContactFolderDetailsResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/GetContactFolderDetailExternal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(__workflow_userEmail);
                callPayload.Queries["ContactEmail"] = ExpressionConverter.Convert(__workflow_contactEmail);
                return new ApiConnectionAction<GetContactFolderDetailsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetCompanyDetailExternalResponse> GetCompanyDetailExternal(Expression<Func<string>> apiKey, Expression<Func<matchByInput>> matchBy, Expression<Func<string>> matchValue)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_matchBy = WorkflowExpression.Compile(matchBy, nameof(matchBy), required: true);
            var __workflow_matchValue = WorkflowExpression.Compile(matchValue, nameof(matchValue), required: true);
            return new DeferredBodyAction<GetCompanyDetailExternalResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalCompany/GetCompanyDetailExternal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["MatchBy"] = ExpressionConverter.Convert(__workflow_matchBy);
                callPayload.Queries["MatchValue"] = ExpressionConverter.Convert(__workflow_matchValue);
                return new ApiConnectionAction<GetCompanyDetailExternalResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetTaskByResourceExtResponse> GetTaskByResourceExt(Expression<Func<string>> apiKey, Expression<Func<string>> resourceAppID)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_resourceAppID = WorkflowExpression.Compile(resourceAppID, nameof(resourceAppID), required: true);
            return new DeferredBodyAction<GetTaskByResourceExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetTaskByResourceExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["ResourceAppID"] = ExpressionConverter.Convert(__workflow_resourceAppID);
                return new ApiConnectionAction<GetTaskByResourceExtResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateTaskCommentExtResponse> CreateTaskCommentExt(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyuserEmail, Expression<Func<string>> bodytaskId, Expression<Func<string>> bodycomment)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodyuserEmail = WorkflowExpression.Compile(bodyuserEmail, nameof(bodyuserEmail), required: true);
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: true);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: true);
            return new DeferredBodyAction<CreateTaskCommentExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateTaskCommentExt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["userEmail"] = ExpressionConverter.ConvertO(__workflow_bodyuserEmail);
                bodypropCount++;
                body["taskId"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                bodypropCount++;
                body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTaskCommentExtResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<UpdateProjectResponse> UpdateProject(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyprojectId, Expression<Func<string>> bodyprojectName, Expression<Func<string>> bodycurrentUserEmail, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bool>> bodyisPrivate = null, Expression<Func<string>> bodyreferenceId = null, Expression<Func<string>> bodyreferenceData = null, Expression<Func<string>> bodyreferenceSource = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            var __workflow_bodyprojectName = WorkflowExpression.Compile(bodyprojectName, nameof(bodyprojectName), required: true);
            var __workflow_bodycurrentUserEmail = WorkflowExpression.Compile(bodycurrentUserEmail, nameof(bodycurrentUserEmail), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: false);
            var __workflow_bodyreferenceId = WorkflowExpression.Compile(bodyreferenceId, nameof(bodyreferenceId), required: false);
            var __workflow_bodyreferenceData = WorkflowExpression.Compile(bodyreferenceData, nameof(bodyreferenceData), required: false);
            var __workflow_bodyreferenceSource = WorkflowExpression.Compile(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            return new DeferredBodyAction<UpdateProjectResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/UpdateProjectExt";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                bodypropCount++;
                body["projectName"] = ExpressionConverter.ConvertO(__workflow_bodyprojectName);
                bodypropCount++;
                body["currentUserEmail"] = ExpressionConverter.ConvertO(__workflow_bodycurrentUserEmail);
                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    if (__workflow_bodystatus != null)
                    {
                        body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["status"] = "Active";
                    bodypropCount++;
                }

                if (__workflow_bodyisPrivate != null)
                {
                    if (__workflow_bodyisPrivate != null)
                    {
                        body["isPrivate"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["isPrivate"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceId != null)
                {
                    body["referenceId"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceId);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceData != null)
                {
                    body["referenceData"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceData);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceSource != null)
                {
                    body["referenceSource"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceSource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateProjectResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetTaskExtResponse> GetTaskExt(Expression<Func<string>> apiKey, Expression<Func<getByInput>> getBy, Expression<Func<string>> id, Expression<Func<string>> source = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_getBy = WorkflowExpression.Compile(getBy, nameof(getBy), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            return new DeferredBodyAction<GetTaskExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetTaskExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["GetBy"] = ExpressionConverter.Convert(__workflow_getBy);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_source != null)
                    callPayload.Queries["Source"] = ExpressionConverter.Convert(__workflow_source);
                return new ApiConnectionAction<GetTaskExtResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectExtResponse> GetProjectExt(Expression<Func<string>> apiKey, Expression<Func<getByInput>> getBy, Expression<Func<string>> id, Expression<Func<string>> source = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_getBy = WorkflowExpression.Compile(getBy, nameof(getBy), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            return new DeferredBodyAction<GetProjectExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["GetBy"] = ExpressionConverter.Convert(__workflow_getBy);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_source != null)
                    callPayload.Queries["Source"] = ExpressionConverter.Convert(__workflow_source);
                return new ApiConnectionAction<GetProjectExtResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectTemplatesExtResponse> GetProjectTemplatesExt(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_userEmail = WorkflowExpression.Compile(userEmail, nameof(userEmail), required: true);
            return new DeferredBodyAction<GetProjectTemplatesExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectTemplatesExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(__workflow_userEmail);
                return new ApiConnectionAction<GetProjectTemplatesExtResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectRolesExtResponse> GetProjectRolesExt(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail, Expression<Func<roleTypeInput>> roleType = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_userEmail = WorkflowExpression.Compile(userEmail, nameof(userEmail), required: true);
            var __workflow_roleType = WorkflowExpression.Compile(roleType, nameof(roleType), required: false);
            return new DeferredBodyAction<GetProjectRolesExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectRolesExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(__workflow_userEmail);
                if (__workflow_roleType != null)
                    callPayload.Queries["RoleType"] = ExpressionConverter.Convert(__workflow_roleType);
                return new ApiConnectionAction<GetProjectRolesExtResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateProjectFromTemplateExtResponse> CreateProjectFromTemplateExt(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodycreatorEmail, Expression<Func<string>> bodyprojectName, Expression<Func<bool>> bodyisPrivate, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyclientName = null, Expression<Func<bodymembersInputItem[]>> bodymembers = null, Expression<Func<bodyfilesLinksInputItem[]>> bodyfilesLinks = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodycreatorEmail = WorkflowExpression.Compile(bodycreatorEmail, nameof(bodycreatorEmail), required: true);
            var __workflow_bodyprojectName = WorkflowExpression.Compile(bodyprojectName, nameof(bodyprojectName), required: true);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyclientName = WorkflowExpression.Compile(bodyclientName, nameof(bodyclientName), required: false);
            var __workflow_bodymembers = WorkflowExpression.Compile(bodymembers, nameof(bodymembers), required: false);
            var __workflow_bodyfilesLinks = WorkflowExpression.Compile(bodyfilesLinks, nameof(bodyfilesLinks), required: false);
            return new DeferredBodyAction<CreateProjectFromTemplateExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateProjectFromTemplateExt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                bodypropCount++;
                body["creatorEmail"] = ExpressionConverter.ConvertO(__workflow_bodycreatorEmail);
                bodypropCount++;
                body["projectName"] = ExpressionConverter.ConvertO(__workflow_bodyprojectName);
                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyclientName != null)
                {
                    body["clientName"] = ExpressionConverter.ConvertO(__workflow_bodyclientName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["isPrivate"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                if (__workflow_bodymembers != null)
                {
                    body["members"] = ExpressionConverter.ConvertO(__workflow_bodymembers);
                    bodypropCount++;
                }

                if (__workflow_bodyfilesLinks != null)
                {
                    body["filesLinks"] = ExpressionConverter.ConvertO(__workflow_bodyfilesLinks);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateProjectFromTemplateExtResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<DeletetaskResponse> Deletetask(Expression<Func<string>> apiKey, Expression<Func<string>> taskID)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_taskID = WorkflowExpression.Compile(taskID, nameof(taskID), required: true);
            return new DeferredBodyAction<DeletetaskResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/DeleteExternalTask";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["TaskID"] = ExpressionConverter.Convert(__workflow_taskID);
                return new ApiConnectionAction<DeletetaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class VineforceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenTaskIsCompletedResponse> WhenTaskIsCompleted(Expression<Func<string>> apiKey, Expression<Func<int>> duration, Expression<Func<string>> projectName = null, Expression<Func<string>> projectId = null, Expression<Func<string>> assigneeEmail = null, Expression<Func<string>> creatorEmail = null, FlowRecurrence recurrence = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_duration = WorkflowExpression.Compile(duration, nameof(duration), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_assigneeEmail = WorkflowExpression.Compile(assigneeEmail, nameof(assigneeEmail), required: false);
            var __workflow_creatorEmail = WorkflowExpression.Compile(creatorEmail, nameof(creatorEmail), required: false);
            return new DeferredBodyTrigger<WhenTaskIsCompletedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentCompletedTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                if (__workflow_projectName != null)
                    callPayload.Queries["ProjectName"] = ExpressionConverter.Convert(__workflow_projectName);
                if (__workflow_projectId != null)
                    callPayload.Queries["ProjectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = ExpressionConverter.Convert(__workflow_assigneeEmail);
                if (__workflow_creatorEmail != null)
                    callPayload.Queries["CreatorEmail"] = ExpressionConverter.Convert(__workflow_creatorEmail);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(__workflow_duration);
                return new ApiConnectionTrigger<WhenTaskIsCompletedResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WhenTaskSectionIsChangedResponse> WhenTaskSectionIsChanged(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail, Expression<Func<string>> projectName = null, Expression<Func<string>> projectId = null, Expression<Func<string>> assigneeEmail = null, Expression<Func<string>> taskId = null, Expression<Func<string>> oldSectionId = null, Expression<Func<string>> oldSectoinName = null, Expression<Func<string>> newSectionId = null, Expression<Func<string>> newSectoinName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_userEmail = WorkflowExpression.Compile(userEmail, nameof(userEmail), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_assigneeEmail = WorkflowExpression.Compile(assigneeEmail, nameof(assigneeEmail), required: false);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: false);
            var __workflow_oldSectionId = WorkflowExpression.Compile(oldSectionId, nameof(oldSectionId), required: false);
            var __workflow_oldSectoinName = WorkflowExpression.Compile(oldSectoinName, nameof(oldSectoinName), required: false);
            var __workflow_newSectionId = WorkflowExpression.Compile(newSectionId, nameof(newSectionId), required: false);
            var __workflow_newSectoinName = WorkflowExpression.Compile(newSectoinName, nameof(newSectoinName), required: false);
            return new DeferredBodyTrigger<WhenTaskSectionIsChangedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentModifiedSectionTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(__workflow_userEmail);
                if (__workflow_projectName != null)
                    callPayload.Queries["ProjectName"] = ExpressionConverter.Convert(__workflow_projectName);
                if (__workflow_projectId != null)
                    callPayload.Queries["ProjectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = ExpressionConverter.Convert(__workflow_assigneeEmail);
                if (__workflow_taskId != null)
                    callPayload.Queries["TaskId"] = ExpressionConverter.Convert(__workflow_taskId);
                if (__workflow_oldSectionId != null)
                    callPayload.Queries["OldSectionId"] = ExpressionConverter.Convert(__workflow_oldSectionId);
                if (__workflow_oldSectoinName != null)
                    callPayload.Queries["OldSectoinName"] = ExpressionConverter.Convert(__workflow_oldSectoinName);
                if (__workflow_newSectionId != null)
                    callPayload.Queries["NewSectionId"] = ExpressionConverter.Convert(__workflow_newSectionId);
                if (__workflow_newSectoinName != null)
                    callPayload.Queries["NewSectoinName"] = ExpressionConverter.Convert(__workflow_newSectoinName);
                return new ApiConnectionTrigger<WhenTaskSectionIsChangedResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WhenTaskIsCreatedResponse> WhenTaskIsCreated(Expression<Func<string>> apiKey, Expression<Func<int>> duration, FlowRecurrence recurrence = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_duration = WorkflowExpression.Compile(duration, nameof(duration), required: true);
            return new DeferredBodyTrigger<WhenTaskIsCreatedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyCreatedTask";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(__workflow_duration);
                return new ApiConnectionTrigger<WhenTaskIsCreatedResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WhenTaskIsUpdatedResponse> WhenTaskIsUpdated(Expression<Func<string>> apiKey, Expression<Func<int>> duration, Expression<Func<string>> updateFilter = null, FlowRecurrence recurrence = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_duration = WorkflowExpression.Compile(duration, nameof(duration), required: true);
            var __workflow_updateFilter = WorkflowExpression.Compile(updateFilter, nameof(updateFilter), required: false);
            return new DeferredBodyTrigger<WhenTaskIsUpdatedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyUpdatedTask";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                if (__workflow_updateFilter != null)
                    callPayload.Queries["UpdateFilter"] = ExpressionConverter.Convert(__workflow_updateFilter);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(__workflow_duration);
                return new ApiConnectionTrigger<WhenTaskIsUpdatedResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WhenTaskIsDeletedResponse> WhenTaskIsDeleted(Expression<Func<string>> apiKey, Expression<Func<int>> duration, Expression<Func<string>> projectName = null, Expression<Func<string>> projectId = null, Expression<Func<string>> assigneeEmail = null, Expression<Func<string>> creatorEmail = null, FlowRecurrence recurrence = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_duration = WorkflowExpression.Compile(duration, nameof(duration), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_assigneeEmail = WorkflowExpression.Compile(assigneeEmail, nameof(assigneeEmail), required: false);
            var __workflow_creatorEmail = WorkflowExpression.Compile(creatorEmail, nameof(creatorEmail), required: false);
            return new DeferredBodyTrigger<WhenTaskIsDeletedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyDeletedTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                if (__workflow_projectName != null)
                    callPayload.Queries["ProjectName"] = ExpressionConverter.Convert(__workflow_projectName);
                if (__workflow_projectId != null)
                    callPayload.Queries["ProjectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = ExpressionConverter.Convert(__workflow_assigneeEmail);
                if (__workflow_creatorEmail != null)
                    callPayload.Queries["CreatorEmail"] = ExpressionConverter.Convert(__workflow_creatorEmail);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(__workflow_duration);
                return new ApiConnectionTrigger<WhenTaskIsDeletedResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }
    }

    public class CreateTaskResponse
    {
        [JsonProperty("result")]
        public CreateTaskResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateTaskResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("message_Info")]
        public string MessageInfo { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("taskID")]
        public string TaskID { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("longTypeEntityId")]
        public string LongTypeEntityId { get; set; }

        [JsonProperty("responseData")]
        public int ResponseData { get; set; }

        [JsonProperty("listOfEntities")]
        public string ListOfEntities { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypriorityTextInput
    {
        Normal,
        Important,
        Urgent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyresourceAppNameInput
    {
        [EnumMember(Value = "Adobe Cloud")]
        AdobeCloud,
        [EnumMember(Value = "Adobe Sign")]
        AdobeSign,
        Asana,
        [EnumMember(Value = "Azure DevOps")]
        AzureDevOps,
        Bitbucket,
        [EnumMember(Value = "Contact Manager")]
        ContactManager,
        Docusign,
        Excel,
        HelloSign,
        Hubspot,
        Jira,
        Dataverse,
        [EnumMember(Value = "Dynamics 365")]
        Dynamics365,
        Forms,
        LinkedIn,
        List,
        [EnumMember(Value = "To Do")]
        ToDo,
        OneDrive,
        OneNote,
        Outlook,
        Pdf,
        Photo,
        Planner,
        [EnumMember(Value = "Power Apps")]
        PowerApps,
        [EnumMember(Value = "Power Automate")]
        PowerAutomate,
        PowerPoint,
        Teams,
        Twitter,
        Typeform,
        Visio,
        Word,
        Zendesk
    }

    public class bodychecklistsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class bodyfilesInputItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("fileType")]
        public bodyfilesInputItemFileTypeType FileType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfilesInputItemFileTypeType
    {
        Word,
        Excel,
        PowerPoint,
        PDF,
        Photo,
        OneNote,
        Visio,
        Folder,
        Link,
        Other
    }

    public class AlertResponse
    {
        [JsonProperty("result")]
        public AlertResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class AlertResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("message_Info")]
        public string MessageInfo { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("longTypeEntityId")]
        public string LongTypeEntityId { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyresourceNameInput
    {
        [EnumMember(Value = "Adobe Cloud")]
        AdobeCloud,
        [EnumMember(Value = "Adobe Sign")]
        AdobeSign,
        Asana,
        [EnumMember(Value = "Azure DevOps")]
        AzureDevOps,
        Bitbucket,
        [EnumMember(Value = "Contact Manager")]
        ContactManager,
        Docusign,
        Excel,
        HelloSign,
        Hubspot,
        Jira,
        Dataverse,
        [EnumMember(Value = "Dynamics 365")]
        Dynamics365,
        Forms,
        LinkedIn,
        List,
        [EnumMember(Value = "To Do")]
        ToDo,
        OneDrive,
        OneNote,
        Outlook,
        Pdf,
        Photo,
        Planner,
        [EnumMember(Value = "Power Apps")]
        PowerApps,
        [EnumMember(Value = "Power Automate")]
        PowerAutomate,
        PowerPoint,
        Teams,
        Twitter,
        Typeform,
        Visio,
        Word,
        Zendesk
    }

    public class CreateProjectResponse
    {
        [JsonProperty("result")]
        public CreateProjectResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateProjectResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("projectID")]
        public string ProjectID { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class bodyfilesInputItem2
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("fileType")]
        public bodyfilesInputItemFileTypeType FileType { get; set; }

        [JsonProperty("fileItemId")]
        public string FileItemId { get; set; }

        [JsonProperty("fileDriveId")]
        public string FileDriveId { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }

    public class UpdateTaskResponse
    {
        [JsonProperty("result")]
        public UpdateTaskResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class UpdateTaskResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("message_Info")]
        public string MessageInfo { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("taskID")]
        public string TaskID { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("longTypeEntityId")]
        public string LongTypeEntityId { get; set; }

        [JsonProperty("responseData")]
        public int ResponseData { get; set; }

        [JsonProperty("listOfEntities")]
        public string ListOfEntities { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytaskStatusInput
    {
        Completed,
        Unfinished
    }

    public class bodyfilesInputItem22
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("fileType")]
        public bodyfilesInputItemFileTypeType FileType { get; set; }
    }

    public class CreateContactResponse
    {
        [JsonProperty("result")]
        public CreateContactResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateContactResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("contactId")]
        public string ContactId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyphoneTypeInput
    {
        Mobile,
        Work,
        Home,
        Fax,
        Other
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyaddressTypeInput
    {
        Home,
        Physical,
        Mailing,
        Work,
        Other
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrelationshipInput
    {
        Spouse,
        Son,
        Daughter,
        Mother,
        Father,
        Brother,
        Sister,
        GrandMother,
        GrandFather,
        GrandSon,
        GrandDaughter
    }

    public class GetContactFolderDetailsResponse
    {
        [JsonProperty("result")]
        public GetContactFolderDetailsResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class GetContactFolderDetailsResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("folderPath")]
        public string FolderPath { get; set; }

        [JsonProperty("isSharePointDrive")]
        public bool IsSharePointDrive { get; set; }
    }

    public class GetCompanyDetailExternalResponse
    {
        [JsonProperty("result")]
        public GetCompanyDetailExternalResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class GetCompanyDetailExternalResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("suiteUnitNumber")]
        public string SuiteUnitNumber { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("taxID")]
        public string TaxID { get; set; }

        [JsonProperty("folderPath")]
        public string FolderPath { get; set; }

        [JsonProperty("isSharePointDrive")]
        public bool IsSharePointDrive { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum matchByInput
    {
        [EnumMember(Value = "Account No.")]
        AccountNo,
        [EnumMember(Value = "Tax ID")]
        TaxID,
        [EnumMember(Value = "Company ID")]
        CompanyID,
        [EnumMember(Value = "Company Name")]
        CompanyName,
        URL
    }

    public class GetTaskByResourceExtResponse
    {
        [JsonProperty("result")]
        public GetTaskByResourceExtResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class GetTaskByResourceExtResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("taskID")]
        public string TaskID { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taskStatus")]
        public string TaskStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("projectSection")]
        public string ProjectSection { get; set; }

        [JsonProperty("assoContactEmail")]
        public string AssoContactEmail { get; set; }

        [JsonProperty("assoContactName")]
        public string AssoContactName { get; set; }
    }

    public class CreateTaskCommentExtResponse
    {
        [JsonProperty("result")]
        public CreateTaskCommentExtResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateTaskCommentExtResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("taskID")]
        public string TaskID { get; set; }
    }

    public class UpdateProjectResponse
    {
        [JsonProperty("result")]
        public UpdateProjectResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class UpdateProjectResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("projectID")]
        public string ProjectID { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystatusInput
    {
        Active,
        Inactive
    }

    public class GetTaskExtResponse
    {
        [JsonProperty("result")]
        public GetTaskExtResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class GetTaskExtResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("taskID")]
        public string TaskID { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taskStatus")]
        public string TaskStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("projectSection")]
        public string ProjectSection { get; set; }

        [JsonProperty("assoContactEmail")]
        public string AssoContactEmail { get; set; }

        [JsonProperty("assoContactName")]
        public string AssoContactName { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("referenceData")]
        public string ReferenceData { get; set; }

        [JsonProperty("referenceSource")]
        public string ReferenceSource { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum getByInput
    {
        [EnumMember(Value = "Trovve Id")]
        TrovveId,
        [EnumMember(Value = "Reference Id")]
        ReferenceId
    }

    public class GetProjectExtResponse
    {
        [JsonProperty("result")]
        public GetProjectExtResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class GetProjectExtResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("managerEmails")]
        public string ManagerEmails { get; set; }

        [JsonProperty("folderLocPath")]
        public string FolderLocPath { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("referenceData")]
        public string ReferenceData { get; set; }

        [JsonProperty("referenceSource")]
        public string ReferenceSource { get; set; }
    }

    public class GetProjectTemplatesExtResponse
    {
        [JsonProperty("result")]
        public GetProjectTemplatesExtResponseResultType Result { get; set; }
    }

    public class GetProjectTemplatesExtResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public GetProjectTemplatesExtResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class GetProjectTemplatesExtResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }
    }

    public class GetProjectRolesExtResponse
    {
        [JsonProperty("result")]
        public GetProjectRolesExtResponseResultType Result { get; set; }
    }

    public class GetProjectRolesExtResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public GetProjectRolesExtResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class GetProjectRolesExtResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("roleId")]
        public string RoleId { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("roleType")]
        public string RoleType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum roleTypeInput
    {
        Member,
        Manager
    }

    public class CreateProjectFromTemplateExtResponse
    {
        [JsonProperty("result")]
        public CreateProjectFromTemplateExtResponseResultType Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateProjectFromTemplateExtResponseResultType
    {
        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public CreateProjectFromTemplateExtResponseResultTypeResponseDataType ResponseData { get; set; }
    }

    public class CreateProjectFromTemplateExtResponseResultTypeResponseDataType
    {
        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }
    }

    public class bodymembersInputItem
    {
        [JsonProperty("roleId")]
        public string RoleId { get; set; }

        [JsonProperty("memberEmail")]
        public string MemberEmail { get; set; }
    }

    public class bodyfilesLinksInputItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("fileType")]
        public bodyfilesLinksInputItemFileTypeType FileType { get; set; }

        [JsonProperty("fileItemId")]
        public string FileItemId { get; set; }

        [JsonProperty("fileDriveId")]
        public string FileDriveId { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfilesLinksInputItemFileTypeType
    {
        Word,
        Excel,
        PowerPoint,
        PDF,
        Photo,
        OneNote,
        Visio,
        Folder,
        Link,
        Other
    }

    public class DeletetaskResponse
    {
        [JsonProperty("result")]
        public DeletetaskResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class DeletetaskResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("message_Info")]
        public string MessageInfo { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("longTypeEntityId")]
        public string LongTypeEntityId { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
    }

    public class WhenTaskIsCompletedResponse
    {
        [JsonProperty("result")]
        public WhenTaskIsCompletedResponseResultType Result { get; set; }
    }

    public class WhenTaskIsCompletedResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public WhenTaskIsCompletedResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class WhenTaskIsCompletedResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taskStatus")]
        public string TaskStatus { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("projectSection")]
        public string ProjectSection { get; set; }

        [JsonProperty("assoContactEmail")]
        public string AssoContactEmail { get; set; }

        [JsonProperty("assoContactName")]
        public string AssoContactName { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("lastModificationTime")]
        public string LastModificationTime { get; set; }

        [JsonProperty("isImportant")]
        public bool IsImportant { get; set; }

        [JsonProperty("externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        [JsonProperty("externalReferenceSource")]
        public string ExternalReferenceSource { get; set; }

        [JsonProperty("externalReferenceData")]
        public string ExternalReferenceData { get; set; }
    }

    public class WhenTaskSectionIsChangedResponse
    {
        [JsonProperty("result")]
        public WhenTaskSectionIsChangedResponseResultType Result { get; set; }
    }

    public class WhenTaskSectionIsChangedResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public WhenTaskSectionIsChangedResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class WhenTaskSectionIsChangedResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taskStatus")]
        public string TaskStatus { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("projectSection")]
        public string ProjectSection { get; set; }

        [JsonProperty("assoContactEmail")]
        public string AssoContactEmail { get; set; }

        [JsonProperty("assoContactName")]
        public string AssoContactName { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("lastModificationTime")]
        public string LastModificationTime { get; set; }

        [JsonProperty("isImportant")]
        public bool IsImportant { get; set; }

        [JsonProperty("externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        [JsonProperty("externalReferenceSource")]
        public string ExternalReferenceSource { get; set; }

        [JsonProperty("externalReferenceData")]
        public string ExternalReferenceData { get; set; }
    }

    public class WhenTaskIsCreatedResponse
    {
        [JsonProperty("result")]
        public WhenTaskIsCreatedResponseResultType Result { get; set; }
    }

    public class WhenTaskIsCreatedResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public WhenTaskIsCreatedResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class WhenTaskIsCreatedResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }
    }

    public class WhenTaskIsUpdatedResponse
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("errorType")]
        public int ErrorType { get; set; }

        [JsonProperty("responseData")]
        public WhenTaskIsUpdatedResponseResponseDataTypeItem[] ResponseData { get; set; }

        [JsonProperty("listOfEntities")]
        public WhenTaskIsUpdatedResponseListOfEntitiesTypeItemItem[][] ListOfEntities { get; set; }
    }

    public class WhenTaskIsUpdatedResponseResponseDataTypeItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("changes")]
        public string Changes { get; set; }

        [JsonProperty("taskChanges")]
        public WhenTaskIsUpdatedResponseResponseDataTypeItemTaskChangesTypeItem[] TaskChanges { get; set; }
    }

    public class WhenTaskIsUpdatedResponseResponseDataTypeItemTaskChangesTypeItem
    {
        [JsonProperty("changeType")]
        public string ChangeType { get; set; }

        [JsonProperty("oldValue")]
        public string OldValue { get; set; }

        [JsonProperty("newValue")]
        public string NewValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class WhenTaskIsUpdatedResponseListOfEntitiesTypeItemItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("taskChanges")]
        public WhenTaskIsUpdatedResponseListOfEntitiesTypeItemItemTaskChangesTypeItem[] TaskChanges { get; set; }
    }

    public class WhenTaskIsUpdatedResponseListOfEntitiesTypeItemItemTaskChangesTypeItem
    {
        [JsonProperty("changeType")]
        public string ChangeType { get; set; }

        [JsonProperty("oldValue")]
        public string OldValue { get; set; }

        [JsonProperty("newValue")]
        public string NewValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class WhenTaskIsDeletedResponse
    {
        [JsonProperty("result")]
        public WhenTaskIsDeletedResponseResultType Result { get; set; }
    }

    public class WhenTaskIsDeletedResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public WhenTaskIsDeletedResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class WhenTaskIsDeletedResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taskStatus")]
        public string TaskStatus { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("projectSection")]
        public string ProjectSection { get; set; }

        [JsonProperty("assoContactEmail")]
        public string AssoContactEmail { get; set; }

        [JsonProperty("assoContactName")]
        public string AssoContactName { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("lastModificationTime")]
        public string LastModificationTime { get; set; }

        [JsonProperty("isImportant")]
        public bool IsImportant { get; set; }

        [JsonProperty("externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        [JsonProperty("externalReferenceSource")]
        public string ExternalReferenceSource { get; set; }

        [JsonProperty("externalReferenceData")]
        public string ExternalReferenceData { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Vineforce;

    public partial class WorkflowManagedActions
    {
        public VineforceActions Vineforce(string connectionId) => new VineforceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VineforceTriggers Vineforce(string connectionId) => new VineforceTriggers(connectionId);
    }
}
