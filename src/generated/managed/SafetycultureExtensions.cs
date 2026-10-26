//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Safetyculture
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SafetycultureActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<AuditSearchResponse, ApiConnectionActionConfiguration> SearchAudits(Expression<Func<orderInput>> order = null, Expression<Func<string>> modifiedAfter = null, Expression<Func<string>> modifiedBefore = null, Expression<Func<string>> template = null, Expression<Func<archivedInput>> archived = null, Expression<Func<completedInput>> completed = null, Expression<Func<ownerInput>> owner = null, Expression<Func<int>> limit = null)
        {
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_modifiedAfter = WorkflowExpression.Compile(modifiedAfter, nameof(modifiedAfter), required: false);
            var __workflow_modifiedBefore = WorkflowExpression.Compile(modifiedBefore, nameof(modifiedBefore), required: false);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_completed = WorkflowExpression.Compile(completed, nameof(completed), required: false);
            var __workflow_owner = WorkflowExpression.Compile(owner, nameof(owner), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<AuditSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/audits/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_modifiedAfter != null)
                    callPayload.Queries["modified_after"] = ExpressionConverter.Convert(__workflow_modifiedAfter);
                if (__workflow_modifiedBefore != null)
                    callPayload.Queries["modified_before"] = ExpressionConverter.Convert(__workflow_modifiedBefore);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Queries["archived"] = Convert.ToString("false");
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                callPayload.Queries["completed"] = Convert.ToString("true");
                if (__workflow_completed != null)
                    callPayload.Queries["completed"] = ExpressionConverter.Convert(__workflow_completed);
                callPayload.Queries["owner"] = Convert.ToString("all");
                if (__workflow_owner != null)
                    callPayload.Queries["owner"] = ExpressionConverter.Convert(__workflow_owner);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<AuditSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditByIdResponse, ApiConnectionActionConfiguration> GetAuditById(Expression<Func<string>> auditId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            return new DeferredBodyAction<GetAuditByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAuditByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditByIdResponse, ApiConnectionActionConfiguration> ArchiveRestoreAudit(Expression<Func<string>> auditId, Expression<Func<ArchiveRestoreAuditInput>> body = null)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetAuditByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetAuditByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InitExportResponse, ApiConnectionActionConfiguration> InitiateAuditExport(Expression<Func<string>> auditId, Expression<Func<formatInput>> format, Expression<Func<timezoneInput>> timezone = null, Expression<Func<string>> exportProfile = null)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_timezone = WorkflowExpression.Compile(timezone, nameof(timezone), required: false);
            var __workflow_exportProfile = WorkflowExpression.Compile(exportProfile, nameof(exportProfile), required: false);
            return new DeferredBodyAction<InitExportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/export", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Queries["timezone"] = Convert.ToString("Etc/UTC");
                if (__workflow_timezone != null)
                    callPayload.Queries["timezone"] = ExpressionConverter.Convert(__workflow_timezone);
                if (__workflow_exportProfile != null)
                    callPayload.Queries["export_profile"] = ExpressionConverter.Convert(__workflow_exportProfile);
                return new ApiConnectionAction<InitExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<ExportStatusResponse, ApiConnectionActionConfiguration> PollExportStatus(Expression<Func<string>> auditId, Expression<Func<string>> exportId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_exportId = WorkflowExpression.Compile(exportId, nameof(exportId), required: true);
            return new DeferredBodyAction<ExportStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/exports/{1}", __workflow_auditId.WithUrlEncoding(1), __workflow_exportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExportStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetAuditExport(Expression<Func<string>> auditId, Expression<Func<string>> exportId, Expression<Func<string>> filename)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_exportId = WorkflowExpression.Compile(exportId, nameof(exportId), required: true);
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/exports/{1}/{2}", __workflow_auditId.WithUrlEncoding(1), __workflow_exportId.WithUrlEncoding(1), __workflow_filename.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditLinkResponse, ApiConnectionActionConfiguration> GetWebReportLink(Expression<Func<string>> auditId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            return new DeferredBodyAction<GetAuditLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/web_report_link", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAuditLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteWebReportLink(Expression<Func<string>> auditId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/web_report_link", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<ActionsSearchResponse, ApiConnectionActionConfiguration> SearchActions(Expression<Func<SearchActionsInput>> searchActionsBody = null)
        {
            var __workflow_searchActionsBody = WorkflowExpression.Compile(searchActionsBody, nameof(searchActionsBody), required: false);
            return new DeferredBodyAction<ActionsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_searchActionsBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchActionsBody);
                return new ApiConnectionAction<ActionsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<Action, ApiConnectionActionConfiguration> CreateAction(Expression<Func<CreateActionInput>> createActionBody)
        {
            var __workflow_createActionBody = WorkflowExpression.Compile(createActionBody, nameof(createActionBody), required: true);
            return new DeferredBodyAction<Action, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createActionBody);
                return new ApiConnectionAction<Action>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<DeleteActionResponse, ApiConnectionActionConfiguration> DeleteAction(Expression<Func<string>> actionId)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<DeleteActionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/actions/{0}", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteActionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<Action, ApiConnectionActionConfiguration> UpdateAction(Expression<Func<string>> actionId, Expression<Func<UpdateActionInput>> updateActionBody)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            var __workflow_updateActionBody = WorkflowExpression.Compile(updateActionBody, nameof(updateActionBody), required: true);
            return new DeferredBodyAction<Action, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/actions/{0}", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updateActionBody);
                return new ApiConnectionAction<Action>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetMedia(Expression<Func<string>> auditId, Expression<Func<string>> mediaId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_mediaId = WorkflowExpression.Compile(mediaId, nameof(mediaId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/media/{1}", __workflow_auditId.WithUrlEncoding(1), __workflow_mediaId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InitInspectionExportResponse, ApiConnectionActionConfiguration> InitiateInspectionExport(Expression<Func<string>> auditId, Expression<Func<InitiateInspectionExportInput>> format)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            return new DeferredBodyAction<InitInspectionExportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/report", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_format);
                return new ApiConnectionAction<InitInspectionExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InspectionExportStatusResponse, ApiConnectionActionConfiguration> PollInspectionExportStatus(Expression<Func<string>> auditId, Expression<Func<string>> exportId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_exportId = WorkflowExpression.Compile(exportId, nameof(exportId), required: true);
            return new DeferredBodyAction<InspectionExportStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/report/{1}", __workflow_auditId.WithUrlEncoding(1), __workflow_exportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InspectionExportStatusResponse>(callPayload);
            });
        }
    }

    public class SafetycultureTriggers([ConnectionName] string connectionId)
    {
    }

    public class AuditSearchResponse
    {
        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("audits")]
        public AuditSearchResponseInspectionTypeItem[] Inspection { get; set; }
    }

    public class AuditSearchResponseInspectionTypeItem
    {
        [JsonProperty("audit_id")]
        public string AuditId { get; set; }

        [JsonProperty("modified_at")]
        public string DateModified { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderInput
    {
        [EnumMember(Value = "desc")]
        Desc,
        [EnumMember(Value = "asc")]
        Asc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum archivedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "both")]
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum completedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "both")]
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ownerInput
    {
        [EnumMember(Value = "me")]
        Me,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "all")]
        All
    }

    public class GetAuditByIdResponse
    {
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("audit_id")]
        public string AuditId { get; set; }

        [JsonProperty("audit_data")]
        public GetAuditByIdResponseAuditDataType AuditData { get; set; }

        [JsonProperty("template_data")]
        public GetAuditByIdResponseTemplateDataType TemplateData { get; set; }
    }

    public class GetAuditByIdResponseAuditDataType
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("total_score")]
        public double TotalScore { get; set; }

        [JsonProperty("score_percentage")]
        public double ScorePercentage { get; set; }

        [JsonProperty("name")]
        public string InspectionTitle { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("authorship")]
        public GetAuditByIdResponseAuditDataTypeAuthorshipType Authorship { get; set; }

        [JsonProperty("date_completed")]
        public string DateCompleted { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("date_started")]
        public string DateStarted { get; set; }
    }

    public class GetAuditByIdResponseAuditDataTypeAuthorshipType
    {
        [JsonProperty("owner")]
        public string InspectionOwner { get; set; }

        [JsonProperty("owner_id")]
        public string InspectionOwnerId { get; set; }

        [JsonProperty("author")]
        public string InspectionAuthor { get; set; }

        [JsonProperty("author_id")]
        public string InspectionAuthorId { get; set; }
    }

    public class GetAuditByIdResponseTemplateDataType
    {
        [JsonProperty("authorship")]
        public GetAuditByIdResponseTemplateDataTypeAuthorshipType Authorship { get; set; }

        [JsonProperty("metadata")]
        public GetAuditByIdResponseTemplateDataTypeMetadataType Metadata { get; set; }
    }

    public class GetAuditByIdResponseTemplateDataTypeAuthorshipType
    {
        [JsonProperty("owner")]
        public string TemplateOwner { get; set; }

        [JsonProperty("owner_id")]
        public string TemplateOwnerId { get; set; }

        [JsonProperty("author")]
        public string TemplateAuthor { get; set; }

        [JsonProperty("author_id")]
        public string TemplateAuthorId { get; set; }
    }

    public class GetAuditByIdResponseTemplateDataTypeMetadataType
    {
        [JsonProperty("description")]
        public string TemplateDescription { get; set; }

        [JsonProperty("name")]
        public string TemplateName { get; set; }
    }

    public class ArchiveRestoreAuditInput
    {
        [JsonProperty("archived")]
        public bool? Archived { get; set; }
    }

    public class InitExportResponse
    {
        [JsonProperty("id")]
        public string ExportTaskId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "pdf")]
        Pdf,
        [EnumMember(Value = "docx")]
        Docx
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum timezoneInput
    {
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Guatemala")]
        AmericaGuatemala,
        [EnumMember(Value = "Etc/UTC")]
        EtcUTC
    }

    public class ExportStatusResponse
    {
        [JsonProperty("status")]
        public string ExportStatus { get; set; }

        [JsonProperty("href")]
        public string ExportURL { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }
    }

    public class GetAuditLinkResponse
    {
        [JsonProperty("url")]
        public string InspectionLink { get; set; }
    }

    public class ActionsSearchResponse
    {
        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("offset")]
        public double Offset { get; set; }

        [JsonProperty("actions")]
        public Action[] Actions { get; set; }
    }

    public class Action
    {
        [JsonProperty("action_id")]
        public string ActionId { get; set; }

        [JsonProperty("audit")]
        public ActionInspectionType Inspection { get; set; }

        [JsonProperty("item")]
        public ActionItemType Item { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("assignees")]
        public ActionAssigneesTypeItem[] Assignees { get; set; }

        [JsonProperty("created_by")]
        public ActionCreatedByType CreatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreationDate { get; set; }

        [JsonProperty("modified_at")]
        public string ModificationDate { get; set; }

        [JsonProperty("due_at")]
        public string DueDate { get; set; }

        [JsonProperty("completed_at")]
        public string CompletionDate { get; set; }
    }

    public class ActionInspectionType
    {
        [JsonProperty("audit_id")]
        public string AuditId { get; set; }

        [JsonProperty("name")]
        public string InspectionTitle { get; set; }
    }

    public class ActionItemType
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("label")]
        public string ItemLabel { get; set; }
    }

    public class ActionAssigneesTypeItem
    {
        [JsonProperty("id")]
        public string AssigneeId { get; set; }

        [JsonProperty("name")]
        public string AssigneeName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ActionCreatedByType
    {
        [JsonProperty("user_id")]
        public string CreatorId { get; set; }

        [JsonProperty("name")]
        public string CreatorName { get; set; }
    }

    public class SearchActionsInput
    {
        [JsonProperty("audit_id")]
        public string[] AuditId { get; set; }

        [JsonProperty("assignees")]
        public AssigneesArrayItem[] Assignees { get; set; }

        [JsonProperty("created_at")]
        public CreatedAt CreatedAt { get; set; }

        [JsonProperty("modified_at")]
        public ModifiedAt ModifiedAt { get; set; }

        [JsonProperty("due_at")]
        public DueAt DueAt { get; set; }
    }

    public class AssigneesArrayItem
    {
        [JsonProperty("id")]
        public string AssigneeId { get; set; }

        [JsonProperty("type")]
        public AssigneesArrayItemTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssigneesArrayItemTypeType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "email")]
        Email
    }

    public class CreatedAt
    {
        [JsonProperty("from")]
        public string AfterDate { get; set; }

        [JsonProperty("to")]
        public string BeforeDate { get; set; }
    }

    public class ModifiedAt
    {
        [JsonProperty("from")]
        public string AfterDate { get; set; }

        [JsonProperty("to")]
        public string BeforeDate { get; set; }
    }

    public class DueAt
    {
        [JsonProperty("from")]
        public string AfterDate { get; set; }

        [JsonProperty("to")]
        public string BeforeDate { get; set; }
    }

    public class CreateActionInput
    {
        [JsonProperty("audit_id")]
        public string AuditId { get; set; }

        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("priority")]
        public CreateActionInputPriorityType? Priority { get; set; }

        [JsonProperty("status")]
        public CreateActionInputStatusType? Status { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }

        [JsonProperty("assignees")]
        public AssigneesArrayItem2[] Assignees { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateActionInputPriorityType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateActionInputStatusType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60
    }

    public class AssigneesArrayItem2
    {
        [JsonProperty("id")]
        public string AssigneeId { get; set; }

        [JsonProperty("type")]
        public AssigneesArrayItemTypeType Type { get; set; }
    }

    public class DeleteActionResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }

    public class UpdateActionInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("priority")]
        public UpdateActionInputPriorityType? Priority { get; set; }

        [JsonProperty("status")]
        public UpdateActionInputStatusType? Status { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }

        [JsonProperty("assignees")]
        public AssigneesArrayItem22[] Assignees { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateActionInputPriorityType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateActionInputStatusType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60
    }

    public class AssigneesArrayItem22
    {
        [JsonProperty("id")]
        public string AssigneeId { get; set; }

        [JsonProperty("type")]
        public AssigneesArrayItemTypeType Type { get; set; }
    }

    public class InitInspectionExportResponse
    {
        [JsonProperty("messageId")]
        public string ExportTaskId { get; set; }
    }

    public class InitiateInspectionExportInput
    {
        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InitiateInspectionExportInputExportFormatType? ExportFormat { get; set; } = InitiateInspectionExportInputExportFormatType.PDF;

        [JsonProperty("preference_id")]
        public string PreferenceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InitiateInspectionExportInputExportFormatType
    {
        PDF,
        WORD
    }

    public class InspectionExportStatusResponse
    {
        [JsonProperty("url")]
        public string ExportURL { get; set; }

        [JsonProperty("status")]
        public string ExportStatus { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Safetyculture;

    public partial class WorkflowManagedActions
    {
        public SafetycultureActions Safetyculture(string connectionId) => new SafetycultureActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SafetycultureTriggers Safetyculture(string connectionId) => new SafetycultureTriggers(connectionId);
    }
}