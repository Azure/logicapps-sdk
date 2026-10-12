//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Staffcircle
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StaffcircleActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        [WorkflowExpressionFactory(nameof(__BuildGetPerson))]
        public IBodyWorkflowAction<GetPersonResponse> GetPerson([WorkflowExpression] Func<string> searchEmail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPersonResponse> __BuildGetPerson(WorkflowExpression<string> searchEmail)
        {
            WorkflowExpression.Validate(searchEmail, nameof(searchEmail), required: true);
            return new DeferredBodyAction<GetPersonResponse>(() =>
            {
                var apiCallPath = "/public/directory/v1/persons";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SearchEmail"] = ExpressionConverter.Convert(searchEmail);
                return new ApiConnectionAction<GetPersonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePerson))]
        public IBodyWorkflowAction<CreatePersonResponse> CreatePerson([WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodysecondName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodymobile, [WorkflowExpression] Func<string> bodydateOfBirth, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodytown = null, [WorkflowExpression] Func<string> bodypostCode = null, [WorkflowExpression] Func<string> bodycountyName = null, [WorkflowExpression] Func<string> bodycountryName = null, [WorkflowExpression] Func<string> bodytitleName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodyhomeEmail = null, [WorkflowExpression] Func<string> bodyhomeTelephone = null, [WorkflowExpression] Func<string> bodytag = null, [WorkflowExpression] Func<string> bodymanagerEmail = null, [WorkflowExpression] Func<string> bodydepartmentName = null, [WorkflowExpression] Func<string> bodyroleName = null, [WorkflowExpression] Func<string> bodyknownAs = null, [WorkflowExpression] Func<string> bodyavatarURL = null, [WorkflowExpression] Func<int> bodytitleId = null, [WorkflowExpression] Func<int> bodycountyId = null, [WorkflowExpression] Func<int> bodycountryId = null, [WorkflowExpression] Func<int> bodygenderId = null, [WorkflowExpression] Func<int> bodynationalityId = null, [WorkflowExpression] Func<int> bodyethnicityId = null, [WorkflowExpression] Func<int> bodymaritalStatusId = null, [WorkflowExpression] Func<int> bodymanagerId = null, [WorkflowExpression] Func<int> bodydepartmentId = null, [WorkflowExpression] Func<int> bodyroleId = null, [WorkflowExpression] Func<int> bodymainSiteId = null, [WorkflowExpression] Func<bool> bodyemergencyContactConsent = null, [WorkflowExpression] Func<string> bodyemergencyContactName = null, [WorkflowExpression] Func<int> bodyemergencyRelationshipId = null, [WorkflowExpression] Func<string> bodyemergencyContactTelephone = null, [WorkflowExpression] Func<string> bodyemergencyAddress = null, [WorkflowExpression] Func<string> bodynextOfKinName = null, [WorkflowExpression] Func<int> bodynextOfKinRelationshipId = null, [WorkflowExpression] Func<string> bodynextOfKinTelephone = null, [WorkflowExpression] Func<string> bodydialingCode = null, [WorkflowExpression] Func<string> bodyworkExtension = null, [WorkflowExpression] Func<string> bodytelephone = null, [WorkflowExpression] Func<string> bodypersonalMobile = null, [WorkflowExpression] Func<int> bodystatusId = null, [WorkflowExpression] Func<int> bodyemploymentTypeId = null, [WorkflowExpression] Func<int> bodycontractTypeId = null, [WorkflowExpression] Func<string> bodycontractExpiry = null, [WorkflowExpression] Func<int> bodyemploymentStatusId = null, [WorkflowExpression] Func<int> bodysecondaryEmploymentStatusId = null, [WorkflowExpression] Func<string> bodyemploymentNotes = null, [WorkflowExpression] Func<string> bodymedicalNotes = null, [WorkflowExpression] Func<bool> bodyisPersonalDataEnabled = null, [WorkflowExpression] Func<bool> bodyisContactDataEnabled = null, [WorkflowExpression] Func<bodytimeZoneInput> bodytimeZone = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePersonResponse> __BuildCreatePerson(WorkflowExpression<string> bodyfirstName, WorkflowExpression<string> bodysecondName, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodymobile, WorkflowExpression<string> bodydateOfBirth, WorkflowExpression<string> bodystartDate, WorkflowExpression<string> bodyaddressLine1 = null, WorkflowExpression<string> bodyaddressLine2 = null, WorkflowExpression<string> bodytown = null, WorkflowExpression<string> bodypostCode = null, WorkflowExpression<string> bodycountyName = null, WorkflowExpression<string> bodycountryName = null, WorkflowExpression<string> bodytitleName = null, WorkflowExpression<string> bodymiddleName = null, WorkflowExpression<string> bodyhomeEmail = null, WorkflowExpression<string> bodyhomeTelephone = null, WorkflowExpression<string> bodytag = null, WorkflowExpression<string> bodymanagerEmail = null, WorkflowExpression<string> bodydepartmentName = null, WorkflowExpression<string> bodyroleName = null, WorkflowExpression<string> bodyknownAs = null, WorkflowExpression<string> bodyavatarURL = null, WorkflowExpression<int> bodytitleId = null, WorkflowExpression<int> bodycountyId = null, WorkflowExpression<int> bodycountryId = null, WorkflowExpression<int> bodygenderId = null, WorkflowExpression<int> bodynationalityId = null, WorkflowExpression<int> bodyethnicityId = null, WorkflowExpression<int> bodymaritalStatusId = null, WorkflowExpression<int> bodymanagerId = null, WorkflowExpression<int> bodydepartmentId = null, WorkflowExpression<int> bodyroleId = null, WorkflowExpression<int> bodymainSiteId = null, WorkflowExpression<bool> bodyemergencyContactConsent = null, WorkflowExpression<string> bodyemergencyContactName = null, WorkflowExpression<int> bodyemergencyRelationshipId = null, WorkflowExpression<string> bodyemergencyContactTelephone = null, WorkflowExpression<string> bodyemergencyAddress = null, WorkflowExpression<string> bodynextOfKinName = null, WorkflowExpression<int> bodynextOfKinRelationshipId = null, WorkflowExpression<string> bodynextOfKinTelephone = null, WorkflowExpression<string> bodydialingCode = null, WorkflowExpression<string> bodyworkExtension = null, WorkflowExpression<string> bodytelephone = null, WorkflowExpression<string> bodypersonalMobile = null, WorkflowExpression<int> bodystatusId = null, WorkflowExpression<int> bodyemploymentTypeId = null, WorkflowExpression<int> bodycontractTypeId = null, WorkflowExpression<string> bodycontractExpiry = null, WorkflowExpression<int> bodyemploymentStatusId = null, WorkflowExpression<int> bodysecondaryEmploymentStatusId = null, WorkflowExpression<string> bodyemploymentNotes = null, WorkflowExpression<string> bodymedicalNotes = null, WorkflowExpression<bool> bodyisPersonalDataEnabled = null, WorkflowExpression<bool> bodyisContactDataEnabled = null, WorkflowExpression<bodytimeZoneInput> bodytimeZone = null)
        {
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            WorkflowExpression.Validate(bodysecondName, nameof(bodysecondName), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodymobile, nameof(bodymobile), required: true);
            WorkflowExpression.Validate(bodydateOfBirth, nameof(bodydateOfBirth), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            WorkflowExpression.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            WorkflowExpression.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            WorkflowExpression.Validate(bodytown, nameof(bodytown), required: false);
            WorkflowExpression.Validate(bodypostCode, nameof(bodypostCode), required: false);
            WorkflowExpression.Validate(bodycountyName, nameof(bodycountyName), required: false);
            WorkflowExpression.Validate(bodycountryName, nameof(bodycountryName), required: false);
            WorkflowExpression.Validate(bodytitleName, nameof(bodytitleName), required: false);
            WorkflowExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowExpression.Validate(bodyhomeEmail, nameof(bodyhomeEmail), required: false);
            WorkflowExpression.Validate(bodyhomeTelephone, nameof(bodyhomeTelephone), required: false);
            WorkflowExpression.Validate(bodytag, nameof(bodytag), required: false);
            WorkflowExpression.Validate(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            WorkflowExpression.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            WorkflowExpression.Validate(bodyroleName, nameof(bodyroleName), required: false);
            WorkflowExpression.Validate(bodyknownAs, nameof(bodyknownAs), required: false);
            WorkflowExpression.Validate(bodyavatarURL, nameof(bodyavatarURL), required: false);
            WorkflowExpression.Validate(bodytitleId, nameof(bodytitleId), required: false);
            WorkflowExpression.Validate(bodycountyId, nameof(bodycountyId), required: false);
            WorkflowExpression.Validate(bodycountryId, nameof(bodycountryId), required: false);
            WorkflowExpression.Validate(bodygenderId, nameof(bodygenderId), required: false);
            WorkflowExpression.Validate(bodynationalityId, nameof(bodynationalityId), required: false);
            WorkflowExpression.Validate(bodyethnicityId, nameof(bodyethnicityId), required: false);
            WorkflowExpression.Validate(bodymaritalStatusId, nameof(bodymaritalStatusId), required: false);
            WorkflowExpression.Validate(bodymanagerId, nameof(bodymanagerId), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodyroleId, nameof(bodyroleId), required: false);
            WorkflowExpression.Validate(bodymainSiteId, nameof(bodymainSiteId), required: false);
            WorkflowExpression.Validate(bodyemergencyContactConsent, nameof(bodyemergencyContactConsent), required: false);
            WorkflowExpression.Validate(bodyemergencyContactName, nameof(bodyemergencyContactName), required: false);
            WorkflowExpression.Validate(bodyemergencyRelationshipId, nameof(bodyemergencyRelationshipId), required: false);
            WorkflowExpression.Validate(bodyemergencyContactTelephone, nameof(bodyemergencyContactTelephone), required: false);
            WorkflowExpression.Validate(bodyemergencyAddress, nameof(bodyemergencyAddress), required: false);
            WorkflowExpression.Validate(bodynextOfKinName, nameof(bodynextOfKinName), required: false);
            WorkflowExpression.Validate(bodynextOfKinRelationshipId, nameof(bodynextOfKinRelationshipId), required: false);
            WorkflowExpression.Validate(bodynextOfKinTelephone, nameof(bodynextOfKinTelephone), required: false);
            WorkflowExpression.Validate(bodydialingCode, nameof(bodydialingCode), required: false);
            WorkflowExpression.Validate(bodyworkExtension, nameof(bodyworkExtension), required: false);
            WorkflowExpression.Validate(bodytelephone, nameof(bodytelephone), required: false);
            WorkflowExpression.Validate(bodypersonalMobile, nameof(bodypersonalMobile), required: false);
            WorkflowExpression.Validate(bodystatusId, nameof(bodystatusId), required: false);
            WorkflowExpression.Validate(bodyemploymentTypeId, nameof(bodyemploymentTypeId), required: false);
            WorkflowExpression.Validate(bodycontractTypeId, nameof(bodycontractTypeId), required: false);
            WorkflowExpression.Validate(bodycontractExpiry, nameof(bodycontractExpiry), required: false);
            WorkflowExpression.Validate(bodyemploymentStatusId, nameof(bodyemploymentStatusId), required: false);
            WorkflowExpression.Validate(bodysecondaryEmploymentStatusId, nameof(bodysecondaryEmploymentStatusId), required: false);
            WorkflowExpression.Validate(bodyemploymentNotes, nameof(bodyemploymentNotes), required: false);
            WorkflowExpression.Validate(bodymedicalNotes, nameof(bodymedicalNotes), required: false);
            WorkflowExpression.Validate(bodyisPersonalDataEnabled, nameof(bodyisPersonalDataEnabled), required: false);
            WorkflowExpression.Validate(bodyisContactDataEnabled, nameof(bodyisContactDataEnabled), required: false);
            WorkflowExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            return new DeferredBodyAction<CreatePersonResponse>(() =>
            {
                var apiCallPath = "/public/directory/v1/persons";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
                body["secondName"] = ExpressionConverter.ConvertO(bodysecondName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
                body["mobile"] = ExpressionConverter.ConvertO(bodymobile);
                bodypropCount++;
                body["dateOfBirth"] = ExpressionConverter.ConvertO(bodydateOfBirth);
                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                if (bodyaddressLine1 != null)
                {
                    body["addressLine1"] = ExpressionConverter.ConvertO(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["addressLine2"] = ExpressionConverter.ConvertO(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodytown != null)
                {
                    body["town"] = ExpressionConverter.ConvertO(bodytown);
                    bodypropCount++;
                }

                if (bodypostCode != null)
                {
                    body["postCode"] = ExpressionConverter.ConvertO(bodypostCode);
                    bodypropCount++;
                }

                if (bodycountyName != null)
                {
                    body["countyName"] = ExpressionConverter.ConvertO(bodycountyName);
                    bodypropCount++;
                }

                if (bodycountryName != null)
                {
                    body["countryName"] = ExpressionConverter.ConvertO(bodycountryName);
                    bodypropCount++;
                }

                if (bodytitleName != null)
                {
                    body["titleName"] = ExpressionConverter.ConvertO(bodytitleName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middleName"] = ExpressionConverter.ConvertO(bodymiddleName);
                    bodypropCount++;
                }

                if (bodyhomeEmail != null)
                {
                    body["homeEmail"] = ExpressionConverter.ConvertO(bodyhomeEmail);
                    bodypropCount++;
                }

                if (bodyhomeTelephone != null)
                {
                    body["homeTelephone"] = ExpressionConverter.ConvertO(bodyhomeTelephone);
                    bodypropCount++;
                }

                if (bodytag != null)
                {
                    body["tag"] = ExpressionConverter.ConvertO(bodytag);
                    bodypropCount++;
                }

                if (bodymanagerEmail != null)
                {
                    body["managerEmail"] = ExpressionConverter.ConvertO(bodymanagerEmail);
                    bodypropCount++;
                }

                if (bodydepartmentName != null)
                {
                    body["departmentName"] = ExpressionConverter.ConvertO(bodydepartmentName);
                    bodypropCount++;
                }

                if (bodyroleName != null)
                {
                    body["roleName"] = ExpressionConverter.ConvertO(bodyroleName);
                    bodypropCount++;
                }

                if (bodyknownAs != null)
                {
                    body["knownAs"] = ExpressionConverter.ConvertO(bodyknownAs);
                    bodypropCount++;
                }

                if (bodyavatarURL != null)
                {
                    body["avatarURL"] = ExpressionConverter.ConvertO(bodyavatarURL);
                    bodypropCount++;
                }

                if (bodytitleId != null)
                {
                    body["titleId"] = ExpressionConverter.ConvertO(bodytitleId);
                    bodypropCount++;
                }

                if (bodycountyId != null)
                {
                    body["countyId"] = ExpressionConverter.ConvertO(bodycountyId);
                    bodypropCount++;
                }

                if (bodycountryId != null)
                {
                    body["countryId"] = ExpressionConverter.ConvertO(bodycountryId);
                    bodypropCount++;
                }

                if (bodygenderId != null)
                {
                    body["genderId"] = ExpressionConverter.ConvertO(bodygenderId);
                    bodypropCount++;
                }

                if (bodynationalityId != null)
                {
                    body["nationalityId"] = ExpressionConverter.ConvertO(bodynationalityId);
                    bodypropCount++;
                }

                if (bodyethnicityId != null)
                {
                    body["ethnicityId"] = ExpressionConverter.ConvertO(bodyethnicityId);
                    bodypropCount++;
                }

                if (bodymaritalStatusId != null)
                {
                    body["maritalStatusId"] = ExpressionConverter.ConvertO(bodymaritalStatusId);
                    bodypropCount++;
                }

                if (bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(bodymanagerId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyroleId != null)
                {
                    body["roleId"] = ExpressionConverter.ConvertO(bodyroleId);
                    bodypropCount++;
                }

                if (bodymainSiteId != null)
                {
                    body["mainSiteId"] = ExpressionConverter.ConvertO(bodymainSiteId);
                    bodypropCount++;
                }

                if (bodyemergencyContactConsent != null)
                {
                    body["emergencyContactConsent"] = ExpressionConverter.ConvertO(bodyemergencyContactConsent);
                    bodypropCount++;
                }

                if (bodyemergencyContactName != null)
                {
                    body["emergencyContactName"] = ExpressionConverter.ConvertO(bodyemergencyContactName);
                    bodypropCount++;
                }

                if (bodyemergencyRelationshipId != null)
                {
                    body["emergencyRelationshipId"] = ExpressionConverter.ConvertO(bodyemergencyRelationshipId);
                    bodypropCount++;
                }

                if (bodyemergencyContactTelephone != null)
                {
                    body["emergencyContactTelephone"] = ExpressionConverter.ConvertO(bodyemergencyContactTelephone);
                    bodypropCount++;
                }

                if (bodyemergencyAddress != null)
                {
                    body["emergencyAddress"] = ExpressionConverter.ConvertO(bodyemergencyAddress);
                    bodypropCount++;
                }

                if (bodynextOfKinName != null)
                {
                    body["nextOfKinName"] = ExpressionConverter.ConvertO(bodynextOfKinName);
                    bodypropCount++;
                }

                if (bodynextOfKinRelationshipId != null)
                {
                    body["nextOfKinRelationshipId"] = ExpressionConverter.ConvertO(bodynextOfKinRelationshipId);
                    bodypropCount++;
                }

                if (bodynextOfKinTelephone != null)
                {
                    body["nextOfKinTelephone"] = ExpressionConverter.ConvertO(bodynextOfKinTelephone);
                    bodypropCount++;
                }

                if (bodydialingCode != null)
                {
                    body["dialingCode"] = ExpressionConverter.ConvertO(bodydialingCode);
                    bodypropCount++;
                }

                if (bodyworkExtension != null)
                {
                    body["workExtension"] = ExpressionConverter.ConvertO(bodyworkExtension);
                    bodypropCount++;
                }

                if (bodytelephone != null)
                {
                    body["telephone"] = ExpressionConverter.ConvertO(bodytelephone);
                    bodypropCount++;
                }

                if (bodypersonalMobile != null)
                {
                    body["personalMobile"] = ExpressionConverter.ConvertO(bodypersonalMobile);
                    bodypropCount++;
                }

                if (bodystatusId != null)
                {
                    if (bodystatusId != null)
                    {
                        body["statusId"] = ExpressionConverter.ConvertO(bodystatusId);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["statusId"] = 1;
                    bodypropCount++;
                }

                if (bodyemploymentTypeId != null)
                {
                    body["employmentTypeId"] = ExpressionConverter.ConvertO(bodyemploymentTypeId);
                    bodypropCount++;
                }

                if (bodycontractTypeId != null)
                {
                    body["contractTypeId"] = ExpressionConverter.ConvertO(bodycontractTypeId);
                    bodypropCount++;
                }

                if (bodycontractExpiry != null)
                {
                    body["contractExpiry"] = ExpressionConverter.ConvertO(bodycontractExpiry);
                    bodypropCount++;
                }

                if (bodyemploymentStatusId != null)
                {
                    body["employmentStatusId"] = ExpressionConverter.ConvertO(bodyemploymentStatusId);
                    bodypropCount++;
                }

                if (bodysecondaryEmploymentStatusId != null)
                {
                    body["secondaryEmploymentStatusId"] = ExpressionConverter.ConvertO(bodysecondaryEmploymentStatusId);
                    bodypropCount++;
                }

                if (bodyemploymentNotes != null)
                {
                    body["employmentNotes"] = ExpressionConverter.ConvertO(bodyemploymentNotes);
                    bodypropCount++;
                }

                if (bodymedicalNotes != null)
                {
                    body["medicalNotes"] = ExpressionConverter.ConvertO(bodymedicalNotes);
                    bodypropCount++;
                }

                if (bodyisPersonalDataEnabled != null)
                {
                    body["isPersonalDataEnabled"] = ExpressionConverter.ConvertO(bodyisPersonalDataEnabled);
                    bodypropCount++;
                }

                if (bodyisContactDataEnabled != null)
                {
                    body["isContactDataEnabled"] = ExpressionConverter.ConvertO(bodyisContactDataEnabled);
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    if (bodytimeZone != null)
                    {
                        body["timeZone"] = ExpressionConverter.ConvertO(bodytimeZone);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        [WorkflowExpressionFactory(nameof(__BuildGetObjectives))]
        public IBodyWorkflowAction<GetObjectivesResponse> GetObjectives([WorkflowExpression] Func<string> searchTitle = null, [WorkflowExpression] Func<string> personEmail = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<string> closed = null, [WorkflowExpression] Func<objectiveTypeInput> objectiveType = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> activeAt = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetObjectivesResponse> __BuildGetObjectives(WorkflowExpression<string> searchTitle = null, WorkflowExpression<string> personEmail = null, WorkflowExpression<string> tag = null, WorkflowExpression<string> closed = null, WorkflowExpression<objectiveTypeInput> objectiveType = null, WorkflowExpression<string> from = null, WorkflowExpression<string> to = null, WorkflowExpression<string> activeAt = null)
        {
            WorkflowExpression.Validate(searchTitle, nameof(searchTitle), required: false);
            WorkflowExpression.Validate(personEmail, nameof(personEmail), required: false);
            WorkflowExpression.Validate(tag, nameof(tag), required: false);
            WorkflowExpression.Validate(closed, nameof(closed), required: false);
            WorkflowExpression.Validate(objectiveType, nameof(objectiveType), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            WorkflowExpression.Validate(activeAt, nameof(activeAt), required: false);
            return new DeferredBodyAction<GetObjectivesResponse>(() =>
            {
                var apiCallPath = "/public/Performance/v1/Objectives";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (searchTitle != null)
                    callPayload.Queries["SearchTitle"] = ExpressionConverter.Convert(searchTitle);
                if (personEmail != null)
                    callPayload.Queries["PersonEmail"] = ExpressionConverter.Convert(personEmail);
                if (tag != null)
                    callPayload.Queries["Tag"] = ExpressionConverter.Convert(tag);
                if (closed != null)
                    callPayload.Queries["Closed"] = ExpressionConverter.Convert(closed);
                if (objectiveType != null)
                    callPayload.Queries["ObjectiveType"] = ExpressionConverter.Convert(objectiveType);
                if (from != null)
                    callPayload.Queries["From"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["To"] = ExpressionConverter.Convert(to);
                if (activeAt != null)
                    callPayload.Queries["ActiveAt"] = ExpressionConverter.Convert(activeAt);
                return new ApiConnectionAction<GetObjectivesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        [WorkflowExpressionFactory(nameof(__BuildCreateObjectiveByTemplate))]
        public IBodyWorkflowAction<CreateObjectiveByTemplateResponse> CreateObjectiveByTemplate([WorkflowExpression] Func<int> bodyobjectiveTemplateId, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodyendDate, [WorkflowExpression] Func<string> bodypersonEmail = null, [WorkflowExpression] Func<int> bodypersonId = null, [WorkflowExpression] Func<string> bodydepartmentName = null, [WorkflowExpression] Func<int> bodydepartmentId = null, [WorkflowExpression] Func<string> bodymanagerEmail = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodymanagerId = null, [WorkflowExpression] Func<int> bodycompanyObjectiveId = null, [WorkflowExpression] Func<int> bodydepartmentObjectiveId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateObjectiveByTemplateResponse> __BuildCreateObjectiveByTemplate(WorkflowExpression<int> bodyobjectiveTemplateId, WorkflowExpression<string> bodystartDate, WorkflowExpression<string> bodyendDate, WorkflowExpression<string> bodypersonEmail = null, WorkflowExpression<int> bodypersonId = null, WorkflowExpression<string> bodydepartmentName = null, WorkflowExpression<int> bodydepartmentId = null, WorkflowExpression<string> bodymanagerEmail = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<int> bodymanagerId = null, WorkflowExpression<int> bodycompanyObjectiveId = null, WorkflowExpression<int> bodydepartmentObjectiveId = null)
        {
            WorkflowExpression.Validate(bodyobjectiveTemplateId, nameof(bodyobjectiveTemplateId), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: true);
            WorkflowExpression.Validate(bodypersonEmail, nameof(bodypersonEmail), required: false);
            WorkflowExpression.Validate(bodypersonId, nameof(bodypersonId), required: false);
            WorkflowExpression.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodymanagerId, nameof(bodymanagerId), required: false);
            WorkflowExpression.Validate(bodycompanyObjectiveId, nameof(bodycompanyObjectiveId), required: false);
            WorkflowExpression.Validate(bodydepartmentObjectiveId, nameof(bodydepartmentObjectiveId), required: false);
            return new DeferredBodyAction<CreateObjectiveByTemplateResponse>(() =>
            {
                var apiCallPath = "/public/Performance/v1/Objectives";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectiveTemplateId"] = ExpressionConverter.ConvertO(bodyobjectiveTemplateId);
                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                if (bodypersonEmail != null)
                {
                    body["personEmail"] = ExpressionConverter.ConvertO(bodypersonEmail);
                    bodypropCount++;
                }

                if (bodypersonId != null)
                {
                    body["personId"] = ExpressionConverter.ConvertO(bodypersonId);
                    bodypropCount++;
                }

                if (bodydepartmentName != null)
                {
                    body["departmentName"] = ExpressionConverter.ConvertO(bodydepartmentName);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodymanagerEmail != null)
                {
                    body["managerEmail"] = ExpressionConverter.ConvertO(bodymanagerEmail);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(bodymanagerId);
                    bodypropCount++;
                }

                if (bodycompanyObjectiveId != null)
                {
                    body["companyObjectiveId"] = ExpressionConverter.ConvertO(bodycompanyObjectiveId);
                    bodypropCount++;
                }

                if (bodydepartmentObjectiveId != null)
                {
                    body["departmentObjectiveId"] = ExpressionConverter.ConvertO(bodydepartmentObjectiveId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateObjectiveByTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        [WorkflowExpressionFactory(nameof(__BuildCreateObjective))]
        public IBodyWorkflowAction<CreateObjectiveResponse> CreateObjective([WorkflowExpression] Func<int> bodycategoryId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodyendDate, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType, [WorkflowExpression] Func<string> bodytag = null, [WorkflowExpression] Func<string> bodymanagerEmail = null, [WorkflowExpression] Func<int> bodymanagerId = null, [WorkflowExpression] Func<string> bodypersonEmail = null, [WorkflowExpression] Func<int> bodypersonId = null, [WorkflowExpression] Func<string> bodydepartmentName = null, [WorkflowExpression] Func<int> bodydepartmentId = null, [WorkflowExpression] Func<int> bodycompanyObjectiveId = null, [WorkflowExpression] Func<int> bodydepartmentObjectiveId = null, [WorkflowExpression] Func<double> bodystartValue = null, [WorkflowExpression] Func<double> bodytarget = null, [WorkflowExpression] Func<bool> bodyallowAddProgress = null, [WorkflowExpression] Func<bodyrecurTypeInput> bodyrecurType = null, [WorkflowExpression] Func<int> bodyrecurInterval = null, [WorkflowExpression] Func<bool> bodycumulativeProgress = null, [WorkflowExpression] Func<bool> bodycontentSettingspush = null, [WorkflowExpression] Func<bool> bodycontentSettingssms = null, [WorkflowExpression] Func<bool> bodycontentSettingsemail = null, [WorkflowExpression] Func<bool> bodycontentSettingsteams = null, [WorkflowExpression] Func<bool> bodycontentSettingsinApp = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowLikes = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowComments = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowImagesInComments = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowDocuments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateObjectiveResponse> __BuildCreateObjective(WorkflowExpression<int> bodycategoryId, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodydescription, WorkflowExpression<string> bodystartDate, WorkflowExpression<string> bodyendDate, WorkflowExpression<bodyvalueTypeInput> bodyvalueType, WorkflowExpression<string> bodytag = null, WorkflowExpression<string> bodymanagerEmail = null, WorkflowExpression<int> bodymanagerId = null, WorkflowExpression<string> bodypersonEmail = null, WorkflowExpression<int> bodypersonId = null, WorkflowExpression<string> bodydepartmentName = null, WorkflowExpression<int> bodydepartmentId = null, WorkflowExpression<int> bodycompanyObjectiveId = null, WorkflowExpression<int> bodydepartmentObjectiveId = null, WorkflowExpression<double> bodystartValue = null, WorkflowExpression<double> bodytarget = null, WorkflowExpression<bool> bodyallowAddProgress = null, WorkflowExpression<bodyrecurTypeInput> bodyrecurType = null, WorkflowExpression<int> bodyrecurInterval = null, WorkflowExpression<bool> bodycumulativeProgress = null, WorkflowExpression<bool> bodycontentSettingspush = null, WorkflowExpression<bool> bodycontentSettingssms = null, WorkflowExpression<bool> bodycontentSettingsemail = null, WorkflowExpression<bool> bodycontentSettingsteams = null, WorkflowExpression<bool> bodycontentSettingsinApp = null, WorkflowExpression<bool> bodycontentSettingsallowLikes = null, WorkflowExpression<bool> bodycontentSettingsallowComments = null, WorkflowExpression<bool> bodycontentSettingsallowImagesInComments = null, WorkflowExpression<bool> bodycontentSettingsallowDocuments = null)
        {
            WorkflowExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: true);
            WorkflowExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: true);
            WorkflowExpression.Validate(bodytag, nameof(bodytag), required: false);
            WorkflowExpression.Validate(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            WorkflowExpression.Validate(bodymanagerId, nameof(bodymanagerId), required: false);
            WorkflowExpression.Validate(bodypersonEmail, nameof(bodypersonEmail), required: false);
            WorkflowExpression.Validate(bodypersonId, nameof(bodypersonId), required: false);
            WorkflowExpression.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodycompanyObjectiveId, nameof(bodycompanyObjectiveId), required: false);
            WorkflowExpression.Validate(bodydepartmentObjectiveId, nameof(bodydepartmentObjectiveId), required: false);
            WorkflowExpression.Validate(bodystartValue, nameof(bodystartValue), required: false);
            WorkflowExpression.Validate(bodytarget, nameof(bodytarget), required: false);
            WorkflowExpression.Validate(bodyallowAddProgress, nameof(bodyallowAddProgress), required: false);
            WorkflowExpression.Validate(bodyrecurType, nameof(bodyrecurType), required: false);
            WorkflowExpression.Validate(bodyrecurInterval, nameof(bodyrecurInterval), required: false);
            WorkflowExpression.Validate(bodycumulativeProgress, nameof(bodycumulativeProgress), required: false);
            WorkflowExpression.Validate(bodycontentSettingspush, nameof(bodycontentSettingspush), required: false);
            WorkflowExpression.Validate(bodycontentSettingssms, nameof(bodycontentSettingssms), required: false);
            WorkflowExpression.Validate(bodycontentSettingsemail, nameof(bodycontentSettingsemail), required: false);
            WorkflowExpression.Validate(bodycontentSettingsteams, nameof(bodycontentSettingsteams), required: false);
            WorkflowExpression.Validate(bodycontentSettingsinApp, nameof(bodycontentSettingsinApp), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowLikes, nameof(bodycontentSettingsallowLikes), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowComments, nameof(bodycontentSettingsallowComments), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowImagesInComments, nameof(bodycontentSettingsallowImagesInComments), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowDocuments, nameof(bodycontentSettingsallowDocuments), required: false);
            return new DeferredBodyAction<CreateObjectiveResponse>(() =>
            {
                var apiCallPath = "/public/Performance/v1/Objectives/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
                body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
                if (bodytag != null)
                {
                    body["tag"] = ExpressionConverter.ConvertO(bodytag);
                    bodypropCount++;
                }

                if (bodymanagerEmail != null)
                {
                    body["managerEmail"] = ExpressionConverter.ConvertO(bodymanagerEmail);
                    bodypropCount++;
                }

                if (bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(bodymanagerId);
                    bodypropCount++;
                }

                if (bodypersonEmail != null)
                {
                    body["personEmail"] = ExpressionConverter.ConvertO(bodypersonEmail);
                    bodypropCount++;
                }

                if (bodypersonId != null)
                {
                    body["personId"] = ExpressionConverter.ConvertO(bodypersonId);
                    bodypropCount++;
                }

                if (bodydepartmentName != null)
                {
                    body["departmentName"] = ExpressionConverter.ConvertO(bodydepartmentName);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodycompanyObjectiveId != null)
                {
                    body["companyObjectiveId"] = ExpressionConverter.ConvertO(bodycompanyObjectiveId);
                    bodypropCount++;
                }

                if (bodydepartmentObjectiveId != null)
                {
                    body["departmentObjectiveId"] = ExpressionConverter.ConvertO(bodydepartmentObjectiveId);
                    bodypropCount++;
                }

                if (bodystartValue != null)
                {
                    body["startValue"] = ExpressionConverter.ConvertO(bodystartValue);
                    bodypropCount++;
                }

                if (bodytarget != null)
                {
                    body["target"] = ExpressionConverter.ConvertO(bodytarget);
                    bodypropCount++;
                }

                if (bodyallowAddProgress != null)
                {
                    if (bodyallowAddProgress != null)
                    {
                        body["allowAddProgress"] = ExpressionConverter.ConvertO(bodyallowAddProgress);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["allowAddProgress"] = false;
                    bodypropCount++;
                }

                if (bodyrecurType != null)
                {
                    body["recurType"] = ExpressionConverter.ConvertO(bodyrecurType);
                    bodypropCount++;
                }

                if (bodyrecurInterval != null)
                {
                    body["recurInterval"] = ExpressionConverter.ConvertO(bodyrecurInterval);
                    bodypropCount++;
                }

                if (bodycumulativeProgress != null)
                {
                    if (bodycumulativeProgress != null)
                    {
                        body["cumulativeProgress"] = ExpressionConverter.ConvertO(bodycumulativeProgress);
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
                if (bodycontentSettingspush != null)
                {
                    if (bodycontentSettingspush != null)
                    {
                        contentSettingsObject["push"] = ExpressionConverter.ConvertO(bodycontentSettingspush);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["push"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingssms != null)
                {
                    if (bodycontentSettingssms != null)
                    {
                        contentSettingsObject["sms"] = ExpressionConverter.ConvertO(bodycontentSettingssms);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["sms"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsemail != null)
                {
                    if (bodycontentSettingsemail != null)
                    {
                        contentSettingsObject["email"] = ExpressionConverter.ConvertO(bodycontentSettingsemail);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["email"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsteams != null)
                {
                    if (bodycontentSettingsteams != null)
                    {
                        contentSettingsObject["teams"] = ExpressionConverter.ConvertO(bodycontentSettingsteams);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["teams"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsinApp != null)
                {
                    if (bodycontentSettingsinApp != null)
                    {
                        contentSettingsObject["inApp"] = ExpressionConverter.ConvertO(bodycontentSettingsinApp);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["inApp"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowLikes != null)
                {
                    if (bodycontentSettingsallowLikes != null)
                    {
                        contentSettingsObject["allowLikes"] = ExpressionConverter.ConvertO(bodycontentSettingsallowLikes);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowLikes"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowComments != null)
                {
                    if (bodycontentSettingsallowComments != null)
                    {
                        contentSettingsObject["allowComments"] = ExpressionConverter.ConvertO(bodycontentSettingsallowComments);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowComments"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowImagesInComments != null)
                {
                    if (bodycontentSettingsallowImagesInComments != null)
                    {
                        contentSettingsObject["allowImagesInComments"] = ExpressionConverter.ConvertO(bodycontentSettingsallowImagesInComments);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowImagesInComments"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowDocuments != null)
                {
                    if (bodycontentSettingsallowDocuments != null)
                    {
                        contentSettingsObject["allowDocuments"] = ExpressionConverter.ConvertO(bodycontentSettingsallowDocuments);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateObjectiveScore))]
        public IBodyWorkflowAction<UpdateObjectiveScoreResponse> UpdateObjectiveScore([WorkflowExpression] Func<string> objectiveId, [WorkflowExpression] Func<double> bodyvalue, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<bool> bodyisIncrement = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateObjectiveScoreResponse> __BuildUpdateObjectiveScore(WorkflowExpression<string> objectiveId, WorkflowExpression<double> bodyvalue, WorkflowExpression<string> bodydescription, WorkflowExpression<bool> bodyisIncrement = null)
        {
            WorkflowExpression.Validate(objectiveId, nameof(objectiveId), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            WorkflowExpression.Validate(bodyisIncrement, nameof(bodyisIncrement), required: false);
            return new DeferredBodyAction<UpdateObjectiveScoreResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/public/Performance/v1/Objectives/{0}/progress", ExpressionConverter.ConvertWithUrlEncoding(objectiveId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                if (bodyisIncrement != null)
                {
                    if (bodyisIncrement != null)
                    {
                        body["isIncrement"] = ExpressionConverter.ConvertO(bodyisIncrement);
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
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateObjectiveScoreResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        [WorkflowExpressionFactory(nameof(__BuildCreateArticle))]
        public IBodyWorkflowAction<CreateArticleResponse> CreateArticle([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<bodypriorityInput> bodypriority, [WorkflowExpression] Func<bodyarticleTypeInput> bodyarticleType, [WorkflowExpression] Func<string> bodyhtmlContent, [WorkflowExpression] Func<string> bodytag, [WorkflowExpression] Func<string> bodymainImageUrl = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<int> bodychannelId = null, [WorkflowExpression] Func<bool> bodycontentSettingspush = null, [WorkflowExpression] Func<bool> bodycontentSettingssms = null, [WorkflowExpression] Func<bool> bodycontentSettingsemail = null, [WorkflowExpression] Func<bool> bodycontentSettingsinApp = null, [WorkflowExpression] Func<bool> bodycontentSettingsteams = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowLikes = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowComments = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowImagesInComments = null, [WorkflowExpression] Func<string> bodypublicationDetailspinFromDate = null, [WorkflowExpression] Func<int> bodypublicationDetailspinDurationHours = null, [WorkflowExpression] Func<string> bodypublicationDetailsscheduledDateTime = null, [WorkflowExpression] Func<bool> bodypublicationDetailspublishImmediately = null, [WorkflowExpression] Func<int> bodypublicationDetailspublishAsUserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateArticleResponse> __BuildCreateArticle(WorkflowExpression<string> bodytitle, WorkflowExpression<bodypriorityInput> bodypriority, WorkflowExpression<bodyarticleTypeInput> bodyarticleType, WorkflowExpression<string> bodyhtmlContent, WorkflowExpression<string> bodytag, WorkflowExpression<string> bodymainImageUrl = null, WorkflowExpression<string> bodysummary = null, WorkflowExpression<int> bodychannelId = null, WorkflowExpression<bool> bodycontentSettingspush = null, WorkflowExpression<bool> bodycontentSettingssms = null, WorkflowExpression<bool> bodycontentSettingsemail = null, WorkflowExpression<bool> bodycontentSettingsinApp = null, WorkflowExpression<bool> bodycontentSettingsteams = null, WorkflowExpression<bool> bodycontentSettingsallowLikes = null, WorkflowExpression<bool> bodycontentSettingsallowComments = null, WorkflowExpression<bool> bodycontentSettingsallowImagesInComments = null, WorkflowExpression<string> bodypublicationDetailspinFromDate = null, WorkflowExpression<int> bodypublicationDetailspinDurationHours = null, WorkflowExpression<string> bodypublicationDetailsscheduledDateTime = null, WorkflowExpression<bool> bodypublicationDetailspublishImmediately = null, WorkflowExpression<int> bodypublicationDetailspublishAsUserId = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: true);
            WorkflowExpression.Validate(bodyarticleType, nameof(bodyarticleType), required: true);
            WorkflowExpression.Validate(bodyhtmlContent, nameof(bodyhtmlContent), required: true);
            WorkflowExpression.Validate(bodytag, nameof(bodytag), required: true);
            WorkflowExpression.Validate(bodymainImageUrl, nameof(bodymainImageUrl), required: false);
            WorkflowExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            WorkflowExpression.Validate(bodychannelId, nameof(bodychannelId), required: false);
            WorkflowExpression.Validate(bodycontentSettingspush, nameof(bodycontentSettingspush), required: false);
            WorkflowExpression.Validate(bodycontentSettingssms, nameof(bodycontentSettingssms), required: false);
            WorkflowExpression.Validate(bodycontentSettingsemail, nameof(bodycontentSettingsemail), required: false);
            WorkflowExpression.Validate(bodycontentSettingsinApp, nameof(bodycontentSettingsinApp), required: false);
            WorkflowExpression.Validate(bodycontentSettingsteams, nameof(bodycontentSettingsteams), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowLikes, nameof(bodycontentSettingsallowLikes), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowComments, nameof(bodycontentSettingsallowComments), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowImagesInComments, nameof(bodycontentSettingsallowImagesInComments), required: false);
            WorkflowExpression.Validate(bodypublicationDetailspinFromDate, nameof(bodypublicationDetailspinFromDate), required: false);
            WorkflowExpression.Validate(bodypublicationDetailspinDurationHours, nameof(bodypublicationDetailspinDurationHours), required: false);
            WorkflowExpression.Validate(bodypublicationDetailsscheduledDateTime, nameof(bodypublicationDetailsscheduledDateTime), required: false);
            WorkflowExpression.Validate(bodypublicationDetailspublishImmediately, nameof(bodypublicationDetailspublishImmediately), required: false);
            WorkflowExpression.Validate(bodypublicationDetailspublishAsUserId, nameof(bodypublicationDetailspublishAsUserId), required: false);
            return new DeferredBodyAction<CreateArticleResponse>(() =>
            {
                var apiCallPath = "/public/comms/v1/Articles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
                body["articleType"] = ExpressionConverter.ConvertO(bodyarticleType);
                bodypropCount++;
                body["htmlContent"] = ExpressionConverter.ConvertO(bodyhtmlContent);
                if (bodymainImageUrl != null)
                {
                    body["mainImageUrl"] = ExpressionConverter.ConvertO(bodymainImageUrl);
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                    bodypropCount++;
                }

                bodypropCount++;
                body["tag"] = ExpressionConverter.ConvertO(bodytag);
                if (bodychannelId != null)
                {
                    body["channelId"] = ExpressionConverter.ConvertO(bodychannelId);
                    bodypropCount++;
                }

                var contentSettingsObject = new JObject();
                var contentSettingsObjectpropCount = 0;
                if (bodycontentSettingspush != null)
                {
                    if (bodycontentSettingspush != null)
                    {
                        contentSettingsObject["push"] = ExpressionConverter.ConvertO(bodycontentSettingspush);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["push"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingssms != null)
                {
                    if (bodycontentSettingssms != null)
                    {
                        contentSettingsObject["sms"] = ExpressionConverter.ConvertO(bodycontentSettingssms);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["sms"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsemail != null)
                {
                    if (bodycontentSettingsemail != null)
                    {
                        contentSettingsObject["email"] = ExpressionConverter.ConvertO(bodycontentSettingsemail);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["email"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsinApp != null)
                {
                    if (bodycontentSettingsinApp != null)
                    {
                        contentSettingsObject["inApp"] = ExpressionConverter.ConvertO(bodycontentSettingsinApp);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["inApp"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsteams != null)
                {
                    if (bodycontentSettingsteams != null)
                    {
                        contentSettingsObject["teams"] = ExpressionConverter.ConvertO(bodycontentSettingsteams);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["teams"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowLikes != null)
                {
                    if (bodycontentSettingsallowLikes != null)
                    {
                        contentSettingsObject["allowLikes"] = ExpressionConverter.ConvertO(bodycontentSettingsallowLikes);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowLikes"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowComments != null)
                {
                    if (bodycontentSettingsallowComments != null)
                    {
                        contentSettingsObject["allowComments"] = ExpressionConverter.ConvertO(bodycontentSettingsallowComments);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["allowComments"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowImagesInComments != null)
                {
                    if (bodycontentSettingsallowImagesInComments != null)
                    {
                        contentSettingsObject["allowImagesInComments"] = ExpressionConverter.ConvertO(bodycontentSettingsallowImagesInComments);
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
                if (bodypublicationDetailspinFromDate != null)
                {
                    publicationDetailsObject["pinFromDate"] = ExpressionConverter.ConvertO(bodypublicationDetailspinFromDate);
                    publicationDetailsObjectpropCount++;
                }

                if (bodypublicationDetailspinDurationHours != null)
                {
                    publicationDetailsObject["pinDurationHours"] = ExpressionConverter.ConvertO(bodypublicationDetailspinDurationHours);
                    publicationDetailsObjectpropCount++;
                }

                if (bodypublicationDetailsscheduledDateTime != null)
                {
                    publicationDetailsObject["scheduledDateTime"] = ExpressionConverter.ConvertO(bodypublicationDetailsscheduledDateTime);
                    publicationDetailsObjectpropCount++;
                }

                if (bodypublicationDetailspublishImmediately != null)
                {
                    if (bodypublicationDetailspublishImmediately != null)
                    {
                        publicationDetailsObject["publishImmediately"] = ExpressionConverter.ConvertO(bodypublicationDetailspublishImmediately);
                        publicationDetailsObjectpropCount++;
                    }

                    publicationDetailsObjectpropCount++;
                }
                else
                {
                    publicationDetailsObject["publishImmediately"] = true;
                    publicationDetailsObjectpropCount++;
                }

                if (bodypublicationDetailspublishAsUserId != null)
                {
                    publicationDetailsObject["publishAsUserId"] = ExpressionConverter.ConvertO(bodypublicationDetailspublishAsUserId);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAlert))]
        public IBodyWorkflowAction<CreateAlertResponse> CreateAlert([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<bodypriorityInput> bodypriority, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<bool> bodyeveryone = null, [WorkflowExpression] Func<string> bodyaudiencedepartmentTags = null, [WorkflowExpression] Func<string> bodyaudiencepeopleTags = null, [WorkflowExpression] Func<string> bodyaudiencegroupTags = null, [WorkflowExpression] Func<string> bodyaudiencesiteTags = null, [WorkflowExpression] Func<bool> bodycommunicationMethodspush = null, [WorkflowExpression] Func<bool> bodycommunicationMethodssms = null, [WorkflowExpression] Func<bool> bodycommunicationMethodsemail = null, [WorkflowExpression] Func<bool> bodycommunicationMethodsinApp = null, [WorkflowExpression] Func<bool> bodycommunicationMethodsteams = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAlertResponse> __BuildCreateAlert(WorkflowExpression<string> bodytitle, WorkflowExpression<bodypriorityInput> bodypriority, WorkflowExpression<string> bodysummary = null, WorkflowExpression<bool> bodyeveryone = null, WorkflowExpression<string> bodyaudiencedepartmentTags = null, WorkflowExpression<string> bodyaudiencepeopleTags = null, WorkflowExpression<string> bodyaudiencegroupTags = null, WorkflowExpression<string> bodyaudiencesiteTags = null, WorkflowExpression<bool> bodycommunicationMethodspush = null, WorkflowExpression<bool> bodycommunicationMethodssms = null, WorkflowExpression<bool> bodycommunicationMethodsemail = null, WorkflowExpression<bool> bodycommunicationMethodsinApp = null, WorkflowExpression<bool> bodycommunicationMethodsteams = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: true);
            WorkflowExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            WorkflowExpression.Validate(bodyeveryone, nameof(bodyeveryone), required: false);
            WorkflowExpression.Validate(bodyaudiencedepartmentTags, nameof(bodyaudiencedepartmentTags), required: false);
            WorkflowExpression.Validate(bodyaudiencepeopleTags, nameof(bodyaudiencepeopleTags), required: false);
            WorkflowExpression.Validate(bodyaudiencegroupTags, nameof(bodyaudiencegroupTags), required: false);
            WorkflowExpression.Validate(bodyaudiencesiteTags, nameof(bodyaudiencesiteTags), required: false);
            WorkflowExpression.Validate(bodycommunicationMethodspush, nameof(bodycommunicationMethodspush), required: false);
            WorkflowExpression.Validate(bodycommunicationMethodssms, nameof(bodycommunicationMethodssms), required: false);
            WorkflowExpression.Validate(bodycommunicationMethodsemail, nameof(bodycommunicationMethodsemail), required: false);
            WorkflowExpression.Validate(bodycommunicationMethodsinApp, nameof(bodycommunicationMethodsinApp), required: false);
            WorkflowExpression.Validate(bodycommunicationMethodsteams, nameof(bodycommunicationMethodsteams), required: false);
            return new DeferredBodyAction<CreateAlertResponse>(() =>
            {
                var apiCallPath = "/public/comms/v1/Alerts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                if (bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                    bodypropCount++;
                }

                if (bodyeveryone != null)
                {
                    if (bodyeveryone != null)
                    {
                        body["everyone"] = ExpressionConverter.ConvertO(bodyeveryone);
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
                if (bodyaudiencedepartmentTags != null)
                {
                    audienceObject["departmentTags"] = ExpressionConverter.ConvertO(bodyaudiencedepartmentTags);
                    audienceObjectpropCount++;
                }

                if (bodyaudiencepeopleTags != null)
                {
                    audienceObject["peopleTags"] = ExpressionConverter.ConvertO(bodyaudiencepeopleTags);
                    audienceObjectpropCount++;
                }

                if (bodyaudiencegroupTags != null)
                {
                    audienceObject["groupTags"] = ExpressionConverter.ConvertO(bodyaudiencegroupTags);
                    audienceObjectpropCount++;
                }

                if (bodyaudiencesiteTags != null)
                {
                    audienceObject["siteTags"] = ExpressionConverter.ConvertO(bodyaudiencesiteTags);
                    audienceObjectpropCount++;
                }

                if (audienceObjectpropCount > 0)
                {
                    body["audience"] = audienceObject;
                    bodypropCount++;
                }

                var communicationMethodsObject = new JObject();
                var communicationMethodsObjectpropCount = 0;
                if (bodycommunicationMethodspush != null)
                {
                    if (bodycommunicationMethodspush != null)
                    {
                        communicationMethodsObject["push"] = ExpressionConverter.ConvertO(bodycommunicationMethodspush);
                        communicationMethodsObjectpropCount++;
                    }

                    communicationMethodsObjectpropCount++;
                }
                else
                {
                    communicationMethodsObject["push"] = false;
                    communicationMethodsObjectpropCount++;
                }

                if (bodycommunicationMethodssms != null)
                {
                    if (bodycommunicationMethodssms != null)
                    {
                        communicationMethodsObject["sms"] = ExpressionConverter.ConvertO(bodycommunicationMethodssms);
                        communicationMethodsObjectpropCount++;
                    }

                    communicationMethodsObjectpropCount++;
                }
                else
                {
                    communicationMethodsObject["sms"] = false;
                    communicationMethodsObjectpropCount++;
                }

                if (bodycommunicationMethodsemail != null)
                {
                    if (bodycommunicationMethodsemail != null)
                    {
                        communicationMethodsObject["email"] = ExpressionConverter.ConvertO(bodycommunicationMethodsemail);
                        communicationMethodsObjectpropCount++;
                    }

                    communicationMethodsObjectpropCount++;
                }
                else
                {
                    communicationMethodsObject["email"] = true;
                    communicationMethodsObjectpropCount++;
                }

                if (bodycommunicationMethodsinApp != null)
                {
                    if (bodycommunicationMethodsinApp != null)
                    {
                        communicationMethodsObject["inApp"] = ExpressionConverter.ConvertO(bodycommunicationMethodsinApp);
                        communicationMethodsObjectpropCount++;
                    }

                    communicationMethodsObjectpropCount++;
                }
                else
                {
                    communicationMethodsObject["inApp"] = true;
                    communicationMethodsObjectpropCount++;
                }

                if (bodycommunicationMethodsteams != null)
                {
                    if (bodycommunicationMethodsteams != null)
                    {
                        communicationMethodsObject["teams"] = ExpressionConverter.ConvertO(bodycommunicationMethodsteams);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<int> bodyformId, [WorkflowExpression] Func<int> bodytaskGroupId, [WorkflowExpression] Func<int> bodypriorityId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<int> bodyassignedToId = null, [WorkflowExpression] Func<int> bodymanagerId = null, [WorkflowExpression] Func<string> bodyassignedToEmail = null, [WorkflowExpression] Func<string> bodymanagerEmail = null, [WorkflowExpression] Func<int> bodytaskIntervalId = null, [WorkflowExpression] Func<bool> bodycontentSettingspush = null, [WorkflowExpression] Func<bool> bodycontentSettingssms = null, [WorkflowExpression] Func<bool> bodycontentSettingsemail = null, [WorkflowExpression] Func<bool> bodycontentSettingsteams = null, [WorkflowExpression] Func<bool> bodycontentSettingsinApp = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowLikes = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowComments = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowImagesInComments = null, [WorkflowExpression] Func<bool> bodycontentSettingsallowDocuments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTaskResponse> __BuildCreateTask(WorkflowExpression<string> bodytitle, WorkflowExpression<int> bodyformId, WorkflowExpression<int> bodytaskGroupId, WorkflowExpression<int> bodypriorityId = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<int> bodyassignedToId = null, WorkflowExpression<int> bodymanagerId = null, WorkflowExpression<string> bodyassignedToEmail = null, WorkflowExpression<string> bodymanagerEmail = null, WorkflowExpression<int> bodytaskIntervalId = null, WorkflowExpression<bool> bodycontentSettingspush = null, WorkflowExpression<bool> bodycontentSettingssms = null, WorkflowExpression<bool> bodycontentSettingsemail = null, WorkflowExpression<bool> bodycontentSettingsteams = null, WorkflowExpression<bool> bodycontentSettingsinApp = null, WorkflowExpression<bool> bodycontentSettingsallowLikes = null, WorkflowExpression<bool> bodycontentSettingsallowComments = null, WorkflowExpression<bool> bodycontentSettingsallowImagesInComments = null, WorkflowExpression<bool> bodycontentSettingsallowDocuments = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodyformId, nameof(bodyformId), required: true);
            WorkflowExpression.Validate(bodytaskGroupId, nameof(bodytaskGroupId), required: true);
            WorkflowExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            WorkflowExpression.Validate(bodymanagerId, nameof(bodymanagerId), required: false);
            WorkflowExpression.Validate(bodyassignedToEmail, nameof(bodyassignedToEmail), required: false);
            WorkflowExpression.Validate(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            WorkflowExpression.Validate(bodytaskIntervalId, nameof(bodytaskIntervalId), required: false);
            WorkflowExpression.Validate(bodycontentSettingspush, nameof(bodycontentSettingspush), required: false);
            WorkflowExpression.Validate(bodycontentSettingssms, nameof(bodycontentSettingssms), required: false);
            WorkflowExpression.Validate(bodycontentSettingsemail, nameof(bodycontentSettingsemail), required: false);
            WorkflowExpression.Validate(bodycontentSettingsteams, nameof(bodycontentSettingsteams), required: false);
            WorkflowExpression.Validate(bodycontentSettingsinApp, nameof(bodycontentSettingsinApp), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowLikes, nameof(bodycontentSettingsallowLikes), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowComments, nameof(bodycontentSettingsallowComments), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowImagesInComments, nameof(bodycontentSettingsallowImagesInComments), required: false);
            WorkflowExpression.Validate(bodycontentSettingsallowDocuments, nameof(bodycontentSettingsallowDocuments), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = "/public/tasks/v1/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(bodypriorityId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["formId"] = ExpressionConverter.ConvertO(bodyformId);
                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(bodymanagerId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["taskGroupId"] = ExpressionConverter.ConvertO(bodytaskGroupId);
                if (bodyassignedToEmail != null)
                {
                    body["assignedToEmail"] = ExpressionConverter.ConvertO(bodyassignedToEmail);
                    bodypropCount++;
                }

                if (bodymanagerEmail != null)
                {
                    body["managerEmail"] = ExpressionConverter.ConvertO(bodymanagerEmail);
                    bodypropCount++;
                }

                if (bodytaskIntervalId != null)
                {
                    body["taskIntervalId"] = ExpressionConverter.ConvertO(bodytaskIntervalId);
                    bodypropCount++;
                }

                var contentSettingsObject = new JObject();
                var contentSettingsObjectpropCount = 0;
                if (bodycontentSettingspush != null)
                {
                    if (bodycontentSettingspush != null)
                    {
                        contentSettingsObject["push"] = ExpressionConverter.ConvertO(bodycontentSettingspush);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["push"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingssms != null)
                {
                    if (bodycontentSettingssms != null)
                    {
                        contentSettingsObject["sms"] = ExpressionConverter.ConvertO(bodycontentSettingssms);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["sms"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsemail != null)
                {
                    if (bodycontentSettingsemail != null)
                    {
                        contentSettingsObject["email"] = ExpressionConverter.ConvertO(bodycontentSettingsemail);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["email"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsteams != null)
                {
                    if (bodycontentSettingsteams != null)
                    {
                        contentSettingsObject["teams"] = ExpressionConverter.ConvertO(bodycontentSettingsteams);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["teams"] = false;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsinApp != null)
                {
                    if (bodycontentSettingsinApp != null)
                    {
                        contentSettingsObject["inApp"] = ExpressionConverter.ConvertO(bodycontentSettingsinApp);
                        contentSettingsObjectpropCount++;
                    }

                    contentSettingsObjectpropCount++;
                }
                else
                {
                    contentSettingsObject["inApp"] = true;
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowLikes != null)
                {
                    contentSettingsObject["allowLikes"] = ExpressionConverter.ConvertO(bodycontentSettingsallowLikes);
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowComments != null)
                {
                    contentSettingsObject["allowComments"] = ExpressionConverter.ConvertO(bodycontentSettingsallowComments);
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowImagesInComments != null)
                {
                    contentSettingsObject["allowImagesInComments"] = ExpressionConverter.ConvertO(bodycontentSettingsallowImagesInComments);
                    contentSettingsObjectpropCount++;
                }

                if (bodycontentSettingsallowDocuments != null)
                {
                    contentSettingsObject["allowDocuments"] = ExpressionConverter.ConvertO(bodycontentSettingsallowDocuments);
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
            });
        }
    }

    public class StaffcircleTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildNewPerson))]
        public IBodyWorkflowTrigger<JToken> NewPerson([WorkflowExpression] Func<string> bodyname,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildNewPerson(WorkflowExpression<string> bodyname,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
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
                body["name"] = ExpressionConverter.ConvertO(bodyname);
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
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildNewObjective))]
        public IBodyWorkflowTrigger<JToken> NewObjective([WorkflowExpression] Func<string> bodyname,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildNewObjective(WorkflowExpression<string> bodyname,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
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
                body["name"] = ExpressionConverter.ConvertO(bodyname);
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
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildUpdateObjective))]
        public IBodyWorkflowTrigger<JToken> UpdateObjective([WorkflowExpression] Func<string> bodyname,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildUpdateObjective(WorkflowExpression<string> bodyname,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
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
                body["name"] = ExpressionConverter.ConvertO(bodyname);
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
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildPublishedArticle))]
        public IBodyWorkflowTrigger<JToken> PublishedArticle([WorkflowExpression] Func<string> bodyname = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildPublishedArticle(WorkflowExpression<string> bodyname = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/Public/Security/v1/Webhooks/NewArticle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["authType"] = "none";
                bodypropCount++;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
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
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildNewTask))]
        public IBodyWorkflowTrigger<JToken> NewTask([WorkflowExpression] Func<string> bodyname,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildNewTask(WorkflowExpression<string> bodyname,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
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
                body["name"] = ExpressionConverter.ConvertO(bodyname);
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
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildNewReview))]
        public IBodyWorkflowTrigger<JToken> NewReview([WorkflowExpression] Func<string> bodyname,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildNewReview(WorkflowExpression<string> bodyname,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
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
                body["name"] = ExpressionConverter.ConvertO(bodyname);
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
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildNewAbsence))]
        public IBodyWorkflowTrigger<JToken> NewAbsence([WorkflowExpression] Func<string> bodyname,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildNewAbsence(WorkflowExpression<string> bodyname,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
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
                body["name"] = ExpressionConverter.ConvertO(bodyname);
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
            });
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