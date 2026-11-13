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
        public IBodyWorkflowAction<CreatePersonResponse, ApiConnectionActionConfiguration> CreatePerson(Expression<Func<CreatePersonBodyInput>> body)
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
        public IBodyWorkflowAction<GetObjectivesResponse, ApiConnectionActionConfiguration> GetObjectives(Expression<Func<string>> searchTitle = null, Expression<Func<string>> personEmail = null, Expression<Func<string>> tag = null, Expression<Func<string>> closed = null, Expression<Func<ObjectiveTypeInput>> objectiveType = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<string>> activeAt = null)
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
        public IBodyWorkflowAction<CreateObjectiveByTemplateResponse, ApiConnectionActionConfiguration> CreateObjectiveByTemplate(Expression<Func<CreateObjectiveByTemplateBodyInput>> body)
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
        public IBodyWorkflowAction<CreateObjectiveResponse, ApiConnectionActionConfiguration> CreateObjective(Expression<Func<CreateObjectiveBodyInput>> body)
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
        public IBodyWorkflowAction<UpdateObjectiveScoreResponse, ApiConnectionActionConfiguration> UpdateObjectiveScore(Expression<Func<string>> objectiveId, Expression<Func<UpdateObjectiveScoreBodyInput>> body)
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
        public IBodyWorkflowAction<CreateArticleResponse, ApiConnectionActionConfiguration> CreateArticle(Expression<Func<CreateArticleBodyInput>> body)
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
        public IBodyWorkflowAction<CreateAlertResponse, ApiConnectionActionConfiguration> CreateAlert(Expression<Func<CreateAlertBodyInput>> body)
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
        public IBodyWorkflowAction<CreateTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<CreateTaskBodyInput>> body)
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
        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> NewPerson(Expression<Func<NewPersonBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewPerson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> NewObjective(Expression<Func<NewObjectiveBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewObjective";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> UpdateObjective(Expression<Func<UpdateObjectiveBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/UpdateObjective";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> PublishedArticle(Expression<Func<PublishedArticleBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Public/Security/v1/Webhooks/NewArticle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> NewTask(Expression<Func<NewTaskBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> NewReview(Expression<Func<NewReviewBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/NewReview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> NewAbsence(Expression<Func<NewAbsenceBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/public/security/v1/webhooks/newabsence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
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
        public string AvatarUrl { get; set; }

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

    public class CreatePersonBodyInput
    {
        public CreatePersonBodyInput(string firstName, string secondName, string email, string mobile, string dateOfBirth, string startDate)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Email = email;
            this.Mobile = mobile;
            this.DateOfBirth = dateOfBirth;
            this.StartDate = startDate;
        }

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
        public string AvatarUrl { get; set; }

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
        public BodyInputTimeZoneType? TimeZone { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Staffcircle.BodyInputTimeZoneType.Gmt0000London;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTimeZoneType
    {
        [EnumMember(Value = "(GMT-11:00) Niue")]
        Gmt1100Niue,
        [EnumMember(Value = "(GMT-11:00) Pago Pago")]
        Gmt1100PagoPago,
        [EnumMember(Value = "(GMT-10:00) Hawaii Time")]
        Gmt1000HawaiiTime,
        [EnumMember(Value = "(GMT-10:00) Rarotonga")]
        Gmt1000Rarotonga,
        [EnumMember(Value = "(GMT-10:00) Tahiti")]
        Gmt1000Tahiti,
        [EnumMember(Value = "(GMT-09:30) Marquesas")]
        Gmt0930Marquesas,
        [EnumMember(Value = "(GMT-09:00) Alaska Time")]
        Gmt0900AlaskaTime,
        [EnumMember(Value = "(GMT-09:00) Gambier")]
        Gmt0900Gambier,
        [EnumMember(Value = "(GMT-08:00) Pacific Time")]
        Gmt0800PacificTime,
        [EnumMember(Value = "(GMT-08:00) Pacific Time - Tijuana")]
        Gmt0800PacificTimeTijuana,
        [EnumMember(Value = "(GMT-08:00) Pacific Time - Vancouver")]
        Gmt0800PacificTimeVancouver,
        [EnumMember(Value = "(GMT-08:00) Pacific Time - Whitehorse")]
        Gmt0800PacificTimeWhitehorse,
        [EnumMember(Value = "(GMT-08:00) Pitcairn")]
        Gmt0800Pitcairn,
        [EnumMember(Value = "(GMT-07:00) Mountain Time")]
        Gmt0700MountainTime,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Arizona")]
        Gmt0700MountainTimeArizona,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Chihuahua, Mazatlan")]
        Gmt0700MountainTimeChihuahuaMazatlan,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Dawson Creek")]
        Gmt0700MountainTimeDawsonCreek,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Edmonton")]
        Gmt0700MountainTimeEdmonton,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Hermosillo")]
        Gmt0700MountainTimeHermosillo,
        [EnumMember(Value = "(GMT-07:00) Mountain Time - Yellowknife")]
        Gmt0700MountainTimeYellowknife,
        [EnumMember(Value = "(GMT-06:00) Belize")]
        Gmt0600Belize,
        [EnumMember(Value = "(GMT-06:00) Central Time")]
        Gmt0600CentralTime,
        [EnumMember(Value = "(GMT-06:00) Central Time - Mexico City")]
        Gmt0600CentralTimeMexicoCity,
        [EnumMember(Value = "(GMT-06:00) Central Time - Regina")]
        Gmt0600CentralTimeRegina,
        [EnumMember(Value = "(GMT-06:00) Central Time - Tegucigalpa")]
        Gmt0600CentralTimeTegucigalpa,
        [EnumMember(Value = "(GMT-06:00) Central Time - Winnipeg")]
        Gmt0600CentralTimeWinnipeg,
        [EnumMember(Value = "(GMT-06:00) Costa Rica")]
        Gmt0600CostaRica,
        [EnumMember(Value = "(GMT-06:00) El Salvador")]
        Gmt0600ElSalvador,
        [EnumMember(Value = "(GMT-06:00) Galapagos")]
        Gmt0600Galapagos,
        [EnumMember(Value = "(GMT-06:00) Guatemala")]
        Gmt0600Guatemala,
        [EnumMember(Value = "(GMT-06:00) Managua")]
        Gmt0600Managua,
        [EnumMember(Value = "(GMT-05:00) America Cancun")]
        Gmt0500AmericaCancun,
        [EnumMember(Value = "(GMT-05:00) Bogota")]
        Gmt0500Bogota,
        [EnumMember(Value = "(GMT-05:00) Easter Island")]
        Gmt0500EasterIsland,
        [EnumMember(Value = "(GMT-05:00) Eastern Time")]
        Gmt0500EasternTime,
        [EnumMember(Value = "(GMT-05:00) Eastern Time - Iqaluit")]
        Gmt0500EasternTimeIqaluit,
        [EnumMember(Value = "(GMT-05:00) Eastern Time - Toronto")]
        Gmt0500EasternTimeToronto,
        [EnumMember(Value = "(GMT-05:00) Guayaquil")]
        Gmt0500Guayaquil,
        [EnumMember(Value = "(GMT-05:00) Havana")]
        Gmt0500Havana,
        [EnumMember(Value = "(GMT-05:00) Jamaica")]
        Gmt0500Jamaica,
        [EnumMember(Value = "(GMT-05:00) Lima")]
        Gmt0500Lima,
        [EnumMember(Value = "(GMT-05:00) Nassau")]
        Gmt0500Nassau,
        [EnumMember(Value = "(GMT-05:00) Panama")]
        Gmt0500Panama,
        [EnumMember(Value = "(GMT-05:00) Port-au-Prince")]
        Gmt0500PortAuPrince,
        [EnumMember(Value = "(GMT-05:00) Rio Branco")]
        Gmt0500RioBranco,
        [EnumMember(Value = "(GMT-04:00) Atlantic Time - Halifax")]
        Gmt0400AtlanticTimeHalifax,
        [EnumMember(Value = "(GMT-04:00) Barbados")]
        Gmt0400Barbados,
        [EnumMember(Value = "(GMT-04:00) Bermuda")]
        Gmt0400Bermuda,
        [EnumMember(Value = "(GMT-04:00) Boa Vista")]
        Gmt0400BoaVista,
        [EnumMember(Value = "(GMT-04:00) Caracas")]
        Gmt0400Caracas,
        [EnumMember(Value = "(GMT-04:00) Curacao")]
        Gmt0400Curacao,
        [EnumMember(Value = "(GMT-04:00) Grand Turk")]
        Gmt0400GrandTurk,
        [EnumMember(Value = "(GMT-04:00) Guyana")]
        Gmt0400Guyana,
        [EnumMember(Value = "(GMT-04:00) La Paz")]
        Gmt0400LaPaz,
        [EnumMember(Value = "(GMT-04:00) Manaus")]
        Gmt0400Manaus,
        [EnumMember(Value = "(GMT-04:00) Martinique")]
        Gmt0400Martinique,
        [EnumMember(Value = "(GMT-04:00) Port of Spain")]
        Gmt0400PortOfSpain,
        [EnumMember(Value = "(GMT-04:00) Porto Velho")]
        Gmt0400PortoVelho,
        [EnumMember(Value = "(GMT-04:00) Puerto Rico")]
        Gmt0400PuertoRico,
        [EnumMember(Value = "(GMT-04:00) Santo Domingo")]
        Gmt0400SantoDomingo,
        [EnumMember(Value = "(GMT-04:00) Thule")]
        Gmt0400Thule,
        [EnumMember(Value = "(GMT-03:30) Newfoundland Time - St. Johns")]
        Gmt0330NewfoundlandTimeStJohns,
        [EnumMember(Value = "(GMT-03:00) Araguaina")]
        Gmt0300Araguaina,
        [EnumMember(Value = "(GMT-03:00) Asuncion")]
        Gmt0300Asuncion,
        [EnumMember(Value = "(GMT-03:00) Belem")]
        Gmt0300Belem,
        [EnumMember(Value = "(GMT-03:00) Buenos Aires")]
        Gmt0300BuenosAires,
        [EnumMember(Value = "(GMT-03:00) Campo Grande")]
        Gmt0300CampoGrande,
        [EnumMember(Value = "(GMT-03:00) Cayenne")]
        Gmt0300Cayenne,
        [EnumMember(Value = "(GMT-03:00) Cuiaba")]
        Gmt0300Cuiaba,
        [EnumMember(Value = "(GMT-03:00) Fortaleza")]
        Gmt0300Fortaleza,
        [EnumMember(Value = "(GMT-03:00) Godthab")]
        Gmt0300Godthab,
        [EnumMember(Value = "(GMT-03:00) Maceio")]
        Gmt0300Maceio,
        [EnumMember(Value = "(GMT-03:00) Miquelon")]
        Gmt0300Miquelon,
        [EnumMember(Value = "(GMT-03:00) Montevideo")]
        Gmt0300Montevideo,
        [EnumMember(Value = "(GMT-03:00) Palmer")]
        Gmt0300Palmer,
        [EnumMember(Value = "(GMT-03:00) Paramaribo")]
        Gmt0300Paramaribo,
        [EnumMember(Value = "(GMT-03:00) Punta Arenas")]
        Gmt0300PuntaArenas,
        [EnumMember(Value = "(GMT-03:00) Recife")]
        Gmt0300Recife,
        [EnumMember(Value = "(GMT-03:00) Rothera")]
        Gmt0300Rothera,
        [EnumMember(Value = "(GMT-03:00) Salvador")]
        Gmt0300Salvador,
        [EnumMember(Value = "(GMT-03:00) Santiago")]
        Gmt0300Santiago,
        [EnumMember(Value = "(GMT-03:00) Stanley")]
        Gmt0300Stanley,
        [EnumMember(Value = "(GMT-02:00) Noronha")]
        Gmt0200Noronha,
        [EnumMember(Value = "(GMT-02:00) Sao Paulo")]
        Gmt0200SaoPaulo,
        [EnumMember(Value = "(GMT-02:00) South Georgia")]
        Gmt0200SouthGeorgia,
        [EnumMember(Value = "(GMT-01:00) Azores")]
        Gmt0100Azores,
        [EnumMember(Value = "(GMT-01:00) Cape Verde")]
        Gmt0100CapeVerde,
        [EnumMember(Value = "(GMT-01:00) Scoresbysund")]
        Gmt0100Scoresbysund,
        [EnumMember(Value = "(GMT+00:00) Abidjan")]
        Gmt0000Abidjan,
        [EnumMember(Value = "(GMT+00:00) Accra")]
        Gmt0000Accra,
        [EnumMember(Value = "(GMT+00:00) Bissau")]
        Gmt0000Bissau,
        [EnumMember(Value = "(GMT+00:00) Canary Islands")]
        Gmt0000CanaryIslands,
        [EnumMember(Value = "(GMT+00:00) Casablanca")]
        Gmt0000Casablanca,
        [EnumMember(Value = "(GMT+00:00) Danmarkshavn")]
        Gmt0000Danmarkshavn,
        [EnumMember(Value = "(GMT+00:00) Dublin")]
        Gmt0000Dublin,
        [EnumMember(Value = "(GMT+00:00) El Aaiun")]
        Gmt0000ElAaiun,
        [EnumMember(Value = "(GMT+00:00) Faeroe")]
        Gmt0000Faeroe,
        [EnumMember(Value = "(GMT+00:00) GMT (no daylight saving)")]
        Gmt0000GmtNoDaylightSaving,
        [EnumMember(Value = "(GMT+00:00) Lisbon")]
        Gmt0000Lisbon,
        [EnumMember(Value = "(GMT+00:00) London")]
        Gmt0000London,
        [EnumMember(Value = "(GMT+00:00) Monrovia")]
        Gmt0000Monrovia,
        [EnumMember(Value = "(GMT+00:00) Reykjavik")]
        Gmt0000Reykjavik,
        [EnumMember(Value = "(GMT+01:00) Algiers")]
        Gmt0100Algiers,
        [EnumMember(Value = "(GMT+01:00) Amsterdam")]
        Gmt0100Amsterdam,
        [EnumMember(Value = "(GMT+01:00) Andorra")]
        Gmt0100Andorra,
        [EnumMember(Value = "(GMT+01:00) Berlin")]
        Gmt0100Berlin,
        [EnumMember(Value = "(GMT+01:00) Brussels")]
        Gmt0100Brussels,
        [EnumMember(Value = "(GMT+01:00) Budapest")]
        Gmt0100Budapest,
        [EnumMember(Value = "(GMT+01:00) Central European Time - Belgrade")]
        Gmt0100CentralEuropeanTimeBelgrade,
        [EnumMember(Value = "(GMT+01:00) Central European Time - Prague")]
        Gmt0100CentralEuropeanTimePrague,
        [EnumMember(Value = "(GMT+01:00) Ceuta")]
        Gmt0100Ceuta,
        [EnumMember(Value = "(GMT+01:00) Copenhagen")]
        Gmt0100Copenhagen,
        [EnumMember(Value = "(GMT+01:00) Gibraltar")]
        Gmt0100Gibraltar,
        [EnumMember(Value = "(GMT+01:00) Lagos")]
        Gmt0100Lagos,
        [EnumMember(Value = "(GMT+01:00) Luxembourg")]
        Gmt0100Luxembourg,
        [EnumMember(Value = "(GMT+01:00) Madrid")]
        Gmt0100Madrid,
        [EnumMember(Value = "(GMT+01:00) Malta")]
        Gmt0100Malta,
        [EnumMember(Value = "(GMT+01:00) Monaco")]
        Gmt0100Monaco,
        [EnumMember(Value = "(GMT+01:00) Ndjamena")]
        Gmt0100Ndjamena,
        [EnumMember(Value = "(GMT+01:00) Oslo")]
        Gmt0100Oslo,
        [EnumMember(Value = "(GMT+01:00) Paris")]
        Gmt0100Paris,
        [EnumMember(Value = "(GMT+01:00) Rome")]
        Gmt0100Rome,
        [EnumMember(Value = "(GMT+01:00) Stockholm")]
        Gmt0100Stockholm,
        [EnumMember(Value = "(GMT+01:00) Tirane")]
        Gmt0100Tirane,
        [EnumMember(Value = "(GMT+01:00) Tunis")]
        Gmt0100Tunis,
        [EnumMember(Value = "(GMT+01:00) Vienna")]
        Gmt0100Vienna,
        [EnumMember(Value = "(GMT+01:00) Warsaw")]
        Gmt0100Warsaw,
        [EnumMember(Value = "(GMT+01:00) Zurich")]
        Gmt0100Zurich,
        [EnumMember(Value = "(GMT+02:00) Amman")]
        Gmt0200Amman,
        [EnumMember(Value = "(GMT+02:00) Athens")]
        Gmt0200Athens,
        [EnumMember(Value = "(GMT+02:00) Beirut")]
        Gmt0200Beirut,
        [EnumMember(Value = "(GMT+02:00) Bucharest")]
        Gmt0200Bucharest,
        [EnumMember(Value = "(GMT+02:00) Cairo")]
        Gmt0200Cairo,
        [EnumMember(Value = "(GMT+02:00) Chisinau")]
        Gmt0200Chisinau,
        [EnumMember(Value = "(GMT+02:00) Damascus")]
        Gmt0200Damascus,
        [EnumMember(Value = "(GMT+02:00) Gaza")]
        Gmt0200Gaza,
        [EnumMember(Value = "(GMT+02:00) Helsinki")]
        Gmt0200Helsinki,
        [EnumMember(Value = "(GMT+02:00) Jerusalem")]
        Gmt0200Jerusalem,
        [EnumMember(Value = "(GMT+02:00) Johannesburg")]
        Gmt0200Johannesburg,
        [EnumMember(Value = "(GMT+02:00) Khartoum")]
        Gmt0200Khartoum,
        [EnumMember(Value = "(GMT+02:00) Kiev")]
        Gmt0200Kiev,
        [EnumMember(Value = "(GMT+02:00) Maputo")]
        Gmt0200Maputo,
        [EnumMember(Value = "(GMT+02:00) Moscow-01 - Kaliningrad")]
        Gmt0200Moscow01Kaliningrad,
        [EnumMember(Value = "(GMT+02:00) Nicosia")]
        Gmt0200Nicosia,
        [EnumMember(Value = "(GMT+02:00) Riga")]
        Gmt0200Riga,
        [EnumMember(Value = "(GMT+02:00) Sofia")]
        Gmt0200Sofia,
        [EnumMember(Value = "(GMT+02:00) Tallinn")]
        Gmt0200Tallinn,
        [EnumMember(Value = "(GMT+02:00) Tripoli")]
        Gmt0200Tripoli,
        [EnumMember(Value = "(GMT+02:00) Vilnius")]
        Gmt0200Vilnius,
        [EnumMember(Value = "(GMT+02:00) Windhoek")]
        Gmt0200Windhoek,
        [EnumMember(Value = "(GMT+03:00) Baghdad")]
        Gmt0300Baghdad,
        [EnumMember(Value = "(GMT+03:00) Istanbul")]
        Gmt0300Istanbul,
        [EnumMember(Value = "(GMT+03:00) Minsk")]
        Gmt0300Minsk,
        [EnumMember(Value = "(GMT+03:00) Moscow+00 - Moscow")]
        Gmt0300Moscow00Moscow,
        [EnumMember(Value = "(GMT+03:00) Nairobi")]
        Gmt0300Nairobi,
        [EnumMember(Value = "(GMT+03:00) Qatar")]
        Gmt0300Qatar,
        [EnumMember(Value = "(GMT+03:00) Riyadh")]
        Gmt0300Riyadh,
        [EnumMember(Value = "(GMT+03:00) Syowa")]
        Gmt0300Syowa,
        [EnumMember(Value = "(GMT+03:30) Tehran")]
        Gmt0330Tehran,
        [EnumMember(Value = "(GMT+04:00) Baku")]
        Gmt0400Baku,
        [EnumMember(Value = "(GMT+04:00) Dubai")]
        Gmt0400Dubai,
        [EnumMember(Value = "(GMT+04:00) Mahe")]
        Gmt0400Mahe,
        [EnumMember(Value = "(GMT+04:00) Mauritius")]
        Gmt0400Mauritius,
        [EnumMember(Value = "(GMT+04:00) Moscow+01 - Samara")]
        Gmt0400Moscow01Samara,
        [EnumMember(Value = "(GMT+04:00) Reunion")]
        Gmt0400Reunion,
        [EnumMember(Value = "(GMT+04:00) Tbilisi")]
        Gmt0400Tbilisi,
        [EnumMember(Value = "(GMT+04:00) Yerevan")]
        Gmt0400Yerevan,
        [EnumMember(Value = "(GMT+04:30) Kabul")]
        Gmt0430Kabul,
        [EnumMember(Value = "(GMT+05:00) Aqtau")]
        Gmt0500Aqtau,
        [EnumMember(Value = "(GMT+05:00) Aqtobe")]
        Gmt0500Aqtobe,
        [EnumMember(Value = "(GMT+05:00) Ashgabat")]
        Gmt0500Ashgabat,
        [EnumMember(Value = "(GMT+05:00) Dushanbe")]
        Gmt0500Dushanbe,
        [EnumMember(Value = "(GMT+05:00) Karachi")]
        Gmt0500Karachi,
        [EnumMember(Value = "(GMT+05:00) Kerguelen")]
        Gmt0500Kerguelen,
        [EnumMember(Value = "(GMT+05:00) Maldives")]
        Gmt0500Maldives,
        [EnumMember(Value = "(GMT+05:00) Mawson")]
        Gmt0500Mawson,
        [EnumMember(Value = "(GMT+05:00) Moscow+02 - Yekaterinburg")]
        Gmt0500Moscow02Yekaterinburg,
        [EnumMember(Value = "(GMT+05:00) Tashkent")]
        Gmt0500Tashkent,
        [EnumMember(Value = "(GMT+05:30) Colombo")]
        Gmt0530Colombo,
        [EnumMember(Value = "(GMT+05:30) India Standard Time")]
        Gmt0530IndiaStandardTime,
        [EnumMember(Value = "(GMT+05:45) Kathmandu")]
        Gmt0545Kathmandu,
        [EnumMember(Value = "(GMT+06:00) Almaty")]
        Gmt0600Almaty,
        [EnumMember(Value = "(GMT+06:00) Bishkek")]
        Gmt0600Bishkek,
        [EnumMember(Value = "(GMT+06:00) Chagos")]
        Gmt0600Chagos,
        [EnumMember(Value = "(GMT+06:00) Dhaka")]
        Gmt0600Dhaka,
        [EnumMember(Value = "(GMT+06:00) Moscow+03 - Omsk")]
        Gmt0600Moscow03Omsk,
        [EnumMember(Value = "(GMT+06:00) Thimphu")]
        Gmt0600Thimphu,
        [EnumMember(Value = "(GMT+06:00) Vostok")]
        Gmt0600Vostok,
        [EnumMember(Value = "(GMT+06:30) Cocos")]
        Gmt0630Cocos,
        [EnumMember(Value = "(GMT+06:30) Rangoon")]
        Gmt0630Rangoon,
        [EnumMember(Value = "(GMT+07:00) Bangkok")]
        Gmt0700Bangkok,
        [EnumMember(Value = "(GMT+07:00) Christmas")]
        Gmt0700Christmas,
        [EnumMember(Value = "(GMT+07:00) Davis")]
        Gmt0700Davis,
        [EnumMember(Value = "(GMT+07:00) Hanoi")]
        Gmt0700Hanoi,
        [EnumMember(Value = "(GMT+07:00) Hovd")]
        Gmt0700Hovd,
        [EnumMember(Value = "(GMT+07:00) Jakarta")]
        Gmt0700Jakarta,
        [EnumMember(Value = "(GMT+07:00) Moscow+04 - Krasnoyarsk")]
        Gmt0700Moscow04Krasnoyarsk,
        [EnumMember(Value = "(GMT+08:00) Brunei")]
        Gmt0800Brunei,
        [EnumMember(Value = "(GMT+08:00) China Time - Beijing")]
        Gmt0800ChinaTimeBeijing,
        [EnumMember(Value = "(GMT+08:00) Choibalsan")]
        Gmt0800Choibalsan,
        [EnumMember(Value = "(GMT+08:00) Hong Kong")]
        Gmt0800HongKong,
        [EnumMember(Value = "(GMT+08:00) Kuala Lumpur")]
        Gmt0800KualaLumpur,
        [EnumMember(Value = "(GMT+08:00) Macau")]
        Gmt0800Macau,
        [EnumMember(Value = "(GMT+08:00) Makassar")]
        Gmt0800Makassar,
        [EnumMember(Value = "(GMT+08:00) Manila")]
        Gmt0800Manila,
        [EnumMember(Value = "(GMT+08:00) Moscow+05 - Irkutsk")]
        Gmt0800Moscow05Irkutsk,
        [EnumMember(Value = "(GMT+08:00) Singapore")]
        Gmt0800Singapore,
        [EnumMember(Value = "(GMT+08:00) Taipei")]
        Gmt0800Taipei,
        [EnumMember(Value = "(GMT+08:00) Ulaanbaatar")]
        Gmt0800Ulaanbaatar,
        [EnumMember(Value = "(GMT+08:00) Western Time - Perth")]
        Gmt0800WesternTimePerth,
        [EnumMember(Value = "(GMT+08:30) Pyongyang")]
        Gmt0830Pyongyang,
        [EnumMember(Value = "(GMT+09:00) Dili")]
        Gmt0900Dili,
        [EnumMember(Value = "(GMT+09:00) Jayapura")]
        Gmt0900Jayapura,
        [EnumMember(Value = "(GMT+09:00) Moscow+06 - Yakutsk")]
        Gmt0900Moscow06Yakutsk,
        [EnumMember(Value = "(GMT+09:00) Palau")]
        Gmt0900Palau,
        [EnumMember(Value = "(GMT+09:00) Seoul")]
        Gmt0900Seoul,
        [EnumMember(Value = "(GMT+09:00) Tokyo")]
        Gmt0900Tokyo,
        [EnumMember(Value = "(GMT+09:30) Central Time - Darwin")]
        Gmt0930CentralTimeDarwin,
        [EnumMember(Value = "(GMT+10:00) Dumont D''Urville")]
        Gmt1000DumontDUrville,
        [EnumMember(Value = "(GMT+10:00) Eastern Time - Brisbane")]
        Gmt1000EasternTimeBrisbane,
        [EnumMember(Value = "(GMT+10:00) Guam")]
        Gmt1000Guam,
        [EnumMember(Value = "(GMT+10:00) Moscow+07 - Vladivostok")]
        Gmt1000Moscow07Vladivostok,
        [EnumMember(Value = "(GMT+10:00) Port Moresby")]
        Gmt1000PortMoresby,
        [EnumMember(Value = "(GMT+10:00) Truk")]
        Gmt1000Truk,
        [EnumMember(Value = "(GMT+10:30) Central Time - Adelaide")]
        Gmt1030CentralTimeAdelaide,
        [EnumMember(Value = "(GMT+11:00) Casey")]
        Gmt1100Casey,
        [EnumMember(Value = "(GMT+11:00) Eastern Time - Hobart")]
        Gmt1100EasternTimeHobart,
        [EnumMember(Value = "(GMT+11:00) Eastern Time - Melbourne, Sydney")]
        Gmt1100EasternTimeMelbourneSydney,
        [EnumMember(Value = "(GMT+11:00) Efate")]
        Gmt1100Efate,
        [EnumMember(Value = "(GMT+11:00) Guadalcanal")]
        Gmt1100Guadalcanal,
        [EnumMember(Value = "(GMT+11:00) Kosrae")]
        Gmt1100Kosrae,
        [EnumMember(Value = "(GMT+11:00) Moscow+08 - Magadan")]
        Gmt1100Moscow08Magadan,
        [EnumMember(Value = "(GMT+11:00) Norfolk")]
        Gmt1100Norfolk,
        [EnumMember(Value = "(GMT+11:00) Noumea")]
        Gmt1100Noumea,
        [EnumMember(Value = "(GMT+11:00) Ponape")]
        Gmt1100Ponape,
        [EnumMember(Value = "(GMT+12:00) Funafuti")]
        Gmt1200Funafuti,
        [EnumMember(Value = "(GMT+12:00) Kwajalein")]
        Gmt1200Kwajalein,
        [EnumMember(Value = "(GMT+12:00) Majuro")]
        Gmt1200Majuro,
        [EnumMember(Value = "(GMT+12:00) Moscow+09 - Petropavlovsk-Kamchatskiy")]
        Gmt1200Moscow09PetropavlovskKamchatskiy,
        [EnumMember(Value = "(GMT+12:00) Nauru")]
        Gmt1200Nauru,
        [EnumMember(Value = "(GMT+12:00) Tarawa")]
        Gmt1200Tarawa,
        [EnumMember(Value = "(GMT+12:00) Wake")]
        Gmt1200Wake,
        [EnumMember(Value = "(GMT+12:00) Wallis")]
        Gmt1200Wallis,
        [EnumMember(Value = "(GMT+13:00) Auckland")]
        Gmt1300Auckland,
        [EnumMember(Value = "(GMT+13:00) Enderbury")]
        Gmt1300Enderbury,
        [EnumMember(Value = "(GMT+13:00) Fakaofo")]
        Gmt1300Fakaofo,
        [EnumMember(Value = "(GMT+13:00) Fiji")]
        Gmt1300Fiji,
        [EnumMember(Value = "(GMT+13:00) Tongatapu")]
        Gmt1300Tongatapu,
        [EnumMember(Value = "(GMT+14:00) Apia")]
        Gmt1400Apia
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
    public enum ObjectiveTypeInput
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

    public class CreateObjectiveByTemplateBodyInput
    {
        public CreateObjectiveByTemplateBodyInput(int objectiveTemplateId, string startDate, string endDate)
        {
            this.ObjectiveTemplateId = objectiveTemplateId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

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

    public class CreateObjectiveBodyInput
    {
        public CreateObjectiveBodyInput(int categoryId, string title, string description, string startDate, string endDate, BodyInputValueTypeType valueType)
        {
            this.CategoryId = categoryId;
            this.Title = title;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ValueType = valueType;
        }

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
        public BodyInputValueTypeType ValueType { get; set; }

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
        public BodyInputRecurTypeType? RecurType { get; set; }

        [JsonProperty("recurInterval")]
        public int? RecurInterval { get; set; }

        [JsonProperty("cumulativeProgress", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CumulativeProgress { get; set; } = false;

        [JsonProperty("contentSettings", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateObjectiveBodyInputContentSettingsType ContentSettings { get; set; } = new CreateObjectiveBodyInputContentSettingsType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputValueTypeType
    {
        Number,
        Percentage,
        Financial,
        YesNo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRecurTypeType
    {
        Days,
        Weeks,
        Months,
        Years
    }

    public class CreateObjectiveBodyInputContentSettingsType
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

    public class UpdateObjectiveScoreBodyInput
    {
        public UpdateObjectiveScoreBodyInput(double value, string description)
        {
            this.Value = value;
            this.Description = description;
        }

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

    public class CreateArticleBodyInput
    {
        public CreateArticleBodyInput(string title, string htmlContent, string tag)
        {
            this.Title = title;
            this.HtmlContent = htmlContent;
            this.Tag = tag;
        }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPriorityType Priority { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Staffcircle.BodyInputPriorityType.Information;

        [JsonProperty("articleType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputArticleTypeType ArticleType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Staffcircle.BodyInputArticleTypeType.Social;

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
        public CreateArticleBodyInputContentSettingsType ContentSettings { get; set; } = new CreateArticleBodyInputContentSettingsType();

        [JsonProperty("publicationDetails", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPublicationDetailsType PublicationDetails { get; set; } = new BodyInputPublicationDetailsType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPriorityType
    {
        Critical,
        Important,
        Highlight,
        Information
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputArticleTypeType
    {
        Social,
        Blog
    }

    public class CreateArticleBodyInputContentSettingsType
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

    public class BodyInputPublicationDetailsType
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

    public class CreateAlertBodyInput
    {
        public CreateAlertBodyInput(string title)
        {
            this.Title = title;
        }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPriorityType Priority { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Staffcircle.BodyInputPriorityType.Critical;

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("everyone", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Everyone { get; set; } = false;

        [JsonProperty("audience")]
        public BodyInputAudienceType Audience { get; set; }

        [JsonProperty("communicationMethods", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputCommunicationMethodsType CommunicationMethods { get; set; } = new BodyInputCommunicationMethodsType();
    }

    public class BodyInputAudienceType
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

    public class BodyInputCommunicationMethodsType
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

    public class CreateTaskBodyInput
    {
        public CreateTaskBodyInput(string title, int formId, int taskGroupId)
        {
            this.Title = title;
            this.FormId = formId;
            this.TaskGroupId = taskGroupId;
        }

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

        [JsonProperty("contentSettings", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTaskBodyInputContentSettingsType ContentSettings { get; set; } = new CreateTaskBodyInputContentSettingsType();
    }

    public class CreateTaskBodyInputContentSettingsType
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

    public class NewPersonBodyInput
    {
        public NewPersonBodyInput(string name)
        {
            this.Name = name;
        }

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

    public class NewObjectiveBodyInput
    {
        public NewObjectiveBodyInput(string name)
        {
            this.Name = name;
        }

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

    public class UpdateObjectiveBodyInput
    {
        public UpdateObjectiveBodyInput(string name)
        {
            this.Name = name;
        }

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

    public class PublishedArticleBodyInput
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

    public class NewTaskBodyInput
    {
        public NewTaskBodyInput(string name)
        {
            this.Name = name;
        }

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

    public class NewReviewBodyInput
    {
        public NewReviewBodyInput(string name)
        {
            this.Name = name;
        }

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

    public class NewAbsenceBodyInput
    {
        public NewAbsenceBodyInput(string name)
        {
            this.Name = name;
        }

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