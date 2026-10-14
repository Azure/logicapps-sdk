//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Staffcircle
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class StaffcircleActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<GetPersonResponse> GetPerson(Expression<Func<string>> searchEmail)
        {
            var __workflow_searchEmail = searchEmail == null ? null : WorkflowExpression.Compile(searchEmail);
            WorkflowExpression.Validate(__workflow_searchEmail, nameof(searchEmail), required: true);
            return new DeferredBodyAction<GetPersonResponse>(() =>
            {
                var apiCallPath = "/public/directory/v1/persons";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SearchEmail"] = ExpressionConverter.Convert(__workflow_searchEmail);
                return new ApiConnectionAction<GetPersonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreatePersonResponse> CreatePerson(Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodysecondName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodymobile, Expression<Func<string>> bodydateOfBirth, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodytown = null, Expression<Func<string>> bodypostCode = null, Expression<Func<string>> bodycountyName = null, Expression<Func<string>> bodycountryName = null, Expression<Func<string>> bodytitleName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyhomeEmail = null, Expression<Func<string>> bodyhomeTelephone = null, Expression<Func<string>> bodytag = null, Expression<Func<string>> bodymanagerEmail = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<string>> bodyroleName = null, Expression<Func<string>> bodyknownAs = null, Expression<Func<string>> bodyavatarURL = null, Expression<Func<int>> bodytitleId = null, Expression<Func<int>> bodycountyId = null, Expression<Func<int>> bodycountryId = null, Expression<Func<int>> bodygenderId = null, Expression<Func<int>> bodynationalityId = null, Expression<Func<int>> bodyethnicityId = null, Expression<Func<int>> bodymaritalStatusId = null, Expression<Func<int>> bodymanagerId = null, Expression<Func<int>> bodydepartmentId = null, Expression<Func<int>> bodyroleId = null, Expression<Func<int>> bodymainSiteId = null, Expression<Func<bool>> bodyemergencyContactConsent = null, Expression<Func<string>> bodyemergencyContactName = null, Expression<Func<int>> bodyemergencyRelationshipId = null, Expression<Func<string>> bodyemergencyContactTelephone = null, Expression<Func<string>> bodyemergencyAddress = null, Expression<Func<string>> bodynextOfKinName = null, Expression<Func<int>> bodynextOfKinRelationshipId = null, Expression<Func<string>> bodynextOfKinTelephone = null, Expression<Func<string>> bodydialingCode = null, Expression<Func<string>> bodyworkExtension = null, Expression<Func<string>> bodytelephone = null, Expression<Func<string>> bodypersonalMobile = null, Expression<Func<int>> bodystatusId = null, Expression<Func<int>> bodyemploymentTypeId = null, Expression<Func<int>> bodycontractTypeId = null, Expression<Func<string>> bodycontractExpiry = null, Expression<Func<int>> bodyemploymentStatusId = null, Expression<Func<int>> bodysecondaryEmploymentStatusId = null, Expression<Func<string>> bodyemploymentNotes = null, Expression<Func<string>> bodymedicalNotes = null, Expression<Func<bool>> bodyisPersonalDataEnabled = null, Expression<Func<bool>> bodyisContactDataEnabled = null, Expression<Func<bodytimeZoneInput>> bodytimeZone = null)
        {
            var __workflow_bodyfirstName = bodyfirstName == null ? null : WorkflowExpression.Compile(bodyfirstName);
            WorkflowExpression.Validate(__workflow_bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodysecondName = bodysecondName == null ? null : WorkflowExpression.Compile(bodysecondName);
            WorkflowExpression.Validate(__workflow_bodysecondName, nameof(bodysecondName), required: true);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodymobile = bodymobile == null ? null : WorkflowExpression.Compile(bodymobile);
            WorkflowExpression.Validate(__workflow_bodymobile, nameof(bodymobile), required: true);
            var __workflow_bodydateOfBirth = bodydateOfBirth == null ? null : WorkflowExpression.Compile(bodydateOfBirth);
            WorkflowExpression.Validate(__workflow_bodydateOfBirth, nameof(bodydateOfBirth), required: true);
            var __workflow_bodystartDate = bodystartDate == null ? null : WorkflowExpression.Compile(bodystartDate);
            WorkflowExpression.Validate(__workflow_bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodyaddressLine1 = bodyaddressLine1 == null ? null : WorkflowExpression.Compile(bodyaddressLine1);
            WorkflowExpression.Validate(__workflow_bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            var __workflow_bodyaddressLine2 = bodyaddressLine2 == null ? null : WorkflowExpression.Compile(bodyaddressLine2);
            WorkflowExpression.Validate(__workflow_bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            var __workflow_bodytown = bodytown == null ? null : WorkflowExpression.Compile(bodytown);
            WorkflowExpression.Validate(__workflow_bodytown, nameof(bodytown), required: false);
            var __workflow_bodypostCode = bodypostCode == null ? null : WorkflowExpression.Compile(bodypostCode);
            WorkflowExpression.Validate(__workflow_bodypostCode, nameof(bodypostCode), required: false);
            var __workflow_bodycountyName = bodycountyName == null ? null : WorkflowExpression.Compile(bodycountyName);
            WorkflowExpression.Validate(__workflow_bodycountyName, nameof(bodycountyName), required: false);
            var __workflow_bodycountryName = bodycountryName == null ? null : WorkflowExpression.Compile(bodycountryName);
            WorkflowExpression.Validate(__workflow_bodycountryName, nameof(bodycountryName), required: false);
            var __workflow_bodytitleName = bodytitleName == null ? null : WorkflowExpression.Compile(bodytitleName);
            WorkflowExpression.Validate(__workflow_bodytitleName, nameof(bodytitleName), required: false);
            var __workflow_bodymiddleName = bodymiddleName == null ? null : WorkflowExpression.Compile(bodymiddleName);
            WorkflowExpression.Validate(__workflow_bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodyhomeEmail = bodyhomeEmail == null ? null : WorkflowExpression.Compile(bodyhomeEmail);
            WorkflowExpression.Validate(__workflow_bodyhomeEmail, nameof(bodyhomeEmail), required: false);
            var __workflow_bodyhomeTelephone = bodyhomeTelephone == null ? null : WorkflowExpression.Compile(bodyhomeTelephone);
            WorkflowExpression.Validate(__workflow_bodyhomeTelephone, nameof(bodyhomeTelephone), required: false);
            var __workflow_bodytag = bodytag == null ? null : WorkflowExpression.Compile(bodytag);
            WorkflowExpression.Validate(__workflow_bodytag, nameof(bodytag), required: false);
            var __workflow_bodymanagerEmail = bodymanagerEmail == null ? null : WorkflowExpression.Compile(bodymanagerEmail);
            WorkflowExpression.Validate(__workflow_bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            var __workflow_bodydepartmentName = bodydepartmentName == null ? null : WorkflowExpression.Compile(bodydepartmentName);
            WorkflowExpression.Validate(__workflow_bodydepartmentName, nameof(bodydepartmentName), required: false);
            var __workflow_bodyroleName = bodyroleName == null ? null : WorkflowExpression.Compile(bodyroleName);
            WorkflowExpression.Validate(__workflow_bodyroleName, nameof(bodyroleName), required: false);
            var __workflow_bodyknownAs = bodyknownAs == null ? null : WorkflowExpression.Compile(bodyknownAs);
            WorkflowExpression.Validate(__workflow_bodyknownAs, nameof(bodyknownAs), required: false);
            var __workflow_bodyavatarURL = bodyavatarURL == null ? null : WorkflowExpression.Compile(bodyavatarURL);
            WorkflowExpression.Validate(__workflow_bodyavatarURL, nameof(bodyavatarURL), required: false);
            var __workflow_bodytitleId = bodytitleId == null ? null : WorkflowExpression.Compile(bodytitleId);
            WorkflowExpression.Validate(__workflow_bodytitleId, nameof(bodytitleId), required: false);
            var __workflow_bodycountyId = bodycountyId == null ? null : WorkflowExpression.Compile(bodycountyId);
            WorkflowExpression.Validate(__workflow_bodycountyId, nameof(bodycountyId), required: false);
            var __workflow_bodycountryId = bodycountryId == null ? null : WorkflowExpression.Compile(bodycountryId);
            WorkflowExpression.Validate(__workflow_bodycountryId, nameof(bodycountryId), required: false);
            var __workflow_bodygenderId = bodygenderId == null ? null : WorkflowExpression.Compile(bodygenderId);
            WorkflowExpression.Validate(__workflow_bodygenderId, nameof(bodygenderId), required: false);
            var __workflow_bodynationalityId = bodynationalityId == null ? null : WorkflowExpression.Compile(bodynationalityId);
            WorkflowExpression.Validate(__workflow_bodynationalityId, nameof(bodynationalityId), required: false);
            var __workflow_bodyethnicityId = bodyethnicityId == null ? null : WorkflowExpression.Compile(bodyethnicityId);
            WorkflowExpression.Validate(__workflow_bodyethnicityId, nameof(bodyethnicityId), required: false);
            var __workflow_bodymaritalStatusId = bodymaritalStatusId == null ? null : WorkflowExpression.Compile(bodymaritalStatusId);
            WorkflowExpression.Validate(__workflow_bodymaritalStatusId, nameof(bodymaritalStatusId), required: false);
            var __workflow_bodymanagerId = bodymanagerId == null ? null : WorkflowExpression.Compile(bodymanagerId);
            WorkflowExpression.Validate(__workflow_bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodydepartmentId = bodydepartmentId == null ? null : WorkflowExpression.Compile(bodydepartmentId);
            WorkflowExpression.Validate(__workflow_bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodyroleId = bodyroleId == null ? null : WorkflowExpression.Compile(bodyroleId);
            WorkflowExpression.Validate(__workflow_bodyroleId, nameof(bodyroleId), required: false);
            var __workflow_bodymainSiteId = bodymainSiteId == null ? null : WorkflowExpression.Compile(bodymainSiteId);
            WorkflowExpression.Validate(__workflow_bodymainSiteId, nameof(bodymainSiteId), required: false);
            var __workflow_bodyemergencyContactConsent = bodyemergencyContactConsent == null ? null : WorkflowExpression.Compile(bodyemergencyContactConsent);
            WorkflowExpression.Validate(__workflow_bodyemergencyContactConsent, nameof(bodyemergencyContactConsent), required: false);
            var __workflow_bodyemergencyContactName = bodyemergencyContactName == null ? null : WorkflowExpression.Compile(bodyemergencyContactName);
            WorkflowExpression.Validate(__workflow_bodyemergencyContactName, nameof(bodyemergencyContactName), required: false);
            var __workflow_bodyemergencyRelationshipId = bodyemergencyRelationshipId == null ? null : WorkflowExpression.Compile(bodyemergencyRelationshipId);
            WorkflowExpression.Validate(__workflow_bodyemergencyRelationshipId, nameof(bodyemergencyRelationshipId), required: false);
            var __workflow_bodyemergencyContactTelephone = bodyemergencyContactTelephone == null ? null : WorkflowExpression.Compile(bodyemergencyContactTelephone);
            WorkflowExpression.Validate(__workflow_bodyemergencyContactTelephone, nameof(bodyemergencyContactTelephone), required: false);
            var __workflow_bodyemergencyAddress = bodyemergencyAddress == null ? null : WorkflowExpression.Compile(bodyemergencyAddress);
            WorkflowExpression.Validate(__workflow_bodyemergencyAddress, nameof(bodyemergencyAddress), required: false);
            var __workflow_bodynextOfKinName = bodynextOfKinName == null ? null : WorkflowExpression.Compile(bodynextOfKinName);
            WorkflowExpression.Validate(__workflow_bodynextOfKinName, nameof(bodynextOfKinName), required: false);
            var __workflow_bodynextOfKinRelationshipId = bodynextOfKinRelationshipId == null ? null : WorkflowExpression.Compile(bodynextOfKinRelationshipId);
            WorkflowExpression.Validate(__workflow_bodynextOfKinRelationshipId, nameof(bodynextOfKinRelationshipId), required: false);
            var __workflow_bodynextOfKinTelephone = bodynextOfKinTelephone == null ? null : WorkflowExpression.Compile(bodynextOfKinTelephone);
            WorkflowExpression.Validate(__workflow_bodynextOfKinTelephone, nameof(bodynextOfKinTelephone), required: false);
            var __workflow_bodydialingCode = bodydialingCode == null ? null : WorkflowExpression.Compile(bodydialingCode);
            WorkflowExpression.Validate(__workflow_bodydialingCode, nameof(bodydialingCode), required: false);
            var __workflow_bodyworkExtension = bodyworkExtension == null ? null : WorkflowExpression.Compile(bodyworkExtension);
            WorkflowExpression.Validate(__workflow_bodyworkExtension, nameof(bodyworkExtension), required: false);
            var __workflow_bodytelephone = bodytelephone == null ? null : WorkflowExpression.Compile(bodytelephone);
            WorkflowExpression.Validate(__workflow_bodytelephone, nameof(bodytelephone), required: false);
            var __workflow_bodypersonalMobile = bodypersonalMobile == null ? null : WorkflowExpression.Compile(bodypersonalMobile);
            WorkflowExpression.Validate(__workflow_bodypersonalMobile, nameof(bodypersonalMobile), required: false);
            var __workflow_bodystatusId = bodystatusId == null ? null : WorkflowExpression.Compile(bodystatusId);
            WorkflowExpression.Validate(__workflow_bodystatusId, nameof(bodystatusId), required: false);
            var __workflow_bodyemploymentTypeId = bodyemploymentTypeId == null ? null : WorkflowExpression.Compile(bodyemploymentTypeId);
            WorkflowExpression.Validate(__workflow_bodyemploymentTypeId, nameof(bodyemploymentTypeId), required: false);
            var __workflow_bodycontractTypeId = bodycontractTypeId == null ? null : WorkflowExpression.Compile(bodycontractTypeId);
            WorkflowExpression.Validate(__workflow_bodycontractTypeId, nameof(bodycontractTypeId), required: false);
            var __workflow_bodycontractExpiry = bodycontractExpiry == null ? null : WorkflowExpression.Compile(bodycontractExpiry);
            WorkflowExpression.Validate(__workflow_bodycontractExpiry, nameof(bodycontractExpiry), required: false);
            var __workflow_bodyemploymentStatusId = bodyemploymentStatusId == null ? null : WorkflowExpression.Compile(bodyemploymentStatusId);
            WorkflowExpression.Validate(__workflow_bodyemploymentStatusId, nameof(bodyemploymentStatusId), required: false);
            var __workflow_bodysecondaryEmploymentStatusId = bodysecondaryEmploymentStatusId == null ? null : WorkflowExpression.Compile(bodysecondaryEmploymentStatusId);
            WorkflowExpression.Validate(__workflow_bodysecondaryEmploymentStatusId, nameof(bodysecondaryEmploymentStatusId), required: false);
            var __workflow_bodyemploymentNotes = bodyemploymentNotes == null ? null : WorkflowExpression.Compile(bodyemploymentNotes);
            WorkflowExpression.Validate(__workflow_bodyemploymentNotes, nameof(bodyemploymentNotes), required: false);
            var __workflow_bodymedicalNotes = bodymedicalNotes == null ? null : WorkflowExpression.Compile(bodymedicalNotes);
            WorkflowExpression.Validate(__workflow_bodymedicalNotes, nameof(bodymedicalNotes), required: false);
            var __workflow_bodyisPersonalDataEnabled = bodyisPersonalDataEnabled == null ? null : WorkflowExpression.Compile(bodyisPersonalDataEnabled);
            WorkflowExpression.Validate(__workflow_bodyisPersonalDataEnabled, nameof(bodyisPersonalDataEnabled), required: false);
            var __workflow_bodyisContactDataEnabled = bodyisContactDataEnabled == null ? null : WorkflowExpression.Compile(bodyisContactDataEnabled);
            WorkflowExpression.Validate(__workflow_bodyisContactDataEnabled, nameof(bodyisContactDataEnabled), required: false);
            var __workflow_bodytimeZone = bodytimeZone == null ? null : WorkflowExpression.Compile(bodytimeZone);
            WorkflowExpression.Validate(__workflow_bodytimeZone, nameof(bodytimeZone), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<GetObjectivesResponse> GetObjectives(Expression<Func<string>> searchTitle = null, Expression<Func<string>> personEmail = null, Expression<Func<string>> tag = null, Expression<Func<string>> closed = null, Expression<Func<objectiveTypeInput>> objectiveType = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<string>> activeAt = null)
        {
            var __workflow_searchTitle = searchTitle == null ? null : WorkflowExpression.Compile(searchTitle);
            WorkflowExpression.Validate(__workflow_searchTitle, nameof(searchTitle), required: false);
            var __workflow_personEmail = personEmail == null ? null : WorkflowExpression.Compile(personEmail);
            WorkflowExpression.Validate(__workflow_personEmail, nameof(personEmail), required: false);
            var __workflow_tag = tag == null ? null : WorkflowExpression.Compile(tag);
            WorkflowExpression.Validate(__workflow_tag, nameof(tag), required: false);
            var __workflow_closed = closed == null ? null : WorkflowExpression.Compile(closed);
            WorkflowExpression.Validate(__workflow_closed, nameof(closed), required: false);
            var __workflow_objectiveType = objectiveType == null ? null : WorkflowExpression.Compile(objectiveType);
            WorkflowExpression.Validate(__workflow_objectiveType, nameof(objectiveType), required: false);
            var __workflow_from = from == null ? null : WorkflowExpression.Compile(from);
            WorkflowExpression.Validate(__workflow_from, nameof(from), required: false);
            var __workflow_to = to == null ? null : WorkflowExpression.Compile(to);
            WorkflowExpression.Validate(__workflow_to, nameof(to), required: false);
            var __workflow_activeAt = activeAt == null ? null : WorkflowExpression.Compile(activeAt);
            WorkflowExpression.Validate(__workflow_activeAt, nameof(activeAt), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateObjectiveByTemplateResponse> CreateObjectiveByTemplate(Expression<Func<int>> bodyobjectiveTemplateId, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyendDate, Expression<Func<string>> bodypersonEmail = null, Expression<Func<int>> bodypersonId = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<int>> bodydepartmentId = null, Expression<Func<string>> bodymanagerEmail = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodymanagerId = null, Expression<Func<int>> bodycompanyObjectiveId = null, Expression<Func<int>> bodydepartmentObjectiveId = null)
        {
            var __workflow_bodyobjectiveTemplateId = bodyobjectiveTemplateId == null ? null : WorkflowExpression.Compile(bodyobjectiveTemplateId);
            WorkflowExpression.Validate(__workflow_bodyobjectiveTemplateId, nameof(bodyobjectiveTemplateId), required: true);
            var __workflow_bodystartDate = bodystartDate == null ? null : WorkflowExpression.Compile(bodystartDate);
            WorkflowExpression.Validate(__workflow_bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodyendDate = bodyendDate == null ? null : WorkflowExpression.Compile(bodyendDate);
            WorkflowExpression.Validate(__workflow_bodyendDate, nameof(bodyendDate), required: true);
            var __workflow_bodypersonEmail = bodypersonEmail == null ? null : WorkflowExpression.Compile(bodypersonEmail);
            WorkflowExpression.Validate(__workflow_bodypersonEmail, nameof(bodypersonEmail), required: false);
            var __workflow_bodypersonId = bodypersonId == null ? null : WorkflowExpression.Compile(bodypersonId);
            WorkflowExpression.Validate(__workflow_bodypersonId, nameof(bodypersonId), required: false);
            var __workflow_bodydepartmentName = bodydepartmentName == null ? null : WorkflowExpression.Compile(bodydepartmentName);
            WorkflowExpression.Validate(__workflow_bodydepartmentName, nameof(bodydepartmentName), required: false);
            var __workflow_bodydepartmentId = bodydepartmentId == null ? null : WorkflowExpression.Compile(bodydepartmentId);
            WorkflowExpression.Validate(__workflow_bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodymanagerEmail = bodymanagerEmail == null ? null : WorkflowExpression.Compile(bodymanagerEmail);
            WorkflowExpression.Validate(__workflow_bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodymanagerId = bodymanagerId == null ? null : WorkflowExpression.Compile(bodymanagerId);
            WorkflowExpression.Validate(__workflow_bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodycompanyObjectiveId = bodycompanyObjectiveId == null ? null : WorkflowExpression.Compile(bodycompanyObjectiveId);
            WorkflowExpression.Validate(__workflow_bodycompanyObjectiveId, nameof(bodycompanyObjectiveId), required: false);
            var __workflow_bodydepartmentObjectiveId = bodydepartmentObjectiveId == null ? null : WorkflowExpression.Compile(bodydepartmentObjectiveId);
            WorkflowExpression.Validate(__workflow_bodydepartmentObjectiveId, nameof(bodydepartmentObjectiveId), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateObjectiveResponse> CreateObjective(Expression<Func<int>> bodycategoryId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyendDate, Expression<Func<bodyvalueTypeInput>> bodyvalueType, Expression<Func<string>> bodytag = null, Expression<Func<string>> bodymanagerEmail = null, Expression<Func<int>> bodymanagerId = null, Expression<Func<string>> bodypersonEmail = null, Expression<Func<int>> bodypersonId = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<int>> bodydepartmentId = null, Expression<Func<int>> bodycompanyObjectiveId = null, Expression<Func<int>> bodydepartmentObjectiveId = null, Expression<Func<double>> bodystartValue = null, Expression<Func<double>> bodytarget = null, Expression<Func<bool>> bodyallowAddProgress = null, Expression<Func<bodyrecurTypeInput>> bodyrecurType = null, Expression<Func<int>> bodyrecurInterval = null, Expression<Func<bool>> bodycumulativeProgress = null, Expression<Func<bool>> bodycontentSettingspush = null, Expression<Func<bool>> bodycontentSettingssms = null, Expression<Func<bool>> bodycontentSettingsemail = null, Expression<Func<bool>> bodycontentSettingsteams = null, Expression<Func<bool>> bodycontentSettingsinApp = null, Expression<Func<bool>> bodycontentSettingsallowLikes = null, Expression<Func<bool>> bodycontentSettingsallowComments = null, Expression<Func<bool>> bodycontentSettingsallowImagesInComments = null, Expression<Func<bool>> bodycontentSettingsallowDocuments = null)
        {
            var __workflow_bodycategoryId = bodycategoryId == null ? null : WorkflowExpression.Compile(bodycategoryId);
            WorkflowExpression.Validate(__workflow_bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodystartDate = bodystartDate == null ? null : WorkflowExpression.Compile(bodystartDate);
            WorkflowExpression.Validate(__workflow_bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodyendDate = bodyendDate == null ? null : WorkflowExpression.Compile(bodyendDate);
            WorkflowExpression.Validate(__workflow_bodyendDate, nameof(bodyendDate), required: true);
            var __workflow_bodyvalueType = bodyvalueType == null ? null : WorkflowExpression.Compile(bodyvalueType);
            WorkflowExpression.Validate(__workflow_bodyvalueType, nameof(bodyvalueType), required: true);
            var __workflow_bodytag = bodytag == null ? null : WorkflowExpression.Compile(bodytag);
            WorkflowExpression.Validate(__workflow_bodytag, nameof(bodytag), required: false);
            var __workflow_bodymanagerEmail = bodymanagerEmail == null ? null : WorkflowExpression.Compile(bodymanagerEmail);
            WorkflowExpression.Validate(__workflow_bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            var __workflow_bodymanagerId = bodymanagerId == null ? null : WorkflowExpression.Compile(bodymanagerId);
            WorkflowExpression.Validate(__workflow_bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodypersonEmail = bodypersonEmail == null ? null : WorkflowExpression.Compile(bodypersonEmail);
            WorkflowExpression.Validate(__workflow_bodypersonEmail, nameof(bodypersonEmail), required: false);
            var __workflow_bodypersonId = bodypersonId == null ? null : WorkflowExpression.Compile(bodypersonId);
            WorkflowExpression.Validate(__workflow_bodypersonId, nameof(bodypersonId), required: false);
            var __workflow_bodydepartmentName = bodydepartmentName == null ? null : WorkflowExpression.Compile(bodydepartmentName);
            WorkflowExpression.Validate(__workflow_bodydepartmentName, nameof(bodydepartmentName), required: false);
            var __workflow_bodydepartmentId = bodydepartmentId == null ? null : WorkflowExpression.Compile(bodydepartmentId);
            WorkflowExpression.Validate(__workflow_bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodycompanyObjectiveId = bodycompanyObjectiveId == null ? null : WorkflowExpression.Compile(bodycompanyObjectiveId);
            WorkflowExpression.Validate(__workflow_bodycompanyObjectiveId, nameof(bodycompanyObjectiveId), required: false);
            var __workflow_bodydepartmentObjectiveId = bodydepartmentObjectiveId == null ? null : WorkflowExpression.Compile(bodydepartmentObjectiveId);
            WorkflowExpression.Validate(__workflow_bodydepartmentObjectiveId, nameof(bodydepartmentObjectiveId), required: false);
            var __workflow_bodystartValue = bodystartValue == null ? null : WorkflowExpression.Compile(bodystartValue);
            WorkflowExpression.Validate(__workflow_bodystartValue, nameof(bodystartValue), required: false);
            var __workflow_bodytarget = bodytarget == null ? null : WorkflowExpression.Compile(bodytarget);
            WorkflowExpression.Validate(__workflow_bodytarget, nameof(bodytarget), required: false);
            var __workflow_bodyallowAddProgress = bodyallowAddProgress == null ? null : WorkflowExpression.Compile(bodyallowAddProgress);
            WorkflowExpression.Validate(__workflow_bodyallowAddProgress, nameof(bodyallowAddProgress), required: false);
            var __workflow_bodyrecurType = bodyrecurType == null ? null : WorkflowExpression.Compile(bodyrecurType);
            WorkflowExpression.Validate(__workflow_bodyrecurType, nameof(bodyrecurType), required: false);
            var __workflow_bodyrecurInterval = bodyrecurInterval == null ? null : WorkflowExpression.Compile(bodyrecurInterval);
            WorkflowExpression.Validate(__workflow_bodyrecurInterval, nameof(bodyrecurInterval), required: false);
            var __workflow_bodycumulativeProgress = bodycumulativeProgress == null ? null : WorkflowExpression.Compile(bodycumulativeProgress);
            WorkflowExpression.Validate(__workflow_bodycumulativeProgress, nameof(bodycumulativeProgress), required: false);
            var __workflow_bodycontentSettingspush = bodycontentSettingspush == null ? null : WorkflowExpression.Compile(bodycontentSettingspush);
            WorkflowExpression.Validate(__workflow_bodycontentSettingspush, nameof(bodycontentSettingspush), required: false);
            var __workflow_bodycontentSettingssms = bodycontentSettingssms == null ? null : WorkflowExpression.Compile(bodycontentSettingssms);
            WorkflowExpression.Validate(__workflow_bodycontentSettingssms, nameof(bodycontentSettingssms), required: false);
            var __workflow_bodycontentSettingsemail = bodycontentSettingsemail == null ? null : WorkflowExpression.Compile(bodycontentSettingsemail);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsemail, nameof(bodycontentSettingsemail), required: false);
            var __workflow_bodycontentSettingsteams = bodycontentSettingsteams == null ? null : WorkflowExpression.Compile(bodycontentSettingsteams);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsteams, nameof(bodycontentSettingsteams), required: false);
            var __workflow_bodycontentSettingsinApp = bodycontentSettingsinApp == null ? null : WorkflowExpression.Compile(bodycontentSettingsinApp);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsinApp, nameof(bodycontentSettingsinApp), required: false);
            var __workflow_bodycontentSettingsallowLikes = bodycontentSettingsallowLikes == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowLikes);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowLikes, nameof(bodycontentSettingsallowLikes), required: false);
            var __workflow_bodycontentSettingsallowComments = bodycontentSettingsallowComments == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowComments);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowComments, nameof(bodycontentSettingsallowComments), required: false);
            var __workflow_bodycontentSettingsallowImagesInComments = bodycontentSettingsallowImagesInComments == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowImagesInComments);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowImagesInComments, nameof(bodycontentSettingsallowImagesInComments), required: false);
            var __workflow_bodycontentSettingsallowDocuments = bodycontentSettingsallowDocuments == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowDocuments);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowDocuments, nameof(bodycontentSettingsallowDocuments), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<UpdateObjectiveScoreResponse> UpdateObjectiveScore(Expression<Func<string>> objectiveId, Expression<Func<double>> bodyvalue, Expression<Func<string>> bodydescription, Expression<Func<bool>> bodyisIncrement = null)
        {
            var __workflow_objectiveId = objectiveId == null ? null : WorkflowExpression.Compile(objectiveId);
            WorkflowExpression.Validate(__workflow_objectiveId, nameof(objectiveId), required: true);
            var __workflow_bodyvalue = bodyvalue == null ? null : WorkflowExpression.Compile(bodyvalue);
            WorkflowExpression.Validate(__workflow_bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodyisIncrement = bodyisIncrement == null ? null : WorkflowExpression.Compile(bodyisIncrement);
            WorkflowExpression.Validate(__workflow_bodyisIncrement, nameof(bodyisIncrement), required: false);
            return new DeferredBodyAction<UpdateObjectiveScoreResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/public/Performance/v1/Objectives/{0}/progress", ExpressionConverter.ConvertWithUrlEncoding(__workflow_objectiveId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateArticleResponse> CreateArticle(Expression<Func<string>> bodytitle, Expression<Func<bodypriorityInput>> bodypriority, Expression<Func<bodyarticleTypeInput>> bodyarticleType, Expression<Func<string>> bodyhtmlContent, Expression<Func<string>> bodytag, Expression<Func<string>> bodymainImageUrl = null, Expression<Func<string>> bodysummary = null, Expression<Func<int>> bodychannelId = null, Expression<Func<bool>> bodycontentSettingspush = null, Expression<Func<bool>> bodycontentSettingssms = null, Expression<Func<bool>> bodycontentSettingsemail = null, Expression<Func<bool>> bodycontentSettingsinApp = null, Expression<Func<bool>> bodycontentSettingsteams = null, Expression<Func<bool>> bodycontentSettingsallowLikes = null, Expression<Func<bool>> bodycontentSettingsallowComments = null, Expression<Func<bool>> bodycontentSettingsallowImagesInComments = null, Expression<Func<string>> bodypublicationDetailspinFromDate = null, Expression<Func<int>> bodypublicationDetailspinDurationHours = null, Expression<Func<string>> bodypublicationDetailsscheduledDateTime = null, Expression<Func<bool>> bodypublicationDetailspublishImmediately = null, Expression<Func<int>> bodypublicationDetailspublishAsUserId = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: true);
            var __workflow_bodyarticleType = bodyarticleType == null ? null : WorkflowExpression.Compile(bodyarticleType);
            WorkflowExpression.Validate(__workflow_bodyarticleType, nameof(bodyarticleType), required: true);
            var __workflow_bodyhtmlContent = bodyhtmlContent == null ? null : WorkflowExpression.Compile(bodyhtmlContent);
            WorkflowExpression.Validate(__workflow_bodyhtmlContent, nameof(bodyhtmlContent), required: true);
            var __workflow_bodytag = bodytag == null ? null : WorkflowExpression.Compile(bodytag);
            WorkflowExpression.Validate(__workflow_bodytag, nameof(bodytag), required: true);
            var __workflow_bodymainImageUrl = bodymainImageUrl == null ? null : WorkflowExpression.Compile(bodymainImageUrl);
            WorkflowExpression.Validate(__workflow_bodymainImageUrl, nameof(bodymainImageUrl), required: false);
            var __workflow_bodysummary = bodysummary == null ? null : WorkflowExpression.Compile(bodysummary);
            WorkflowExpression.Validate(__workflow_bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodychannelId = bodychannelId == null ? null : WorkflowExpression.Compile(bodychannelId);
            WorkflowExpression.Validate(__workflow_bodychannelId, nameof(bodychannelId), required: false);
            var __workflow_bodycontentSettingspush = bodycontentSettingspush == null ? null : WorkflowExpression.Compile(bodycontentSettingspush);
            WorkflowExpression.Validate(__workflow_bodycontentSettingspush, nameof(bodycontentSettingspush), required: false);
            var __workflow_bodycontentSettingssms = bodycontentSettingssms == null ? null : WorkflowExpression.Compile(bodycontentSettingssms);
            WorkflowExpression.Validate(__workflow_bodycontentSettingssms, nameof(bodycontentSettingssms), required: false);
            var __workflow_bodycontentSettingsemail = bodycontentSettingsemail == null ? null : WorkflowExpression.Compile(bodycontentSettingsemail);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsemail, nameof(bodycontentSettingsemail), required: false);
            var __workflow_bodycontentSettingsinApp = bodycontentSettingsinApp == null ? null : WorkflowExpression.Compile(bodycontentSettingsinApp);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsinApp, nameof(bodycontentSettingsinApp), required: false);
            var __workflow_bodycontentSettingsteams = bodycontentSettingsteams == null ? null : WorkflowExpression.Compile(bodycontentSettingsteams);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsteams, nameof(bodycontentSettingsteams), required: false);
            var __workflow_bodycontentSettingsallowLikes = bodycontentSettingsallowLikes == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowLikes);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowLikes, nameof(bodycontentSettingsallowLikes), required: false);
            var __workflow_bodycontentSettingsallowComments = bodycontentSettingsallowComments == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowComments);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowComments, nameof(bodycontentSettingsallowComments), required: false);
            var __workflow_bodycontentSettingsallowImagesInComments = bodycontentSettingsallowImagesInComments == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowImagesInComments);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowImagesInComments, nameof(bodycontentSettingsallowImagesInComments), required: false);
            var __workflow_bodypublicationDetailspinFromDate = bodypublicationDetailspinFromDate == null ? null : WorkflowExpression.Compile(bodypublicationDetailspinFromDate);
            WorkflowExpression.Validate(__workflow_bodypublicationDetailspinFromDate, nameof(bodypublicationDetailspinFromDate), required: false);
            var __workflow_bodypublicationDetailspinDurationHours = bodypublicationDetailspinDurationHours == null ? null : WorkflowExpression.Compile(bodypublicationDetailspinDurationHours);
            WorkflowExpression.Validate(__workflow_bodypublicationDetailspinDurationHours, nameof(bodypublicationDetailspinDurationHours), required: false);
            var __workflow_bodypublicationDetailsscheduledDateTime = bodypublicationDetailsscheduledDateTime == null ? null : WorkflowExpression.Compile(bodypublicationDetailsscheduledDateTime);
            WorkflowExpression.Validate(__workflow_bodypublicationDetailsscheduledDateTime, nameof(bodypublicationDetailsscheduledDateTime), required: false);
            var __workflow_bodypublicationDetailspublishImmediately = bodypublicationDetailspublishImmediately == null ? null : WorkflowExpression.Compile(bodypublicationDetailspublishImmediately);
            WorkflowExpression.Validate(__workflow_bodypublicationDetailspublishImmediately, nameof(bodypublicationDetailspublishImmediately), required: false);
            var __workflow_bodypublicationDetailspublishAsUserId = bodypublicationDetailspublishAsUserId == null ? null : WorkflowExpression.Compile(bodypublicationDetailspublishAsUserId);
            WorkflowExpression.Validate(__workflow_bodypublicationDetailspublishAsUserId, nameof(bodypublicationDetailspublishAsUserId), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateAlertResponse> CreateAlert(Expression<Func<string>> bodytitle, Expression<Func<bodypriorityInput>> bodypriority, Expression<Func<string>> bodysummary = null, Expression<Func<bool>> bodyeveryone = null, Expression<Func<string>> bodyaudiencedepartmentTags = null, Expression<Func<string>> bodyaudiencepeopleTags = null, Expression<Func<string>> bodyaudiencegroupTags = null, Expression<Func<string>> bodyaudiencesiteTags = null, Expression<Func<bool>> bodycommunicationMethodspush = null, Expression<Func<bool>> bodycommunicationMethodssms = null, Expression<Func<bool>> bodycommunicationMethodsemail = null, Expression<Func<bool>> bodycommunicationMethodsinApp = null, Expression<Func<bool>> bodycommunicationMethodsteams = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: true);
            var __workflow_bodysummary = bodysummary == null ? null : WorkflowExpression.Compile(bodysummary);
            WorkflowExpression.Validate(__workflow_bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodyeveryone = bodyeveryone == null ? null : WorkflowExpression.Compile(bodyeveryone);
            WorkflowExpression.Validate(__workflow_bodyeveryone, nameof(bodyeveryone), required: false);
            var __workflow_bodyaudiencedepartmentTags = bodyaudiencedepartmentTags == null ? null : WorkflowExpression.Compile(bodyaudiencedepartmentTags);
            WorkflowExpression.Validate(__workflow_bodyaudiencedepartmentTags, nameof(bodyaudiencedepartmentTags), required: false);
            var __workflow_bodyaudiencepeopleTags = bodyaudiencepeopleTags == null ? null : WorkflowExpression.Compile(bodyaudiencepeopleTags);
            WorkflowExpression.Validate(__workflow_bodyaudiencepeopleTags, nameof(bodyaudiencepeopleTags), required: false);
            var __workflow_bodyaudiencegroupTags = bodyaudiencegroupTags == null ? null : WorkflowExpression.Compile(bodyaudiencegroupTags);
            WorkflowExpression.Validate(__workflow_bodyaudiencegroupTags, nameof(bodyaudiencegroupTags), required: false);
            var __workflow_bodyaudiencesiteTags = bodyaudiencesiteTags == null ? null : WorkflowExpression.Compile(bodyaudiencesiteTags);
            WorkflowExpression.Validate(__workflow_bodyaudiencesiteTags, nameof(bodyaudiencesiteTags), required: false);
            var __workflow_bodycommunicationMethodspush = bodycommunicationMethodspush == null ? null : WorkflowExpression.Compile(bodycommunicationMethodspush);
            WorkflowExpression.Validate(__workflow_bodycommunicationMethodspush, nameof(bodycommunicationMethodspush), required: false);
            var __workflow_bodycommunicationMethodssms = bodycommunicationMethodssms == null ? null : WorkflowExpression.Compile(bodycommunicationMethodssms);
            WorkflowExpression.Validate(__workflow_bodycommunicationMethodssms, nameof(bodycommunicationMethodssms), required: false);
            var __workflow_bodycommunicationMethodsemail = bodycommunicationMethodsemail == null ? null : WorkflowExpression.Compile(bodycommunicationMethodsemail);
            WorkflowExpression.Validate(__workflow_bodycommunicationMethodsemail, nameof(bodycommunicationMethodsemail), required: false);
            var __workflow_bodycommunicationMethodsinApp = bodycommunicationMethodsinApp == null ? null : WorkflowExpression.Compile(bodycommunicationMethodsinApp);
            WorkflowExpression.Validate(__workflow_bodycommunicationMethodsinApp, nameof(bodycommunicationMethodsinApp), required: false);
            var __workflow_bodycommunicationMethodsteams = bodycommunicationMethodsteams == null ? null : WorkflowExpression.Compile(bodycommunicationMethodsteams);
            WorkflowExpression.Validate(__workflow_bodycommunicationMethodsteams, nameof(bodycommunicationMethodsteams), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> bodytitle, Expression<Func<int>> bodyformId, Expression<Func<int>> bodytaskGroupId, Expression<Func<int>> bodypriorityId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydueDate = null, Expression<Func<int>> bodyassignedToId = null, Expression<Func<int>> bodymanagerId = null, Expression<Func<string>> bodyassignedToEmail = null, Expression<Func<string>> bodymanagerEmail = null, Expression<Func<int>> bodytaskIntervalId = null, Expression<Func<bool>> bodycontentSettingspush = null, Expression<Func<bool>> bodycontentSettingssms = null, Expression<Func<bool>> bodycontentSettingsemail = null, Expression<Func<bool>> bodycontentSettingsteams = null, Expression<Func<bool>> bodycontentSettingsinApp = null, Expression<Func<bool>> bodycontentSettingsallowLikes = null, Expression<Func<bool>> bodycontentSettingsallowComments = null, Expression<Func<bool>> bodycontentSettingsallowImagesInComments = null, Expression<Func<bool>> bodycontentSettingsallowDocuments = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyformId = bodyformId == null ? null : WorkflowExpression.Compile(bodyformId);
            WorkflowExpression.Validate(__workflow_bodyformId, nameof(bodyformId), required: true);
            var __workflow_bodytaskGroupId = bodytaskGroupId == null ? null : WorkflowExpression.Compile(bodytaskGroupId);
            WorkflowExpression.Validate(__workflow_bodytaskGroupId, nameof(bodytaskGroupId), required: true);
            var __workflow_bodypriorityId = bodypriorityId == null ? null : WorkflowExpression.Compile(bodypriorityId);
            WorkflowExpression.Validate(__workflow_bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydueDate = bodydueDate == null ? null : WorkflowExpression.Compile(bodydueDate);
            WorkflowExpression.Validate(__workflow_bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyassignedToId = bodyassignedToId == null ? null : WorkflowExpression.Compile(bodyassignedToId);
            WorkflowExpression.Validate(__workflow_bodyassignedToId, nameof(bodyassignedToId), required: false);
            var __workflow_bodymanagerId = bodymanagerId == null ? null : WorkflowExpression.Compile(bodymanagerId);
            WorkflowExpression.Validate(__workflow_bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodyassignedToEmail = bodyassignedToEmail == null ? null : WorkflowExpression.Compile(bodyassignedToEmail);
            WorkflowExpression.Validate(__workflow_bodyassignedToEmail, nameof(bodyassignedToEmail), required: false);
            var __workflow_bodymanagerEmail = bodymanagerEmail == null ? null : WorkflowExpression.Compile(bodymanagerEmail);
            WorkflowExpression.Validate(__workflow_bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            var __workflow_bodytaskIntervalId = bodytaskIntervalId == null ? null : WorkflowExpression.Compile(bodytaskIntervalId);
            WorkflowExpression.Validate(__workflow_bodytaskIntervalId, nameof(bodytaskIntervalId), required: false);
            var __workflow_bodycontentSettingspush = bodycontentSettingspush == null ? null : WorkflowExpression.Compile(bodycontentSettingspush);
            WorkflowExpression.Validate(__workflow_bodycontentSettingspush, nameof(bodycontentSettingspush), required: false);
            var __workflow_bodycontentSettingssms = bodycontentSettingssms == null ? null : WorkflowExpression.Compile(bodycontentSettingssms);
            WorkflowExpression.Validate(__workflow_bodycontentSettingssms, nameof(bodycontentSettingssms), required: false);
            var __workflow_bodycontentSettingsemail = bodycontentSettingsemail == null ? null : WorkflowExpression.Compile(bodycontentSettingsemail);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsemail, nameof(bodycontentSettingsemail), required: false);
            var __workflow_bodycontentSettingsteams = bodycontentSettingsteams == null ? null : WorkflowExpression.Compile(bodycontentSettingsteams);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsteams, nameof(bodycontentSettingsteams), required: false);
            var __workflow_bodycontentSettingsinApp = bodycontentSettingsinApp == null ? null : WorkflowExpression.Compile(bodycontentSettingsinApp);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsinApp, nameof(bodycontentSettingsinApp), required: false);
            var __workflow_bodycontentSettingsallowLikes = bodycontentSettingsallowLikes == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowLikes);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowLikes, nameof(bodycontentSettingsallowLikes), required: false);
            var __workflow_bodycontentSettingsallowComments = bodycontentSettingsallowComments == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowComments);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowComments, nameof(bodycontentSettingsallowComments), required: false);
            var __workflow_bodycontentSettingsallowImagesInComments = bodycontentSettingsallowImagesInComments == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowImagesInComments);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowImagesInComments, nameof(bodycontentSettingsallowImagesInComments), required: false);
            var __workflow_bodycontentSettingsallowDocuments = bodycontentSettingsallowDocuments == null ? null : WorkflowExpression.Compile(bodycontentSettingsallowDocuments);
            WorkflowExpression.Validate(__workflow_bodycontentSettingsallowDocuments, nameof(bodycontentSettingsallowDocuments), required: false);
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
            });
        }
    }

    public class StaffcircleTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> NewPerson(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
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
            });
        }

        public IBodyWorkflowTrigger<JToken> NewObjective(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
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
            });
        }

        public IBodyWorkflowTrigger<JToken> UpdateObjective(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
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
            });
        }

        public IBodyWorkflowTrigger<JToken> PublishedArticle(Expression<Func<string>> bodyname = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
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
            });
        }

        public IBodyWorkflowTrigger<JToken> NewTask(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
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
            });
        }

        public IBodyWorkflowTrigger<JToken> NewReview(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
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
            });
        }

        public IBodyWorkflowTrigger<JToken> NewAbsence(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
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
