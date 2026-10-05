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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTaskResponse> __BuildCreateTask(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodytitle, WorkflowValue<string> bodyfromEmail = null, WorkflowValue<string> bodytoEmail = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodydueDate = null, WorkflowValue<bodypriorityTextInput> bodypriorityText = null, WorkflowValue<string> bodyassociatedContactEmail = null, WorkflowValue<bodyresourceAppNameInput> bodyresourceAppName = null, WorkflowValue<string> bodyresourceAppUrl = null, WorkflowValue<string> bodyresourceAppID = null, WorkflowValue<string> bodyresourceAppData = null, WorkflowValue<string> bodyreferenceId = null, WorkflowValue<string> bodyreferenceData = null, WorkflowValue<string> bodyreferenceSource = null, WorkflowValue<string> bodyprojectName = null, WorkflowValue<string> bodyprojectSectionName = null, WorkflowValue<string> bodyprojectTags = null, WorkflowValue<bodychecklistsInputItem[]> bodychecklists = null, WorkflowValue<bodyfilesInputItem[]> bodyfiles = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowValue.Validate(bodyfromEmail, nameof(bodyfromEmail), required: false);
            WorkflowValue.Validate(bodytoEmail, nameof(bodytoEmail), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowValue.Validate(bodypriorityText, nameof(bodypriorityText), required: false);
            WorkflowValue.Validate(bodyassociatedContactEmail, nameof(bodyassociatedContactEmail), required: false);
            WorkflowValue.Validate(bodyresourceAppName, nameof(bodyresourceAppName), required: false);
            WorkflowValue.Validate(bodyresourceAppUrl, nameof(bodyresourceAppUrl), required: false);
            WorkflowValue.Validate(bodyresourceAppID, nameof(bodyresourceAppID), required: false);
            WorkflowValue.Validate(bodyresourceAppData, nameof(bodyresourceAppData), required: false);
            WorkflowValue.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            WorkflowValue.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            WorkflowValue.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            WorkflowValue.Validate(bodyprojectName, nameof(bodyprojectName), required: false);
            WorkflowValue.Validate(bodyprojectSectionName, nameof(bodyprojectSectionName), required: false);
            WorkflowValue.Validate(bodyprojectTags, nameof(bodyprojectTags), required: false);
            WorkflowValue.Validate(bodychecklists, nameof(bodychecklists), required: false);
            WorkflowValue.Validate(bodyfiles, nameof(bodyfiles), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AlertResponse> __BuildAlert(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodyalertToEmail, WorkflowValue<string> bodytitle, WorkflowValue<string> bodymessage, WorkflowValue<bodyresourceNameInput> bodyresourceName = null, WorkflowValue<string> bodyresourceUrl = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodyalertToEmail, nameof(bodyalertToEmail), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowValue.Validate(bodyresourceName, nameof(bodyresourceName), required: false);
            WorkflowValue.Validate(bodyresourceUrl, nameof(bodyresourceUrl), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateProjectResponse> __BuildCreateProject(WorkflowValue<string> bodyprojectName, WorkflowValue<string> bodycreatorEmail, WorkflowValue<string> bodyapiKey, WorkflowValue<bodyfilesInputItem2[]> bodyfiles, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodydueDate = null, WorkflowValue<bool> bodyisPrivate = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodymembers = null, WorkflowValue<string> bodysections = null, WorkflowValue<string> bodyreferenceId = null, WorkflowValue<string> bodyreferenceData = null, WorkflowValue<string> bodyreferenceSource = null)
        {
            WorkflowValue.Validate(bodyprojectName, nameof(bodyprojectName), required: true);
            WorkflowValue.Validate(bodycreatorEmail, nameof(bodycreatorEmail), required: true);
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodyfiles, nameof(bodyfiles), required: true);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodymembers, nameof(bodymembers), required: false);
            WorkflowValue.Validate(bodysections, nameof(bodysections), required: false);
            WorkflowValue.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            WorkflowValue.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            WorkflowValue.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateTaskResponse> __BuildUpdateTask(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodytaskID, WorkflowValue<string> bodytoEmail, WorkflowValue<string> bodytitle, WorkflowValue<string> bodyfromEmail = null, WorkflowValue<bodytaskStatusInput> bodytaskStatus = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodydueDate = null, WorkflowValue<bodypriorityTextInput> bodypriorityText = null, WorkflowValue<string> bodyassociatedContactEmail = null, WorkflowValue<bodyresourceAppNameInput> bodyresourceAppName = null, WorkflowValue<string> bodyresourceAppUrl = null, WorkflowValue<string> bodyresourceAppID = null, WorkflowValue<string> bodyresourceAppData = null, WorkflowValue<string> bodyreferenceId = null, WorkflowValue<string> bodyreferenceData = null, WorkflowValue<string> bodyreferenceSource = null, WorkflowValue<string> bodyprojectName = null, WorkflowValue<string> bodyprojectSectionName = null, WorkflowValue<string> bodyprojectTags = null, WorkflowValue<bodychecklistsInputItem[]> bodychecklists = null, WorkflowValue<bodyfilesInputItem22[]> bodyfiles = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodytaskID, nameof(bodytaskID), required: true);
            WorkflowValue.Validate(bodytoEmail, nameof(bodytoEmail), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowValue.Validate(bodyfromEmail, nameof(bodyfromEmail), required: false);
            WorkflowValue.Validate(bodytaskStatus, nameof(bodytaskStatus), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowValue.Validate(bodypriorityText, nameof(bodypriorityText), required: false);
            WorkflowValue.Validate(bodyassociatedContactEmail, nameof(bodyassociatedContactEmail), required: false);
            WorkflowValue.Validate(bodyresourceAppName, nameof(bodyresourceAppName), required: false);
            WorkflowValue.Validate(bodyresourceAppUrl, nameof(bodyresourceAppUrl), required: false);
            WorkflowValue.Validate(bodyresourceAppID, nameof(bodyresourceAppID), required: false);
            WorkflowValue.Validate(bodyresourceAppData, nameof(bodyresourceAppData), required: false);
            WorkflowValue.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            WorkflowValue.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            WorkflowValue.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            WorkflowValue.Validate(bodyprojectName, nameof(bodyprojectName), required: false);
            WorkflowValue.Validate(bodyprojectSectionName, nameof(bodyprojectSectionName), required: false);
            WorkflowValue.Validate(bodyprojectTags, nameof(bodyprojectTags), required: false);
            WorkflowValue.Validate(bodychecklists, nameof(bodychecklists), required: false);
            WorkflowValue.Validate(bodyfiles, nameof(bodyfiles), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateContactNote(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodyownerEmail, WorkflowValue<string> bodycontactEmail, WorkflowValue<string> bodynotes)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodyownerEmail, nameof(bodyownerEmail), required: true);
            WorkflowValue.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            WorkflowValue.Validate(bodynotes, nameof(bodynotes), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateCompany(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodycompanyName, WorkflowValue<string> bodyuserEmail, WorkflowValue<string> bodystreet = null, WorkflowValue<string> bodysuiteUnitNumber = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodypostalCode = null, WorkflowValue<string> bodycountryName = null, WorkflowValue<string> bodytaxId = null, WorkflowValue<string> bodysiteUrl = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodycompanyName, nameof(bodycompanyName), required: true);
            WorkflowValue.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            WorkflowValue.Validate(bodystreet, nameof(bodystreet), required: false);
            WorkflowValue.Validate(bodysuiteUnitNumber, nameof(bodysuiteUnitNumber), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowValue.Validate(bodycountryName, nameof(bodycountryName), required: false);
            WorkflowValue.Validate(bodytaxId, nameof(bodytaxId), required: false);
            WorkflowValue.Validate(bodysiteUrl, nameof(bodysiteUrl), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateContactResponse> __BuildCreateContact(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodyownerEmailAddress, WorkflowValue<string> bodycontactEmailAddress1, WorkflowValue<string> bodyfirstName, WorkflowValue<string> bodycontactEmailAddress2 = null, WorkflowValue<string> bodycontactEmailAddress3 = null, WorkflowValue<string> bodylastName = null, WorkflowValue<string> bodyjobTitle = null, WorkflowValue<string> bodybirthDay = null, WorkflowValue<int> bodybirthMonth = null, WorkflowValue<int> bodybirthYear = null, WorkflowValue<string> bodycontactType = null, WorkflowValue<string> bodycompanyID1 = null, WorkflowValue<string> bodycompanyID2 = null, WorkflowValue<string> bodycompanyID3 = null, WorkflowValue<string> bodyaccountNumber = null, WorkflowValue<string> bodysocialSecurityNumber = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodyownerEmailAddress, nameof(bodyownerEmailAddress), required: true);
            WorkflowValue.Validate(bodycontactEmailAddress1, nameof(bodycontactEmailAddress1), required: true);
            WorkflowValue.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            WorkflowValue.Validate(bodycontactEmailAddress2, nameof(bodycontactEmailAddress2), required: false);
            WorkflowValue.Validate(bodycontactEmailAddress3, nameof(bodycontactEmailAddress3), required: false);
            WorkflowValue.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowValue.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowValue.Validate(bodybirthDay, nameof(bodybirthDay), required: false);
            WorkflowValue.Validate(bodybirthMonth, nameof(bodybirthMonth), required: false);
            WorkflowValue.Validate(bodybirthYear, nameof(bodybirthYear), required: false);
            WorkflowValue.Validate(bodycontactType, nameof(bodycontactType), required: false);
            WorkflowValue.Validate(bodycompanyID1, nameof(bodycompanyID1), required: false);
            WorkflowValue.Validate(bodycompanyID2, nameof(bodycompanyID2), required: false);
            WorkflowValue.Validate(bodycompanyID3, nameof(bodycompanyID3), required: false);
            WorkflowValue.Validate(bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            WorkflowValue.Validate(bodysocialSecurityNumber, nameof(bodysocialSecurityNumber), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateContactPhone(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodycontactEmail, WorkflowValue<string> bodyuserEmail, WorkflowValue<string> bodyphone, WorkflowValue<bodyphoneTypeInput> bodyphoneType, WorkflowValue<string> bodyextension = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            WorkflowValue.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            WorkflowValue.Validate(bodyphone, nameof(bodyphone), required: true);
            WorkflowValue.Validate(bodyphoneType, nameof(bodyphoneType), required: true);
            WorkflowValue.Validate(bodyextension, nameof(bodyextension), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateContactAddress(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodycontactEmail, WorkflowValue<string> bodyuserEmail, WorkflowValue<bodyaddressTypeInput> bodyaddressType, WorkflowValue<string> bodystreet = null, WorkflowValue<string> bodysuiteUnitNumber = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodyzipCode = null, WorkflowValue<string> bodycountryName = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            WorkflowValue.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            WorkflowValue.Validate(bodyaddressType, nameof(bodyaddressType), required: true);
            WorkflowValue.Validate(bodystreet, nameof(bodystreet), required: false);
            WorkflowValue.Validate(bodysuiteUnitNumber, nameof(bodysuiteUnitNumber), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowValue.Validate(bodycountryName, nameof(bodycountryName), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateContactFamily(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodycontactEmail, WorkflowValue<string> bodyuserEmail, WorkflowValue<string> bodyfirstName, WorkflowValue<bodyrelationshipInput> bodyrelationship, WorkflowValue<string> bodylastName = null, WorkflowValue<string> bodybirthDate = null, WorkflowValue<int> bodybirthMonth = null, WorkflowValue<int> bodybirthYear = null, WorkflowValue<string> bodycountryName = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            WorkflowValue.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            WorkflowValue.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            WorkflowValue.Validate(bodyrelationship, nameof(bodyrelationship), required: true);
            WorkflowValue.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowValue.Validate(bodybirthDate, nameof(bodybirthDate), required: false);
            WorkflowValue.Validate(bodybirthMonth, nameof(bodybirthMonth), required: false);
            WorkflowValue.Validate(bodybirthYear, nameof(bodybirthYear), required: false);
            WorkflowValue.Validate(bodycountryName, nameof(bodycountryName), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetContactFolderDetailsResponse> __BuildGetContactFolderDetails(WorkflowValue<string> apiKey, WorkflowValue<string> userEmail, WorkflowValue<string> contactEmail)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(userEmail, nameof(userEmail), required: true);
            WorkflowValue.Validate(contactEmail, nameof(contactEmail), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCompanyDetailExternalResponse> __BuildGetCompanyDetailExternal(WorkflowValue<string> apiKey, WorkflowValue<matchByInput> matchBy, WorkflowValue<string> matchValue)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(matchBy, nameof(matchBy), required: true);
            WorkflowValue.Validate(matchValue, nameof(matchValue), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskByResourceExtResponse> __BuildGetTaskByResourceExt(WorkflowValue<string> apiKey, WorkflowValue<string> resourceAppID)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(resourceAppID, nameof(resourceAppID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTaskCommentExtResponse> __BuildCreateTaskCommentExt(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodyuserEmail, WorkflowValue<string> bodytaskId, WorkflowValue<string> bodycomment)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            WorkflowValue.Validate(bodytaskId, nameof(bodytaskId), required: true);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateProjectResponse> __BuildUpdateProject(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodyprojectId, WorkflowValue<string> bodyprojectName, WorkflowValue<string> bodycurrentUserEmail, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodydueDate = null, WorkflowValue<string> bodydescription = null, WorkflowValue<bodystatusInput> bodystatus = null, WorkflowValue<bool> bodyisPrivate = null, WorkflowValue<string> bodyreferenceId = null, WorkflowValue<string> bodyreferenceData = null, WorkflowValue<string> bodyreferenceSource = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            WorkflowValue.Validate(bodyprojectName, nameof(bodyprojectName), required: true);
            WorkflowValue.Validate(bodycurrentUserEmail, nameof(bodycurrentUserEmail), required: true);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            WorkflowValue.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            WorkflowValue.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            WorkflowValue.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskExtResponse> __BuildGetTaskExt(WorkflowValue<string> apiKey, WorkflowValue<getByInput> getBy, WorkflowValue<string> id, WorkflowValue<string> source = null)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(getBy, nameof(getBy), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(source, nameof(source), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectExtResponse> __BuildGetProjectExt(WorkflowValue<string> apiKey, WorkflowValue<getByInput> getBy, WorkflowValue<string> id, WorkflowValue<string> source = null)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(getBy, nameof(getBy), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(source, nameof(source), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectTemplatesExtResponse> __BuildGetProjectTemplatesExt(WorkflowValue<string> apiKey, WorkflowValue<string> userEmail)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(userEmail, nameof(userEmail), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectRolesExtResponse> __BuildGetProjectRolesExt(WorkflowValue<string> apiKey, WorkflowValue<string> userEmail, WorkflowValue<roleTypeInput> roleType = null)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(userEmail, nameof(userEmail), required: true);
            WorkflowValue.Validate(roleType, nameof(roleType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateProjectFromTemplateExtResponse> __BuildCreateProjectFromTemplateExt(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodytemplateId, WorkflowValue<string> bodycreatorEmail, WorkflowValue<string> bodyprojectName, WorkflowValue<bool> bodyisPrivate, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<string> bodyclientName = null, WorkflowValue<bodymembersInputItem[]> bodymembers = null, WorkflowValue<bodyfilesLinksInputItem[]> bodyfilesLinks = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowValue.Validate(bodycreatorEmail, nameof(bodycreatorEmail), required: true);
            WorkflowValue.Validate(bodyprojectName, nameof(bodyprojectName), required: true);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: true);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodyclientName, nameof(bodyclientName), required: false);
            WorkflowValue.Validate(bodymembers, nameof(bodymembers), required: false);
            WorkflowValue.Validate(bodyfilesLinks, nameof(bodyfilesLinks), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeletetaskResponse> __BuildDeletetask(WorkflowValue<string> apiKey, WorkflowValue<string> taskID)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(taskID, nameof(taskID), required: true);
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
        public IBodyWorkflowTrigger<WhenTaskIsCompletedResponse> WhenTaskIsCompleted([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<int> duration, [WorkflowExpression] Func<string> projectName = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> assigneeEmail = null, [WorkflowExpression] Func<string> creatorEmail = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenTaskIsCompletedResponse> __BuildWhenTaskIsCompleted(WorkflowValue<string> apiKey, WorkflowValue<int> duration, WorkflowValue<string> projectName = null, WorkflowValue<string> projectId = null, WorkflowValue<string> assigneeEmail = null, WorkflowValue<string> creatorEmail = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(duration, nameof(duration), required: true);
            WorkflowValue.Validate(projectName, nameof(projectName), required: false);
            WorkflowValue.Validate(projectId, nameof(projectId), required: false);
            WorkflowValue.Validate(assigneeEmail, nameof(assigneeEmail), required: false);
            WorkflowValue.Validate(creatorEmail, nameof(creatorEmail), required: false);
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
                return new ApiConnectionTrigger<WhenTaskIsCompletedResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenTaskSectionIsChanged))]
        public IBodyWorkflowTrigger<WhenTaskSectionIsChangedResponse> WhenTaskSectionIsChanged([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> userEmail, [WorkflowExpression] Func<string> projectName = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> assigneeEmail = null, [WorkflowExpression] Func<string> taskId = null, [WorkflowExpression] Func<string> oldSectionId = null, [WorkflowExpression] Func<string> oldSectoinName = null, [WorkflowExpression] Func<string> newSectionId = null, [WorkflowExpression] Func<string> newSectoinName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenTaskSectionIsChangedResponse> __BuildWhenTaskSectionIsChanged(WorkflowValue<string> apiKey, WorkflowValue<string> userEmail, WorkflowValue<string> projectName = null, WorkflowValue<string> projectId = null, WorkflowValue<string> assigneeEmail = null, WorkflowValue<string> taskId = null, WorkflowValue<string> oldSectionId = null, WorkflowValue<string> oldSectoinName = null, WorkflowValue<string> newSectionId = null, WorkflowValue<string> newSectoinName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(userEmail, nameof(userEmail), required: true);
            WorkflowValue.Validate(projectName, nameof(projectName), required: false);
            WorkflowValue.Validate(projectId, nameof(projectId), required: false);
            WorkflowValue.Validate(assigneeEmail, nameof(assigneeEmail), required: false);
            WorkflowValue.Validate(taskId, nameof(taskId), required: false);
            WorkflowValue.Validate(oldSectionId, nameof(oldSectionId), required: false);
            WorkflowValue.Validate(oldSectoinName, nameof(oldSectoinName), required: false);
            WorkflowValue.Validate(newSectionId, nameof(newSectionId), required: false);
            WorkflowValue.Validate(newSectoinName, nameof(newSectoinName), required: false);
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
                return new ApiConnectionTrigger<WhenTaskSectionIsChangedResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenTaskIsCreated))]
        public IBodyWorkflowTrigger<WhenTaskIsCreatedResponse> WhenTaskIsCreated([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<int> duration, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenTaskIsCreatedResponse> __BuildWhenTaskIsCreated(WorkflowValue<string> apiKey, WorkflowValue<int> duration, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(duration, nameof(duration), required: true);
            return new DeferredBodyTrigger<WhenTaskIsCreatedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyCreatedTask";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(duration);
                return new ApiConnectionTrigger<WhenTaskIsCreatedResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenTaskIsUpdated))]
        public IBodyWorkflowTrigger<WhenTaskIsUpdatedResponse> WhenTaskIsUpdated([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<int> duration, [WorkflowExpression] Func<string> updateFilter = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenTaskIsUpdatedResponse> __BuildWhenTaskIsUpdated(WorkflowValue<string> apiKey, WorkflowValue<int> duration, WorkflowValue<string> updateFilter = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(duration, nameof(duration), required: true);
            WorkflowValue.Validate(updateFilter, nameof(updateFilter), required: false);
            return new DeferredBodyTrigger<WhenTaskIsUpdatedResponse>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyUpdatedTask";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
                if (updateFilter != null)
                    callPayload.Queries["UpdateFilter"] = ExpressionConverter.Convert(updateFilter);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(duration);
                return new ApiConnectionTrigger<WhenTaskIsUpdatedResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenTaskIsDeleted))]
        public IBodyWorkflowTrigger<WhenTaskIsDeletedResponse> WhenTaskIsDeleted([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<int> duration, [WorkflowExpression] Func<string> projectName = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> assigneeEmail = null, [WorkflowExpression] Func<string> creatorEmail = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenTaskIsDeletedResponse> __BuildWhenTaskIsDeleted(WorkflowValue<string> apiKey, WorkflowValue<int> duration, WorkflowValue<string> projectName = null, WorkflowValue<string> projectId = null, WorkflowValue<string> assigneeEmail = null, WorkflowValue<string> creatorEmail = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowValue.Validate(duration, nameof(duration), required: true);
            WorkflowValue.Validate(projectName, nameof(projectName), required: false);
            WorkflowValue.Validate(projectId, nameof(projectId), required: false);
            WorkflowValue.Validate(assigneeEmail, nameof(assigneeEmail), required: false);
            WorkflowValue.Validate(creatorEmail, nameof(creatorEmail), required: false);
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
                return new ApiConnectionTrigger<WhenTaskIsDeletedResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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

    public enum bodypriorityTextInput
    {
        Normal,
        Important,
        Urgent
    }

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

    public enum bodyphoneTypeInput
    {
        Mobile,
        Work,
        Home,
        Fax,
        Other
    }

    public enum bodyaddressTypeInput
    {
        Home,
        Physical,
        Mailing,
        Work,
        Other
    }

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
