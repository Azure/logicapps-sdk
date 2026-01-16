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
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyfromEmail = null, Expression<Func<string>> bodytoEmail = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bodypriorityTextInput>> bodypriorityText = null, Expression<Func<string>> bodyassociatedContactEmail = null, Expression<Func<bodyresourceAppNameInput>> bodyresourceAppName = null, Expression<Func<string>> bodyresourceAppUrl = null, Expression<Func<string>> bodyresourceAppID = null, Expression<Func<string>> bodyresourceAppData = null, Expression<Func<string>> bodyreferenceId = null, Expression<Func<string>> bodyreferenceData = null, Expression<Func<string>> bodyreferenceSource = null, Expression<Func<string>> bodyprojectName = null, Expression<Func<string>> bodyprojectSectionName = null, Expression<Func<string>> bodyprojectTags = null, Expression<Func<bodychecklistsInputItem[]>> bodychecklists = null, Expression<Func<bodyfilesInputItem[]>> bodyfiles = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<AlertResponse> Alert(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyalertToEmail, Expression<Func<string>> bodytitle, Expression<Func<string>> bodymessage, Expression<Func<bodyresourceNameInput>> bodyresourceName = null, Expression<Func<string>> bodyResourceUrl = null)
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

            if (bodyResourceUrl != null)
            {
                body["ResourceUrl"] = ExpressionConverter.ConvertO(bodyResourceUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AlertResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject(Expression<Func<string>> bodyprojectName, Expression<Func<string>> bodycreatorEmail, Expression<Func<string>> bodyapiKey, Expression<Func<bodyfilesInputItem2[]>> bodyfiles, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bool>> bodyisPrivate = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodymembers = null, Expression<Func<string>> bodysections = null, Expression<Func<string>> bodyreferenceId = null, Expression<Func<string>> bodyreferenceData = null, Expression<Func<string>> bodyreferenceSource = null)
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
                body["isPrivate"] = ExpressionConverter.ConvertO(bodyisPrivate);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodytaskID, Expression<Func<string>> bodytoEmail, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyfromEmail = null, Expression<Func<bodyTaskStatusInput>> bodyTaskStatus = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bodypriorityTextInput>> bodypriorityText = null, Expression<Func<string>> bodyassociatedContactEmail = null, Expression<Func<bodyresourceAppNameInput>> bodyresourceAppName = null, Expression<Func<string>> bodyresourceAppUrl = null, Expression<Func<string>> bodyresourceAppID = null, Expression<Func<string>> bodyresourceAppData = null, Expression<Func<string>> bodyreferenceId = null, Expression<Func<string>> bodyreferenceData = null, Expression<Func<string>> bodyreferenceSource = null, Expression<Func<string>> bodyprojectName = null, Expression<Func<string>> bodyprojectSectionName = null, Expression<Func<string>> bodyprojectTags = null, Expression<Func<bodychecklistsInputItem[]>> bodychecklists = null, Expression<Func<bodyfilesInputItem22[]>> bodyfiles = null)
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
            if (bodyTaskStatus != null)
            {
                body["TaskStatus"] = ExpressionConverter.ConvertO(bodyTaskStatus);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactNote(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyownerEmail, Expression<Func<string>> bodycontactEmail, Expression<Func<string>> bodynotes)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateCompany(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodycompanyName, Expression<Func<string>> bodyuserEmail, Expression<Func<string>> bodystreet = null, Expression<Func<string>> bodysuiteUnitNumber = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodycountryName = null, Expression<Func<string>> bodytaxId = null, Expression<Func<string>> bodysiteUrl = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyownerEmailAddress, Expression<Func<string>> bodycontactEmailAddress1, Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodycontactEmailAddress2 = null, Expression<Func<string>> bodycontactEmailAddress3 = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodybirthDay = null, Expression<Func<int>> bodybirthMonth = null, Expression<Func<int>> bodybirthYear = null, Expression<Func<string>> bodycontactType = null, Expression<Func<string>> bodycompanyID1 = null, Expression<Func<string>> bodycompanyID2 = null, Expression<Func<string>> bodycompanyID3 = null, Expression<Func<string>> bodyaccountNumber = null, Expression<Func<string>> bodysocialSecurityNumber = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactPhone(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodycontactEmail, Expression<Func<string>> bodyuserEmail, Expression<Func<string>> bodyphone, Expression<Func<bodyphoneTypeInput>> bodyphoneType, Expression<Func<string>> bodyextension = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactAddress(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodycontactEmail, Expression<Func<string>> bodyuserEmail, Expression<Func<bodyaddressTypeInput>> bodyaddressType, Expression<Func<string>> bodystreet = null, Expression<Func<string>> bodysuiteUnitNumber = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycountryName = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction CreateContactFamily(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodycontactEmail, Expression<Func<string>> bodyuserEmail, Expression<Func<string>> bodyfirstName, Expression<Func<bodyrelationshipInput>> bodyrelationship, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodybirthDate = null, Expression<Func<int>> bodybirthMonth = null, Expression<Func<int>> bodybirthYear = null, Expression<Func<string>> bodycountryName = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetContactFolderDetailsResponse> GetContactFolderDetails(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail, Expression<Func<string>> contactEmail)
        {
            var apiCallPath = "/api/services/app/ExternalContact/GetContactFolderDetailExternal";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
            callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(userEmail);
            callPayload.Queries["ContactEmail"] = ExpressionConverter.Convert(contactEmail);
            return new ApiConnectionAction<GetContactFolderDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetCompanyDetailExternalResponse> GetCompanyDetailExternal(Expression<Func<string>> apiKey, Expression<Func<matchByInput>> matchBy, Expression<Func<string>> matchValue)
        {
            var apiCallPath = "/api/services/app/ExternalCompany/GetCompanyDetailExternal";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
            callPayload.Queries["MatchBy"] = ExpressionConverter.Convert(matchBy);
            callPayload.Queries["MatchValue"] = ExpressionConverter.Convert(matchValue);
            return new ApiConnectionAction<GetCompanyDetailExternalResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetTaskByResourceExtResponse> GetTaskByResourceExt(Expression<Func<string>> apiKey, Expression<Func<string>> resourceAppID)
        {
            var apiCallPath = "/api/services/app/ExternalTask/GetTaskByResourceExt";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
            callPayload.Queries["ResourceAppID"] = ExpressionConverter.Convert(resourceAppID);
            return new ApiConnectionAction<GetTaskByResourceExtResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateTaskCommentExtResponse> CreateTaskCommentExt(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyuserEmail, Expression<Func<string>> bodytaskId, Expression<Func<string>> bodycomment)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<UpdateProjectResponse> UpdateProject(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyprojectId, Expression<Func<string>> bodyprojectName, Expression<Func<string>> bodycurrentUserEmail, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bool>> bodyisPrivate = null, Expression<Func<string>> bodyreferenceId = null, Expression<Func<string>> bodyreferenceData = null, Expression<Func<string>> bodyreferenceSource = null)
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
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyisPrivate != null)
            {
                body["isPrivate"] = ExpressionConverter.ConvertO(bodyisPrivate);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetTaskExtResponse> GetTaskExt(Expression<Func<string>> apiKey, Expression<Func<getByInput>> getBy, Expression<Func<string>> id, Expression<Func<string>> source = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectExtResponse> GetProjectExt(Expression<Func<string>> apiKey, Expression<Func<getByInput>> getBy, Expression<Func<string>> id, Expression<Func<string>> source = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectTemplatesExtResponse> GetProjectTemplatesExt(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail)
        {
            var apiCallPath = "/api/services/app/ExternalTask/GetProjectTemplatesExt";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
            callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(userEmail);
            return new ApiConnectionAction<GetProjectTemplatesExtResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectRolesExtResponse> GetProjectRolesExt(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail, Expression<Func<roleTypeInput>> roleType = null)
        {
            var apiCallPath = "/api/services/app/ExternalTask/GetProjectRolesExt";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
            callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(userEmail);
            if (roleType != null)
                callPayload.Queries["RoleType"] = ExpressionConverter.Convert(roleType);
            return new ApiConnectionAction<GetProjectRolesExtResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateProjectFromTemplateExtResponse> CreateProjectFromTemplateExt(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodycreatorEmail, Expression<Func<string>> bodyprojectName, Expression<Func<bool>> bodyisPrivate, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyclientName = null, Expression<Func<bodymembersInputItem[]>> bodymembers = null, Expression<Func<bodyfilesLinksInputItem[]>> bodyfilesLinks = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<DeletetaskResponse> Deletetask(Expression<Func<string>> apiKey, Expression<Func<string>> taskID)
        {
            var apiCallPath = "/api/services/app/ExternalTask/DeleteExternalTask";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
            callPayload.Queries["TaskID"] = ExpressionConverter.Convert(taskID);
            return new ApiConnectionAction<DeletetaskResponse>(callPayload);
        }
    }

    public class VineforceTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<WhenTaskIsCompletedResponse> WhenTaskIsCompleted(Expression<Func<string>> apiKey, Expression<Func<int>> duration, Expression<Func<string>> projectName = null, Expression<Func<string>> projectId = null, Expression<Func<string>> assigneeEmail = null, Expression<Func<string>> creatorEmail = null)
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
            return new ApiConnectionTrigger<WhenTaskIsCompletedResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WhenTaskSectionIsChangedResponse> WhenTaskSectionIsChanged(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail, Expression<Func<string>> projectName = null, Expression<Func<string>> projectId = null, Expression<Func<string>> assigneeEmail = null, Expression<Func<string>> taskId = null, Expression<Func<string>> oldSectionId = null, Expression<Func<string>> oldSectoinName = null, Expression<Func<string>> newSectionId = null, Expression<Func<string>> newSectoinName = null)
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
            return new ApiConnectionTrigger<WhenTaskSectionIsChangedResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WhenTaskIsCreatedResponse> WhenTaskIsCreated(Expression<Func<string>> apiKey, Expression<Func<int>> duration)
        {
            var apiCallPath = "/trigger/api/GetRecentlyCreatedTask";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
            callPayload.Queries["Duration"] = ExpressionConverter.Convert(duration);
            return new ApiConnectionTrigger<WhenTaskIsCreatedResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WhenTaskIsUpdatedResponse> WhenTaskIsUpdated(Expression<Func<string>> apiKey, Expression<Func<int>> duration, Expression<Func<string>> updateFilter = null)
        {
            var apiCallPath = "/trigger/api/GetRecentlyUpdatedTask";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(apiKey);
            if (updateFilter != null)
                callPayload.Queries["UpdateFilter"] = ExpressionConverter.Convert(updateFilter);
            callPayload.Queries["Duration"] = ExpressionConverter.Convert(duration);
            return new ApiConnectionTrigger<WhenTaskIsUpdatedResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WhenTaskIsDeletedResponse> WhenTaskIsDeleted(Expression<Func<string>> apiKey, Expression<Func<int>> duration, Expression<Func<string>> projectName = null, Expression<Func<string>> projectId = null, Expression<Func<string>> assigneeEmail = null, Expression<Func<string>> creatorEmail = null)
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
            return new ApiConnectionTrigger<WhenTaskIsDeletedResponse>(callPayload);
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

    public enum bodyTaskStatusInput
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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