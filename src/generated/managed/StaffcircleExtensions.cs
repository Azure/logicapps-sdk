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
        public IBodyWorkflowAction<GetPersonResponse, ApiConnectionActionConfiguration> GetPerson(Expression<Func<string>> searchEmail)
        {
            var __workflow_searchEmail = WorkflowExpression.Compile(searchEmail, nameof(searchEmail), required: true);
            return new DeferredBodyAction<GetPersonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public/directory/v1/persons";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SearchEmail"] = ExpressionConverter.Convert(__workflow_searchEmail);
                return new ApiConnectionAction<GetPersonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreatePersonResponse, ApiConnectionActionConfiguration> CreatePerson(Expression<Func<CreatePersonInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreatePersonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public/directory/v1/persons";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatePersonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<GetObjectivesResponse, ApiConnectionActionConfiguration> GetObjectives(Expression<Func<string>> searchTitle = null, Expression<Func<string>> personEmail = null, Expression<Func<string>> tag = null, Expression<Func<string>> closed = null, Expression<Func<objectiveTypeInput>> objectiveType = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<string>> activeAt = null)
        {
            var __workflow_searchTitle = WorkflowExpression.Compile(searchTitle, nameof(searchTitle), required: false);
            var __workflow_personEmail = WorkflowExpression.Compile(personEmail, nameof(personEmail), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_closed = WorkflowExpression.Compile(closed, nameof(closed), required: false);
            var __workflow_objectiveType = WorkflowExpression.Compile(objectiveType, nameof(objectiveType), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_activeAt = WorkflowExpression.Compile(activeAt, nameof(activeAt), required: false);
            return new DeferredBodyAction<GetObjectivesResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CreateObjectiveByTemplateResponse, ApiConnectionActionConfiguration> CreateObjectiveByTemplate(Expression<Func<CreateObjectiveByTemplateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateObjectiveByTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public/Performance/v1/Objectives";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateObjectiveByTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateObjectiveResponse, ApiConnectionActionConfiguration> CreateObjective(Expression<Func<CreateObjectiveInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateObjectiveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public/Performance/v1/Objectives/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateObjectiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<UpdateObjectiveScoreResponse, ApiConnectionActionConfiguration> UpdateObjectiveScore(Expression<Func<string>> objectiveId, Expression<Func<UpdateObjectiveScoreInput>> body)
        {
            var __workflow_objectiveId = WorkflowExpression.Compile(objectiveId, nameof(objectiveId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateObjectiveScoreResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public/Performance/v1/Objectives/{0}/progress", __workflow_objectiveId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateObjectiveScoreResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateArticleResponse, ApiConnectionActionConfiguration> CreateArticle(Expression<Func<CreateArticleInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateArticleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public/comms/v1/Articles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateArticleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateAlertResponse, ApiConnectionActionConfiguration> CreateAlert(Expression<Func<CreateAlertInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateAlertResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public/comms/v1/Alerts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAlertResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffcircle")]
        public IBodyWorkflowAction<CreateTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<CreateTaskInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public/tasks/v1/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
        }
    }

    public class StaffcircleTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> NewPerson(Expression<Func<NewPersonInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewPerson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> NewObjective(Expression<Func<NewObjectiveInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewObjective";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> UpdateObjective(Expression<Func<UpdateObjectiveInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/UpdateObjective";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> PublishedArticle(Expression<Func<PublishedArticleInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Public/Security/v1/Webhooks/NewArticle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> NewTask(Expression<Func<NewTaskInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> NewReview(Expression<Func<NewReviewInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewReview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> NewAbsence(Expression<Func<NewAbsenceInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/newabsence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class CreatePersonInput
    {
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("secondName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SecondName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("mobile", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Mobile { get; set; }

        [JsonProperty("dateOfBirth", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateOfBirth { get; set; }

        [JsonProperty("startDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("town")]
        public string Town { get; set; }

        [JsonProperty("postCode")]
        public string PostCode { get; set; }

        [JsonProperty("countyName")]
        public string CountyName { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("titleName")]
        public string TitleName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("homeEmail")]
        public string HomeEmail { get; set; }

        [JsonProperty("homeTelephone")]
        public string HomeTelephone { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("managerEmail")]
        public string ManagerEmail { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("knownAs")]
        public string KnownAs { get; set; }

        [JsonProperty("avatarURL")]
        public string AvatarURL { get; set; }

        [JsonProperty("titleId")]
        public int? TitleId { get; set; }

        [JsonProperty("countyId")]
        public int? CountyId { get; set; }

        [JsonProperty("countryId")]
        public int? CountryId { get; set; }

        [JsonProperty("genderId")]
        public int? GenderId { get; set; }

        [JsonProperty("nationalityId")]
        public int? NationalityId { get; set; }

        [JsonProperty("ethnicityId")]
        public int? EthnicityId { get; set; }

        [JsonProperty("maritalStatusId")]
        public int? MaritalStatusId { get; set; }

        [JsonProperty("managerId")]
        public int? ManagerId { get; set; }

        [JsonProperty("departmentId")]
        public int? DepartmentId { get; set; }

        [JsonProperty("roleId")]
        public int? RoleId { get; set; }

        [JsonProperty("mainSiteId")]
        public int? MainSiteId { get; set; }

        [JsonProperty("emergencyContactConsent")]
        public bool? EmergencyContactConsent { get; set; }

        [JsonProperty("emergencyContactName")]
        public string EmergencyContactName { get; set; }

        [JsonProperty("emergencyRelationshipId")]
        public int? EmergencyRelationshipId { get; set; }

        [JsonProperty("emergencyContactTelephone")]
        public string EmergencyContactTelephone { get; set; }

        [JsonProperty("emergencyAddress")]
        public string EmergencyAddress { get; set; }

        [JsonProperty("nextOfKinName")]
        public string NextOfKinName { get; set; }

        [JsonProperty("nextOfKinRelationshipId")]
        public int? NextOfKinRelationshipId { get; set; }

        [JsonProperty("nextOfKinTelephone")]
        public string NextOfKinTelephone { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("workExtension")]
        public string WorkExtension { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("personalMobile")]
        public string PersonalMobile { get; set; }

        [JsonProperty("statusId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? StatusId { get; set; } = 1;

        [JsonProperty("employmentTypeId")]
        public int? EmploymentTypeId { get; set; }

        [JsonProperty("contractTypeId")]
        public int? ContractTypeId { get; set; }

        [JsonProperty("contractExpiry")]
        public string ContractExpiry { get; set; }

        [JsonProperty("employmentStatusId")]
        public int? EmploymentStatusId { get; set; }

        [JsonProperty("secondaryEmploymentStatusId")]
        public int? SecondaryEmploymentStatusId { get; set; }

        [JsonProperty("employmentNotes")]
        public string EmploymentNotes { get; set; }

        [JsonProperty("medicalNotes")]
        public string MedicalNotes { get; set; }

        [JsonProperty("isPersonalDataEnabled")]
        public bool? IsPersonalDataEnabled { get; set; }

        [JsonProperty("isContactDataEnabled")]
        public bool? IsContactDataEnabled { get; set; }

        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePersonInputTimeZoneType? TimeZone { get; set; } = CreatePersonInputTimeZoneType.GMT0000London;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePersonInputTimeZoneType
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

    public class CreateObjectiveByTemplateInput
    {
        [JsonProperty("objectiveTemplateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ObjectiveTemplateId { get; set; }

        [JsonProperty("startDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty("endDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDate { get; set; }

        [JsonProperty("personEmail")]
        public string PersonEmail { get; set; }

        [JsonProperty("personId")]
        public int? PersonId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("departmentId")]
        public int? DepartmentId { get; set; }

        [JsonProperty("managerEmail")]
        public string ManagerEmail { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("managerId")]
        public int? ManagerId { get; set; }

        [JsonProperty("companyObjectiveId")]
        public int? CompanyObjectiveId { get; set; }

        [JsonProperty("departmentObjectiveId")]
        public int? DepartmentObjectiveId { get; set; }
    }

    public class CreateObjectiveResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateObjectiveInput
    {
        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int CategoryId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("startDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty("endDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDate { get; set; }

        [JsonProperty("valueType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateObjectiveInputValueTypeType ValueType { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("managerEmail")]
        public string ManagerEmail { get; set; }

        [JsonProperty("managerId")]
        public int? ManagerId { get; set; }

        [JsonProperty("personEmail")]
        public string PersonEmail { get; set; }

        [JsonProperty("personId")]
        public int? PersonId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("departmentId")]
        public int? DepartmentId { get; set; }

        [JsonProperty("companyObjectiveId")]
        public int? CompanyObjectiveId { get; set; }

        [JsonProperty("departmentObjectiveId")]
        public int? DepartmentObjectiveId { get; set; }

        [JsonProperty("startValue")]
        public double? StartValue { get; set; }

        [JsonProperty("target")]
        public double? Target { get; set; }

        [JsonProperty("allowAddProgress", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowAddProgress { get; set; } = false;

        [JsonProperty("recurType")]
        public CreateObjectiveInputRecurTypeType? RecurType { get; set; }

        [JsonProperty("recurInterval")]
        public int? RecurInterval { get; set; }

        [JsonProperty("cumulativeProgress", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CumulativeProgress { get; set; } = false;

        [JsonProperty("contentSettings")]
        public CreateObjectiveInputContentSettingsType ContentSettings { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateObjectiveInputValueTypeType
    {
        Number,
        Percentage,
        Financial,
        YesNo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateObjectiveInputRecurTypeType
    {
        Days,
        Weeks,
        Months,
        Years
    }

    public class CreateObjectiveInputContentSettingsType
    {
        [JsonProperty("push", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Push { get; set; } = true;

        [JsonProperty("sms", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Sms { get; set; } = false;

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Email { get; set; } = true;

        [JsonProperty("teams", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Teams { get; set; } = false;

        [JsonProperty("inApp", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? InApp { get; set; } = true;

        [JsonProperty("allowLikes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowLikes { get; set; } = true;

        [JsonProperty("allowComments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowComments { get; set; } = true;

        [JsonProperty("allowImagesInComments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowImagesInComments { get; set; } = true;

        [JsonProperty("allowDocuments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowDocuments { get; set; } = true;
    }

    public class UpdateObjectiveScoreResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class UpdateObjectiveScoreInput
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Value { get; set; }

        [JsonProperty("isIncrement", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsIncrement { get; set; } = false;

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }
    }

    public class CreateArticleResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateArticleInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateArticleInputPriorityType Priority { get; set; } = CreateArticleInputPriorityType.Information;

        [JsonProperty("articleType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateArticleInputArticleTypeType ArticleType { get; set; } = CreateArticleInputArticleTypeType.Social;

        [JsonProperty("htmlContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlContent { get; set; }

        [JsonProperty("mainImageUrl")]
        public string MainImageUrl { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("tag", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Tag { get; set; }

        [JsonProperty("channelId")]
        public int? ChannelId { get; set; }

        [JsonProperty("contentSettings", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateArticleInputContentSettingsType ContentSettings { get; set; }

        [JsonProperty("publicationDetails")]
        public CreateArticleInputPublicationDetailsType PublicationDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateArticleInputPriorityType
    {
        Critical,
        Important,
        Highlight,
        Information
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateArticleInputArticleTypeType
    {
        Social,
        Blog
    }

    public class CreateArticleInputContentSettingsType
    {
        [JsonProperty("push", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Push { get; set; } = false;

        [JsonProperty("sms", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Sms { get; set; } = false;

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Email { get; set; } = false;

        [JsonProperty("inApp", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? InApp { get; set; } = true;

        [JsonProperty("teams", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Teams { get; set; } = false;

        [JsonProperty("allowLikes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowLikes { get; set; } = true;

        [JsonProperty("allowComments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowComments { get; set; } = true;

        [JsonProperty("allowImagesInComments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowImagesInComments { get; set; } = true;
    }

    public class CreateArticleInputPublicationDetailsType
    {
        [JsonProperty("pinFromDate")]
        public string PinFromDate { get; set; }

        [JsonProperty("pinDurationHours")]
        public int? PinDurationHours { get; set; }

        [JsonProperty("scheduledDateTime")]
        public string ScheduledDateTime { get; set; }

        [JsonProperty("publishImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PublishImmediately { get; set; } = true;

        [JsonProperty("publishAsUserId")]
        public int? PublishAsUserId { get; set; }
    }

    public class CreateAlertResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateAlertInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAlertInputPriorityType Priority { get; set; } = CreateAlertInputPriorityType.Critical;

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("everyone", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Everyone { get; set; } = false;

        [JsonProperty("audience")]
        public CreateAlertInputAudienceType Audience { get; set; }

        [JsonProperty("communicationMethods")]
        public CreateAlertInputCommunicationMethodsType CommunicationMethods { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAlertInputPriorityType
    {
        Critical,
        Important,
        Highlight,
        Information
    }

    public class CreateAlertInputAudienceType
    {
        [JsonProperty("departmentTags")]
        public string DepartmentTags { get; set; }

        [JsonProperty("peopleTags")]
        public string PeopleTags { get; set; }

        [JsonProperty("groupTags")]
        public string GroupTags { get; set; }

        [JsonProperty("siteTags")]
        public string SiteTags { get; set; }
    }

    public class CreateAlertInputCommunicationMethodsType
    {
        [JsonProperty("push", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Push { get; set; } = false;

        [JsonProperty("sms", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Sms { get; set; } = false;

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Email { get; set; } = true;

        [JsonProperty("inApp", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? InApp { get; set; } = true;

        [JsonProperty("teams", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Teams { get; set; } = false;
    }

    public class CreateTaskResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateTaskInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("priorityId")]
        public int? PriorityId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("formId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int FormId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("assignedToId")]
        public int? AssignedToId { get; set; }

        [JsonProperty("managerId")]
        public int? ManagerId { get; set; }

        [JsonProperty("taskGroupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TaskGroupId { get; set; }

        [JsonProperty("assignedToEmail")]
        public string AssignedToEmail { get; set; }

        [JsonProperty("managerEmail")]
        public string ManagerEmail { get; set; }

        [JsonProperty("taskIntervalId")]
        public int? TaskIntervalId { get; set; }

        [JsonProperty("contentSettings")]
        public CreateTaskInputContentSettingsType ContentSettings { get; set; }
    }

    public class CreateTaskInputContentSettingsType
    {
        [JsonProperty("push", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Push { get; set; } = false;

        [JsonProperty("sms", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Sms { get; set; } = false;

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Email { get; set; } = false;

        [JsonProperty("teams", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Teams { get; set; } = false;

        [JsonProperty("inApp", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? InApp { get; set; } = true;

        [JsonProperty("allowLikes")]
        public bool? AllowLikes { get; set; }

        [JsonProperty("allowComments")]
        public bool? AllowComments { get; set; }

        [JsonProperty("allowImagesInComments")]
        public bool? AllowImagesInComments { get; set; }

        [JsonProperty("allowDocuments")]
        public bool? AllowDocuments { get; set; }
    }

    public class NewPersonInput
    {
        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AuthType { get; set; } = "none";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ResourceType { get; set; } = "People";

        [JsonProperty("create", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Create { get; set; } = true;

        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Update { get; set; } = false;

        [JsonProperty("delete", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Delete { get; set; } = false;

        [JsonProperty("notifications", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Notifications { get; set; } = false;

        [JsonProperty("isActive", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool IsActive { get; set; } = true;
    }

    public class NewObjectiveInput
    {
        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AuthType { get; set; } = "none";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ResourceType { get; set; } = "Objectives";

        [JsonProperty("create", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Create { get; set; } = true;

        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Update { get; set; } = false;

        [JsonProperty("delete", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Delete { get; set; } = false;

        [JsonProperty("notifications", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Notifications { get; set; } = false;

        [JsonProperty("isActive", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool IsActive { get; set; } = true;
    }

    public class UpdateObjectiveInput
    {
        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AuthType { get; set; } = "none";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ResourceType { get; set; } = "Objectives_Progress";

        [JsonProperty("create", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Create { get; set; } = true;

        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Update { get; set; } = false;

        [JsonProperty("delete", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Delete { get; set; } = false;

        [JsonProperty("notifications", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Notifications { get; set; } = false;

        [JsonProperty("isActive", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool IsActive { get; set; } = true;
    }

    public class PublishedArticleInput
    {
        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AuthType { get; set; } = "none";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ResourceType { get; set; } = "Articles";

        [JsonProperty("create", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Create { get; set; } = false;

        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Update { get; set; } = false;

        [JsonProperty("delete", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Delete { get; set; } = false;

        [JsonProperty("notifications", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Notifications { get; set; } = false;

        [JsonProperty("customAction", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CustomAction { get; set; } = "Publish";

        [JsonProperty("isActive", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool IsActive { get; set; } = true;
    }

    public class NewTaskInput
    {
        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AuthType { get; set; } = "none";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("isActive", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool IsActive { get; set; } = true;

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ResourceType { get; set; } = "Task";

        [JsonProperty("create", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Create { get; set; } = true;

        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Update { get; set; } = false;

        [JsonProperty("delete", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Delete { get; set; } = false;

        [JsonProperty("notifications", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Notifications { get; set; } = false;
    }

    public class NewReviewInput
    {
        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AuthType { get; set; } = "none";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("isActive", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool IsActive { get; set; } = true;

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ResourceType { get; set; } = "Reviews";

        [JsonProperty("create", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Create { get; set; } = true;

        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Update { get; set; } = false;

        [JsonProperty("delete", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Delete { get; set; } = false;

        [JsonProperty("notifications", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Notifications { get; set; } = false;
    }

    public class NewAbsenceInput
    {
        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AuthType { get; set; } = "none";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("isActive", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool IsActive { get; set; } = true;

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ResourceType { get; set; } = "Absences";

        [JsonProperty("create", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Create { get; set; } = true;

        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Update { get; set; } = false;

        [JsonProperty("delete", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Delete { get; set; } = false;

        [JsonProperty("notifications", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Notifications { get; set; } = false;
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