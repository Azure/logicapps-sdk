//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vineforce
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VineforceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyfromEmail = null, [WorkflowExpression] Func<string> bodytoEmail = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodypriorityTextInput> bodypriorityText = null, [WorkflowExpression] Func<string> bodyassociatedContactEmail = null, [WorkflowExpression] Func<bodyresourceAppNameInput> bodyresourceAppName = null, [WorkflowExpression] Func<string> bodyresourceAppUrl = null, [WorkflowExpression] Func<string> bodyresourceAppId = null, [WorkflowExpression] Func<string> bodyresourceAppData = null, [WorkflowExpression] Func<string> bodyreferenceId = null, [WorkflowExpression] Func<string> bodyreferenceData = null, [WorkflowExpression] Func<string> bodyreferenceSource = null, [WorkflowExpression] Func<string> bodyprojectName = null, [WorkflowExpression] Func<string> bodyprojectSectionName = null, [WorkflowExpression] Func<string> bodyprojectTags = null, [WorkflowExpression] Func<bodychecklistsInputItem[]> bodychecklists = null, [WorkflowExpression] Func<bodyfilesInputItem[]> bodyfiles = null)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodyfromEmail, nameof(bodyfromEmail), required: false);
            SourceExpression.Validate(bodytoEmail, nameof(bodytoEmail), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodypriorityText, nameof(bodypriorityText), required: false);
            SourceExpression.Validate(bodyassociatedContactEmail, nameof(bodyassociatedContactEmail), required: false);
            SourceExpression.Validate(bodyresourceAppName, nameof(bodyresourceAppName), required: false);
            SourceExpression.Validate(bodyresourceAppUrl, nameof(bodyresourceAppUrl), required: false);
            SourceExpression.Validate(bodyresourceAppId, nameof(bodyresourceAppId), required: false);
            SourceExpression.Validate(bodyresourceAppData, nameof(bodyresourceAppData), required: false);
            SourceExpression.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            SourceExpression.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            SourceExpression.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            SourceExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: false);
            SourceExpression.Validate(bodyprojectSectionName, nameof(bodyprojectSectionName), required: false);
            SourceExpression.Validate(bodyprojectTags, nameof(bodyprojectTags), required: false);
            SourceExpression.Validate(bodychecklists, nameof(bodychecklists), required: false);
            SourceExpression.Validate(bodyfiles, nameof(bodyfiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateExternalTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                if (bodyfromEmail != null)
                {
                    body["fromEmail"] = SourceExpressionConverter.ConvertToken(bodyfromEmail);
                    bodypropCount++;
                }

                if (bodytoEmail != null)
                {
                    body["toEmail"] = SourceExpressionConverter.ConvertToken(bodytoEmail);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodypriorityText != null)
                {
                    body["priorityText"] = SourceExpressionConverter.Convert(bodypriorityText);
                    bodypropCount++;
                }

                if (bodyassociatedContactEmail != null)
                {
                    body["associatedContactEmail"] = SourceExpressionConverter.ConvertToken(bodyassociatedContactEmail);
                    bodypropCount++;
                }

                if (bodyresourceAppName != null)
                {
                    body["resourceAppName"] = SourceExpressionConverter.Convert(bodyresourceAppName);
                    bodypropCount++;
                }

                if (bodyresourceAppUrl != null)
                {
                    body["resourceAppUrl"] = SourceExpressionConverter.ConvertToken(bodyresourceAppUrl);
                    bodypropCount++;
                }

                if (bodyresourceAppId != null)
                {
                    body["resourceAppID"] = SourceExpressionConverter.ConvertToken(bodyresourceAppId);
                    bodypropCount++;
                }

                if (bodyresourceAppData != null)
                {
                    body["resourceAppData"] = SourceExpressionConverter.ConvertToken(bodyresourceAppData);
                    bodypropCount++;
                }

                if (bodyreferenceId != null)
                {
                    body["referenceId"] = SourceExpressionConverter.ConvertToken(bodyreferenceId);
                    bodypropCount++;
                }

                if (bodyreferenceData != null)
                {
                    body["referenceData"] = SourceExpressionConverter.ConvertToken(bodyreferenceData);
                    bodypropCount++;
                }

                if (bodyreferenceSource != null)
                {
                    body["referenceSource"] = SourceExpressionConverter.ConvertToken(bodyreferenceSource);
                    bodypropCount++;
                }

                if (bodyprojectName != null)
                {
                    body["projectName"] = SourceExpressionConverter.ConvertToken(bodyprojectName);
                    bodypropCount++;
                }

                if (bodyprojectSectionName != null)
                {
                    body["projectSectionName"] = SourceExpressionConverter.ConvertToken(bodyprojectSectionName);
                    bodypropCount++;
                }

                if (bodyprojectTags != null)
                {
                    body["projectTags"] = SourceExpressionConverter.ConvertToken(bodyprojectTags);
                    bodypropCount++;
                }

                if (bodychecklists != null)
                {
                    body["checklists"] = SourceExpressionConverter.ConvertToken(bodychecklists);
                    bodypropCount++;
                }

                if (bodyfiles != null)
                {
                    body["files"] = SourceExpressionConverter.ConvertToken(bodyfiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<AlertResponse> Alert([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyalertToEmail, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<bodyresourceNameInput> bodyresourceName = null, [WorkflowExpression] Func<string> bodyresourceUrl = null)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodyalertToEmail, nameof(bodyalertToEmail), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodyresourceName, nameof(bodyresourceName), required: false);
            SourceExpression.Validate(bodyresourceUrl, nameof(bodyresourceUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/PushNotificationFromExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["alertToEmail"] = SourceExpressionConverter.ConvertToken(bodyalertToEmail);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodyresourceName != null)
                {
                    body["resourceName"] = SourceExpressionConverter.Convert(bodyresourceName);
                    bodypropCount++;
                }

                if (bodyresourceUrl != null)
                {
                    body["ResourceUrl"] = SourceExpressionConverter.ConvertToken(bodyresourceUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AlertResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject([WorkflowExpression] Func<string> bodyprojectName, [WorkflowExpression] Func<string> bodycreatorEmail, [WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<bodyfilesInputItem22[]> bodyfiles, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bool> bodyisPrivate = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodymembers = null, [WorkflowExpression] Func<string> bodysections = null, [WorkflowExpression] Func<string> bodyreferenceId = null, [WorkflowExpression] Func<string> bodyreferenceData = null, [WorkflowExpression] Func<string> bodyreferenceSource = null)
        {
            SourceExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: true);
            SourceExpression.Validate(bodycreatorEmail, nameof(bodycreatorEmail), required: true);
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodyfiles, nameof(bodyfiles), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodymembers, nameof(bodymembers), required: false);
            SourceExpression.Validate(bodysections, nameof(bodysections), required: false);
            SourceExpression.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            SourceExpression.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            SourceExpression.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateExternalProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["projectName"] = SourceExpressionConverter.ConvertToken(bodyprojectName);
                bodypropCount++;
                body["creatorEmail"] = SourceExpressionConverter.ConvertToken(bodycreatorEmail);
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    if (bodyisPrivate != null)
                    {
                        body["isPrivate"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
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
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodymembers != null)
                {
                    body["members"] = SourceExpressionConverter.ConvertToken(bodymembers);
                    bodypropCount++;
                }

                if (bodysections != null)
                {
                    body["sections"] = SourceExpressionConverter.ConvertToken(bodysections);
                    bodypropCount++;
                }

                bodypropCount++;
                body["files"] = SourceExpressionConverter.ConvertToken(bodyfiles);
                if (bodyreferenceId != null)
                {
                    body["referenceId"] = SourceExpressionConverter.ConvertToken(bodyreferenceId);
                    bodypropCount++;
                }

                if (bodyreferenceData != null)
                {
                    body["referenceData"] = SourceExpressionConverter.ConvertToken(bodyreferenceData);
                    bodypropCount++;
                }

                if (bodyreferenceSource != null)
                {
                    body["referenceSource"] = SourceExpressionConverter.ConvertToken(bodyreferenceSource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodytoEmail, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyfromEmail = null, [WorkflowExpression] Func<bodytaskStatusInput> bodytaskStatus = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodypriorityTextInput> bodypriorityText = null, [WorkflowExpression] Func<string> bodyassociatedContactEmail = null, [WorkflowExpression] Func<bodyresourceAppNameInput> bodyresourceAppName = null, [WorkflowExpression] Func<string> bodyresourceAppUrl = null, [WorkflowExpression] Func<string> bodyresourceAppId = null, [WorkflowExpression] Func<string> bodyresourceAppData = null, [WorkflowExpression] Func<string> bodyreferenceId = null, [WorkflowExpression] Func<string> bodyreferenceData = null, [WorkflowExpression] Func<string> bodyreferenceSource = null, [WorkflowExpression] Func<string> bodyprojectName = null, [WorkflowExpression] Func<string> bodyprojectSectionName = null, [WorkflowExpression] Func<string> bodyprojectTags = null, [WorkflowExpression] Func<bodychecklistsInputItem[]> bodychecklists = null, [WorkflowExpression] Func<bodyfilesInputItem2222[]> bodyfiles = null)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            SourceExpression.Validate(bodytoEmail, nameof(bodytoEmail), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodyfromEmail, nameof(bodyfromEmail), required: false);
            SourceExpression.Validate(bodytaskStatus, nameof(bodytaskStatus), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodypriorityText, nameof(bodypriorityText), required: false);
            SourceExpression.Validate(bodyassociatedContactEmail, nameof(bodyassociatedContactEmail), required: false);
            SourceExpression.Validate(bodyresourceAppName, nameof(bodyresourceAppName), required: false);
            SourceExpression.Validate(bodyresourceAppUrl, nameof(bodyresourceAppUrl), required: false);
            SourceExpression.Validate(bodyresourceAppId, nameof(bodyresourceAppId), required: false);
            SourceExpression.Validate(bodyresourceAppData, nameof(bodyresourceAppData), required: false);
            SourceExpression.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            SourceExpression.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            SourceExpression.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            SourceExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: false);
            SourceExpression.Validate(bodyprojectSectionName, nameof(bodyprojectSectionName), required: false);
            SourceExpression.Validate(bodyprojectTags, nameof(bodyprojectTags), required: false);
            SourceExpression.Validate(bodychecklists, nameof(bodychecklists), required: false);
            SourceExpression.Validate(bodyfiles, nameof(bodyfiles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/UpdateExternalTask";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["taskID"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                if (bodyfromEmail != null)
                {
                    body["fromEmail"] = SourceExpressionConverter.ConvertToken(bodyfromEmail);
                    bodypropCount++;
                }

                bodypropCount++;
                body["toEmail"] = SourceExpressionConverter.ConvertToken(bodytoEmail);
                if (bodytaskStatus != null)
                {
                    body["TaskStatus"] = SourceExpressionConverter.Convert(bodytaskStatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodypriorityText != null)
                {
                    body["priorityText"] = SourceExpressionConverter.Convert(bodypriorityText);
                    bodypropCount++;
                }

                if (bodyassociatedContactEmail != null)
                {
                    body["associatedContactEmail"] = SourceExpressionConverter.ConvertToken(bodyassociatedContactEmail);
                    bodypropCount++;
                }

                if (bodyresourceAppName != null)
                {
                    body["resourceAppName"] = SourceExpressionConverter.Convert(bodyresourceAppName);
                    bodypropCount++;
                }

                if (bodyresourceAppUrl != null)
                {
                    body["resourceAppUrl"] = SourceExpressionConverter.ConvertToken(bodyresourceAppUrl);
                    bodypropCount++;
                }

                if (bodyresourceAppId != null)
                {
                    body["resourceAppID"] = SourceExpressionConverter.ConvertToken(bodyresourceAppId);
                    bodypropCount++;
                }

                if (bodyresourceAppData != null)
                {
                    body["resourceAppData"] = SourceExpressionConverter.ConvertToken(bodyresourceAppData);
                    bodypropCount++;
                }

                if (bodyreferenceId != null)
                {
                    body["referenceId"] = SourceExpressionConverter.ConvertToken(bodyreferenceId);
                    bodypropCount++;
                }

                if (bodyreferenceData != null)
                {
                    body["referenceData"] = SourceExpressionConverter.ConvertToken(bodyreferenceData);
                    bodypropCount++;
                }

                if (bodyreferenceSource != null)
                {
                    body["referenceSource"] = SourceExpressionConverter.ConvertToken(bodyreferenceSource);
                    bodypropCount++;
                }

                if (bodyprojectName != null)
                {
                    body["projectName"] = SourceExpressionConverter.ConvertToken(bodyprojectName);
                    bodypropCount++;
                }

                if (bodyprojectSectionName != null)
                {
                    body["projectSectionName"] = SourceExpressionConverter.ConvertToken(bodyprojectSectionName);
                    bodypropCount++;
                }

                if (bodyprojectTags != null)
                {
                    body["projectTags"] = SourceExpressionConverter.ConvertToken(bodyprojectTags);
                    bodypropCount++;
                }

                if (bodychecklists != null)
                {
                    body["checklists"] = SourceExpressionConverter.ConvertToken(bodychecklists);
                    bodypropCount++;
                }

                if (bodyfiles != null)
                {
                    body["files"] = SourceExpressionConverter.ConvertToken(bodyfiles);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactNote([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyownerEmail, [WorkflowExpression] Func<string> bodycontactEmail, [WorkflowExpression] Func<string> bodynotes)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodyownerEmail, nameof(bodyownerEmail), required: true);
            SourceExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactNotes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["ownerEmail"] = SourceExpressionConverter.ConvertToken(bodyownerEmail);
                bodypropCount++;
                body["contactEmail"] = SourceExpressionConverter.ConvertToken(bodycontactEmail);
                bodypropCount++;
                body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateCompany([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodycompanyName, [WorkflowExpression] Func<string> bodyuserEmail, [WorkflowExpression] Func<string> bodystreet = null, [WorkflowExpression] Func<string> bodysuiteUnitNumber = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<string> bodycountryName = null, [WorkflowExpression] Func<string> bodytaxId = null, [WorkflowExpression] Func<string> bodysiteUrl = null)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: true);
            SourceExpression.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            SourceExpression.Validate(bodystreet, nameof(bodystreet), required: false);
            SourceExpression.Validate(bodysuiteUnitNumber, nameof(bodysuiteUnitNumber), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            SourceExpression.Validate(bodycountryName, nameof(bodycountryName), required: false);
            SourceExpression.Validate(bodytaxId, nameof(bodytaxId), required: false);
            SourceExpression.Validate(bodysiteUrl, nameof(bodysiteUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalCompany/CreateCompanyExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["companyName"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                bodypropCount++;
                body["userEmail"] = SourceExpressionConverter.ConvertToken(bodyuserEmail);
                if (bodystreet != null)
                {
                    body["street"] = SourceExpressionConverter.ConvertToken(bodystreet);
                    bodypropCount++;
                }

                if (bodysuiteUnitNumber != null)
                {
                    body["suite_UnitNumber"] = SourceExpressionConverter.ConvertToken(bodysuiteUnitNumber);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postalCode"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodycountryName != null)
                {
                    body["countryName"] = SourceExpressionConverter.ConvertToken(bodycountryName);
                    bodypropCount++;
                }

                if (bodytaxId != null)
                {
                    body["taxId"] = SourceExpressionConverter.ConvertToken(bodytaxId);
                    bodypropCount++;
                }

                if (bodysiteUrl != null)
                {
                    body["siteUrl"] = SourceExpressionConverter.ConvertToken(bodysiteUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyownerEmailAddress, [WorkflowExpression] Func<string> bodycontactEmailAddress1, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodycontactEmailAddress2 = null, [WorkflowExpression] Func<string> bodycontactEmailAddress3 = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodybirthDay = null, [WorkflowExpression] Func<int> bodybirthMonth = null, [WorkflowExpression] Func<int> bodybirthYear = null, [WorkflowExpression] Func<string> bodycontactType = null, [WorkflowExpression] Func<string> bodycompanyID1 = null, [WorkflowExpression] Func<string> bodycompanyID2 = null, [WorkflowExpression] Func<string> bodycompanyID3 = null, [WorkflowExpression] Func<string> bodyaccountNumber = null, [WorkflowExpression] Func<string> bodysocialSecurityNumber = null)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodyownerEmailAddress, nameof(bodyownerEmailAddress), required: true);
            SourceExpression.Validate(bodycontactEmailAddress1, nameof(bodycontactEmailAddress1), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            SourceExpression.Validate(bodycontactEmailAddress2, nameof(bodycontactEmailAddress2), required: false);
            SourceExpression.Validate(bodycontactEmailAddress3, nameof(bodycontactEmailAddress3), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            SourceExpression.Validate(bodybirthDay, nameof(bodybirthDay), required: false);
            SourceExpression.Validate(bodybirthMonth, nameof(bodybirthMonth), required: false);
            SourceExpression.Validate(bodybirthYear, nameof(bodybirthYear), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            SourceExpression.Validate(bodycompanyID1, nameof(bodycompanyID1), required: false);
            SourceExpression.Validate(bodycompanyID2, nameof(bodycompanyID2), required: false);
            SourceExpression.Validate(bodycompanyID3, nameof(bodycompanyID3), required: false);
            SourceExpression.Validate(bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            SourceExpression.Validate(bodysocialSecurityNumber, nameof(bodysocialSecurityNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["ownerEmailAddress"] = SourceExpressionConverter.ConvertToken(bodyownerEmailAddress);
                bodypropCount++;
                body["contactEmailAddress1"] = SourceExpressionConverter.ConvertToken(bodycontactEmailAddress1);
                if (bodycontactEmailAddress2 != null)
                {
                    body["contactEmailAddress2"] = SourceExpressionConverter.ConvertToken(bodycontactEmailAddress2);
                    bodypropCount++;
                }

                if (bodycontactEmailAddress3 != null)
                {
                    body["contactEmailAddress3"] = SourceExpressionConverter.ConvertToken(bodycontactEmailAddress3);
                    bodypropCount++;
                }

                bodypropCount++;
                body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodybirthDay != null)
                {
                    body["birthDay"] = SourceExpressionConverter.ConvertToken(bodybirthDay);
                    bodypropCount++;
                }

                if (bodybirthMonth != null)
                {
                    body["birthMonth"] = SourceExpressionConverter.ConvertToken(bodybirthMonth);
                    bodypropCount++;
                }

                if (bodybirthYear != null)
                {
                    body["birthYear"] = SourceExpressionConverter.ConvertToken(bodybirthYear);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = SourceExpressionConverter.ConvertToken(bodycontactType);
                    bodypropCount++;
                }

                if (bodycompanyID1 != null)
                {
                    body["companyID1"] = SourceExpressionConverter.ConvertToken(bodycompanyID1);
                    bodypropCount++;
                }

                if (bodycompanyID2 != null)
                {
                    body["companyID2"] = SourceExpressionConverter.ConvertToken(bodycompanyID2);
                    bodypropCount++;
                }

                if (bodycompanyID3 != null)
                {
                    body["companyID3"] = SourceExpressionConverter.ConvertToken(bodycompanyID3);
                    bodypropCount++;
                }

                if (bodyaccountNumber != null)
                {
                    body["accountNumber"] = SourceExpressionConverter.ConvertToken(bodyaccountNumber);
                    bodypropCount++;
                }

                if (bodysocialSecurityNumber != null)
                {
                    body["socialSecurityNumber"] = SourceExpressionConverter.ConvertToken(bodysocialSecurityNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactPhone([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodycontactEmail, [WorkflowExpression] Func<string> bodyuserEmail, [WorkflowExpression] Func<string> bodyphone, [WorkflowExpression] Func<bodyphoneTypeInput> bodyphoneType, [WorkflowExpression] Func<string> bodyextension = null)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            SourceExpression.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: true);
            SourceExpression.Validate(bodyphoneType, nameof(bodyphoneType), required: true);
            SourceExpression.Validate(bodyextension, nameof(bodyextension), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactPhoneExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["contactEmail"] = SourceExpressionConverter.ConvertToken(bodycontactEmail);
                bodypropCount++;
                body["userEmail"] = SourceExpressionConverter.ConvertToken(bodyuserEmail);
                bodypropCount++;
                body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
                body["phoneType"] = SourceExpressionConverter.Convert(bodyphoneType);
                if (bodyextension != null)
                {
                    body["extension"] = SourceExpressionConverter.ConvertToken(bodyextension);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactAddress([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodycontactEmail, [WorkflowExpression] Func<string> bodyuserEmail, [WorkflowExpression] Func<bodyaddressTypeInput> bodyaddressType, [WorkflowExpression] Func<string> bodystreet = null, [WorkflowExpression] Func<string> bodysuiteUnitNumber = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountryName = null)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            SourceExpression.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            SourceExpression.Validate(bodyaddressType, nameof(bodyaddressType), required: true);
            SourceExpression.Validate(bodystreet, nameof(bodystreet), required: false);
            SourceExpression.Validate(bodysuiteUnitNumber, nameof(bodysuiteUnitNumber), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodycountryName, nameof(bodycountryName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactAddressExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["contactEmail"] = SourceExpressionConverter.ConvertToken(bodycontactEmail);
                bodypropCount++;
                body["userEmail"] = SourceExpressionConverter.ConvertToken(bodyuserEmail);
                bodypropCount++;
                body["addressType"] = SourceExpressionConverter.Convert(bodyaddressType);
                if (bodystreet != null)
                {
                    body["street"] = SourceExpressionConverter.ConvertToken(bodystreet);
                    bodypropCount++;
                }

                if (bodysuiteUnitNumber != null)
                {
                    body["suiteUnitNumber"] = SourceExpressionConverter.ConvertToken(bodysuiteUnitNumber);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zipCode"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountryName != null)
                {
                    body["countryName"] = SourceExpressionConverter.ConvertToken(bodycountryName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactFamily([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodycontactEmail, [WorkflowExpression] Func<string> bodyuserEmail, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<bodyrelationshipInput> bodyrelationship, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodybirthDate = null, [WorkflowExpression] Func<int> bodybirthMonth = null, [WorkflowExpression] Func<int> bodybirthYear = null, [WorkflowExpression] Func<string> bodycountryName = null)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: true);
            SourceExpression.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            SourceExpression.Validate(bodyrelationship, nameof(bodyrelationship), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodybirthDate, nameof(bodybirthDate), required: false);
            SourceExpression.Validate(bodybirthMonth, nameof(bodybirthMonth), required: false);
            SourceExpression.Validate(bodybirthYear, nameof(bodybirthYear), required: false);
            SourceExpression.Validate(bodycountryName, nameof(bodycountryName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactFamilyExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["contactEmail"] = SourceExpressionConverter.ConvertToken(bodycontactEmail);
                bodypropCount++;
                body["userEmail"] = SourceExpressionConverter.ConvertToken(bodyuserEmail);
                bodypropCount++;
                body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["relationship"] = SourceExpressionConverter.Convert(bodyrelationship);
                if (bodybirthDate != null)
                {
                    body["birthDate"] = SourceExpressionConverter.ConvertToken(bodybirthDate);
                    bodypropCount++;
                }

                if (bodybirthMonth != null)
                {
                    body["birthMonth"] = SourceExpressionConverter.ConvertToken(bodybirthMonth);
                    bodypropCount++;
                }

                if (bodybirthYear != null)
                {
                    body["birthYear"] = SourceExpressionConverter.ConvertToken(bodybirthYear);
                    bodypropCount++;
                }

                if (bodycountryName != null)
                {
                    body["countryName"] = SourceExpressionConverter.ConvertToken(bodycountryName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetContactFolderDetailsResponse> GetContactFolderDetails([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> userEmail, [WorkflowExpression] Func<string> contactEmail)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(userEmail, nameof(userEmail), required: true);
            SourceExpression.Validate(contactEmail, nameof(contactEmail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalContact/GetContactFolderDetailExternal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["UserEmail"] = SourceExpressionConverter.ConvertO(userEmail);
                callPayload.Queries["ContactEmail"] = SourceExpressionConverter.ConvertO(contactEmail);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactFolderDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetCompanyDetailExternalResponse> GetCompanyDetailExternal([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<matchByInput> matchBy, [WorkflowExpression] Func<string> matchValue)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(matchBy, nameof(matchBy), required: true);
            SourceExpression.Validate(matchValue, nameof(matchValue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalCompany/GetCompanyDetailExternal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["MatchBy"] = SourceExpressionConverter.Convert(matchBy);
                callPayload.Queries["MatchValue"] = SourceExpressionConverter.ConvertO(matchValue);
                return callPayload;
            }

            return new ApiConnectionAction<GetCompanyDetailExternalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetTaskByResourceExtResponse> GetTaskByResourceExt([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> resourceAppId)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(resourceAppId, nameof(resourceAppId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetTaskByResourceExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["ResourceAppID"] = SourceExpressionConverter.ConvertO(resourceAppId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskByResourceExtResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateTaskCommentExtResponse> CreateTaskCommentExt([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyuserEmail, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodycomment)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodyuserEmail, nameof(bodyuserEmail), required: true);
            SourceExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateTaskCommentExt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["userEmail"] = SourceExpressionConverter.ConvertToken(bodyuserEmail);
                bodypropCount++;
                body["taskId"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                bodypropCount++;
                body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTaskCommentExtResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<UpdateProjectResponse> UpdateProject([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodyprojectName, [WorkflowExpression] Func<string> bodycurrentUserEmail, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<bool> bodyisPrivate = null, [WorkflowExpression] Func<string> bodyreferenceId = null, [WorkflowExpression] Func<string> bodyreferenceData = null, [WorkflowExpression] Func<string> bodyreferenceSource = null)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            SourceExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: true);
            SourceExpression.Validate(bodycurrentUserEmail, nameof(bodycurrentUserEmail), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            SourceExpression.Validate(bodyreferenceId, nameof(bodyreferenceId), required: false);
            SourceExpression.Validate(bodyreferenceData, nameof(bodyreferenceData), required: false);
            SourceExpression.Validate(bodyreferenceSource, nameof(bodyreferenceSource), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/UpdateProjectExt";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                bodypropCount++;
                body["projectName"] = SourceExpressionConverter.ConvertToken(bodyprojectName);
                bodypropCount++;
                body["currentUserEmail"] = SourceExpressionConverter.ConvertToken(bodycurrentUserEmail);
                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    if (bodystatus != null)
                    {
                        body["status"] = SourceExpressionConverter.Convert(bodystatus);
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
                        body["isPrivate"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
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
                    body["referenceId"] = SourceExpressionConverter.ConvertToken(bodyreferenceId);
                    bodypropCount++;
                }

                if (bodyreferenceData != null)
                {
                    body["referenceData"] = SourceExpressionConverter.ConvertToken(bodyreferenceData);
                    bodypropCount++;
                }

                if (bodyreferenceSource != null)
                {
                    body["referenceSource"] = SourceExpressionConverter.ConvertToken(bodyreferenceSource);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetTaskExtResponse> GetTaskExt([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<getByInput> getBy, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> source = null)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(getBy, nameof(getBy), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(source, nameof(source), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetTaskExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["GetBy"] = SourceExpressionConverter.Convert(getBy);
                callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (source != null)
                    callPayload.Queries["Source"] = SourceExpressionConverter.ConvertO(source);
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskExtResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectExtResponse> GetProjectExt([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<getByInput> getBy, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> source = null)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(getBy, nameof(getBy), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(source, nameof(source), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["GetBy"] = SourceExpressionConverter.Convert(getBy);
                callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (source != null)
                    callPayload.Queries["Source"] = SourceExpressionConverter.ConvertO(source);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectExtResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectTemplatesExtResponse> GetProjectTemplatesExt([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> userEmail)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(userEmail, nameof(userEmail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectTemplatesExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["UserEmail"] = SourceExpressionConverter.ConvertO(userEmail);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectTemplatesExtResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectRolesExtResponse> GetProjectRolesExt([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> userEmail, [WorkflowExpression] Func<roleTypeInput> roleType = null)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(userEmail, nameof(userEmail), required: true);
            SourceExpression.Validate(roleType, nameof(roleType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectRolesExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["UserEmail"] = SourceExpressionConverter.ConvertO(userEmail);
                if (roleType != null)
                    callPayload.Queries["RoleType"] = SourceExpressionConverter.Convert(roleType);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectRolesExtResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateProjectFromTemplateExtResponse> CreateProjectFromTemplateExt([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodycreatorEmail, [WorkflowExpression] Func<string> bodyprojectName, [WorkflowExpression] Func<bool> bodyisPrivate, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyclientName = null, [WorkflowExpression] Func<bodymembersInputItem[]> bodymembers = null, [WorkflowExpression] Func<bodyfilesLinksInputItem[]> bodyfilesLinks = null)
        {
            SourceExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            SourceExpression.Validate(bodycreatorEmail, nameof(bodycreatorEmail), required: true);
            SourceExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: true);
            SourceExpression.Validate(bodyisPrivate, nameof(bodyisPrivate), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyclientName, nameof(bodyclientName), required: false);
            SourceExpression.Validate(bodymembers, nameof(bodymembers), required: false);
            SourceExpression.Validate(bodyfilesLinks, nameof(bodyfilesLinks), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateProjectFromTemplateExt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["apiKey"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                bodypropCount++;
                body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                bodypropCount++;
                body["creatorEmail"] = SourceExpressionConverter.ConvertToken(bodycreatorEmail);
                bodypropCount++;
                body["projectName"] = SourceExpressionConverter.ConvertToken(bodyprojectName);
                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyclientName != null)
                {
                    body["clientName"] = SourceExpressionConverter.ConvertToken(bodyclientName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["isPrivate"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
                if (bodymembers != null)
                {
                    body["members"] = SourceExpressionConverter.ConvertToken(bodymembers);
                    bodypropCount++;
                }

                if (bodyfilesLinks != null)
                {
                    body["filesLinks"] = SourceExpressionConverter.ConvertToken(bodyfilesLinks);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateProjectFromTemplateExtResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<DeletetaskResponse> Deletetask([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> taskId)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/services/app/ExternalTask/DeleteExternalTask";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["TaskID"] = SourceExpressionConverter.ConvertO(taskId);
                return callPayload;
            }

            return new ApiConnectionAction<DeletetaskResponse>(BuildSourceInput);
        }
    }

    public class VineforceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenTaskIsCompletedResponse> WhenTaskIsCompleted([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<int> duration, [WorkflowExpression] Func<string> projectName = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> assigneeEmail = null, [WorkflowExpression] Func<string> creatorEmail = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(duration, nameof(duration), required: true);
            SourceExpression.Validate(projectName, nameof(projectName), required: false);
            SourceExpression.Validate(projectId, nameof(projectId), required: false);
            SourceExpression.Validate(assigneeEmail, nameof(assigneeEmail), required: false);
            SourceExpression.Validate(creatorEmail, nameof(creatorEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/GetRecentCompletedTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                if (projectName != null)
                    callPayload.Queries["ProjectName"] = SourceExpressionConverter.ConvertO(projectName);
                if (projectId != null)
                    callPayload.Queries["ProjectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = SourceExpressionConverter.ConvertO(assigneeEmail);
                if (creatorEmail != null)
                    callPayload.Queries["CreatorEmail"] = SourceExpressionConverter.ConvertO(creatorEmail);
                callPayload.Queries["Duration"] = SourceExpressionConverter.ConvertO(duration);
                return callPayload;
            }

            return new ApiConnectionTrigger<WhenTaskIsCompletedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WhenTaskSectionIsChangedResponse> WhenTaskSectionIsChanged([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> userEmail, [WorkflowExpression] Func<string> projectName = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> assigneeEmail = null, [WorkflowExpression] Func<string> taskId = null, [WorkflowExpression] Func<string> oldSectionId = null, [WorkflowExpression] Func<string> oldSectoinName = null, [WorkflowExpression] Func<string> newSectionId = null, [WorkflowExpression] Func<string> newSectoinName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(userEmail, nameof(userEmail), required: true);
            SourceExpression.Validate(projectName, nameof(projectName), required: false);
            SourceExpression.Validate(projectId, nameof(projectId), required: false);
            SourceExpression.Validate(assigneeEmail, nameof(assigneeEmail), required: false);
            SourceExpression.Validate(taskId, nameof(taskId), required: false);
            SourceExpression.Validate(oldSectionId, nameof(oldSectionId), required: false);
            SourceExpression.Validate(oldSectoinName, nameof(oldSectoinName), required: false);
            SourceExpression.Validate(newSectionId, nameof(newSectionId), required: false);
            SourceExpression.Validate(newSectoinName, nameof(newSectoinName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/GetRecentModifiedSectionTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["UserEmail"] = SourceExpressionConverter.ConvertO(userEmail);
                if (projectName != null)
                    callPayload.Queries["ProjectName"] = SourceExpressionConverter.ConvertO(projectName);
                if (projectId != null)
                    callPayload.Queries["ProjectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = SourceExpressionConverter.ConvertO(assigneeEmail);
                if (taskId != null)
                    callPayload.Queries["TaskId"] = SourceExpressionConverter.ConvertO(taskId);
                if (oldSectionId != null)
                    callPayload.Queries["OldSectionId"] = SourceExpressionConverter.ConvertO(oldSectionId);
                if (oldSectoinName != null)
                    callPayload.Queries["OldSectoinName"] = SourceExpressionConverter.ConvertO(oldSectoinName);
                if (newSectionId != null)
                    callPayload.Queries["NewSectionId"] = SourceExpressionConverter.ConvertO(newSectionId);
                if (newSectoinName != null)
                    callPayload.Queries["NewSectoinName"] = SourceExpressionConverter.ConvertO(newSectoinName);
                return callPayload;
            }

            return new ApiConnectionTrigger<WhenTaskSectionIsChangedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WhenTaskIsCreatedResponse> WhenTaskIsCreated([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<int> duration, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(duration, nameof(duration), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/GetRecentlyCreatedTask";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["Duration"] = SourceExpressionConverter.ConvertO(duration);
                return callPayload;
            }

            return new ApiConnectionTrigger<WhenTaskIsCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WhenTaskIsUpdatedResponse> WhenTaskIsUpdated([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<int> duration, [WorkflowExpression] Func<string> updateFilter = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(duration, nameof(duration), required: true);
            SourceExpression.Validate(updateFilter, nameof(updateFilter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/GetRecentlyUpdatedTask";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                if (updateFilter != null)
                    callPayload.Queries["UpdateFilter"] = SourceExpressionConverter.ConvertO(updateFilter);
                callPayload.Queries["Duration"] = SourceExpressionConverter.ConvertO(duration);
                return callPayload;
            }

            return new ApiConnectionTrigger<WhenTaskIsUpdatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WhenTaskIsDeletedResponse> WhenTaskIsDeleted([WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<int> duration, [WorkflowExpression] Func<string> projectName = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> assigneeEmail = null, [WorkflowExpression] Func<string> creatorEmail = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(duration, nameof(duration), required: true);
            SourceExpression.Validate(projectName, nameof(projectName), required: false);
            SourceExpression.Validate(projectId, nameof(projectId), required: false);
            SourceExpression.Validate(assigneeEmail, nameof(assigneeEmail), required: false);
            SourceExpression.Validate(creatorEmail, nameof(creatorEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/GetRecentlyDeletedTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = SourceExpressionConverter.ConvertO(apiKey);
                if (projectName != null)
                    callPayload.Queries["ProjectName"] = SourceExpressionConverter.ConvertO(projectName);
                if (projectId != null)
                    callPayload.Queries["ProjectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = SourceExpressionConverter.ConvertO(assigneeEmail);
                if (creatorEmail != null)
                    callPayload.Queries["CreatorEmail"] = SourceExpressionConverter.ConvertO(creatorEmail);
                callPayload.Queries["Duration"] = SourceExpressionConverter.ConvertO(duration);
                return callPayload;
            }

            return new ApiConnectionTrigger<WhenTaskIsDeletedResponse>(BuildSourceInput, triggerName, recurrence);
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

    public class bodyfilesInputItem22
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

    public class bodyfilesInputItem2222
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
        TaxId,
        [EnumMember(Value = "Company ID")]
        CompanyId,
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