//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtvolunt
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudrenxtvoluntActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiJob> GetJob([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiJob>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiJobSkillCollection> ListJobSkills([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/jobs/{0}/skills", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiJobSkillCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiJobAssignmentCollection> ListJobAssignments([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/jobs/{0}/volunteers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiJobAssignmentCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiVolunteerAssignmentCollection> ListVolunteerJobAssignments([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/{0}/assignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiVolunteerAssignmentCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiEmergencyContact> GetVolunteerEmergencyContact([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/{0}/emergencycontact", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiEmergencyContact>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction EditVolunteerEmergencyContact([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyrelationship = null, [WorkflowExpression] Func<string> bodyphone = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyrelationship, nameof(bodyrelationship), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/{0}/emergencycontact", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyrelationship != null)
                {
                    body["relationship"] = SourceExpressionConverter.ConvertToken(bodyrelationship);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiVolunteerInterestCollection> ListVolunteerInterests([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/{0}/interests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiVolunteerInterestCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiVolunteerSkillCollection> ListVolunteerSkills([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/{0}/skills", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiVolunteerSkillCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiVolunteerTimesheetCollection> ListVolunteerTimesheets([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/{0}/timesheets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiVolunteerTimesheetCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiVolunteerTypeCollection> ListVolunteerTypes([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/{0}/types", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiVolunteerTypeCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiCreatedVolunteerInterest> CreateVolunteerInterest([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyinterest)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyinterest, nameof(bodyinterest), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/volunteer/v1/volunteers/interests";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodyinterest);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiCreatedVolunteerInterest>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction DeleteVolunteerInterest([WorkflowExpression] Func<string> volunteerInterestId)
        {
            SourceExpression.Validate(volunteerInterestId, nameof(volunteerInterestId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/interests/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(volunteerInterestId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiCreatedVolunteerSkill> CreateVolunteerSkill([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodyskillLevel = null, [WorkflowExpression] Func<string> bodylicenseType = null, [WorkflowExpression] Func<int> bodyexpirationDateday = null, [WorkflowExpression] Func<int> bodyexpirationDatemonth = null, [WorkflowExpression] Func<int> bodyexpirationDateyear = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodyskillLevel, nameof(bodyskillLevel), required: false);
            SourceExpression.Validate(bodylicenseType, nameof(bodylicenseType), required: false);
            SourceExpression.Validate(bodyexpirationDateday, nameof(bodyexpirationDateday), required: false);
            SourceExpression.Validate(bodyexpirationDatemonth, nameof(bodyexpirationDatemonth), required: false);
            SourceExpression.Validate(bodyexpirationDateyear, nameof(bodyexpirationDateyear), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/volunteer/v1/volunteers/skills";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["skill_description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodyskillLevel != null)
                {
                    body["skill_level"] = SourceExpressionConverter.ConvertToken(bodyskillLevel);
                    bodypropCount++;
                }

                if (bodylicenseType != null)
                {
                    body["license_type"] = SourceExpressionConverter.ConvertToken(bodylicenseType);
                    bodypropCount++;
                }

                var expirationDateObject = new JObject();
                var expirationDateObjectpropCount = 0;
                if (bodyexpirationDateday != null)
                {
                    expirationDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyexpirationDateday);
                    expirationDateObjectpropCount++;
                }

                if (bodyexpirationDatemonth != null)
                {
                    expirationDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyexpirationDatemonth);
                    expirationDateObjectpropCount++;
                }

                if (bodyexpirationDateyear != null)
                {
                    expirationDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyexpirationDateyear);
                    expirationDateObjectpropCount++;
                }

                if (expirationDateObjectpropCount > 0)
                {
                    body["expiration_date"] = expirationDateObject;
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiCreatedVolunteerSkill>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction DeleteVolunteerSkill([WorkflowExpression] Func<string> volunteerSkillId)
        {
            SourceExpression.Validate(volunteerSkillId, nameof(volunteerSkillId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/skills/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(volunteerSkillId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction EditVolunteerSkill([WorkflowExpression] Func<string> volunteerSkillId, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyskillLevel = null, [WorkflowExpression] Func<string> bodylicenseType = null, [WorkflowExpression] Func<int> bodyexpirationDateday = null, [WorkflowExpression] Func<int> bodyexpirationDatemonth = null, [WorkflowExpression] Func<int> bodyexpirationDateyear = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(volunteerSkillId, nameof(volunteerSkillId), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyskillLevel, nameof(bodyskillLevel), required: false);
            SourceExpression.Validate(bodylicenseType, nameof(bodylicenseType), required: false);
            SourceExpression.Validate(bodyexpirationDateday, nameof(bodyexpirationDateday), required: false);
            SourceExpression.Validate(bodyexpirationDatemonth, nameof(bodyexpirationDatemonth), required: false);
            SourceExpression.Validate(bodyexpirationDateyear, nameof(bodyexpirationDateyear), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/skills/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(volunteerSkillId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["skill_description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyskillLevel != null)
                {
                    body["skill_level"] = SourceExpressionConverter.ConvertToken(bodyskillLevel);
                    bodypropCount++;
                }

                if (bodylicenseType != null)
                {
                    body["license_type"] = SourceExpressionConverter.ConvertToken(bodylicenseType);
                    bodypropCount++;
                }

                var expirationDateObject = new JObject();
                var expirationDateObjectpropCount = 0;
                if (bodyexpirationDateday != null)
                {
                    expirationDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyexpirationDateday);
                    expirationDateObjectpropCount++;
                }

                if (bodyexpirationDatemonth != null)
                {
                    expirationDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyexpirationDatemonth);
                    expirationDateObjectpropCount++;
                }

                if (bodyexpirationDateyear != null)
                {
                    expirationDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyexpirationDateyear);
                    expirationDateObjectpropCount++;
                }

                if (expirationDateObjectpropCount > 0)
                {
                    body["expiration_date"] = expirationDateObject;
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IBodyWorkflowAction<VolunteerApiCreatedVolunteerType> CreateVolunteerType([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodydateStartedday = null, [WorkflowExpression] Func<int> bodydateStartedmonth = null, [WorkflowExpression] Func<int> bodydateStartedyear = null, [WorkflowExpression] Func<int> bodydateFinishedday = null, [WorkflowExpression] Func<int> bodydateFinishedmonth = null, [WorkflowExpression] Func<int> bodydateFinishedyear = null, [WorkflowExpression] Func<string> bodyreasonFinished = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodydateStartedday, nameof(bodydateStartedday), required: false);
            SourceExpression.Validate(bodydateStartedmonth, nameof(bodydateStartedmonth), required: false);
            SourceExpression.Validate(bodydateStartedyear, nameof(bodydateStartedyear), required: false);
            SourceExpression.Validate(bodydateFinishedday, nameof(bodydateFinishedday), required: false);
            SourceExpression.Validate(bodydateFinishedmonth, nameof(bodydateFinishedmonth), required: false);
            SourceExpression.Validate(bodydateFinishedyear, nameof(bodydateFinishedyear), required: false);
            SourceExpression.Validate(bodyreasonFinished, nameof(bodyreasonFinished), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/volunteer/v1/volunteers/types";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                var dateStartedObject = new JObject();
                var dateStartedObjectpropCount = 0;
                if (bodydateStartedday != null)
                {
                    dateStartedObject["d"] = SourceExpressionConverter.ConvertToken(bodydateStartedday);
                    dateStartedObjectpropCount++;
                }

                if (bodydateStartedmonth != null)
                {
                    dateStartedObject["m"] = SourceExpressionConverter.ConvertToken(bodydateStartedmonth);
                    dateStartedObjectpropCount++;
                }

                if (bodydateStartedyear != null)
                {
                    dateStartedObject["y"] = SourceExpressionConverter.ConvertToken(bodydateStartedyear);
                    dateStartedObjectpropCount++;
                }

                if (dateStartedObjectpropCount > 0)
                {
                    body["date_started"] = dateStartedObject;
                    bodypropCount++;
                }

                var dateFinishedObject = new JObject();
                var dateFinishedObjectpropCount = 0;
                if (bodydateFinishedday != null)
                {
                    dateFinishedObject["d"] = SourceExpressionConverter.ConvertToken(bodydateFinishedday);
                    dateFinishedObjectpropCount++;
                }

                if (bodydateFinishedmonth != null)
                {
                    dateFinishedObject["m"] = SourceExpressionConverter.ConvertToken(bodydateFinishedmonth);
                    dateFinishedObjectpropCount++;
                }

                if (bodydateFinishedyear != null)
                {
                    dateFinishedObject["y"] = SourceExpressionConverter.ConvertToken(bodydateFinishedyear);
                    dateFinishedObjectpropCount++;
                }

                if (dateFinishedObjectpropCount > 0)
                {
                    body["date_finished"] = dateFinishedObject;
                    bodypropCount++;
                }

                if (bodyreasonFinished != null)
                {
                    body["reason_finished"] = SourceExpressionConverter.ConvertToken(bodyreasonFinished);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VolunteerApiCreatedVolunteerType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction DeleteVolunteerType([WorkflowExpression] Func<string> volunteerTypeId)
        {
            SourceExpression.Validate(volunteerTypeId, nameof(volunteerTypeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/types/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(volunteerTypeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtvolunt")]
        public IWorkflowAction EditVolunteerType([WorkflowExpression] Func<string> volunteerTypeId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodydateStartedday = null, [WorkflowExpression] Func<int> bodydateStartedmonth = null, [WorkflowExpression] Func<int> bodydateStartedyear = null, [WorkflowExpression] Func<int> bodydateFinishedday = null, [WorkflowExpression] Func<int> bodydateFinishedmonth = null, [WorkflowExpression] Func<int> bodydateFinishedyear = null, [WorkflowExpression] Func<string> bodyreasonFinished = null)
        {
            SourceExpression.Validate(volunteerTypeId, nameof(volunteerTypeId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodydateStartedday, nameof(bodydateStartedday), required: false);
            SourceExpression.Validate(bodydateStartedmonth, nameof(bodydateStartedmonth), required: false);
            SourceExpression.Validate(bodydateStartedyear, nameof(bodydateStartedyear), required: false);
            SourceExpression.Validate(bodydateFinishedday, nameof(bodydateFinishedday), required: false);
            SourceExpression.Validate(bodydateFinishedmonth, nameof(bodydateFinishedmonth), required: false);
            SourceExpression.Validate(bodydateFinishedyear, nameof(bodydateFinishedyear), required: false);
            SourceExpression.Validate(bodyreasonFinished, nameof(bodyreasonFinished), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/volunteer/v1/volunteers/types/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(volunteerTypeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                var dateStartedObject = new JObject();
                var dateStartedObjectpropCount = 0;
                if (bodydateStartedday != null)
                {
                    dateStartedObject["d"] = SourceExpressionConverter.ConvertToken(bodydateStartedday);
                    dateStartedObjectpropCount++;
                }

                if (bodydateStartedmonth != null)
                {
                    dateStartedObject["m"] = SourceExpressionConverter.ConvertToken(bodydateStartedmonth);
                    dateStartedObjectpropCount++;
                }

                if (bodydateStartedyear != null)
                {
                    dateStartedObject["y"] = SourceExpressionConverter.ConvertToken(bodydateStartedyear);
                    dateStartedObjectpropCount++;
                }

                if (dateStartedObjectpropCount > 0)
                {
                    body["date_started"] = dateStartedObject;
                    bodypropCount++;
                }

                var dateFinishedObject = new JObject();
                var dateFinishedObjectpropCount = 0;
                if (bodydateFinishedday != null)
                {
                    dateFinishedObject["d"] = SourceExpressionConverter.ConvertToken(bodydateFinishedday);
                    dateFinishedObjectpropCount++;
                }

                if (bodydateFinishedmonth != null)
                {
                    dateFinishedObject["m"] = SourceExpressionConverter.ConvertToken(bodydateFinishedmonth);
                    dateFinishedObjectpropCount++;
                }

                if (bodydateFinishedyear != null)
                {
                    dateFinishedObject["y"] = SourceExpressionConverter.ConvertToken(bodydateFinishedyear);
                    dateFinishedObjectpropCount++;
                }

                if (dateFinishedObjectpropCount > 0)
                {
                    body["date_finished"] = dateFinishedObject;
                    bodypropCount++;
                }

                if (bodyreasonFinished != null)
                {
                    body["reason_finished"] = SourceExpressionConverter.ConvertToken(bodyreasonFinished);
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
    }

    public class BlackbaudrenxtvoluntTriggers([ConnectionName] string connectionId)
    {
    }

    public class VolunteerApiJob
    {
        [JsonProperty("id")]
        public int ID { get; set; }

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
        public int OrganizationID { get; set; }

        [JsonProperty("event_id")]
        public int EventID { get; set; }

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
        public int ID { get; set; }

        [JsonProperty("constituent_id")]
        public int ConstituentID { get; set; }

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
        public int ID { get; set; }

        [JsonProperty("job_id")]
        public int JobID { get; set; }

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
        public int ID { get; set; }

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
        public int ID { get; set; }

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
        public int ID { get; set; }

        [JsonProperty("job_id")]
        public int JobID { get; set; }

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
        public int ID { get; set; }

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
        public int ID { get; set; }
    }

    public class VolunteerApiCreatedVolunteerSkill
    {
        [JsonProperty("id")]
        public int ID { get; set; }
    }

    public class VolunteerApiCreatedVolunteerType
    {
        [JsonProperty("id")]
        public int ID { get; set; }
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