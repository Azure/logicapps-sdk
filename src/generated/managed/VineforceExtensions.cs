//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vineforce
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VineforceActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyfromEmail = null, [WorkflowExpression] Func<string> bodytoEmail = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodypriorityTextInput> bodypriorityText = null, [WorkflowExpression] Func<string> bodyassociatedContactEmail = null, [WorkflowExpression] Func<bodyresourceAppNameInput> bodyresourceAppName = null, [WorkflowExpression] Func<string> bodyresourceAppUrl = null, [WorkflowExpression] Func<string> bodyresourceAppID = null, [WorkflowExpression] Func<string> bodyresourceAppData = null, [WorkflowExpression] Func<string> bodyreferenceId = null, [WorkflowExpression] Func<string> bodyreferenceData = null, [WorkflowExpression] Func<string> bodyreferenceSource = null, [WorkflowExpression] Func<string> bodyprojectName = null, [WorkflowExpression] Func<string> bodyprojectSectionName = null, [WorkflowExpression] Func<string> bodyprojectTags = null, [WorkflowExpression] Func<bodychecklistsInputItem[]> bodychecklists = null, [WorkflowExpression] Func<bodyfilesInputItem[]> bodyfiles = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTaskResponse> __BuildCreateTask(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodyfromEmail = null, WorkflowExpression<string> bodytoEmail = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<bodypriorityTextInput> bodypriorityText = null, WorkflowExpression<string> bodyassociatedContactEmail = null, WorkflowExpression<bodyresourceAppNameInput> bodyresourceAppName = null, WorkflowExpression<string> bodyresourceAppUrl = null, WorkflowExpression<string> bodyresourceAppID = null, WorkflowExpression<string> bodyresourceAppData = null, WorkflowExpression<string> bodyreferenceId = null, WorkflowExpression<string> bodyreferenceData = null, WorkflowExpression<string> bodyreferenceSource = null, WorkflowExpression<string> bodyprojectName = null, WorkflowExpression<string> bodyprojectSectionName = null, WorkflowExpression<string> bodyprojectTags = null, WorkflowExpression<bodychecklistsInputItem[]> bodychecklists = null, WorkflowExpression<bodyfilesInputItem[]> bodyfiles = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodyfromEmail, nameof(bodyfromEmail), required: false);
            WorkflowExpression.Validate(bodytoEmail, nameof(bodytoEmail), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodypriorityText, nameof(bodypriorityText), required: false);
            WorkflowExpression.Validate(bodyassociatedContactEmail, nameof(bodyassociatedContactEmail), required: false);
            WorkflowExpression.Validate(bodyresourceAppName, nameof(bodyresourceAppName), required: false);
            WorkflowExpression.Validate(bodyresourceAppUrl, nameof(bodyresourceAppUrl), required: false);
            WorkflowExpression.Validate(bodyresourceAppID, nameof(bodyresourceAppID), required: false);
            WorkflowExpression.Validate(bodyresourceAppData, nameof(bodyresourceAppData), required: false);
            WorkflowExpression.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            WorkflowExpression.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            WorkflowExpression.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            WorkflowExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: false);
            WorkflowExpression.Validate(bodyprojectSectionName, nameof(bodyprojectSectionName), required: false);
            WorkflowExpression.Validate(bodyprojectTags, nameof(bodyprojectTags), required: false);
            WorkflowExpression.Validate(bodychecklists, nameof(bodychecklists), required: false);
            WorkflowExpression.Validate(bodyfiles, nameof(bodyfiles), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateExternalTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                if (bodyfromEmail != null)
                {
                    body["fromEmail"] = ExpressionConverter.ConvertO(bodyfromEmail);
                    bodypropCount++;
                }

                if (bodytoEmail != null)
                {
                    body["toEmail"] = ExpressionConverter.ConvertO(bodytoEmail);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodypriorityText != null)
                {
                    body["priorityText"] = ExpressionConverter.ConvertO(bodypriorityText);
                    bodypropCount++;
                }

                if (bodyassociatedContactEmail != null)
                {
                    body["associatedContactEmail"] = ExpressionConverter.ConvertO(bodyassociatedContactEmail);
                    bodypropCount++;
                }

                if (bodyresourceAppName != null)
                {
                    body["resourceAppName"] = ExpressionConverter.ConvertO(bodyresourceAppName);
                    bodypropCount++;
                }

                if (bodyresourceAppUrl != null)
                {
                    body["resourceAppUrl"] = ExpressionConverter.ConvertO(bodyresourceAppUrl);
                    bodypropCount++;
                }

                if (bodyresourceAppID != null)
                {
                    body["resourceAppID"] = ExpressionConverter.ConvertO(bodyresourceAppID);
                    bodypropCount++;
                }

                if (bodyresourceAppData != null)
                {
                    body["resourceAppData"] = ExpressionConverter.ConvertO(bodyresourceAppData);
                    bodypropCount++;
                }

                if (bodyreferenceId != null)
                {
                    body["referenceId"] = ExpressionConverter.ConvertO(bodyreferenceId);
                    bodypropCount++;
                }

                if (bodyreferenceData != null)
                {
                    body["referenceData"] = ExpressionConverter.ConvertO(bodyreferenceData);
                    bodypropCount++;
                }

                if (bodyreferenceSource != null)
                {
                    body["referenceSource"] = ExpressionConverter.ConvertO(bodyreferenceSource);
                    bodypropCount++;
                }

                if (bodyprojectName != null)
                {
                    body["projectName"] = ExpressionConverter.ConvertO(bodyprojectName);
                    bodypropCount++;
                }

                if (bodyprojectSectionName != null)
                {
                    body["projectSectionName"] = ExpressionConverter.ConvertO(bodyprojectSectionName);
                    bodypropCount++;
                }

                if (bodyprojectTags != null)
                {
                    body["projectTags"] = ExpressionConverter.ConvertO(bodyprojectTags);
                    bodypropCount++;
                }

                if (bodychecklists != null)
                {
                    body["checklists"] = ExpressionConverter.ConvertO(bodychecklists);
                    bodypropCount++;
                }

                if (bodyfiles != null)
                {
                    body["files"] = ExpressionConverter.ConvertO(bodyfiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildAlert))]
        public IBodyWorkflowAction<AlertResponse> Alert([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyalertToEmail, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<bodyresourceNameInput> bodyresourceName = null, [WorkflowExpression] Func<string> bodyresourceUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AlertResponse> __BuildAlert(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodyalertToEmail, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodymessage, WorkflowExpression<bodyresourceNameInput> bodyresourceName = null, WorkflowExpression<string> bodyresourceUrl = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodyalertToEmail, nameof(bodyalertToEmail), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodyresourceName, nameof(bodyresourceName), required: false);
            WorkflowExpression.Validate(bodyresourceUrl, nameof(bodyresourceUrl), required: false);
            return new DeferredBodyAction<AlertResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/PushNotificationFromExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["alertToEmail"] = ExpressionConverter.ConvertO(bodyalertToEmail);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                if (bodyresourceName != null)
                {
                    body["resourceName"] = ExpressionConverter.ConvertO(bodyresourceName);
                    bodypropCount++;
                }

                if (bodyresourceUrl != null)
                {
                    body["ResourceUrl"] = ExpressionConverter.ConvertO(bodyresourceUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AlertResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateProject))]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject([WorkflowExpression] Func<string> bodyprojectName, [WorkflowExpression] Func<string> bodycreatorEmail, [WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<bodyfilesInputItem2[]> bodyfiles, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bool> bodyisPrivate = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodymembers = null, [WorkflowExpression] Func<string> bodysections = null, [WorkflowExpression] Func<string> bodyreferenceId = null, [WorkflowExpression] Func<string> bodyreferenceData = null, [WorkflowExpression] Func<string> bodyreferenceSource = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateProjectResponse> __BuildCreateProject(WorkflowExpression<string> bodyprojectName, WorkflowExpression<string> bodycreatorEmail, WorkflowExpression<string> bodyapiKey, WorkflowExpression<bodyfilesInputItem2[]> bodyfiles, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<bool> bodyisPrivate = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodymembers = null, WorkflowExpression<string> bodysections = null, WorkflowExpression<string> bodyreferenceId = null, WorkflowExpression<string> bodyreferenceData = null, WorkflowExpression<string> bodyreferenceSource = null)
        {
            WorkflowExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: true);
            WorkflowExpression.Validate(bodycreatorEmail, nameof(bodycreatorEmail), required: true);
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodyfiles, nameof(bodyfiles), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodymembers, nameof(bodymembers), required: false);
            WorkflowExpression.Validate(bodysections, nameof(bodysections), required: false);
            WorkflowExpression.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            WorkflowExpression.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            WorkflowExpression.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            return new DeferredBodyAction<CreateProjectResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateExternalProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["projectName"] = ExpressionConverter.ConvertO(bodyprojectName);
                bodypropCount++;
                body["creatorEmail"] = ExpressionConverter.ConvertO(bodycreatorEmail);
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                if (bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    if (bodyisPrivate != null)
                    {
                        body["isPrivate"] = ExpressionConverter.ConvertO(bodyisPrivate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["isPrivate"] = false;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodymembers != null)
                {
                    body["members"] = ExpressionConverter.ConvertO(bodymembers);
                    bodypropCount++;
                }

                if (bodysections != null)
                {
                    body["sections"] = ExpressionConverter.ConvertO(bodysections);
                    bodypropCount++;
                }

                bodypropCount++;
                body["files"] = ExpressionConverter.ConvertO(bodyfiles);
                if (bodyreferenceId != null)
                {
                    body["referenceId"] = ExpressionConverter.ConvertO(bodyreferenceId);
                    bodypropCount++;
                }

                if (bodyreferenceData != null)
                {
                    body["referenceData"] = ExpressionConverter.ConvertO(bodyreferenceData);
                    bodypropCount++;
                }

                if (bodyreferenceSource != null)
                {
                    body["referenceSource"] = ExpressionConverter.ConvertO(bodyreferenceSource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTask))]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodytaskID, [WorkflowExpression] Func<string> bodytoEmail, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyfromEmail = null, [WorkflowExpression] Func<bodytaskStatusInput> bodytaskStatus = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodypriorityTextInput> bodypriorityText = null, [WorkflowExpression] Func<string> bodyassociatedContactEmail = null, [WorkflowExpression] Func<bodyresourceAppNameInput> bodyresourceAppName = null, [WorkflowExpression] Func<string> bodyresourceAppUrl = null, [WorkflowExpression] Func<string> bodyresourceAppID = null, [WorkflowExpression] Func<string> bodyresourceAppData = null, [WorkflowExpression] Func<string> bodyreferenceId = null, [WorkflowExpression] Func<string> bodyreferenceData = null, [WorkflowExpression] Func<string> bodyreferenceSource = null, [WorkflowExpression] Func<string> bodyprojectName = null, [WorkflowExpression] Func<string> bodyprojectSectionName = null, [WorkflowExpression] Func<string> bodyprojectTags = null, [WorkflowExpression] Func<bodychecklistsInputItem[]> bodychecklists = null, [WorkflowExpression] Func<bodyfilesInputItem22[]> bodyfiles = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateTaskResponse> __BuildUpdateTask(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodytaskID, WorkflowExpression<string> bodytoEmail, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodyfromEmail = null, WorkflowExpression<bodytaskStatusInput> bodytaskStatus = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<bodypriorityTextInput> bodypriorityText = null, WorkflowExpression<string> bodyassociatedContactEmail = null, WorkflowExpression<bodyresourceAppNameInput> bodyresourceAppName = null, WorkflowExpression<string> bodyresourceAppUrl = null, WorkflowExpression<string> bodyresourceAppID = null, WorkflowExpression<string> bodyresourceAppData = null, WorkflowExpression<string> bodyreferenceId = null, WorkflowExpression<string> bodyreferenceData = null, WorkflowExpression<string> bodyreferenceSource = null, WorkflowExpression<string> bodyprojectName = null, WorkflowExpression<string> bodyprojectSectionName = null, WorkflowExpression<string> bodyprojectTags = null, WorkflowExpression<bodychecklistsInputItem[]> bodychecklists = null, WorkflowExpression<bodyfilesInputItem22[]> bodyfiles = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodytaskID, nameof(bodytaskID), required: true);
            WorkflowExpression.Validate(bodytoEmail, nameof(bodytoEmail), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodyfromEmail, nameof(bodyfromEmail), required: false);
            WorkflowExpression.Validate(bodytaskStatus, nameof(bodytaskStatus), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodypriorityText, nameof(bodypriorityText), required: false);
            WorkflowExpression.Validate(bodyassociatedContactEmail, nameof(bodyassociatedContactEmail), required: false);
            WorkflowExpression.Validate(bodyresourceAppName, nameof(bodyresourceAppName), required: false);
            WorkflowExpression.Validate(bodyresourceAppUrl, nameof(bodyresourceAppUrl), required: false);
            WorkflowExpression.Validate(bodyresourceAppID, nameof(bodyresourceAppID), required: false);
            WorkflowExpression.Validate(bodyresourceAppData, nameof(bodyresourceAppData), required: false);
            WorkflowExpression.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            WorkflowExpression.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            WorkflowExpression.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            WorkflowExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: false);
            WorkflowExpression.Validate(bodyprojectSectionName, nameof(bodyprojectSectionName), required: false);
            WorkflowExpression.Validate(bodyprojectTags, nameof(bodyprojectTags), required: false);
            WorkflowExpression.Validate(bodychecklists, nameof(bodychecklists), required: false);
            WorkflowExpression.Validate(bodyfiles, nameof(bodyfiles), required: false);
            return new DeferredBodyAction<UpdateTaskResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/UpdateExternalTask";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["taskID"] = ExpressionConverter.ConvertO(bodytaskID);
                if (bodyfromEmail != null)
                {
                    body["fromEmail"] = ExpressionConverter.ConvertO(bodyfromEmail);
                    bodypropCount++;
                }

                bodypropCount++;
                body["toEmail"] = ExpressionConverter.ConvertO(bodytoEmail);
                if (bodytaskStatus != null)
                {
                    body["TaskStatus"] = ExpressionConverter.ConvertO(bodytaskStatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodypriorityText != null)
                {
                    body["priorityText"] = ExpressionConverter.ConvertO(bodypriorityText);
                    bodypropCount++;
                }

                if (bodyassociatedContactEmail != null)
                {
                    body["associatedContactEmail"] = ExpressionConverter.ConvertO(bodyassociatedContactEmail);
                    bodypropCount++;
                }

                if (bodyresourceAppName != null)
                {
                    body["resourceAppName"] = ExpressionConverter.ConvertO(bodyresourceAppName);
                    bodypropCount++;
                }

                if (bodyresourceAppUrl != null)
                {
                    body["resourceAppUrl"] = ExpressionConverter.ConvertO(bodyresourceAppUrl);
                    bodypropCount++;
                }

                if (bodyresourceAppID != null)
                {
                    body["resourceAppID"] = ExpressionConverter.ConvertO(bodyresourceAppID);
                    bodypropCount++;
                }

                if (bodyresourceAppData != null)
                {
                    body["resourceAppData"] = ExpressionConverter.ConvertO(bodyresourceAppData);
                    bodypropCount++;
                }

                if (bodyreferenceId != null)
                {
                    body["referenceId"] = ExpressionConverter.ConvertO(bodyreferenceId);
                    bodypropCount++;
                }

                if (bodyreferenceData != null)
                {
                    body["referenceData"] = ExpressionConverter.ConvertO(bodyreferenceData);
                    bodypropCount++;
                }

                if (bodyreferenceSource != null)
                {
                    body["referenceSource"] = ExpressionConverter.ConvertO(bodyreferenceSource);
                    bodypropCount++;
                }

                if (bodyprojectName != null)
                {
                    body["projectName"] = ExpressionConverter.ConvertO(bodyprojectName);
                    bodypropCount++;
                }

                if (bodyprojectSectionName != null)
                {
                    body["projectSectionName"] = ExpressionConverter.ConvertO(bodyprojectSectionName);
                    bodypropCount++;
                }

                if (bodyprojectTags != null)
                {
                    body["projectTags"] = ExpressionConverter.ConvertO(bodyprojectTags);
                    bodypropCount++;
                }

                if (bodychecklists != null)
                {
                    body["checklists"] = ExpressionConverter.ConvertO(bodychecklists);
                    bodypropCount++;
                }

                if (bodyfiles != null)
                {
                    body["files"] = ExpressionConverter.ConvertO(bodyfiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContactNote))]
        public IWorkflowAction CreateContactNote([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyownerEmail, [WorkflowExpression] Func<string> bodycontactEmail, [WorkflowExpression] Func<string> bodynotes)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateContactNote(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodyownerEmail, WorkflowExpression<string> bodycontactEmail, WorkflowExpression<string> bodynotes)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodyownerEmail, nameof(bodyownerEmail), required: true);
            WorkflowExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            WorkflowExpression.Validate(bodynotes, nameof(bodynotes), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactNotes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["ownerEmail"] = ExpressionConverter.ConvertO(bodyownerEmail);
                bodypropCount++;
                body["contactEmail"] = ExpressionConverter.ConvertO(bodycontactEmail);
                bodypropCount++;
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCompany))]
        public IWorkflowAction CreateCompany([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodycompanyName, [WorkflowExpression] Func<string> bodyuserEmail, [WorkflowExpression] Func<string> bodystreet = null, [WorkflowExpression] Func<string> bodysuiteUnitNumber = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<string> bodycountryName = null, [WorkflowExpression] Func<string> bodytaxId = null, [WorkflowExpression] Func<string> bodysiteUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateCompany(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodycompanyName, WorkflowExpression<string> bodyuserEmail, WorkflowExpression<string> bodystreet = null, WorkflowExpression<string> bodysuiteUnitNumber = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodypostalCode = null, WorkflowExpression<string> bodycountryName = null, WorkflowExpression<string> bodytaxId = null, WorkflowExpression<string> bodysiteUrl = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: true);
            WorkflowExpression.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            WorkflowExpression.Validate(bodystreet, nameof(bodystreet), required: false);
            WorkflowExpression.Validate(bodysuiteUnitNumber, nameof(bodysuiteUnitNumber), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowExpression.Validate(bodycountryName, nameof(bodycountryName), required: false);
            WorkflowExpression.Validate(bodytaxId, nameof(bodytaxId), required: false);
            WorkflowExpression.Validate(bodysiteUrl, nameof(bodysiteUrl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/services/app/ExternalCompany/CreateCompanyExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["companyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
                body["userEmail"] = ExpressionConverter.ConvertO(bodyuserEmail);
                if (bodystreet != null)
                {
                    body["street"] = ExpressionConverter.ConvertO(bodystreet);
                    bodypropCount++;
                }

                if (bodysuiteUnitNumber != null)
                {
                    body["suite_UnitNumber"] = ExpressionConverter.ConvertO(bodysuiteUnitNumber);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postalCode"] = ExpressionConverter.ConvertO(bodypostalCode);
                    bodypropCount++;
                }

                if (bodycountryName != null)
                {
                    body["countryName"] = ExpressionConverter.ConvertO(bodycountryName);
                    bodypropCount++;
                }

                if (bodytaxId != null)
                {
                    body["taxId"] = ExpressionConverter.ConvertO(bodytaxId);
                    bodypropCount++;
                }

                if (bodysiteUrl != null)
                {
                    body["siteUrl"] = ExpressionConverter.ConvertO(bodysiteUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContact))]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyownerEmailAddress, [WorkflowExpression] Func<string> bodycontactEmailAddress1, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodycontactEmailAddress2 = null, [WorkflowExpression] Func<string> bodycontactEmailAddress3 = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodybirthDay = null, [WorkflowExpression] Func<int> bodybirthMonth = null, [WorkflowExpression] Func<int> bodybirthYear = null, [WorkflowExpression] Func<string> bodycontactType = null, [WorkflowExpression] Func<string> bodycompanyID1 = null, [WorkflowExpression] Func<string> bodycompanyID2 = null, [WorkflowExpression] Func<string> bodycompanyID3 = null, [WorkflowExpression] Func<string> bodyaccountNumber = null, [WorkflowExpression] Func<string> bodysocialSecurityNumber = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateContactResponse> __BuildCreateContact(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodyownerEmailAddress, WorkflowExpression<string> bodycontactEmailAddress1, WorkflowExpression<string> bodyfirstName, WorkflowExpression<string> bodycontactEmailAddress2 = null, WorkflowExpression<string> bodycontactEmailAddress3 = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodybirthDay = null, WorkflowExpression<int> bodybirthMonth = null, WorkflowExpression<int> bodybirthYear = null, WorkflowExpression<string> bodycontactType = null, WorkflowExpression<string> bodycompanyID1 = null, WorkflowExpression<string> bodycompanyID2 = null, WorkflowExpression<string> bodycompanyID3 = null, WorkflowExpression<string> bodyaccountNumber = null, WorkflowExpression<string> bodysocialSecurityNumber = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodyownerEmailAddress, nameof(bodyownerEmailAddress), required: true);
            WorkflowExpression.Validate(bodycontactEmailAddress1, nameof(bodycontactEmailAddress1), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            WorkflowExpression.Validate(bodycontactEmailAddress2, nameof(bodycontactEmailAddress2), required: false);
            WorkflowExpression.Validate(bodycontactEmailAddress3, nameof(bodycontactEmailAddress3), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodybirthDay, nameof(bodybirthDay), required: false);
            WorkflowExpression.Validate(bodybirthMonth, nameof(bodybirthMonth), required: false);
            WorkflowExpression.Validate(bodybirthYear, nameof(bodybirthYear), required: false);
            WorkflowExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            WorkflowExpression.Validate(bodycompanyID1, nameof(bodycompanyID1), required: false);
            WorkflowExpression.Validate(bodycompanyID2, nameof(bodycompanyID2), required: false);
            WorkflowExpression.Validate(bodycompanyID3, nameof(bodycompanyID3), required: false);
            WorkflowExpression.Validate(bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            WorkflowExpression.Validate(bodysocialSecurityNumber, nameof(bodysocialSecurityNumber), required: false);
            return new DeferredBodyAction<CreateContactResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["ownerEmailAddress"] = ExpressionConverter.ConvertO(bodyownerEmailAddress);
                bodypropCount++;
                body["contactEmailAddress1"] = ExpressionConverter.ConvertO(bodycontactEmailAddress1);
                if (bodycontactEmailAddress2 != null)
                {
                    body["contactEmailAddress2"] = ExpressionConverter.ConvertO(bodycontactEmailAddress2);
                    bodypropCount++;
                }

                if (bodycontactEmailAddress3 != null)
                {
                    body["contactEmailAddress3"] = ExpressionConverter.ConvertO(bodycontactEmailAddress3);
                    bodypropCount++;
                }

                bodypropCount++;
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                if (bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodybirthDay != null)
                {
                    body["birthDay"] = ExpressionConverter.ConvertO(bodybirthDay);
                    bodypropCount++;
                }

                if (bodybirthMonth != null)
                {
                    body["birthMonth"] = ExpressionConverter.ConvertO(bodybirthMonth);
                    bodypropCount++;
                }

                if (bodybirthYear != null)
                {
                    body["birthYear"] = ExpressionConverter.ConvertO(bodybirthYear);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(bodycontactType);
                    bodypropCount++;
                }

                if (bodycompanyID1 != null)
                {
                    body["companyID1"] = ExpressionConverter.ConvertO(bodycompanyID1);
                    bodypropCount++;
                }

                if (bodycompanyID2 != null)
                {
                    body["companyID2"] = ExpressionConverter.ConvertO(bodycompanyID2);
                    bodypropCount++;
                }

                if (bodycompanyID3 != null)
                {
                    body["companyID3"] = ExpressionConverter.ConvertO(bodycompanyID3);
                    bodypropCount++;
                }

                if (bodyaccountNumber != null)
                {
                    body["accountNumber"] = ExpressionConverter.ConvertO(bodyaccountNumber);
                    bodypropCount++;
                }

                if (bodysocialSecurityNumber != null)
                {
                    body["socialSecurityNumber"] = ExpressionConverter.ConvertO(bodysocialSecurityNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContactPhone))]
        public IWorkflowAction CreateContactPhone([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodycontactEmail, [WorkflowExpression] Func<string> bodyuserEmail, [WorkflowExpression] Func<string> bodyphone, [WorkflowExpression] Func<bodyphoneTypeInput> bodyphoneType, [WorkflowExpression] Func<string> bodyextension = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateContactPhone(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodycontactEmail, WorkflowExpression<string> bodyuserEmail, WorkflowExpression<string> bodyphone, WorkflowExpression<bodyphoneTypeInput> bodyphoneType, WorkflowExpression<string> bodyextension = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            WorkflowExpression.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: true);
            WorkflowExpression.Validate(bodyphoneType, nameof(bodyphoneType), required: true);
            WorkflowExpression.Validate(bodyextension, nameof(bodyextension), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactPhoneExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["contactEmail"] = ExpressionConverter.ConvertO(bodycontactEmail);
                bodypropCount++;
                body["userEmail"] = ExpressionConverter.ConvertO(bodyuserEmail);
                bodypropCount++;
                body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                bodypropCount++;
                body["phoneType"] = ExpressionConverter.ConvertO(bodyphoneType);
                if (bodyextension != null)
                {
                    body["extension"] = ExpressionConverter.ConvertO(bodyextension);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContactAddress))]
        public IWorkflowAction CreateContactAddress([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodycontactEmail, [WorkflowExpression] Func<string> bodyuserEmail, [WorkflowExpression] Func<bodyaddressTypeInput> bodyaddressType, [WorkflowExpression] Func<string> bodystreet = null, [WorkflowExpression] Func<string> bodysuiteUnitNumber = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountryName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateContactAddress(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodycontactEmail, WorkflowExpression<string> bodyuserEmail, WorkflowExpression<bodyaddressTypeInput> bodyaddressType, WorkflowExpression<string> bodystreet = null, WorkflowExpression<string> bodysuiteUnitNumber = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodyzipCode = null, WorkflowExpression<string> bodycountryName = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            WorkflowExpression.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            WorkflowExpression.Validate(bodyaddressType, nameof(bodyaddressType), required: true);
            WorkflowExpression.Validate(bodystreet, nameof(bodystreet), required: false);
            WorkflowExpression.Validate(bodysuiteUnitNumber, nameof(bodysuiteUnitNumber), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodycountryName, nameof(bodycountryName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactAddressExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["contactEmail"] = ExpressionConverter.ConvertO(bodycontactEmail);
                bodypropCount++;
                body["userEmail"] = ExpressionConverter.ConvertO(bodyuserEmail);
                bodypropCount++;
                body["addressType"] = ExpressionConverter.ConvertO(bodyaddressType);
                if (bodystreet != null)
                {
                    body["street"] = ExpressionConverter.ConvertO(bodystreet);
                    bodypropCount++;
                }

                if (bodysuiteUnitNumber != null)
                {
                    body["suiteUnitNumber"] = ExpressionConverter.ConvertO(bodysuiteUnitNumber);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zipCode"] = ExpressionConverter.ConvertO(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountryName != null)
                {
                    body["countryName"] = ExpressionConverter.ConvertO(bodycountryName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContactFamily))]
        public IWorkflowAction CreateContactFamily([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodycontactEmail, [WorkflowExpression] Func<string> bodyuserEmail, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<bodyrelationshipInput> bodyrelationship, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodybirthDate = null, [WorkflowExpression] Func<int> bodybirthMonth = null, [WorkflowExpression] Func<int> bodybirthYear = null, [WorkflowExpression] Func<string> bodycountryName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateContactFamily(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodycontactEmail, WorkflowExpression<string> bodyuserEmail, WorkflowExpression<string> bodyfirstName, WorkflowExpression<bodyrelationshipInput> bodyrelationship, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodybirthDate = null, WorkflowExpression<int> bodybirthMonth = null, WorkflowExpression<int> bodybirthYear = null, WorkflowExpression<string> bodycountryName = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            WorkflowExpression.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            WorkflowExpression.Validate(bodyrelationship, nameof(bodyrelationship), required: true);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodybirthDate, nameof(bodybirthDate), required: false);
            WorkflowExpression.Validate(bodybirthMonth, nameof(bodybirthMonth), required: false);
            WorkflowExpression.Validate(bodybirthYear, nameof(bodybirthYear), required: false);
            WorkflowExpression.Validate(bodycountryName, nameof(bodycountryName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactFamilyExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["contactEmail"] = ExpressionConverter.ConvertO(bodycontactEmail);
                bodypropCount++;
                body["userEmail"] = ExpressionConverter.ConvertO(bodyuserEmail);
                bodypropCount++;
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                if (bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["relationship"] = ExpressionConverter.ConvertO(bodyrelationship);
                if (bodybirthDate != null)
                {
                    body["birthDate"] = ExpressionConverter.ConvertO(bodybirthDate);
                    bodypropCount++;
                }

                if (bodybirthMonth != null)
                {
                    body["birthMonth"] = ExpressionConverter.ConvertO(bodybirthMonth);
                    bodypropCount++;
                }

                if (bodybirthYear != null)
                {
                    body["birthYear"] = ExpressionConverter.ConvertO(bodybirthYear);
                    bodypropCount++;
                }

                if (bodycountryName != null)
                {
                    body["countryName"] = ExpressionConverter.ConvertO(bodycountryName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetContactFolderDetails))]
        public IBodyWorkflowAction<GetContactFolderDetailsResponse> GetContactFolderDetails([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> userEmail, [WorkflowExpression] Func<string> contactEmail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetContactFolderDetailsResponse> __BuildGetContactFolderDetails(WorkflowExpression<string> apiKey, WorkflowExpression<string> userEmail, WorkflowExpression<string> contactEmail)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(userEmail, nameof(userEmail), required: true);
            WorkflowExpression.Validate(contactEmail, nameof(contactEmail), required: true);
            return new DeferredBodyAction<GetContactFolderDetailsResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/GetContactFolderDetailExternal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(userEmail);
                callPayload.Queries["ContactEmail"] = ExpressionConverter.Convert(contactEmail);
                return new ApiConnectionAction<GetContactFolderDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompanyDetailExternal))]
        public IBodyWorkflowAction<GetCompanyDetailExternalResponse> GetCompanyDetailExternal([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<matchByInput> matchBy, [WorkflowExpression] Func<string> matchValue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCompanyDetailExternalResponse> __BuildGetCompanyDetailExternal(WorkflowExpression<string> apiKey, WorkflowExpression<matchByInput> matchBy, WorkflowExpression<string> matchValue)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(matchBy, nameof(matchBy), required: true);
            WorkflowExpression.Validate(matchValue, nameof(matchValue), required: true);
            return new DeferredBodyAction<GetCompanyDetailExternalResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalCompany/GetCompanyDetailExternal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["MatchBy"] = ExpressionConverter.Convert(matchBy);
                callPayload.Queries["MatchValue"] = ExpressionConverter.Convert(matchValue);
                return new ApiConnectionAction<GetCompanyDetailExternalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetTaskByResourceExt))]
        public IBodyWorkflowAction<GetTaskByResourceExtResponse> GetTaskByResourceExt([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> resourceAppID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskByResourceExtResponse> __BuildGetTaskByResourceExt(WorkflowExpression<string> apiKey, WorkflowExpression<string> resourceAppID)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(resourceAppID, nameof(resourceAppID), required: true);
            return new DeferredBodyAction<GetTaskByResourceExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetTaskByResourceExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["ResourceAppID"] = ExpressionConverter.Convert(resourceAppID);
                return new ApiConnectionAction<GetTaskByResourceExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTaskCommentExt))]
        public IBodyWorkflowAction<CreateTaskCommentExtResponse> CreateTaskCommentExt([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyuserEmail, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodycomment)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTaskCommentExtResponse> __BuildCreateTaskCommentExt(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodyuserEmail, WorkflowExpression<string> bodytaskId, WorkflowExpression<string> bodycomment)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            WorkflowExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            return new DeferredBodyAction<CreateTaskCommentExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateTaskCommentExt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["userEmail"] = ExpressionConverter.ConvertO(bodyuserEmail);
                bodypropCount++;
                body["taskId"] = ExpressionConverter.ConvertO(bodytaskId);
                bodypropCount++;
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTaskCommentExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateProject))]
        public IBodyWorkflowAction<UpdateProjectResponse> UpdateProject([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodyprojectName, [WorkflowExpression] Func<string> bodycurrentUserEmail, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<bool> bodyisPrivate = null, [WorkflowExpression] Func<string> bodyreferenceId = null, [WorkflowExpression] Func<string> bodyreferenceData = null, [WorkflowExpression] Func<string> bodyreferenceSource = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateProjectResponse> __BuildUpdateProject(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodyprojectId, WorkflowExpression<string> bodyprojectName, WorkflowExpression<string> bodycurrentUserEmail, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<bool> bodyisPrivate = null, WorkflowExpression<string> bodyreferenceId = null, WorkflowExpression<string> bodyreferenceData = null, WorkflowExpression<string> bodyreferenceSource = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            WorkflowExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: true);
            WorkflowExpression.Validate(bodycurrentUserEmail, nameof(bodycurrentUserEmail), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            WorkflowExpression.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            WorkflowExpression.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            WorkflowExpression.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            return new DeferredBodyAction<UpdateProjectResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/UpdateProjectExt";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
                body["projectName"] = ExpressionConverter.ConvertO(bodyprojectName);
                bodypropCount++;
                body["currentUserEmail"] = ExpressionConverter.ConvertO(bodycurrentUserEmail);
                if (bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    if (bodystatus != null)
                    {
                        body["status"] = ExpressionConverter.ConvertO(bodystatus);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["status"] = "Active";
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    if (bodyisPrivate != null)
                    {
                        body["isPrivate"] = ExpressionConverter.ConvertO(bodyisPrivate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["isPrivate"] = false;
                    bodypropCount++;
                }

                if (bodyreferenceId != null)
                {
                    body["referenceId"] = ExpressionConverter.ConvertO(bodyreferenceId);
                    bodypropCount++;
                }

                if (bodyreferenceData != null)
                {
                    body["referenceData"] = ExpressionConverter.ConvertO(bodyreferenceData);
                    bodypropCount++;
                }

                if (bodyreferenceSource != null)
                {
                    body["referenceSource"] = ExpressionConverter.ConvertO(bodyreferenceSource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetTaskExt))]
        public IBodyWorkflowAction<GetTaskExtResponse> GetTaskExt([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<getByInput> getBy, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> source = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskExtResponse> __BuildGetTaskExt(WorkflowExpression<string> apiKey, WorkflowExpression<getByInput> getBy, WorkflowExpression<string> id, WorkflowExpression<string> source = null)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(getBy, nameof(getBy), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            return new DeferredBodyAction<GetTaskExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetTaskExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["GetBy"] = ExpressionConverter.Convert(getBy);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (source != null)
                    callPayload.Queries["Source"] = ExpressionConverter.Convert(source);
                return new ApiConnectionAction<GetTaskExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjectExt))]
        public IBodyWorkflowAction<GetProjectExtResponse> GetProjectExt([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<getByInput> getBy, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> source = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectExtResponse> __BuildGetProjectExt(WorkflowExpression<string> apiKey, WorkflowExpression<getByInput> getBy, WorkflowExpression<string> id, WorkflowExpression<string> source = null)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(getBy, nameof(getBy), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            return new DeferredBodyAction<GetProjectExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["GetBy"] = ExpressionConverter.Convert(getBy);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (source != null)
                    callPayload.Queries["Source"] = ExpressionConverter.Convert(source);
                return new ApiConnectionAction<GetProjectExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjectTemplatesExt))]
        public IBodyWorkflowAction<GetProjectTemplatesExtResponse> GetProjectTemplatesExt([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> userEmail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectTemplatesExtResponse> __BuildGetProjectTemplatesExt(WorkflowExpression<string> apiKey, WorkflowExpression<string> userEmail)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(userEmail, nameof(userEmail), required: true);
            return new DeferredBodyAction<GetProjectTemplatesExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectTemplatesExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(userEmail);
                return new ApiConnectionAction<GetProjectTemplatesExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjectRolesExt))]
        public IBodyWorkflowAction<GetProjectRolesExtResponse> GetProjectRolesExt([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> userEmail, [WorkflowExpression] Func<roleTypeInput> roleType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectRolesExtResponse> __BuildGetProjectRolesExt(WorkflowExpression<string> apiKey, WorkflowExpression<string> userEmail, WorkflowExpression<roleTypeInput> roleType = null)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(userEmail, nameof(userEmail), required: true);
            WorkflowExpression.Validate(roleType, nameof(roleType), required: false);
            return new DeferredBodyAction<GetProjectRolesExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectRolesExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(userEmail);
                if (roleType != null)
                    callPayload.Queries["RoleType"] = ExpressionConverter.Convert(roleType);
                return new ApiConnectionAction<GetProjectRolesExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildCreateProjectFromTemplateExt))]
        public IBodyWorkflowAction<CreateProjectFromTemplateExtResponse> CreateProjectFromTemplateExt([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodycreatorEmail, [WorkflowExpression] Func<string> bodyprojectName, [WorkflowExpression] Func<bool> bodyisPrivate, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyclientName = null, [WorkflowExpression] Func<bodymembersInputItem[]> bodymembers = null, [WorkflowExpression] Func<bodyfilesLinksInputItem[]> bodyfilesLinks = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateProjectFromTemplateExtResponse> __BuildCreateProjectFromTemplateExt(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodytemplateId, WorkflowExpression<string> bodycreatorEmail, WorkflowExpression<string> bodyprojectName, WorkflowExpression<bool> bodyisPrivate, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodyclientName = null, WorkflowExpression<bodymembersInputItem[]> bodymembers = null, WorkflowExpression<bodyfilesLinksInputItem[]> bodyfilesLinks = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowExpression.Validate(bodycreatorEmail, nameof(bodycreatorEmail), required: true);
            WorkflowExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: true);
            WorkflowExpression.Validate(bodyisPrivate, nameof(bodyisPrivate), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyclientName, nameof(bodyclientName), required: false);
            WorkflowExpression.Validate(bodymembers, nameof(bodymembers), required: false);
            WorkflowExpression.Validate(bodyfilesLinks, nameof(bodyfilesLinks), required: false);
            return new DeferredBodyAction<CreateProjectFromTemplateExtResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateProjectFromTemplateExt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = ExpressionConverter.ConvertO(bodyapiKey);
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
                body["creatorEmail"] = ExpressionConverter.ConvertO(bodycreatorEmail);
                bodypropCount++;
                body["projectName"] = ExpressionConverter.ConvertO(bodyprojectName);
                if (bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                    bodypropCount++;
                }

                if (bodyclientName != null)
                {
                    body["clientName"] = ExpressionConverter.ConvertO(bodyclientName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["isPrivate"] = ExpressionConverter.ConvertO(bodyisPrivate);
                if (bodymembers != null)
                {
                    body["members"] = ExpressionConverter.ConvertO(bodymembers);
                    bodypropCount++;
                }

                if (bodyfilesLinks != null)
                {
                    body["filesLinks"] = ExpressionConverter.ConvertO(bodyfilesLinks);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateProjectFromTemplateExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        [WorkflowExpressionFactory(nameof(__BuildDeletetask))]
        public IBodyWorkflowAction<DeletetaskResponse> Deletetask([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> taskID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeletetaskResponse> __BuildDeletetask(WorkflowExpression<string> apiKey, WorkflowExpression<string> taskID)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(taskID, nameof(taskID), required: true);
            return new DeferredBodyAction<DeletetaskResponse>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/DeleteExternalTask";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["TaskID"] = ExpressionConverter.Convert(taskID);
                return new ApiConnectionAction<DeletetaskResponse>(callPayload);
            });
        }
    }

    public class VineforceTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWhenTaskIsCompleted))]
        public IBodyWorkflowTrigger<WhenTaskIsCompletedResponse> WhenTaskIsCompleted([WorkflowExpression] Func<string> apiKey,[WorkflowExpression] Func<int> duration,[WorkflowExpression] Func<string> projectName = null,[WorkflowExpression] Func<string> projectId = null,[WorkflowExpression] Func<string> assigneeEmail = null,[WorkflowExpression] Func<string> creatorEmail = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenTaskIsCompletedResponse> __BuildWhenTaskIsCompleted(WorkflowExpression<string> apiKey,WorkflowExpression<int> duration,WorkflowExpression<string> projectName = null,WorkflowExpression<string> projectId = null,WorkflowExpression<string> assigneeEmail = null,WorkflowExpression<string> creatorEmail = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(duration, nameof(duration), required: true);
            WorkflowExpression.Validate(projectName, nameof(projectName), required: false);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: false);
            WorkflowExpression.Validate(assigneeEmail, nameof(assigneeEmail), required: false);
            WorkflowExpression.Validate(creatorEmail, nameof(creatorEmail), required: false);
            return new DeferredBodyTrigger<WhenTaskIsCompletedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentCompletedTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                if (projectName != null)
                    callPayload.Queries["ProjectName"] = ExpressionConverter.Convert(projectName);
                if (projectId != null)
                    callPayload.Queries["ProjectId"] = ExpressionConverter.Convert(projectId);
                if (assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = ExpressionConverter.Convert(assigneeEmail);
                if (creatorEmail != null)
                    callPayload.Queries["CreatorEmail"] = ExpressionConverter.Convert(creatorEmail);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(duration);
                return new ApiConnectionTrigger<WhenTaskIsCompletedResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenTaskSectionIsChanged))]
        public IBodyWorkflowTrigger<WhenTaskSectionIsChangedResponse> WhenTaskSectionIsChanged([WorkflowExpression] Func<string> apiKey,[WorkflowExpression] Func<string> userEmail,[WorkflowExpression] Func<string> projectName = null,[WorkflowExpression] Func<string> projectId = null,[WorkflowExpression] Func<string> assigneeEmail = null,[WorkflowExpression] Func<string> taskId = null,[WorkflowExpression] Func<string> oldSectionId = null,[WorkflowExpression] Func<string> oldSectoinName = null,[WorkflowExpression] Func<string> newSectionId = null,[WorkflowExpression] Func<string> newSectoinName = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenTaskSectionIsChangedResponse> __BuildWhenTaskSectionIsChanged(WorkflowExpression<string> apiKey,WorkflowExpression<string> userEmail,WorkflowExpression<string> projectName = null,WorkflowExpression<string> projectId = null,WorkflowExpression<string> assigneeEmail = null,WorkflowExpression<string> taskId = null,WorkflowExpression<string> oldSectionId = null,WorkflowExpression<string> oldSectoinName = null,WorkflowExpression<string> newSectionId = null,WorkflowExpression<string> newSectoinName = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(userEmail, nameof(userEmail), required: true);
            WorkflowExpression.Validate(projectName, nameof(projectName), required: false);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: false);
            WorkflowExpression.Validate(assigneeEmail, nameof(assigneeEmail), required: false);
            WorkflowExpression.Validate(taskId, nameof(taskId), required: false);
            WorkflowExpression.Validate(oldSectionId, nameof(oldSectionId), required: false);
            WorkflowExpression.Validate(oldSectoinName, nameof(oldSectoinName), required: false);
            WorkflowExpression.Validate(newSectionId, nameof(newSectionId), required: false);
            WorkflowExpression.Validate(newSectoinName, nameof(newSectoinName), required: false);
            return new DeferredBodyTrigger<WhenTaskSectionIsChangedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentModifiedSectionTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(userEmail);
                if (projectName != null)
                    callPayload.Queries["ProjectName"] = ExpressionConverter.Convert(projectName);
                if (projectId != null)
                    callPayload.Queries["ProjectId"] = ExpressionConverter.Convert(projectId);
                if (assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = ExpressionConverter.Convert(assigneeEmail);
                if (taskId != null)
                    callPayload.Queries["TaskId"] = ExpressionConverter.Convert(taskId);
                if (oldSectionId != null)
                    callPayload.Queries["OldSectionId"] = ExpressionConverter.Convert(oldSectionId);
                if (oldSectoinName != null)
                    callPayload.Queries["OldSectoinName"] = ExpressionConverter.Convert(oldSectoinName);
                if (newSectionId != null)
                    callPayload.Queries["NewSectionId"] = ExpressionConverter.Convert(newSectionId);
                if (newSectoinName != null)
                    callPayload.Queries["NewSectoinName"] = ExpressionConverter.Convert(newSectoinName);
                return new ApiConnectionTrigger<WhenTaskSectionIsChangedResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenTaskIsCreated))]
        public IBodyWorkflowTrigger<WhenTaskIsCreatedResponse> WhenTaskIsCreated([WorkflowExpression] Func<string> apiKey,[WorkflowExpression] Func<int> duration,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenTaskIsCreatedResponse> __BuildWhenTaskIsCreated(WorkflowExpression<string> apiKey,WorkflowExpression<int> duration,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(duration, nameof(duration), required: true);
            return new DeferredBodyTrigger<WhenTaskIsCreatedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyCreatedTask";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(duration);
                return new ApiConnectionTrigger<WhenTaskIsCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenTaskIsUpdated))]
        public IBodyWorkflowTrigger<WhenTaskIsUpdatedResponse> WhenTaskIsUpdated([WorkflowExpression] Func<string> apiKey,[WorkflowExpression] Func<int> duration,[WorkflowExpression] Func<string> updateFilter = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenTaskIsUpdatedResponse> __BuildWhenTaskIsUpdated(WorkflowExpression<string> apiKey,WorkflowExpression<int> duration,WorkflowExpression<string> updateFilter = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(duration, nameof(duration), required: true);
            WorkflowExpression.Validate(updateFilter, nameof(updateFilter), required: false);
            return new DeferredBodyTrigger<WhenTaskIsUpdatedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyUpdatedTask";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                if (updateFilter != null)
                    callPayload.Queries["UpdateFilter"] = ExpressionConverter.Convert(updateFilter);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(duration);
                return new ApiConnectionTrigger<WhenTaskIsUpdatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenTaskIsDeleted))]
        public IBodyWorkflowTrigger<WhenTaskIsDeletedResponse> WhenTaskIsDeleted([WorkflowExpression] Func<string> apiKey,[WorkflowExpression] Func<int> duration,[WorkflowExpression] Func<string> projectName = null,[WorkflowExpression] Func<string> projectId = null,[WorkflowExpression] Func<string> assigneeEmail = null,[WorkflowExpression] Func<string> creatorEmail = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenTaskIsDeletedResponse> __BuildWhenTaskIsDeleted(WorkflowExpression<string> apiKey,WorkflowExpression<int> duration,WorkflowExpression<string> projectName = null,WorkflowExpression<string> projectId = null,WorkflowExpression<string> assigneeEmail = null,WorkflowExpression<string> creatorEmail = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(duration, nameof(duration), required: true);
            WorkflowExpression.Validate(projectName, nameof(projectName), required: false);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: false);
            WorkflowExpression.Validate(assigneeEmail, nameof(assigneeEmail), required: false);
            WorkflowExpression.Validate(creatorEmail, nameof(creatorEmail), required: false);
            return new DeferredBodyTrigger<WhenTaskIsDeletedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyDeletedTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                if (projectName != null)
                    callPayload.Queries["ProjectName"] = ExpressionConverter.Convert(projectName);
                if (projectId != null)
                    callPayload.Queries["ProjectId"] = ExpressionConverter.Convert(projectId);
                if (assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = ExpressionConverter.Convert(assigneeEmail);
                if (creatorEmail != null)
                    callPayload.Queries["CreatorEmail"] = ExpressionConverter.Convert(creatorEmail);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(duration);
                return new ApiConnectionTrigger<WhenTaskIsDeletedResponse>(callPayload, recurrence: recurrence);
            });
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