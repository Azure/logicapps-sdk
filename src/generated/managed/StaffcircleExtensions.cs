//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Staffcircle
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StaffcircleActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<GetPersonResponse> GetPerson(Expression<Func<string>> searchEmail)
        {
            var __workflow_searchEmail = WorkflowExpression.Compile(searchEmail, nameof(searchEmail), required: true);
            return new DeferredBodyAction<GetPersonResponse>(() =>
            {
                var apiCallPath = "/public/directory/v1/persons";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SearchEmail"] = ExpressionConverter.Convert(__workflow_searchEmail);
                return new ApiConnectionAction<GetPersonResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreatePersonResponse> CreatePerson(Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodysecondName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodymobile, Expression<Func<string>> bodydateOfBirth, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodytown = null, Expression<Func<string>> bodypostCode = null, Expression<Func<string>> bodycountyName = null, Expression<Func<string>> bodycountryName = null, Expression<Func<string>> bodytitleName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyhomeEmail = null, Expression<Func<string>> bodyhomeTelephone = null, Expression<Func<string>> bodytag = null, Expression<Func<string>> bodymanagerEmail = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<string>> bodyroleName = null, Expression<Func<string>> bodyknownAs = null, Expression<Func<string>> bodyavatarURL = null, Expression<Func<int>> bodytitleId = null, Expression<Func<int>> bodycountyId = null, Expression<Func<int>> bodycountryId = null, Expression<Func<int>> bodygenderId = null, Expression<Func<int>> bodynationalityId = null, Expression<Func<int>> bodyethnicityId = null, Expression<Func<int>> bodymaritalStatusId = null, Expression<Func<int>> bodymanagerId = null, Expression<Func<int>> bodydepartmentId = null, Expression<Func<int>> bodyroleId = null, Expression<Func<int>> bodymainSiteId = null, Expression<Func<bool>> bodyemergencyContactConsent = null, Expression<Func<string>> bodyemergencyContactName = null, Expression<Func<int>> bodyemergencyRelationshipId = null, Expression<Func<string>> bodyemergencyContactTelephone = null, Expression<Func<string>> bodyemergencyAddress = null, Expression<Func<string>> bodynextOfKinName = null, Expression<Func<int>> bodynextOfKinRelationshipId = null, Expression<Func<string>> bodynextOfKinTelephone = null, Expression<Func<string>> bodydialingCode = null, Expression<Func<string>> bodyworkExtension = null, Expression<Func<string>> bodytelephone = null, Expression<Func<string>> bodypersonalMobile = null, Expression<Func<int>> bodystatusId = null, Expression<Func<int>> bodyemploymentTypeId = null, Expression<Func<int>> bodycontractTypeId = null, Expression<Func<string>> bodycontractExpiry = null, Expression<Func<int>> bodyemploymentStatusId = null, Expression<Func<int>> bodysecondaryEmploymentStatusId = null, Expression<Func<string>> bodyemploymentNotes = null, Expression<Func<string>> bodymedicalNotes = null, Expression<Func<bool>> bodyisPersonalDataEnabled = null, Expression<Func<bool>> bodyisContactDataEnabled = null, Expression<Func<bodytimeZoneInput>> bodytimeZone = null)
        {
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodysecondName = WorkflowExpression.Compile(bodysecondName, nameof(bodysecondName), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodymobile = WorkflowExpression.Compile(bodymobile, nameof(bodymobile), required: true);
            var __workflow_bodydateOfBirth = WorkflowExpression.Compile(bodydateOfBirth, nameof(bodydateOfBirth), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodyaddressLine1 = WorkflowExpression.Compile(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            var __workflow_bodyaddressLine2 = WorkflowExpression.Compile(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            var __workflow_bodytown = WorkflowExpression.Compile(bodytown, nameof(bodytown), required: false);
            var __workflow_bodypostCode = WorkflowExpression.Compile(bodypostCode, nameof(bodypostCode), required: false);
            var __workflow_bodycountyName = WorkflowExpression.Compile(bodycountyName, nameof(bodycountyName), required: false);
            var __workflow_bodycountryName = WorkflowExpression.Compile(bodycountryName, nameof(bodycountryName), required: false);
            var __workflow_bodytitleName = WorkflowExpression.Compile(bodytitleName, nameof(bodytitleName), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodyhomeEmail = WorkflowExpression.Compile(bodyhomeEmail, nameof(bodyhomeEmail), required: false);
            var __workflow_bodyhomeTelephone = WorkflowExpression.Compile(bodyhomeTelephone, nameof(bodyhomeTelephone), required: false);
            var __workflow_bodytag = WorkflowExpression.Compile(bodytag, nameof(bodytag), required: false);
            var __workflow_bodymanagerEmail = WorkflowExpression.Compile(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            var __workflow_bodydepartmentName = WorkflowExpression.Compile(bodydepartmentName, nameof(bodydepartmentName), required: false);
            var __workflow_bodyroleName = WorkflowExpression.Compile(bodyroleName, nameof(bodyroleName), required: false);
            var __workflow_bodyknownAs = WorkflowExpression.Compile(bodyknownAs, nameof(bodyknownAs), required: false);
            var __workflow_bodyavatarURL = WorkflowExpression.Compile(bodyavatarURL, nameof(bodyavatarURL), required: false);
            var __workflow_bodytitleId = WorkflowExpression.Compile(bodytitleId, nameof(bodytitleId), required: false);
            var __workflow_bodycountyId = WorkflowExpression.Compile(bodycountyId, nameof(bodycountyId), required: false);
            var __workflow_bodycountryId = WorkflowExpression.Compile(bodycountryId, nameof(bodycountryId), required: false);
            var __workflow_bodygenderId = WorkflowExpression.Compile(bodygenderId, nameof(bodygenderId), required: false);
            var __workflow_bodynationalityId = WorkflowExpression.Compile(bodynationalityId, nameof(bodynationalityId), required: false);
            var __workflow_bodyethnicityId = WorkflowExpression.Compile(bodyethnicityId, nameof(bodyethnicityId), required: false);
            var __workflow_bodymaritalStatusId = WorkflowExpression.Compile(bodymaritalStatusId, nameof(bodymaritalStatusId), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodyroleId = WorkflowExpression.Compile(bodyroleId, nameof(bodyroleId), required: false);
            var __workflow_bodymainSiteId = WorkflowExpression.Compile(bodymainSiteId, nameof(bodymainSiteId), required: false);
            var __workflow_bodyemergencyContactConsent = WorkflowExpression.Compile(bodyemergencyContactConsent, nameof(bodyemergencyContactConsent), required: false);
            var __workflow_bodyemergencyContactName = WorkflowExpression.Compile(bodyemergencyContactName, nameof(bodyemergencyContactName), required: false);
            var __workflow_bodyemergencyRelationshipId = WorkflowExpression.Compile(bodyemergencyRelationshipId, nameof(bodyemergencyRelationshipId), required: false);
            var __workflow_bodyemergencyContactTelephone = WorkflowExpression.Compile(bodyemergencyContactTelephone, nameof(bodyemergencyContactTelephone), required: false);
            var __workflow_bodyemergencyAddress = WorkflowExpression.Compile(bodyemergencyAddress, nameof(bodyemergencyAddress), required: false);
            var __workflow_bodynextOfKinName = WorkflowExpression.Compile(bodynextOfKinName, nameof(bodynextOfKinName), required: false);
            var __workflow_bodynextOfKinRelationshipId = WorkflowExpression.Compile(bodynextOfKinRelationshipId, nameof(bodynextOfKinRelationshipId), required: false);
            var __workflow_bodynextOfKinTelephone = WorkflowExpression.Compile(bodynextOfKinTelephone, nameof(bodynextOfKinTelephone), required: false);
            var __workflow_bodydialingCode = WorkflowExpression.Compile(bodydialingCode, nameof(bodydialingCode), required: false);
            var __workflow_bodyworkExtension = WorkflowExpression.Compile(bodyworkExtension, nameof(bodyworkExtension), required: false);
            var __workflow_bodytelephone = WorkflowExpression.Compile(bodytelephone, nameof(bodytelephone), required: false);
            var __workflow_bodypersonalMobile = WorkflowExpression.Compile(bodypersonalMobile, nameof(bodypersonalMobile), required: false);
            var __workflow_bodystatusId = WorkflowExpression.Compile(bodystatusId, nameof(bodystatusId), required: false);
            var __workflow_bodyemploymentTypeId = WorkflowExpression.Compile(bodyemploymentTypeId, nameof(bodyemploymentTypeId), required: false);
            var __workflow_bodycontractTypeId = WorkflowExpression.Compile(bodycontractTypeId, nameof(bodycontractTypeId), required: false);
            var __workflow_bodycontractExpiry = WorkflowExpression.Compile(bodycontractExpiry, nameof(bodycontractExpiry), required: false);
            var __workflow_bodyemploymentStatusId = WorkflowExpression.Compile(bodyemploymentStatusId, nameof(bodyemploymentStatusId), required: false);
            var __workflow_bodysecondaryEmploymentStatusId = WorkflowExpression.Compile(bodysecondaryEmploymentStatusId, nameof(bodysecondaryEmploymentStatusId), required: false);
            var __workflow_bodyemploymentNotes = WorkflowExpression.Compile(bodyemploymentNotes, nameof(bodyemploymentNotes), required: false);
            var __workflow_bodymedicalNotes = WorkflowExpression.Compile(bodymedicalNotes, nameof(bodymedicalNotes), required: false);
            var __workflow_bodyisPersonalDataEnabled = WorkflowExpression.Compile(bodyisPersonalDataEnabled, nameof(bodyisPersonalDataEnabled), required: false);
            var __workflow_bodyisContactDataEnabled = WorkflowExpression.Compile(bodyisContactDataEnabled, nameof(bodyisContactDataEnabled), required: false);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: false);
            return new DeferredBodyAction<CreatePersonResponse>(() =>
            {
                var apiCallPath = "/public/directory/v1/persons";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                bodypropCount++;
                body["secondName"] = ExpressionConverter.ConvertO(__workflow_bodysecondName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["mobile"] = ExpressionConverter.ConvertO(__workflow_bodymobile);
                bodypropCount++;
                body["dateOfBirth"] = ExpressionConverter.ConvertO(__workflow_bodydateOfBirth);
                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                if (__workflow_bodyaddressLine1 != null)
                {
                    body["addressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine2 != null)
                {
                    body["addressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodytown != null)
                {
                    body["town"] = ExpressionConverter.ConvertO(__workflow_bodytown);
                    bodypropCount++;
                }

                if (__workflow_bodypostCode != null)
                {
                    body["postCode"] = ExpressionConverter.ConvertO(__workflow_bodypostCode);
                    bodypropCount++;
                }

                if (__workflow_bodycountyName != null)
                {
                    body["countyName"] = ExpressionConverter.ConvertO(__workflow_bodycountyName);
                    bodypropCount++;
                }

                if (__workflow_bodycountryName != null)
                {
                    body["countryName"] = ExpressionConverter.ConvertO(__workflow_bodycountryName);
                    bodypropCount++;
                }

                if (__workflow_bodytitleName != null)
                {
                    body["titleName"] = ExpressionConverter.ConvertO(__workflow_bodytitleName);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middleName"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodyhomeEmail != null)
                {
                    body["homeEmail"] = ExpressionConverter.ConvertO(__workflow_bodyhomeEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyhomeTelephone != null)
                {
                    body["homeTelephone"] = ExpressionConverter.ConvertO(__workflow_bodyhomeTelephone);
                    bodypropCount++;
                }

                if (__workflow_bodytag != null)
                {
                    body["tag"] = ExpressionConverter.ConvertO(__workflow_bodytag);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerEmail != null)
                {
                    body["managerEmail"] = ExpressionConverter.ConvertO(__workflow_bodymanagerEmail);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentName != null)
                {
                    body["departmentName"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentName);
                    bodypropCount++;
                }

                if (__workflow_bodyroleName != null)
                {
                    body["roleName"] = ExpressionConverter.ConvertO(__workflow_bodyroleName);
                    bodypropCount++;
                }

                if (__workflow_bodyknownAs != null)
                {
                    body["knownAs"] = ExpressionConverter.ConvertO(__workflow_bodyknownAs);
                    bodypropCount++;
                }

                if (__workflow_bodyavatarURL != null)
                {
                    body["avatarURL"] = ExpressionConverter.ConvertO(__workflow_bodyavatarURL);
                    bodypropCount++;
                }

                if (__workflow_bodytitleId != null)
                {
                    body["titleId"] = ExpressionConverter.ConvertO(__workflow_bodytitleId);
                    bodypropCount++;
                }

                if (__workflow_bodycountyId != null)
                {
                    body["countyId"] = ExpressionConverter.ConvertO(__workflow_bodycountyId);
                    bodypropCount++;
                }

                if (__workflow_bodycountryId != null)
                {
                    body["countryId"] = ExpressionConverter.ConvertO(__workflow_bodycountryId);
                    bodypropCount++;
                }

                if (__workflow_bodygenderId != null)
                {
                    body["genderId"] = ExpressionConverter.ConvertO(__workflow_bodygenderId);
                    bodypropCount++;
                }

                if (__workflow_bodynationalityId != null)
                {
                    body["nationalityId"] = ExpressionConverter.ConvertO(__workflow_bodynationalityId);
                    bodypropCount++;
                }

                if (__workflow_bodyethnicityId != null)
                {
                    body["ethnicityId"] = ExpressionConverter.ConvertO(__workflow_bodyethnicityId);
                    bodypropCount++;
                }

                if (__workflow_bodymaritalStatusId != null)
                {
                    body["maritalStatusId"] = ExpressionConverter.ConvertO(__workflow_bodymaritalStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodyroleId != null)
                {
                    body["roleId"] = ExpressionConverter.ConvertO(__workflow_bodyroleId);
                    bodypropCount++;
                }

                if (__workflow_bodymainSiteId != null)
                {
                    body["mainSiteId"] = ExpressionConverter.ConvertO(__workflow_bodymainSiteId);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactConsent != null)
                {
                    body["emergencyContactConsent"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactConsent);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactName != null)
                {
                    body["emergencyContactName"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactName);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyRelationshipId != null)
                {
                    body["emergencyRelationshipId"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyRelationshipId);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactTelephone != null)
                {
                    body["emergencyContactTelephone"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactTelephone);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyAddress != null)
                {
                    body["emergencyAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyAddress);
                    bodypropCount++;
                }

                if (__workflow_bodynextOfKinName != null)
                {
                    body["nextOfKinName"] = ExpressionConverter.ConvertO(__workflow_bodynextOfKinName);
                    bodypropCount++;
                }

                if (__workflow_bodynextOfKinRelationshipId != null)
                {
                    body["nextOfKinRelationshipId"] = ExpressionConverter.ConvertO(__workflow_bodynextOfKinRelationshipId);
                    bodypropCount++;
                }

                if (__workflow_bodynextOfKinTelephone != null)
                {
                    body["nextOfKinTelephone"] = ExpressionConverter.ConvertO(__workflow_bodynextOfKinTelephone);
                    bodypropCount++;
                }

                if (__workflow_bodydialingCode != null)
                {
                    body["dialingCode"] = ExpressionConverter.ConvertO(__workflow_bodydialingCode);
                    bodypropCount++;
                }

                if (__workflow_bodyworkExtension != null)
                {
                    body["workExtension"] = ExpressionConverter.ConvertO(__workflow_bodyworkExtension);
                    bodypropCount++;
                }

                if (__workflow_bodytelephone != null)
                {
                    body["telephone"] = ExpressionConverter.ConvertO(__workflow_bodytelephone);
                    bodypropCount++;
                }

                if (__workflow_bodypersonalMobile != null)
                {
                    body["personalMobile"] = ExpressionConverter.ConvertO(__workflow_bodypersonalMobile);
                    bodypropCount++;
                }

                if (__workflow_bodystatusId != null)
                {
                    if (__workflow_bodystatusId != null)
                    {
                        body["statusId"] = ExpressionConverter.ConvertO(__workflow_bodystatusId);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["statusId"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodyemploymentTypeId != null)
                {
                    body["employmentTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodycontractTypeId != null)
                {
                    body["contractTypeId"] = ExpressionConverter.ConvertO(__workflow_bodycontractTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodycontractExpiry != null)
                {
                    body["contractExpiry"] = ExpressionConverter.ConvertO(__workflow_bodycontractExpiry);
                    bodypropCount++;
                }

                if (__workflow_bodyemploymentStatusId != null)
                {
                    body["employmentStatusId"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodysecondaryEmploymentStatusId != null)
                {
                    body["secondaryEmploymentStatusId"] = ExpressionConverter.ConvertO(__workflow_bodysecondaryEmploymentStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodyemploymentNotes != null)
                {
                    body["employmentNotes"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentNotes);
                    bodypropCount++;
                }

                if (__workflow_bodymedicalNotes != null)
                {
                    body["medicalNotes"] = ExpressionConverter.ConvertO(__workflow_bodymedicalNotes);
                    bodypropCount++;
                }

                if (__workflow_bodyisPersonalDataEnabled != null)
                {
                    body["isPersonalDataEnabled"] = ExpressionConverter.ConvertO(__workflow_bodyisPersonalDataEnabled);
                    bodypropCount++;
                }

                if (__workflow_bodyisContactDataEnabled != null)
                {
                    body["isContactDataEnabled"] = ExpressionConverter.ConvertO(__workflow_bodyisContactDataEnabled);
                    bodypropCount++;
                }

                if (__workflow_bodytimeZone != null)
                {
                    if (__workflow_bodytimeZone != null)
                    {
                        body["timeZone"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["timeZone"] = "(GMT+00:00) London";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreatePersonResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<GetObjectivesResponse> GetObjectives(Expression<Func<string>> searchTitle = null, Expression<Func<string>> personEmail = null, Expression<Func<string>> tag = null, Expression<Func<string>> closed = null, Expression<Func<objectiveTypeInput>> objectiveType = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<string>> activeAt = null)
        {
            var __workflow_searchTitle = WorkflowExpression.Compile(searchTitle, nameof(searchTitle), required: false);
            var __workflow_personEmail = WorkflowExpression.Compile(personEmail, nameof(personEmail), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_closed = WorkflowExpression.Compile(closed, nameof(closed), required: false);
            var __workflow_objectiveType = WorkflowExpression.Compile(objectiveType, nameof(objectiveType), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_activeAt = WorkflowExpression.Compile(activeAt, nameof(activeAt), required: false);
            return new DeferredBodyAction<GetObjectivesResponse>(() =>
            {
                var apiCallPath = "/public/Performance/v1/Objectives";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_searchTitle != null)
                    callPayload.Queries["SearchTitle"] = ExpressionConverter.Convert(__workflow_searchTitle);
                if (__workflow_personEmail != null)
                    callPayload.Queries["PersonEmail"] = ExpressionConverter.Convert(__workflow_personEmail);
                if (__workflow_tag != null)
                    callPayload.Queries["Tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_closed != null)
                    callPayload.Queries["Closed"] = ExpressionConverter.Convert(__workflow_closed);
                if (__workflow_objectiveType != null)
                    callPayload.Queries["ObjectiveType"] = ExpressionConverter.Convert(__workflow_objectiveType);
                if (__workflow_from != null)
                    callPayload.Queries["From"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["To"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_activeAt != null)
                    callPayload.Queries["ActiveAt"] = ExpressionConverter.Convert(__workflow_activeAt);
                return new ApiConnectionAction<GetObjectivesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateObjectiveByTemplateResponse> CreateObjectiveByTemplate(Expression<Func<int>> bodyobjectiveTemplateId, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyendDate, Expression<Func<string>> bodypersonEmail = null, Expression<Func<int>> bodypersonId = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<int>> bodydepartmentId = null, Expression<Func<string>> bodymanagerEmail = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodymanagerId = null, Expression<Func<int>> bodycompanyObjectiveId = null, Expression<Func<int>> bodydepartmentObjectiveId = null)
        {
            var __workflow_bodyobjectiveTemplateId = WorkflowExpression.Compile(bodyobjectiveTemplateId, nameof(bodyobjectiveTemplateId), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: true);
            var __workflow_bodypersonEmail = WorkflowExpression.Compile(bodypersonEmail, nameof(bodypersonEmail), required: false);
            var __workflow_bodypersonId = WorkflowExpression.Compile(bodypersonId, nameof(bodypersonId), required: false);
            var __workflow_bodydepartmentName = WorkflowExpression.Compile(bodydepartmentName, nameof(bodydepartmentName), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodymanagerEmail = WorkflowExpression.Compile(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodycompanyObjectiveId = WorkflowExpression.Compile(bodycompanyObjectiveId, nameof(bodycompanyObjectiveId), required: false);
            var __workflow_bodydepartmentObjectiveId = WorkflowExpression.Compile(bodydepartmentObjectiveId, nameof(bodydepartmentObjectiveId), required: false);
            return new DeferredBodyAction<CreateObjectiveByTemplateResponse>(() =>
            {
                var apiCallPath = "/public/Performance/v1/Objectives";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectiveTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodyobjectiveTemplateId);
                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                bodypropCount++;
                body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                if (__workflow_bodypersonEmail != null)
                {
                    body["personEmail"] = ExpressionConverter.ConvertO(__workflow_bodypersonEmail);
                    bodypropCount++;
                }

                if (__workflow_bodypersonId != null)
                {
                    body["personId"] = ExpressionConverter.ConvertO(__workflow_bodypersonId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentName != null)
                {
                    body["departmentName"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentName);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerEmail != null)
                {
                    body["managerEmail"] = ExpressionConverter.ConvertO(__workflow_bodymanagerEmail);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyObjectiveId != null)
                {
                    body["companyObjectiveId"] = ExpressionConverter.ConvertO(__workflow_bodycompanyObjectiveId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentObjectiveId != null)
                {
                    body["departmentObjectiveId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentObjectiveId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateObjectiveByTemplateResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateObjectiveResponse> CreateObjective(Expression<Func<int>> bodycategoryId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyendDate, Expression<Func<bodyvalueTypeInput>> bodyvalueType, Expression<Func<string>> bodytag = null, Expression<Func<string>> bodymanagerEmail = null, Expression<Func<int>> bodymanagerId = null, Expression<Func<string>> bodypersonEmail = null, Expression<Func<int>> bodypersonId = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<int>> bodydepartmentId = null, Expression<Func<int>> bodycompanyObjectiveId = null, Expression<Func<int>> bodydepartmentObjectiveId = null, Expression<Func<double>> bodystartValue = null, Expression<Func<double>> bodytarget = null, Expression<Func<bool>> bodyallowAddProgress = null, Expression<Func<bodyrecurTypeInput>> bodyrecurType = null, Expression<Func<int>> bodyrecurInterval = null, Expression<Func<bool>> bodycumulativeProgress = null, Expression<Func<bool>> bodycontentSettingspush = null, Expression<Func<bool>> bodycontentSettingssms = null, Expression<Func<bool>> bodycontentSettingsemail = null, Expression<Func<bool>> bodycontentSettingsteams = null, Expression<Func<bool>> bodycontentSettingsinApp = null, Expression<Func<bool>> bodycontentSettingsallowLikes = null, Expression<Func<bool>> bodycontentSettingsallowComments = null, Expression<Func<bool>> bodycontentSettingsallowImagesInComments = null, Expression<Func<bool>> bodycontentSettingsallowDocuments = null)
        {
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: true);
            var __workflow_bodyvalueType = WorkflowExpression.Compile(bodyvalueType, nameof(bodyvalueType), required: true);
            var __workflow_bodytag = WorkflowExpression.Compile(bodytag, nameof(bodytag), required: false);
            var __workflow_bodymanagerEmail = WorkflowExpression.Compile(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodypersonEmail = WorkflowExpression.Compile(bodypersonEmail, nameof(bodypersonEmail), required: false);
            var __workflow_bodypersonId = WorkflowExpression.Compile(bodypersonId, nameof(bodypersonId), required: false);
            var __workflow_bodydepartmentName = WorkflowExpression.Compile(bodydepartmentName, nameof(bodydepartmentName), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodycompanyObjectiveId = WorkflowExpression.Compile(bodycompanyObjectiveId, nameof(bodycompanyObjectiveId), required: false);
            var __workflow_bodydepartmentObjectiveId = WorkflowExpression.Compile(bodydepartmentObjectiveId, nameof(bodydepartmentObjectiveId), required: false);
            var __workflow_bodystartValue = WorkflowExpression.Compile(bodystartValue, nameof(bodystartValue), required: false);
            var __workflow_bodytarget = WorkflowExpression.Compile(bodytarget, nameof(bodytarget), required: false);
            var __workflow_bodyallowAddProgress = WorkflowExpression.Compile(bodyallowAddProgress, nameof(bodyallowAddProgress), required: false);
            var __workflow_bodyrecurType = WorkflowExpression.Compile(bodyrecurType, nameof(bodyrecurType), required: false);
            var __workflow_bodyrecurInterval = WorkflowExpression.Compile(bodyrecurInterval, nameof(bodyrecurInterval), required: false);
            var __workflow_bodycumulativeProgress = WorkflowExpression.Compile(bodycumulativeProgress, nameof(bodycumulativeProgress), required: false);
            var __workflow_bodycontentSettingspush = WorkflowExpression.Compile(bodycontentSettingspush, nameof(bodycontentSettingspush), required: false);
            var __workflow_bodycontentSettingssms = WorkflowExpression.Compile(bodycontentSettingssms, nameof(bodycontentSettingssms), required: false);
            var __workflow_bodycontentSettingsemail = WorkflowExpression.Compile(bodycontentSettingsemail, nameof(bodycontentSettingsemail), required: false);
            var __workflow_bodycontentSettingsteams = WorkflowExpression.Compile(bodycontentSettingsteams, nameof(bodycontentSettingsteams), required: false);
            var __workflow_bodycontentSettingsinApp = WorkflowExpression.Compile(bodycontentSettingsinApp, nameof(bodycontentSettingsinApp), required: false);
            var __workflow_bodycontentSettingsallowLikes = WorkflowExpression.Compile(bodycontentSettingsallowLikes, nameof(bodycontentSettingsallowLikes), required: false);
            var __workflow_bodycontentSettingsallowComments = WorkflowExpression.Compile(bodycontentSettingsallowComments, nameof(bodycontentSettingsallowComments), required: false);
            var __workflow_bodycontentSettingsallowImagesInComments = WorkflowExpression.Compile(bodycontentSettingsallowImagesInComments, nameof(bodycontentSettingsallowImagesInComments), required: false);
            var __workflow_bodycontentSettingsallowDocuments = WorkflowExpression.Compile(bodycontentSettingsallowDocuments, nameof(bodycontentSettingsallowDocuments), required: false);
            return new DeferredBodyAction<CreateObjectiveResponse>(() =>
            {
                var apiCallPath = "/public/Performance/v1/Objectives/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                bodypropCount++;
                body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                bodypropCount++;
                body["valueType"] = ExpressionConverter.ConvertO(__workflow_bodyvalueType);
                if (__workflow_bodytag != null)
                {
                    body["tag"] = ExpressionConverter.ConvertO(__workflow_bodytag);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerEmail != null)
                {
                    body["managerEmail"] = ExpressionConverter.ConvertO(__workflow_bodymanagerEmail);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                if (__workflow_bodypersonEmail != null)
                {
                    body["personEmail"] = ExpressionConverter.ConvertO(__workflow_bodypersonEmail);
                    bodypropCount++;
                }

                if (__workflow_bodypersonId != null)
                {
                    body["personId"] = ExpressionConverter.ConvertO(__workflow_bodypersonId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentName != null)
                {
                    body["departmentName"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentName);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyObjectiveId != null)
                {
                    body["companyObjectiveId"] = ExpressionConverter.ConvertO(__workflow_bodycompanyObjectiveId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentObjectiveId != null)
                {
                    body["departmentObjectiveId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentObjectiveId);
                    bodypropCount++;
                }

                if (__workflow_bodystartValue != null)
                {
                    body["startValue"] = ExpressionConverter.ConvertO(__workflow_bodystartValue);
                    bodypropCount++;
                }

                if (__workflow_bodytarget != null)
                {
                    body["target"] = ExpressionConverter.ConvertO(__workflow_bodytarget);
                    bodypropCount++;
                }

                if (__workflow_bodyallowAddProgress != null)
                {
                    if (__workflow_bodyallowAddProgress != null)
                    {
                        body["allowAddProgress"] = ExpressionConverter.ConvertO(__workflow_bodyallowAddProgress);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["allowAddProgress"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyrecurType != null)
                {
                    body["recurType"] = ExpressionConverter.ConvertO(__workflow_bodyrecurType);
                    bodypropCount++;
                }

                if (__workflow_bodyrecurInterval != null)
                {
                    body["recurInterval"] = ExpressionConverter.ConvertO(__workflow_bodyrecurInterval);
                    bodypropCount++;
                }

                if (__workflow_bodycumulativeProgress != null)
                {
                    if (__workflow_bodycumulativeProgress != null)
                    {
                        body["cumulativeProgress"] = ExpressionConverter.ConvertO(__workflow_bodycumulativeProgress);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["cumulativeProgress"] = false;
                    bodypropCount++;
                }

                var contentSettingsObject = new JObject();
                var contentSettingsObjectpropCount = 0;
                if (__workflow_bodycontentSettingspush != null)
                {
                    if (__workflow_bodycontentSettingspush != null)
                    {
                        contentSettingsObject["push"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingspush);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["push"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingssms != null)
                {
                    if (__workflow_bodycontentSettingssms != null)
                    {
                        contentSettingsObject["sms"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingssms);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["sms"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsemail != null)
                {
                    if (__workflow_bodycontentSettingsemail != null)
                    {
                        contentSettingsObject["email"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsemail);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["email"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsteams != null)
                {
                    if (__workflow_bodycontentSettingsteams != null)
                    {
                        contentSettingsObject["teams"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsteams);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["teams"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsinApp != null)
                {
                    if (__workflow_bodycontentSettingsinApp != null)
                    {
                        contentSettingsObject["inApp"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsinApp);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["inApp"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowLikes != null)
                {
                    if (__workflow_bodycontentSettingsallowLikes != null)
                    {
                        contentSettingsObject["allowLikes"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowLikes);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowLikes"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowComments != null)
                {
                    if (__workflow_bodycontentSettingsallowComments != null)
                    {
                        contentSettingsObject["allowComments"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowComments);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowComments"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowImagesInComments != null)
                {
                    if (__workflow_bodycontentSettingsallowImagesInComments != null)
                    {
                        contentSettingsObject["allowImagesInComments"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowImagesInComments);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowImagesInComments"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowDocuments != null)
                {
                    if (__workflow_bodycontentSettingsallowDocuments != null)
                    {
                        contentSettingsObject["allowDocuments"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowDocuments);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowDocuments"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (contentSettingsObjectpropCount > 0)
                {
                    body["contentSettings"] = contentSettingsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateObjectiveResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<UpdateObjectiveScoreResponse> UpdateObjectiveScore(Expression<Func<string>> objectiveId, Expression<Func<double>> bodyvalue, Expression<Func<string>> bodydescription, Expression<Func<bool>> bodyisIncrement = null)
        {
            var __workflow_objectiveId = WorkflowExpression.Compile(objectiveId, nameof(objectiveId), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodyisIncrement = WorkflowExpression.Compile(bodyisIncrement, nameof(bodyisIncrement), required: false);
            return new DeferredBodyAction<UpdateObjectiveScoreResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public/Performance/v1/Objectives/{0}/progress", __workflow_objectiveId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (__workflow_bodyisIncrement != null)
                {
                    if (__workflow_bodyisIncrement != null)
                    {
                        body["isIncrement"] = ExpressionConverter.ConvertO(__workflow_bodyisIncrement);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["isIncrement"] = false;
                    bodypropCount++;
                }

                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateObjectiveScoreResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateArticleResponse> CreateArticle(Expression<Func<string>> bodytitle, Expression<Func<bodypriorityInput>> bodypriority, Expression<Func<bodyarticleTypeInput>> bodyarticleType, Expression<Func<string>> bodyhtmlContent, Expression<Func<string>> bodytag, Expression<Func<string>> bodymainImageUrl = null, Expression<Func<string>> bodysummary = null, Expression<Func<int>> bodychannelId = null, Expression<Func<bool>> bodycontentSettingspush = null, Expression<Func<bool>> bodycontentSettingssms = null, Expression<Func<bool>> bodycontentSettingsemail = null, Expression<Func<bool>> bodycontentSettingsinApp = null, Expression<Func<bool>> bodycontentSettingsteams = null, Expression<Func<bool>> bodycontentSettingsallowLikes = null, Expression<Func<bool>> bodycontentSettingsallowComments = null, Expression<Func<bool>> bodycontentSettingsallowImagesInComments = null, Expression<Func<string>> bodypublicationDetailspinFromDate = null, Expression<Func<int>> bodypublicationDetailspinDurationHours = null, Expression<Func<string>> bodypublicationDetailsscheduledDateTime = null, Expression<Func<bool>> bodypublicationDetailspublishImmediately = null, Expression<Func<int>> bodypublicationDetailspublishAsUserId = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: true);
            var __workflow_bodyarticleType = WorkflowExpression.Compile(bodyarticleType, nameof(bodyarticleType), required: true);
            var __workflow_bodyhtmlContent = WorkflowExpression.Compile(bodyhtmlContent, nameof(bodyhtmlContent), required: true);
            var __workflow_bodytag = WorkflowExpression.Compile(bodytag, nameof(bodytag), required: true);
            var __workflow_bodymainImageUrl = WorkflowExpression.Compile(bodymainImageUrl, nameof(bodymainImageUrl), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodychannelId = WorkflowExpression.Compile(bodychannelId, nameof(bodychannelId), required: false);
            var __workflow_bodycontentSettingspush = WorkflowExpression.Compile(bodycontentSettingspush, nameof(bodycontentSettingspush), required: false);
            var __workflow_bodycontentSettingssms = WorkflowExpression.Compile(bodycontentSettingssms, nameof(bodycontentSettingssms), required: false);
            var __workflow_bodycontentSettingsemail = WorkflowExpression.Compile(bodycontentSettingsemail, nameof(bodycontentSettingsemail), required: false);
            var __workflow_bodycontentSettingsinApp = WorkflowExpression.Compile(bodycontentSettingsinApp, nameof(bodycontentSettingsinApp), required: false);
            var __workflow_bodycontentSettingsteams = WorkflowExpression.Compile(bodycontentSettingsteams, nameof(bodycontentSettingsteams), required: false);
            var __workflow_bodycontentSettingsallowLikes = WorkflowExpression.Compile(bodycontentSettingsallowLikes, nameof(bodycontentSettingsallowLikes), required: false);
            var __workflow_bodycontentSettingsallowComments = WorkflowExpression.Compile(bodycontentSettingsallowComments, nameof(bodycontentSettingsallowComments), required: false);
            var __workflow_bodycontentSettingsallowImagesInComments = WorkflowExpression.Compile(bodycontentSettingsallowImagesInComments, nameof(bodycontentSettingsallowImagesInComments), required: false);
            var __workflow_bodypublicationDetailspinFromDate = WorkflowExpression.Compile(bodypublicationDetailspinFromDate, nameof(bodypublicationDetailspinFromDate), required: false);
            var __workflow_bodypublicationDetailspinDurationHours = WorkflowExpression.Compile(bodypublicationDetailspinDurationHours, nameof(bodypublicationDetailspinDurationHours), required: false);
            var __workflow_bodypublicationDetailsscheduledDateTime = WorkflowExpression.Compile(bodypublicationDetailsscheduledDateTime, nameof(bodypublicationDetailsscheduledDateTime), required: false);
            var __workflow_bodypublicationDetailspublishImmediately = WorkflowExpression.Compile(bodypublicationDetailspublishImmediately, nameof(bodypublicationDetailspublishImmediately), required: false);
            var __workflow_bodypublicationDetailspublishAsUserId = WorkflowExpression.Compile(bodypublicationDetailspublishAsUserId, nameof(bodypublicationDetailspublishAsUserId), required: false);
            return new DeferredBodyAction<CreateArticleResponse>(() =>
            {
                var apiCallPath = "/public/comms/v1/Articles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                bodypropCount++;
                body["articleType"] = ExpressionConverter.ConvertO(__workflow_bodyarticleType);
                bodypropCount++;
                body["htmlContent"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlContent);
                if (__workflow_bodymainImageUrl != null)
                {
                    body["mainImageUrl"] = ExpressionConverter.ConvertO(__workflow_bodymainImageUrl);
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                bodypropCount++;
                body["tag"] = ExpressionConverter.ConvertO(__workflow_bodytag);
                if (__workflow_bodychannelId != null)
                {
                    body["channelId"] = ExpressionConverter.ConvertO(__workflow_bodychannelId);
                    bodypropCount++;
                }

                var contentSettingsObject = new JObject();
                var contentSettingsObjectpropCount = 0;
                if (__workflow_bodycontentSettingspush != null)
                {
                    if (__workflow_bodycontentSettingspush != null)
                    {
                        contentSettingsObject["push"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingspush);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["push"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingssms != null)
                {
                    if (__workflow_bodycontentSettingssms != null)
                    {
                        contentSettingsObject["sms"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingssms);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["sms"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsemail != null)
                {
                    if (__workflow_bodycontentSettingsemail != null)
                    {
                        contentSettingsObject["email"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsemail);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["email"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsinApp != null)
                {
                    if (__workflow_bodycontentSettingsinApp != null)
                    {
                        contentSettingsObject["inApp"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsinApp);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["inApp"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsteams != null)
                {
                    if (__workflow_bodycontentSettingsteams != null)
                    {
                        contentSettingsObject["teams"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsteams);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["teams"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowLikes != null)
                {
                    if (__workflow_bodycontentSettingsallowLikes != null)
                    {
                        contentSettingsObject["allowLikes"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowLikes);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowLikes"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowComments != null)
                {
                    if (__workflow_bodycontentSettingsallowComments != null)
                    {
                        contentSettingsObject["allowComments"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowComments);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowComments"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowImagesInComments != null)
                {
                    if (__workflow_bodycontentSettingsallowImagesInComments != null)
                    {
                        contentSettingsObject["allowImagesInComments"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowImagesInComments);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowImagesInComments"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (contentSettingsObjectpropCount > 0)
                {
                    body["contentSettings"] = contentSettingsObject;
                    bodypropCount++;
                }

                var publicationDetailsObject = new JObject();
                var publicationDetailsObjectpropCount = 0;
                if (__workflow_bodypublicationDetailspinFromDate != null)
                {
                    publicationDetailsObject["pinFromDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationDetailspinFromDate);
                    publicationDetailsObjectpropCount++;
                }

                if (__workflow_bodypublicationDetailspinDurationHours != null)
                {
                    publicationDetailsObject["pinDurationHours"] = ExpressionConverter.ConvertO(__workflow_bodypublicationDetailspinDurationHours);
                    publicationDetailsObjectpropCount++;
                }

                if (__workflow_bodypublicationDetailsscheduledDateTime != null)
                {
                    publicationDetailsObject["scheduledDateTime"] = ExpressionConverter.ConvertO(__workflow_bodypublicationDetailsscheduledDateTime);
                    publicationDetailsObjectpropCount++;
                }

                if (__workflow_bodypublicationDetailspublishImmediately != null)
                {
                    if (__workflow_bodypublicationDetailspublishImmediately != null)
                    {
                        publicationDetailsObject["publishImmediately"] = ExpressionConverter.ConvertO(__workflow_bodypublicationDetailspublishImmediately);
                        publicationDetailsObjectpropCount++;
                    }

                    publicationDetailsObjectpropCount++;
                }
                else
                {
                    publicationDetailsObject["publishImmediately"] = true;
                    publicationDetailsObjectpropCount++;
                }

                if (__workflow_bodypublicationDetailspublishAsUserId != null)
                {
                    publicationDetailsObject["publishAsUserId"] = ExpressionConverter.ConvertO(__workflow_bodypublicationDetailspublishAsUserId);
                    publicationDetailsObjectpropCount++;
                }

                if (publicationDetailsObjectpropCount > 0)
                {
                    body["publicationDetails"] = publicationDetailsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateArticleResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateAlertResponse> CreateAlert(Expression<Func<string>> bodytitle, Expression<Func<bodypriorityInput>> bodypriority, Expression<Func<string>> bodysummary = null, Expression<Func<bool>> bodyeveryone = null, Expression<Func<string>> bodyaudiencedepartmentTags = null, Expression<Func<string>> bodyaudiencepeopleTags = null, Expression<Func<string>> bodyaudiencegroupTags = null, Expression<Func<string>> bodyaudiencesiteTags = null, Expression<Func<bool>> bodycommunicationMethodspush = null, Expression<Func<bool>> bodycommunicationMethodssms = null, Expression<Func<bool>> bodycommunicationMethodsemail = null, Expression<Func<bool>> bodycommunicationMethodsinApp = null, Expression<Func<bool>> bodycommunicationMethodsteams = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: true);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodyeveryone = WorkflowExpression.Compile(bodyeveryone, nameof(bodyeveryone), required: false);
            var __workflow_bodyaudiencedepartmentTags = WorkflowExpression.Compile(bodyaudiencedepartmentTags, nameof(bodyaudiencedepartmentTags), required: false);
            var __workflow_bodyaudiencepeopleTags = WorkflowExpression.Compile(bodyaudiencepeopleTags, nameof(bodyaudiencepeopleTags), required: false);
            var __workflow_bodyaudiencegroupTags = WorkflowExpression.Compile(bodyaudiencegroupTags, nameof(bodyaudiencegroupTags), required: false);
            var __workflow_bodyaudiencesiteTags = WorkflowExpression.Compile(bodyaudiencesiteTags, nameof(bodyaudiencesiteTags), required: false);
            var __workflow_bodycommunicationMethodspush = WorkflowExpression.Compile(bodycommunicationMethodspush, nameof(bodycommunicationMethodspush), required: false);
            var __workflow_bodycommunicationMethodssms = WorkflowExpression.Compile(bodycommunicationMethodssms, nameof(bodycommunicationMethodssms), required: false);
            var __workflow_bodycommunicationMethodsemail = WorkflowExpression.Compile(bodycommunicationMethodsemail, nameof(bodycommunicationMethodsemail), required: false);
            var __workflow_bodycommunicationMethodsinApp = WorkflowExpression.Compile(bodycommunicationMethodsinApp, nameof(bodycommunicationMethodsinApp), required: false);
            var __workflow_bodycommunicationMethodsteams = WorkflowExpression.Compile(bodycommunicationMethodsteams, nameof(bodycommunicationMethodsteams), required: false);
            return new DeferredBodyAction<CreateAlertResponse>(() =>
            {
                var apiCallPath = "/public/comms/v1/Alerts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodyeveryone != null)
                {
                    if (__workflow_bodyeveryone != null)
                    {
                        body["everyone"] = ExpressionConverter.ConvertO(__workflow_bodyeveryone);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["everyone"] = false;
                    bodypropCount++;
                }

                var audienceObject = new JObject();
                var audienceObjectpropCount = 0;
                if (__workflow_bodyaudiencedepartmentTags != null)
                {
                    audienceObject["departmentTags"] = ExpressionConverter.ConvertO(__workflow_bodyaudiencedepartmentTags);
                    audienceObjectpropCount++;
                }

                if (__workflow_bodyaudiencepeopleTags != null)
                {
                    audienceObject["peopleTags"] = ExpressionConverter.ConvertO(__workflow_bodyaudiencepeopleTags);
                    audienceObjectpropCount++;
                }

                if (__workflow_bodyaudiencegroupTags != null)
                {
                    audienceObject["groupTags"] = ExpressionConverter.ConvertO(__workflow_bodyaudiencegroupTags);
                    audienceObjectpropCount++;
                }

                if (__workflow_bodyaudiencesiteTags != null)
                {
                    audienceObject["siteTags"] = ExpressionConverter.ConvertO(__workflow_bodyaudiencesiteTags);
                    audienceObjectpropCount++;
                }

                if (audienceObjectpropCount > 0)
                {
                    body["audience"] = audienceObject;
                    bodypropCount++;
                }

                var communicationMethodsObject = new JObject();
                var communicationMethodsObjectpropCount = 0;
                if (__workflow_bodycommunicationMethodspush != null)
                {
                    if (__workflow_bodycommunicationMethodspush != null)
                    {
                        communicationMethodsObject["push"] = ExpressionConverter.ConvertO(__workflow_bodycommunicationMethodspush);
                        communicationMethodsObjectpropCount++;
                    }

                    communicationMethodsObjectpropCount++;
                }
                else
                {
                    communicationMethodsObject["push"] = false;
                    communicationMethodsObjectpropCount++;
                }

                if (__workflow_bodycommunicationMethodssms != null)
                {
                    if (__workflow_bodycommunicationMethodssms != null)
                    {
                        communicationMethodsObject["sms"] = ExpressionConverter.ConvertO(__workflow_bodycommunicationMethodssms);
                        communicationMethodsObjectpropCount++;
                    }

                    communicationMethodsObjectpropCount++;
                }
                else
                {
                    communicationMethodsObject["sms"] = false;
                    communicationMethodsObjectpropCount++;
                }

                if (__workflow_bodycommunicationMethodsemail != null)
                {
                    if (__workflow_bodycommunicationMethodsemail != null)
                    {
                        communicationMethodsObject["email"] = ExpressionConverter.ConvertO(__workflow_bodycommunicationMethodsemail);
                        communicationMethodsObjectpropCount++;
                    }

                    communicationMethodsObjectpropCount++;
                }
                else
                {
                    communicationMethodsObject["email"] = true;
                    communicationMethodsObjectpropCount++;
                }

                if (__workflow_bodycommunicationMethodsinApp != null)
                {
                    if (__workflow_bodycommunicationMethodsinApp != null)
                    {
                        communicationMethodsObject["inApp"] = ExpressionConverter.ConvertO(__workflow_bodycommunicationMethodsinApp);
                        communicationMethodsObjectpropCount++;
                    }

                    communicationMethodsObjectpropCount++;
                }
                else
                {
                    communicationMethodsObject["inApp"] = true;
                    communicationMethodsObjectpropCount++;
                }

                if (__workflow_bodycommunicationMethodsteams != null)
                {
                    if (__workflow_bodycommunicationMethodsteams != null)
                    {
                        communicationMethodsObject["teams"] = ExpressionConverter.ConvertO(__workflow_bodycommunicationMethodsteams);
                        communicationMethodsObjectpropCount++;
                    }

                    communicationMethodsObjectpropCount++;
                }
                else
                {
                    communicationMethodsObject["teams"] = false;
                    communicationMethodsObjectpropCount++;
                }

                if (communicationMethodsObjectpropCount > 0)
                {
                    body["communicationMethods"] = communicationMethodsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAlertResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> bodytitle, Expression<Func<int>> bodyformId, Expression<Func<int>> bodytaskGroupId, Expression<Func<int>> bodypriorityId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydueDate = null, Expression<Func<int>> bodyassignedToId = null, Expression<Func<int>> bodymanagerId = null, Expression<Func<string>> bodyassignedToEmail = null, Expression<Func<string>> bodymanagerEmail = null, Expression<Func<int>> bodytaskIntervalId = null, Expression<Func<bool>> bodycontentSettingspush = null, Expression<Func<bool>> bodycontentSettingssms = null, Expression<Func<bool>> bodycontentSettingsemail = null, Expression<Func<bool>> bodycontentSettingsteams = null, Expression<Func<bool>> bodycontentSettingsinApp = null, Expression<Func<bool>> bodycontentSettingsallowLikes = null, Expression<Func<bool>> bodycontentSettingsallowComments = null, Expression<Func<bool>> bodycontentSettingsallowImagesInComments = null, Expression<Func<bool>> bodycontentSettingsallowDocuments = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyformId = WorkflowExpression.Compile(bodyformId, nameof(bodyformId), required: true);
            var __workflow_bodytaskGroupId = WorkflowExpression.Compile(bodytaskGroupId, nameof(bodytaskGroupId), required: true);
            var __workflow_bodypriorityId = WorkflowExpression.Compile(bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyassignedToId = WorkflowExpression.Compile(bodyassignedToId, nameof(bodyassignedToId), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodyassignedToEmail = WorkflowExpression.Compile(bodyassignedToEmail, nameof(bodyassignedToEmail), required: false);
            var __workflow_bodymanagerEmail = WorkflowExpression.Compile(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            var __workflow_bodytaskIntervalId = WorkflowExpression.Compile(bodytaskIntervalId, nameof(bodytaskIntervalId), required: false);
            var __workflow_bodycontentSettingspush = WorkflowExpression.Compile(bodycontentSettingspush, nameof(bodycontentSettingspush), required: false);
            var __workflow_bodycontentSettingssms = WorkflowExpression.Compile(bodycontentSettingssms, nameof(bodycontentSettingssms), required: false);
            var __workflow_bodycontentSettingsemail = WorkflowExpression.Compile(bodycontentSettingsemail, nameof(bodycontentSettingsemail), required: false);
            var __workflow_bodycontentSettingsteams = WorkflowExpression.Compile(bodycontentSettingsteams, nameof(bodycontentSettingsteams), required: false);
            var __workflow_bodycontentSettingsinApp = WorkflowExpression.Compile(bodycontentSettingsinApp, nameof(bodycontentSettingsinApp), required: false);
            var __workflow_bodycontentSettingsallowLikes = WorkflowExpression.Compile(bodycontentSettingsallowLikes, nameof(bodycontentSettingsallowLikes), required: false);
            var __workflow_bodycontentSettingsallowComments = WorkflowExpression.Compile(bodycontentSettingsallowComments, nameof(bodycontentSettingsallowComments), required: false);
            var __workflow_bodycontentSettingsallowImagesInComments = WorkflowExpression.Compile(bodycontentSettingsallowImagesInComments, nameof(bodycontentSettingsallowImagesInComments), required: false);
            var __workflow_bodycontentSettingsallowDocuments = WorkflowExpression.Compile(bodycontentSettingsallowDocuments, nameof(bodycontentSettingsallowDocuments), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = "/public/tasks/v1/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(__workflow_bodypriorityId);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["formId"] = ExpressionConverter.ConvertO(__workflow_bodyformId);
                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["taskGroupId"] = ExpressionConverter.ConvertO(__workflow_bodytaskGroupId);
                if (__workflow_bodyassignedToEmail != null)
                {
                    body["assignedToEmail"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToEmail);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerEmail != null)
                {
                    body["managerEmail"] = ExpressionConverter.ConvertO(__workflow_bodymanagerEmail);
                    bodypropCount++;
                }

                if (__workflow_bodytaskIntervalId != null)
                {
                    body["taskIntervalId"] = ExpressionConverter.ConvertO(__workflow_bodytaskIntervalId);
                    bodypropCount++;
                }

                var contentSettingsObject = new JObject();
                var contentSettingsObjectpropCount = 0;
                if (__workflow_bodycontentSettingspush != null)
                {
                    if (__workflow_bodycontentSettingspush != null)
                    {
                        contentSettingsObject["push"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingspush);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["push"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingssms != null)
                {
                    if (__workflow_bodycontentSettingssms != null)
                    {
                        contentSettingsObject["sms"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingssms);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["sms"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsemail != null)
                {
                    if (__workflow_bodycontentSettingsemail != null)
                    {
                        contentSettingsObject["email"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsemail);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["email"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsteams != null)
                {
                    if (__workflow_bodycontentSettingsteams != null)
                    {
                        contentSettingsObject["teams"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsteams);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["teams"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsinApp != null)
                {
                    if (__workflow_bodycontentSettingsinApp != null)
                    {
                        contentSettingsObject["inApp"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsinApp);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["inApp"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowLikes != null)
                {
                    contentSettingsObject["allowLikes"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowLikes);
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowComments != null)
                {
                    contentSettingsObject["allowComments"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowComments);
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowImagesInComments != null)
                {
                    contentSettingsObject["allowImagesInComments"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowImagesInComments);
                    contentSettingsObjectpropCount++;
                }

                if (__workflow_bodycontentSettingsallowDocuments != null)
                {
                    contentSettingsObject["allowDocuments"] = ExpressionConverter.ConvertO(__workflow_bodycontentSettingsallowDocuments);
                    contentSettingsObjectpropCount++;
                }

                if (contentSettingsObjectpropCount > 0)
                {
                    body["contentSettings"] = contentSettingsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class StaffcircleTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> NewPerson(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewPerson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["authType"] = "none";
                bodypropCount++;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resourceType"] = "People";
                bodypropCount++;
                body["create"] = true;
                bodypropCount++;
                body["update"] = false;
                bodypropCount++;
                body["delete"] = false;
                bodypropCount++;
                body["notifications"] = false;
                bodypropCount++;
                body["isActive"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<JToken> NewObjective(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewObjective";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["authType"] = "none";
                bodypropCount++;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resourceType"] = "Objectives";
                bodypropCount++;
                body["create"] = true;
                bodypropCount++;
                body["update"] = false;
                bodypropCount++;
                body["delete"] = false;
                bodypropCount++;
                body["notifications"] = false;
                bodypropCount++;
                body["isActive"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<JToken> UpdateObjective(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/UpdateObjective";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["authType"] = "none";
                bodypropCount++;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resourceType"] = "Objectives_Progress";
                bodypropCount++;
                body["create"] = true;
                bodypropCount++;
                body["update"] = false;
                bodypropCount++;
                body["delete"] = false;
                bodypropCount++;
                body["notifications"] = false;
                bodypropCount++;
                body["isActive"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<JToken> PublishedArticle(Expression<Func<string>> bodyname = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/Public/Security/v1/Webhooks/NewArticle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["authType"] = "none";
                bodypropCount++;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resourceType"] = "Articles";
                bodypropCount++;
                body["create"] = false;
                bodypropCount++;
                body["update"] = false;
                bodypropCount++;
                body["delete"] = false;
                bodypropCount++;
                body["notifications"] = false;
                bodypropCount++;
                body["customAction"] = "Publish";
                bodypropCount++;
                body["isActive"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<JToken> NewTask(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["authType"] = "none";
                bodypropCount++;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["isActive"] = true;
                bodypropCount++;
                body["resourceType"] = "Task";
                bodypropCount++;
                body["create"] = true;
                bodypropCount++;
                body["update"] = false;
                bodypropCount++;
                body["delete"] = false;
                bodypropCount++;
                body["notifications"] = false;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<JToken> NewReview(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewReview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["authType"] = "none";
                bodypropCount++;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["isActive"] = true;
                bodypropCount++;
                body["resourceType"] = "Reviews";
                bodypropCount++;
                body["create"] = true;
                bodypropCount++;
                body["update"] = false;
                bodypropCount++;
                body["delete"] = false;
                bodypropCount++;
                body["notifications"] = false;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<JToken> NewAbsence(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/newabsence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["authType"] = "none";
                bodypropCount++;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["isActive"] = true;
                bodypropCount++;
                body["resourceType"] = "Absences";
                bodypropCount++;
                body["create"] = true;
                bodypropCount++;
                body["update"] = false;
                bodypropCount++;
                body["delete"] = false;
                bodypropCount++;
                body["notifications"] = false;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }
    }

    public class GetPersonResponse
    {
        [JsonProperty("results")]
        public GetPersonResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetPersonResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("secondName")]
        public string SecondName { get; set; }

        [JsonProperty("knownAs")]
        public string KnownAs { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("mainSite")]
        public GetPersonResponseResultsTypeItemMainSiteType MainSite { get; set; }

        [JsonProperty("manager")]
        public GetPersonResponseResultsTypeItemManagerType Manager { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("department")]
        public GetPersonResponseResultsTypeItemDepartmentType Department { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("role")]
        public GetPersonResponseResultsTypeItemRoleType Role { get; set; }

        [JsonProperty("avatarURL")]
        public string AvatarURL { get; set; }

        [JsonProperty("status")]
        public GetPersonResponseResultsTypeItemStatusType Status { get; set; }

        [JsonProperty("personStatus")]
        public GetPersonResponseResultsTypeItemPersonStatusType PersonStatus { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }

    public class GetPersonResponseResultsTypeItemMainSiteType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }
    }

    public class GetPersonResponseResultsTypeItemManagerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("secondName")]
        public string SecondName { get; set; }
    }

    public class GetPersonResponseResultsTypeItemDepartmentType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetPersonResponseResultsTypeItemRoleType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetPersonResponseResultsTypeItemStatusType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetPersonResponseResultsTypeItemPersonStatusType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreatePersonResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytimeZoneInput
    {
        [EnumMember(Value = "(GMT-11:00) Niue")]
        GMT1100Niue,
        [EnumMember(Value = "(GMT-11:00) Pago Pago")]
        GMT1100PagoPago,
        [EnumMember(Value = "(GMT-10:00) Hawaii Time")]
        GMT1000HawaiiTime,
        [EnumMember(Value = "(GMT-10:00) Rarotonga")]
        GMT1000Rarotonga,
        [EnumMember(Value = "(GMT-10:00) Tahiti")]
        GMT1000Tahiti,
        [EnumMember(Value = "(GMT-09:30) Marquesas")]
        GMT0930Marquesas,
        [EnumMember(Value = "(GMT-09:00) Alaska Time")]
        GMT0900AlaskaTime,
        [EnumMember(Value = "(GMT-09:00) Gambier")]
        GMT0900Gambier,
        [EnumMember(Value = "(GMT-08:00) Pacific Time")]
        GMT0800PacificTime,
        [EnumMember(Value = "(GMT-08:00) Pacific Time - Tijuana")]
        GMT0800PacificTimeTijuana,
        [EnumMember(Value = "(GMT-08:00) Pacific Time - Vancouver")]
        GMT0800PacificTimeVancouver,
        [EnumMember(Value = "(GMT-08:00) Pacific Time - Whitehorse")]
        GMT0800PacificTimeWhitehorse,
        [EnumMember(Value = "(GMT-08:00) Pitcairn")]
        GMT0800Pitcairn,
        [EnumMember(Value = "(GMT-07:00) Mountain Time")]
        GMT0700MountainTime,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Arizona")]
        GMT0700MountainTimeArizona,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Chihuahua, Mazatlan")]
        GMT0700MountainTimeChihuahuaMazatlan,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Dawson Creek")]
        GMT0700MountainTimeDawsonCreek,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Edmonton")]
        GMT0700MountainTimeEdmonton,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Hermosillo")]
        GMT0700MountainTimeHermosillo,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Yellowknife")]
        GMT0700MountainTimeYellowknife,
        [EnumMember(Value = "(GMT-06:00) Belize")]
        GMT0600Belize,
        [EnumMember(Value = "(GMT-06:00) Central Time")]
        GMT0600CentralTime,
        [EnumMember(Value = "(GMT-06:00) Central Time - Mexico City")]
        GMT0600CentralTimeMexicoCity,
        [EnumMember(Value = "(GMT-06:00) Central Time - Regina")]
        GMT0600CentralTimeRegina,
        [EnumMember(Value = "(GMT-06:00) Central Time - Tegucigalpa")]
        GMT0600CentralTimeTegucigalpa,
        [EnumMember(Value = "(GMT-06:00) Central Time - Winnipeg")]
        GMT0600CentralTimeWinnipeg,
        [EnumMember(Value = "(GMT-06:00) Costa Rica")]
        GMT0600CostaRica,
        [EnumMember(Value = "(GMT-06:00) El Salvador")]
        GMT0600ElSalvador,
        [EnumMember(Value = "(GMT-06:00) Galapagos")]
        GMT0600Galapagos,
        [EnumMember(Value = "(GMT-06:00) Guatemala")]
        GMT0600Guatemala,
        [EnumMember(Value = "(GMT-06:00) Managua")]
        GMT0600Managua,
        [EnumMember(Value = "(GMT-05:00) America Cancun")]
        GMT0500AmericaCancun,
        [EnumMember(Value = "(GMT-05:00) Bogota")]
        GMT0500Bogota,
        [EnumMember(Value = "(GMT-05:00) Easter Island")]
        GMT0500EasterIsland,
        [EnumMember(Value = "(GMT-05:00) Eastern Time")]
        GMT0500EasternTime,
        [EnumMember(Value = "(GMT-05:00) Eastern Time - Iqaluit")]
        GMT0500EasternTimeIqaluit,
        [EnumMember(Value = "(GMT-05:00) Eastern Time - Toronto")]
        GMT0500EasternTimeToronto,
        [EnumMember(Value = "(GMT-05:00) Guayaquil")]
        GMT0500Guayaquil,
        [EnumMember(Value = "(GMT-05:00) Havana")]
        GMT0500Havana,
        [EnumMember(Value = "(GMT-05:00) Jamaica")]
        GMT0500Jamaica,
        [EnumMember(Value = "(GMT-05:00) Lima")]
        GMT0500Lima,
        [EnumMember(Value = "(GMT-05:00) Nassau")]
        GMT0500Nassau,
        [EnumMember(Value = "(GMT-05:00) Panama")]
        GMT0500Panama,
        [EnumMember(Value = "(GMT-05:00) Port-au-Prince")]
        GMT0500PortAuPrince,
        [EnumMember(Value = "(GMT-05:00) Rio Branco")]
        GMT0500RioBranco,
        [EnumMember(Value = "(GMT-04:00) Atlantic Time - Halifax")]
        GMT0400AtlanticTimeHalifax,
        [EnumMember(Value = "(GMT-04:00) Barbados")]
        GMT0400Barbados,
        [EnumMember(Value = "(GMT-04:00) Bermuda")]
        GMT0400Bermuda,
        [EnumMember(Value = "(GMT-04:00) Boa Vista")]
        GMT0400BoaVista,
        [EnumMember(Value = "(GMT-04:00) Caracas")]
        GMT0400Caracas,
        [EnumMember(Value = "(GMT-04:00) Curacao")]
        GMT0400Curacao,
        [EnumMember(Value = "(GMT-04:00) Grand Turk")]
        GMT0400GrandTurk,
        [EnumMember(Value = "(GMT-04:00) Guyana")]
        GMT0400Guyana,
        [EnumMember(Value = "(GMT-04:00) La Paz")]
        GMT0400LaPaz,
        [EnumMember(Value = "(GMT-04:00) Manaus")]
        GMT0400Manaus,
        [EnumMember(Value = "(GMT-04:00) Martinique")]
        GMT0400Martinique,
        [EnumMember(Value = "(GMT-04:00) Port of Spain")]
        GMT0400PortOfSpain,
        [EnumMember(Value = "(GMT-04:00) Porto Velho")]
        GMT0400PortoVelho,
        [EnumMember(Value = "(GMT-04:00) Puerto Rico")]
        GMT0400PuertoRico,
        [EnumMember(Value = "(GMT-04:00) Santo Domingo")]
        GMT0400SantoDomingo,
        [EnumMember(Value = "(GMT-04:00) Thule")]
        GMT0400Thule,
        [EnumMember(Value = "(GMT-03:30) Newfoundland Time - St. Johns")]
        GMT0330NewfoundlandTimeStJohns,
        [EnumMember(Value = "(GMT-03:00) Araguaina")]
        GMT0300Araguaina,
        [EnumMember(Value = "(GMT-03:00) Asuncion")]
        GMT0300Asuncion,
        [EnumMember(Value = "(GMT-03:00) Belem")]
        GMT0300Belem,
        [EnumMember(Value = "(GMT-03:00) Buenos Aires")]
        GMT0300BuenosAires,
        [EnumMember(Value = "(GMT-03:00) Campo Grande")]
        GMT0300CampoGrande,
        [EnumMember(Value = "(GMT-03:00) Cayenne")]
        GMT0300Cayenne,
        [EnumMember(Value = "(GMT-03:00) Cuiaba")]
        GMT0300Cuiaba,
        [EnumMember(Value = "(GMT-03:00) Fortaleza")]
        GMT0300Fortaleza,
        [EnumMember(Value = "(GMT-03:00) Godthab")]
        GMT0300Godthab,
        [EnumMember(Value = "(GMT-03:00) Maceio")]
        GMT0300Maceio,
        [EnumMember(Value = "(GMT-03:00) Miquelon")]
        GMT0300Miquelon,
        [EnumMember(Value = "(GMT-03:00) Montevideo")]
        GMT0300Montevideo,
        [EnumMember(Value = "(GMT-03:00) Palmer")]
        GMT0300Palmer,
        [EnumMember(Value = "(GMT-03:00) Paramaribo")]
        GMT0300Paramaribo,
        [EnumMember(Value = "(GMT-03:00) Punta Arenas")]
        GMT0300PuntaArenas,
        [EnumMember(Value = "(GMT-03:00) Recife")]
        GMT0300Recife,
        [EnumMember(Value = "(GMT-03:00) Rothera")]
        GMT0300Rothera,
        [EnumMember(Value = "(GMT-03:00) Salvador")]
        GMT0300Salvador,
        [EnumMember(Value = "(GMT-03:00) Santiago")]
        GMT0300Santiago,
        [EnumMember(Value = "(GMT-03:00) Stanley")]
        GMT0300Stanley,
        [EnumMember(Value = "(GMT-02:00) Noronha")]
        GMT0200Noronha,
        [EnumMember(Value = "(GMT-02:00) Sao Paulo")]
        GMT0200SaoPaulo,
        [EnumMember(Value = "(GMT-02:00) South Georgia")]
        GMT0200SouthGeorgia,
        [EnumMember(Value = "(GMT-01:00) Azores")]
        GMT0100Azores,
        [EnumMember(Value = "(GMT-01:00) Cape Verde")]
        GMT0100CapeVerde,
        [EnumMember(Value = "(GMT-01:00) Scoresbysund")]
        GMT0100Scoresbysund,
        [EnumMember(Value = "(GMT+00:00) Abidjan")]
        GMT0000Abidjan,
        [EnumMember(Value = "(GMT+00:00) Accra")]
        GMT0000Accra,
        [EnumMember(Value = "(GMT+00:00) Bissau")]
        GMT0000Bissau,
        [EnumMember(Value = "(GMT+00:00) Canary Islands")]
        GMT0000CanaryIslands,
        [EnumMember(Value = "(GMT+00:00) Casablanca")]
        GMT0000Casablanca,
        [EnumMember(Value = "(GMT+00:00) Danmarkshavn")]
        GMT0000Danmarkshavn,
        [EnumMember(Value = "(GMT+00:00) Dublin")]
        GMT0000Dublin,
        [EnumMember(Value = "(GMT+00:00) El Aaiun")]
        GMT0000ElAaiun,
        [EnumMember(Value = "(GMT+00:00) Faeroe")]
        GMT0000Faeroe,
        [EnumMember(Value = "(GMT+00:00) GMT (no daylight saving)")]
        GMT0000GMTNoDaylightSaving,
        [EnumMember(Value = "(GMT+00:00) Lisbon")]
        GMT0000Lisbon,
        [EnumMember(Value = "(GMT+00:00) London")]
        GMT0000London,
        [EnumMember(Value = "(GMT+00:00) Monrovia")]
        GMT0000Monrovia,
        [EnumMember(Value = "(GMT+00:00) Reykjavik")]
        GMT0000Reykjavik,
        [EnumMember(Value = "(GMT+01:00) Algiers")]
        GMT0100Algiers,
        [EnumMember(Value = "(GMT+01:00) Amsterdam")]
        GMT0100Amsterdam,
        [EnumMember(Value = "(GMT+01:00) Andorra")]
        GMT0100Andorra,
        [EnumMember(Value = "(GMT+01:00) Berlin")]
        GMT0100Berlin,
        [EnumMember(Value = "(GMT+01:00) Brussels")]
        GMT0100Brussels,
        [EnumMember(Value = "(GMT+01:00) Budapest")]
        GMT0100Budapest,
        [EnumMember(Value = "(GMT+01:00) Central European Time - Belgrade")]
        GMT0100CentralEuropeanTimeBelgrade,
        [EnumMember(Value = "(GMT+01:00) Central European Time - Prague")]
        GMT0100CentralEuropeanTimePrague,
        [EnumMember(Value = "(GMT+01:00) Ceuta")]
        GMT0100Ceuta,
        [EnumMember(Value = "(GMT+01:00) Copenhagen")]
        GMT0100Copenhagen,
        [EnumMember(Value = "(GMT+01:00) Gibraltar")]
        GMT0100Gibraltar,
        [EnumMember(Value = "(GMT+01:00) Lagos")]
        GMT0100Lagos,
        [EnumMember(Value = "(GMT+01:00) Luxembourg")]
        GMT0100Luxembourg,
        [EnumMember(Value = "(GMT+01:00) Madrid")]
        GMT0100Madrid,
        [EnumMember(Value = "(GMT+01:00) Malta")]
        GMT0100Malta,
        [EnumMember(Value = "(GMT+01:00) Monaco")]
        GMT0100Monaco,
        [EnumMember(Value = "(GMT+01:00) Ndjamena")]
        GMT0100Ndjamena,
        [EnumMember(Value = "(GMT+01:00) Oslo")]
        GMT0100Oslo,
        [EnumMember(Value = "(GMT+01:00) Paris")]
        GMT0100Paris,
        [EnumMember(Value = "(GMT+01:00) Rome")]
        GMT0100Rome,
        [EnumMember(Value = "(GMT+01:00) Stockholm")]
        GMT0100Stockholm,
        [EnumMember(Value = "(GMT+01:00) Tirane")]
        GMT0100Tirane,
        [EnumMember(Value = "(GMT+01:00) Tunis")]
        GMT0100Tunis,
        [EnumMember(Value = "(GMT+01:00) Vienna")]
        GMT0100Vienna,
        [EnumMember(Value = "(GMT+01:00) Warsaw")]
        GMT0100Warsaw,
        [EnumMember(Value = "(GMT+01:00) Zurich")]
        GMT0100Zurich,
        [EnumMember(Value = "(GMT+02:00) Amman")]
        GMT0200Amman,
        [EnumMember(Value = "(GMT+02:00) Athens")]
        GMT0200Athens,
        [EnumMember(Value = "(GMT+02:00) Beirut")]
        GMT0200Beirut,
        [EnumMember(Value = "(GMT+02:00) Bucharest")]
        GMT0200Bucharest,
        [EnumMember(Value = "(GMT+02:00) Cairo")]
        GMT0200Cairo,
        [EnumMember(Value = "(GMT+02:00) Chisinau")]
        GMT0200Chisinau,
        [EnumMember(Value = "(GMT+02:00) Damascus")]
        GMT0200Damascus,
        [EnumMember(Value = "(GMT+02:00) Gaza")]
        GMT0200Gaza,
        [EnumMember(Value = "(GMT+02:00) Helsinki")]
        GMT0200Helsinki,
        [EnumMember(Value = "(GMT+02:00) Jerusalem")]
        GMT0200Jerusalem,
        [EnumMember(Value = "(GMT+02:00) Johannesburg")]
        GMT0200Johannesburg,
        [EnumMember(Value = "(GMT+02:00) Khartoum")]
        GMT0200Khartoum,
        [EnumMember(Value = "(GMT+02:00) Kiev")]
        GMT0200Kiev,
        [EnumMember(Value = "(GMT+02:00) Maputo")]
        GMT0200Maputo,
        [EnumMember(Value = "(GMT+02:00) Moscow-01 - Kaliningrad")]
        GMT0200Moscow01Kaliningrad,
        [EnumMember(Value = "(GMT+02:00) Nicosia")]
        GMT0200Nicosia,
        [EnumMember(Value = "(GMT+02:00) Riga")]
        GMT0200Riga,
        [EnumMember(Value = "(GMT+02:00) Sofia")]
        GMT0200Sofia,
        [EnumMember(Value = "(GMT+02:00) Tallinn")]
        GMT0200Tallinn,
        [EnumMember(Value = "(GMT+02:00) Tripoli")]
        GMT0200Tripoli,
        [EnumMember(Value = "(GMT+02:00) Vilnius")]
        GMT0200Vilnius,
        [EnumMember(Value = "(GMT+02:00) Windhoek")]
        GMT0200Windhoek,
        [EnumMember(Value = "(GMT+03:00) Baghdad")]
        GMT0300Baghdad,
        [EnumMember(Value = "(GMT+03:00) Istanbul")]
        GMT0300Istanbul,
        [EnumMember(Value = "(GMT+03:00) Minsk")]
        GMT0300Minsk,
        [EnumMember(Value = "(GMT+03:00) Moscow+00 - Moscow")]
        GMT0300Moscow00Moscow,
        [EnumMember(Value = "(GMT+03:00) Nairobi")]
        GMT0300Nairobi,
        [EnumMember(Value = "(GMT+03:00) Qatar")]
        GMT0300Qatar,
        [EnumMember(Value = "(GMT+03:00) Riyadh")]
        GMT0300Riyadh,
        [EnumMember(Value = "(GMT+03:00) Syowa")]
        GMT0300Syowa,
        [EnumMember(Value = "(GMT+03:30) Tehran")]
        GMT0330Tehran,
        [EnumMember(Value = "(GMT+04:00) Baku")]
        GMT0400Baku,
        [EnumMember(Value = "(GMT+04:00) Dubai")]
        GMT0400Dubai,
        [EnumMember(Value = "(GMT+04:00) Mahe")]
        GMT0400Mahe,
        [EnumMember(Value = "(GMT+04:00) Mauritius")]
        GMT0400Mauritius,
        [EnumMember(Value = "(GMT+04:00) Moscow+01 - Samara")]
        GMT0400Moscow01Samara,
        [EnumMember(Value = "(GMT+04:00) Reunion")]
        GMT0400Reunion,
        [EnumMember(Value = "(GMT+04:00) Tbilisi")]
        GMT0400Tbilisi,
        [EnumMember(Value = "(GMT+04:00) Yerevan")]
        GMT0400Yerevan,
        [EnumMember(Value = "(GMT+04:30) Kabul")]
        GMT0430Kabul,
        [EnumMember(Value = "(GMT+05:00) Aqtau")]
        GMT0500Aqtau,
        [EnumMember(Value = "(GMT+05:00) Aqtobe")]
        GMT0500Aqtobe,
        [EnumMember(Value = "(GMT+05:00) Ashgabat")]
        GMT0500Ashgabat,
        [EnumMember(Value = "(GMT+05:00) Dushanbe")]
        GMT0500Dushanbe,
        [EnumMember(Value = "(GMT+05:00) Karachi")]
        GMT0500Karachi,
        [EnumMember(Value = "(GMT+05:00) Kerguelen")]
        GMT0500Kerguelen,
        [EnumMember(Value = "(GMT+05:00) Maldives")]
        GMT0500Maldives,
        [EnumMember(Value = "(GMT+05:00) Mawson")]
        GMT0500Mawson,
        [EnumMember(Value = "(GMT+05:00) Moscow+02 - Yekaterinburg")]
        GMT0500Moscow02Yekaterinburg,
        [EnumMember(Value = "(GMT+05:00) Tashkent")]
        GMT0500Tashkent,
        [EnumMember(Value = "(GMT+05:30) Colombo")]
        GMT0530Colombo,
        [EnumMember(Value = "(GMT+05:30) India Standard Time")]
        GMT0530IndiaStandardTime,
        [EnumMember(Value = "(GMT+05:45) Kathmandu")]
        GMT0545Kathmandu,
        [EnumMember(Value = "(GMT+06:00) Almaty")]
        GMT0600Almaty,
        [EnumMember(Value = "(GMT+06:00) Bishkek")]
        GMT0600Bishkek,
        [EnumMember(Value = "(GMT+06:00) Chagos")]
        GMT0600Chagos,
        [EnumMember(Value = "(GMT+06:00) Dhaka")]
        GMT0600Dhaka,
        [EnumMember(Value = "(GMT+06:00) Moscow+03 - Omsk")]
        GMT0600Moscow03Omsk,
        [EnumMember(Value = "(GMT+06:00) Thimphu")]
        GMT0600Thimphu,
        [EnumMember(Value = "(GMT+06:00) Vostok")]
        GMT0600Vostok,
        [EnumMember(Value = "(GMT+06:30) Cocos")]
        GMT0630Cocos,
        [EnumMember(Value = "(GMT+06:30) Rangoon")]
        GMT0630Rangoon,
        [EnumMember(Value = "(GMT+07:00) Bangkok")]
        GMT0700Bangkok,
        [EnumMember(Value = "(GMT+07:00) Christmas")]
        GMT0700Christmas,
        [EnumMember(Value = "(GMT+07:00) Davis")]
        GMT0700Davis,
        [EnumMember(Value = "(GMT+07:00) Hanoi")]
        GMT0700Hanoi,
        [EnumMember(Value = "(GMT+07:00) Hovd")]
        GMT0700Hovd,
        [EnumMember(Value = "(GMT+07:00) Jakarta")]
        GMT0700Jakarta,
        [EnumMember(Value = "(GMT+07:00) Moscow+04 - Krasnoyarsk")]
        GMT0700Moscow04Krasnoyarsk,
        [EnumMember(Value = "(GMT+08:00) Brunei")]
        GMT0800Brunei,
        [EnumMember(Value = "(GMT+08:00) China Time - Beijing")]
        GMT0800ChinaTimeBeijing,
        [EnumMember(Value = "(GMT+08:00) Choibalsan")]
        GMT0800Choibalsan,
        [EnumMember(Value = "(GMT+08:00) Hong Kong")]
        GMT0800HongKong,
        [EnumMember(Value = "(GMT+08:00) Kuala Lumpur")]
        GMT0800KualaLumpur,
        [EnumMember(Value = "(GMT+08:00) Macau")]
        GMT0800Macau,
        [EnumMember(Value = "(GMT+08:00) Makassar")]
        GMT0800Makassar,
        [EnumMember(Value = "(GMT+08:00) Manila")]
        GMT0800Manila,
        [EnumMember(Value = "(GMT+08:00) Moscow+05 - Irkutsk")]
        GMT0800Moscow05Irkutsk,
        [EnumMember(Value = "(GMT+08:00) Singapore")]
        GMT0800Singapore,
        [EnumMember(Value = "(GMT+08:00) Taipei")]
        GMT0800Taipei,
        [EnumMember(Value = "(GMT+08:00) Ulaanbaatar")]
        GMT0800Ulaanbaatar,
        [EnumMember(Value = "(GMT+08:00) Western Time - Perth")]
        GMT0800WesternTimePerth,
        [EnumMember(Value = "(GMT+08:30) Pyongyang")]
        GMT0830Pyongyang,
        [EnumMember(Value = "(GMT+09:00) Dili")]
        GMT0900Dili,
        [EnumMember(Value = "(GMT+09:00) Jayapura")]
        GMT0900Jayapura,
        [EnumMember(Value = "(GMT+09:00) Moscow+06 - Yakutsk")]
        GMT0900Moscow06Yakutsk,
        [EnumMember(Value = "(GMT+09:00) Palau")]
        GMT0900Palau,
        [EnumMember(Value = "(GMT+09:00) Seoul")]
        GMT0900Seoul,
        [EnumMember(Value = "(GMT+09:00) Tokyo")]
        GMT0900Tokyo,
        [EnumMember(Value = "(GMT+09:30) Central Time - Darwin")]
        GMT0930CentralTimeDarwin,
        [EnumMember(Value = "(GMT+10:00) Dumont D''Urville")]
        GMT1000DumontDUrville,
        [EnumMember(Value = "(GMT+10:00) Eastern Time - Brisbane")]
        GMT1000EasternTimeBrisbane,
        [EnumMember(Value = "(GMT+10:00) Guam")]
        GMT1000Guam,
        [EnumMember(Value = "(GMT+10:00) Moscow+07 - Vladivostok")]
        GMT1000Moscow07Vladivostok,
        [EnumMember(Value = "(GMT+10:00) Port Moresby")]
        GMT1000PortMoresby,
        [EnumMember(Value = "(GMT+10:00) Truk")]
        GMT1000Truk,
        [EnumMember(Value = "(GMT+10:30) Central Time - Adelaide")]
        GMT1030CentralTimeAdelaide,
        [EnumMember(Value = "(GMT+11:00) Casey")]
        GMT1100Casey,
        [EnumMember(Value = "(GMT+11:00) Eastern Time - Hobart")]
        GMT1100EasternTimeHobart,
        [EnumMember(Value = "(GMT+11:00) Eastern Time - Melbourne, Sydney")]
        GMT1100EasternTimeMelbourneSydney,
        [EnumMember(Value = "(GMT+11:00) Efate")]
        GMT1100Efate,
        [EnumMember(Value = "(GMT+11:00) Guadalcanal")]
        GMT1100Guadalcanal,
        [EnumMember(Value = "(GMT+11:00) Kosrae")]
        GMT1100Kosrae,
        [EnumMember(Value = "(GMT+11:00) Moscow+08 - Magadan")]
        GMT1100Moscow08Magadan,
        [EnumMember(Value = "(GMT+11:00) Norfolk")]
        GMT1100Norfolk,
        [EnumMember(Value = "(GMT+11:00) Noumea")]
        GMT1100Noumea,
        [EnumMember(Value = "(GMT+11:00) Ponape")]
        GMT1100Ponape,
        [EnumMember(Value = "(GMT+12:00) Funafuti")]
        GMT1200Funafuti,
        [EnumMember(Value = "(GMT+12:00) Kwajalein")]
        GMT1200Kwajalein,
        [EnumMember(Value = "(GMT+12:00) Majuro")]
        GMT1200Majuro,
        [EnumMember(Value = "(GMT+12:00) Moscow+09 - Petropavlovsk-Kamchatskiy")]
        GMT1200Moscow09PetropavlovskKamchatskiy,
        [EnumMember(Value = "(GMT+12:00) Nauru")]
        GMT1200Nauru,
        [EnumMember(Value = "(GMT+12:00) Tarawa")]
        GMT1200Tarawa,
        [EnumMember(Value = "(GMT+12:00) Wake")]
        GMT1200Wake,
        [EnumMember(Value = "(GMT+12:00) Wallis")]
        GMT1200Wallis,
        [EnumMember(Value = "(GMT+13:00) Auckland")]
        GMT1300Auckland,
        [EnumMember(Value = "(GMT+13:00) Enderbury")]
        GMT1300Enderbury,
        [EnumMember(Value = "(GMT+13:00) Fakaofo")]
        GMT1300Fakaofo,
        [EnumMember(Value = "(GMT+13:00) Fiji")]
        GMT1300Fiji,
        [EnumMember(Value = "(GMT+13:00) Tongatapu")]
        GMT1300Tongatapu,
        [EnumMember(Value = "(GMT+14:00) Apia")]
        GMT1400Apia
    }

    public class GetObjectivesResponse
    {
        [JsonProperty("results")]
        public GetObjectivesResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetObjectivesResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("objectiveType")]
        public string ObjectiveType { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("closedReason")]
        public string ClosedReason { get; set; }

        [JsonProperty("person")]
        public GetObjectivesResponseResultsTypeItemPersonType Person { get; set; }

        [JsonProperty("manager")]
        public GetObjectivesResponseResultsTypeItemManagerType Manager { get; set; }

        [JsonProperty("createdBy")]
        public GetObjectivesResponseResultsTypeItemCreatedByType CreatedBy { get; set; }

        [JsonProperty("department")]
        public GetObjectivesResponseResultsTypeItemDepartmentType Department { get; set; }

        [JsonProperty("departmentObjective")]
        public GetObjectivesResponseResultsTypeItemDepartmentObjectiveType DepartmentObjective { get; set; }

        [JsonProperty("companyObjective")]
        public GetObjectivesResponseResultsTypeItemCompanyObjectiveType CompanyObjective { get; set; }

        [JsonProperty("currentProgress")]
        public double CurrentProgress { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class GetObjectivesResponseResultsTypeItemPersonType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("secondName")]
        public string SecondName { get; set; }
    }

    public class GetObjectivesResponseResultsTypeItemManagerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("secondName")]
        public string SecondName { get; set; }
    }

    public class GetObjectivesResponseResultsTypeItemCreatedByType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("secondName")]
        public string SecondName { get; set; }
    }

    public class GetObjectivesResponseResultsTypeItemDepartmentType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetObjectivesResponseResultsTypeItemDepartmentObjectiveType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetObjectivesResponseResultsTypeItemCompanyObjectiveType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum objectiveTypeInput
    {
        Personal,
        Departmental,
        Company
    }

    public class CreateObjectiveByTemplateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateObjectiveResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyvalueTypeInput
    {
        Number,
        Percentage,
        Financial,
        YesNo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrecurTypeInput
    {
        Days,
        Weeks,
        Months,
        Years
    }

    public class UpdateObjectiveScoreResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateArticleResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypriorityInput
    {
        Critical,
        Important,
        Highlight,
        Information
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyarticleTypeInput
    {
        Social,
        Blog
    }

    public class CreateAlertResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateTaskResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Staffcircle;

    public partial class WorkflowManagedActions
    {
        public StaffcircleActions Staffcircle(string connectionId) => new StaffcircleActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StaffcircleTriggers Staffcircle(string connectionId) => new StaffcircleTriggers(connectionId);
    }
}
