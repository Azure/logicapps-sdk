//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Servicedeskpluscloud
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServicedeskpluscloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicedeskpluscloud")]
        public IBodyWorkflowAction<CreateRequestResponse, ApiConnectionActionConfiguration> CreateRequest(Expression<Func<string>> serviceDeskInstance, Expression<Func<CreateRequestInput>> body = null)
        {
            var __workflow_serviceDeskInstance = WorkflowExpression.Compile(serviceDeskInstance, nameof(serviceDeskInstance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/app/{0}/api/v3/requests", __workflow_serviceDeskInstance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicedeskpluscloud")]
        public IBodyWorkflowAction<UpdateRequestResponse, ApiConnectionActionConfiguration> UpdateRequest(Expression<Func<string>> serviceDeskInstance, Expression<Func<string>> id, Expression<Func<UpdateRequestInput>> body = null)
        {
            var __workflow_serviceDeskInstance = WorkflowExpression.Compile(serviceDeskInstance, nameof(serviceDeskInstance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/app/{0}/api/v3/requests/{1}", __workflow_serviceDeskInstance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicedeskpluscloud")]
        public IBodyWorkflowAction<CreateChangeResponse, ApiConnectionActionConfiguration> CreateChange(Expression<Func<string>> serviceDeskInstance, Expression<Func<CreateChangeInput>> body = null)
        {
            var __workflow_serviceDeskInstance = WorkflowExpression.Compile(serviceDeskInstance, nameof(serviceDeskInstance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateChangeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/app/{0}/api/v3/changes", __workflow_serviceDeskInstance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateChangeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicedeskpluscloud")]
        public IBodyWorkflowAction<UpdateChangeResponse, ApiConnectionActionConfiguration> UpdateChange(Expression<Func<string>> serviceDeskInstance, Expression<Func<string>> id, Expression<Func<UpdateChangeInput>> body = null)
        {
            var __workflow_serviceDeskInstance = WorkflowExpression.Compile(serviceDeskInstance, nameof(serviceDeskInstance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateChangeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/app/{0}/api/v3/changes/{1}", __workflow_serviceDeskInstance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateChangeResponse>(callPayload);
            });
        }
    }

    public class ServicedeskpluscloudTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateRequestResponse
    {
        [JsonProperty("request")]
        public CreateRequestResponseRequestType Request { get; set; }
    }

    public class CreateRequestResponseRequestType
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("project")]
        public CreateRequestResponseRequestTypeProjectType Project { get; set; }

        [JsonProperty("resolution")]
        public CreateRequestResponseRequestTypeResolutionType Resolution { get; set; }

        [JsonProperty("linked_to_request")]
        public CreateRequestResponseRequestTypeLinkedToRequestType LinkedToRequest { get; set; }

        [JsonProperty("mode")]
        public CreateRequestResponseRequestTypeModeType Mode { get; set; }

        [JsonProperty("lifecycle")]
        public JToken Lifecycle { get; set; }

        [JsonProperty("is_read")]
        public bool IsRead { get; set; }

        [JsonProperty("assets")]
        public CreateRequestResponseRequestTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("cancellation_requested")]
        public bool CancellationRequested { get; set; }

        [JsonProperty("is_trashed")]
        public bool IsTrashed { get; set; }

        [JsonProperty("has_change_initiated_request")]
        public bool HasChangeInitiatedRequest { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("assigned_time")]
        public CreateRequestResponseRequestTypeAssignedTimeType AssignedTime { get; set; }

        [JsonProperty("group")]
        public CreateRequestResponseRequestTypeGroupType Group { get; set; }

        [JsonProperty("requester")]
        public CreateRequestResponseRequestTypeRequesterType Requester { get; set; }

        [JsonProperty("email_to")]
        public JToken[] EmailTo { get; set; }

        [JsonProperty("created_time")]
        public CreateRequestResponseRequestTypeCreatedTimeType CreatedTime { get; set; }

        [JsonProperty("item")]
        public CreateRequestResponseRequestTypeItemType Item { get; set; }

        [JsonProperty("cancel_flag_comments")]
        public JToken CancelFlagComments { get; set; }

        [JsonProperty("level")]
        public CreateRequestResponseRequestTypeLevelType Level { get; set; }

        [JsonProperty("approval_status")]
        public JToken ApprovalStatus { get; set; }

        [JsonProperty("impact")]
        public CreateRequestResponseRequestTypeImpactType Impact { get; set; }

        [JsonProperty("service_category")]
        public CreateRequestResponseRequestTypeServiceCategoryType ServiceCategory { get; set; }

        [JsonProperty("sla")]
        public CreateRequestResponseRequestTypeSlaType Sla { get; set; }

        [JsonProperty("resolved_time")]
        public JToken ResolvedTime { get; set; }

        [JsonProperty("priority")]
        public CreateRequestResponseRequestTypePriorityType Priority { get; set; }

        [JsonProperty("created_by")]
        public CreateRequestResponseRequestTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("scheduled_end_time")]
        public CreateRequestResponseRequestTypeScheduledEndTimeType ScheduledEndTime { get; set; }

        [JsonProperty("first_response_due_by_time")]
        public CreateRequestResponseRequestTypeFirstResponseDueByTimeType FirstResponseDueByTime { get; set; }

        [JsonProperty("is_escalated")]
        public bool IsEscalated { get; set; }

        [JsonProperty("last_updated_time")]
        public CreateRequestResponseRequestTypeLastUpdatedTimeType LastUpdatedTime { get; set; }

        [JsonProperty("has_notes")]
        public bool HasNotes { get; set; }

        [JsonProperty("udf_fields")]
        public JToken UdfFields { get; set; }

        [JsonProperty("impact_details")]
        public string ImpactDetails { get; set; }

        [JsonProperty("subcategory")]
        public CreateRequestResponseRequestTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("deleted_time")]
        public JToken DeletedTime { get; set; }

        [JsonProperty("email_cc")]
        public string[] EmailCc { get; set; }

        [JsonProperty("onhold_scheduler")]
        public JToken OnholdScheduler { get; set; }

        [JsonProperty("status")]
        public CreateRequestResponseRequestTypeStatusType Status { get; set; }

        [JsonProperty("scheduled_start_time")]
        public CreateRequestResponseRequestTypeScheduledStartTimeType ScheduledStartTime { get; set; }

        [JsonProperty("template")]
        public CreateRequestResponseRequestTypeTemplateType Template { get; set; }

        [JsonProperty("email_ids_to_notify")]
        public string[] EmailIdsToNotify { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("request_type")]
        public CreateRequestResponseRequestTypeRequestTypeType RequestType { get; set; }

        [JsonProperty("completed_by_denial")]
        public bool CompletedByDenial { get; set; }

        [JsonProperty("display_id")]
        public string DisplayId { get; set; }

        [JsonProperty("time_elapsed")]
        public string TimeElapsed { get; set; }

        [JsonProperty("notification_status")]
        public JToken NotificationStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("responded_time")]
        public string RespondedTime { get; set; }

        [JsonProperty("is_service_request")]
        public bool IsServiceRequest { get; set; }

        [JsonProperty("deleted_assets")]
        public JToken[] DeletedAssets { get; set; }

        [JsonProperty("urgency")]
        public CreateRequestResponseRequestTypeUrgencyType Urgency { get; set; }

        [JsonProperty("has_request_initiated_change")]
        public bool HasRequestInitiatedChange { get; set; }

        [JsonProperty("request_template_task_ids")]
        public CreateRequestResponseRequestTypeRequestTemplateTaskIdsTypeItem[] RequestTemplateTaskIds { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("is_reopened")]
        public bool IsReopened { get; set; }

        [JsonProperty("has_draft")]
        public bool HasDraft { get; set; }

        [JsonProperty("has_attachments")]
        public bool HasAttachments { get; set; }

        [JsonProperty("has_linked_requests")]
        public bool HasLinkedRequests { get; set; }

        [JsonProperty("is_overdue")]
        public bool IsOverdue { get; set; }

        [JsonProperty("technician")]
        public CreateRequestResponseRequestTypeTechnicianType Technician { get; set; }

        [JsonProperty("has_problem")]
        public bool HasProblem { get; set; }

        [JsonProperty("due_by_time")]
        public CreateRequestResponseRequestTypeDueByTimeType DueByTime { get; set; }

        [JsonProperty("is_fcr")]
        public bool IsFcr { get; set; }

        [JsonProperty("has_project")]
        public bool HasProject { get; set; }

        [JsonProperty("site")]
        public CreateRequestResponseRequestTypeSiteType Site { get; set; }

        [JsonProperty("is_first_response_overdue")]
        public bool IsFirstResponseOverdue { get; set; }

        [JsonProperty("completed_time")]
        public JToken CompletedTime { get; set; }

        [JsonProperty("unreplied_count")]
        public int UnrepliedCount { get; set; }

        [JsonProperty("email_bcc")]
        public JToken[] EmailBcc { get; set; }

        [JsonProperty("category")]
        public CreateRequestResponseRequestTypeCategoryType Category { get; set; }

        [JsonProperty("maintenance")]
        public JToken Maintenance { get; set; }
    }

    public class CreateRequestResponseRequestTypeProjectType
    {
        [JsonProperty("display_id")]
        public CreateRequestResponseRequestTypeProjectTypeDisplayIdType DisplayId { get; set; }

        [JsonProperty("project_code")]
        public JToken ProjectCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CreateRequestResponseRequestTypeProjectTypeDisplayIdType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeResolutionType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class CreateRequestResponseRequestTypeLinkedToRequestType
    {
        [JsonProperty("request")]
        public CreateRequestResponseRequestTypeLinkedToRequestTypeRequestType Request { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class CreateRequestResponseRequestTypeLinkedToRequestTypeRequestType
    {
        [JsonProperty("display_id")]
        public int DisplayId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeModeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeAssetsTypeItem
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeAssignedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeGroupType
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeRequesterType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateRequestResponseRequestTypeCreatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeLevelType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeServiceCategoryType
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sort_index")]
        public int SortIndex { get; set; }
    }

    public class CreateRequestResponseRequestTypeSlaType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypePriorityType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeCreatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateRequestResponseRequestTypeScheduledEndTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeFirstResponseDueByTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeLastUpdatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeStatusType
    {
        [JsonProperty("in_progress")]
        public bool InProgress { get; set; }

        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stop_timer")]
        public bool StopTimer { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeScheduledStartTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeTemplateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeRequestTypeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeRequestTemplateTaskIdsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeTechnicianType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("cost_per_hour")]
        public string CostPerHour { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public CreateRequestResponseRequestTypeTechnicianTypeDepartmentType Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateRequestResponseRequestTypeTechnicianTypeDepartmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeDueByTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeCategoryType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestInput
    {
        [JsonProperty("input_data", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRequestInputInputDataType InputData { get; set; }
    }

    public class CreateRequestInputInputDataType
    {
        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRequestInputInputDataTypeRequestType Request { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestType
    {
        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("template")]
        public CreateRequestInputInputDataTypeRequestTypeTemplateType Template { get; set; }

        [JsonProperty("request_type")]
        public CreateRequestInputInputDataTypeRequestTypeRequestTypeType RequestType { get; set; }

        [JsonProperty("requester")]
        public CreateRequestInputInputDataTypeRequestTypeRequesterType Requester { get; set; }

        [JsonProperty("status")]
        public CreateRequestInputInputDataTypeRequestTypeStatusType Status { get; set; }

        [JsonProperty("technician")]
        public CreateRequestInputInputDataTypeRequestTypeTechnicianType Technician { get; set; }

        [JsonProperty("site")]
        public CreateRequestInputInputDataTypeRequestTypeSiteType Site { get; set; }

        [JsonProperty("group")]
        public CreateRequestInputInputDataTypeRequestTypeGroupType Group { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("priority")]
        public CreateRequestInputInputDataTypeRequestTypePriorityType Priority { get; set; }

        [JsonProperty("urgency")]
        public CreateRequestInputInputDataTypeRequestTypeUrgencyType Urgency { get; set; }

        [JsonProperty("impact")]
        public CreateRequestInputInputDataTypeRequestTypeImpactType Impact { get; set; }

        [JsonProperty("mode")]
        public CreateRequestInputInputDataTypeRequestTypeModeType Mode { get; set; }

        [JsonProperty("category")]
        public CreateRequestInputInputDataTypeRequestTypeCategoryType Category { get; set; }

        [JsonProperty("subcategory")]
        public CreateRequestInputInputDataTypeRequestTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("item")]
        public CreateRequestInputInputDataTypeRequestTypeItemType Item { get; set; }

        [JsonProperty("assets")]
        public CreateRequestInputInputDataTypeRequestTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("udf_fields")]
        public string UdfFields { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeTemplateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeRequestTypeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeRequesterType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeStatusType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeTechnicianType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeSiteType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeGroupType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypePriorityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeModeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeCategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRequestInputInputDataTypeRequestTypeAssetsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestResponse
    {
        [JsonProperty("request")]
        public UpdateRequestResponseRequestType Request { get; set; }
    }

    public class UpdateRequestResponseRequestType
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("project")]
        public UpdateRequestResponseRequestTypeProjectType Project { get; set; }

        [JsonProperty("resolution")]
        public UpdateRequestResponseRequestTypeResolutionType Resolution { get; set; }

        [JsonProperty("linked_to_request")]
        public UpdateRequestResponseRequestTypeLinkedToRequestType LinkedToRequest { get; set; }

        [JsonProperty("mode")]
        public UpdateRequestResponseRequestTypeModeType Mode { get; set; }

        [JsonProperty("lifecycle")]
        public JToken Lifecycle { get; set; }

        [JsonProperty("is_read")]
        public bool IsRead { get; set; }

        [JsonProperty("assets")]
        public UpdateRequestResponseRequestTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("cancellation_requested")]
        public bool CancellationRequested { get; set; }

        [JsonProperty("is_trashed")]
        public bool IsTrashed { get; set; }

        [JsonProperty("has_change_initiated_request")]
        public bool HasChangeInitiatedRequest { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("assigned_time")]
        public UpdateRequestResponseRequestTypeAssignedTimeType AssignedTime { get; set; }

        [JsonProperty("group")]
        public UpdateRequestResponseRequestTypeGroupType Group { get; set; }

        [JsonProperty("requester")]
        public UpdateRequestResponseRequestTypeRequesterType Requester { get; set; }

        [JsonProperty("email_to")]
        public JToken[] EmailTo { get; set; }

        [JsonProperty("created_time")]
        public UpdateRequestResponseRequestTypeCreatedTimeType CreatedTime { get; set; }

        [JsonProperty("item")]
        public UpdateRequestResponseRequestTypeItemType Item { get; set; }

        [JsonProperty("cancel_flag_comments")]
        public JToken CancelFlagComments { get; set; }

        [JsonProperty("level")]
        public UpdateRequestResponseRequestTypeLevelType Level { get; set; }

        [JsonProperty("approval_status")]
        public JToken ApprovalStatus { get; set; }

        [JsonProperty("impact")]
        public UpdateRequestResponseRequestTypeImpactType Impact { get; set; }

        [JsonProperty("service_category")]
        public UpdateRequestResponseRequestTypeServiceCategoryType ServiceCategory { get; set; }

        [JsonProperty("sla")]
        public UpdateRequestResponseRequestTypeSlaType Sla { get; set; }

        [JsonProperty("resolved_time")]
        public JToken ResolvedTime { get; set; }

        [JsonProperty("priority")]
        public UpdateRequestResponseRequestTypePriorityType Priority { get; set; }

        [JsonProperty("created_by")]
        public UpdateRequestResponseRequestTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("scheduled_end_time")]
        public UpdateRequestResponseRequestTypeScheduledEndTimeType ScheduledEndTime { get; set; }

        [JsonProperty("first_response_due_by_time")]
        public UpdateRequestResponseRequestTypeFirstResponseDueByTimeType FirstResponseDueByTime { get; set; }

        [JsonProperty("is_escalated")]
        public bool IsEscalated { get; set; }

        [JsonProperty("last_updated_time")]
        public UpdateRequestResponseRequestTypeLastUpdatedTimeType LastUpdatedTime { get; set; }

        [JsonProperty("has_notes")]
        public bool HasNotes { get; set; }

        [JsonProperty("udf_fields")]
        public JToken UdfFields { get; set; }

        [JsonProperty("impact_details")]
        public string ImpactDetails { get; set; }

        [JsonProperty("subcategory")]
        public UpdateRequestResponseRequestTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("deleted_time")]
        public JToken DeletedTime { get; set; }

        [JsonProperty("email_cc")]
        public string[] EmailCc { get; set; }

        [JsonProperty("onhold_scheduler")]
        public JToken OnholdScheduler { get; set; }

        [JsonProperty("status")]
        public UpdateRequestResponseRequestTypeStatusType Status { get; set; }

        [JsonProperty("scheduled_start_time")]
        public UpdateRequestResponseRequestTypeScheduledStartTimeType ScheduledStartTime { get; set; }

        [JsonProperty("template")]
        public UpdateRequestResponseRequestTypeTemplateType Template { get; set; }

        [JsonProperty("email_ids_to_notify")]
        public string[] EmailIdsToNotify { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("request_type")]
        public UpdateRequestResponseRequestTypeRequestTypeType RequestType { get; set; }

        [JsonProperty("completed_by_denial")]
        public bool CompletedByDenial { get; set; }

        [JsonProperty("display_id")]
        public string DisplayId { get; set; }

        [JsonProperty("time_elapsed")]
        public string TimeElapsed { get; set; }

        [JsonProperty("notification_status")]
        public JToken NotificationStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("responded_time")]
        public string RespondedTime { get; set; }

        [JsonProperty("is_service_request")]
        public bool IsServiceRequest { get; set; }

        [JsonProperty("deleted_assets")]
        public JToken[] DeletedAssets { get; set; }

        [JsonProperty("urgency")]
        public UpdateRequestResponseRequestTypeUrgencyType Urgency { get; set; }

        [JsonProperty("has_request_initiated_change")]
        public bool HasRequestInitiatedChange { get; set; }

        [JsonProperty("request_template_task_ids")]
        public UpdateRequestResponseRequestTypeRequestTemplateTaskIdsTypeItem[] RequestTemplateTaskIds { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("is_reopened")]
        public bool IsReopened { get; set; }

        [JsonProperty("has_draft")]
        public bool HasDraft { get; set; }

        [JsonProperty("has_attachments")]
        public bool HasAttachments { get; set; }

        [JsonProperty("has_linked_requests")]
        public bool HasLinkedRequests { get; set; }

        [JsonProperty("is_overdue")]
        public bool IsOverdue { get; set; }

        [JsonProperty("technician")]
        public UpdateRequestResponseRequestTypeTechnicianType Technician { get; set; }

        [JsonProperty("has_problem")]
        public bool HasProblem { get; set; }

        [JsonProperty("due_by_time")]
        public UpdateRequestResponseRequestTypeDueByTimeType DueByTime { get; set; }

        [JsonProperty("is_fcr")]
        public bool IsFcr { get; set; }

        [JsonProperty("has_project")]
        public bool HasProject { get; set; }

        [JsonProperty("site")]
        public UpdateRequestResponseRequestTypeSiteType Site { get; set; }

        [JsonProperty("is_first_response_overdue")]
        public bool IsFirstResponseOverdue { get; set; }

        [JsonProperty("completed_time")]
        public JToken CompletedTime { get; set; }

        [JsonProperty("unreplied_count")]
        public int UnrepliedCount { get; set; }

        [JsonProperty("email_bcc")]
        public JToken[] EmailBcc { get; set; }

        [JsonProperty("category")]
        public UpdateRequestResponseRequestTypeCategoryType Category { get; set; }

        [JsonProperty("maintenance")]
        public JToken Maintenance { get; set; }
    }

    public class UpdateRequestResponseRequestTypeProjectType
    {
        [JsonProperty("display_id")]
        public UpdateRequestResponseRequestTypeProjectTypeDisplayIdType DisplayId { get; set; }

        [JsonProperty("project_code")]
        public JToken ProjectCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class UpdateRequestResponseRequestTypeProjectTypeDisplayIdType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeResolutionType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class UpdateRequestResponseRequestTypeLinkedToRequestType
    {
        [JsonProperty("request")]
        public UpdateRequestResponseRequestTypeLinkedToRequestTypeRequestType Request { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class UpdateRequestResponseRequestTypeLinkedToRequestTypeRequestType
    {
        [JsonProperty("display_id")]
        public int DisplayId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeModeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeAssetsTypeItem
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeAssignedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeGroupType
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeRequesterType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateRequestResponseRequestTypeCreatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeLevelType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeServiceCategoryType
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sort_index")]
        public int SortIndex { get; set; }
    }

    public class UpdateRequestResponseRequestTypeSlaType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypePriorityType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeCreatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateRequestResponseRequestTypeScheduledEndTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeFirstResponseDueByTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeLastUpdatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeStatusType
    {
        [JsonProperty("in_progress")]
        public bool InProgress { get; set; }

        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stop_timer")]
        public bool StopTimer { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeScheduledStartTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeTemplateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeRequestTypeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeRequestTemplateTaskIdsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeTechnicianType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("cost_per_hour")]
        public string CostPerHour { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public UpdateRequestResponseRequestTypeTechnicianTypeDepartmentType Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateRequestResponseRequestTypeTechnicianTypeDepartmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeDueByTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeCategoryType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestInput
    {
        [JsonProperty("input_data", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateRequestInputInputDataType InputData { get; set; }
    }

    public class UpdateRequestInputInputDataType
    {
        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateRequestInputInputDataTypeRequestType Request { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestType
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("template")]
        public UpdateRequestInputInputDataTypeRequestTypeTemplateType Template { get; set; }

        [JsonProperty("request_type")]
        public UpdateRequestInputInputDataTypeRequestTypeRequestTypeType RequestType { get; set; }

        [JsonProperty("requester")]
        public UpdateRequestInputInputDataTypeRequestTypeRequesterType Requester { get; set; }

        [JsonProperty("status")]
        public UpdateRequestInputInputDataTypeRequestTypeStatusType Status { get; set; }

        [JsonProperty("technician")]
        public UpdateRequestInputInputDataTypeRequestTypeTechnicianType Technician { get; set; }

        [JsonProperty("site")]
        public UpdateRequestInputInputDataTypeRequestTypeSiteType Site { get; set; }

        [JsonProperty("group")]
        public UpdateRequestInputInputDataTypeRequestTypeGroupType Group { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("priority")]
        public UpdateRequestInputInputDataTypeRequestTypePriorityType Priority { get; set; }

        [JsonProperty("urgency")]
        public UpdateRequestInputInputDataTypeRequestTypeUrgencyType Urgency { get; set; }

        [JsonProperty("impact")]
        public UpdateRequestInputInputDataTypeRequestTypeImpactType Impact { get; set; }

        [JsonProperty("mode")]
        public UpdateRequestInputInputDataTypeRequestTypeModeType Mode { get; set; }

        [JsonProperty("category")]
        public UpdateRequestInputInputDataTypeRequestTypeCategoryType Category { get; set; }

        [JsonProperty("subcategory")]
        public UpdateRequestInputInputDataTypeRequestTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("item")]
        public UpdateRequestInputInputDataTypeRequestTypeItemType Item { get; set; }

        [JsonProperty("assets")]
        public UpdateRequestInputInputDataTypeRequestTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("udf_fields")]
        public string UdfFields { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeTemplateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeRequestTypeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeRequesterType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeStatusType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeTechnicianType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeSiteType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeGroupType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypePriorityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeModeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeCategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestInputInputDataTypeRequestTypeAssetsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeResponse
    {
        [JsonProperty("response_status")]
        public CreateChangeResponseResponseStatusType ResponseStatus { get; set; }

        [JsonProperty("change")]
        public CreateChangeResponseChangeType Change { get; set; }
    }

    public class CreateChangeResponseResponseStatusType
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CreateChangeResponseChangeType
    {
        [JsonProperty("roll_out_plan")]
        public CreateChangeResponseChangeTypeRollOutPlanType RollOutPlan { get; set; }

        [JsonProperty("emergency")]
        public bool Emergency { get; set; }

        [JsonProperty("change_type")]
        public CreateChangeResponseChangeTypeChangeTypeType ChangeType { get; set; }

        [JsonProperty("review_details")]
        public CreateChangeResponseChangeTypeReviewDetailsType ReviewDetails { get; set; }

        [JsonProperty("assets")]
        public CreateChangeResponseChangeTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("configuration_items")]
        public JToken[] ConfigurationItems { get; set; }

        [JsonProperty("workflow_instance_details")]
        public CreateChangeResponseChangeTypeWorkflowInstanceDetailsType WorkflowInstanceDetails { get; set; }

        [JsonProperty("rel")]
        public CreateChangeResponseChangeTypeRelType Rel { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("change_requester")]
        public CreateChangeResponseChangeTypeChangeRequesterType ChangeRequester { get; set; }

        [JsonProperty("group")]
        public CreateChangeResponseChangeTypeGroupType Group { get; set; }

        [JsonProperty("created_time")]
        public CreateChangeResponseChangeTypeCreatedTimeType CreatedTime { get; set; }

        [JsonProperty("item")]
        public CreateChangeResponseChangeTypeItemType Item { get; set; }

        [JsonProperty("workflow")]
        public CreateChangeResponseChangeTypeWorkflowType Workflow { get; set; }

        [JsonProperty("approval_status")]
        public string ApprovalStatus { get; set; }

        [JsonProperty("impact")]
        public CreateChangeResponseChangeTypeImpactType Impact { get; set; }

        [JsonProperty("release_details")]
        public CreateChangeResponseChangeTypeReleaseDetailsType ReleaseDetails { get; set; }

        [JsonProperty("priority")]
        public CreateChangeResponseChangeTypePriorityType Priority { get; set; }

        [JsonProperty("scheduled_end_time")]
        public CreateChangeResponseChangeTypeScheduledEndTimeType ScheduledEndTime { get; set; }

        [JsonProperty("uat_details")]
        public CreateChangeResponseChangeTypeUatDetailsType UatDetails { get; set; }

        [JsonProperty("reason_for_change")]
        public CreateChangeResponseChangeTypeReasonForChangeType ReasonForChange { get; set; }

        [JsonProperty("udf_fields")]
        public JToken UdfFields { get; set; }

        [JsonProperty("impact_details")]
        public CreateChangeResponseChangeTypeImpactDetailsType ImpactDetails { get; set; }

        [JsonProperty("subcategory")]
        public CreateChangeResponseChangeTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("deleted_time")]
        public JToken DeletedTime { get; set; }

        [JsonProperty("is_freeze_conflicted")]
        public bool IsFreezeConflicted { get; set; }

        [JsonProperty("status")]
        public CreateChangeResponseChangeTypeStatusType Status { get; set; }

        [JsonProperty("scheduled_start_time")]
        public CreateChangeResponseChangeTypeScheduledStartTimeType ScheduledStartTime { get; set; }

        [JsonProperty("template")]
        public CreateChangeResponseChangeTypeTemplateType Template { get; set; }

        [JsonProperty("has_release_association")]
        public bool HasReleaseAssociation { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("display_id")]
        public CreateChangeResponseChangeTypeDisplayIdType DisplayId { get; set; }

        [JsonProperty("roles")]
        public CreateChangeResponseChangeTypeRolesTypeItem[] Roles { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("change_owner")]
        public CreateChangeResponseChangeTypeChangeOwnerType ChangeOwner { get; set; }

        [JsonProperty("urgency")]
        public CreateChangeResponseChangeTypeUrgencyType Urgency { get; set; }

        [JsonProperty("close_details")]
        public CreateChangeResponseChangeTypeCloseDetailsType CloseDetails { get; set; }

        [JsonProperty("change_manager")]
        public string ChangeManager { get; set; }

        [JsonProperty("is_freezed")]
        public bool IsFreezed { get; set; }

        [JsonProperty("retrospective")]
        public bool Retrospective { get; set; }

        [JsonProperty("checklist")]
        public CreateChangeResponseChangeTypeChecklistType Checklist { get; set; }

        [JsonProperty("services")]
        public CreateChangeResponseChangeTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("back_out_plan")]
        public CreateChangeResponseChangeTypeBackOutPlanType BackOutPlan { get; set; }

        [JsonProperty("site")]
        public CreateChangeResponseChangeTypeSiteType Site { get; set; }

        [JsonProperty("stage")]
        public CreateChangeResponseChangeTypeStageType Stage { get; set; }

        [JsonProperty("completed_time")]
        public CreateChangeResponseChangeTypeCompletedTimeType CompletedTime { get; set; }

        [JsonProperty("risk")]
        public CreateChangeResponseChangeTypeRiskType Risk { get; set; }

        [JsonProperty("category")]
        public CreateChangeResponseChangeTypeCategoryType Category { get; set; }

        [JsonProperty("notes_present")]
        public bool NotesPresent { get; set; }
    }

    public class CreateChangeResponseChangeTypeRollOutPlanType
    {
        [JsonProperty("roll_out_plan_updated_on")]
        public CreateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedOnType RollOutPlanUpdatedOn { get; set; }

        [JsonProperty("roll_out_plan_updated_by")]
        public CreateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedByType RollOutPlanUpdatedBy { get; set; }

        [JsonProperty("roll_out_plan_description")]
        public string RollOutPlanDescription { get; set; }
    }

    public class CreateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeChangeTypeType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("pre_approved")]
        public bool PreApproved { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeReviewDetailsType
    {
        [JsonProperty("next_review_on")]
        public JToken NextReviewOn { get; set; }

        [JsonProperty("review_details_updated_by")]
        public JToken ReviewDetailsUpdatedBy { get; set; }

        [JsonProperty("review_details_updated_on")]
        public JToken ReviewDetailsUpdatedOn { get; set; }

        [JsonProperty("review_details_description")]
        public JToken ReviewDetailsDescription { get; set; }
    }

    public class CreateChangeResponseChangeTypeAssetsTypeItem
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeWorkflowInstanceDetailsType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public CreateChangeResponseChangeTypeWorkflowInstanceDetailsTypeStatusType Status { get; set; }
    }

    public class CreateChangeResponseChangeTypeWorkflowInstanceDetailsTypeStatusType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeRelType
    {
        [JsonProperty("releases")]
        public JToken Releases { get; set; }
    }

    public class CreateChangeResponseChangeTypeChangeRequesterType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeGroupType
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeCreatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeWorkflowType
    {
        [JsonProperty("validated")]
        public bool Validated { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeReleaseDetailsType
    {
        [JsonProperty("release_actual_start")]
        public JToken ReleaseActualStart { get; set; }

        [JsonProperty("release_actual_end")]
        public JToken ReleaseActualEnd { get; set; }

        [JsonProperty("release_details_description")]
        public string ReleaseDetailsDescription { get; set; }

        [JsonProperty("release_scheduled_end")]
        public CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledEndType ReleaseScheduledEnd { get; set; }

        [JsonProperty("release_details_updated_on")]
        public CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedOnType ReleaseDetailsUpdatedOn { get; set; }

        [JsonProperty("release_scheduled_start")]
        public CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledStartType ReleaseScheduledStart { get; set; }

        [JsonProperty("release_details_updated_by")]
        public CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedByType ReleaseDetailsUpdatedBy { get; set; }
    }

    public class CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledEndType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledStartType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypePriorityType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeScheduledEndTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeUatDetailsType
    {
        [JsonProperty("uat_scheduled_start")]
        public JToken UatScheduledStart { get; set; }

        [JsonProperty("uat_actual_end")]
        public JToken UatActualEnd { get; set; }

        [JsonProperty("uat_details_updated_by")]
        public CreateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedByType UatDetailsUpdatedBy { get; set; }

        [JsonProperty("uat_details_description")]
        public string UatDetailsDescription { get; set; }

        [JsonProperty("uat_details_updated_on")]
        public CreateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedOnType UatDetailsUpdatedOn { get; set; }

        [JsonProperty("uat_scheduled_end")]
        public JToken UatScheduledEnd { get; set; }

        [JsonProperty("uat_actual_start")]
        public JToken UatActualStart { get; set; }
    }

    public class CreateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeReasonForChangeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeImpactDetailsType
    {
        [JsonProperty("impact_details_updated_on")]
        public CreateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedOnType ImpactDetailsUpdatedOn { get; set; }

        [JsonProperty("impact_details_updated_by")]
        public CreateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedByType ImpactDetailsUpdatedBy { get; set; }

        [JsonProperty("impact_details_description")]
        public string ImpactDetailsDescription { get; set; }
    }

    public class CreateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeStatusType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stage")]
        public CreateChangeResponseChangeTypeStatusTypeStageType Stage { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeStatusTypeStageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeScheduledStartTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeTemplateType
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeDisplayIdType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeRolesTypeItem
    {
        [JsonProperty("role")]
        public CreateChangeResponseChangeTypeRolesTypeItemRoleType Role { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user")]
        public CreateChangeResponseChangeTypeRolesTypeItemUserType User { get; set; }
    }

    public class CreateChangeResponseChangeTypeRolesTypeItemRoleType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("user_type")]
        public string UserType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeRolesTypeItemUserType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public CreateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentType Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentType
    {
        [JsonProperty("site")]
        public CreateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentTypeSiteType Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeChangeOwnerType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("cost_per_hour")]
        public string CostPerHour { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeCloseDetailsType
    {
        [JsonProperty("close_details_updated_on")]
        public CreateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedOnType CloseDetailsUpdatedOn { get; set; }

        [JsonProperty("close_details_description")]
        public string CloseDetailsDescription { get; set; }

        [JsonProperty("closure_code")]
        public CreateChangeResponseChangeTypeCloseDetailsTypeClosureCodeType ClosureCode { get; set; }

        [JsonProperty("close_details_updated_by")]
        public CreateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedByType CloseDetailsUpdatedBy { get; set; }
    }

    public class CreateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeCloseDetailsTypeClosureCodeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeChecklistType
    {
        [JsonProperty("checklist_description")]
        public string ChecklistDescription { get; set; }

        [JsonProperty("checklist_updated_on")]
        public CreateChangeResponseChangeTypeChecklistTypeChecklistUpdatedOnType ChecklistUpdatedOn { get; set; }

        [JsonProperty("checklist_updated_by")]
        public CreateChangeResponseChangeTypeChecklistTypeChecklistUpdatedByType ChecklistUpdatedBy { get; set; }
    }

    public class CreateChangeResponseChangeTypeChecklistTypeChecklistUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeChecklistTypeChecklistUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeServicesTypeItem
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sort_index")]
        public int SortIndex { get; set; }
    }

    public class CreateChangeResponseChangeTypeBackOutPlanType
    {
        [JsonProperty("back_out_plan_updated_by")]
        public CreateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedByType BackOutPlanUpdatedBy { get; set; }

        [JsonProperty("back_out_plan_updated_on")]
        public CreateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedOnType BackOutPlanUpdatedOn { get; set; }

        [JsonProperty("back_out_plan_description")]
        public string BackOutPlanDescription { get; set; }
    }

    public class CreateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeStageType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stage_index")]
        public int StageIndex { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeCompletedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeRiskType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeCategoryType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeInput
    {
        [JsonProperty("input_data", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateChangeInputInputDataType InputData { get; set; }
    }

    public class CreateChangeInputInputDataType
    {
        [JsonProperty("change", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateChangeInputInputDataTypeChangeType Change { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeType
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("template")]
        public CreateChangeInputInputDataTypeChangeTypeTemplateType Template { get; set; }

        [JsonProperty("change_requester")]
        public CreateChangeInputInputDataTypeChangeTypeChangeRequesterType ChangeRequester { get; set; }

        [JsonProperty("site")]
        public CreateChangeInputInputDataTypeChangeTypeSiteType Site { get; set; }

        [JsonProperty("group")]
        public CreateChangeInputInputDataTypeChangeTypeGroupType Group { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("change_owner")]
        public CreateChangeInputInputDataTypeChangeTypeChangeOwnerType ChangeOwner { get; set; }

        [JsonProperty("change_type")]
        public CreateChangeInputInputDataTypeChangeTypeChangeTypeType ChangeType { get; set; }

        [JsonProperty("priority")]
        public CreateChangeInputInputDataTypeChangeTypePriorityType Priority { get; set; }

        [JsonProperty("urgency")]
        public CreateChangeInputInputDataTypeChangeTypeUrgencyType Urgency { get; set; }

        [JsonProperty("impact")]
        public CreateChangeInputInputDataTypeChangeTypeImpactType Impact { get; set; }

        [JsonProperty("risk")]
        public CreateChangeInputInputDataTypeChangeTypeRiskType Risk { get; set; }

        [JsonProperty("reason_for_change")]
        public CreateChangeInputInputDataTypeChangeTypeReasonForChangeType ReasonForChange { get; set; }

        [JsonProperty("category")]
        public CreateChangeInputInputDataTypeChangeTypeCategoryType Category { get; set; }

        [JsonProperty("subcategory")]
        public CreateChangeInputInputDataTypeChangeTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("item")]
        public CreateChangeInputInputDataTypeChangeTypeItemType Item { get; set; }

        [JsonProperty("assets")]
        public CreateChangeInputInputDataTypeChangeTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("udf_fields")]
        public string UdfFields { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeTemplateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeChangeRequesterType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeSiteType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeGroupType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeChangeOwnerType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeChangeTypeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypePriorityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeRiskType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeReasonForChangeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeCategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChangeInputInputDataTypeChangeTypeAssetsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeResponse
    {
        [JsonProperty("response_status")]
        public UpdateChangeResponseResponseStatusType ResponseStatus { get; set; }

        [JsonProperty("change")]
        public UpdateChangeResponseChangeType Change { get; set; }
    }

    public class UpdateChangeResponseResponseStatusType
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UpdateChangeResponseChangeType
    {
        [JsonProperty("roll_out_plan")]
        public UpdateChangeResponseChangeTypeRollOutPlanType RollOutPlan { get; set; }

        [JsonProperty("emergency")]
        public bool Emergency { get; set; }

        [JsonProperty("change_type")]
        public UpdateChangeResponseChangeTypeChangeTypeType ChangeType { get; set; }

        [JsonProperty("review_details")]
        public UpdateChangeResponseChangeTypeReviewDetailsType ReviewDetails { get; set; }

        [JsonProperty("assets")]
        public UpdateChangeResponseChangeTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("configuration_items")]
        public JToken[] ConfigurationItems { get; set; }

        [JsonProperty("workflow_instance_details")]
        public UpdateChangeResponseChangeTypeWorkflowInstanceDetailsType WorkflowInstanceDetails { get; set; }

        [JsonProperty("rel")]
        public UpdateChangeResponseChangeTypeRelType Rel { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("change_requester")]
        public UpdateChangeResponseChangeTypeChangeRequesterType ChangeRequester { get; set; }

        [JsonProperty("group")]
        public UpdateChangeResponseChangeTypeGroupType Group { get; set; }

        [JsonProperty("created_time")]
        public UpdateChangeResponseChangeTypeCreatedTimeType CreatedTime { get; set; }

        [JsonProperty("item")]
        public UpdateChangeResponseChangeTypeItemType Item { get; set; }

        [JsonProperty("workflow")]
        public UpdateChangeResponseChangeTypeWorkflowType Workflow { get; set; }

        [JsonProperty("approval_status")]
        public string ApprovalStatus { get; set; }

        [JsonProperty("impact")]
        public UpdateChangeResponseChangeTypeImpactType Impact { get; set; }

        [JsonProperty("release_details")]
        public UpdateChangeResponseChangeTypeReleaseDetailsType ReleaseDetails { get; set; }

        [JsonProperty("priority")]
        public UpdateChangeResponseChangeTypePriorityType Priority { get; set; }

        [JsonProperty("scheduled_end_time")]
        public UpdateChangeResponseChangeTypeScheduledEndTimeType ScheduledEndTime { get; set; }

        [JsonProperty("uat_details")]
        public UpdateChangeResponseChangeTypeUatDetailsType UatDetails { get; set; }

        [JsonProperty("reason_for_change")]
        public UpdateChangeResponseChangeTypeReasonForChangeType ReasonForChange { get; set; }

        [JsonProperty("udf_fields")]
        public JToken UdfFields { get; set; }

        [JsonProperty("impact_details")]
        public UpdateChangeResponseChangeTypeImpactDetailsType ImpactDetails { get; set; }

        [JsonProperty("subcategory")]
        public UpdateChangeResponseChangeTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("deleted_time")]
        public JToken DeletedTime { get; set; }

        [JsonProperty("is_freeze_conflicted")]
        public bool IsFreezeConflicted { get; set; }

        [JsonProperty("status")]
        public UpdateChangeResponseChangeTypeStatusType Status { get; set; }

        [JsonProperty("scheduled_start_time")]
        public UpdateChangeResponseChangeTypeScheduledStartTimeType ScheduledStartTime { get; set; }

        [JsonProperty("template")]
        public UpdateChangeResponseChangeTypeTemplateType Template { get; set; }

        [JsonProperty("has_release_association")]
        public bool HasReleaseAssociation { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("display_id")]
        public UpdateChangeResponseChangeTypeDisplayIdType DisplayId { get; set; }

        [JsonProperty("roles")]
        public UpdateChangeResponseChangeTypeRolesTypeItem[] Roles { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("change_owner")]
        public UpdateChangeResponseChangeTypeChangeOwnerType ChangeOwner { get; set; }

        [JsonProperty("urgency")]
        public UpdateChangeResponseChangeTypeUrgencyType Urgency { get; set; }

        [JsonProperty("close_details")]
        public UpdateChangeResponseChangeTypeCloseDetailsType CloseDetails { get; set; }

        [JsonProperty("change_manager")]
        public string ChangeManager { get; set; }

        [JsonProperty("is_freezed")]
        public bool IsFreezed { get; set; }

        [JsonProperty("retrospective")]
        public bool Retrospective { get; set; }

        [JsonProperty("checklist")]
        public UpdateChangeResponseChangeTypeChecklistType Checklist { get; set; }

        [JsonProperty("services")]
        public UpdateChangeResponseChangeTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("back_out_plan")]
        public UpdateChangeResponseChangeTypeBackOutPlanType BackOutPlan { get; set; }

        [JsonProperty("site")]
        public UpdateChangeResponseChangeTypeSiteType Site { get; set; }

        [JsonProperty("stage")]
        public UpdateChangeResponseChangeTypeStageType Stage { get; set; }

        [JsonProperty("completed_time")]
        public UpdateChangeResponseChangeTypeCompletedTimeType CompletedTime { get; set; }

        [JsonProperty("risk")]
        public UpdateChangeResponseChangeTypeRiskType Risk { get; set; }

        [JsonProperty("category")]
        public UpdateChangeResponseChangeTypeCategoryType Category { get; set; }

        [JsonProperty("notes_present")]
        public bool NotesPresent { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRollOutPlanType
    {
        [JsonProperty("roll_out_plan_updated_on")]
        public UpdateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedOnType RollOutPlanUpdatedOn { get; set; }

        [JsonProperty("roll_out_plan_updated_by")]
        public UpdateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedByType RollOutPlanUpdatedBy { get; set; }

        [JsonProperty("roll_out_plan_description")]
        public string RollOutPlanDescription { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChangeTypeType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("pre_approved")]
        public bool PreApproved { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReviewDetailsType
    {
        [JsonProperty("next_review_on")]
        public JToken NextReviewOn { get; set; }

        [JsonProperty("review_details_updated_by")]
        public JToken ReviewDetailsUpdatedBy { get; set; }

        [JsonProperty("review_details_updated_on")]
        public JToken ReviewDetailsUpdatedOn { get; set; }

        [JsonProperty("review_details_description")]
        public JToken ReviewDetailsDescription { get; set; }
    }

    public class UpdateChangeResponseChangeTypeAssetsTypeItem
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeWorkflowInstanceDetailsType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public UpdateChangeResponseChangeTypeWorkflowInstanceDetailsTypeStatusType Status { get; set; }
    }

    public class UpdateChangeResponseChangeTypeWorkflowInstanceDetailsTypeStatusType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRelType
    {
        [JsonProperty("releases")]
        public JToken Releases { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChangeRequesterType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeGroupType
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCreatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeWorkflowType
    {
        [JsonProperty("validated")]
        public bool Validated { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReleaseDetailsType
    {
        [JsonProperty("release_actual_start")]
        public JToken ReleaseActualStart { get; set; }

        [JsonProperty("release_actual_end")]
        public JToken ReleaseActualEnd { get; set; }

        [JsonProperty("release_details_description")]
        public string ReleaseDetailsDescription { get; set; }

        [JsonProperty("release_scheduled_end")]
        public UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledEndType ReleaseScheduledEnd { get; set; }

        [JsonProperty("release_details_updated_on")]
        public UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedOnType ReleaseDetailsUpdatedOn { get; set; }

        [JsonProperty("release_scheduled_start")]
        public UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledStartType ReleaseScheduledStart { get; set; }

        [JsonProperty("release_details_updated_by")]
        public UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedByType ReleaseDetailsUpdatedBy { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledEndType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledStartType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypePriorityType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeScheduledEndTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeUatDetailsType
    {
        [JsonProperty("uat_scheduled_start")]
        public JToken UatScheduledStart { get; set; }

        [JsonProperty("uat_actual_end")]
        public JToken UatActualEnd { get; set; }

        [JsonProperty("uat_details_updated_by")]
        public UpdateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedByType UatDetailsUpdatedBy { get; set; }

        [JsonProperty("uat_details_description")]
        public string UatDetailsDescription { get; set; }

        [JsonProperty("uat_details_updated_on")]
        public UpdateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedOnType UatDetailsUpdatedOn { get; set; }

        [JsonProperty("uat_scheduled_end")]
        public JToken UatScheduledEnd { get; set; }

        [JsonProperty("uat_actual_start")]
        public JToken UatActualStart { get; set; }
    }

    public class UpdateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReasonForChangeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeImpactDetailsType
    {
        [JsonProperty("impact_details_updated_on")]
        public UpdateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedOnType ImpactDetailsUpdatedOn { get; set; }

        [JsonProperty("impact_details_updated_by")]
        public UpdateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedByType ImpactDetailsUpdatedBy { get; set; }

        [JsonProperty("impact_details_description")]
        public string ImpactDetailsDescription { get; set; }
    }

    public class UpdateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeStatusType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stage")]
        public UpdateChangeResponseChangeTypeStatusTypeStageType Stage { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeStatusTypeStageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeScheduledStartTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeTemplateType
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeDisplayIdType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRolesTypeItem
    {
        [JsonProperty("role")]
        public UpdateChangeResponseChangeTypeRolesTypeItemRoleType Role { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user")]
        public UpdateChangeResponseChangeTypeRolesTypeItemUserType User { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRolesTypeItemRoleType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("user_type")]
        public string UserType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRolesTypeItemUserType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public UpdateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentType Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentType
    {
        [JsonProperty("site")]
        public UpdateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentTypeSiteType Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChangeOwnerType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("cost_per_hour")]
        public string CostPerHour { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCloseDetailsType
    {
        [JsonProperty("close_details_updated_on")]
        public UpdateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedOnType CloseDetailsUpdatedOn { get; set; }

        [JsonProperty("close_details_description")]
        public string CloseDetailsDescription { get; set; }

        [JsonProperty("closure_code")]
        public UpdateChangeResponseChangeTypeCloseDetailsTypeClosureCodeType ClosureCode { get; set; }

        [JsonProperty("close_details_updated_by")]
        public UpdateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedByType CloseDetailsUpdatedBy { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCloseDetailsTypeClosureCodeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChecklistType
    {
        [JsonProperty("checklist_description")]
        public string ChecklistDescription { get; set; }

        [JsonProperty("checklist_updated_on")]
        public UpdateChangeResponseChangeTypeChecklistTypeChecklistUpdatedOnType ChecklistUpdatedOn { get; set; }

        [JsonProperty("checklist_updated_by")]
        public UpdateChangeResponseChangeTypeChecklistTypeChecklistUpdatedByType ChecklistUpdatedBy { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChecklistTypeChecklistUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChecklistTypeChecklistUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeServicesTypeItem
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sort_index")]
        public int SortIndex { get; set; }
    }

    public class UpdateChangeResponseChangeTypeBackOutPlanType
    {
        [JsonProperty("back_out_plan_updated_by")]
        public UpdateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedByType BackOutPlanUpdatedBy { get; set; }

        [JsonProperty("back_out_plan_updated_on")]
        public UpdateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedOnType BackOutPlanUpdatedOn { get; set; }

        [JsonProperty("back_out_plan_description")]
        public string BackOutPlanDescription { get; set; }
    }

    public class UpdateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeStageType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stage_index")]
        public int StageIndex { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCompletedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRiskType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCategoryType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeInput
    {
        [JsonProperty("input_data", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateChangeInputInputDataType InputData { get; set; }
    }

    public class UpdateChangeInputInputDataType
    {
        [JsonProperty("change", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateChangeInputInputDataTypeChangeType Change { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("template")]
        public UpdateChangeInputInputDataTypeChangeTypeTemplateType Template { get; set; }

        [JsonProperty("change_requester")]
        public UpdateChangeInputInputDataTypeChangeTypeChangeRequesterType ChangeRequester { get; set; }

        [JsonProperty("site")]
        public UpdateChangeInputInputDataTypeChangeTypeSiteType Site { get; set; }

        [JsonProperty("group")]
        public UpdateChangeInputInputDataTypeChangeTypeGroupType Group { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("change_owner")]
        public UpdateChangeInputInputDataTypeChangeTypeChangeOwnerType ChangeOwner { get; set; }

        [JsonProperty("change_type")]
        public UpdateChangeInputInputDataTypeChangeTypeChangeTypeType ChangeType { get; set; }

        [JsonProperty("priority")]
        public UpdateChangeInputInputDataTypeChangeTypePriorityType Priority { get; set; }

        [JsonProperty("urgency")]
        public UpdateChangeInputInputDataTypeChangeTypeUrgencyType Urgency { get; set; }

        [JsonProperty("impact")]
        public UpdateChangeInputInputDataTypeChangeTypeImpactType Impact { get; set; }

        [JsonProperty("risk")]
        public UpdateChangeInputInputDataTypeChangeTypeRiskType Risk { get; set; }

        [JsonProperty("reason_for_change")]
        public UpdateChangeInputInputDataTypeChangeTypeReasonForChangeType ReasonForChange { get; set; }

        [JsonProperty("category")]
        public UpdateChangeInputInputDataTypeChangeTypeCategoryType Category { get; set; }

        [JsonProperty("subcategory")]
        public UpdateChangeInputInputDataTypeChangeTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("item")]
        public UpdateChangeInputInputDataTypeChangeTypeItemType Item { get; set; }

        [JsonProperty("assets")]
        public UpdateChangeInputInputDataTypeChangeTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("udf_fields")]
        public string UdfFields { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeTemplateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeChangeRequesterType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeSiteType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeGroupType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeChangeOwnerType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeChangeTypeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypePriorityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeRiskType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeReasonForChangeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeCategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeInputInputDataTypeChangeTypeAssetsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Servicedeskpluscloud;

    public partial class WorkflowManagedActions
    {
        public ServicedeskpluscloudActions Servicedeskpluscloud(string connectionId) => new ServicedeskpluscloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ServicedeskpluscloudTriggers Servicedeskpluscloud(string connectionId) => new ServicedeskpluscloudTriggers(connectionId);
    }
}