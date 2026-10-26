//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtvolunt
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudrenxtvoluntActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiJob, ApiConnectionActionConfiguration> GetJob(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<VolunteerApiJob, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VolunteerApiJob>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiJobSkillCollection, ApiConnectionActionConfiguration> ListJobSkills(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<VolunteerApiJobSkillCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/jobs/{0}/skills", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VolunteerApiJobSkillCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiJobAssignmentCollection, ApiConnectionActionConfiguration> ListJobAssignments(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<VolunteerApiJobAssignmentCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/jobs/{0}/volunteers", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VolunteerApiJobAssignmentCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiVolunteerAssignmentCollection, ApiConnectionActionConfiguration> ListVolunteerJobAssignments(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<VolunteerApiVolunteerAssignmentCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/{0}/assignments", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VolunteerApiVolunteerAssignmentCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiEmergencyContact, ApiConnectionActionConfiguration> GetVolunteerEmergencyContact(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<VolunteerApiEmergencyContact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/{0}/emergencycontact", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VolunteerApiEmergencyContact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditVolunteerEmergencyContact(Expression<Func<string>> constituentId, Expression<Func<EditVolunteerEmergencyContactInput>> body)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/{0}/emergencycontact", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiVolunteerInterestCollection, ApiConnectionActionConfiguration> ListVolunteerInterests(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<VolunteerApiVolunteerInterestCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/{0}/interests", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VolunteerApiVolunteerInterestCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiVolunteerSkillCollection, ApiConnectionActionConfiguration> ListVolunteerSkills(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<VolunteerApiVolunteerSkillCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/{0}/skills", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VolunteerApiVolunteerSkillCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiVolunteerTimesheetCollection, ApiConnectionActionConfiguration> ListVolunteerTimesheets(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<VolunteerApiVolunteerTimesheetCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/{0}/timesheets", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VolunteerApiVolunteerTimesheetCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiVolunteerTypeCollection, ApiConnectionActionConfiguration> ListVolunteerTypes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<VolunteerApiVolunteerTypeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/{0}/types", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VolunteerApiVolunteerTypeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiCreatedVolunteerInterest, ApiConnectionActionConfiguration> CreateVolunteerInterest(Expression<Func<CreateVolunteerInterestInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<VolunteerApiCreatedVolunteerInterest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/volunteer/v1/volunteers/interests";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<VolunteerApiCreatedVolunteerInterest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteVolunteerInterest(Expression<Func<string>> volunteerInterestId)
        {
            var __workflow_volunteerInterestId = WorkflowExpression.Compile(volunteerInterestId, nameof(volunteerInterestId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/interests/{0}", __workflow_volunteerInterestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiCreatedVolunteerSkill, ApiConnectionActionConfiguration> CreateVolunteerSkill(Expression<Func<CreateVolunteerSkillInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<VolunteerApiCreatedVolunteerSkill, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/volunteer/v1/volunteers/skills";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<VolunteerApiCreatedVolunteerSkill>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteVolunteerSkill(Expression<Func<string>> volunteerSkillId)
        {
            var __workflow_volunteerSkillId = WorkflowExpression.Compile(volunteerSkillId, nameof(volunteerSkillId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/skills/{0}", __workflow_volunteerSkillId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditVolunteerSkill(Expression<Func<string>> volunteerSkillId, Expression<Func<EditVolunteerSkillInput>> body)
        {
            var __workflow_volunteerSkillId = WorkflowExpression.Compile(volunteerSkillId, nameof(volunteerSkillId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/skills/{0}", __workflow_volunteerSkillId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiCreatedVolunteerType, ApiConnectionActionConfiguration> CreateVolunteerType(Expression<Func<CreateVolunteerTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<VolunteerApiCreatedVolunteerType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/volunteer/v1/volunteers/types";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<VolunteerApiCreatedVolunteerType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteVolunteerType(Expression<Func<string>> volunteerTypeId)
        {
            var __workflow_volunteerTypeId = WorkflowExpression.Compile(volunteerTypeId, nameof(volunteerTypeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/types/{0}", __workflow_volunteerTypeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditVolunteerType(Expression<Func<string>> volunteerTypeId, Expression<Func<EditVolunteerTypeInput>> body)
        {
            var __workflow_volunteerTypeId = WorkflowExpression.Compile(volunteerTypeId, nameof(volunteerTypeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/types/{0}", __workflow_volunteerTypeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class BlackbaudrenxtvoluntTriggers([ConnectionName] string connectionId)
    {
    }

    public class VolunteerApiJob
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("allow_mandate")]
        public bool AllowMandate { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("volunteer_type")]
        public string VolunteerType { get; set; }

        [JsonProperty("minimum_age")]
        public int MinimumAge { get; set; }

        [JsonProperty("organization_id")]
        public int OrganizationId { get; set; }

        [JsonProperty("event_id")]
        public int EventId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class VolunteerApiJobSkillCollection
    {
        [JsonProperty("skills")]
        public VolunteerApiJobSkill[] Skills { get; set; }
    }

    public class VolunteerApiJobSkill
    {
        [JsonProperty("description")]
        public string Skill { get; set; }

        [JsonProperty("skill_level")]
        public string SkillLevel { get; set; }

        [JsonProperty("license_type")]
        public string LicenseType { get; set; }
    }

    public class VolunteerApiJobAssignmentCollection
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("volunteers")]
        public VolunteerApiJobAssignment[] Volunteers { get; set; }
    }

    public class VolunteerApiJobAssignment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("constituent_id")]
        public int ConstituentId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("requested_on")]
        public string RequestedOn { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("letter_sent")]
        public bool LetterSent { get; set; }

        [JsonProperty("letter_sent_on")]
        public string LetterSentOn { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("task")]
        public string TaskObject { get; set; }

        [JsonProperty("volunteer_type")]
        public string VolunteerType { get; set; }

        [JsonProperty("supervisor")]
        public string Supervisor { get; set; }

        [JsonProperty("day_of_week")]
        public string DayOfWeek { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class VolunteerApiVolunteerAssignmentCollection
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("assignments")]
        public VolunteerApiVolunteerAssignment[] Assignments { get; set; }
    }

    public class VolunteerApiVolunteerAssignment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("job_id")]
        public int JobId { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("requested_on")]
        public string RequestedOn { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("job_start_date")]
        public string JobStartDate { get; set; }

        [JsonProperty("job_end_date")]
        public string JobEndDate { get; set; }

        [JsonProperty("letter_sent")]
        public bool LetterSent { get; set; }

        [JsonProperty("letter_sent_on")]
        public string LetterSentOn { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("task")]
        public string TaskObject { get; set; }

        [JsonProperty("volunteer_type")]
        public string VolunteerType { get; set; }

        [JsonProperty("supervisor")]
        public string Supervisor { get; set; }

        [JsonProperty("day_of_week")]
        public string DayOfWeek { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class VolunteerApiEmergencyContact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class EditVolunteerEmergencyContactInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class VolunteerApiVolunteerInterestCollection
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("interests")]
        public VolunteerApiVolunteerInterest[] Interests { get; set; }
    }

    public class VolunteerApiVolunteerInterest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class VolunteerApiVolunteerSkillCollection
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("skills")]
        public VolunteerApiVolunteerSkill[] Skills { get; set; }
    }

    public class VolunteerApiVolunteerSkill
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("skill_description")]
        public string Skill { get; set; }

        [JsonProperty("skill_level")]
        public string SkillLevel { get; set; }

        [JsonProperty("license_type")]
        public string LicenseType { get; set; }

        [JsonProperty("expiration_date")]
        public VolunteerApiVolunteerSkillExpirationDateType ExpirationDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class VolunteerApiVolunteerSkillExpirationDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class VolunteerApiVolunteerTimesheetCollection
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("timesheets")]
        public VolunteerApiVolunteerTimesheet[] Timesheets { get; set; }
    }

    public class VolunteerApiVolunteerTimesheet
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("job_id")]
        public int JobId { get; set; }

        [JsonProperty("job")]
        public string JobName { get; set; }

        [JsonProperty("timesheet_date")]
        public string Date { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("task")]
        public string TaskObject { get; set; }

        [JsonProperty("volunteer_type")]
        public string VolunteerType { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("hours")]
        public double Hours { get; set; }

        [JsonProperty("hourly_wage")]
        public double HourlyWage { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class VolunteerApiVolunteerTypeCollection
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("types")]
        public VolunteerApiVolunteerType[] Types { get; set; }
    }

    public class VolunteerApiVolunteerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_started")]
        public VolunteerApiVolunteerTypeDateStartedType DateStarted { get; set; }

        [JsonProperty("date_finished")]
        public VolunteerApiVolunteerTypeDateFinishedType DateFinished { get; set; }

        [JsonProperty("reason_finished")]
        public string ReasonFinished { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class VolunteerApiVolunteerTypeDateStartedType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class VolunteerApiVolunteerTypeDateFinishedType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class VolunteerApiCreatedVolunteerInterest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateVolunteerInterestInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Interest { get; set; }
    }

    public class VolunteerApiCreatedVolunteerSkill
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateVolunteerSkillInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("skill_description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("skill_level")]
        public string SkillLevel { get; set; }

        [JsonProperty("license_type")]
        public string LicenseType { get; set; }

        [JsonProperty("expiration_date")]
        public CreateVolunteerSkillInputExpirationDateType ExpirationDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class CreateVolunteerSkillInputExpirationDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditVolunteerSkillInput
    {
        [JsonProperty("skill_description")]
        public string Description { get; set; }

        [JsonProperty("skill_level")]
        public string SkillLevel { get; set; }

        [JsonProperty("license_type")]
        public string LicenseType { get; set; }

        [JsonProperty("expiration_date")]
        public EditVolunteerSkillInputExpirationDateType ExpirationDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class EditVolunteerSkillInputExpirationDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class VolunteerApiCreatedVolunteerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateVolunteerTypeInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_started")]
        public CreateVolunteerTypeInputDateStartedType DateStarted { get; set; }

        [JsonProperty("date_finished")]
        public CreateVolunteerTypeInputDateFinishedType DateFinished { get; set; }

        [JsonProperty("reason_finished")]
        public string ReasonFinished { get; set; }
    }

    public class CreateVolunteerTypeInputDateStartedType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class CreateVolunteerTypeInputDateFinishedType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditVolunteerTypeInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_started")]
        public EditVolunteerTypeInputDateStartedType DateStarted { get; set; }

        [JsonProperty("date_finished")]
        public EditVolunteerTypeInputDateFinishedType DateFinished { get; set; }

        [JsonProperty("reason_finished")]
        public string ReasonFinished { get; set; }
    }

    public class EditVolunteerTypeInputDateStartedType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditVolunteerTypeInputDateFinishedType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtvolunt;

    public partial class WorkflowManagedActions
    {
        public BlackbaudrenxtvoluntActions Blackbaudrenxtvolunt(string connectionId) => new BlackbaudrenxtvoluntActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudrenxtvoluntTriggers Blackbaudrenxtvolunt(string connectionId) => new BlackbaudrenxtvoluntTriggers(connectionId);
    }
}