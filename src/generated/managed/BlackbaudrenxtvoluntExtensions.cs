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
        public IWorkflowAction<ApiConnectionActionConfiguration> EditVolunteerEmergencyContact(Expression<Func<string>> constituentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyrelationship = null, Expression<Func<string>> bodyphone = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyrelationship = WorkflowExpression.Compile(bodyrelationship, nameof(bodyrelationship), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/{0}/emergencycontact", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyrelationship != null)
                {
                    body["relationship"] = ExpressionConverter.ConvertO(__workflow_bodyrelationship);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<VolunteerApiCreatedVolunteerInterest, ApiConnectionActionConfiguration> CreateVolunteerInterest(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyinterest)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyinterest = WorkflowExpression.Compile(bodyinterest, nameof(bodyinterest), required: true);
            return new DeferredBodyAction<VolunteerApiCreatedVolunteerInterest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/volunteer/v1/volunteers/interests";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodyinterest);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<VolunteerApiCreatedVolunteerSkill, ApiConnectionActionConfiguration> CreateVolunteerSkill(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodydescription, Expression<Func<string>> bodyskillLevel = null, Expression<Func<string>> bodylicenseType = null, Expression<Func<int>> bodyexpirationDateday = null, Expression<Func<int>> bodyexpirationDatemonth = null, Expression<Func<int>> bodyexpirationDateyear = null, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodyskillLevel = WorkflowExpression.Compile(bodyskillLevel, nameof(bodyskillLevel), required: false);
            var __workflow_bodylicenseType = WorkflowExpression.Compile(bodylicenseType, nameof(bodylicenseType), required: false);
            var __workflow_bodyexpirationDateday = WorkflowExpression.Compile(bodyexpirationDateday, nameof(bodyexpirationDateday), required: false);
            var __workflow_bodyexpirationDatemonth = WorkflowExpression.Compile(bodyexpirationDatemonth, nameof(bodyexpirationDatemonth), required: false);
            var __workflow_bodyexpirationDateyear = WorkflowExpression.Compile(bodyexpirationDateyear, nameof(bodyexpirationDateyear), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<VolunteerApiCreatedVolunteerSkill, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/volunteer/v1/volunteers/skills";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["skill_description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (__workflow_bodyskillLevel != null)
                {
                    body["skill_level"] = ExpressionConverter.ConvertO(__workflow_bodyskillLevel);
                    bodypropCount++;
                }

                if (__workflow_bodylicenseType != null)
                {
                    body["license_type"] = ExpressionConverter.ConvertO(__workflow_bodylicenseType);
                    bodypropCount++;
                }

                var expirationDateObject = new JObject();
                var expirationDateObjectpropCount = 0;
                if (__workflow_bodyexpirationDateday != null)
                {
                    expirationDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDateday);
                    expirationDateObjectpropCount++;
                }

                if (__workflow_bodyexpirationDatemonth != null)
                {
                    expirationDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDatemonth);
                    expirationDateObjectpropCount++;
                }

                if (__workflow_bodyexpirationDateyear != null)
                {
                    expirationDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDateyear);
                    expirationDateObjectpropCount++;
                }

                if (expirationDateObjectpropCount > 0)
                {
                    body["expiration_date"] = expirationDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IWorkflowAction<ApiConnectionActionConfiguration> EditVolunteerSkill(Expression<Func<string>> volunteerSkillId, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyskillLevel = null, Expression<Func<string>> bodylicenseType = null, Expression<Func<int>> bodyexpirationDateday = null, Expression<Func<int>> bodyexpirationDatemonth = null, Expression<Func<int>> bodyexpirationDateyear = null, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_volunteerSkillId = WorkflowExpression.Compile(volunteerSkillId, nameof(volunteerSkillId), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyskillLevel = WorkflowExpression.Compile(bodyskillLevel, nameof(bodyskillLevel), required: false);
            var __workflow_bodylicenseType = WorkflowExpression.Compile(bodylicenseType, nameof(bodylicenseType), required: false);
            var __workflow_bodyexpirationDateday = WorkflowExpression.Compile(bodyexpirationDateday, nameof(bodyexpirationDateday), required: false);
            var __workflow_bodyexpirationDatemonth = WorkflowExpression.Compile(bodyexpirationDatemonth, nameof(bodyexpirationDatemonth), required: false);
            var __workflow_bodyexpirationDateyear = WorkflowExpression.Compile(bodyexpirationDateyear, nameof(bodyexpirationDateyear), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/skills/{0}", __workflow_volunteerSkillId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["skill_description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyskillLevel != null)
                {
                    body["skill_level"] = ExpressionConverter.ConvertO(__workflow_bodyskillLevel);
                    bodypropCount++;
                }

                if (__workflow_bodylicenseType != null)
                {
                    body["license_type"] = ExpressionConverter.ConvertO(__workflow_bodylicenseType);
                    bodypropCount++;
                }

                var expirationDateObject = new JObject();
                var expirationDateObjectpropCount = 0;
                if (__workflow_bodyexpirationDateday != null)
                {
                    expirationDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDateday);
                    expirationDateObjectpropCount++;
                }

                if (__workflow_bodyexpirationDatemonth != null)
                {
                    expirationDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDatemonth);
                    expirationDateObjectpropCount++;
                }

                if (__workflow_bodyexpirationDateyear != null)
                {
                    expirationDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDateyear);
                    expirationDateObjectpropCount++;
                }

                if (expirationDateObjectpropCount > 0)
                {
                    body["expiration_date"] = expirationDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiCreatedVolunteerType, ApiConnectionActionConfiguration> CreateVolunteerType(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodytype, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodydateStartedday = null, Expression<Func<int>> bodydateStartedmonth = null, Expression<Func<int>> bodydateStartedyear = null, Expression<Func<int>> bodydateFinishedday = null, Expression<Func<int>> bodydateFinishedmonth = null, Expression<Func<int>> bodydateFinishedyear = null, Expression<Func<string>> bodyreasonFinished = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydateStartedday = WorkflowExpression.Compile(bodydateStartedday, nameof(bodydateStartedday), required: false);
            var __workflow_bodydateStartedmonth = WorkflowExpression.Compile(bodydateStartedmonth, nameof(bodydateStartedmonth), required: false);
            var __workflow_bodydateStartedyear = WorkflowExpression.Compile(bodydateStartedyear, nameof(bodydateStartedyear), required: false);
            var __workflow_bodydateFinishedday = WorkflowExpression.Compile(bodydateFinishedday, nameof(bodydateFinishedday), required: false);
            var __workflow_bodydateFinishedmonth = WorkflowExpression.Compile(bodydateFinishedmonth, nameof(bodydateFinishedmonth), required: false);
            var __workflow_bodydateFinishedyear = WorkflowExpression.Compile(bodydateFinishedyear, nameof(bodydateFinishedyear), required: false);
            var __workflow_bodyreasonFinished = WorkflowExpression.Compile(bodyreasonFinished, nameof(bodyreasonFinished), required: false);
            return new DeferredBodyAction<VolunteerApiCreatedVolunteerType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/volunteer/v1/volunteers/types";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var dateStartedObject = new JObject();
                var dateStartedObjectpropCount = 0;
                if (__workflow_bodydateStartedday != null)
                {
                    dateStartedObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateStartedday);
                    dateStartedObjectpropCount++;
                }

                if (__workflow_bodydateStartedmonth != null)
                {
                    dateStartedObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateStartedmonth);
                    dateStartedObjectpropCount++;
                }

                if (__workflow_bodydateStartedyear != null)
                {
                    dateStartedObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateStartedyear);
                    dateStartedObjectpropCount++;
                }

                if (dateStartedObjectpropCount > 0)
                {
                    body["date_started"] = dateStartedObject;
                    bodypropCount++;
                }

                var dateFinishedObject = new JObject();
                var dateFinishedObjectpropCount = 0;
                if (__workflow_bodydateFinishedday != null)
                {
                    dateFinishedObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateFinishedday);
                    dateFinishedObjectpropCount++;
                }

                if (__workflow_bodydateFinishedmonth != null)
                {
                    dateFinishedObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateFinishedmonth);
                    dateFinishedObjectpropCount++;
                }

                if (__workflow_bodydateFinishedyear != null)
                {
                    dateFinishedObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateFinishedyear);
                    dateFinishedObjectpropCount++;
                }

                if (dateFinishedObjectpropCount > 0)
                {
                    body["date_finished"] = dateFinishedObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreasonFinished != null)
                {
                    body["reason_finished"] = ExpressionConverter.ConvertO(__workflow_bodyreasonFinished);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IWorkflowAction<ApiConnectionActionConfiguration> EditVolunteerType(Expression<Func<string>> volunteerTypeId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodydateStartedday = null, Expression<Func<int>> bodydateStartedmonth = null, Expression<Func<int>> bodydateStartedyear = null, Expression<Func<int>> bodydateFinishedday = null, Expression<Func<int>> bodydateFinishedmonth = null, Expression<Func<int>> bodydateFinishedyear = null, Expression<Func<string>> bodyreasonFinished = null)
        {
            var __workflow_volunteerTypeId = WorkflowExpression.Compile(volunteerTypeId, nameof(volunteerTypeId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydateStartedday = WorkflowExpression.Compile(bodydateStartedday, nameof(bodydateStartedday), required: false);
            var __workflow_bodydateStartedmonth = WorkflowExpression.Compile(bodydateStartedmonth, nameof(bodydateStartedmonth), required: false);
            var __workflow_bodydateStartedyear = WorkflowExpression.Compile(bodydateStartedyear, nameof(bodydateStartedyear), required: false);
            var __workflow_bodydateFinishedday = WorkflowExpression.Compile(bodydateFinishedday, nameof(bodydateFinishedday), required: false);
            var __workflow_bodydateFinishedmonth = WorkflowExpression.Compile(bodydateFinishedmonth, nameof(bodydateFinishedmonth), required: false);
            var __workflow_bodydateFinishedyear = WorkflowExpression.Compile(bodydateFinishedyear, nameof(bodydateFinishedyear), required: false);
            var __workflow_bodyreasonFinished = WorkflowExpression.Compile(bodyreasonFinished, nameof(bodyreasonFinished), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/volunteer/v1/volunteers/types/{0}", __workflow_volunteerTypeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var dateStartedObject = new JObject();
                var dateStartedObjectpropCount = 0;
                if (__workflow_bodydateStartedday != null)
                {
                    dateStartedObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateStartedday);
                    dateStartedObjectpropCount++;
                }

                if (__workflow_bodydateStartedmonth != null)
                {
                    dateStartedObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateStartedmonth);
                    dateStartedObjectpropCount++;
                }

                if (__workflow_bodydateStartedyear != null)
                {
                    dateStartedObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateStartedyear);
                    dateStartedObjectpropCount++;
                }

                if (dateStartedObjectpropCount > 0)
                {
                    body["date_started"] = dateStartedObject;
                    bodypropCount++;
                }

                var dateFinishedObject = new JObject();
                var dateFinishedObjectpropCount = 0;
                if (__workflow_bodydateFinishedday != null)
                {
                    dateFinishedObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateFinishedday);
                    dateFinishedObjectpropCount++;
                }

                if (__workflow_bodydateFinishedmonth != null)
                {
                    dateFinishedObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateFinishedmonth);
                    dateFinishedObjectpropCount++;
                }

                if (__workflow_bodydateFinishedyear != null)
                {
                    dateFinishedObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateFinishedyear);
                    dateFinishedObjectpropCount++;
                }

                if (dateFinishedObjectpropCount > 0)
                {
                    body["date_finished"] = dateFinishedObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreasonFinished != null)
                {
                    body["reason_finished"] = ExpressionConverter.ConvertO(__workflow_bodyreasonFinished);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class VolunteerApiCreatedVolunteerSkill
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class VolunteerApiCreatedVolunteerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
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